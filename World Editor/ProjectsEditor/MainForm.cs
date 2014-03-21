using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using World_Editor.Database;
using World_Editor.Stormlib;

namespace World_Editor.ProjectsEditor
{
    public partial class MainForm : Form
    {
        public List<Project> Projects { get; set; }
        private readonly ProjectSettings _projConf = new ProjectSettings();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Projects = new List<Project>();
            _projConf.Reload();
            if (_projConf.Projects != null)
                Projects = _projConf.Projects;

            foreach (Project p in Projects)
            {
                listProjects.Items.Add(p);
            }

            try
            {
                listProjects.SelectedIndex = 0;
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project p = new Project
            {
                Name = "Nouveau projet",
                Path = "C:\\Dossier\\SousDossier\\DossierProjet",
                WowDir = "C:\\Programmes\\World of Warcraft",
            };

            Projects.Add(p);
            listProjects.Items.Add(p);
            listProjects.SelectedIndex = listProjects.Items.Count - 1;
            _projConf.Projects = Projects;
        }

        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];

            txtProjectName.Text = p.Name;
            txtProjectPath.Text = p.Path;
            txtWowFolder.Text = p.WowDir;
            try
            {
                listCores.SelectedIndex = p.Core - 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                listCores.SelectedIndex = 0;
            }
            txtDbHost.Text = p.Host;
            txtDbDatabase.Text = p.Database;
            txtDbUser.Text = p.User;
            txtDbPassword.Text = p.Password;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];

            listProjects.Items.Remove(p);
            Projects.Remove(p);
            _projConf.Projects = Projects;
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.Name = txtProjectName.Text;
            listProjects.Items[listProjects.SelectedIndex] = p;
        }

        private void txtProjectPath_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.Path = txtProjectPath.Text;
            listProjects.Items[listProjects.SelectedIndex] = p;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            DialogResult dResult = d.ShowDialog();
            if (dResult == DialogResult.OK)
                txtProjectPath.Text = d.SelectedPath;
        }

        private void btnWowFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            DialogResult dResult = d.ShowDialog();
            if (dResult == DialogResult.OK)
                txtWowFolder.Text = d.SelectedPath;
        }

        private void txtWowFolder_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.WowDir = txtWowFolder.Text;
            listProjects.Items[listProjects.SelectedIndex] = p;
        }

        private void btnExtractDbc_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtProjectPath.Text) || !Directory.Exists(txtWowFolder.Text))
                return;

            ProjectManager.WowDirectory = txtWowFolder.Text;
            MPQArchiveLoader.Instance.Init();
            Directory.CreateDirectory(txtProjectPath.Text + "\\dbc");
            if (Directory.GetFiles(txtProjectPath.Text + "\\dbc").Any())
            {
                if (MessageBox.Show("Des fichiers sont déjà présents dans le répertoire du projet, les écraser et poursuivre ?", "Ecraser les fichiers déjà présents et poursuivre ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var file in Directory.GetFiles(txtProjectPath.Text + "\\dbc"))
                        File.Delete(file);

                    ExtractAllDbcs(txtProjectPath.Text + "\\dbc");
                }
            }
            else
            {
                ExtractAllDbcs(txtProjectPath.Text + "\\dbc");
            }
        }

        #region Liste DBCs
        private static readonly List<string> ListDbcs = new List<string>
        {
            "Achievement.dbc", 
            "Achievement_Category.dbc", 
            "Achievement_Criteria.dbc", 
            "AnimationData.dbc", 
            "AreaGroup.dbc", 
            "AreaPOI.dbc", 
            "AreaTable.dbc", 
            "AreaTrigger.dbc", 
            "AttackAnimKits.dbc", 
            "AttackAnimTypes.dbc", 
            "AuctionHouse.dbc", 
            "BankBagSlotPrices.dbc", 
            "BannedAddOns.dbc", 
            "BarberShopStyle.dbc", 
            "BattlemasterList.dbc", 
            "CameraShakes.dbc", 
            "Cfg_Categories.dbc", 
            "Cfg_Configs.dbc", 
            "CharacterFacialHairStyles.dbc", 
            "CharBaseInfo.dbc", 
            "CharHairGeosets.dbc", 
            "CharHairTextures.dbc", 
            "CharSections.dbc", 
            "CharStartOutfit.dbc", 
            "CharTitles.dbc", 
            /*"CharVariations.dbc",*/
            "ChatChannels.dbc", 
            "ChatProfanity.dbc", 
            "ChrClasses.dbc", 
            "ChrRaces.dbc", 
            "CinematicCamera.dbc", 
            "CinematicSequences.dbc", 
            "CreatureDisplayInfo.dbc", 
            "CreatureDisplayInfoExtra.dbc", 
            "CreatureFamily.dbc", 
            "CreatureModelData.dbc", 
            "CreatureMovementInfo.dbc", 
            "CreatureSoundData.dbc", 
            "CreatureSpellData.dbc", 
            "CreatureType.dbc", 
            "CurrencyCategory.dbc", 
            "CurrencyTypes.dbc", 
            "DanceMoves.dbc", 
            "DeathThudLookups.dbc", 
            "DeclinedWord.dbc", 
            "DeclinedWordCases.dbc", 
            "DestructibleModelData.dbc", 
            "DungeonEncounter.dbc", 
            "DungeonMap.dbc", 
            "DungeonMapChunk.dbc", 
            "DurabilityCosts.dbc", 
            "DurabilityQuality.dbc", 
            "Emotes.dbc", 
            "EmotesText.dbc", 
            "EmotesTextData.dbc", 
            "EmotesTextSound.dbc", 
            "EnvironmentalDamage.dbc", 
            "Exhaustion.dbc", 
            "Faction.dbc", 
            "FactionGroup.dbc", 
            "FactionTemplate.dbc", 
            "FileData.dbc", 
            "FootprintTextures.dbc", 
            "FootstepTerrainLookup.dbc", 
            "GameObjectArtKit.dbc", 
            "GameObjectDisplayInfo.dbc", 
            "GameTables.dbc", 
            "GameTips.dbc", 
            "GemProperties.dbc", 
            "GlyphProperties.dbc", 
            "GlyphSlot.dbc", 
            "GMSurveyAnswers.dbc", 
            "GMSurveyCurrentSurvey.dbc", 
            "GMSurveyQuestions.dbc", 
            "GMSurveySurveys.dbc", 
            "GMTicketCategory.dbc", 
            "GroundEffectDoodad.dbc", 
            "GroundEffectTexture.dbc", 
            "gtBarberShopCostBase.dbc", 
            "gtChanceToMeleeCrit.dbc", 
            "gtChanceToMeleeCritBase.dbc", 
            "gtChanceToSpellCrit.dbc", 
            "gtChanceToSpellCritBase.dbc", 
            "gtCombatRatings.dbc", 
            "gtNPCManaCostScaler.dbc", 
            "gtOCTClassCombatRatingScalar.dbc", 
            "gtOCTRegenHP.dbc", 
            "gtOCTRegenMP.dbc", 
            "gtRegenHPPerSpt.dbc", 
            "gtRegenMPPerSpt.dbc", 
            "HelmetGeosetVisData.dbc", 
            "HolidayDescriptions.dbc", 
            "HolidayNames.dbc", 
            "Holidays.dbc", 
            "Item.dbc", 
            "ItemBagFamily.dbc", 
            "ItemClass.dbc", 
            "ItemCondExtCosts.dbc", 
            "ItemDisplayInfo.dbc", 
            "ItemExtendedCost.dbc", 
            "ItemGroupSounds.dbc", 
            "ItemLimitCategory.dbc", 
            "ItemPetFood.dbc", 
            "ItemPurchaseGroup.dbc", 
            "ItemRandomProperties.dbc", 
            "ItemRandomSuffix.dbc", 
            "ItemSet.dbc", 
            "ItemSubClass.dbc", 
            "ItemSubClassMask.dbc", 
            "ItemVisualEffects.dbc", 
            "ItemVisuals.dbc", 
            "Languages.dbc", 
            "LanguageWords.dbc", 
            "LFGDungeonExpansion.dbc", 
            "LFGDungeonGroup.dbc", 
            "LFGDungeons.dbc", 
            "Light.dbc", 
            "LightFloatBand.dbc", 
            "LightIntBand.dbc", 
            "LightParams.dbc", 
            "LightSkybox.dbc", 
            "LiquidMaterial.dbc", 
            "LiquidType.dbc", 
            "LoadingScreens.dbc", 
            "LoadingScreenTaxiSplines.dbc", 
            "Lock.dbc", 
            "LockType.dbc", 
            "MailTemplate.dbc", 
            "Map.dbc", 
            "MapDifficulty.dbc", 
            "Material.dbc", 
            "Movie.dbc", 
            "MovieFileData.dbc", 
            "MovieVariation.dbc", 
            "NameGen.dbc", 
            "NamesProfanity.dbc", 
            "NamesReserved.dbc", 
            "NPCSounds.dbc", 
            "ObjectEffect.dbc", 
            "ObjectEffectGroup.dbc", 
            "ObjectEffectModifier.dbc", 
            "ObjectEffectPackage.dbc", 
            "ObjectEffectPackageElem.dbc", 
            "OverrideSpellData.dbc", 
            "Package.dbc", 
            "PageTextMaterial.dbc", 
            "PaperDollItemFrame.dbc", 
            "ParticleColor.dbc", 
            "PetitionType.dbc", 
            "PetPersonality.dbc", 
            "PowerDisplay.dbc", 
            "PvpDifficulty.dbc", 
            "QuestFactionReward.dbc", 
            "QuestInfo.dbc", 
            "QuestSort.dbc", 
            "QuestXP.dbc", 
            "RandPropPoints.dbc", 
            "Resistances.dbc", 
            "ScalingStatDistribution.dbc", 
            "ScalingStatValues.dbc", 
            "ScreenEffect.dbc", 
            "ServerMessages.dbc", 
            "SheatheSoundLookups.dbc", 
            "SkillCostsData.dbc", 
            "SkillLine.dbc", 
            "SkillLineAbility.dbc", 
            "SkillLineCategory.dbc", 
            "SkillRaceClassInfo.dbc", 
            "SkillTiers.dbc", 
            "SoundAmbience.dbc", 
            "SoundEmitters.dbc", 
            "SoundEntries.dbc", 
            "SoundEntriesAdvanced.dbc", 
            "SoundFilter.dbc", 
            "SoundFilterElem.dbc", 
            "SoundProviderPreferences.dbc", 
            "SoundSamplePreferences.dbc", 
            "SoundWaterType.dbc", 
            "SpamMessages.dbc", 
            "Spell.dbc", 
            "SpellCastTimes.dbc", 
            "SpellCategory.dbc", 
            "SpellChainEffects.dbc", 
            "SpellDescriptionVariables.dbc", 
            "SpellDifficulty.dbc", 
            "SpellDispelType.dbc", 
            "SpellDuration.dbc", 
            "SpellEffectCameraShakes.dbc", 
            "SpellFocusObject.dbc", 
            "SpellIcon.dbc", 
            "SpellItemEnchantment.dbc", 
            "SpellItemEnchantmentCondition.dbc", 
            "SpellMechanic.dbc", 
            "SpellMissile.dbc", 
            "SpellMissileMotion.dbc", 
            "SpellRadius.dbc", 
            "SpellRange.dbc", 
            "SpellRuneCost.dbc", 
            "SpellShapeshiftForm.dbc", 
            "SpellVisual.dbc", 
            "SpellVisualEffectName.dbc", 
            "SpellVisualKit.dbc", 
            "SpellVisualKitAreaModel.dbc", 
            "SpellVisualKitModelAttach.dbc", 
            "SpellVisualPrecastTransitions.dbc", 
            "StableSlotPrices.dbc", 
            "Startup_Strings.dbc", 
            "Stationery.dbc", 
            "StringLookups.dbc", 
            "SummonProperties.dbc", 
            "Talent.dbc", 
            "TalentTab.dbc", 
            "TaxiNodes.dbc", 
            "TaxiPath.dbc", 
            "TaxiPathNode.dbc", 
            "TeamContributionPoints.dbc", 
            "TerrainType.dbc", 
            "TerrainTypeSounds.dbc", 
            "TotemCategory.dbc", 
            "TransportAnimation.dbc", 
            "TransportPhysics.dbc", 
            "TransportRotation.dbc", 
            "UISoundLookups.dbc", 
            "UnitBlood.dbc", 
            "UnitBloodLevels.dbc", 
            "Vehicle.dbc", 
            "VehicleSeat.dbc", 
            "VehicleUIIndicator.dbc", 
            "VehicleUIIndSeat.dbc", 
            "VideoHardware.dbc", 
            "VocalUISounds.dbc", 
            "WeaponImpactSounds.dbc", 
            "WeaponSwingSounds2.dbc", 
            "Weather.dbc", 
            "WMOAreaTable.dbc", 
            "WorldChunkSounds.dbc", 
            "WorldMapArea.dbc", 
            "WorldMapContinent.dbc", 
            "WorldMapOverlay.dbc", 
            "WorldMapTransforms.dbc", 
            "WorldSafeLocs.dbc", 
            "WorldStateUI.dbc", 
            "WorldStateZoneSounds.dbc", 
            "WowError_Strings.dbc", 
            "ZoneIntroMusicTable.dbc", 
            "ZoneMusic.dbc",
        };
        #endregion

        private void ExtractAllDbcs(string outputFolder)
        {
            if (!MPQFile.Exists("DBFilesClient\\Achievement.dbc"))
            {
                MessageBox.Show("Impossible d'extraire les DBCs, vérifiez que le chemin vers votre dossier World of Warcraft est correct et que les fichiers MPQs ne soient pas déjà utilisés par un autre programme.");
                return;
            }

            bool error = false;
            foreach (string dbc in ListDbcs)
            {
                if (MPQFile.Exists("DBFilesClient\\" + dbc))
                {
                    MPQFile fileMpq = new MPQFile("DBFilesClient\\" + dbc);
                    FileStream file = File.Create(txtProjectPath.Text + "\\dbc\\" + dbc);
                    file.Write(fileMpq.Read((uint)fileMpq.Length), 0, (int)fileMpq.Length);
                    file.Close();
                    fileMpq.Close();
                    continue;
                }
                error = true;
            }

            MessageBox.Show(error
                                ? "Toutes les DBCs n'ont pas pû être extraites, vérifiez que vous possédez bien toutes les archives MPQ du jeu."
                                : "Extraction des fichiers terminés.");
        }

        private void listCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.Core = listCores.SelectedIndex + 1;
        }

        private void txtDbHost_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.Host = txtDbHost.Text;
        }

        private void txtDbDatabase_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.Database = txtDbDatabase.Text;
        }

        private void txtDbUser_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.User = txtDbUser.Text;
        }

        private void txtDbPassword_TextChanged(object sender, EventArgs e)
        {
            if (listProjects.SelectedItem == null)
                return;

            Project p = (Project)listProjects.Items[listProjects.SelectedIndex];
            p.Password = txtDbPassword.Text;
        }

        private void btnTestDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnector conn = new Database.MySqlConnector(txtDbHost.Text,
                                txtDbDatabase.Text, txtDbUser.Text, txtDbPassword.Text, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Connexion établie.", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string WowDir { get; set; }
        public bool IsLast { get; set; }
        public string Host { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Core { get; set; }

        public override string ToString()
        {
            return Name + " - " + Path;
        }
    }

    sealed class ProjectSettings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        public List<Project> Projects
        {
            get { return (List<Project>)this["Projects"]; }
            set { this["Projects"] = value; }
        }
    }

}
