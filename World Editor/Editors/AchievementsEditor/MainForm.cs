using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AntiBrouillard;
using DBCLib.Structures335;
using World_Editor.DBC;
using World_Editor.Dialogs;

namespace World_Editor.Editors.AchievementsEditor
{
    public partial class MainForm : EditorForm
    {
        private const int DefaultGeneralCategoryId = 92;
        private readonly Regex _typeOfNodeRegex = new Regex(@"^([ac])([\d]+)$");

        #region Enums

        enum AchievementFlags
        {
            FLAG_COUNTER = 1,               // Just count statistic (never stop and complete)
            FLAG_HIDDEN = 2,                // Not sent to client - internal use only
            FLAG_STORE_MAX_VALUE = 4,       // Store only max value? used only in "Reach level xx"
            FLAG_CUMULATIVE = 8,            // Use summ criteria value from all requirements (and calculate max value)
            FLAG_DISPLAY_HIGHEST = 16,      // Show max criteria (and calculate max value ??)
            FLAG_CRITERIA_COUNT = 32,       // Use not zero req count (and calculate max value)
            FLAG_AVG_PER_DAY = 64,          // Show as average value (value / time_in_days) depend from other flag (by def use last criteria value)
            FLAG_HAS_PROGRESS_BAR = 128,    // Show as progress bar (value / max vale) depend from other flag (by def use last criteria value)
            FLAG_REALM_FIRST_REACH = 256,   //
            FLAG_REALM_FIRST_KILL = 512     //
        }

        // /!\ Flags non cumulables
        enum AchievementCriteriaCondition
        {
            CONDITION_NONE = 0,
            CONDITION_NO_DEATH = 1,         // reset progress on death
            CONDITION_UNK2 = 2,             // only used in "Complete a daily quest every day for five consecutive days"
            CONDITION_BG_MAP = 3,           // requires you to be on specific map, reset at change
            CONDITION_NO_LOSE = 4,          // only used in "Win 10 arenas without losing"
            CONDITION_NO_SPELL_HIT = 9,     // requires the player not to be hit by specific spell
            CONDITION_NOT_IN_GROUP = 10,    // requires the player not to be in group
            CONDITION_UNK13 = 13            // unk
        }

