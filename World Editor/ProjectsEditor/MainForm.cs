#region

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AntiBrouillard;
using World_Editor.Database;
using World_Editor.Model;
using World_Editor.Stormlib;

#endregion

namespace World_Editor.ProjectsEditor
{
    public partial class MainForm : Form
    {
        private readonly ProjectSettings _projConf = new ProjectSettings();
        private List<ProjectModel> _listProjects;

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

        public MainForm()
        {
            InitializeComponent();
        }

        public List<ProjectModel> GetProjectModels()
        {
            return _listProjects;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProjectsFromSettings();
        }

        private void listProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectModel project = GetSelectedProject();
            if (project != null)
            {
                UpdateFormFromSelectedProject(project);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InitializeNewProject();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            ProjectModel project = GetSelectedProject();

            listProjects.Items.Remove(project);
            _listProjects.Remove(project);
            _projConf.Projects = _listProjects;
        }

        private void OpenFolderBrowserWhenClick(object sender, EventArgs e)
        {
            OpenFolderBrowserWhenClick(sender);
        }

        private void btnExtractDbc_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtProjectPath.Text) || !Directory.Exists(txtWowFolder.Text))
            {
                Log.E("Le dossier WoW ou des DBCs n'existe pas !");
                return;
            }

            ProjectManager.WowDirectory = txtWowFolder.Text;
            MPQArchiveLoader.Instance.Init();
            Directory.CreateDirectory(txtProjectPath.Text + "\\dbc");
            if (Directory.GetFiles(txtProjectPath.Text + "\\dbc").Any())
            {
                if (
                    MessageBox.Show(
                        "Des fichiers sont déjà présents dans le répertoire du projet, les écraser et poursuivre ?",
                        "Ecraser les fichiers déjà présents et poursuivre ?", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    foreach (var file in Directory.GetFiles(txtProjectPath.Text + "\\dbc"))
                    {
                        Log.V("Suppression de " + file);
                        File.Delete(file);
                    }
                    ExtractAllDbcs(txtProjectPath.Text + "\\dbc");
                }
            }
            else
            {
                ExtractAllDbcs(txtProjectPath.Text + "\\dbc");
            }
        }

        private void listCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjectModel project = GetSelectedProject();
            if (project != null)
            {
                project.Core = listCores.SelectedIndex + 1;
            }
        }

        private void UpdateProjectWhenTextChanged(object sender, EventArgs e)
        {
            UpdateProjectWhenTextChanged(sender);
        }

        private void LoadProjectsFromSettings()
        {
            _listProjects = new List<ProjectModel>();
            _projConf.Reload();
            if (_projConf.Projects != null)
                _listProjects = _projConf.Projects;

            foreach (ProjectModel p in _listProjects)
            {
                listProjects.Items.Add(p);
            }

            if (listProjects.Items.Count > 0)
            {
                listProjects.SelectedIndex = 0;
            }
        }

        private void btnTestDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (TryToConnectToMysql())
                {
                    Log.I("Test de connexion MySQL OK");
                    MessageBox.Show("Connexion établie.", "Connexion réussie", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log.W("Test de connexion MySQL KO", ex);
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Echec de connexion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OpenFolderBrowserWhenClick(object sender)
        {
            FolderBrowserDialog d = new FolderBrowserDialog();
            DialogResult dResult = d.ShowDialog();

            if (sender == btnBrowse)
            {
                if (dResult == DialogResult.OK)
                {
                    txtProjectPath.Text = d.SelectedPath;
                }
            }
            else if (sender == btnWowFolder)
            {
                if (dResult == DialogResult.OK)
                {
                    txtWowFolder.Text = d.SelectedPath;
                }
            }
        }

        private void InitializeNewProject()
        {
            ProjectModel newProject = CreateDefaultProject();

            _listProjects.Add(newProject);
            listProjects.Items.Add(newProject);
            listProjects.SelectedIndex = listProjects.Items.Count - 1;
            _projConf.Projects = _listProjects;
        }

        private ProjectModel CreateDefaultProject()
        {
            return new ProjectModel
            {
                Name = "Nouveau projet",
                Path = "C:\\Dossier\\SousDossier\\DossierProjet",
                WowDir = "C:\\Programmes\\World of Warcraft",
            };
        }

        private void UpdateFormFromSelectedProject(ProjectModel project)
        {
            txtProjectName.Text = project.Name;
            txtProjectPath.Text = project.Path;
            txtWowFolder.Text = project.WowDir;
            try
            {
                if (listCores.Items.Count > project.Core)
                {
                    listCores.SelectedIndex = project.Core - 1;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                listCores.SelectedIndex = 0;
            }
            txtDbHost.Text = project.Host;
            txtDbDatabase.Text = project.Database;
            txtDbUser.Text = project.User;
            txtDbPassword.Text = project.Password;
        }

        private void ExtractAllDbcs(string outputFolder)
        {
            if (!MPQFile.Exists("DBFilesClient\\Achievement.dbc"))
            {
                Log.E("Impossible d'atteindre les DBCs");
                MessageBox.Show(
                    "Impossible d'extraire les DBCs, vérifiez que le chemin vers votre dossier World of Warcraft est correct et que les fichiers MPQs ne soient pas déjà utilisés par un autre programme.");
                return;
            }

            bool error = false;
            foreach (string dbc in ListDbcs)
            {
                if (MPQFile.Exists("DBFilesClient\\" + dbc))
                {
                    MPQFile fileMpq = new MPQFile("DBFilesClient\\" + dbc);
                    FileStream file = File.Create(outputFolder + "\\" + dbc);
                    Log.V("Extraction de " + dbc + " (" + fileMpq.Length + ")");
                    file.Write(fileMpq.Read((uint)fileMpq.Length), 0, (int)fileMpq.Length);
                    file.Close();
                    fileMpq.Close();
                }
                else
                {
                    Log.I("Impossible d'extraire " + dbc);
                    error = true;
                }
            }

            MessageBox.Show(error
                ? "Toutes les DBCs n'ont pas pû être extraites, vérifiez que vous possédez bien toutes les archives MPQ du jeu."
                : "Extraction des fichiers terminés.");
        }

        private void UpdateProjectWhenTextChanged(object sender)
        {
            ProjectModel selectedProject = GetSelectedProject();
            if (selectedProject != null)
            {
                if (sender == txtDbUser)
                {
                    selectedProject.User = txtDbUser.Text;
                }
                else if (sender == txtDbPassword)
                {
                    selectedProject.Password = txtDbPassword.Text;
                }
                else if (sender == txtDbDatabase)
                {
                    selectedProject.Database = txtDbDatabase.Text;
                }
                else if (sender == txtDbHost)
                {
                    selectedProject.Host = txtDbHost.Text;
                }
                else if (sender == txtProjectName)
                {
                    selectedProject.Name = txtProjectName.Text;
                    UpdateDisplayProjectInList(selectedProject);
                }
                else if (sender == txtProjectPath)
                {
                    selectedProject.Path = txtProjectPath.Text;
                    UpdateDisplayProjectInList(selectedProject);
                }
                else if (sender == txtWowFolder)
                {
                    selectedProject.WowDir = txtWowFolder.Text;
                }
            }
        }

        private void UpdateDisplayProjectInList(ProjectModel project)
        {
            listProjects.Items[listProjects.SelectedIndex] = project;
        }

        private ProjectModel GetSelectedProject()
        {
            ProjectModel project = null;

            if (listProjects.SelectedItem != null)
            {
                project = listProjects.SelectedItem as ProjectModel;
            }

            return project;
        }

        private Boolean TryToConnectToMysql()
        {
            try
            {
                MySqlConnector conn = new MySqlConnector(txtDbHost.Text, txtDbDatabase.Text, txtDbUser.Text,
                    txtDbPassword.Text, null);
            }
            catch (Exception ex)
            {
                Log.E(ex);
                throw;
            }
            return true;
        }
    }

    internal sealed class ProjectSettings : ApplicationSettingsBase
    {
        [UserScopedSetting]
        public List<ProjectModel> Projects
        {
            get { return (List<ProjectModel>)this["Projects"]; }
            set { this["Projects"] = value; }
        }
    }
}