        enum AchievementCriteriaFlags
        {
            FLAG_SHOW_PROGRESS_BAR = 1,     // Show progress as bar
            FLAG_HIDDEN = 2,                // Not show criteria in client
            FLAG_FAIL_ACHIEVEMENT = 4,      // BG related??
            FLAG_RESET_ON_START = 8,        //
            FLAG_IS_DATE = 16,              // not used
            FLAG_MONEY_COUNTER = 32,        // Displays counter as money
            FLAG_IS_ACHIEVEMENT_ID = 64,
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadSubCat(int id = -1)
        {
            foreach (AchievementCategoryEntry c in DBCStores.AchievementCategory.Records.Where(c => c.ParentCategory == id))
            {
                if (id == -1)
                {
                    treeAchievements.Nodes.Add("c" + c.Id, c.Name);
                    LoadSubCat((int)c.Id);
                    foreach (AchievementEntry a in DBCStores.Achievement.Records.Where(ta => ta.CategoryId == c.Id).OrderBy(ta => ta.OrderInCategory))
                        treeAchievements.Nodes["c" + c.Id].Nodes.Add("a" + a.Id, a.Name);
                }
                else
                {
                    TreeNode parent = treeAchievements.Nodes.Find("c" + c.ParentCategory, true).First();
                    parent.Nodes.Add("c" + c.Id, c.Name);
                    LoadSubCat((int)c.Id);
                    foreach (AchievementEntry a in DBCStores.Achievement.Records.Where(ta => ta.CategoryId == c.Id).OrderBy(ta => ta.OrderInCategory))
                        parent.Nodes["c" + c.Id].Nodes.Add("a" + a.Id, a.Name);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DBCStores.LoadAchievementsEditor();

            int start = Environment.TickCount;

            LoadSubCat();

            int end = Environment.TickCount;
            lblTimeRender.Text = (end - start) + " ms";

            Criterias.Init();
            listCriteriaType.Items.Clear();
            listCriteriaType.Items.AddRange(Criterias.GetCriterias().Values.ToArray());

            listMap.Items.Clear();
            listMap.Items.Add("None");
            listMap.Items.AddRange(DBCStores.Map.Records.ToArray());
        }

        private void treeAchievements_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            Match m = _typeOfNodeRegex.Match(treeAchievements.SelectedNode.Name);
            string categoryOrAchievementNode = m.Groups[1].Value;
            uint categoryOrAchievementId = UInt32.Parse(m.Groups[2].Value);

            switch (categoryOrAchievementNode)
            {
                case "a":
                    UpdateAchievement(categoryOrAchievementId);
                    break;
                case "c":
                    UpdateCategory(categoryOrAchievementId);
                    break;
                default:
                    Log.W("Impossible de déterminer le node");
                    break;
            }
        }

        private void UpdateAchievement(uint achievementId)
        {
            tabAchievement.TabPages[0].Enabled = true;
            tabAchievement.TabPages[1].Enabled = false;
            tabAchievement.SelectedIndex = 0;
            AchievementEntry a = DBCStores.Achievement[achievementId];
            panelRenderAchievement.SetAchievement(a);

            txtId.Text = a.Id.ToString();
            listFaction.SelectedIndex = a.FactionFlag + 1;
            txtMap.Text = a.MapId.ToString();
            txtName.Text = a.Name;
            txtDescription.Text = a.Description;
            txtParentAchievement.Text = a.ParentAchievement.ToString();
            txtPoints.Text = a.Points.ToString();
            txtOrder.Text = a.OrderInCategory.ToString();
            txtFlags.Text = a.Flags.ToString();
            txtIcon.Text = a.Icon.ToString();
            txtReward.Text = a.TitleReward;
            txtCategory.Text = a.CategoryId.ToString();
            txtCount.Text = a.Count.ToString();
            txtAchievementRef.Text = a.RefAchievement.ToString();

            listCriterias.Items.Clear();
            listCriterias.Items.AddRange(DBCStores.AchievementCriteria.Records.Where(c => c.ReferredAchievement == a.Id).ToArray());
            if (listCriterias.Items.Count > 0)
                listCriterias.SelectedIndex = 0;
        }

        private void UpdateCategory(uint categoryId)
        {
            tabAchievement.TabPages[0].Enabled = false;
            tabAchievement.TabPages[1].Enabled = true;
            tabAchievement.SelectedIndex = 1;
            
            AchievementCategoryEntry c = DBCStores.AchievementCategory[categoryId];

            txtCatId.Text = c.Id.ToString();
            txtCatParentId.Text = c.ParentCategory.ToString();
            txtCatName.Text = c.Name;
            txtCatOrder.Text = c.SortOrder.ToString();
        }

        private void listCriterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            AchievementCriteriaEntry c = (AchievementCriteriaEntry)listCriterias.SelectedItem;
            txtCriteriaId.Text = c.Id.ToString();
            txtCriteriaAchievement.Text = c.ReferredAchievement.ToString();
            listCriteriaType.SelectedItem = Criterias.GetCriterias()[c.RequiredType];

            txtReqType0.Text = c.ReqType0.ToString();
            txtReqValue0.Text = c.ReqValue0.ToString();
            txtReqType1.Text = c.ReqType1.ToString();
            txtReqValue1.Text = c.ReqValue1.ToString();
            txtReqType2.Text = c.ReqType2.ToString();
            txtReqValue2.Text = c.ReqValue2.ToString();

            txtCriteriaFlags.Text = c.Flags.ToString();
            txtCriteriaName.Text = c.Name;
            txtTimerStartEvent.Text = c.TimerStartEvent.ToString();
            txtTimeLimit.Text = c.TimeLimit.ToString();
            txtCriteriaOrder.Text = c.ShowOrder.ToString();
            txtTimedType.Text = c.TimedType.ToString();
        }

        private void btnReconstructTree_Click(object sender, EventArgs e)
        {
            string nodeName = null;
            if (treeAchievements.SelectedNode != null)
                nodeName = treeAchievements.SelectedNode.Name;

            treeAchievements.Nodes.Clear();
            LoadSubCat();

            if (nodeName != null)
                treeAchievements.SelectedNode = treeAchievements.Nodes.Find(nodeName, true).First();
        }

        #region TextChanged Category
        private void txtCatParentId_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            if (DBCStores.AchievementCategory.ContainsKey(Misc.ParseToUInt(txtCatParentId.Text)))
                lblCatParentId.Text = DBCStores.AchievementCategory[Misc.ParseToUInt(txtCatParentId.Text)].Name;
            else
                lblCatParentId.Text = "None";

            DBCStores.AchievementCategory[Misc.ParseToUInt(txtCatId.Text)].ParentCategory = Misc.ParseToInt(txtCatParentId.Text);
        }

        private void txtCatName_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            DBCStores.AchievementCategory[Misc.ParseToUInt(txtCatId.Text)].Name = txtCatName.Text;

            treeAchievements.Nodes.Find("c" + txtCatId.Text, true).First().Text = txtCatName.Text;
        }

        private void txtCatOrder_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            DBCStores.AchievementCategory[Misc.ParseToUInt(txtCatId.Text)].SortOrder = Misc.ParseToUInt(txtCatOrder.Text);
        }
        #endregion

        #region TextChanged Achievement
        private void listFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a")) &&
                !DBCStores.Achievement.ContainsKey(Misc.ParseToUInt(txtId.Text)))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].FactionFlag = listFaction.SelectedIndex - 1;
        }

        private void txtMap_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            if (Misc.ParseToInt(txtMap.Text) == -1 || !DBCStores.Map.ContainsKey(Misc.ParseToUInt(txtMap.Text)))
                listMap.SelectedIndex = 0;
            else
                listMap.SelectedItem = DBCStores.Map[Misc.ParseToUInt(txtMap.Text)];

            AchievementEntry a = DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)];
            a.MapId = Misc.ParseToInt(txtMap.Text);
        }

        private void listMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            if (listMap.SelectedItem == null)
                return;

            if (listMap.SelectedIndex == 0)
            {
                txtMap.Text = "-1";
                return;
            }

            MapEntry m = (MapEntry)listMap.SelectedItem;
            txtMap.Text = m.ID.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            treeAchievements.Nodes.Find("a" + txtId.Text, true).First().Text = txtName.Text;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Name = txtName.Text;

            panelRenderAchievement.Invalidate();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Description = txtDescription.Text;
        }

        private void txtParentAchievement_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].ParentAchievement = Misc.ParseToUInt(txtParentAchievement.Text);
        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Points = Misc.ParseToUInt(txtPoints.Text);

            panelRenderAchievement.Invalidate();
        }

        private void txtOrder_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].OrderInCategory = Misc.ParseToUInt(txtOrder.Text);
        }

        private void txtFlags_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Flags = Misc.ParseToUInt(txtFlags.Text);
        }

        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Icon = Misc.ParseToUInt(txtIcon.Text);

            panelRenderAchievement.Invalidate();
        }

        private void txtReward_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Icon = Misc.ParseToUInt(txtIcon.Text);
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;
            if (DBCStores.AchievementCategory.ContainsKey(Misc.ParseToUInt(txtCategory.Text)))
                DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].CategoryId = Misc.ParseToUInt(txtCategory.Text);
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].Count = Misc.ParseToUInt(txtCount.Text);
        }

        private void txtAchievementRef_TextChanged(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            DBCStores.Achievement[Misc.ParseToUInt(txtId.Text)].RefAchievement = Misc.ParseToUInt(txtAchievementRef.Text);
        }
        #endregion

        #region TextChanged Criteria
        private void txtCriteriaFlags_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].Flags = Misc.ParseToUInt(txtCriteriaFlags.Text);
        }

        private void listCriteriaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCriteriaType.SelectedItem == null || listCriterias.SelectedItem == null)
                return;

            Criteria c = (Criteria)listCriteriaType.SelectedItem;
            lblReqType0.Text = "Unused";
            lblReqType1.Text = "Unused";
            lblReqType2.Text = "Unused";
            lblReqValue0.Text = "Unused";
            lblReqValue1.Text = "Unused";
            lblReqValue2.Text = "Unused";
            txtReqType0.Enabled = false;
            txtReqValue0.Enabled = false;
            txtReqType1.Enabled = false;
            txtReqValue1.Enabled = false;
            txtReqType2.Enabled = false;
            txtReqValue2.Enabled = false;

            if (c.ReqType0 != null)
            {
                lblReqType0.Text = c.ReqType0;
                txtReqType0.Enabled = true;
            }

            if (c.ReqValue0 != null)
            {
                lblReqValue0.Text = c.ReqValue0;
                txtReqValue0.Enabled = true;
            }

            if (c.ReqType1 != null)
            {
                lblReqType1.Text = c.ReqType1;
                txtReqType1.Enabled = true;
            }

            if (c.ReqValue1 != null)
            {
                lblReqValue1.Text = c.ReqValue1;
                txtReqValue1.Enabled = true;
            }

            if (c.ReqType2 != null)
            {
                lblReqType2.Text = c.ReqType2;
                txtReqType2.Enabled = true;
            }

            if (c.ReqValue2 != null)
            {
                lblReqValue2.Text = c.ReqValue2;
                txtReqValue2.Enabled = true;
            }

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].RequiredType = c.TypeId;
        }

        private void txtCriteriaName_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].Name = txtCriteriaName.Text;

            listCriterias.Items[listCriterias.SelectedIndex] = DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)];
        }

        private void txtTimerStartEvent_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].TimerStartEvent = Misc.ParseToUInt(txtTimerStartEvent.Text);
        }

        private void txtTimeLimit_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].TimeLimit = Misc.ParseToUInt(txtTimeLimit.Text);
        }

        private void txtCriteriaOrder_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ShowOrder = Misc.ParseToUInt(txtCriteriaOrder.Text);
        }

        private void txtTimedType_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].TimedType = Misc.ParseToUInt(txtTimedType.Text);
        }

        private void txtReqType0_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqType0 = Misc.ParseToUInt(txtReqType0.Text);
        }

        private void txtReqType1_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqType1 = Misc.ParseToUInt(txtReqType1.Text);
        }

        private void txtReqType2_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqType2 = Misc.ParseToUInt(txtReqType2.Text);
        }

        private void txtReqValue0_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqValue0 = Misc.ParseToUInt(txtReqValue0.Text);
        }

        private void txtReqValue1_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqValue1 = Misc.ParseToUInt(txtReqValue1.Text);
        }

        private void txtReqValue2_TextChanged(object sender, EventArgs e)
        {
            if (listCriterias.SelectedItem == null)
                return;

            DBCStores.AchievementCriteria[Misc.ParseToUInt(txtCriteriaId.Text)].ReqValue2 = Misc.ParseToUInt(txtReqValue2.Text);
        }
        #endregion

        #region Buttons
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBCStores.SaveAchievementsEditor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la sauvegarde : " + ex.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null)
                return;

            if (treeAchievements.SelectedNode.Name == "c" + DefaultGeneralCategoryId)
            {
                MessageBox.Show("Vous ne pouvez pas supprimer cette catégorie !");
                return;
            }

            if (treeAchievements.SelectedNode.Name.Contains("a"))
            {
                DBCStores.Achievement.TryRemoveEntry(Misc.ParseToUInt(txtId.Text));
            }
            else if (treeAchievements.SelectedNode.Name.Contains("c"))
            {
                uint categoryId = Misc.ParseToUInt(txtCatId.Text);
                if (DBCStores.AchievementCategory.ContainsKey(categoryId))
                {
                    if (MessageBox.Show("Toutes les sous-catégories et haut-faits seront déplacés dans la catégorie Général", "Confirmer la suppression", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        foreach (AchievementCategoryEntry c in DBCStores.AchievementCategory.Records.Where(cp => cp.ParentCategory == categoryId))
                            c.ParentCategory = DefaultGeneralCategoryId;
                        foreach (AchievementEntry a in DBCStores.Achievement.Records.Where(ap => ap.CategoryId == categoryId))
                            a.CategoryId = DefaultGeneralCategoryId;
                        DBCStores.AchievementCategory.RemoveEntry(categoryId);
                    }
                }
            }

            treeAchievements.Nodes.Clear();
            LoadSubCat();
        }

        private void btnCatAdd_Click(object sender, EventArgs e)
        {
            AchievementCategoryEntry c = new AchievementCategoryEntry
            {
                Id = DBCStores.AchievementCategory.MaxKey + 1,
                ParentCategory = -1,
                Name = "Nouvelle catégorie",
                SortOrder = DBCStores.AchievementCategory.Records.Where(cp => cp.ParentCategory == -1).Max(cp => cp.SortOrder) + 1,
            };

            DBCStores.AchievementCategory.AddEntry(c.Id, c);

            treeAchievements.Nodes.Clear();
            LoadSubCat();

            treeAchievements.SelectedNode = treeAchievements.Nodes.Find("c" + c.Id, true).First();
        }

        private void btnAchAdd_Click(object sender, EventArgs e)
        {
            AchievementEntry a = new AchievementEntry
            {
                Id = DBCStores.Achievement.MaxKey + 1,
                FactionFlag = -1,
                MapId = -1,
                Name = "Nouveau haut-fait",
                Description = "",
                CategoryId = DefaultGeneralCategoryId,
                TitleReward = "",
            };

            DBCStores.Achievement.AddEntry(a.Id, a);

            treeAchievements.Nodes.Clear();
            LoadSubCat();

            treeAchievements.SelectedNode = treeAchievements.Nodes.Find("a" + a.Id, true).First();
        }

        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a"))
                return;

            uint refAchiev = Misc.ParseToUInt(txtId.Text);

            AchievementCriteriaEntry c = new AchievementCriteriaEntry
            {
                Id = DBCStores.AchievementCriteria.MaxKey + 1,
                ReferredAchievement = refAchiev,
                Name = "Nouveau critère",
            };

            DBCStores.AchievementCriteria.AddEntry(c.Id, c);

            listCriterias.Items.Clear();
            listCriterias.Items.AddRange(DBCStores.AchievementCriteria.Records.Where(cp => cp.ReferredAchievement == refAchiev).ToArray());
            if (listCriterias.Items.Count > 0)
                listCriterias.SelectedIndex = listCriterias.Items.Count - 1;
        }

        private void btnRmvCriteria_Click(object sender, EventArgs e)
        {
            if (treeAchievements.SelectedNode == null ||
                !treeAchievements.SelectedNode.Name.Contains("a") ||
                listCriterias.SelectedItem == null)
                return;

            AchievementCriteriaEntry c = (AchievementCriteriaEntry)listCriterias.SelectedItem;

            DBCStores.AchievementCriteria.RemoveEntry(c.Id);
            listCriterias.Items.Remove(c);
            if (listCriterias.Items.Count > 0)
                listCriterias.SelectedIndex = 0;
        }

        private void btnFlags_Click(object sender, EventArgs e)
        {
            FlagDialog d = new FlagDialog(typeof(AchievementFlags), Misc.ParseToUInt(txtFlags.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtFlags.Text = d.Bitmask.ToString();
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            SpellIconDialog d = new SpellIconDialog(Misc.ParseToUInt(txtIcon.Text));
            d.ShowDialog();
            if (d.DialogResult == DialogResult.OK)
                txtIcon.Text = d.choosenIcon.ToString();
        }
        #endregion

        private void tabAchievement_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !e.TabPage.Enabled;
        }

    }
}
