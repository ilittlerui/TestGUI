namespace ZGWUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripPortSettings = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxBindTargetExtAddr = new System.Windows.Forms.TextBox();
            this.textBoxUserSetReqDescription = new System.Windows.Forms.TextBox();
            this.textBoxUserSetReqAddr = new System.Windows.Forms.TextBox();
            this.buttonUserSetReq = new System.Windows.Forms.Button();
            this.textBoxUserReqAddr = new System.Windows.Forms.TextBox();
            this.buttonUserReq = new System.Windows.Forms.Button();
            this.textBoxRestoreNwkFrameCounter = new System.Windows.Forms.TextBox();
            this.comboBoxLeaveChildren = new System.Windows.Forms.ComboBox();
            this.comboBoxLeaveReJoin = new System.Windows.Forms.ComboBox();
            this.textBoxLeaveAddr = new System.Windows.Forms.TextBox();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.textBoxRemoveChildAddr = new System.Windows.Forms.TextBox();
            this.textBoxRemoveParentAddr = new System.Windows.Forms.TextBox();
            this.buttonRemoveDevice = new System.Windows.Forms.Button();
            this.buttonPermitJoinState = new System.Windows.Forms.Button();
            this.buttonRestoreNwk = new System.Windows.Forms.Button();
            this.buttonRecoverNwk = new System.Windows.Forms.Button();
            this.comboBoxMgmtLeaveChildren = new System.Windows.Forms.ComboBox();
            this.comboBoxMgmtLeaveReJoin = new System.Windows.Forms.ComboBox();
            this.textBoxMgmtLeaveExtAddr = new System.Windows.Forms.TextBox();
            this.textBoxMgmtLeaveAddr = new System.Windows.Forms.TextBox();
            this.buttonMgmtLeave = new System.Windows.Forms.Button();
            this.textBoxUnBindDestEP = new System.Windows.Forms.TextBox();
            this.textBoxUnBindDestAddr = new System.Windows.Forms.TextBox();
            this.comboBoxUnBindAddrMode = new System.Windows.Forms.ComboBox();
            this.textBoxUnBindClusterID = new System.Windows.Forms.TextBox();
            this.textBoxUnBindTargetEP = new System.Windows.Forms.TextBox();
            this.textBoxUnBindTargetExtAddr = new System.Windows.Forms.TextBox();
            this.buttonUnBind = new System.Windows.Forms.Button();
            this.textBoxBindDestEP = new System.Windows.Forms.TextBox();
            this.textBoxBindDestAddr = new System.Windows.Forms.TextBox();
            this.comboBoxBindAddrMode = new System.Windows.Forms.ComboBox();
            this.textBoxBindClusterID = new System.Windows.Forms.TextBox();
            this.textBoxBindTargetEP = new System.Windows.Forms.TextBox();
            this.textBoxLqiReqStartIndex = new System.Windows.Forms.TextBox();
            this.textBoxLqiReqTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonMgmtLqiReq = new System.Windows.Forms.Button();
            this.buttonStartScan = new System.Windows.Forms.Button();
            this.textBoxNwkAddrReqStartIndex = new System.Windows.Forms.TextBox();
            this.comboBoxNwkAddrReqType = new System.Windows.Forms.ComboBox();
            this.textBoxNwkAddrReqExtAddr = new System.Windows.Forms.TextBox();
            this.textBoxNwkAddrReqTargetAddr = new System.Windows.Forms.TextBox();
            this.textBoxIeeeReqStartIndex = new System.Windows.Forms.TextBox();
            this.comboBoxIeeeReqType = new System.Windows.Forms.ComboBox();
            this.textBoxIeeeReqAddr = new System.Windows.Forms.TextBox();
            this.textBoxIeeeReqTargetAddr = new System.Windows.Forms.TextBox();
            this.textBoxComplexReqAddr = new System.Windows.Forms.TextBox();
            this.buttonComplexReq = new System.Windows.Forms.Button();
            this.textBoxMatchReqOutputClusters = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqInputClusters = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqProfileID = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqNbrOutputClusters = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqNbrInputClusters = new System.Windows.Forms.TextBox();
            this.textBoxMatchReqAddr = new System.Windows.Forms.TextBox();
            this.textBoxActiveEpAddr = new System.Windows.Forms.TextBox();
            this.textBoxPowerReqAddr = new System.Windows.Forms.TextBox();
            this.textBoxSimpleReqEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxSimpleReqAddr = new System.Windows.Forms.TextBox();
            this.buttonMatchReq = new System.Windows.Forms.Button();
            this.buttonActiveEpReq = new System.Windows.Forms.Button();
            this.buttonPowerDescReq = new System.Windows.Forms.Button();
            this.buttonSimpleDescReq = new System.Windows.Forms.Button();
            this.textBoxNodeDescReq = new System.Windows.Forms.TextBox();
            this.buttonNodeDescReq = new System.Windows.Forms.Button();
            this.buttonIeeeAddrReq = new System.Windows.Forms.Button();
            this.buttonNwkAddrReq = new System.Windows.Forms.Button();
            this.comboBoxSecurityKey = new System.Windows.Forms.ComboBox();
            this.comboBoxPermitJoinTCsignificance = new System.Windows.Forms.ComboBox();
            this.textBoxPermitJoinInterval = new System.Windows.Forms.TextBox();
            this.textBoxPermitJoinAddr = new System.Windows.Forms.TextBox();
            this.buttonPermitJoin = new System.Windows.Forms.Button();
            this.comboBoxSetKeyType = new System.Windows.Forms.ComboBox();
            this.comboBoxSetKeyState = new System.Windows.Forms.ComboBox();
            this.comboBoxSetType = new System.Windows.Forms.ComboBox();
            this.buttonStartNWK = new System.Windows.Forms.Button();
            this.buttonBind = new System.Windows.Forms.Button();
            this.buttonErasePD = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxSetSecurityKeySeqNbr = new System.Windows.Forms.TextBox();
            this.buttonSetDeviceType = new System.Windows.Forms.Button();
            this.buttonSetSecurity = new System.Windows.Forms.Button();
            this.textBoxSetEPID = new System.Windows.Forms.TextBox();
            this.textBoxSetCMSK = new System.Windows.Forms.TextBox();
            this.buttonSetCMSK = new System.Windows.Forms.Button();
            this.buttonSetEPID = new System.Windows.Forms.Button();
            this.buttonGetVersion = new System.Windows.Forms.Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.textBoxDiscoverAttributesStartAttrId = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsProfileID = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsSecurityMode = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsRadius = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsData = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsClusterID = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsDstEP = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxRawDataCommandsTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxRawDataCommandsAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonRawDataSend = new System.Windows.Forms.Button();
            this.textBoxMgmtNwkUpdateNwkManagerAddr = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverCommandsRxGen = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscoverAttributesExtended = new System.Windows.Forms.ComboBox();
            this.textBoxDiscoverCommandsMaxCommands = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverCommandsManuID = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverCommandsManuSpecific = new System.Windows.Forms.ComboBox();
            this.textBoxDiscoverCommandsCommandID = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverCommandsDirection = new System.Windows.Forms.ComboBox();
            this.textBoxDiscoverCommandsClusterID = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverCommandsDstEP = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverCommandsSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverCommandsTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverCommandsAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonDiscoverCommands = new System.Windows.Forms.Button();
            this.textBoxMgmtNwkUpdateScanCount = new System.Windows.Forms.TextBox();
            this.textBoxMgmtNwkUpdateScanDuration = new System.Windows.Forms.TextBox();
            this.textBoxMgmtNwkUpdateChannelMask = new System.Windows.Forms.TextBox();
            this.textBoxMgmtNwkUpdateTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxMgmtNwkUpdateAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonMgmtNwkUpdate = new System.Windows.Forms.Button();
            this.comboBoxManyToOneRouteRequestCacheRoute = new System.Windows.Forms.ComboBox();
            this.textBoxManyToOneRouteRequesRadius = new System.Windows.Forms.TextBox();
            this.buttonManyToOneRouteRequest = new System.Windows.Forms.Button();
            this.comboBoxReadReportConfigDirection = new System.Windows.Forms.ComboBox();
            this.comboBoxReadReportConfigDirIsRx = new System.Windows.Forms.ComboBox();
            this.textBoxReadReportConfigAttribID = new System.Windows.Forms.TextBox();
            this.textBoxReadReportConfigClusterID = new System.Windows.Forms.TextBox();
            this.textBoxReadReportConfigDstEP = new System.Windows.Forms.TextBox();
            this.textBoxReadReportConfigSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxReadReportConfigTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxReadReportConfigAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonReadReportConfig = new System.Windows.Forms.Button();
            this.textBoxWriteAttribManuID = new System.Windows.Forms.TextBox();
            this.comboBoxWriteAttribManuSpecific = new System.Windows.Forms.ComboBox();
            this.textBoxReadAttribManuID = new System.Windows.Forms.TextBox();
            this.comboBoxReadAttribManuSpecific = new System.Windows.Forms.ComboBox();
            this.textBoxWriteAttribDataType = new System.Windows.Forms.TextBox();
            this.comboBoxConfigReportAddrMode = new System.Windows.Forms.ComboBox();
            this.textBoxWriteAttribData = new System.Windows.Forms.TextBox();
            this.textBoxWriteAttribID = new System.Windows.Forms.TextBox();
            this.comboBoxWriteAttribDirection = new System.Windows.Forms.ComboBox();
            this.textBoxWriteAttribClusterID = new System.Windows.Forms.TextBox();
            this.textBoxWriteAttribDstEP = new System.Windows.Forms.TextBox();
            this.textBoxWriteAttribSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxWriteAttribTargetAddr = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportChange = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportTimeOut = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportMaxInterval = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverAttributesMaxIDs = new System.Windows.Forms.TextBox();
            this.comboBoxDiscoverAttributesDirection = new System.Windows.Forms.ComboBox();
            this.textBoxDiscoverAttributesClusterID = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverAttributesDstEp = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverAttributesSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxDiscoverAttributesAddr = new System.Windows.Forms.TextBox();
            this.buttonDiscoverAttributes = new System.Windows.Forms.Button();
            this.comboBoxReadAllAttribDirection = new System.Windows.Forms.ComboBox();
            this.textBoxReadAllAttribClusterID = new System.Windows.Forms.TextBox();
            this.textBoxReadAllAttribDstEP = new System.Windows.Forms.TextBox();
            this.textBoxReadAllAttribSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxReadAllAttribAddr = new System.Windows.Forms.TextBox();
            this.buttonReadAllAttrib = new System.Windows.Forms.Button();
            this.comboBoxConfigReportAttribDirection = new System.Windows.Forms.ComboBox();
            this.textBoxConfigReportAttribType = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportMinInterval = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportAttribID = new System.Windows.Forms.TextBox();
            this.comboBoxConfigReportDirection = new System.Windows.Forms.ComboBox();
            this.textBoxConfigReportClusterID = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportDstEP = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxConfigReportTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonConfigReport = new System.Windows.Forms.Button();
            this.buttonWriteAttrib = new System.Windows.Forms.Button();
            this.textBoxReadAttribCount = new System.Windows.Forms.TextBox();
            this.comboBoxReadAttribDirection = new System.Windows.Forms.ComboBox();
            this.textBoxReadAttribID1 = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribClusterID = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribDstEP = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxReadAttribTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonReadAttrib = new System.Windows.Forms.Button();
            this.AHIControl = new System.Windows.Forms.TabPage();
            this.labelUnimplemented = new System.Windows.Forms.Label();
            this.comboBoxIPNConfigTimerId = new System.Windows.Forms.ComboBox();
            this.textBoxIPNConfigDioTxConfInDioMask = new System.Windows.Forms.TextBox();
            this.textBoxDioSetOutputOffPinMask = new System.Windows.Forms.TextBox();
            this.textBoxDioSetOutputOnPinMask = new System.Windows.Forms.TextBox();
            this.buttonDioSetOutput = new System.Windows.Forms.Button();
            this.textBoxDioSetDirectionOutputPinMask = new System.Windows.Forms.TextBox();
            this.textBoxDioSetDirectionInputPinMask = new System.Windows.Forms.TextBox();
            this.buttonDioSetDirection = new System.Windows.Forms.Button();
            this.textBoxIPNConfigPollPeriod = new System.Windows.Forms.TextBox();
            this.comboBoxIPNConfigRegisterCallback = new System.Windows.Forms.ComboBox();
            this.textBoxIPNConfigDioStatusOutDioMask = new System.Windows.Forms.TextBox();
            this.textBoxIPNConfigDioRfActiveOutDioMask = new System.Windows.Forms.TextBox();
            this.comboBoxIPNConfigEnable = new System.Windows.Forms.ComboBox();
            this.buttonInPacketNotification = new System.Windows.Forms.Button();
            this.BasicClusterTab = new System.Windows.Forms.TabPage();
            this.textBoxBasicResetDstEP = new System.Windows.Forms.TextBox();
            this.textBoxBasicResetSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxBasicResetTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxBasicResetTargetAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonBasicReset = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.textBoxGroupAddIfIdentifyGroupID = new System.Windows.Forms.TextBox();
            this.textBoxGroupAddIfIdentifySrcEp = new System.Windows.Forms.TextBox();
            this.textBoxGroupAddIfIdentifyDstEp = new System.Windows.Forms.TextBox();
            this.textBoxGroupAddIfIndentifyingTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonGroupAddIfIdentifying = new System.Windows.Forms.Button();
            this.textBoxRemoveAllGroupDstEp = new System.Windows.Forms.TextBox();
            this.textBoxRemoveAllGroupSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxRemoveAllGroupTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonGroupRemoveAll = new System.Windows.Forms.Button();
            this.textBoxRemoveGroupGroupAddr = new System.Windows.Forms.TextBox();
            this.textBoxRemoveGroupDstEp = new System.Windows.Forms.TextBox();
            this.textBoxRemoveGroupSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxRemoveGroupTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.textBoxGetGroupCount = new System.Windows.Forms.TextBox();
            this.textBoxGetGroupDstEp = new System.Windows.Forms.TextBox();
            this.textBoxGetGroupSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxGetGroupTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonGetGroup = new System.Windows.Forms.Button();
            this.textBoxViewGroupGroupAddr = new System.Windows.Forms.TextBox();
            this.textBoxViewGroupDstEp = new System.Windows.Forms.TextBox();
            this.textBoxViewGroupSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxViewGroupAddr = new System.Windows.Forms.TextBox();
            this.buttonViewGroup = new System.Windows.Forms.Button();
            this.textBoxAddGroupGroupAddr = new System.Windows.Forms.TextBox();
            this.textBoxAddGroupDstEp = new System.Windows.Forms.TextBox();
            this.textBoxAddGroupSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxAddGroupAddr = new System.Windows.Forms.TextBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBoxIdQueryDstEp = new System.Windows.Forms.TextBox();
            this.textBoxIdQuerySrcEp = new System.Windows.Forms.TextBox();
            this.textBoxIdQueryAddr = new System.Windows.Forms.TextBox();
            this.textBoxIdSendTime = new System.Windows.Forms.TextBox();
            this.textBoxIdSendDstEp = new System.Windows.Forms.TextBox();
            this.textBoxSendIdSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxSendIdAddr = new System.Windows.Forms.TextBox();
            this.buttonIdQuery = new System.Windows.Forms.Button();
            this.buttonIdSend = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.comboBoxMoveToLevelOnOff = new System.Windows.Forms.ComboBox();
            this.comboBoxMoveToLevelAddrMode = new System.Windows.Forms.ComboBox();
            this.textBoxMoveToLevelTransTime = new System.Windows.Forms.TextBox();
            this.textBoxMoveToLevelLevel = new System.Windows.Forms.TextBox();
            this.textBoxMoveToLevelDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxMoveToLevelSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxMoveToLevelAddr = new System.Windows.Forms.TextBox();
            this.buttonMoveToLevel = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBoxOnOffAddrMode = new System.Windows.Forms.ComboBox();
            this.comboBoxOnOffCommand = new System.Windows.Forms.ComboBox();
            this.textBoxOnOffDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxOnOffSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxOnOffAddr = new System.Windows.Forms.TextBox();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBoxRemoveSceneSceneID = new System.Windows.Forms.TextBox();
            this.textBoxRemoveSceneGroupID = new System.Windows.Forms.TextBox();
            this.textBoxRemoveSceneDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxRemoveSceneSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxRemoveSceneAddr = new System.Windows.Forms.TextBox();
            this.comboBoxRemoveSceneAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonRemoveScene = new System.Windows.Forms.Button();
            this.textBoxRemoveAllScenesGroupID = new System.Windows.Forms.TextBox();
            this.textBoxRemoveAllScenesDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxRemoveAllScenesSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxRemoveAllScenesAddr = new System.Windows.Forms.TextBox();
            this.comboBoxRemoveAllScenesAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonRemoveAllScenes = new System.Windows.Forms.Button();
            this.textBoxGetSceneMembershipGroupID = new System.Windows.Forms.TextBox();
            this.textBoxGetSceneMembershipDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxGetSceneMembershipSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxGetSceneMembershipAddr = new System.Windows.Forms.TextBox();
            this.comboBoxGetSceneMembershipAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonGetSceneMembership = new System.Windows.Forms.Button();
            this.textBoxRecallSceneSceneId = new System.Windows.Forms.TextBox();
            this.textBoxRecallSceneGroupId = new System.Windows.Forms.TextBox();
            this.textBoxRecallSceneDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxRecallSceneSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxRecallSceneAddr = new System.Windows.Forms.TextBox();
            this.comboBoxRecallSceneAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonRecallScene = new System.Windows.Forms.Button();
            this.textBoxStoreSceneSceneId = new System.Windows.Forms.TextBox();
            this.textBoxStoreSceneGroupId = new System.Windows.Forms.TextBox();
            this.textBoxStoreSceneDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxStoreSceneSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxStoreSceneAddr = new System.Windows.Forms.TextBox();
            this.comboBoxStoreSceneAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonStoreScene = new System.Windows.Forms.Button();
            this.textBoxAddSceneMaxNameLen = new System.Windows.Forms.TextBox();
            this.textBoxAddSceneNameLen = new System.Windows.Forms.TextBox();
            this.textBoxAddSceneName = new System.Windows.Forms.TextBox();
            this.textBoxAddSceneTransTime = new System.Windows.Forms.TextBox();
            this.textBoxAddSceneSceneId = new System.Windows.Forms.TextBox();
            this.textBoxAddSceneGroupId = new System.Windows.Forms.TextBox();
            this.textBoxAddSceneDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxAddSceneSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxAddSceneAddr = new System.Windows.Forms.TextBox();
            this.comboBoxAddSceneAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonAddScene = new System.Windows.Forms.Button();
            this.comboBoxViewSceneAddrMode = new System.Windows.Forms.ComboBox();
            this.textBoxViewSceneSceneId = new System.Windows.Forms.TextBox();
            this.textBoxViewSceneGroupId = new System.Windows.Forms.TextBox();
            this.textBoxViewSceneDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxViewSceneSrcEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxViewSceneAddr = new System.Windows.Forms.TextBox();
            this.buttonViewScene = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.textBoxMoveToColorTempRate = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorTempTemp = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorTempDstEp = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorTempSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorTempAddr = new System.Windows.Forms.TextBox();
            this.buttonMoveToColorTemp = new System.Windows.Forms.Button();
            this.textBoxMoveToColorTime = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorY = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorX = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorDstEp = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxMoveToColorAddr = new System.Windows.Forms.TextBox();
            this.buttonMoveToColor = new System.Windows.Forms.Button();
            this.textBoxMoveToHueTime = new System.Windows.Forms.TextBox();
            this.textBoxMoveToHueDir = new System.Windows.Forms.TextBox();
            this.textBoxMoveToHueHue = new System.Windows.Forms.TextBox();
            this.textBoxMoveToHueDstEp = new System.Windows.Forms.TextBox();
            this.textBoxMoveToHueSrcEp = new System.Windows.Forms.TextBox();
            this.buttonMoveToHue = new System.Windows.Forms.Button();
            this.textBoxMoveToHueAddr = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxLockUnlock = new System.Windows.Forms.ComboBox();
            this.textBoxLockUnlockDstEp = new System.Windows.Forms.TextBox();
            this.textBoxLockUnlockSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxLockUnlockAddr = new System.Windows.Forms.TextBox();
            this.buttonLockUnlock = new System.Windows.Forms.Button();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.textBoxHVACRaiseLowData = new System.Windows.Forms.TextBox();
            this.textBoxHVACDstEndPoint = new System.Windows.Forms.TextBox();
            this.textBoxHVACSrcEndPoint = new System.Windows.Forms.TextBox();
            this.comboBoxHVACSetMode = new System.Windows.Forms.ComboBox();
            this.textBoxHVACAddress = new System.Windows.Forms.TextBox();
            this.comboBoxHVACAddressMode = new System.Windows.Forms.ComboBox();
            this.SetRaiseLower_button1 = new System.Windows.Forms.Button();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.comboBoxEnrollRspCode = new System.Windows.Forms.ComboBox();
            this.textBoxEnrollRspZone = new System.Windows.Forms.TextBox();
            this.textBoxEnrollRspDstEp = new System.Windows.Forms.TextBox();
            this.textBoxEnrollRspSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxEnrollRspAddr = new System.Windows.Forms.TextBox();
            this.comboBoxEnrollRspAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonEnrollResponse = new System.Windows.Forms.Button();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.buttonZllTouchlinkFactoryReset = new System.Windows.Forms.Button();
            this.buttonZllTouchlinkInitiate = new System.Windows.Forms.Button();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.comboBoxZllOnOffEffectID = new System.Windows.Forms.ComboBox();
            this.textBoxZllOnOffEffectsGradient = new System.Windows.Forms.TextBox();
            this.textBoxZllOnOffEffectsDstEp = new System.Windows.Forms.TextBox();
            this.textBoxZllOnOffEffectsSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxZllOnOffEffectsAddr = new System.Windows.Forms.TextBox();
            this.buttonZllOnOffEffects = new System.Windows.Forms.Button();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.textBoxZllMoveToHueHue = new System.Windows.Forms.TextBox();
            this.textBoxZllMoveToHueTransTime = new System.Windows.Forms.TextBox();
            this.textBoxZllMoveToHueDirection = new System.Windows.Forms.TextBox();
            this.textBoxZllMoveToHueDstEp = new System.Windows.Forms.TextBox();
            this.textBoxZllMoveToHueSrcEp = new System.Windows.Forms.TextBox();
            this.textBoxZllMoveToHueAddr = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonZllMoveToHue = new System.Windows.Forms.Button();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.textBoxOTASetWaitForDataParamsRequestBlockDelay = new System.Windows.Forms.TextBox();
            this.textBoxOTASetWaitForDataParamsRequestTime = new System.Windows.Forms.TextBox();
            this.textBoxOTASetWaitForDataParamsCurrentTime = new System.Windows.Forms.TextBox();
            this.textBoxOTASetWaitForDataParamsSrcEP = new System.Windows.Forms.TextBox();
            this.textBoxOTASetWaitForDataParamsTargetAddr = new System.Windows.Forms.TextBox();
            this.buttonOTASetWaitForDataParams = new System.Windows.Forms.Button();
            this.textBoxOtaFileOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOtaDownloadStatus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarOtaDownloadProgress = new System.Windows.Forms.ProgressBar();
            this.textBoxOTAImageNotifyJitter = new System.Windows.Forms.TextBox();
            this.textBoxOTAImageNotifyManuID = new System.Windows.Forms.TextBox();
            this.textBoxOTAImageNotifyImageType = new System.Windows.Forms.TextBox();
            this.textBoxOTAImageNotifyFileVersion = new System.Windows.Forms.TextBox();
            this.comboBoxOTAImageNotifyType = new System.Windows.Forms.ComboBox();
            this.textBoxOTAImageNotifyDstEP = new System.Windows.Forms.TextBox();
            this.textBoxOTAImageNotifySrcEP = new System.Windows.Forms.TextBox();
            this.textBoxOTAImageNotifyTargetAddr = new System.Windows.Forms.TextBox();
            this.comboBoxOTAImageNotifyAddrMode = new System.Windows.Forms.ComboBox();
            this.buttonOTAImageNotify = new System.Windows.Forms.Button();
            this.textBoxOtaFileSize = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOtaFileVersion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOtaFileImageType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOtaFileManuCode = new System.Windows.Forms.TextBox();
            this.buttonOTALoadNewImage = new System.Windows.Forms.Button();
            this.buttonMessageViewClear = new System.Windows.Forms.Button();
            this.buttonClearRaw = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxMessageView = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxCommandResponse = new System.Windows.Forms.RichTextBox();
            this.openOtaFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTipGeneralTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxAddSceneExtensionsLen = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.AHIControl.SuspendLayout();
            this.BasicClusterTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.openPortToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1947, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // openPortToolStripMenuItem
            // 
            this.openPortToolStripMenuItem.Name = "openPortToolStripMenuItem";
            this.openPortToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.openPortToolStripMenuItem.Text = "Open Port";
            this.openPortToolStripMenuItem.Click += new System.EventHandler(this.openPortToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusPort,
            this.toolStripPortSettings});
            this.statusStrip.Location = new System.Drawing.Point(0, 1054);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1947, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusPort
            // 
            this.toolStripStatusPort.Name = "toolStripStatusPort";
            this.toolStripStatusPort.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripPortSettings
            // 
            this.toolStripPortSettings.Name = "toolStripPortSettings";
            this.toolStripPortSettings.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.AHIControl);
            this.tabControl1.Controls.Add(this.BasicClusterTab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage15);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage14);
            this.tabControl1.Location = new System.Drawing.Point(18, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1911, 622);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.textBoxBindTargetExtAddr);
            this.tabPage2.Controls.Add(this.textBoxUserSetReqDescription);
            this.tabPage2.Controls.Add(this.textBoxUserSetReqAddr);
            this.tabPage2.Controls.Add(this.buttonUserSetReq);
            this.tabPage2.Controls.Add(this.textBoxUserReqAddr);
            this.tabPage2.Controls.Add(this.buttonUserReq);
            this.tabPage2.Controls.Add(this.textBoxRestoreNwkFrameCounter);
            this.tabPage2.Controls.Add(this.comboBoxLeaveChildren);
            this.tabPage2.Controls.Add(this.comboBoxLeaveReJoin);
            this.tabPage2.Controls.Add(this.textBoxLeaveAddr);
            this.tabPage2.Controls.Add(this.buttonLeave);
            this.tabPage2.Controls.Add(this.textBoxRemoveChildAddr);
            this.tabPage2.Controls.Add(this.textBoxRemoveParentAddr);
            this.tabPage2.Controls.Add(this.buttonRemoveDevice);
            this.tabPage2.Controls.Add(this.buttonPermitJoinState);
            this.tabPage2.Controls.Add(this.buttonRestoreNwk);
            this.tabPage2.Controls.Add(this.buttonRecoverNwk);
            this.tabPage2.Controls.Add(this.comboBoxMgmtLeaveChildren);
            this.tabPage2.Controls.Add(this.comboBoxMgmtLeaveReJoin);
            this.tabPage2.Controls.Add(this.textBoxMgmtLeaveExtAddr);
            this.tabPage2.Controls.Add(this.textBoxMgmtLeaveAddr);
            this.tabPage2.Controls.Add(this.buttonMgmtLeave);
            this.tabPage2.Controls.Add(this.textBoxUnBindDestEP);
            this.tabPage2.Controls.Add(this.textBoxUnBindDestAddr);
            this.tabPage2.Controls.Add(this.comboBoxUnBindAddrMode);
            this.tabPage2.Controls.Add(this.textBoxUnBindClusterID);
            this.tabPage2.Controls.Add(this.textBoxUnBindTargetEP);
            this.tabPage2.Controls.Add(this.textBoxUnBindTargetExtAddr);
            this.tabPage2.Controls.Add(this.buttonUnBind);
            this.tabPage2.Controls.Add(this.textBoxBindDestEP);
            this.tabPage2.Controls.Add(this.textBoxBindDestAddr);
            this.tabPage2.Controls.Add(this.comboBoxBindAddrMode);
            this.tabPage2.Controls.Add(this.textBoxBindClusterID);
            this.tabPage2.Controls.Add(this.textBoxBindTargetEP);
            this.tabPage2.Controls.Add(this.textBoxLqiReqStartIndex);
            this.tabPage2.Controls.Add(this.textBoxLqiReqTargetAddr);
            this.tabPage2.Controls.Add(this.buttonMgmtLqiReq);
            this.tabPage2.Controls.Add(this.buttonStartScan);
            this.tabPage2.Controls.Add(this.textBoxNwkAddrReqStartIndex);
            this.tabPage2.Controls.Add(this.comboBoxNwkAddrReqType);
            this.tabPage2.Controls.Add(this.textBoxNwkAddrReqExtAddr);
            this.tabPage2.Controls.Add(this.textBoxNwkAddrReqTargetAddr);
            this.tabPage2.Controls.Add(this.textBoxIeeeReqStartIndex);
            this.tabPage2.Controls.Add(this.comboBoxIeeeReqType);
            this.tabPage2.Controls.Add(this.textBoxIeeeReqAddr);
            this.tabPage2.Controls.Add(this.textBoxIeeeReqTargetAddr);
            this.tabPage2.Controls.Add(this.textBoxComplexReqAddr);
            this.tabPage2.Controls.Add(this.buttonComplexReq);
            this.tabPage2.Controls.Add(this.textBoxMatchReqOutputClusters);
            this.tabPage2.Controls.Add(this.textBoxMatchReqInputClusters);
            this.tabPage2.Controls.Add(this.textBoxMatchReqProfileID);
            this.tabPage2.Controls.Add(this.textBoxMatchReqNbrOutputClusters);
            this.tabPage2.Controls.Add(this.textBoxMatchReqNbrInputClusters);
            this.tabPage2.Controls.Add(this.textBoxMatchReqAddr);
            this.tabPage2.Controls.Add(this.textBoxActiveEpAddr);
            this.tabPage2.Controls.Add(this.textBoxPowerReqAddr);
            this.tabPage2.Controls.Add(this.textBoxSimpleReqEndPoint);
            this.tabPage2.Controls.Add(this.textBoxSimpleReqAddr);
            this.tabPage2.Controls.Add(this.buttonMatchReq);
            this.tabPage2.Controls.Add(this.buttonActiveEpReq);
            this.tabPage2.Controls.Add(this.buttonPowerDescReq);
            this.tabPage2.Controls.Add(this.buttonSimpleDescReq);
            this.tabPage2.Controls.Add(this.textBoxNodeDescReq);
            this.tabPage2.Controls.Add(this.buttonNodeDescReq);
            this.tabPage2.Controls.Add(this.buttonIeeeAddrReq);
            this.tabPage2.Controls.Add(this.buttonNwkAddrReq);
            this.tabPage2.Controls.Add(this.comboBoxSecurityKey);
            this.tabPage2.Controls.Add(this.comboBoxPermitJoinTCsignificance);
            this.tabPage2.Controls.Add(this.textBoxPermitJoinInterval);
            this.tabPage2.Controls.Add(this.textBoxPermitJoinAddr);
            this.tabPage2.Controls.Add(this.buttonPermitJoin);
            this.tabPage2.Controls.Add(this.comboBoxSetKeyType);
            this.tabPage2.Controls.Add(this.comboBoxSetKeyState);
            this.tabPage2.Controls.Add(this.comboBoxSetType);
            this.tabPage2.Controls.Add(this.buttonStartNWK);
            this.tabPage2.Controls.Add(this.buttonBind);
            this.tabPage2.Controls.Add(this.buttonErasePD);
            this.tabPage2.Controls.Add(this.buttonReset);
            this.tabPage2.Controls.Add(this.textBoxSetSecurityKeySeqNbr);
            this.tabPage2.Controls.Add(this.buttonSetDeviceType);
            this.tabPage2.Controls.Add(this.buttonSetSecurity);
            this.tabPage2.Controls.Add(this.textBoxSetEPID);
            this.tabPage2.Controls.Add(this.textBoxSetCMSK);
            this.tabPage2.Controls.Add(this.buttonSetCMSK);
            this.tabPage2.Controls.Add(this.buttonSetEPID);
            this.tabPage2.Controls.Add(this.buttonGetVersion);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1903, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Management";
            // 
            // textBoxBindTargetExtAddr
            // 
            this.textBoxBindTargetExtAddr.Location = new System.Drawing.Point(130, 458);
            this.textBoxBindTargetExtAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBindTargetExtAddr.Name = "textBoxBindTargetExtAddr";
            this.textBoxBindTargetExtAddr.Size = new System.Drawing.Size(180, 28);
            this.textBoxBindTargetExtAddr.TabIndex = 77;
            // 
            // textBoxUserSetReqDescription
            // 
            this.textBoxUserSetReqDescription.Location = new System.Drawing.Point(1338, 336);
            this.textBoxUserSetReqDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserSetReqDescription.Name = "textBoxUserSetReqDescription";
            this.textBoxUserSetReqDescription.Size = new System.Drawing.Size(223, 28);
            this.textBoxUserSetReqDescription.TabIndex = 104;
            this.textBoxUserSetReqDescription.MouseEnter += new System.EventHandler(this.textBoxUserSetReqDescription_MouseEnter);
            this.textBoxUserSetReqDescription.MouseLeave += new System.EventHandler(this.textBoxUserSetReqDescription_MouseLeave);
            // 
            // textBoxUserSetReqAddr
            // 
            this.textBoxUserSetReqAddr.Location = new System.Drawing.Point(1179, 336);
            this.textBoxUserSetReqAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserSetReqAddr.Name = "textBoxUserSetReqAddr";
            this.textBoxUserSetReqAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxUserSetReqAddr.TabIndex = 103;
            this.textBoxUserSetReqAddr.MouseEnter += new System.EventHandler(this.textBoxUserSetReqAddr_MouseEnter);
            this.textBoxUserSetReqAddr.MouseLeave += new System.EventHandler(this.textBoxUserSetReqAddr_MouseLeave);
            // 
            // buttonUserSetReq
            // 
            this.buttonUserSetReq.Location = new System.Drawing.Point(1058, 334);
            this.buttonUserSetReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserSetReq.Name = "buttonUserSetReq";
            this.buttonUserSetReq.Size = new System.Drawing.Size(112, 32);
            this.buttonUserSetReq.TabIndex = 102;
            this.buttonUserSetReq.Text = "UserSetReq";
            this.buttonUserSetReq.UseVisualStyleBackColor = true;
            this.buttonUserSetReq.Click += new System.EventHandler(this.buttonUserSetReq_Click);
            // 
            // textBoxUserReqAddr
            // 
            this.textBoxUserReqAddr.Location = new System.Drawing.Point(1179, 296);
            this.textBoxUserReqAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserReqAddr.Name = "textBoxUserReqAddr";
            this.textBoxUserReqAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxUserReqAddr.TabIndex = 101;
            this.textBoxUserReqAddr.MouseEnter += new System.EventHandler(this.textBoxUserReqAddr_MouseEnter);
            this.textBoxUserReqAddr.MouseLeave += new System.EventHandler(this.textBoxUserReqAddr_MouseLeave);
            // 
            // buttonUserReq
            // 
            this.buttonUserReq.Location = new System.Drawing.Point(1058, 294);
            this.buttonUserReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserReq.Name = "buttonUserReq";
            this.buttonUserReq.Size = new System.Drawing.Size(112, 32);
            this.buttonUserReq.TabIndex = 100;
            this.buttonUserReq.Text = "UserReq";
            this.buttonUserReq.UseVisualStyleBackColor = true;
            this.buttonUserReq.Click += new System.EventHandler(this.buttonUserReq_Click);
            // 
            // textBoxRestoreNwkFrameCounter
            // 
            this.textBoxRestoreNwkFrameCounter.Location = new System.Drawing.Point(1179, 460);
            this.textBoxRestoreNwkFrameCounter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRestoreNwkFrameCounter.Name = "textBoxRestoreNwkFrameCounter";
            this.textBoxRestoreNwkFrameCounter.Size = new System.Drawing.Size(228, 28);
            this.textBoxRestoreNwkFrameCounter.TabIndex = 99;
            this.textBoxRestoreNwkFrameCounter.Visible = false;
            this.textBoxRestoreNwkFrameCounter.MouseEnter += new System.EventHandler(this.textBoxRestoreNwkFrameCounter_MouseEnter);
            this.textBoxRestoreNwkFrameCounter.MouseLeave += new System.EventHandler(this.textBoxRestoreNwkFrameCounter_MouseLeave);
            // 
            // comboBoxLeaveChildren
            // 
            this.comboBoxLeaveChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeaveChildren.FormattingEnabled = true;
            this.comboBoxLeaveChildren.Location = new System.Drawing.Point(610, 256);
            this.comboBoxLeaveChildren.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLeaveChildren.Name = "comboBoxLeaveChildren";
            this.comboBoxLeaveChildren.Size = new System.Drawing.Size(274, 26);
            this.comboBoxLeaveChildren.TabIndex = 98;
            // 
            // comboBoxLeaveReJoin
            // 
            this.comboBoxLeaveReJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeaveReJoin.FormattingEnabled = true;
            this.comboBoxLeaveReJoin.Location = new System.Drawing.Point(434, 256);
            this.comboBoxLeaveReJoin.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLeaveReJoin.Name = "comboBoxLeaveReJoin";
            this.comboBoxLeaveReJoin.Size = new System.Drawing.Size(166, 26);
            this.comboBoxLeaveReJoin.TabIndex = 97;
            // 
            // textBoxLeaveAddr
            // 
            this.textBoxLeaveAddr.Location = new System.Drawing.Point(130, 256);
            this.textBoxLeaveAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLeaveAddr.Name = "textBoxLeaveAddr";
            this.textBoxLeaveAddr.Size = new System.Drawing.Size(292, 28);
            this.textBoxLeaveAddr.TabIndex = 96;
            this.textBoxLeaveAddr.MouseLeave += new System.EventHandler(this.textBoxLeaveAddr_MouseLeave);
            this.textBoxLeaveAddr.MouseHover += new System.EventHandler(this.textBoxLeaveAddr_MouseHover);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(9, 253);
            this.buttonLeave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(112, 32);
            this.buttonLeave.TabIndex = 94;
            this.buttonLeave.Text = "Leave";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // textBoxRemoveChildAddr
            // 
            this.textBoxRemoveChildAddr.Location = new System.Drawing.Point(452, 298);
            this.textBoxRemoveChildAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveChildAddr.Name = "textBoxRemoveChildAddr";
            this.textBoxRemoveChildAddr.Size = new System.Drawing.Size(307, 28);
            this.textBoxRemoveChildAddr.TabIndex = 93;
            this.textBoxRemoveChildAddr.MouseLeave += new System.EventHandler(this.textBoxRemoveChildAddr_MouseLeave);
            this.textBoxRemoveChildAddr.MouseHover += new System.EventHandler(this.textBoxRemoveChildAddr_MouseHover);
            // 
            // textBoxRemoveParentAddr
            // 
            this.textBoxRemoveParentAddr.Location = new System.Drawing.Point(130, 298);
            this.textBoxRemoveParentAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveParentAddr.Name = "textBoxRemoveParentAddr";
            this.textBoxRemoveParentAddr.Size = new System.Drawing.Size(307, 28);
            this.textBoxRemoveParentAddr.TabIndex = 92;
            this.textBoxRemoveParentAddr.MouseLeave += new System.EventHandler(this.textBoxRemoveParentAddr_MouseLeave);
            this.textBoxRemoveParentAddr.MouseHover += new System.EventHandler(this.textBoxRemoveParentAddr_MouseHover);
            // 
            // buttonRemoveDevice
            // 
            this.buttonRemoveDevice.Location = new System.Drawing.Point(9, 295);
            this.buttonRemoveDevice.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveDevice.Name = "buttonRemoveDevice";
            this.buttonRemoveDevice.Size = new System.Drawing.Size(112, 32);
            this.buttonRemoveDevice.TabIndex = 91;
            this.buttonRemoveDevice.Text = "Remove";
            this.buttonRemoveDevice.UseVisualStyleBackColor = true;
            this.buttonRemoveDevice.Click += new System.EventHandler(this.buttonRemoveDevice_Click);
            // 
            // buttonPermitJoinState
            // 
            this.buttonPermitJoinState.Location = new System.Drawing.Point(9, 375);
            this.buttonPermitJoinState.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPermitJoinState.Name = "buttonPermitJoinState";
            this.buttonPermitJoinState.Size = new System.Drawing.Size(147, 32);
            this.buttonPermitJoinState.TabIndex = 90;
            this.buttonPermitJoinState.Text = "Permit Join State";
            this.buttonPermitJoinState.UseVisualStyleBackColor = true;
            this.buttonPermitJoinState.Click += new System.EventHandler(this.buttonPermitJoinState_Click);
            // 
            // buttonRestoreNwk
            // 
            this.buttonRestoreNwk.Location = new System.Drawing.Point(1058, 456);
            this.buttonRestoreNwk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRestoreNwk.Name = "buttonRestoreNwk";
            this.buttonRestoreNwk.Size = new System.Drawing.Size(112, 32);
            this.buttonRestoreNwk.TabIndex = 68;
            this.buttonRestoreNwk.Text = "RES NWK";
            this.buttonRestoreNwk.UseVisualStyleBackColor = true;
            this.buttonRestoreNwk.Visible = false;
            this.buttonRestoreNwk.Click += new System.EventHandler(this.buttonRestoreNwk_Click);
            // 
            // buttonRecoverNwk
            // 
            this.buttonRecoverNwk.Location = new System.Drawing.Point(1058, 415);
            this.buttonRecoverNwk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRecoverNwk.Name = "buttonRecoverNwk";
            this.buttonRecoverNwk.Size = new System.Drawing.Size(112, 32);
            this.buttonRecoverNwk.TabIndex = 67;
            this.buttonRecoverNwk.Text = "REC NWK";
            this.buttonRecoverNwk.UseVisualStyleBackColor = true;
            this.buttonRecoverNwk.Visible = false;
            this.buttonRecoverNwk.Click += new System.EventHandler(this.buttonRecoverNwk_Click);
            // 
            // comboBoxMgmtLeaveChildren
            // 
            this.comboBoxMgmtLeaveChildren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMgmtLeaveChildren.FormattingEnabled = true;
            this.comboBoxMgmtLeaveChildren.Location = new System.Drawing.Point(770, 216);
            this.comboBoxMgmtLeaveChildren.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMgmtLeaveChildren.Name = "comboBoxMgmtLeaveChildren";
            this.comboBoxMgmtLeaveChildren.Size = new System.Drawing.Size(274, 26);
            this.comboBoxMgmtLeaveChildren.TabIndex = 87;
            // 
            // comboBoxMgmtLeaveReJoin
            // 
            this.comboBoxMgmtLeaveReJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMgmtLeaveReJoin.FormattingEnabled = true;
            this.comboBoxMgmtLeaveReJoin.Location = new System.Drawing.Point(592, 216);
            this.comboBoxMgmtLeaveReJoin.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMgmtLeaveReJoin.Name = "comboBoxMgmtLeaveReJoin";
            this.comboBoxMgmtLeaveReJoin.Size = new System.Drawing.Size(166, 26);
            this.comboBoxMgmtLeaveReJoin.TabIndex = 86;
            // 
            // textBoxMgmtLeaveExtAddr
            // 
            this.textBoxMgmtLeaveExtAddr.Location = new System.Drawing.Point(290, 216);
            this.textBoxMgmtLeaveExtAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMgmtLeaveExtAddr.Name = "textBoxMgmtLeaveExtAddr";
            this.textBoxMgmtLeaveExtAddr.Size = new System.Drawing.Size(292, 28);
            this.textBoxMgmtLeaveExtAddr.TabIndex = 85;
            this.textBoxMgmtLeaveExtAddr.MouseLeave += new System.EventHandler(this.textBoxMgmtLeaveExtAddr_MouseLeave);
            this.textBoxMgmtLeaveExtAddr.MouseHover += new System.EventHandler(this.textBoxMgmtLeaveExtAddr_MouseHover);
            // 
            // textBoxMgmtLeaveAddr
            // 
            this.textBoxMgmtLeaveAddr.Location = new System.Drawing.Point(130, 216);
            this.textBoxMgmtLeaveAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMgmtLeaveAddr.Name = "textBoxMgmtLeaveAddr";
            this.textBoxMgmtLeaveAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxMgmtLeaveAddr.TabIndex = 84;
            this.textBoxMgmtLeaveAddr.MouseLeave += new System.EventHandler(this.textBoxMgmtLeaveAddr_MouseLeave);
            this.textBoxMgmtLeaveAddr.MouseHover += new System.EventHandler(this.textBoxMgmtLeaveAddr_MouseHover);
            // 
            // buttonMgmtLeave
            // 
            this.buttonMgmtLeave.Location = new System.Drawing.Point(9, 213);
            this.buttonMgmtLeave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMgmtLeave.Name = "buttonMgmtLeave";
            this.buttonMgmtLeave.Size = new System.Drawing.Size(112, 32);
            this.buttonMgmtLeave.TabIndex = 83;
            this.buttonMgmtLeave.Text = "Mgmt Leave";
            this.buttonMgmtLeave.UseVisualStyleBackColor = true;
            this.buttonMgmtLeave.Click += new System.EventHandler(this.buttonMgmtLeave_Click);
            // 
            // textBoxUnBindDestEP
            // 
            this.textBoxUnBindDestEP.Location = new System.Drawing.Point(916, 498);
            this.textBoxUnBindDestEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnBindDestEP.Name = "textBoxUnBindDestEP";
            this.textBoxUnBindDestEP.Size = new System.Drawing.Size(122, 28);
            this.textBoxUnBindDestEP.TabIndex = 82;
            this.textBoxUnBindDestEP.MouseEnter += new System.EventHandler(this.textBoxUnBindDestEP_MouseEnter);
            this.textBoxUnBindDestEP.MouseLeave += new System.EventHandler(this.textBoxUnBindDestEP_MouseLeave);
            // 
            // textBoxUnBindDestAddr
            // 
            this.textBoxUnBindDestAddr.Location = new System.Drawing.Point(720, 498);
            this.textBoxUnBindDestAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnBindDestAddr.Name = "textBoxUnBindDestAddr";
            this.textBoxUnBindDestAddr.Size = new System.Drawing.Size(186, 28);
            this.textBoxUnBindDestAddr.TabIndex = 81;
            this.textBoxUnBindDestAddr.MouseEnter += new System.EventHandler(this.textBoxUnBindDestAddr_MouseEnter);
            this.textBoxUnBindDestAddr.MouseLeave += new System.EventHandler(this.textBoxUnBindDestAddr_MouseLeave);
            // 
            // comboBoxUnBindAddrMode
            // 
            this.comboBoxUnBindAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnBindAddrMode.FormattingEnabled = true;
            this.comboBoxUnBindAddrMode.Location = new System.Drawing.Point(592, 498);
            this.comboBoxUnBindAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUnBindAddrMode.Name = "comboBoxUnBindAddrMode";
            this.comboBoxUnBindAddrMode.Size = new System.Drawing.Size(116, 26);
            this.comboBoxUnBindAddrMode.TabIndex = 80;
            this.comboBoxUnBindAddrMode.MouseEnter += new System.EventHandler(this.comboBoxUnBindAddrMode_MouseEnter);
            this.comboBoxUnBindAddrMode.MouseLeave += new System.EventHandler(this.comboBoxUnBindAddrMode_MouseLeave);
            // 
            // textBoxUnBindClusterID
            // 
            this.textBoxUnBindClusterID.Location = new System.Drawing.Point(448, 496);
            this.textBoxUnBindClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnBindClusterID.Name = "textBoxUnBindClusterID";
            this.textBoxUnBindClusterID.Size = new System.Drawing.Size(133, 28);
            this.textBoxUnBindClusterID.TabIndex = 79;
            this.textBoxUnBindClusterID.MouseEnter += new System.EventHandler(this.textBoxUnBindClusterID_MouseEnter);
            this.textBoxUnBindClusterID.MouseLeave += new System.EventHandler(this.textBoxUnBindClusterID_MouseLeave);
            // 
            // textBoxUnBindTargetEP
            // 
            this.textBoxUnBindTargetEP.Location = new System.Drawing.Point(321, 496);
            this.textBoxUnBindTargetEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnBindTargetEP.Name = "textBoxUnBindTargetEP";
            this.textBoxUnBindTargetEP.Size = new System.Drawing.Size(116, 28);
            this.textBoxUnBindTargetEP.TabIndex = 78;
            this.textBoxUnBindTargetEP.MouseEnter += new System.EventHandler(this.textBoxUnBindTargetEP_MouseEnter);
            this.textBoxUnBindTargetEP.MouseLeave += new System.EventHandler(this.textBoxUnBindTargetEP_MouseLeave);
            // 
            // textBoxUnBindTargetExtAddr
            // 
            this.textBoxUnBindTargetExtAddr.Location = new System.Drawing.Point(134, 496);
            this.textBoxUnBindTargetExtAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnBindTargetExtAddr.Name = "textBoxUnBindTargetExtAddr";
            this.textBoxUnBindTargetExtAddr.Size = new System.Drawing.Size(180, 28);
            this.textBoxUnBindTargetExtAddr.TabIndex = 77;
            this.textBoxUnBindTargetExtAddr.MouseEnter += new System.EventHandler(this.textBoxUnBindTargetExtAddr_MouseEnter);
            this.textBoxUnBindTargetExtAddr.MouseLeave += new System.EventHandler(this.textBoxUnBindTargetExtAddr_MouseLeave);
            // 
            // buttonUnBind
            // 
            this.buttonUnBind.Location = new System.Drawing.Point(9, 494);
            this.buttonUnBind.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUnBind.Name = "buttonUnBind";
            this.buttonUnBind.Size = new System.Drawing.Size(112, 35);
            this.buttonUnBind.TabIndex = 76;
            this.buttonUnBind.Text = "UnBind";
            this.buttonUnBind.UseVisualStyleBackColor = true;
            this.buttonUnBind.Click += new System.EventHandler(this.buttonUnBind_Click);
            // 
            // textBoxBindDestEP
            // 
            this.textBoxBindDestEP.Location = new System.Drawing.Point(916, 460);
            this.textBoxBindDestEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBindDestEP.Name = "textBoxBindDestEP";
            this.textBoxBindDestEP.Size = new System.Drawing.Size(122, 28);
            this.textBoxBindDestEP.TabIndex = 75;
            this.textBoxBindDestEP.MouseEnter += new System.EventHandler(this.textBoxBindDestEP_MouseEnter);
            this.textBoxBindDestEP.MouseLeave += new System.EventHandler(this.textBoxBindDestEP_MouseLeave);
            // 
            // textBoxBindDestAddr
            // 
            this.textBoxBindDestAddr.Location = new System.Drawing.Point(720, 460);
            this.textBoxBindDestAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBindDestAddr.Name = "textBoxBindDestAddr";
            this.textBoxBindDestAddr.Size = new System.Drawing.Size(186, 28);
            this.textBoxBindDestAddr.TabIndex = 74;
            this.textBoxBindDestAddr.MouseEnter += new System.EventHandler(this.textBoxBindDestAddr_MouseEnter);
            this.textBoxBindDestAddr.MouseLeave += new System.EventHandler(this.textBoxBindDestAddr_MouseLeave);
            // 
            // comboBoxBindAddrMode
            // 
            this.comboBoxBindAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBindAddrMode.FormattingEnabled = true;
            this.comboBoxBindAddrMode.Location = new System.Drawing.Point(592, 460);
            this.comboBoxBindAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBindAddrMode.Name = "comboBoxBindAddrMode";
            this.comboBoxBindAddrMode.Size = new System.Drawing.Size(116, 26);
            this.comboBoxBindAddrMode.TabIndex = 73;
            this.comboBoxBindAddrMode.MouseEnter += new System.EventHandler(this.comboBoxBindAddrMode_MouseEnter);
            this.comboBoxBindAddrMode.MouseLeave += new System.EventHandler(this.comboBoxBindAddrMode_MouseLeave);
            // 
            // textBoxBindClusterID
            // 
            this.textBoxBindClusterID.Location = new System.Drawing.Point(321, 458);
            this.textBoxBindClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBindClusterID.Name = "textBoxBindClusterID";
            this.textBoxBindClusterID.Size = new System.Drawing.Size(116, 28);
            this.textBoxBindClusterID.TabIndex = 72;
            this.textBoxBindClusterID.MouseLeave += new System.EventHandler(this.textBoxBindClusterID_MouseLeave);
            this.textBoxBindClusterID.MouseHover += new System.EventHandler(this.textBoxBindClusterID_MouseHover);
            // 
            // textBoxBindTargetEP
            // 
            this.textBoxBindTargetEP.Location = new System.Drawing.Point(448, 458);
            this.textBoxBindTargetEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBindTargetEP.Name = "textBoxBindTargetEP";
            this.textBoxBindTargetEP.Size = new System.Drawing.Size(133, 28);
            this.textBoxBindTargetEP.TabIndex = 71;
            this.textBoxBindTargetEP.MouseLeave += new System.EventHandler(this.textBoxBindTargetEP_MouseLeave);
            this.textBoxBindTargetEP.MouseHover += new System.EventHandler(this.textBoxBindTargetEP_MouseHover);
            // 
            // textBoxLqiReqStartIndex
            // 
            this.textBoxLqiReqStartIndex.Location = new System.Drawing.Point(1338, 377);
            this.textBoxLqiReqStartIndex.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLqiReqStartIndex.Name = "textBoxLqiReqStartIndex";
            this.textBoxLqiReqStartIndex.Size = new System.Drawing.Size(148, 28);
            this.textBoxLqiReqStartIndex.TabIndex = 69;
            this.textBoxLqiReqStartIndex.MouseEnter += new System.EventHandler(this.textBoxLqiReqStartIndex_MouseEnter);
            this.textBoxLqiReqStartIndex.MouseLeave += new System.EventHandler(this.textBoxLqiReqStartIndex_MouseLeave);
            // 
            // textBoxLqiReqTargetAddr
            // 
            this.textBoxLqiReqTargetAddr.Location = new System.Drawing.Point(1179, 378);
            this.textBoxLqiReqTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLqiReqTargetAddr.Name = "textBoxLqiReqTargetAddr";
            this.textBoxLqiReqTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxLqiReqTargetAddr.TabIndex = 68;
            this.textBoxLqiReqTargetAddr.MouseEnter += new System.EventHandler(this.textBoxLqiReqTargetAddr_MouseEnter);
            this.textBoxLqiReqTargetAddr.MouseLeave += new System.EventHandler(this.textBoxLqiReqTargetAddr_MouseLeave);
            // 
            // buttonMgmtLqiReq
            // 
            this.buttonMgmtLqiReq.Location = new System.Drawing.Point(1058, 375);
            this.buttonMgmtLqiReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMgmtLqiReq.Name = "buttonMgmtLqiReq";
            this.buttonMgmtLqiReq.Size = new System.Drawing.Size(112, 32);
            this.buttonMgmtLqiReq.TabIndex = 67;
            this.buttonMgmtLqiReq.Text = "Lqi Req";
            this.buttonMgmtLqiReq.UseVisualStyleBackColor = true;
            this.buttonMgmtLqiReq.Click += new System.EventHandler(this.buttonMgmtLqiReq_Click_1);
            // 
            // buttonStartScan
            // 
            this.buttonStartScan.Location = new System.Drawing.Point(495, 8);
            this.buttonStartScan.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartScan.Name = "buttonStartScan";
            this.buttonStartScan.Size = new System.Drawing.Size(112, 32);
            this.buttonStartScan.TabIndex = 66;
            this.buttonStartScan.Text = "Start Scan";
            this.buttonStartScan.UseVisualStyleBackColor = true;
            this.buttonStartScan.Click += new System.EventHandler(this.buttonStartScan_Click);
            // 
            // textBoxNwkAddrReqStartIndex
            // 
            this.textBoxNwkAddrReqStartIndex.Location = new System.Drawing.Point(1688, 90);
            this.textBoxNwkAddrReqStartIndex.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNwkAddrReqStartIndex.Name = "textBoxNwkAddrReqStartIndex";
            this.textBoxNwkAddrReqStartIndex.Size = new System.Drawing.Size(148, 28);
            this.textBoxNwkAddrReqStartIndex.TabIndex = 65;
            this.textBoxNwkAddrReqStartIndex.MouseEnter += new System.EventHandler(this.textBoxNwkAddrReqStartIndex_MouseEnter);
            this.textBoxNwkAddrReqStartIndex.MouseLeave += new System.EventHandler(this.textBoxNwkAddrReqStartIndex_MouseLeave);
            // 
            // comboBoxNwkAddrReqType
            // 
            this.comboBoxNwkAddrReqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNwkAddrReqType.FormattingEnabled = true;
            this.comboBoxNwkAddrReqType.Location = new System.Drawing.Point(1497, 90);
            this.comboBoxNwkAddrReqType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNwkAddrReqType.Name = "comboBoxNwkAddrReqType";
            this.comboBoxNwkAddrReqType.Size = new System.Drawing.Size(180, 26);
            this.comboBoxNwkAddrReqType.TabIndex = 64;
            this.comboBoxNwkAddrReqType.MouseEnter += new System.EventHandler(this.comboBoxNwkAddrReqType_MouseEnter);
            this.comboBoxNwkAddrReqType.MouseLeave += new System.EventHandler(this.comboBoxNwkAddrReqType_MouseLeave);
            // 
            // textBoxNwkAddrReqExtAddr
            // 
            this.textBoxNwkAddrReqExtAddr.Location = new System.Drawing.Point(1338, 91);
            this.textBoxNwkAddrReqExtAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNwkAddrReqExtAddr.Name = "textBoxNwkAddrReqExtAddr";
            this.textBoxNwkAddrReqExtAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxNwkAddrReqExtAddr.TabIndex = 63;
            this.textBoxNwkAddrReqExtAddr.MouseEnter += new System.EventHandler(this.textBoxNwkAddrReqExtAddr_MouseEnter);
            this.textBoxNwkAddrReqExtAddr.MouseLeave += new System.EventHandler(this.textBoxNwkAddrReqExtAddr_MouseLeave);
            // 
            // textBoxNwkAddrReqTargetAddr
            // 
            this.textBoxNwkAddrReqTargetAddr.Location = new System.Drawing.Point(1179, 91);
            this.textBoxNwkAddrReqTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNwkAddrReqTargetAddr.Name = "textBoxNwkAddrReqTargetAddr";
            this.textBoxNwkAddrReqTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxNwkAddrReqTargetAddr.TabIndex = 62;
            this.textBoxNwkAddrReqTargetAddr.MouseEnter += new System.EventHandler(this.textBoxNwkAddrReqTargetAddr_MouseEnter);
            this.textBoxNwkAddrReqTargetAddr.MouseLeave += new System.EventHandler(this.textBoxNwkAddrReqTargetAddr_MouseLeave);
            // 
            // textBoxIeeeReqStartIndex
            // 
            this.textBoxIeeeReqStartIndex.Location = new System.Drawing.Point(1688, 50);
            this.textBoxIeeeReqStartIndex.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIeeeReqStartIndex.Name = "textBoxIeeeReqStartIndex";
            this.textBoxIeeeReqStartIndex.Size = new System.Drawing.Size(148, 28);
            this.textBoxIeeeReqStartIndex.TabIndex = 61;
            this.textBoxIeeeReqStartIndex.MouseEnter += new System.EventHandler(this.textBoxIeeeReqStartIndex_MouseEnter);
            this.textBoxIeeeReqStartIndex.MouseLeave += new System.EventHandler(this.textBoxIeeeReqStartIndex_MouseLeave);
            // 
            // comboBoxIeeeReqType
            // 
            this.comboBoxIeeeReqType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIeeeReqType.FormattingEnabled = true;
            this.comboBoxIeeeReqType.Location = new System.Drawing.Point(1497, 50);
            this.comboBoxIeeeReqType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIeeeReqType.Name = "comboBoxIeeeReqType";
            this.comboBoxIeeeReqType.Size = new System.Drawing.Size(180, 26);
            this.comboBoxIeeeReqType.TabIndex = 60;
            this.comboBoxIeeeReqType.MouseEnter += new System.EventHandler(this.comboBoxIeeeReqType_MouseEnter);
            this.comboBoxIeeeReqType.MouseLeave += new System.EventHandler(this.comboBoxIeeeReqType_MouseLeave);
            // 
            // textBoxIeeeReqAddr
            // 
            this.textBoxIeeeReqAddr.Location = new System.Drawing.Point(1338, 51);
            this.textBoxIeeeReqAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIeeeReqAddr.Name = "textBoxIeeeReqAddr";
            this.textBoxIeeeReqAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxIeeeReqAddr.TabIndex = 59;
            this.textBoxIeeeReqAddr.MouseEnter += new System.EventHandler(this.textBoxIeeeReqAddr_MouseEnter);
            this.textBoxIeeeReqAddr.MouseLeave += new System.EventHandler(this.textBoxIeeeReqAddr_MouseLeave);
            // 
            // textBoxIeeeReqTargetAddr
            // 
            this.textBoxIeeeReqTargetAddr.Location = new System.Drawing.Point(1179, 51);
            this.textBoxIeeeReqTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIeeeReqTargetAddr.Name = "textBoxIeeeReqTargetAddr";
            this.textBoxIeeeReqTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxIeeeReqTargetAddr.TabIndex = 58;
            this.textBoxIeeeReqTargetAddr.MouseEnter += new System.EventHandler(this.textBoxIeeeReqTargetAddr_MouseEnter);
            this.textBoxIeeeReqTargetAddr.MouseLeave += new System.EventHandler(this.textBoxIeeeReqTargetAddr_MouseLeave);
            // 
            // textBoxComplexReqAddr
            // 
            this.textBoxComplexReqAddr.Location = new System.Drawing.Point(1179, 256);
            this.textBoxComplexReqAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComplexReqAddr.Name = "textBoxComplexReqAddr";
            this.textBoxComplexReqAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxComplexReqAddr.TabIndex = 53;
            this.textBoxComplexReqAddr.MouseEnter += new System.EventHandler(this.textBoxComplexReqAddr_MouseEnter);
            this.textBoxComplexReqAddr.MouseLeave += new System.EventHandler(this.textBoxComplexReqAddr_MouseLeave);
            // 
            // buttonComplexReq
            // 
            this.buttonComplexReq.Location = new System.Drawing.Point(1058, 253);
            this.buttonComplexReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComplexReq.Name = "buttonComplexReq";
            this.buttonComplexReq.Size = new System.Drawing.Size(112, 32);
            this.buttonComplexReq.TabIndex = 52;
            this.buttonComplexReq.Text = "ComplexReq";
            this.buttonComplexReq.UseVisualStyleBackColor = true;
            this.buttonComplexReq.Click += new System.EventHandler(this.buttonComplexReq_Click);
            // 
            // textBoxMatchReqOutputClusters
            // 
            this.textBoxMatchReqOutputClusters.Location = new System.Drawing.Point(896, 420);
            this.textBoxMatchReqOutputClusters.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatchReqOutputClusters.Name = "textBoxMatchReqOutputClusters";
            this.textBoxMatchReqOutputClusters.Size = new System.Drawing.Size(144, 28);
            this.textBoxMatchReqOutputClusters.TabIndex = 51;
            this.textBoxMatchReqOutputClusters.MouseLeave += new System.EventHandler(this.textBoxMatchReqOutputClusters_MouseLeave);
            this.textBoxMatchReqOutputClusters.MouseHover += new System.EventHandler(this.textBoxMatchReqOutputClusters_MouseHover);
            // 
            // textBoxMatchReqInputClusters
            // 
            this.textBoxMatchReqInputClusters.Location = new System.Drawing.Point(592, 420);
            this.textBoxMatchReqInputClusters.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatchReqInputClusters.Name = "textBoxMatchReqInputClusters";
            this.textBoxMatchReqInputClusters.Size = new System.Drawing.Size(148, 28);
            this.textBoxMatchReqInputClusters.TabIndex = 50;
            this.textBoxMatchReqInputClusters.MouseLeave += new System.EventHandler(this.textBoxMatchReqInputClusters_MouseLeave);
            this.textBoxMatchReqInputClusters.MouseHover += new System.EventHandler(this.textBoxMatchReqInputClusters_MouseHover);
            // 
            // textBoxMatchReqProfileID
            // 
            this.textBoxMatchReqProfileID.Location = new System.Drawing.Point(290, 418);
            this.textBoxMatchReqProfileID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatchReqProfileID.Name = "textBoxMatchReqProfileID";
            this.textBoxMatchReqProfileID.Size = new System.Drawing.Size(148, 28);
            this.textBoxMatchReqProfileID.TabIndex = 49;
            this.textBoxMatchReqProfileID.MouseLeave += new System.EventHandler(this.textBoxMatchReqProfileID_MouseLeave);
            this.textBoxMatchReqProfileID.MouseHover += new System.EventHandler(this.textBoxMatchReqProfileID_MouseHover);
            // 
            // textBoxMatchReqNbrOutputClusters
            // 
            this.textBoxMatchReqNbrOutputClusters.Location = new System.Drawing.Point(752, 420);
            this.textBoxMatchReqNbrOutputClusters.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatchReqNbrOutputClusters.Name = "textBoxMatchReqNbrOutputClusters";
            this.textBoxMatchReqNbrOutputClusters.Size = new System.Drawing.Size(133, 28);
            this.textBoxMatchReqNbrOutputClusters.TabIndex = 48;
            this.textBoxMatchReqNbrOutputClusters.MouseLeave += new System.EventHandler(this.textBoxMatchReqNbrOutputClusters_MouseLeave);
            this.textBoxMatchReqNbrOutputClusters.MouseHover += new System.EventHandler(this.textBoxMatchReqNbrOutputClusters_MouseHover);
            // 
            // textBoxMatchReqNbrInputClusters
            // 
            this.textBoxMatchReqNbrInputClusters.Location = new System.Drawing.Point(448, 420);
            this.textBoxMatchReqNbrInputClusters.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatchReqNbrInputClusters.Name = "textBoxMatchReqNbrInputClusters";
            this.textBoxMatchReqNbrInputClusters.Size = new System.Drawing.Size(133, 28);
            this.textBoxMatchReqNbrInputClusters.TabIndex = 47;
            this.textBoxMatchReqNbrInputClusters.MouseLeave += new System.EventHandler(this.textBoxMatchReqNbrInputClusters_MouseLeave);
            this.textBoxMatchReqNbrInputClusters.MouseHover += new System.EventHandler(this.textBoxMatchReqNbrInputClusters_MouseHover);
            // 
            // textBoxMatchReqAddr
            // 
            this.textBoxMatchReqAddr.Location = new System.Drawing.Point(130, 418);
            this.textBoxMatchReqAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMatchReqAddr.Name = "textBoxMatchReqAddr";
            this.textBoxMatchReqAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxMatchReqAddr.TabIndex = 46;
            this.textBoxMatchReqAddr.MouseLeave += new System.EventHandler(this.textBoxMatchReqAddr_MouseLeave);
            this.textBoxMatchReqAddr.MouseHover += new System.EventHandler(this.textBoxMatchReqAddr_MouseHover);
            // 
            // textBoxActiveEpAddr
            // 
            this.textBoxActiveEpAddr.Location = new System.Drawing.Point(1179, 11);
            this.textBoxActiveEpAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxActiveEpAddr.Name = "textBoxActiveEpAddr";
            this.textBoxActiveEpAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxActiveEpAddr.TabIndex = 45;
            this.textBoxActiveEpAddr.MouseEnter += new System.EventHandler(this.textBoxActiveEpAddr_MouseEnter);
            this.textBoxActiveEpAddr.MouseLeave += new System.EventHandler(this.textBoxActiveEpAddr_MouseLeave);
            // 
            // textBoxPowerReqAddr
            // 
            this.textBoxPowerReqAddr.Location = new System.Drawing.Point(1179, 174);
            this.textBoxPowerReqAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPowerReqAddr.Name = "textBoxPowerReqAddr";
            this.textBoxPowerReqAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxPowerReqAddr.TabIndex = 44;
            this.textBoxPowerReqAddr.MouseEnter += new System.EventHandler(this.textBoxPowerReqAddr_MouseEnter);
            this.textBoxPowerReqAddr.MouseLeave += new System.EventHandler(this.textBoxPowerReqAddr_MouseLeave);
            // 
            // textBoxSimpleReqEndPoint
            // 
            this.textBoxSimpleReqEndPoint.Location = new System.Drawing.Point(1338, 215);
            this.textBoxSimpleReqEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSimpleReqEndPoint.Name = "textBoxSimpleReqEndPoint";
            this.textBoxSimpleReqEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxSimpleReqEndPoint.TabIndex = 43;
            this.textBoxSimpleReqEndPoint.MouseEnter += new System.EventHandler(this.textBoxSimpleReqEndPoint_MouseEnter);
            this.textBoxSimpleReqEndPoint.MouseLeave += new System.EventHandler(this.textBoxSimpleReqEndPoint_MouseLeave);
            // 
            // textBoxSimpleReqAddr
            // 
            this.textBoxSimpleReqAddr.Location = new System.Drawing.Point(1179, 215);
            this.textBoxSimpleReqAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSimpleReqAddr.Name = "textBoxSimpleReqAddr";
            this.textBoxSimpleReqAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxSimpleReqAddr.TabIndex = 42;
            this.textBoxSimpleReqAddr.MouseEnter += new System.EventHandler(this.textBoxSimpleReqAddr_MouseEnter);
            this.textBoxSimpleReqAddr.MouseLeave += new System.EventHandler(this.textBoxSimpleReqAddr_MouseLeave);
            // 
            // buttonMatchReq
            // 
            this.buttonMatchReq.Location = new System.Drawing.Point(9, 415);
            this.buttonMatchReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMatchReq.Name = "buttonMatchReq";
            this.buttonMatchReq.Size = new System.Drawing.Size(112, 32);
            this.buttonMatchReq.TabIndex = 40;
            this.buttonMatchReq.Text = "Match Req";
            this.buttonMatchReq.UseVisualStyleBackColor = true;
            this.buttonMatchReq.Click += new System.EventHandler(this.buttonMatchReq_Click);
            // 
            // buttonActiveEpReq
            // 
            this.buttonActiveEpReq.Location = new System.Drawing.Point(1058, 8);
            this.buttonActiveEpReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActiveEpReq.Name = "buttonActiveEpReq";
            this.buttonActiveEpReq.Size = new System.Drawing.Size(112, 32);
            this.buttonActiveEpReq.TabIndex = 39;
            this.buttonActiveEpReq.Text = "Active Req";
            this.buttonActiveEpReq.UseVisualStyleBackColor = true;
            this.buttonActiveEpReq.Click += new System.EventHandler(this.buttonActiveEpReq_Click);
            // 
            // buttonPowerDescReq
            // 
            this.buttonPowerDescReq.Location = new System.Drawing.Point(1058, 172);
            this.buttonPowerDescReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPowerDescReq.Name = "buttonPowerDescReq";
            this.buttonPowerDescReq.Size = new System.Drawing.Size(112, 32);
            this.buttonPowerDescReq.TabIndex = 38;
            this.buttonPowerDescReq.Text = "Power Req";
            this.buttonPowerDescReq.UseVisualStyleBackColor = true;
            this.buttonPowerDescReq.Click += new System.EventHandler(this.buttonPowerDescReq_Click);
            // 
            // buttonSimpleDescReq
            // 
            this.buttonSimpleDescReq.Location = new System.Drawing.Point(1058, 212);
            this.buttonSimpleDescReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSimpleDescReq.Name = "buttonSimpleDescReq";
            this.buttonSimpleDescReq.Size = new System.Drawing.Size(112, 32);
            this.buttonSimpleDescReq.TabIndex = 37;
            this.buttonSimpleDescReq.Text = "Simple Req";
            this.buttonSimpleDescReq.UseVisualStyleBackColor = true;
            this.buttonSimpleDescReq.Click += new System.EventHandler(this.buttonSimpleDescReq_Click);
            // 
            // textBoxNodeDescReq
            // 
            this.textBoxNodeDescReq.Location = new System.Drawing.Point(1179, 133);
            this.textBoxNodeDescReq.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNodeDescReq.Name = "textBoxNodeDescReq";
            this.textBoxNodeDescReq.Size = new System.Drawing.Size(148, 28);
            this.textBoxNodeDescReq.TabIndex = 36;
            this.textBoxNodeDescReq.MouseEnter += new System.EventHandler(this.textBoxNodeDescReq_MouseEnter);
            this.textBoxNodeDescReq.MouseLeave += new System.EventHandler(this.textBoxNodeDescReq_MouseLeave);
            // 
            // buttonNodeDescReq
            // 
            this.buttonNodeDescReq.Location = new System.Drawing.Point(1058, 130);
            this.buttonNodeDescReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNodeDescReq.Name = "buttonNodeDescReq";
            this.buttonNodeDescReq.Size = new System.Drawing.Size(112, 32);
            this.buttonNodeDescReq.TabIndex = 35;
            this.buttonNodeDescReq.Text = "Node Req";
            this.buttonNodeDescReq.UseVisualStyleBackColor = true;
            this.buttonNodeDescReq.Click += new System.EventHandler(this.buttonNodeDescReq_Click);
            // 
            // buttonIeeeAddrReq
            // 
            this.buttonIeeeAddrReq.Location = new System.Drawing.Point(1058, 48);
            this.buttonIeeeAddrReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIeeeAddrReq.Name = "buttonIeeeAddrReq";
            this.buttonIeeeAddrReq.Size = new System.Drawing.Size(112, 32);
            this.buttonIeeeAddrReq.TabIndex = 34;
            this.buttonIeeeAddrReq.Text = "IEEE Req";
            this.buttonIeeeAddrReq.UseVisualStyleBackColor = true;
            this.buttonIeeeAddrReq.Click += new System.EventHandler(this.buttonIeeeAddrReq_Click);
            // 
            // buttonNwkAddrReq
            // 
            this.buttonNwkAddrReq.Location = new System.Drawing.Point(1058, 89);
            this.buttonNwkAddrReq.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNwkAddrReq.Name = "buttonNwkAddrReq";
            this.buttonNwkAddrReq.Size = new System.Drawing.Size(112, 32);
            this.buttonNwkAddrReq.TabIndex = 33;
            this.buttonNwkAddrReq.Text = "Addr Req";
            this.buttonNwkAddrReq.UseVisualStyleBackColor = true;
            this.buttonNwkAddrReq.Click += new System.EventHandler(this.buttonNwkAddrReq_Click);
            // 
            // comboBoxSecurityKey
            // 
            this.comboBoxSecurityKey.FormattingEnabled = true;
            this.comboBoxSecurityKey.Location = new System.Drawing.Point(720, 132);
            this.comboBoxSecurityKey.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSecurityKey.Name = "comboBoxSecurityKey";
            this.comboBoxSecurityKey.Size = new System.Drawing.Size(331, 26);
            this.comboBoxSecurityKey.TabIndex = 31;
            // 
            // comboBoxPermitJoinTCsignificance
            // 
            this.comboBoxPermitJoinTCsignificance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPermitJoinTCsignificance.FormattingEnabled = true;
            this.comboBoxPermitJoinTCsignificance.Location = new System.Drawing.Point(448, 334);
            this.comboBoxPermitJoinTCsignificance.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPermitJoinTCsignificance.Name = "comboBoxPermitJoinTCsignificance";
            this.comboBoxPermitJoinTCsignificance.Size = new System.Drawing.Size(180, 26);
            this.comboBoxPermitJoinTCsignificance.TabIndex = 30;
            // 
            // textBoxPermitJoinInterval
            // 
            this.textBoxPermitJoinInterval.Location = new System.Drawing.Point(290, 335);
            this.textBoxPermitJoinInterval.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermitJoinInterval.Name = "textBoxPermitJoinInterval";
            this.textBoxPermitJoinInterval.Size = new System.Drawing.Size(148, 28);
            this.textBoxPermitJoinInterval.TabIndex = 29;
            this.textBoxPermitJoinInterval.MouseLeave += new System.EventHandler(this.textBoxPermitJoinInterval_MouseLeave);
            this.textBoxPermitJoinInterval.MouseHover += new System.EventHandler(this.textBoxPermitJoinInterval_MouseHover);
            // 
            // textBoxPermitJoinAddr
            // 
            this.textBoxPermitJoinAddr.Location = new System.Drawing.Point(130, 335);
            this.textBoxPermitJoinAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermitJoinAddr.Name = "textBoxPermitJoinAddr";
            this.textBoxPermitJoinAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxPermitJoinAddr.TabIndex = 28;
            this.textBoxPermitJoinAddr.MouseLeave += new System.EventHandler(this.textBoxPermitJoinAddr_MouseLeave);
            this.textBoxPermitJoinAddr.MouseHover += new System.EventHandler(this.textBoxPermitJoinAddr_MouseHover);
            // 
            // buttonPermitJoin
            // 
            this.buttonPermitJoin.Location = new System.Drawing.Point(9, 335);
            this.buttonPermitJoin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPermitJoin.Name = "buttonPermitJoin";
            this.buttonPermitJoin.Size = new System.Drawing.Size(112, 32);
            this.buttonPermitJoin.TabIndex = 27;
            this.buttonPermitJoin.Text = "Permit Join";
            this.buttonPermitJoin.UseVisualStyleBackColor = true;
            this.buttonPermitJoin.Click += new System.EventHandler(this.buttonPermitJoin_Click);
            // 
            // comboBoxSetKeyType
            // 
            this.comboBoxSetKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetKeyType.FormattingEnabled = true;
            this.comboBoxSetKeyType.Location = new System.Drawing.Point(530, 130);
            this.comboBoxSetKeyType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSetKeyType.Name = "comboBoxSetKeyType";
            this.comboBoxSetKeyType.Size = new System.Drawing.Size(180, 26);
            this.comboBoxSetKeyType.TabIndex = 26;
            // 
            // comboBoxSetKeyState
            // 
            this.comboBoxSetKeyState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetKeyState.FormattingEnabled = true;
            this.comboBoxSetKeyState.Location = new System.Drawing.Point(134, 132);
            this.comboBoxSetKeyState.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSetKeyState.Name = "comboBoxSetKeyState";
            this.comboBoxSetKeyState.Size = new System.Drawing.Size(298, 26);
            this.comboBoxSetKeyState.TabIndex = 25;
            // 
            // comboBoxSetType
            // 
            this.comboBoxSetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetType.FormattingEnabled = true;
            this.comboBoxSetType.Location = new System.Drawing.Point(134, 174);
            this.comboBoxSetType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSetType.Name = "comboBoxSetType";
            this.comboBoxSetType.Size = new System.Drawing.Size(298, 26);
            this.comboBoxSetType.TabIndex = 24;
            // 
            // buttonStartNWK
            // 
            this.buttonStartNWK.Location = new System.Drawing.Point(374, 8);
            this.buttonStartNWK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStartNWK.Name = "buttonStartNWK";
            this.buttonStartNWK.Size = new System.Drawing.Size(112, 32);
            this.buttonStartNWK.TabIndex = 15;
            this.buttonStartNWK.Text = "Start NWK";
            this.buttonStartNWK.UseVisualStyleBackColor = true;
            this.buttonStartNWK.Click += new System.EventHandler(this.buttonStartNWK_Click);
            // 
            // buttonBind
            // 
            this.buttonBind.Location = new System.Drawing.Point(9, 456);
            this.buttonBind.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBind.Name = "buttonBind";
            this.buttonBind.Size = new System.Drawing.Size(112, 32);
            this.buttonBind.TabIndex = 14;
            this.buttonBind.Text = "Bind";
            this.buttonBind.UseVisualStyleBackColor = true;
            this.buttonBind.Click += new System.EventHandler(this.buttonBind_Click);
            // 
            // buttonErasePD
            // 
            this.buttonErasePD.Location = new System.Drawing.Point(9, 8);
            this.buttonErasePD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonErasePD.Name = "buttonErasePD";
            this.buttonErasePD.Size = new System.Drawing.Size(112, 32);
            this.buttonErasePD.TabIndex = 13;
            this.buttonErasePD.Text = "Erase PD";
            this.buttonErasePD.UseVisualStyleBackColor = true;
            this.buttonErasePD.Click += new System.EventHandler(this.buttonErasePD_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(130, 8);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(112, 32);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxSetSecurityKeySeqNbr
            // 
            this.textBoxSetSecurityKeySeqNbr.Location = new System.Drawing.Point(442, 133);
            this.textBoxSetSecurityKeySeqNbr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSetSecurityKeySeqNbr.Name = "textBoxSetSecurityKeySeqNbr";
            this.textBoxSetSecurityKeySeqNbr.Size = new System.Drawing.Size(76, 28);
            this.textBoxSetSecurityKeySeqNbr.TabIndex = 11;
            // 
            // buttonSetDeviceType
            // 
            this.buttonSetDeviceType.Location = new System.Drawing.Point(9, 172);
            this.buttonSetDeviceType.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetDeviceType.Name = "buttonSetDeviceType";
            this.buttonSetDeviceType.Size = new System.Drawing.Size(112, 32);
            this.buttonSetDeviceType.TabIndex = 9;
            this.buttonSetDeviceType.Text = "Set Type";
            this.buttonSetDeviceType.UseVisualStyleBackColor = true;
            this.buttonSetDeviceType.Click += new System.EventHandler(this.buttonSetDeviceType_Click);
            // 
            // buttonSetSecurity
            // 
            this.buttonSetSecurity.Location = new System.Drawing.Point(9, 130);
            this.buttonSetSecurity.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetSecurity.Name = "buttonSetSecurity";
            this.buttonSetSecurity.Size = new System.Drawing.Size(112, 32);
            this.buttonSetSecurity.TabIndex = 7;
            this.buttonSetSecurity.Text = "Set Security";
            this.buttonSetSecurity.UseVisualStyleBackColor = true;
            this.buttonSetSecurity.Click += new System.EventHandler(this.buttonSetSecurity_Click);
            // 
            // textBoxSetEPID
            // 
            this.textBoxSetEPID.Location = new System.Drawing.Point(134, 51);
            this.textBoxSetEPID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSetEPID.Name = "textBoxSetEPID";
            this.textBoxSetEPID.Size = new System.Drawing.Size(298, 28);
            this.textBoxSetEPID.TabIndex = 6;
            this.textBoxSetEPID.MouseLeave += new System.EventHandler(this.textBoxSetEPID_MouseLeave);
            this.textBoxSetEPID.MouseHover += new System.EventHandler(this.textBoxSetEPID_MouseHover);
            // 
            // textBoxSetCMSK
            // 
            this.textBoxSetCMSK.Location = new System.Drawing.Point(134, 91);
            this.textBoxSetCMSK.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSetCMSK.Name = "textBoxSetCMSK";
            this.textBoxSetCMSK.Size = new System.Drawing.Size(298, 28);
            this.textBoxSetCMSK.TabIndex = 5;
            this.textBoxSetCMSK.MouseLeave += new System.EventHandler(this.textBoxSetCMSK_MouseLeave);
            this.textBoxSetCMSK.MouseHover += new System.EventHandler(this.textBoxSetCMSK_MouseHover);
            // 
            // buttonSetCMSK
            // 
            this.buttonSetCMSK.Location = new System.Drawing.Point(9, 89);
            this.buttonSetCMSK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetCMSK.Name = "buttonSetCMSK";
            this.buttonSetCMSK.Size = new System.Drawing.Size(112, 32);
            this.buttonSetCMSK.TabIndex = 3;
            this.buttonSetCMSK.Text = "Set CMSK";
            this.buttonSetCMSK.UseVisualStyleBackColor = true;
            this.buttonSetCMSK.Click += new System.EventHandler(this.buttonSetCMSK_Click);
            // 
            // buttonSetEPID
            // 
            this.buttonSetEPID.Location = new System.Drawing.Point(9, 48);
            this.buttonSetEPID.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetEPID.Name = "buttonSetEPID";
            this.buttonSetEPID.Size = new System.Drawing.Size(112, 32);
            this.buttonSetEPID.TabIndex = 2;
            this.buttonSetEPID.Text = "Set EPID";
            this.buttonSetEPID.UseVisualStyleBackColor = true;
            this.buttonSetEPID.Click += new System.EventHandler(this.buttonSetEPID_Click);
            // 
            // buttonGetVersion
            // 
            this.buttonGetVersion.Location = new System.Drawing.Point(252, 8);
            this.buttonGetVersion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetVersion.Name = "buttonGetVersion";
            this.buttonGetVersion.Size = new System.Drawing.Size(112, 32);
            this.buttonGetVersion.TabIndex = 1;
            this.buttonGetVersion.Text = "Get Version";
            this.buttonGetVersion.UseVisualStyleBackColor = true;
            this.buttonGetVersion.Click += new System.EventHandler(this.buttonGetVersion_Click);
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesStartAttrId);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsProfileID);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsSecurityMode);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsRadius);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsData);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsClusterID);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsDstEP);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsSrcEP);
            this.tabPage12.Controls.Add(this.textBoxRawDataCommandsTargetAddr);
            this.tabPage12.Controls.Add(this.comboBoxRawDataCommandsAddrMode);
            this.tabPage12.Controls.Add(this.buttonRawDataSend);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateNwkManagerAddr);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverCommandsRxGen);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverAttributesExtended);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsMaxCommands);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsManuID);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverCommandsManuSpecific);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsCommandID);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverCommandsDirection);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsClusterID);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsDstEP);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsSrcEP);
            this.tabPage12.Controls.Add(this.textBoxDiscoverCommandsTargetAddr);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverCommandsAddrMode);
            this.tabPage12.Controls.Add(this.buttonDiscoverCommands);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateScanCount);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateScanDuration);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateChannelMask);
            this.tabPage12.Controls.Add(this.textBoxMgmtNwkUpdateTargetAddr);
            this.tabPage12.Controls.Add(this.comboBoxMgmtNwkUpdateAddrMode);
            this.tabPage12.Controls.Add(this.buttonMgmtNwkUpdate);
            this.tabPage12.Controls.Add(this.comboBoxManyToOneRouteRequestCacheRoute);
            this.tabPage12.Controls.Add(this.textBoxManyToOneRouteRequesRadius);
            this.tabPage12.Controls.Add(this.buttonManyToOneRouteRequest);
            this.tabPage12.Controls.Add(this.comboBoxReadReportConfigDirection);
            this.tabPage12.Controls.Add(this.comboBoxReadReportConfigDirIsRx);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigAttribID);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigClusterID);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigDstEP);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigSrcEP);
            this.tabPage12.Controls.Add(this.textBoxReadReportConfigTargetAddr);
            this.tabPage12.Controls.Add(this.comboBoxReadReportConfigAddrMode);
            this.tabPage12.Controls.Add(this.buttonReadReportConfig);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribManuID);
            this.tabPage12.Controls.Add(this.comboBoxWriteAttribManuSpecific);
            this.tabPage12.Controls.Add(this.textBoxReadAttribManuID);
            this.tabPage12.Controls.Add(this.comboBoxReadAttribManuSpecific);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribDataType);
            this.tabPage12.Controls.Add(this.comboBoxConfigReportAddrMode);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribData);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribID);
            this.tabPage12.Controls.Add(this.comboBoxWriteAttribDirection);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribClusterID);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribDstEP);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribSrcEP);
            this.tabPage12.Controls.Add(this.textBoxWriteAttribTargetAddr);
            this.tabPage12.Controls.Add(this.textBoxConfigReportChange);
            this.tabPage12.Controls.Add(this.textBoxConfigReportTimeOut);
            this.tabPage12.Controls.Add(this.textBoxConfigReportMaxInterval);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesMaxIDs);
            this.tabPage12.Controls.Add(this.comboBoxDiscoverAttributesDirection);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesClusterID);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesDstEp);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesSrcEp);
            this.tabPage12.Controls.Add(this.textBoxDiscoverAttributesAddr);
            this.tabPage12.Controls.Add(this.buttonDiscoverAttributes);
            this.tabPage12.Controls.Add(this.comboBoxReadAllAttribDirection);
            this.tabPage12.Controls.Add(this.textBoxReadAllAttribClusterID);
            this.tabPage12.Controls.Add(this.textBoxReadAllAttribDstEP);
            this.tabPage12.Controls.Add(this.textBoxReadAllAttribSrcEP);
            this.tabPage12.Controls.Add(this.textBoxReadAllAttribAddr);
            this.tabPage12.Controls.Add(this.buttonReadAllAttrib);
            this.tabPage12.Controls.Add(this.comboBoxConfigReportAttribDirection);
            this.tabPage12.Controls.Add(this.textBoxConfigReportAttribType);
            this.tabPage12.Controls.Add(this.textBoxConfigReportMinInterval);
            this.tabPage12.Controls.Add(this.textBoxConfigReportAttribID);
            this.tabPage12.Controls.Add(this.comboBoxConfigReportDirection);
            this.tabPage12.Controls.Add(this.textBoxConfigReportClusterID);
            this.tabPage12.Controls.Add(this.textBoxConfigReportDstEP);
            this.tabPage12.Controls.Add(this.textBoxConfigReportSrcEP);
            this.tabPage12.Controls.Add(this.textBoxConfigReportTargetAddr);
            this.tabPage12.Controls.Add(this.buttonConfigReport);
            this.tabPage12.Controls.Add(this.buttonWriteAttrib);
            this.tabPage12.Controls.Add(this.textBoxReadAttribCount);
            this.tabPage12.Controls.Add(this.comboBoxReadAttribDirection);
            this.tabPage12.Controls.Add(this.textBoxReadAttribID1);
            this.tabPage12.Controls.Add(this.textBoxReadAttribClusterID);
            this.tabPage12.Controls.Add(this.textBoxReadAttribDstEP);
            this.tabPage12.Controls.Add(this.textBoxReadAttribSrcEP);
            this.tabPage12.Controls.Add(this.textBoxReadAttribTargetAddr);
            this.tabPage12.Controls.Add(this.buttonReadAttrib);
            this.tabPage12.Location = new System.Drawing.Point(4, 28);
            this.tabPage12.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage12.Size = new System.Drawing.Size(1903, 590);
            this.tabPage12.TabIndex = 12;
            this.tabPage12.Text = "General";
            this.tabPage12.Click += new System.EventHandler(this.tabPage12_Click);
            // 
            // textBoxDiscoverAttributesStartAttrId
            // 
            this.textBoxDiscoverAttributesStartAttrId.Location = new System.Drawing.Point(760, 296);
            this.textBoxDiscoverAttributesStartAttrId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverAttributesStartAttrId.Name = "textBoxDiscoverAttributesStartAttrId";
            this.textBoxDiscoverAttributesStartAttrId.Size = new System.Drawing.Size(152, 28);
            this.textBoxDiscoverAttributesStartAttrId.TabIndex = 98;
            this.textBoxDiscoverAttributesStartAttrId.MouseEnter += new System.EventHandler(this.textBoxDiscoverAttributesStartAttrId_MouseEnter);
            this.textBoxDiscoverAttributesStartAttrId.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesStartAttrId_MouseLeave);
            // 
            // textBoxRawDataCommandsProfileID
            // 
            this.textBoxRawDataCommandsProfileID.Location = new System.Drawing.Point(760, 450);
            this.textBoxRawDataCommandsProfileID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawDataCommandsProfileID.Name = "textBoxRawDataCommandsProfileID";
            this.textBoxRawDataCommandsProfileID.Size = new System.Drawing.Size(154, 28);
            this.textBoxRawDataCommandsProfileID.TabIndex = 97;
            this.textBoxRawDataCommandsProfileID.MouseEnter += new System.EventHandler(this.textBoxRawDataCommandsProfileID_MouseEnter);
            this.textBoxRawDataCommandsProfileID.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsProfileID_MouseLeave);
            // 
            // textBoxRawDataCommandsSecurityMode
            // 
            this.textBoxRawDataCommandsSecurityMode.Location = new System.Drawing.Point(1244, 450);
            this.textBoxRawDataCommandsSecurityMode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawDataCommandsSecurityMode.Name = "textBoxRawDataCommandsSecurityMode";
            this.textBoxRawDataCommandsSecurityMode.Size = new System.Drawing.Size(290, 28);
            this.textBoxRawDataCommandsSecurityMode.TabIndex = 96;
            this.textBoxRawDataCommandsSecurityMode.MouseEnter += new System.EventHandler(this.textBoxRawDataCommandsSecurityMode_MouseEnter);
            this.textBoxRawDataCommandsSecurityMode.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsSecurityMode_MouseLeave);
            // 
            // textBoxRawDataCommandsRadius
            // 
            this.textBoxRawDataCommandsRadius.Location = new System.Drawing.Point(1084, 450);
            this.textBoxRawDataCommandsRadius.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawDataCommandsRadius.Name = "textBoxRawDataCommandsRadius";
            this.textBoxRawDataCommandsRadius.Size = new System.Drawing.Size(148, 28);
            this.textBoxRawDataCommandsRadius.TabIndex = 95;
            this.textBoxRawDataCommandsRadius.MouseEnter += new System.EventHandler(this.textBoxRawDataCommandsRadius_MouseEnter);
            this.textBoxRawDataCommandsRadius.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsRadius_MouseLeave);
            // 
            // textBoxRawDataCommandsData
            // 
            this.textBoxRawDataCommandsData.Location = new System.Drawing.Point(1545, 450);
            this.textBoxRawDataCommandsData.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawDataCommandsData.Name = "textBoxRawDataCommandsData";
            this.textBoxRawDataCommandsData.Size = new System.Drawing.Size(348, 28);
            this.textBoxRawDataCommandsData.TabIndex = 93;
            this.textBoxRawDataCommandsData.MouseEnter += new System.EventHandler(this.textBoxRawDataCommandsData_MouseEnter);
            this.textBoxRawDataCommandsData.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsData_MouseLeave);
            // 
            // textBoxRawDataCommandsClusterID
            // 
            this.textBoxRawDataCommandsClusterID.Location = new System.Drawing.Point(926, 450);
            this.textBoxRawDataCommandsClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawDataCommandsClusterID.Name = "textBoxRawDataCommandsClusterID";
            this.textBoxRawDataCommandsClusterID.Size = new System.Drawing.Size(151, 28);
            this.textBoxRawDataCommandsClusterID.TabIndex = 92;
            this.textBoxRawDataCommandsClusterID.MouseEnter += new System.EventHandler(this.textBoxRawDataCommandsClusterID_MouseEnter);
            this.textBoxRawDataCommandsClusterID.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsClusterID_MouseLeave);
            // 
            // textBoxRawDataCommandsDstEP
            // 
            this.textBoxRawDataCommandsDstEP.Location = new System.Drawing.Point(608, 450);
            this.textBoxRawDataCommandsDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawDataCommandsDstEP.Name = "textBoxRawDataCommandsDstEP";
            this.textBoxRawDataCommandsDstEP.Size = new System.Drawing.Size(144, 28);
            this.textBoxRawDataCommandsDstEP.TabIndex = 91;
            this.textBoxRawDataCommandsDstEP.MouseEnter += new System.EventHandler(this.textBoxRawDataCommandsDstEP_MouseEnter);
            this.textBoxRawDataCommandsDstEP.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsDstEP_MouseLeave);
            // 
            // textBoxRawDataCommandsSrcEP
            // 
            this.textBoxRawDataCommandsSrcEP.Location = new System.Drawing.Point(448, 450);
            this.textBoxRawDataCommandsSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawDataCommandsSrcEP.Name = "textBoxRawDataCommandsSrcEP";
            this.textBoxRawDataCommandsSrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxRawDataCommandsSrcEP.TabIndex = 90;
            this.textBoxRawDataCommandsSrcEP.MouseEnter += new System.EventHandler(this.textBoxRawDataCommandsSrcEP_MouseEnter);
            this.textBoxRawDataCommandsSrcEP.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsSrcEP_MouseLeave);
            // 
            // textBoxRawDataCommandsTargetAddr
            // 
            this.textBoxRawDataCommandsTargetAddr.Location = new System.Drawing.Point(292, 450);
            this.textBoxRawDataCommandsTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRawDataCommandsTargetAddr.Name = "textBoxRawDataCommandsTargetAddr";
            this.textBoxRawDataCommandsTargetAddr.Size = new System.Drawing.Size(146, 28);
            this.textBoxRawDataCommandsTargetAddr.TabIndex = 89;
            this.textBoxRawDataCommandsTargetAddr.MouseEnter += new System.EventHandler(this.textBoxRawDataCommandsTargetAddr_MouseEnter);
            this.textBoxRawDataCommandsTargetAddr.MouseLeave += new System.EventHandler(this.textBoxRawDataCommandsTargetAddr_MouseLeave);
            // 
            // comboBoxRawDataCommandsAddrMode
            // 
            this.comboBoxRawDataCommandsAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRawDataCommandsAddrMode.FormattingEnabled = true;
            this.comboBoxRawDataCommandsAddrMode.Location = new System.Drawing.Point(152, 451);
            this.comboBoxRawDataCommandsAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRawDataCommandsAddrMode.Name = "comboBoxRawDataCommandsAddrMode";
            this.comboBoxRawDataCommandsAddrMode.Size = new System.Drawing.Size(130, 26);
            this.comboBoxRawDataCommandsAddrMode.TabIndex = 88;
            // 
            // buttonRawDataSend
            // 
            this.buttonRawDataSend.Location = new System.Drawing.Point(9, 450);
            this.buttonRawDataSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRawDataSend.Name = "buttonRawDataSend";
            this.buttonRawDataSend.Size = new System.Drawing.Size(134, 30);
            this.buttonRawDataSend.TabIndex = 87;
            this.buttonRawDataSend.Text = "Raw Data";
            this.buttonRawDataSend.UseVisualStyleBackColor = true;
            this.buttonRawDataSend.Click += new System.EventHandler(this.buttonRawDataSend_Click);
            // 
            // textBoxMgmtNwkUpdateNwkManagerAddr
            // 
            this.textBoxMgmtNwkUpdateNwkManagerAddr.Location = new System.Drawing.Point(926, 375);
            this.textBoxMgmtNwkUpdateNwkManagerAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMgmtNwkUpdateNwkManagerAddr.Name = "textBoxMgmtNwkUpdateNwkManagerAddr";
            this.textBoxMgmtNwkUpdateNwkManagerAddr.Size = new System.Drawing.Size(196, 28);
            this.textBoxMgmtNwkUpdateNwkManagerAddr.TabIndex = 86;
            // 
            // comboBoxDiscoverCommandsRxGen
            // 
            this.comboBoxDiscoverCommandsRxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverCommandsRxGen.FormattingEnabled = true;
            this.comboBoxDiscoverCommandsRxGen.Location = new System.Drawing.Point(1712, 413);
            this.comboBoxDiscoverCommandsRxGen.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiscoverCommandsRxGen.Name = "comboBoxDiscoverCommandsRxGen";
            this.comboBoxDiscoverCommandsRxGen.Size = new System.Drawing.Size(133, 26);
            this.comboBoxDiscoverCommandsRxGen.TabIndex = 85;
            // 
            // comboBoxDiscoverAttributesExtended
            // 
            this.comboBoxDiscoverAttributesExtended.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverAttributesExtended.FormattingEnabled = true;
            this.comboBoxDiscoverAttributesExtended.Location = new System.Drawing.Point(1242, 294);
            this.comboBoxDiscoverAttributesExtended.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiscoverAttributesExtended.Name = "comboBoxDiscoverAttributesExtended";
            this.comboBoxDiscoverAttributesExtended.Size = new System.Drawing.Size(146, 26);
            this.comboBoxDiscoverAttributesExtended.TabIndex = 84;
            this.comboBoxDiscoverAttributesExtended.MouseEnter += new System.EventHandler(this.comboBoxDiscoverAttributesExtended_MouseEnter);
            this.comboBoxDiscoverAttributesExtended.MouseLeave += new System.EventHandler(this.comboBoxDiscoverAttributesExtended_MouseLeave);
            // 
            // textBoxDiscoverCommandsMaxCommands
            // 
            this.textBoxDiscoverCommandsMaxCommands.Location = new System.Drawing.Point(1545, 414);
            this.textBoxDiscoverCommandsMaxCommands.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverCommandsMaxCommands.Name = "textBoxDiscoverCommandsMaxCommands";
            this.textBoxDiscoverCommandsMaxCommands.Size = new System.Drawing.Size(156, 28);
            this.textBoxDiscoverCommandsMaxCommands.TabIndex = 83;
            // 
            // textBoxDiscoverCommandsManuID
            // 
            this.textBoxDiscoverCommandsManuID.Location = new System.Drawing.Point(1382, 414);
            this.textBoxDiscoverCommandsManuID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverCommandsManuID.Name = "textBoxDiscoverCommandsManuID";
            this.textBoxDiscoverCommandsManuID.Size = new System.Drawing.Size(156, 28);
            this.textBoxDiscoverCommandsManuID.TabIndex = 82;
            // 
            // comboBoxDiscoverCommandsManuSpecific
            // 
            this.comboBoxDiscoverCommandsManuSpecific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverCommandsManuSpecific.FormattingEnabled = true;
            this.comboBoxDiscoverCommandsManuSpecific.Location = new System.Drawing.Point(1244, 414);
            this.comboBoxDiscoverCommandsManuSpecific.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiscoverCommandsManuSpecific.Name = "comboBoxDiscoverCommandsManuSpecific";
            this.comboBoxDiscoverCommandsManuSpecific.Size = new System.Drawing.Size(127, 26);
            this.comboBoxDiscoverCommandsManuSpecific.TabIndex = 81;
            // 
            // textBoxDiscoverCommandsCommandID
            // 
            this.textBoxDiscoverCommandsCommandID.Location = new System.Drawing.Point(1083, 414);
            this.textBoxDiscoverCommandsCommandID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverCommandsCommandID.Name = "textBoxDiscoverCommandsCommandID";
            this.textBoxDiscoverCommandsCommandID.Size = new System.Drawing.Size(151, 28);
            this.textBoxDiscoverCommandsCommandID.TabIndex = 80;
            // 
            // comboBoxDiscoverCommandsDirection
            // 
            this.comboBoxDiscoverCommandsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverCommandsDirection.FormattingEnabled = true;
            this.comboBoxDiscoverCommandsDirection.Location = new System.Drawing.Point(926, 414);
            this.comboBoxDiscoverCommandsDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiscoverCommandsDirection.Name = "comboBoxDiscoverCommandsDirection";
            this.comboBoxDiscoverCommandsDirection.Size = new System.Drawing.Size(148, 26);
            this.comboBoxDiscoverCommandsDirection.TabIndex = 79;
            // 
            // textBoxDiscoverCommandsClusterID
            // 
            this.textBoxDiscoverCommandsClusterID.Location = new System.Drawing.Point(758, 414);
            this.textBoxDiscoverCommandsClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverCommandsClusterID.Name = "textBoxDiscoverCommandsClusterID";
            this.textBoxDiscoverCommandsClusterID.Size = new System.Drawing.Size(157, 28);
            this.textBoxDiscoverCommandsClusterID.TabIndex = 78;
            // 
            // textBoxDiscoverCommandsDstEP
            // 
            this.textBoxDiscoverCommandsDstEP.Location = new System.Drawing.Point(606, 414);
            this.textBoxDiscoverCommandsDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverCommandsDstEP.Name = "textBoxDiscoverCommandsDstEP";
            this.textBoxDiscoverCommandsDstEP.Size = new System.Drawing.Size(144, 28);
            this.textBoxDiscoverCommandsDstEP.TabIndex = 77;
            // 
            // textBoxDiscoverCommandsSrcEP
            // 
            this.textBoxDiscoverCommandsSrcEP.Location = new System.Drawing.Point(448, 414);
            this.textBoxDiscoverCommandsSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverCommandsSrcEP.Name = "textBoxDiscoverCommandsSrcEP";
            this.textBoxDiscoverCommandsSrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxDiscoverCommandsSrcEP.TabIndex = 76;
            // 
            // textBoxDiscoverCommandsTargetAddr
            // 
            this.textBoxDiscoverCommandsTargetAddr.Location = new System.Drawing.Point(290, 414);
            this.textBoxDiscoverCommandsTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverCommandsTargetAddr.Name = "textBoxDiscoverCommandsTargetAddr";
            this.textBoxDiscoverCommandsTargetAddr.Size = new System.Drawing.Size(146, 28);
            this.textBoxDiscoverCommandsTargetAddr.TabIndex = 75;
            // 
            // comboBoxDiscoverCommandsAddrMode
            // 
            this.comboBoxDiscoverCommandsAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverCommandsAddrMode.FormattingEnabled = true;
            this.comboBoxDiscoverCommandsAddrMode.Location = new System.Drawing.Point(152, 414);
            this.comboBoxDiscoverCommandsAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiscoverCommandsAddrMode.Name = "comboBoxDiscoverCommandsAddrMode";
            this.comboBoxDiscoverCommandsAddrMode.Size = new System.Drawing.Size(130, 26);
            this.comboBoxDiscoverCommandsAddrMode.TabIndex = 74;
            // 
            // buttonDiscoverCommands
            // 
            this.buttonDiscoverCommands.Location = new System.Drawing.Point(9, 411);
            this.buttonDiscoverCommands.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiscoverCommands.Name = "buttonDiscoverCommands";
            this.buttonDiscoverCommands.Size = new System.Drawing.Size(134, 30);
            this.buttonDiscoverCommands.TabIndex = 73;
            this.buttonDiscoverCommands.Text = "Disc Cmds";
            this.buttonDiscoverCommands.UseVisualStyleBackColor = true;
            this.buttonDiscoverCommands.Click += new System.EventHandler(this.buttonDiscoverCommands_Click);
            // 
            // textBoxMgmtNwkUpdateScanCount
            // 
            this.textBoxMgmtNwkUpdateScanCount.Location = new System.Drawing.Point(758, 375);
            this.textBoxMgmtNwkUpdateScanCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMgmtNwkUpdateScanCount.Name = "textBoxMgmtNwkUpdateScanCount";
            this.textBoxMgmtNwkUpdateScanCount.Size = new System.Drawing.Size(157, 28);
            this.textBoxMgmtNwkUpdateScanCount.TabIndex = 72;
            // 
            // textBoxMgmtNwkUpdateScanDuration
            // 
            this.textBoxMgmtNwkUpdateScanDuration.Location = new System.Drawing.Point(606, 375);
            this.textBoxMgmtNwkUpdateScanDuration.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMgmtNwkUpdateScanDuration.Name = "textBoxMgmtNwkUpdateScanDuration";
            this.textBoxMgmtNwkUpdateScanDuration.Size = new System.Drawing.Size(144, 28);
            this.textBoxMgmtNwkUpdateScanDuration.TabIndex = 71;
            // 
            // textBoxMgmtNwkUpdateChannelMask
            // 
            this.textBoxMgmtNwkUpdateChannelMask.Location = new System.Drawing.Point(448, 375);
            this.textBoxMgmtNwkUpdateChannelMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMgmtNwkUpdateChannelMask.Name = "textBoxMgmtNwkUpdateChannelMask";
            this.textBoxMgmtNwkUpdateChannelMask.Size = new System.Drawing.Size(148, 28);
            this.textBoxMgmtNwkUpdateChannelMask.TabIndex = 70;
            // 
            // textBoxMgmtNwkUpdateTargetAddr
            // 
            this.textBoxMgmtNwkUpdateTargetAddr.Location = new System.Drawing.Point(291, 375);
            this.textBoxMgmtNwkUpdateTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMgmtNwkUpdateTargetAddr.Name = "textBoxMgmtNwkUpdateTargetAddr";
            this.textBoxMgmtNwkUpdateTargetAddr.Size = new System.Drawing.Size(146, 28);
            this.textBoxMgmtNwkUpdateTargetAddr.TabIndex = 69;
            // 
            // comboBoxMgmtNwkUpdateAddrMode
            // 
            this.comboBoxMgmtNwkUpdateAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMgmtNwkUpdateAddrMode.FormattingEnabled = true;
            this.comboBoxMgmtNwkUpdateAddrMode.Location = new System.Drawing.Point(152, 375);
            this.comboBoxMgmtNwkUpdateAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMgmtNwkUpdateAddrMode.Name = "comboBoxMgmtNwkUpdateAddrMode";
            this.comboBoxMgmtNwkUpdateAddrMode.Size = new System.Drawing.Size(130, 26);
            this.comboBoxMgmtNwkUpdateAddrMode.TabIndex = 68;
            // 
            // buttonMgmtNwkUpdate
            // 
            this.buttonMgmtNwkUpdate.Location = new System.Drawing.Point(9, 372);
            this.buttonMgmtNwkUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMgmtNwkUpdate.Name = "buttonMgmtNwkUpdate";
            this.buttonMgmtNwkUpdate.Size = new System.Drawing.Size(134, 30);
            this.buttonMgmtNwkUpdate.TabIndex = 67;
            this.buttonMgmtNwkUpdate.Text = "NWK Update";
            this.buttonMgmtNwkUpdate.UseVisualStyleBackColor = true;
            this.buttonMgmtNwkUpdate.Click += new System.EventHandler(this.buttonMgmtNwkUpdate_Click);
            // 
            // comboBoxManyToOneRouteRequestCacheRoute
            // 
            this.comboBoxManyToOneRouteRequestCacheRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManyToOneRouteRequestCacheRoute.FormattingEnabled = true;
            this.comboBoxManyToOneRouteRequestCacheRoute.Location = new System.Drawing.Point(152, 335);
            this.comboBoxManyToOneRouteRequestCacheRoute.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxManyToOneRouteRequestCacheRoute.Name = "comboBoxManyToOneRouteRequestCacheRoute";
            this.comboBoxManyToOneRouteRequestCacheRoute.Size = new System.Drawing.Size(127, 26);
            this.comboBoxManyToOneRouteRequestCacheRoute.TabIndex = 66;
            // 
            // textBoxManyToOneRouteRequesRadius
            // 
            this.textBoxManyToOneRouteRequesRadius.Location = new System.Drawing.Point(291, 335);
            this.textBoxManyToOneRouteRequesRadius.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxManyToOneRouteRequesRadius.Name = "textBoxManyToOneRouteRequesRadius";
            this.textBoxManyToOneRouteRequesRadius.Size = new System.Drawing.Size(146, 28);
            this.textBoxManyToOneRouteRequesRadius.TabIndex = 65;
            // 
            // buttonManyToOneRouteRequest
            // 
            this.buttonManyToOneRouteRequest.Location = new System.Drawing.Point(9, 331);
            this.buttonManyToOneRouteRequest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonManyToOneRouteRequest.Name = "buttonManyToOneRouteRequest";
            this.buttonManyToOneRouteRequest.Size = new System.Drawing.Size(134, 33);
            this.buttonManyToOneRouteRequest.TabIndex = 63;
            this.buttonManyToOneRouteRequest.Text = "MTO Rt Req";
            this.buttonManyToOneRouteRequest.UseVisualStyleBackColor = true;
            this.buttonManyToOneRouteRequest.Click += new System.EventHandler(this.buttonManyToOneRouteRequest_Click);
            // 
            // comboBoxReadReportConfigDirection
            // 
            this.comboBoxReadReportConfigDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadReportConfigDirection.FormattingEnabled = true;
            this.comboBoxReadReportConfigDirection.Location = new System.Drawing.Point(920, 213);
            this.comboBoxReadReportConfigDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReadReportConfigDirection.Name = "comboBoxReadReportConfigDirection";
            this.comboBoxReadReportConfigDirection.Size = new System.Drawing.Size(152, 26);
            this.comboBoxReadReportConfigDirection.TabIndex = 62;
            this.comboBoxReadReportConfigDirection.MouseEnter += new System.EventHandler(this.comboBoxReadReportConfigDirection_MouseEnter);
            this.comboBoxReadReportConfigDirection.MouseLeave += new System.EventHandler(this.comboBoxReadReportConfigDirection_MouseLeave);
            // 
            // comboBoxReadReportConfigDirIsRx
            // 
            this.comboBoxReadReportConfigDirIsRx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadReportConfigDirIsRx.FormattingEnabled = true;
            this.comboBoxReadReportConfigDirIsRx.Location = new System.Drawing.Point(1244, 213);
            this.comboBoxReadReportConfigDirIsRx.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReadReportConfigDirIsRx.Name = "comboBoxReadReportConfigDirIsRx";
            this.comboBoxReadReportConfigDirIsRx.Size = new System.Drawing.Size(146, 26);
            this.comboBoxReadReportConfigDirIsRx.TabIndex = 61;
            this.comboBoxReadReportConfigDirIsRx.MouseEnter += new System.EventHandler(this.comboBoxReadReportConfigDirIsRx_MouseEnter);
            this.comboBoxReadReportConfigDirIsRx.MouseLeave += new System.EventHandler(this.comboBoxReadReportConfigDirIsRx_MouseLeave);
            // 
            // textBoxReadReportConfigAttribID
            // 
            this.textBoxReadReportConfigAttribID.Location = new System.Drawing.Point(1083, 215);
            this.textBoxReadReportConfigAttribID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadReportConfigAttribID.Name = "textBoxReadReportConfigAttribID";
            this.textBoxReadReportConfigAttribID.Size = new System.Drawing.Size(150, 28);
            this.textBoxReadReportConfigAttribID.TabIndex = 60;
            this.textBoxReadReportConfigAttribID.MouseEnter += new System.EventHandler(this.textBoxReadReportConfigAttribID_MouseEnter);
            this.textBoxReadReportConfigAttribID.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigAttribID_MouseLeave);
            // 
            // textBoxReadReportConfigClusterID
            // 
            this.textBoxReadReportConfigClusterID.Location = new System.Drawing.Point(766, 215);
            this.textBoxReadReportConfigClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadReportConfigClusterID.Name = "textBoxReadReportConfigClusterID";
            this.textBoxReadReportConfigClusterID.Size = new System.Drawing.Size(146, 28);
            this.textBoxReadReportConfigClusterID.TabIndex = 59;
            this.textBoxReadReportConfigClusterID.MouseEnter += new System.EventHandler(this.textBoxReadReportConfigClusterID_MouseEnter);
            this.textBoxReadReportConfigClusterID.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigClusterID_MouseLeave);
            // 
            // textBoxReadReportConfigDstEP
            // 
            this.textBoxReadReportConfigDstEP.Location = new System.Drawing.Point(608, 215);
            this.textBoxReadReportConfigDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadReportConfigDstEP.Name = "textBoxReadReportConfigDstEP";
            this.textBoxReadReportConfigDstEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadReportConfigDstEP.TabIndex = 58;
            this.textBoxReadReportConfigDstEP.MouseEnter += new System.EventHandler(this.textBoxReadReportConfigDstEP_MouseEnter);
            this.textBoxReadReportConfigDstEP.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigDstEP_MouseLeave);
            // 
            // textBoxReadReportConfigSrcEP
            // 
            this.textBoxReadReportConfigSrcEP.Location = new System.Drawing.Point(447, 215);
            this.textBoxReadReportConfigSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadReportConfigSrcEP.Name = "textBoxReadReportConfigSrcEP";
            this.textBoxReadReportConfigSrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadReportConfigSrcEP.TabIndex = 57;
            this.textBoxReadReportConfigSrcEP.MouseEnter += new System.EventHandler(this.textBoxReadReportConfigSrcEP_MouseEnter);
            this.textBoxReadReportConfigSrcEP.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigSrcEP_MouseLeave);
            // 
            // textBoxReadReportConfigTargetAddr
            // 
            this.textBoxReadReportConfigTargetAddr.Location = new System.Drawing.Point(288, 215);
            this.textBoxReadReportConfigTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadReportConfigTargetAddr.Name = "textBoxReadReportConfigTargetAddr";
            this.textBoxReadReportConfigTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadReportConfigTargetAddr.TabIndex = 56;
            this.textBoxReadReportConfigTargetAddr.MouseEnter += new System.EventHandler(this.textBoxReadReportConfigTargetAddr_MouseEnter);
            this.textBoxReadReportConfigTargetAddr.MouseLeave += new System.EventHandler(this.textBoxReadReportConfigTargetAddr_MouseLeave);
            // 
            // comboBoxReadReportConfigAddrMode
            // 
            this.comboBoxReadReportConfigAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadReportConfigAddrMode.FormattingEnabled = true;
            this.comboBoxReadReportConfigAddrMode.Location = new System.Drawing.Point(130, 215);
            this.comboBoxReadReportConfigAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReadReportConfigAddrMode.Name = "comboBoxReadReportConfigAddrMode";
            this.comboBoxReadReportConfigAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxReadReportConfigAddrMode.TabIndex = 55;
            this.comboBoxReadReportConfigAddrMode.MouseEnter += new System.EventHandler(this.comboBoxReadReportConfigAddrMode_MouseEnter);
            this.comboBoxReadReportConfigAddrMode.MouseLeave += new System.EventHandler(this.comboBoxReadReportConfigAddrMode_MouseLeave);
            // 
            // buttonReadReportConfig
            // 
            this.buttonReadReportConfig.Location = new System.Drawing.Point(9, 210);
            this.buttonReadReportConfig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadReportConfig.Name = "buttonReadReportConfig";
            this.buttonReadReportConfig.Size = new System.Drawing.Size(112, 33);
            this.buttonReadReportConfig.TabIndex = 54;
            this.buttonReadReportConfig.Text = "Read Rprt";
            this.buttonReadReportConfig.UseVisualStyleBackColor = true;
            this.buttonReadReportConfig.Click += new System.EventHandler(this.buttonReadReportConfig_Click);
            // 
            // textBoxWriteAttribManuID
            // 
            this.textBoxWriteAttribManuID.Location = new System.Drawing.Point(1562, 51);
            this.textBoxWriteAttribManuID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteAttribManuID.Name = "textBoxWriteAttribManuID";
            this.textBoxWriteAttribManuID.Size = new System.Drawing.Size(148, 28);
            this.textBoxWriteAttribManuID.TabIndex = 53;
            this.textBoxWriteAttribManuID.MouseEnter += new System.EventHandler(this.textBoxWriteAttribManuID_MouseEnter);
            this.textBoxWriteAttribManuID.MouseLeave += new System.EventHandler(this.textBoxWriteAttribManuID_MouseLeave);
            // 
            // comboBoxWriteAttribManuSpecific
            // 
            this.comboBoxWriteAttribManuSpecific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWriteAttribManuSpecific.FormattingEnabled = true;
            this.comboBoxWriteAttribManuSpecific.Location = new System.Drawing.Point(1402, 51);
            this.comboBoxWriteAttribManuSpecific.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWriteAttribManuSpecific.Name = "comboBoxWriteAttribManuSpecific";
            this.comboBoxWriteAttribManuSpecific.Size = new System.Drawing.Size(148, 26);
            this.comboBoxWriteAttribManuSpecific.TabIndex = 52;
            this.comboBoxWriteAttribManuSpecific.MouseEnter += new System.EventHandler(this.comboBoxWriteAttribManuSpecific_MouseEnter);
            this.comboBoxWriteAttribManuSpecific.MouseLeave += new System.EventHandler(this.comboBoxWriteAttribManuSpecific_MouseLeave);
            // 
            // textBoxReadAttribManuID
            // 
            this.textBoxReadAttribManuID.Location = new System.Drawing.Point(1402, 11);
            this.textBoxReadAttribManuID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAttribManuID.Name = "textBoxReadAttribManuID";
            this.textBoxReadAttribManuID.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadAttribManuID.TabIndex = 51;
            this.textBoxReadAttribManuID.MouseEnter += new System.EventHandler(this.textBoxReadAttribManuID_MouseEnter);
            this.textBoxReadAttribManuID.MouseLeave += new System.EventHandler(this.textBoxReadAttribManuID_MouseLeave);
            // 
            // comboBoxReadAttribManuSpecific
            // 
            this.comboBoxReadAttribManuSpecific.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadAttribManuSpecific.FormattingEnabled = true;
            this.comboBoxReadAttribManuSpecific.Location = new System.Drawing.Point(1244, 11);
            this.comboBoxReadAttribManuSpecific.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReadAttribManuSpecific.Name = "comboBoxReadAttribManuSpecific";
            this.comboBoxReadAttribManuSpecific.Size = new System.Drawing.Size(148, 26);
            this.comboBoxReadAttribManuSpecific.TabIndex = 50;
            this.comboBoxReadAttribManuSpecific.MouseEnter += new System.EventHandler(this.comboBoxReadAttribManuSpecific_MouseEnter);
            this.comboBoxReadAttribManuSpecific.MouseLeave += new System.EventHandler(this.comboBoxReadAttribManuSpecific_MouseLeave);
            // 
            // textBoxWriteAttribDataType
            // 
            this.textBoxWriteAttribDataType.Location = new System.Drawing.Point(1084, 51);
            this.textBoxWriteAttribDataType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteAttribDataType.Name = "textBoxWriteAttribDataType";
            this.textBoxWriteAttribDataType.Size = new System.Drawing.Size(150, 28);
            this.textBoxWriteAttribDataType.TabIndex = 49;
            this.textBoxWriteAttribDataType.MouseEnter += new System.EventHandler(this.textBoxWriteAttribDataType_MouseEnter);
            this.textBoxWriteAttribDataType.MouseLeave += new System.EventHandler(this.textBoxWriteAttribDataType_MouseLeave);
            // 
            // comboBoxConfigReportAddrMode
            // 
            this.comboBoxConfigReportAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigReportAddrMode.FormattingEnabled = true;
            this.comboBoxConfigReportAddrMode.Location = new System.Drawing.Point(130, 93);
            this.comboBoxConfigReportAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxConfigReportAddrMode.Name = "comboBoxConfigReportAddrMode";
            this.comboBoxConfigReportAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxConfigReportAddrMode.TabIndex = 48;
            this.comboBoxConfigReportAddrMode.MouseEnter += new System.EventHandler(this.comboBoxConfigReportAddrMode_MouseEnter);
            this.comboBoxConfigReportAddrMode.MouseLeave += new System.EventHandler(this.comboBoxConfigReportAddrMode_MouseLeave);
            // 
            // textBoxWriteAttribData
            // 
            this.textBoxWriteAttribData.Location = new System.Drawing.Point(1244, 51);
            this.textBoxWriteAttribData.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteAttribData.Name = "textBoxWriteAttribData";
            this.textBoxWriteAttribData.Size = new System.Drawing.Size(148, 28);
            this.textBoxWriteAttribData.TabIndex = 46;
            this.textBoxWriteAttribData.MouseEnter += new System.EventHandler(this.textBoxWriteAttribData_MouseEnter);
            this.textBoxWriteAttribData.MouseLeave += new System.EventHandler(this.textBoxWriteAttribData_MouseLeave);
            // 
            // textBoxWriteAttribID
            // 
            this.textBoxWriteAttribID.Location = new System.Drawing.Point(926, 51);
            this.textBoxWriteAttribID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteAttribID.Name = "textBoxWriteAttribID";
            this.textBoxWriteAttribID.Size = new System.Drawing.Size(148, 28);
            this.textBoxWriteAttribID.TabIndex = 45;
            this.textBoxWriteAttribID.MouseEnter += new System.EventHandler(this.textBoxWriteAttribID_MouseEnter);
            this.textBoxWriteAttribID.MouseLeave += new System.EventHandler(this.textBoxWriteAttribID_MouseLeave);
            // 
            // comboBoxWriteAttribDirection
            // 
            this.comboBoxWriteAttribDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWriteAttribDirection.FormattingEnabled = true;
            this.comboBoxWriteAttribDirection.Location = new System.Drawing.Point(766, 51);
            this.comboBoxWriteAttribDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxWriteAttribDirection.Name = "comboBoxWriteAttribDirection";
            this.comboBoxWriteAttribDirection.Size = new System.Drawing.Size(148, 26);
            this.comboBoxWriteAttribDirection.TabIndex = 44;
            this.comboBoxWriteAttribDirection.MouseEnter += new System.EventHandler(this.comboBoxWriteAttribDirection_MouseEnter);
            this.comboBoxWriteAttribDirection.MouseLeave += new System.EventHandler(this.comboBoxWriteAttribDirection_MouseLeave);
            // 
            // textBoxWriteAttribClusterID
            // 
            this.textBoxWriteAttribClusterID.Location = new System.Drawing.Point(608, 51);
            this.textBoxWriteAttribClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteAttribClusterID.Name = "textBoxWriteAttribClusterID";
            this.textBoxWriteAttribClusterID.Size = new System.Drawing.Size(148, 28);
            this.textBoxWriteAttribClusterID.TabIndex = 43;
            this.textBoxWriteAttribClusterID.MouseEnter += new System.EventHandler(this.textBoxWriteAttribClusterID_MouseEnter);
            this.textBoxWriteAttribClusterID.MouseLeave += new System.EventHandler(this.textBoxWriteAttribClusterID_MouseLeave);
            // 
            // textBoxWriteAttribDstEP
            // 
            this.textBoxWriteAttribDstEP.Location = new System.Drawing.Point(448, 51);
            this.textBoxWriteAttribDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteAttribDstEP.Name = "textBoxWriteAttribDstEP";
            this.textBoxWriteAttribDstEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxWriteAttribDstEP.TabIndex = 42;
            this.textBoxWriteAttribDstEP.MouseEnter += new System.EventHandler(this.textBoxWriteAttribDstEP_MouseEnter);
            this.textBoxWriteAttribDstEP.MouseLeave += new System.EventHandler(this.textBoxWriteAttribDstEP_MouseLeave);
            // 
            // textBoxWriteAttribSrcEP
            // 
            this.textBoxWriteAttribSrcEP.Location = new System.Drawing.Point(290, 51);
            this.textBoxWriteAttribSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteAttribSrcEP.Name = "textBoxWriteAttribSrcEP";
            this.textBoxWriteAttribSrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxWriteAttribSrcEP.TabIndex = 41;
            this.textBoxWriteAttribSrcEP.MouseEnter += new System.EventHandler(this.textBoxWriteAttribSrcEP_MouseEnter);
            this.textBoxWriteAttribSrcEP.MouseLeave += new System.EventHandler(this.textBoxWriteAttribSrcEP_MouseLeave);
            // 
            // textBoxWriteAttribTargetAddr
            // 
            this.textBoxWriteAttribTargetAddr.Location = new System.Drawing.Point(130, 51);
            this.textBoxWriteAttribTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWriteAttribTargetAddr.Name = "textBoxWriteAttribTargetAddr";
            this.textBoxWriteAttribTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxWriteAttribTargetAddr.TabIndex = 40;
            this.textBoxWriteAttribTargetAddr.MouseEnter += new System.EventHandler(this.textBoxWriteAttribTargetAddr_MouseEnter);
            this.textBoxWriteAttribTargetAddr.MouseLeave += new System.EventHandler(this.textBoxWriteAttribTargetAddr_MouseLeave);
            // 
            // textBoxConfigReportChange
            // 
            this.textBoxConfigReportChange.Location = new System.Drawing.Point(1402, 165);
            this.textBoxConfigReportChange.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportChange.Name = "textBoxConfigReportChange";
            this.textBoxConfigReportChange.Size = new System.Drawing.Size(148, 28);
            this.textBoxConfigReportChange.TabIndex = 39;
            this.textBoxConfigReportChange.MouseEnter += new System.EventHandler(this.textBoxConfigReportChange_MouseEnter);
            this.textBoxConfigReportChange.MouseLeave += new System.EventHandler(this.textBoxConfigReportChange_MouseLeave);
            // 
            // textBoxConfigReportTimeOut
            // 
            this.textBoxConfigReportTimeOut.Location = new System.Drawing.Point(1245, 165);
            this.textBoxConfigReportTimeOut.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportTimeOut.Name = "textBoxConfigReportTimeOut";
            this.textBoxConfigReportTimeOut.Size = new System.Drawing.Size(148, 28);
            this.textBoxConfigReportTimeOut.TabIndex = 38;
            this.textBoxConfigReportTimeOut.MouseEnter += new System.EventHandler(this.textBoxConfigReportTimeOut_MouseEnter);
            this.textBoxConfigReportTimeOut.MouseLeave += new System.EventHandler(this.textBoxConfigReportTimeOut_MouseLeave);
            // 
            // textBoxConfigReportMaxInterval
            // 
            this.textBoxConfigReportMaxInterval.Location = new System.Drawing.Point(1402, 129);
            this.textBoxConfigReportMaxInterval.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportMaxInterval.Name = "textBoxConfigReportMaxInterval";
            this.textBoxConfigReportMaxInterval.Size = new System.Drawing.Size(148, 28);
            this.textBoxConfigReportMaxInterval.TabIndex = 37;
            this.textBoxConfigReportMaxInterval.MouseEnter += new System.EventHandler(this.textBoxConfigReportMaxInterval_MouseEnter);
            this.textBoxConfigReportMaxInterval.MouseLeave += new System.EventHandler(this.textBoxConfigReportMaxInterval_MouseLeave);
            // 
            // textBoxDiscoverAttributesMaxIDs
            // 
            this.textBoxDiscoverAttributesMaxIDs.Location = new System.Drawing.Point(1078, 295);
            this.textBoxDiscoverAttributesMaxIDs.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverAttributesMaxIDs.Name = "textBoxDiscoverAttributesMaxIDs";
            this.textBoxDiscoverAttributesMaxIDs.Size = new System.Drawing.Size(154, 28);
            this.textBoxDiscoverAttributesMaxIDs.TabIndex = 36;
            this.textBoxDiscoverAttributesMaxIDs.MouseEnter += new System.EventHandler(this.textBoxDiscoverAttributesMaxIDs_MouseEnter);
            this.textBoxDiscoverAttributesMaxIDs.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesMaxIDs_MouseLeave);
            // 
            // comboBoxDiscoverAttributesDirection
            // 
            this.comboBoxDiscoverAttributesDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverAttributesDirection.FormattingEnabled = true;
            this.comboBoxDiscoverAttributesDirection.Location = new System.Drawing.Point(920, 295);
            this.comboBoxDiscoverAttributesDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDiscoverAttributesDirection.Name = "comboBoxDiscoverAttributesDirection";
            this.comboBoxDiscoverAttributesDirection.Size = new System.Drawing.Size(148, 26);
            this.comboBoxDiscoverAttributesDirection.TabIndex = 35;
            this.comboBoxDiscoverAttributesDirection.MouseEnter += new System.EventHandler(this.comboBoxDiscoverAttributesDirection_MouseEnter);
            this.comboBoxDiscoverAttributesDirection.MouseLeave += new System.EventHandler(this.comboBoxDiscoverAttributesDirection_MouseLeave);
            // 
            // textBoxDiscoverAttributesClusterID
            // 
            this.textBoxDiscoverAttributesClusterID.Location = new System.Drawing.Point(606, 295);
            this.textBoxDiscoverAttributesClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverAttributesClusterID.Name = "textBoxDiscoverAttributesClusterID";
            this.textBoxDiscoverAttributesClusterID.Size = new System.Drawing.Size(142, 28);
            this.textBoxDiscoverAttributesClusterID.TabIndex = 34;
            this.textBoxDiscoverAttributesClusterID.MouseEnter += new System.EventHandler(this.textBoxDiscoverAttributesClusterID_MouseEnter);
            this.textBoxDiscoverAttributesClusterID.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesClusterID_MouseLeave);
            // 
            // textBoxDiscoverAttributesDstEp
            // 
            this.textBoxDiscoverAttributesDstEp.Location = new System.Drawing.Point(448, 295);
            this.textBoxDiscoverAttributesDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverAttributesDstEp.Name = "textBoxDiscoverAttributesDstEp";
            this.textBoxDiscoverAttributesDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxDiscoverAttributesDstEp.TabIndex = 33;
            this.textBoxDiscoverAttributesDstEp.MouseEnter += new System.EventHandler(this.textBoxDiscoverAttributesDstEp_MouseEnter);
            this.textBoxDiscoverAttributesDstEp.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesDstEp_MouseLeave);
            // 
            // textBoxDiscoverAttributesSrcEp
            // 
            this.textBoxDiscoverAttributesSrcEp.Location = new System.Drawing.Point(290, 295);
            this.textBoxDiscoverAttributesSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverAttributesSrcEp.Name = "textBoxDiscoverAttributesSrcEp";
            this.textBoxDiscoverAttributesSrcEp.Size = new System.Drawing.Size(146, 28);
            this.textBoxDiscoverAttributesSrcEp.TabIndex = 32;
            this.textBoxDiscoverAttributesSrcEp.MouseEnter += new System.EventHandler(this.textBoxDiscoverAttributesSrcEp_MouseEnter);
            this.textBoxDiscoverAttributesSrcEp.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesSrcEp_MouseLeave);
            // 
            // textBoxDiscoverAttributesAddr
            // 
            this.textBoxDiscoverAttributesAddr.Location = new System.Drawing.Point(152, 295);
            this.textBoxDiscoverAttributesAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiscoverAttributesAddr.Name = "textBoxDiscoverAttributesAddr";
            this.textBoxDiscoverAttributesAddr.Size = new System.Drawing.Size(127, 28);
            this.textBoxDiscoverAttributesAddr.TabIndex = 31;
            this.textBoxDiscoverAttributesAddr.MouseEnter += new System.EventHandler(this.textBoxDiscoverAttributesAddr_MouseEnter);
            this.textBoxDiscoverAttributesAddr.MouseLeave += new System.EventHandler(this.textBoxDiscoverAttributesAddr_MouseLeave);
            // 
            // buttonDiscoverAttributes
            // 
            this.buttonDiscoverAttributes.Location = new System.Drawing.Point(9, 292);
            this.buttonDiscoverAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDiscoverAttributes.Name = "buttonDiscoverAttributes";
            this.buttonDiscoverAttributes.Size = new System.Drawing.Size(134, 30);
            this.buttonDiscoverAttributes.TabIndex = 30;
            this.buttonDiscoverAttributes.Text = "Disc Attribs";
            this.buttonDiscoverAttributes.UseVisualStyleBackColor = true;
            this.buttonDiscoverAttributes.Click += new System.EventHandler(this.buttonDiscoverAttributes_Click);
            // 
            // comboBoxReadAllAttribDirection
            // 
            this.comboBoxReadAllAttribDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadAllAttribDirection.FormattingEnabled = true;
            this.comboBoxReadAllAttribDirection.Location = new System.Drawing.Point(760, 255);
            this.comboBoxReadAllAttribDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReadAllAttribDirection.Name = "comboBoxReadAllAttribDirection";
            this.comboBoxReadAllAttribDirection.Size = new System.Drawing.Size(148, 26);
            this.comboBoxReadAllAttribDirection.TabIndex = 29;
            this.comboBoxReadAllAttribDirection.MouseEnter += new System.EventHandler(this.comboBoxReadAllAttribDirection_MouseEnter);
            this.comboBoxReadAllAttribDirection.MouseLeave += new System.EventHandler(this.comboBoxReadAllAttribDirection_MouseLeave);
            // 
            // textBoxReadAllAttribClusterID
            // 
            this.textBoxReadAllAttribClusterID.Location = new System.Drawing.Point(606, 256);
            this.textBoxReadAllAttribClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAllAttribClusterID.Name = "textBoxReadAllAttribClusterID";
            this.textBoxReadAllAttribClusterID.Size = new System.Drawing.Size(144, 28);
            this.textBoxReadAllAttribClusterID.TabIndex = 28;
            this.textBoxReadAllAttribClusterID.MouseEnter += new System.EventHandler(this.textBoxReadAllAttribClusterID_MouseEnter);
            this.textBoxReadAllAttribClusterID.MouseLeave += new System.EventHandler(this.textBoxReadAllAttribClusterID_MouseLeave);
            // 
            // textBoxReadAllAttribDstEP
            // 
            this.textBoxReadAllAttribDstEP.Location = new System.Drawing.Point(448, 256);
            this.textBoxReadAllAttribDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAllAttribDstEP.Name = "textBoxReadAllAttribDstEP";
            this.textBoxReadAllAttribDstEP.Size = new System.Drawing.Size(146, 28);
            this.textBoxReadAllAttribDstEP.TabIndex = 27;
            this.textBoxReadAllAttribDstEP.MouseEnter += new System.EventHandler(this.textBoxReadAllAttribDstEP_MouseEnter);
            this.textBoxReadAllAttribDstEP.MouseLeave += new System.EventHandler(this.textBoxReadAllAttribDstEP_MouseLeave);
            // 
            // textBoxReadAllAttribSrcEP
            // 
            this.textBoxReadAllAttribSrcEP.Location = new System.Drawing.Point(290, 258);
            this.textBoxReadAllAttribSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAllAttribSrcEP.Name = "textBoxReadAllAttribSrcEP";
            this.textBoxReadAllAttribSrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadAllAttribSrcEP.TabIndex = 26;
            this.textBoxReadAllAttribSrcEP.MouseEnter += new System.EventHandler(this.textBoxReadAllAttribSrcEP_MouseEnter);
            this.textBoxReadAllAttribSrcEP.MouseLeave += new System.EventHandler(this.textBoxReadAllAttribSrcEP_MouseLeave);
            // 
            // textBoxReadAllAttribAddr
            // 
            this.textBoxReadAllAttribAddr.Location = new System.Drawing.Point(152, 258);
            this.textBoxReadAllAttribAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAllAttribAddr.Name = "textBoxReadAllAttribAddr";
            this.textBoxReadAllAttribAddr.Size = new System.Drawing.Size(127, 28);
            this.textBoxReadAllAttribAddr.TabIndex = 25;
            this.textBoxReadAllAttribAddr.MouseEnter += new System.EventHandler(this.textBoxReadAllAttribAddr_MouseEnter);
            this.textBoxReadAllAttribAddr.MouseLeave += new System.EventHandler(this.textBoxReadAllAttribAddr_MouseLeave);
            // 
            // buttonReadAllAttrib
            // 
            this.buttonReadAllAttrib.Location = new System.Drawing.Point(9, 256);
            this.buttonReadAllAttrib.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadAllAttrib.Name = "buttonReadAllAttrib";
            this.buttonReadAllAttrib.Size = new System.Drawing.Size(134, 28);
            this.buttonReadAllAttrib.TabIndex = 24;
            this.buttonReadAllAttrib.Text = "Read All Attrib";
            this.buttonReadAllAttrib.UseVisualStyleBackColor = true;
            this.buttonReadAllAttrib.Click += new System.EventHandler(this.buttonReadAllAttrib_Click);
            // 
            // comboBoxConfigReportAttribDirection
            // 
            this.comboBoxConfigReportAttribDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigReportAttribDirection.FormattingEnabled = true;
            this.comboBoxConfigReportAttribDirection.Location = new System.Drawing.Point(1084, 93);
            this.comboBoxConfigReportAttribDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxConfigReportAttribDirection.Name = "comboBoxConfigReportAttribDirection";
            this.comboBoxConfigReportAttribDirection.Size = new System.Drawing.Size(150, 26);
            this.comboBoxConfigReportAttribDirection.TabIndex = 23;
            this.comboBoxConfigReportAttribDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxConfigReportAttribDirection_SelectedIndexChanged);
            this.comboBoxConfigReportAttribDirection.MouseEnter += new System.EventHandler(this.comboBoxConfigReportAttribDirection_MouseEnter);
            this.comboBoxConfigReportAttribDirection.MouseLeave += new System.EventHandler(this.comboBoxConfigReportAttribDirection_MouseLeave);
            // 
            // textBoxConfigReportAttribType
            // 
            this.textBoxConfigReportAttribType.Location = new System.Drawing.Point(1245, 93);
            this.textBoxConfigReportAttribType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportAttribType.Name = "textBoxConfigReportAttribType";
            this.textBoxConfigReportAttribType.Size = new System.Drawing.Size(146, 28);
            this.textBoxConfigReportAttribType.TabIndex = 22;
            this.textBoxConfigReportAttribType.MouseEnter += new System.EventHandler(this.textBoxConfigReportAttribType_MouseEnter);
            this.textBoxConfigReportAttribType.MouseLeave += new System.EventHandler(this.textBoxConfigReportAttribType_MouseLeave);
            // 
            // textBoxConfigReportMinInterval
            // 
            this.textBoxConfigReportMinInterval.Location = new System.Drawing.Point(1245, 129);
            this.textBoxConfigReportMinInterval.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportMinInterval.Name = "textBoxConfigReportMinInterval";
            this.textBoxConfigReportMinInterval.Size = new System.Drawing.Size(148, 28);
            this.textBoxConfigReportMinInterval.TabIndex = 21;
            this.textBoxConfigReportMinInterval.MouseEnter += new System.EventHandler(this.textBoxConfigReportMinInterval_MouseEnter);
            this.textBoxConfigReportMinInterval.MouseLeave += new System.EventHandler(this.textBoxConfigReportMinInterval_MouseLeave);
            // 
            // textBoxConfigReportAttribID
            // 
            this.textBoxConfigReportAttribID.Location = new System.Drawing.Point(1402, 93);
            this.textBoxConfigReportAttribID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportAttribID.Name = "textBoxConfigReportAttribID";
            this.textBoxConfigReportAttribID.Size = new System.Drawing.Size(148, 28);
            this.textBoxConfigReportAttribID.TabIndex = 20;
            this.textBoxConfigReportAttribID.MouseEnter += new System.EventHandler(this.textBoxConfigReportAttribID_MouseEnter);
            this.textBoxConfigReportAttribID.MouseLeave += new System.EventHandler(this.textBoxConfigReportAttribID_MouseLeave);
            // 
            // comboBoxConfigReportDirection
            // 
            this.comboBoxConfigReportDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConfigReportDirection.FormattingEnabled = true;
            this.comboBoxConfigReportDirection.Location = new System.Drawing.Point(926, 93);
            this.comboBoxConfigReportDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxConfigReportDirection.Name = "comboBoxConfigReportDirection";
            this.comboBoxConfigReportDirection.Size = new System.Drawing.Size(148, 26);
            this.comboBoxConfigReportDirection.TabIndex = 16;
            this.comboBoxConfigReportDirection.MouseEnter += new System.EventHandler(this.comboBoxConfigReportDirection_MouseEnter);
            this.comboBoxConfigReportDirection.MouseLeave += new System.EventHandler(this.comboBoxConfigReportDirection_MouseLeave);
            // 
            // textBoxConfigReportClusterID
            // 
            this.textBoxConfigReportClusterID.Location = new System.Drawing.Point(766, 93);
            this.textBoxConfigReportClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportClusterID.Name = "textBoxConfigReportClusterID";
            this.textBoxConfigReportClusterID.Size = new System.Drawing.Size(146, 28);
            this.textBoxConfigReportClusterID.TabIndex = 15;
            this.textBoxConfigReportClusterID.MouseEnter += new System.EventHandler(this.textBoxConfigReportClusterID_MouseEnter);
            this.textBoxConfigReportClusterID.MouseLeave += new System.EventHandler(this.textBoxConfigReportClusterID_MouseLeave);
            // 
            // textBoxConfigReportDstEP
            // 
            this.textBoxConfigReportDstEP.Location = new System.Drawing.Point(608, 93);
            this.textBoxConfigReportDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportDstEP.Name = "textBoxConfigReportDstEP";
            this.textBoxConfigReportDstEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxConfigReportDstEP.TabIndex = 14;
            this.textBoxConfigReportDstEP.MouseEnter += new System.EventHandler(this.textBoxConfigReportDstEP_MouseEnter);
            this.textBoxConfigReportDstEP.MouseLeave += new System.EventHandler(this.textBoxConfigReportDstEP_MouseLeave);
            // 
            // textBoxConfigReportSrcEP
            // 
            this.textBoxConfigReportSrcEP.Location = new System.Drawing.Point(448, 93);
            this.textBoxConfigReportSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportSrcEP.Name = "textBoxConfigReportSrcEP";
            this.textBoxConfigReportSrcEP.Size = new System.Drawing.Size(146, 28);
            this.textBoxConfigReportSrcEP.TabIndex = 13;
            this.textBoxConfigReportSrcEP.MouseEnter += new System.EventHandler(this.textBoxConfigReportSrcEP_MouseEnter);
            this.textBoxConfigReportSrcEP.MouseLeave += new System.EventHandler(this.textBoxConfigReportSrcEP_MouseLeave);
            // 
            // textBoxConfigReportTargetAddr
            // 
            this.textBoxConfigReportTargetAddr.Location = new System.Drawing.Point(290, 93);
            this.textBoxConfigReportTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConfigReportTargetAddr.Name = "textBoxConfigReportTargetAddr";
            this.textBoxConfigReportTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxConfigReportTargetAddr.TabIndex = 12;
            this.textBoxConfigReportTargetAddr.MouseEnter += new System.EventHandler(this.textBoxConfigReportTargetAddr_MouseEnter);
            this.textBoxConfigReportTargetAddr.MouseLeave += new System.EventHandler(this.textBoxConfigReportTargetAddr_MouseLeave);
            // 
            // buttonConfigReport
            // 
            this.buttonConfigReport.Location = new System.Drawing.Point(9, 89);
            this.buttonConfigReport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfigReport.Name = "buttonConfigReport";
            this.buttonConfigReport.Size = new System.Drawing.Size(112, 33);
            this.buttonConfigReport.TabIndex = 11;
            this.buttonConfigReport.Text = "Config Rprt";
            this.buttonConfigReport.UseVisualStyleBackColor = true;
            this.buttonConfigReport.Click += new System.EventHandler(this.buttonConfigReport_Click_1);
            // 
            // buttonWriteAttrib
            // 
            this.buttonWriteAttrib.Location = new System.Drawing.Point(9, 48);
            this.buttonWriteAttrib.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWriteAttrib.Name = "buttonWriteAttrib";
            this.buttonWriteAttrib.Size = new System.Drawing.Size(112, 32);
            this.buttonWriteAttrib.TabIndex = 10;
            this.buttonWriteAttrib.Text = "Write Attrib";
            this.buttonWriteAttrib.UseVisualStyleBackColor = true;
            this.buttonWriteAttrib.Click += new System.EventHandler(this.buttonWriteAttrib_Click_1);
            // 
            // textBoxReadAttribCount
            // 
            this.textBoxReadAttribCount.Location = new System.Drawing.Point(926, 11);
            this.textBoxReadAttribCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAttribCount.Name = "textBoxReadAttribCount";
            this.textBoxReadAttribCount.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadAttribCount.TabIndex = 8;
            this.textBoxReadAttribCount.MouseEnter += new System.EventHandler(this.textBoxReadAttribCount_MouseEnter);
            this.textBoxReadAttribCount.MouseLeave += new System.EventHandler(this.textBoxReadAttribCount_MouseLeave);
            // 
            // comboBoxReadAttribDirection
            // 
            this.comboBoxReadAttribDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadAttribDirection.FormattingEnabled = true;
            this.comboBoxReadAttribDirection.Location = new System.Drawing.Point(766, 11);
            this.comboBoxReadAttribDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxReadAttribDirection.Name = "comboBoxReadAttribDirection";
            this.comboBoxReadAttribDirection.Size = new System.Drawing.Size(148, 26);
            this.comboBoxReadAttribDirection.TabIndex = 7;
            this.comboBoxReadAttribDirection.MouseEnter += new System.EventHandler(this.comboBoxReadAttribDirection_MouseEnter);
            this.comboBoxReadAttribDirection.MouseLeave += new System.EventHandler(this.comboBoxReadAttribDirection_MouseLeave);
            // 
            // textBoxReadAttribID1
            // 
            this.textBoxReadAttribID1.Location = new System.Drawing.Point(1084, 11);
            this.textBoxReadAttribID1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAttribID1.Name = "textBoxReadAttribID1";
            this.textBoxReadAttribID1.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadAttribID1.TabIndex = 6;
            this.textBoxReadAttribID1.MouseEnter += new System.EventHandler(this.textBoxReadAttribID1_MouseEnter);
            this.textBoxReadAttribID1.MouseLeave += new System.EventHandler(this.textBoxReadAttribID1_MouseLeave);
            // 
            // textBoxReadAttribClusterID
            // 
            this.textBoxReadAttribClusterID.Location = new System.Drawing.Point(608, 11);
            this.textBoxReadAttribClusterID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAttribClusterID.Name = "textBoxReadAttribClusterID";
            this.textBoxReadAttribClusterID.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadAttribClusterID.TabIndex = 4;
            this.textBoxReadAttribClusterID.MouseEnter += new System.EventHandler(this.textBoxReadAttribClusterID_MouseEnter);
            this.textBoxReadAttribClusterID.MouseLeave += new System.EventHandler(this.textBoxReadAttribClusterID_MouseLeave);
            // 
            // textBoxReadAttribDstEP
            // 
            this.textBoxReadAttribDstEP.Location = new System.Drawing.Point(448, 11);
            this.textBoxReadAttribDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAttribDstEP.Name = "textBoxReadAttribDstEP";
            this.textBoxReadAttribDstEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadAttribDstEP.TabIndex = 3;
            this.textBoxReadAttribDstEP.MouseEnter += new System.EventHandler(this.textBoxReadAttribDstEP_MouseEnter);
            this.textBoxReadAttribDstEP.MouseLeave += new System.EventHandler(this.textBoxReadAttribDstEP_MouseLeave);
            // 
            // textBoxReadAttribSrcEP
            // 
            this.textBoxReadAttribSrcEP.Location = new System.Drawing.Point(290, 11);
            this.textBoxReadAttribSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAttribSrcEP.Name = "textBoxReadAttribSrcEP";
            this.textBoxReadAttribSrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadAttribSrcEP.TabIndex = 2;
            this.textBoxReadAttribSrcEP.MouseEnter += new System.EventHandler(this.textBoxReadAttribSrcEP_MouseEnter);
            this.textBoxReadAttribSrcEP.MouseLeave += new System.EventHandler(this.textBoxReadAttribSrcEP_MouseLeave);
            // 
            // textBoxReadAttribTargetAddr
            // 
            this.textBoxReadAttribTargetAddr.Location = new System.Drawing.Point(130, 11);
            this.textBoxReadAttribTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReadAttribTargetAddr.Name = "textBoxReadAttribTargetAddr";
            this.textBoxReadAttribTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxReadAttribTargetAddr.TabIndex = 1;
            this.textBoxReadAttribTargetAddr.MouseEnter += new System.EventHandler(this.textBoxReadAttribTargetAddr_MouseEnter);
            this.textBoxReadAttribTargetAddr.MouseLeave += new System.EventHandler(this.textBoxReadAttribTargetAddr_MouseLeave);
            // 
            // buttonReadAttrib
            // 
            this.buttonReadAttrib.Location = new System.Drawing.Point(9, 8);
            this.buttonReadAttrib.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReadAttrib.Name = "buttonReadAttrib";
            this.buttonReadAttrib.Size = new System.Drawing.Size(112, 32);
            this.buttonReadAttrib.TabIndex = 0;
            this.buttonReadAttrib.Text = "Read Attrib";
            this.buttonReadAttrib.UseVisualStyleBackColor = true;
            this.buttonReadAttrib.Click += new System.EventHandler(this.buttonReadAttrib_Click_1);
            // 
            // AHIControl
            // 
            this.AHIControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AHIControl.Controls.Add(this.labelUnimplemented);
            this.AHIControl.Controls.Add(this.comboBoxIPNConfigTimerId);
            this.AHIControl.Controls.Add(this.textBoxIPNConfigDioTxConfInDioMask);
            this.AHIControl.Controls.Add(this.textBoxDioSetOutputOffPinMask);
            this.AHIControl.Controls.Add(this.textBoxDioSetOutputOnPinMask);
            this.AHIControl.Controls.Add(this.buttonDioSetOutput);
            this.AHIControl.Controls.Add(this.textBoxDioSetDirectionOutputPinMask);
            this.AHIControl.Controls.Add(this.textBoxDioSetDirectionInputPinMask);
            this.AHIControl.Controls.Add(this.buttonDioSetDirection);
            this.AHIControl.Controls.Add(this.textBoxIPNConfigPollPeriod);
            this.AHIControl.Controls.Add(this.comboBoxIPNConfigRegisterCallback);
            this.AHIControl.Controls.Add(this.textBoxIPNConfigDioStatusOutDioMask);
            this.AHIControl.Controls.Add(this.textBoxIPNConfigDioRfActiveOutDioMask);
            this.AHIControl.Controls.Add(this.comboBoxIPNConfigEnable);
            this.AHIControl.Controls.Add(this.buttonInPacketNotification);
            this.AHIControl.Location = new System.Drawing.Point(4, 28);
            this.AHIControl.Margin = new System.Windows.Forms.Padding(4);
            this.AHIControl.Name = "AHIControl";
            this.AHIControl.Padding = new System.Windows.Forms.Padding(4);
            this.AHIControl.Size = new System.Drawing.Size(1903, 590);
            this.AHIControl.TabIndex = 16;
            this.AHIControl.Text = "AHI Control";
            // 
            // labelUnimplemented
            // 
            this.labelUnimplemented.AutoSize = true;
            this.labelUnimplemented.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnimplemented.Location = new System.Drawing.Point(728, 260);
            this.labelUnimplemented.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnimplemented.Name = "labelUnimplemented";
            this.labelUnimplemented.Size = new System.Drawing.Size(460, 69);
            this.labelUnimplemented.TabIndex = 15;
            this.labelUnimplemented.Text = "Unimplemented";
            // 
            // comboBoxIPNConfigTimerId
            // 
            this.comboBoxIPNConfigTimerId.FormattingEnabled = true;
            this.comboBoxIPNConfigTimerId.Items.AddRange(new object[] {
            "TIMER 0",
            "TIMER 1",
            "TIMER 2",
            "TIMER 3",
            "TIMER 4"});
            this.comboBoxIPNConfigTimerId.Location = new System.Drawing.Point(1029, 96);
            this.comboBoxIPNConfigTimerId.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIPNConfigTimerId.Name = "comboBoxIPNConfigTimerId";
            this.comboBoxIPNConfigTimerId.Size = new System.Drawing.Size(118, 26);
            this.comboBoxIPNConfigTimerId.TabIndex = 14;
            this.comboBoxIPNConfigTimerId.Visible = false;
            // 
            // textBoxIPNConfigDioTxConfInDioMask
            // 
            this.textBoxIPNConfigDioTxConfInDioMask.Location = new System.Drawing.Point(580, 96);
            this.textBoxIPNConfigDioTxConfInDioMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPNConfigDioTxConfInDioMask.Name = "textBoxIPNConfigDioTxConfInDioMask";
            this.textBoxIPNConfigDioTxConfInDioMask.Size = new System.Drawing.Size(148, 28);
            this.textBoxIPNConfigDioTxConfInDioMask.TabIndex = 13;
            this.textBoxIPNConfigDioTxConfInDioMask.Visible = false;
            // 
            // textBoxDioSetOutputOffPinMask
            // 
            this.textBoxDioSetOutputOffPinMask.Location = new System.Drawing.Point(291, 54);
            this.textBoxDioSetOutputOffPinMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDioSetOutputOffPinMask.Name = "textBoxDioSetOutputOffPinMask";
            this.textBoxDioSetOutputOffPinMask.Size = new System.Drawing.Size(148, 28);
            this.textBoxDioSetOutputOffPinMask.TabIndex = 12;
            this.textBoxDioSetOutputOffPinMask.Visible = false;
            this.textBoxDioSetOutputOffPinMask.MouseEnter += new System.EventHandler(this.textBoxDioSetOutputOffPinMask_MouseEnter);
            this.textBoxDioSetOutputOffPinMask.MouseLeave += new System.EventHandler(this.textBoxDioSetOutputOffPinMask_MouseLeave);
            // 
            // textBoxDioSetOutputOnPinMask
            // 
            this.textBoxDioSetOutputOnPinMask.Location = new System.Drawing.Point(132, 54);
            this.textBoxDioSetOutputOnPinMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDioSetOutputOnPinMask.Name = "textBoxDioSetOutputOnPinMask";
            this.textBoxDioSetOutputOnPinMask.Size = new System.Drawing.Size(148, 28);
            this.textBoxDioSetOutputOnPinMask.TabIndex = 11;
            this.textBoxDioSetOutputOnPinMask.Visible = false;
            this.textBoxDioSetOutputOnPinMask.MouseEnter += new System.EventHandler(this.textBoxDioSetOutputOnPinMask_MouseEnter);
            this.textBoxDioSetOutputOnPinMask.MouseLeave += new System.EventHandler(this.textBoxDioSetOutputOnPinMask_MouseLeave);
            // 
            // buttonDioSetOutput
            // 
            this.buttonDioSetOutput.Location = new System.Drawing.Point(10, 51);
            this.buttonDioSetOutput.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDioSetOutput.Name = "buttonDioSetOutput";
            this.buttonDioSetOutput.Size = new System.Drawing.Size(112, 32);
            this.buttonDioSetOutput.TabIndex = 10;
            this.buttonDioSetOutput.Text = "DIO Set";
            this.buttonDioSetOutput.UseVisualStyleBackColor = true;
            this.buttonDioSetOutput.Visible = false;
            this.buttonDioSetOutput.Click += new System.EventHandler(this.buttonDioSetOutput_Click);
            // 
            // textBoxDioSetDirectionOutputPinMask
            // 
            this.textBoxDioSetDirectionOutputPinMask.Location = new System.Drawing.Point(291, 14);
            this.textBoxDioSetDirectionOutputPinMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDioSetDirectionOutputPinMask.Name = "textBoxDioSetDirectionOutputPinMask";
            this.textBoxDioSetDirectionOutputPinMask.Size = new System.Drawing.Size(148, 28);
            this.textBoxDioSetDirectionOutputPinMask.TabIndex = 9;
            this.textBoxDioSetDirectionOutputPinMask.Visible = false;
            this.textBoxDioSetDirectionOutputPinMask.MouseEnter += new System.EventHandler(this.textBoxDioSetDirectionOutputPinMask_MouseEnter);
            this.textBoxDioSetDirectionOutputPinMask.MouseLeave += new System.EventHandler(this.textBoxDioSetDirectionOutputPinMask_MouseLeave);
            // 
            // textBoxDioSetDirectionInputPinMask
            // 
            this.textBoxDioSetDirectionInputPinMask.Location = new System.Drawing.Point(132, 14);
            this.textBoxDioSetDirectionInputPinMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDioSetDirectionInputPinMask.Name = "textBoxDioSetDirectionInputPinMask";
            this.textBoxDioSetDirectionInputPinMask.Size = new System.Drawing.Size(148, 28);
            this.textBoxDioSetDirectionInputPinMask.TabIndex = 8;
            this.textBoxDioSetDirectionInputPinMask.Visible = false;
            this.textBoxDioSetDirectionInputPinMask.MouseEnter += new System.EventHandler(this.textBoxDioSetDirectionInputPinMask_MouseEnter);
            this.textBoxDioSetDirectionInputPinMask.MouseLeave += new System.EventHandler(this.textBoxDioSetDirectionInputPinMask_MouseLeave);
            // 
            // buttonDioSetDirection
            // 
            this.buttonDioSetDirection.Location = new System.Drawing.Point(10, 11);
            this.buttonDioSetDirection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDioSetDirection.Name = "buttonDioSetDirection";
            this.buttonDioSetDirection.Size = new System.Drawing.Size(112, 32);
            this.buttonDioSetDirection.TabIndex = 6;
            this.buttonDioSetDirection.Text = "DIO Set Dir";
            this.buttonDioSetDirection.UseVisualStyleBackColor = true;
            this.buttonDioSetDirection.Visible = false;
            this.buttonDioSetDirection.Click += new System.EventHandler(this.buttonDioSetDirection_Click);
            // 
            // textBoxIPNConfigPollPeriod
            // 
            this.textBoxIPNConfigPollPeriod.Location = new System.Drawing.Point(868, 96);
            this.textBoxIPNConfigPollPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPNConfigPollPeriod.Name = "textBoxIPNConfigPollPeriod";
            this.textBoxIPNConfigPollPeriod.Size = new System.Drawing.Size(148, 28);
            this.textBoxIPNConfigPollPeriod.TabIndex = 5;
            this.textBoxIPNConfigPollPeriod.Visible = false;
            this.textBoxIPNConfigPollPeriod.MouseEnter += new System.EventHandler(this.textBoxIPNConfigPollPeriod_MouseEnter);
            this.textBoxIPNConfigPollPeriod.MouseLeave += new System.EventHandler(this.textBoxIPNConfigPollPeriod_MouseLeave);
            // 
            // comboBoxIPNConfigRegisterCallback
            // 
            this.comboBoxIPNConfigRegisterCallback.FormattingEnabled = true;
            this.comboBoxIPNConfigRegisterCallback.Items.AddRange(new object[] {
            "DISABLED",
            "ENABLED"});
            this.comboBoxIPNConfigRegisterCallback.Location = new System.Drawing.Point(740, 96);
            this.comboBoxIPNConfigRegisterCallback.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIPNConfigRegisterCallback.Name = "comboBoxIPNConfigRegisterCallback";
            this.comboBoxIPNConfigRegisterCallback.Size = new System.Drawing.Size(118, 26);
            this.comboBoxIPNConfigRegisterCallback.TabIndex = 4;
            this.comboBoxIPNConfigRegisterCallback.Visible = false;
            this.comboBoxIPNConfigRegisterCallback.MouseEnter += new System.EventHandler(this.comboBoxIPNConfigRegisterCallback_MouseEnter);
            this.comboBoxIPNConfigRegisterCallback.MouseLeave += new System.EventHandler(this.comboBoxIPNConfigRegisterCallback_MouseLeave);
            // 
            // textBoxIPNConfigDioStatusOutDioMask
            // 
            this.textBoxIPNConfigDioStatusOutDioMask.Location = new System.Drawing.Point(422, 96);
            this.textBoxIPNConfigDioStatusOutDioMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPNConfigDioStatusOutDioMask.Name = "textBoxIPNConfigDioStatusOutDioMask";
            this.textBoxIPNConfigDioStatusOutDioMask.Size = new System.Drawing.Size(148, 28);
            this.textBoxIPNConfigDioStatusOutDioMask.TabIndex = 3;
            this.textBoxIPNConfigDioStatusOutDioMask.Visible = false;
            this.textBoxIPNConfigDioStatusOutDioMask.MouseEnter += new System.EventHandler(this.textBoxIPNConfigDioOutputPinMask_MouseEnter);
            this.textBoxIPNConfigDioStatusOutDioMask.MouseLeave += new System.EventHandler(this.textBoxIPNConfigDioOutputPinMask_MouseLeave);
            // 
            // textBoxIPNConfigDioRfActiveOutDioMask
            // 
            this.textBoxIPNConfigDioRfActiveOutDioMask.Location = new System.Drawing.Point(261, 96);
            this.textBoxIPNConfigDioRfActiveOutDioMask.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIPNConfigDioRfActiveOutDioMask.Name = "textBoxIPNConfigDioRfActiveOutDioMask";
            this.textBoxIPNConfigDioRfActiveOutDioMask.Size = new System.Drawing.Size(148, 28);
            this.textBoxIPNConfigDioRfActiveOutDioMask.TabIndex = 2;
            this.textBoxIPNConfigDioRfActiveOutDioMask.Visible = false;
            this.textBoxIPNConfigDioRfActiveOutDioMask.MouseEnter += new System.EventHandler(this.textBoxIPNConfigDioInputPinMask_MouseEnter);
            this.textBoxIPNConfigDioRfActiveOutDioMask.MouseLeave += new System.EventHandler(this.textBoxIPNConfigDioInputPinMask_MouseLeave);
            // 
            // comboBoxIPNConfigEnable
            // 
            this.comboBoxIPNConfigEnable.FormattingEnabled = true;
            this.comboBoxIPNConfigEnable.Items.AddRange(new object[] {
            "DISABLE",
            "ENABLE"});
            this.comboBoxIPNConfigEnable.Location = new System.Drawing.Point(132, 94);
            this.comboBoxIPNConfigEnable.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxIPNConfigEnable.Name = "comboBoxIPNConfigEnable";
            this.comboBoxIPNConfigEnable.Size = new System.Drawing.Size(118, 26);
            this.comboBoxIPNConfigEnable.TabIndex = 1;
            this.comboBoxIPNConfigEnable.Visible = false;
            this.comboBoxIPNConfigEnable.MouseEnter += new System.EventHandler(this.comboBoxIPNConfigEnable_MouseEnter);
            this.comboBoxIPNConfigEnable.MouseLeave += new System.EventHandler(this.comboBoxIPNConfigEnable_MouseLeave);
            // 
            // buttonInPacketNotification
            // 
            this.buttonInPacketNotification.Location = new System.Drawing.Point(10, 91);
            this.buttonInPacketNotification.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInPacketNotification.Name = "buttonInPacketNotification";
            this.buttonInPacketNotification.Size = new System.Drawing.Size(112, 32);
            this.buttonInPacketNotification.TabIndex = 0;
            this.buttonInPacketNotification.Text = "IPN Config";
            this.buttonInPacketNotification.UseVisualStyleBackColor = true;
            this.buttonInPacketNotification.Visible = false;
            this.buttonInPacketNotification.Click += new System.EventHandler(this.buttonInPacketNotification_Click);
            // 
            // BasicClusterTab
            // 
            this.BasicClusterTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BasicClusterTab.Controls.Add(this.textBoxBasicResetDstEP);
            this.BasicClusterTab.Controls.Add(this.textBoxBasicResetSrcEP);
            this.BasicClusterTab.Controls.Add(this.textBoxBasicResetTargetAddr);
            this.BasicClusterTab.Controls.Add(this.comboBoxBasicResetTargetAddrMode);
            this.BasicClusterTab.Controls.Add(this.buttonBasicReset);
            this.BasicClusterTab.Location = new System.Drawing.Point(4, 28);
            this.BasicClusterTab.Margin = new System.Windows.Forms.Padding(4);
            this.BasicClusterTab.Name = "BasicClusterTab";
            this.BasicClusterTab.Size = new System.Drawing.Size(1903, 590);
            this.BasicClusterTab.TabIndex = 15;
            this.BasicClusterTab.Text = "Basic Cluster";
            // 
            // textBoxBasicResetDstEP
            // 
            this.textBoxBasicResetDstEP.Location = new System.Drawing.Point(621, 8);
            this.textBoxBasicResetDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBasicResetDstEP.Name = "textBoxBasicResetDstEP";
            this.textBoxBasicResetDstEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxBasicResetDstEP.TabIndex = 4;
            // 
            // textBoxBasicResetSrcEP
            // 
            this.textBoxBasicResetSrcEP.Location = new System.Drawing.Point(462, 8);
            this.textBoxBasicResetSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBasicResetSrcEP.Name = "textBoxBasicResetSrcEP";
            this.textBoxBasicResetSrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxBasicResetSrcEP.TabIndex = 3;
            // 
            // textBoxBasicResetTargetAddr
            // 
            this.textBoxBasicResetTargetAddr.Location = new System.Drawing.Point(303, 8);
            this.textBoxBasicResetTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBasicResetTargetAddr.Name = "textBoxBasicResetTargetAddr";
            this.textBoxBasicResetTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxBasicResetTargetAddr.TabIndex = 2;
            this.textBoxBasicResetTargetAddr.TextChanged += new System.EventHandler(this.textBoxBasicResetTargetAddr_TextChanged);
            // 
            // comboBoxBasicResetTargetAddrMode
            // 
            this.comboBoxBasicResetTargetAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBasicResetTargetAddrMode.FormattingEnabled = true;
            this.comboBoxBasicResetTargetAddrMode.Location = new System.Drawing.Point(144, 8);
            this.comboBoxBasicResetTargetAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBasicResetTargetAddrMode.Name = "comboBoxBasicResetTargetAddrMode";
            this.comboBoxBasicResetTargetAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxBasicResetTargetAddrMode.TabIndex = 1;
            // 
            // buttonBasicReset
            // 
            this.buttonBasicReset.Location = new System.Drawing.Point(4, 4);
            this.buttonBasicReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBasicReset.Name = "buttonBasicReset";
            this.buttonBasicReset.Size = new System.Drawing.Size(130, 35);
            this.buttonBasicReset.TabIndex = 0;
            this.buttonBasicReset.Text = "Reset To FD";
            this.buttonBasicReset.UseVisualStyleBackColor = true;
            this.buttonBasicReset.Click += new System.EventHandler(this.buttonBasicReset_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.buttonAddToList);
            this.tabPage3.Controls.Add(this.textBoxGroupAddIfIdentifyGroupID);
            this.tabPage3.Controls.Add(this.textBoxGroupAddIfIdentifySrcEp);
            this.tabPage3.Controls.Add(this.textBoxGroupAddIfIdentifyDstEp);
            this.tabPage3.Controls.Add(this.textBoxGroupAddIfIndentifyingTargetAddr);
            this.tabPage3.Controls.Add(this.buttonGroupAddIfIdentifying);
            this.tabPage3.Controls.Add(this.textBoxRemoveAllGroupDstEp);
            this.tabPage3.Controls.Add(this.textBoxRemoveAllGroupSrcEp);
            this.tabPage3.Controls.Add(this.textBoxRemoveAllGroupTargetAddr);
            this.tabPage3.Controls.Add(this.buttonGroupRemoveAll);
            this.tabPage3.Controls.Add(this.textBoxRemoveGroupGroupAddr);
            this.tabPage3.Controls.Add(this.textBoxRemoveGroupDstEp);
            this.tabPage3.Controls.Add(this.textBoxRemoveGroupSrcEp);
            this.tabPage3.Controls.Add(this.textBoxRemoveGroupTargetAddr);
            this.tabPage3.Controls.Add(this.buttonRemoveGroup);
            this.tabPage3.Controls.Add(this.textBoxGetGroupCount);
            this.tabPage3.Controls.Add(this.textBoxGetGroupDstEp);
            this.tabPage3.Controls.Add(this.textBoxGetGroupSrcEp);
            this.tabPage3.Controls.Add(this.textBoxGetGroupTargetAddr);
            this.tabPage3.Controls.Add(this.buttonGetGroup);
            this.tabPage3.Controls.Add(this.textBoxViewGroupGroupAddr);
            this.tabPage3.Controls.Add(this.textBoxViewGroupDstEp);
            this.tabPage3.Controls.Add(this.textBoxViewGroupSrcEp);
            this.tabPage3.Controls.Add(this.textBoxViewGroupAddr);
            this.tabPage3.Controls.Add(this.buttonViewGroup);
            this.tabPage3.Controls.Add(this.textBoxAddGroupGroupAddr);
            this.tabPage3.Controls.Add(this.textBoxAddGroupDstEp);
            this.tabPage3.Controls.Add(this.textBoxAddGroupSrcEp);
            this.tabPage3.Controls.Add(this.textBoxAddGroupAddr);
            this.tabPage3.Controls.Add(this.buttonAddGroup);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1903, 590);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Group Cluster";
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(772, 86);
            this.buttonAddToList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(147, 32);
            this.buttonAddToList.TabIndex = 30;
            this.buttonAddToList.Text = "Add Group List";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // textBoxGroupAddIfIdentifyGroupID
            // 
            this.textBoxGroupAddIfIdentifyGroupID.Location = new System.Drawing.Point(603, 209);
            this.textBoxGroupAddIfIdentifyGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupAddIfIdentifyGroupID.Name = "textBoxGroupAddIfIdentifyGroupID";
            this.textBoxGroupAddIfIdentifyGroupID.Size = new System.Drawing.Size(157, 28);
            this.textBoxGroupAddIfIdentifyGroupID.TabIndex = 28;
            // 
            // textBoxGroupAddIfIdentifySrcEp
            // 
            this.textBoxGroupAddIfIdentifySrcEp.Location = new System.Drawing.Point(286, 209);
            this.textBoxGroupAddIfIdentifySrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupAddIfIdentifySrcEp.Name = "textBoxGroupAddIfIdentifySrcEp";
            this.textBoxGroupAddIfIdentifySrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxGroupAddIfIdentifySrcEp.TabIndex = 27;
            // 
            // textBoxGroupAddIfIdentifyDstEp
            // 
            this.textBoxGroupAddIfIdentifyDstEp.Location = new System.Drawing.Point(446, 209);
            this.textBoxGroupAddIfIdentifyDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupAddIfIdentifyDstEp.Name = "textBoxGroupAddIfIdentifyDstEp";
            this.textBoxGroupAddIfIdentifyDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxGroupAddIfIdentifyDstEp.TabIndex = 26;
            this.textBoxGroupAddIfIdentifyDstEp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxGroupAddIfIndentifyingTargetAddr
            // 
            this.textBoxGroupAddIfIndentifyingTargetAddr.Location = new System.Drawing.Point(128, 209);
            this.textBoxGroupAddIfIndentifyingTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGroupAddIfIndentifyingTargetAddr.Name = "textBoxGroupAddIfIndentifyingTargetAddr";
            this.textBoxGroupAddIfIndentifyingTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxGroupAddIfIndentifyingTargetAddr.TabIndex = 25;
            // 
            // buttonGroupAddIfIdentifying
            // 
            this.buttonGroupAddIfIdentifying.Location = new System.Drawing.Point(6, 206);
            this.buttonGroupAddIfIdentifying.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroupAddIfIdentifying.Name = "buttonGroupAddIfIdentifying";
            this.buttonGroupAddIfIdentifying.Size = new System.Drawing.Size(112, 32);
            this.buttonGroupAddIfIdentifying.TabIndex = 24;
            this.buttonGroupAddIfIdentifying.Text = "Add If Ident";
            this.buttonGroupAddIfIdentifying.UseVisualStyleBackColor = true;
            this.buttonGroupAddIfIdentifying.Click += new System.EventHandler(this.buttonGroupAddIfIdentifying_Click);
            // 
            // textBoxRemoveAllGroupDstEp
            // 
            this.textBoxRemoveAllGroupDstEp.Location = new System.Drawing.Point(446, 169);
            this.textBoxRemoveAllGroupDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveAllGroupDstEp.Name = "textBoxRemoveAllGroupDstEp";
            this.textBoxRemoveAllGroupDstEp.Size = new System.Drawing.Size(146, 28);
            this.textBoxRemoveAllGroupDstEp.TabIndex = 23;
            // 
            // textBoxRemoveAllGroupSrcEp
            // 
            this.textBoxRemoveAllGroupSrcEp.Location = new System.Drawing.Point(286, 170);
            this.textBoxRemoveAllGroupSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveAllGroupSrcEp.Name = "textBoxRemoveAllGroupSrcEp";
            this.textBoxRemoveAllGroupSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveAllGroupSrcEp.TabIndex = 22;
            // 
            // textBoxRemoveAllGroupTargetAddr
            // 
            this.textBoxRemoveAllGroupTargetAddr.Location = new System.Drawing.Point(128, 169);
            this.textBoxRemoveAllGroupTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveAllGroupTargetAddr.Name = "textBoxRemoveAllGroupTargetAddr";
            this.textBoxRemoveAllGroupTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveAllGroupTargetAddr.TabIndex = 21;
            // 
            // buttonGroupRemoveAll
            // 
            this.buttonGroupRemoveAll.Location = new System.Drawing.Point(6, 166);
            this.buttonGroupRemoveAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGroupRemoveAll.Name = "buttonGroupRemoveAll";
            this.buttonGroupRemoveAll.Size = new System.Drawing.Size(112, 32);
            this.buttonGroupRemoveAll.TabIndex = 20;
            this.buttonGroupRemoveAll.Text = "Remove All";
            this.buttonGroupRemoveAll.UseVisualStyleBackColor = true;
            this.buttonGroupRemoveAll.Click += new System.EventHandler(this.buttonGroupRemoveAll_Click);
            // 
            // textBoxRemoveGroupGroupAddr
            // 
            this.textBoxRemoveGroupGroupAddr.Location = new System.Drawing.Point(603, 129);
            this.textBoxRemoveGroupGroupAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveGroupGroupAddr.Name = "textBoxRemoveGroupGroupAddr";
            this.textBoxRemoveGroupGroupAddr.Size = new System.Drawing.Size(158, 28);
            this.textBoxRemoveGroupGroupAddr.TabIndex = 19;
            // 
            // textBoxRemoveGroupDstEp
            // 
            this.textBoxRemoveGroupDstEp.Location = new System.Drawing.Point(446, 129);
            this.textBoxRemoveGroupDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveGroupDstEp.Name = "textBoxRemoveGroupDstEp";
            this.textBoxRemoveGroupDstEp.Size = new System.Drawing.Size(146, 28);
            this.textBoxRemoveGroupDstEp.TabIndex = 18;
            // 
            // textBoxRemoveGroupSrcEp
            // 
            this.textBoxRemoveGroupSrcEp.Location = new System.Drawing.Point(286, 129);
            this.textBoxRemoveGroupSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveGroupSrcEp.Name = "textBoxRemoveGroupSrcEp";
            this.textBoxRemoveGroupSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveGroupSrcEp.TabIndex = 17;
            // 
            // textBoxRemoveGroupTargetAddr
            // 
            this.textBoxRemoveGroupTargetAddr.Location = new System.Drawing.Point(128, 129);
            this.textBoxRemoveGroupTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveGroupTargetAddr.Name = "textBoxRemoveGroupTargetAddr";
            this.textBoxRemoveGroupTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveGroupTargetAddr.TabIndex = 16;
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.Location = new System.Drawing.Point(6, 126);
            this.buttonRemoveGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(112, 32);
            this.buttonRemoveGroup.TabIndex = 15;
            this.buttonRemoveGroup.Text = "Remove Grp";
            this.buttonRemoveGroup.UseVisualStyleBackColor = true;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // textBoxGetGroupCount
            // 
            this.textBoxGetGroupCount.Location = new System.Drawing.Point(604, 89);
            this.textBoxGetGroupCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGetGroupCount.Name = "textBoxGetGroupCount";
            this.textBoxGetGroupCount.Size = new System.Drawing.Size(157, 28);
            this.textBoxGetGroupCount.TabIndex = 14;
            // 
            // textBoxGetGroupDstEp
            // 
            this.textBoxGetGroupDstEp.Location = new System.Drawing.Point(446, 89);
            this.textBoxGetGroupDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGetGroupDstEp.Name = "textBoxGetGroupDstEp";
            this.textBoxGetGroupDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxGetGroupDstEp.TabIndex = 13;
            // 
            // textBoxGetGroupSrcEp
            // 
            this.textBoxGetGroupSrcEp.Location = new System.Drawing.Point(286, 89);
            this.textBoxGetGroupSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGetGroupSrcEp.Name = "textBoxGetGroupSrcEp";
            this.textBoxGetGroupSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxGetGroupSrcEp.TabIndex = 12;
            // 
            // textBoxGetGroupTargetAddr
            // 
            this.textBoxGetGroupTargetAddr.Location = new System.Drawing.Point(128, 89);
            this.textBoxGetGroupTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGetGroupTargetAddr.Name = "textBoxGetGroupTargetAddr";
            this.textBoxGetGroupTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxGetGroupTargetAddr.TabIndex = 11;
            // 
            // buttonGetGroup
            // 
            this.buttonGetGroup.Location = new System.Drawing.Point(6, 86);
            this.buttonGetGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetGroup.Name = "buttonGetGroup";
            this.buttonGetGroup.Size = new System.Drawing.Size(112, 32);
            this.buttonGetGroup.TabIndex = 10;
            this.buttonGetGroup.Text = "Get Group";
            this.buttonGetGroup.UseVisualStyleBackColor = true;
            this.buttonGetGroup.Click += new System.EventHandler(this.buttonGetGroup_Click);
            // 
            // textBoxViewGroupGroupAddr
            // 
            this.textBoxViewGroupGroupAddr.Location = new System.Drawing.Point(604, 48);
            this.textBoxViewGroupGroupAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewGroupGroupAddr.Name = "textBoxViewGroupGroupAddr";
            this.textBoxViewGroupGroupAddr.Size = new System.Drawing.Size(157, 28);
            this.textBoxViewGroupGroupAddr.TabIndex = 9;
            // 
            // textBoxViewGroupDstEp
            // 
            this.textBoxViewGroupDstEp.Location = new System.Drawing.Point(446, 48);
            this.textBoxViewGroupDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewGroupDstEp.Name = "textBoxViewGroupDstEp";
            this.textBoxViewGroupDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxViewGroupDstEp.TabIndex = 8;
            // 
            // textBoxViewGroupSrcEp
            // 
            this.textBoxViewGroupSrcEp.Location = new System.Drawing.Point(286, 48);
            this.textBoxViewGroupSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewGroupSrcEp.Name = "textBoxViewGroupSrcEp";
            this.textBoxViewGroupSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxViewGroupSrcEp.TabIndex = 7;
            // 
            // textBoxViewGroupAddr
            // 
            this.textBoxViewGroupAddr.Location = new System.Drawing.Point(128, 48);
            this.textBoxViewGroupAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewGroupAddr.Name = "textBoxViewGroupAddr";
            this.textBoxViewGroupAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxViewGroupAddr.TabIndex = 6;
            // 
            // buttonViewGroup
            // 
            this.buttonViewGroup.Location = new System.Drawing.Point(6, 46);
            this.buttonViewGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewGroup.Name = "buttonViewGroup";
            this.buttonViewGroup.Size = new System.Drawing.Size(112, 32);
            this.buttonViewGroup.TabIndex = 5;
            this.buttonViewGroup.Text = "View Group";
            this.buttonViewGroup.UseVisualStyleBackColor = true;
            this.buttonViewGroup.Click += new System.EventHandler(this.buttonViewGroup_Click);
            // 
            // textBoxAddGroupGroupAddr
            // 
            this.textBoxAddGroupGroupAddr.Location = new System.Drawing.Point(604, 8);
            this.textBoxAddGroupGroupAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddGroupGroupAddr.Name = "textBoxAddGroupGroupAddr";
            this.textBoxAddGroupGroupAddr.Size = new System.Drawing.Size(157, 28);
            this.textBoxAddGroupGroupAddr.TabIndex = 4;
            // 
            // textBoxAddGroupDstEp
            // 
            this.textBoxAddGroupDstEp.Location = new System.Drawing.Point(446, 8);
            this.textBoxAddGroupDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddGroupDstEp.Name = "textBoxAddGroupDstEp";
            this.textBoxAddGroupDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddGroupDstEp.TabIndex = 3;
            // 
            // textBoxAddGroupSrcEp
            // 
            this.textBoxAddGroupSrcEp.Location = new System.Drawing.Point(286, 8);
            this.textBoxAddGroupSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddGroupSrcEp.Name = "textBoxAddGroupSrcEp";
            this.textBoxAddGroupSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddGroupSrcEp.TabIndex = 2;
            // 
            // textBoxAddGroupAddr
            // 
            this.textBoxAddGroupAddr.Location = new System.Drawing.Point(128, 8);
            this.textBoxAddGroupAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddGroupAddr.Name = "textBoxAddGroupAddr";
            this.textBoxAddGroupAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddGroupAddr.TabIndex = 1;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(6, 6);
            this.buttonAddGroup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(112, 32);
            this.buttonAddGroup.TabIndex = 0;
            this.buttonAddGroup.Text = "Add Group";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage5.Controls.Add(this.textBoxIdQueryDstEp);
            this.tabPage5.Controls.Add(this.textBoxIdQuerySrcEp);
            this.tabPage5.Controls.Add(this.textBoxIdQueryAddr);
            this.tabPage5.Controls.Add(this.textBoxIdSendTime);
            this.tabPage5.Controls.Add(this.textBoxIdSendDstEp);
            this.tabPage5.Controls.Add(this.textBoxSendIdSrcEp);
            this.tabPage5.Controls.Add(this.textBoxSendIdAddr);
            this.tabPage5.Controls.Add(this.buttonIdQuery);
            this.tabPage5.Controls.Add(this.buttonIdSend);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1903, 590);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Identify Cluster";
            // 
            // textBoxIdQueryDstEp
            // 
            this.textBoxIdQueryDstEp.Location = new System.Drawing.Point(446, 50);
            this.textBoxIdQueryDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdQueryDstEp.Name = "textBoxIdQueryDstEp";
            this.textBoxIdQueryDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxIdQueryDstEp.TabIndex = 8;
            // 
            // textBoxIdQuerySrcEp
            // 
            this.textBoxIdQuerySrcEp.Location = new System.Drawing.Point(286, 50);
            this.textBoxIdQuerySrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdQuerySrcEp.Name = "textBoxIdQuerySrcEp";
            this.textBoxIdQuerySrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxIdQuerySrcEp.TabIndex = 7;
            // 
            // textBoxIdQueryAddr
            // 
            this.textBoxIdQueryAddr.Location = new System.Drawing.Point(128, 50);
            this.textBoxIdQueryAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdQueryAddr.Name = "textBoxIdQueryAddr";
            this.textBoxIdQueryAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxIdQueryAddr.TabIndex = 6;
            // 
            // textBoxIdSendTime
            // 
            this.textBoxIdSendTime.Location = new System.Drawing.Point(604, 8);
            this.textBoxIdSendTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdSendTime.Name = "textBoxIdSendTime";
            this.textBoxIdSendTime.Size = new System.Drawing.Size(148, 28);
            this.textBoxIdSendTime.TabIndex = 5;
            // 
            // textBoxIdSendDstEp
            // 
            this.textBoxIdSendDstEp.Location = new System.Drawing.Point(446, 8);
            this.textBoxIdSendDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIdSendDstEp.Name = "textBoxIdSendDstEp";
            this.textBoxIdSendDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxIdSendDstEp.TabIndex = 4;
            // 
            // textBoxSendIdSrcEp
            // 
            this.textBoxSendIdSrcEp.Location = new System.Drawing.Point(286, 8);
            this.textBoxSendIdSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSendIdSrcEp.Name = "textBoxSendIdSrcEp";
            this.textBoxSendIdSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxSendIdSrcEp.TabIndex = 3;
            // 
            // textBoxSendIdAddr
            // 
            this.textBoxSendIdAddr.Location = new System.Drawing.Point(128, 8);
            this.textBoxSendIdAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSendIdAddr.Name = "textBoxSendIdAddr";
            this.textBoxSendIdAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxSendIdAddr.TabIndex = 2;
            // 
            // buttonIdQuery
            // 
            this.buttonIdQuery.Location = new System.Drawing.Point(6, 47);
            this.buttonIdQuery.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIdQuery.Name = "buttonIdQuery";
            this.buttonIdQuery.Size = new System.Drawing.Size(112, 32);
            this.buttonIdQuery.TabIndex = 1;
            this.buttonIdQuery.Text = "ID Query";
            this.buttonIdQuery.UseVisualStyleBackColor = true;
            this.buttonIdQuery.Click += new System.EventHandler(this.buttonIdQuery_Click);
            // 
            // buttonIdSend
            // 
            this.buttonIdSend.Location = new System.Drawing.Point(6, 6);
            this.buttonIdSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIdSend.Name = "buttonIdSend";
            this.buttonIdSend.Size = new System.Drawing.Size(112, 32);
            this.buttonIdSend.TabIndex = 0;
            this.buttonIdSend.Text = "ID Send";
            this.buttonIdSend.UseVisualStyleBackColor = true;
            this.buttonIdSend.Click += new System.EventHandler(this.buttonIdSend_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage6.Controls.Add(this.comboBoxMoveToLevelOnOff);
            this.tabPage6.Controls.Add(this.comboBoxMoveToLevelAddrMode);
            this.tabPage6.Controls.Add(this.textBoxMoveToLevelTransTime);
            this.tabPage6.Controls.Add(this.textBoxMoveToLevelLevel);
            this.tabPage6.Controls.Add(this.textBoxMoveToLevelDstEndPoint);
            this.tabPage6.Controls.Add(this.textBoxMoveToLevelSrcEndPoint);
            this.tabPage6.Controls.Add(this.textBoxMoveToLevelAddr);
            this.tabPage6.Controls.Add(this.buttonMoveToLevel);
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1903, 590);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Level Cluster";
            // 
            // comboBoxMoveToLevelOnOff
            // 
            this.comboBoxMoveToLevelOnOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoveToLevelOnOff.FormattingEnabled = true;
            this.comboBoxMoveToLevelOnOff.Location = new System.Drawing.Point(777, 10);
            this.comboBoxMoveToLevelOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMoveToLevelOnOff.Name = "comboBoxMoveToLevelOnOff";
            this.comboBoxMoveToLevelOnOff.Size = new System.Drawing.Size(148, 26);
            this.comboBoxMoveToLevelOnOff.TabIndex = 9;
            // 
            // comboBoxMoveToLevelAddrMode
            // 
            this.comboBoxMoveToLevelAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMoveToLevelAddrMode.FormattingEnabled = true;
            this.comboBoxMoveToLevelAddrMode.Location = new System.Drawing.Point(141, 10);
            this.comboBoxMoveToLevelAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMoveToLevelAddrMode.Name = "comboBoxMoveToLevelAddrMode";
            this.comboBoxMoveToLevelAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxMoveToLevelAddrMode.TabIndex = 7;
            // 
            // textBoxMoveToLevelTransTime
            // 
            this.textBoxMoveToLevelTransTime.Location = new System.Drawing.Point(1095, 10);
            this.textBoxMoveToLevelTransTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToLevelTransTime.Name = "textBoxMoveToLevelTransTime";
            this.textBoxMoveToLevelTransTime.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToLevelTransTime.TabIndex = 6;
            // 
            // textBoxMoveToLevelLevel
            // 
            this.textBoxMoveToLevelLevel.Location = new System.Drawing.Point(936, 10);
            this.textBoxMoveToLevelLevel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToLevelLevel.Name = "textBoxMoveToLevelLevel";
            this.textBoxMoveToLevelLevel.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToLevelLevel.TabIndex = 5;
            // 
            // textBoxMoveToLevelDstEndPoint
            // 
            this.textBoxMoveToLevelDstEndPoint.Location = new System.Drawing.Point(618, 10);
            this.textBoxMoveToLevelDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToLevelDstEndPoint.Name = "textBoxMoveToLevelDstEndPoint";
            this.textBoxMoveToLevelDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToLevelDstEndPoint.TabIndex = 4;
            // 
            // textBoxMoveToLevelSrcEndPoint
            // 
            this.textBoxMoveToLevelSrcEndPoint.Location = new System.Drawing.Point(459, 10);
            this.textBoxMoveToLevelSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToLevelSrcEndPoint.Name = "textBoxMoveToLevelSrcEndPoint";
            this.textBoxMoveToLevelSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToLevelSrcEndPoint.TabIndex = 3;
            // 
            // textBoxMoveToLevelAddr
            // 
            this.textBoxMoveToLevelAddr.Location = new System.Drawing.Point(300, 10);
            this.textBoxMoveToLevelAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToLevelAddr.Name = "textBoxMoveToLevelAddr";
            this.textBoxMoveToLevelAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToLevelAddr.TabIndex = 2;
            // 
            // buttonMoveToLevel
            // 
            this.buttonMoveToLevel.Location = new System.Drawing.Point(4, 7);
            this.buttonMoveToLevel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveToLevel.Name = "buttonMoveToLevel";
            this.buttonMoveToLevel.Size = new System.Drawing.Size(128, 32);
            this.buttonMoveToLevel.TabIndex = 0;
            this.buttonMoveToLevel.Text = "MoveToLevel";
            this.buttonMoveToLevel.UseVisualStyleBackColor = true;
            this.buttonMoveToLevel.Click += new System.EventHandler(this.buttonMoveToLevel_Click_1);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.comboBoxOnOffAddrMode);
            this.tabPage4.Controls.Add(this.comboBoxOnOffCommand);
            this.tabPage4.Controls.Add(this.textBoxOnOffDstEndPoint);
            this.tabPage4.Controls.Add(this.textBoxOnOffSrcEndPoint);
            this.tabPage4.Controls.Add(this.textBoxOnOffAddr);
            this.tabPage4.Controls.Add(this.buttonOnOff);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1903, 590);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "On/Off Cluster";
            // 
            // comboBoxOnOffAddrMode
            // 
            this.comboBoxOnOffAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOnOffAddrMode.FormattingEnabled = true;
            this.comboBoxOnOffAddrMode.Location = new System.Drawing.Point(128, 7);
            this.comboBoxOnOffAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOnOffAddrMode.Name = "comboBoxOnOffAddrMode";
            this.comboBoxOnOffAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxOnOffAddrMode.TabIndex = 6;
            // 
            // comboBoxOnOffCommand
            // 
            this.comboBoxOnOffCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOnOffCommand.FormattingEnabled = true;
            this.comboBoxOnOffCommand.Location = new System.Drawing.Point(764, 7);
            this.comboBoxOnOffCommand.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOnOffCommand.Name = "comboBoxOnOffCommand";
            this.comboBoxOnOffCommand.Size = new System.Drawing.Size(180, 26);
            this.comboBoxOnOffCommand.TabIndex = 5;
            // 
            // textBoxOnOffDstEndPoint
            // 
            this.textBoxOnOffDstEndPoint.Location = new System.Drawing.Point(604, 7);
            this.textBoxOnOffDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOnOffDstEndPoint.Name = "textBoxOnOffDstEndPoint";
            this.textBoxOnOffDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxOnOffDstEndPoint.TabIndex = 4;
            // 
            // textBoxOnOffSrcEndPoint
            // 
            this.textBoxOnOffSrcEndPoint.Location = new System.Drawing.Point(446, 8);
            this.textBoxOnOffSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOnOffSrcEndPoint.Name = "textBoxOnOffSrcEndPoint";
            this.textBoxOnOffSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxOnOffSrcEndPoint.TabIndex = 3;
            // 
            // textBoxOnOffAddr
            // 
            this.textBoxOnOffAddr.Location = new System.Drawing.Point(286, 8);
            this.textBoxOnOffAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOnOffAddr.Name = "textBoxOnOffAddr";
            this.textBoxOnOffAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxOnOffAddr.TabIndex = 2;
            this.textBoxOnOffAddr.TabStop = false;
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.Location = new System.Drawing.Point(6, 6);
            this.buttonOnOff.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(112, 32);
            this.buttonOnOff.TabIndex = 0;
            this.buttonOnOff.Text = "OnOff";
            this.buttonOnOff.UseVisualStyleBackColor = true;
            this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage7.Controls.Add(this.textBoxAddSceneExtensionsLen);
            this.tabPage7.Controls.Add(this.textBoxRemoveSceneSceneID);
            this.tabPage7.Controls.Add(this.textBoxRemoveSceneGroupID);
            this.tabPage7.Controls.Add(this.textBoxRemoveSceneDstEndPoint);
            this.tabPage7.Controls.Add(this.textBoxRemoveSceneSrcEndPoint);
            this.tabPage7.Controls.Add(this.textBoxRemoveSceneAddr);
            this.tabPage7.Controls.Add(this.comboBoxRemoveSceneAddrMode);
            this.tabPage7.Controls.Add(this.buttonRemoveScene);
            this.tabPage7.Controls.Add(this.textBoxRemoveAllScenesGroupID);
            this.tabPage7.Controls.Add(this.textBoxRemoveAllScenesDstEndPoint);
            this.tabPage7.Controls.Add(this.textBoxRemoveAllScenesSrcEndPoint);
            this.tabPage7.Controls.Add(this.textBoxRemoveAllScenesAddr);
            this.tabPage7.Controls.Add(this.comboBoxRemoveAllScenesAddrMode);
            this.tabPage7.Controls.Add(this.buttonRemoveAllScenes);
            this.tabPage7.Controls.Add(this.textBoxGetSceneMembershipGroupID);
            this.tabPage7.Controls.Add(this.textBoxGetSceneMembershipDstEndPoint);
            this.tabPage7.Controls.Add(this.textBoxGetSceneMembershipSrcEndPoint);
            this.tabPage7.Controls.Add(this.textBoxGetSceneMembershipAddr);
            this.tabPage7.Controls.Add(this.comboBoxGetSceneMembershipAddrMode);
            this.tabPage7.Controls.Add(this.buttonGetSceneMembership);
            this.tabPage7.Controls.Add(this.textBoxRecallSceneSceneId);
            this.tabPage7.Controls.Add(this.textBoxRecallSceneGroupId);
            this.tabPage7.Controls.Add(this.textBoxRecallSceneDstEndPoint);
            this.tabPage7.Controls.Add(this.textBoxRecallSceneSrcEndPoint);
            this.tabPage7.Controls.Add(this.textBoxRecallSceneAddr);
            this.tabPage7.Controls.Add(this.comboBoxRecallSceneAddrMode);
            this.tabPage7.Controls.Add(this.buttonRecallScene);
            this.tabPage7.Controls.Add(this.textBoxStoreSceneSceneId);
            this.tabPage7.Controls.Add(this.textBoxStoreSceneGroupId);
            this.tabPage7.Controls.Add(this.textBoxStoreSceneDstEndPoint);
            this.tabPage7.Controls.Add(this.textBoxStoreSceneSrcEndPoint);
            this.tabPage7.Controls.Add(this.textBoxStoreSceneAddr);
            this.tabPage7.Controls.Add(this.comboBoxStoreSceneAddrMode);
            this.tabPage7.Controls.Add(this.buttonStoreScene);
            this.tabPage7.Controls.Add(this.textBoxAddSceneMaxNameLen);
            this.tabPage7.Controls.Add(this.textBoxAddSceneNameLen);
            this.tabPage7.Controls.Add(this.textBoxAddSceneName);
            this.tabPage7.Controls.Add(this.textBoxAddSceneTransTime);
            this.tabPage7.Controls.Add(this.textBoxAddSceneSceneId);
            this.tabPage7.Controls.Add(this.textBoxAddSceneGroupId);
            this.tabPage7.Controls.Add(this.textBoxAddSceneDstEndPoint);
            this.tabPage7.Controls.Add(this.textBoxAddSceneSrcEndPoint);
            this.tabPage7.Controls.Add(this.textBoxAddSceneAddr);
            this.tabPage7.Controls.Add(this.comboBoxAddSceneAddrMode);
            this.tabPage7.Controls.Add(this.buttonAddScene);
            this.tabPage7.Controls.Add(this.comboBoxViewSceneAddrMode);
            this.tabPage7.Controls.Add(this.textBoxViewSceneSceneId);
            this.tabPage7.Controls.Add(this.textBoxViewSceneGroupId);
            this.tabPage7.Controls.Add(this.textBoxViewSceneDstEndPoint);
            this.tabPage7.Controls.Add(this.textBoxViewSceneSrcEndPoint);
            this.tabPage7.Controls.Add(this.textBoxViewSceneAddr);
            this.tabPage7.Controls.Add(this.buttonViewScene);
            this.tabPage7.Location = new System.Drawing.Point(4, 28);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1903, 590);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Scenes Cluster";
            // 
            // textBoxRemoveSceneSceneID
            // 
            this.textBoxRemoveSceneSceneID.Location = new System.Drawing.Point(921, 252);
            this.textBoxRemoveSceneSceneID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveSceneSceneID.Name = "textBoxRemoveSceneSceneID";
            this.textBoxRemoveSceneSceneID.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveSceneSceneID.TabIndex = 50;
            // 
            // textBoxRemoveSceneGroupID
            // 
            this.textBoxRemoveSceneGroupID.Location = new System.Drawing.Point(762, 253);
            this.textBoxRemoveSceneGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveSceneGroupID.Name = "textBoxRemoveSceneGroupID";
            this.textBoxRemoveSceneGroupID.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveSceneGroupID.TabIndex = 49;
            // 
            // textBoxRemoveSceneDstEndPoint
            // 
            this.textBoxRemoveSceneDstEndPoint.Location = new System.Drawing.Point(603, 252);
            this.textBoxRemoveSceneDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveSceneDstEndPoint.Name = "textBoxRemoveSceneDstEndPoint";
            this.textBoxRemoveSceneDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveSceneDstEndPoint.TabIndex = 48;
            // 
            // textBoxRemoveSceneSrcEndPoint
            // 
            this.textBoxRemoveSceneSrcEndPoint.Location = new System.Drawing.Point(444, 252);
            this.textBoxRemoveSceneSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveSceneSrcEndPoint.Name = "textBoxRemoveSceneSrcEndPoint";
            this.textBoxRemoveSceneSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveSceneSrcEndPoint.TabIndex = 47;
            // 
            // textBoxRemoveSceneAddr
            // 
            this.textBoxRemoveSceneAddr.Location = new System.Drawing.Point(285, 252);
            this.textBoxRemoveSceneAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveSceneAddr.Name = "textBoxRemoveSceneAddr";
            this.textBoxRemoveSceneAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveSceneAddr.TabIndex = 46;
            // 
            // comboBoxRemoveSceneAddrMode
            // 
            this.comboBoxRemoveSceneAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemoveSceneAddrMode.FormattingEnabled = true;
            this.comboBoxRemoveSceneAddrMode.Location = new System.Drawing.Point(126, 252);
            this.comboBoxRemoveSceneAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRemoveSceneAddrMode.Name = "comboBoxRemoveSceneAddrMode";
            this.comboBoxRemoveSceneAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxRemoveSceneAddrMode.TabIndex = 45;
            // 
            // buttonRemoveScene
            // 
            this.buttonRemoveScene.Location = new System.Drawing.Point(4, 248);
            this.buttonRemoveScene.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveScene.Name = "buttonRemoveScene";
            this.buttonRemoveScene.Size = new System.Drawing.Size(112, 35);
            this.buttonRemoveScene.TabIndex = 44;
            this.buttonRemoveScene.Text = "Remove";
            this.buttonRemoveScene.UseVisualStyleBackColor = true;
            this.buttonRemoveScene.Click += new System.EventHandler(this.buttonRemoveScene_Click);
            // 
            // textBoxRemoveAllScenesGroupID
            // 
            this.textBoxRemoveAllScenesGroupID.Location = new System.Drawing.Point(762, 209);
            this.textBoxRemoveAllScenesGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveAllScenesGroupID.Name = "textBoxRemoveAllScenesGroupID";
            this.textBoxRemoveAllScenesGroupID.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveAllScenesGroupID.TabIndex = 43;
            // 
            // textBoxRemoveAllScenesDstEndPoint
            // 
            this.textBoxRemoveAllScenesDstEndPoint.Location = new System.Drawing.Point(603, 209);
            this.textBoxRemoveAllScenesDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveAllScenesDstEndPoint.Name = "textBoxRemoveAllScenesDstEndPoint";
            this.textBoxRemoveAllScenesDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveAllScenesDstEndPoint.TabIndex = 42;
            // 
            // textBoxRemoveAllScenesSrcEndPoint
            // 
            this.textBoxRemoveAllScenesSrcEndPoint.Location = new System.Drawing.Point(444, 209);
            this.textBoxRemoveAllScenesSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveAllScenesSrcEndPoint.Name = "textBoxRemoveAllScenesSrcEndPoint";
            this.textBoxRemoveAllScenesSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveAllScenesSrcEndPoint.TabIndex = 41;
            // 
            // textBoxRemoveAllScenesAddr
            // 
            this.textBoxRemoveAllScenesAddr.Location = new System.Drawing.Point(285, 209);
            this.textBoxRemoveAllScenesAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRemoveAllScenesAddr.Name = "textBoxRemoveAllScenesAddr";
            this.textBoxRemoveAllScenesAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxRemoveAllScenesAddr.TabIndex = 40;
            // 
            // comboBoxRemoveAllScenesAddrMode
            // 
            this.comboBoxRemoveAllScenesAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemoveAllScenesAddrMode.FormattingEnabled = true;
            this.comboBoxRemoveAllScenesAddrMode.Location = new System.Drawing.Point(126, 209);
            this.comboBoxRemoveAllScenesAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRemoveAllScenesAddrMode.Name = "comboBoxRemoveAllScenesAddrMode";
            this.comboBoxRemoveAllScenesAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxRemoveAllScenesAddrMode.TabIndex = 39;
            // 
            // buttonRemoveAllScenes
            // 
            this.buttonRemoveAllScenes.Location = new System.Drawing.Point(4, 205);
            this.buttonRemoveAllScenes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveAllScenes.Name = "buttonRemoveAllScenes";
            this.buttonRemoveAllScenes.Size = new System.Drawing.Size(112, 35);
            this.buttonRemoveAllScenes.TabIndex = 38;
            this.buttonRemoveAllScenes.Text = "Remove All";
            this.buttonRemoveAllScenes.UseVisualStyleBackColor = true;
            this.buttonRemoveAllScenes.Click += new System.EventHandler(this.buttonRemoveAllScenes_Click);
            // 
            // textBoxGetSceneMembershipGroupID
            // 
            this.textBoxGetSceneMembershipGroupID.Location = new System.Drawing.Point(762, 168);
            this.textBoxGetSceneMembershipGroupID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGetSceneMembershipGroupID.Name = "textBoxGetSceneMembershipGroupID";
            this.textBoxGetSceneMembershipGroupID.Size = new System.Drawing.Size(148, 28);
            this.textBoxGetSceneMembershipGroupID.TabIndex = 37;
            // 
            // textBoxGetSceneMembershipDstEndPoint
            // 
            this.textBoxGetSceneMembershipDstEndPoint.Location = new System.Drawing.Point(603, 168);
            this.textBoxGetSceneMembershipDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGetSceneMembershipDstEndPoint.Name = "textBoxGetSceneMembershipDstEndPoint";
            this.textBoxGetSceneMembershipDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxGetSceneMembershipDstEndPoint.TabIndex = 36;
            // 
            // textBoxGetSceneMembershipSrcEndPoint
            // 
            this.textBoxGetSceneMembershipSrcEndPoint.Location = new System.Drawing.Point(444, 168);
            this.textBoxGetSceneMembershipSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGetSceneMembershipSrcEndPoint.Name = "textBoxGetSceneMembershipSrcEndPoint";
            this.textBoxGetSceneMembershipSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxGetSceneMembershipSrcEndPoint.TabIndex = 35;
            // 
            // textBoxGetSceneMembershipAddr
            // 
            this.textBoxGetSceneMembershipAddr.Location = new System.Drawing.Point(285, 168);
            this.textBoxGetSceneMembershipAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGetSceneMembershipAddr.Name = "textBoxGetSceneMembershipAddr";
            this.textBoxGetSceneMembershipAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxGetSceneMembershipAddr.TabIndex = 34;
            // 
            // comboBoxGetSceneMembershipAddrMode
            // 
            this.comboBoxGetSceneMembershipAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGetSceneMembershipAddrMode.FormattingEnabled = true;
            this.comboBoxGetSceneMembershipAddrMode.Location = new System.Drawing.Point(126, 168);
            this.comboBoxGetSceneMembershipAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGetSceneMembershipAddrMode.Name = "comboBoxGetSceneMembershipAddrMode";
            this.comboBoxGetSceneMembershipAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxGetSceneMembershipAddrMode.TabIndex = 33;
            // 
            // buttonGetSceneMembership
            // 
            this.buttonGetSceneMembership.Location = new System.Drawing.Point(4, 165);
            this.buttonGetSceneMembership.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetSceneMembership.Name = "buttonGetSceneMembership";
            this.buttonGetSceneMembership.Size = new System.Drawing.Size(112, 32);
            this.buttonGetSceneMembership.TabIndex = 32;
            this.buttonGetSceneMembership.Text = "Get Memb";
            this.buttonGetSceneMembership.UseVisualStyleBackColor = true;
            this.buttonGetSceneMembership.Click += new System.EventHandler(this.buttonGetSceneMembership_Click);
            // 
            // textBoxRecallSceneSceneId
            // 
            this.textBoxRecallSceneSceneId.Location = new System.Drawing.Point(921, 127);
            this.textBoxRecallSceneSceneId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecallSceneSceneId.Name = "textBoxRecallSceneSceneId";
            this.textBoxRecallSceneSceneId.Size = new System.Drawing.Size(148, 28);
            this.textBoxRecallSceneSceneId.TabIndex = 31;
            // 
            // textBoxRecallSceneGroupId
            // 
            this.textBoxRecallSceneGroupId.Location = new System.Drawing.Point(762, 129);
            this.textBoxRecallSceneGroupId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecallSceneGroupId.Name = "textBoxRecallSceneGroupId";
            this.textBoxRecallSceneGroupId.Size = new System.Drawing.Size(148, 28);
            this.textBoxRecallSceneGroupId.TabIndex = 30;
            // 
            // textBoxRecallSceneDstEndPoint
            // 
            this.textBoxRecallSceneDstEndPoint.Location = new System.Drawing.Point(603, 127);
            this.textBoxRecallSceneDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecallSceneDstEndPoint.Name = "textBoxRecallSceneDstEndPoint";
            this.textBoxRecallSceneDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxRecallSceneDstEndPoint.TabIndex = 29;
            // 
            // textBoxRecallSceneSrcEndPoint
            // 
            this.textBoxRecallSceneSrcEndPoint.Location = new System.Drawing.Point(444, 127);
            this.textBoxRecallSceneSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecallSceneSrcEndPoint.Name = "textBoxRecallSceneSrcEndPoint";
            this.textBoxRecallSceneSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxRecallSceneSrcEndPoint.TabIndex = 28;
            // 
            // textBoxRecallSceneAddr
            // 
            this.textBoxRecallSceneAddr.Location = new System.Drawing.Point(285, 127);
            this.textBoxRecallSceneAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxRecallSceneAddr.Name = "textBoxRecallSceneAddr";
            this.textBoxRecallSceneAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxRecallSceneAddr.TabIndex = 27;
            // 
            // comboBoxRecallSceneAddrMode
            // 
            this.comboBoxRecallSceneAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecallSceneAddrMode.FormattingEnabled = true;
            this.comboBoxRecallSceneAddrMode.Location = new System.Drawing.Point(126, 127);
            this.comboBoxRecallSceneAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRecallSceneAddrMode.Name = "comboBoxRecallSceneAddrMode";
            this.comboBoxRecallSceneAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxRecallSceneAddrMode.TabIndex = 26;
            // 
            // buttonRecallScene
            // 
            this.buttonRecallScene.Location = new System.Drawing.Point(4, 125);
            this.buttonRecallScene.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRecallScene.Name = "buttonRecallScene";
            this.buttonRecallScene.Size = new System.Drawing.Size(112, 32);
            this.buttonRecallScene.TabIndex = 25;
            this.buttonRecallScene.Text = "Recall Scn";
            this.buttonRecallScene.UseVisualStyleBackColor = true;
            this.buttonRecallScene.Click += new System.EventHandler(this.buttonRecallScene_Click_1);
            // 
            // textBoxStoreSceneSceneId
            // 
            this.textBoxStoreSceneSceneId.Location = new System.Drawing.Point(921, 87);
            this.textBoxStoreSceneSceneId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoreSceneSceneId.Name = "textBoxStoreSceneSceneId";
            this.textBoxStoreSceneSceneId.Size = new System.Drawing.Size(148, 28);
            this.textBoxStoreSceneSceneId.TabIndex = 24;
            // 
            // textBoxStoreSceneGroupId
            // 
            this.textBoxStoreSceneGroupId.Location = new System.Drawing.Point(762, 87);
            this.textBoxStoreSceneGroupId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoreSceneGroupId.Name = "textBoxStoreSceneGroupId";
            this.textBoxStoreSceneGroupId.Size = new System.Drawing.Size(148, 28);
            this.textBoxStoreSceneGroupId.TabIndex = 23;
            // 
            // textBoxStoreSceneDstEndPoint
            // 
            this.textBoxStoreSceneDstEndPoint.Location = new System.Drawing.Point(603, 87);
            this.textBoxStoreSceneDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoreSceneDstEndPoint.Name = "textBoxStoreSceneDstEndPoint";
            this.textBoxStoreSceneDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxStoreSceneDstEndPoint.TabIndex = 22;
            // 
            // textBoxStoreSceneSrcEndPoint
            // 
            this.textBoxStoreSceneSrcEndPoint.Location = new System.Drawing.Point(444, 87);
            this.textBoxStoreSceneSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoreSceneSrcEndPoint.Name = "textBoxStoreSceneSrcEndPoint";
            this.textBoxStoreSceneSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxStoreSceneSrcEndPoint.TabIndex = 21;
            // 
            // textBoxStoreSceneAddr
            // 
            this.textBoxStoreSceneAddr.Location = new System.Drawing.Point(285, 87);
            this.textBoxStoreSceneAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoreSceneAddr.Name = "textBoxStoreSceneAddr";
            this.textBoxStoreSceneAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxStoreSceneAddr.TabIndex = 20;
            // 
            // comboBoxStoreSceneAddrMode
            // 
            this.comboBoxStoreSceneAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStoreSceneAddrMode.FormattingEnabled = true;
            this.comboBoxStoreSceneAddrMode.Location = new System.Drawing.Point(126, 87);
            this.comboBoxStoreSceneAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStoreSceneAddrMode.Name = "comboBoxStoreSceneAddrMode";
            this.comboBoxStoreSceneAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxStoreSceneAddrMode.TabIndex = 19;
            // 
            // buttonStoreScene
            // 
            this.buttonStoreScene.Location = new System.Drawing.Point(4, 84);
            this.buttonStoreScene.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStoreScene.Name = "buttonStoreScene";
            this.buttonStoreScene.Size = new System.Drawing.Size(112, 32);
            this.buttonStoreScene.TabIndex = 18;
            this.buttonStoreScene.Text = "Store Scene";
            this.buttonStoreScene.UseVisualStyleBackColor = true;
            this.buttonStoreScene.Click += new System.EventHandler(this.buttonStoreScene_Click);
            // 
            // textBoxAddSceneMaxNameLen
            // 
            this.textBoxAddSceneMaxNameLen.Location = new System.Drawing.Point(1557, 47);
            this.textBoxAddSceneMaxNameLen.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneMaxNameLen.Name = "textBoxAddSceneMaxNameLen";
            this.textBoxAddSceneMaxNameLen.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneMaxNameLen.TabIndex = 17;
            // 
            // textBoxAddSceneNameLen
            // 
            this.textBoxAddSceneNameLen.Location = new System.Drawing.Point(1398, 47);
            this.textBoxAddSceneNameLen.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneNameLen.Name = "textBoxAddSceneNameLen";
            this.textBoxAddSceneNameLen.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneNameLen.TabIndex = 16;
            // 
            // textBoxAddSceneName
            // 
            this.textBoxAddSceneName.Location = new System.Drawing.Point(1239, 47);
            this.textBoxAddSceneName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneName.Name = "textBoxAddSceneName";
            this.textBoxAddSceneName.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneName.TabIndex = 15;
            // 
            // textBoxAddSceneTransTime
            // 
            this.textBoxAddSceneTransTime.Location = new System.Drawing.Point(1080, 47);
            this.textBoxAddSceneTransTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneTransTime.Name = "textBoxAddSceneTransTime";
            this.textBoxAddSceneTransTime.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneTransTime.TabIndex = 14;
            // 
            // textBoxAddSceneSceneId
            // 
            this.textBoxAddSceneSceneId.Location = new System.Drawing.Point(921, 47);
            this.textBoxAddSceneSceneId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneSceneId.Name = "textBoxAddSceneSceneId";
            this.textBoxAddSceneSceneId.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneSceneId.TabIndex = 13;
            // 
            // textBoxAddSceneGroupId
            // 
            this.textBoxAddSceneGroupId.Location = new System.Drawing.Point(762, 47);
            this.textBoxAddSceneGroupId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneGroupId.Name = "textBoxAddSceneGroupId";
            this.textBoxAddSceneGroupId.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneGroupId.TabIndex = 12;
            // 
            // textBoxAddSceneDstEndPoint
            // 
            this.textBoxAddSceneDstEndPoint.Location = new System.Drawing.Point(603, 47);
            this.textBoxAddSceneDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneDstEndPoint.Name = "textBoxAddSceneDstEndPoint";
            this.textBoxAddSceneDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneDstEndPoint.TabIndex = 11;
            // 
            // textBoxAddSceneSrcEndPoint
            // 
            this.textBoxAddSceneSrcEndPoint.Location = new System.Drawing.Point(444, 47);
            this.textBoxAddSceneSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneSrcEndPoint.Name = "textBoxAddSceneSrcEndPoint";
            this.textBoxAddSceneSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneSrcEndPoint.TabIndex = 10;
            // 
            // textBoxAddSceneAddr
            // 
            this.textBoxAddSceneAddr.Location = new System.Drawing.Point(285, 47);
            this.textBoxAddSceneAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneAddr.Name = "textBoxAddSceneAddr";
            this.textBoxAddSceneAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneAddr.TabIndex = 9;
            // 
            // comboBoxAddSceneAddrMode
            // 
            this.comboBoxAddSceneAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddSceneAddrMode.FormattingEnabled = true;
            this.comboBoxAddSceneAddrMode.Location = new System.Drawing.Point(126, 47);
            this.comboBoxAddSceneAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAddSceneAddrMode.Name = "comboBoxAddSceneAddrMode";
            this.comboBoxAddSceneAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxAddSceneAddrMode.TabIndex = 8;
            // 
            // buttonAddScene
            // 
            this.buttonAddScene.Location = new System.Drawing.Point(4, 44);
            this.buttonAddScene.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddScene.Name = "buttonAddScene";
            this.buttonAddScene.Size = new System.Drawing.Size(112, 32);
            this.buttonAddScene.TabIndex = 7;
            this.buttonAddScene.Text = "Add Scene";
            this.buttonAddScene.UseVisualStyleBackColor = true;
            this.buttonAddScene.Click += new System.EventHandler(this.buttonAddScene_Click);
            // 
            // comboBoxViewSceneAddrMode
            // 
            this.comboBoxViewSceneAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewSceneAddrMode.FormattingEnabled = true;
            this.comboBoxViewSceneAddrMode.Location = new System.Drawing.Point(126, 7);
            this.comboBoxViewSceneAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxViewSceneAddrMode.Name = "comboBoxViewSceneAddrMode";
            this.comboBoxViewSceneAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxViewSceneAddrMode.TabIndex = 6;
            // 
            // textBoxViewSceneSceneId
            // 
            this.textBoxViewSceneSceneId.Location = new System.Drawing.Point(921, 7);
            this.textBoxViewSceneSceneId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewSceneSceneId.Name = "textBoxViewSceneSceneId";
            this.textBoxViewSceneSceneId.Size = new System.Drawing.Size(148, 28);
            this.textBoxViewSceneSceneId.TabIndex = 5;
            // 
            // textBoxViewSceneGroupId
            // 
            this.textBoxViewSceneGroupId.Location = new System.Drawing.Point(762, 7);
            this.textBoxViewSceneGroupId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewSceneGroupId.Name = "textBoxViewSceneGroupId";
            this.textBoxViewSceneGroupId.Size = new System.Drawing.Size(148, 28);
            this.textBoxViewSceneGroupId.TabIndex = 4;
            // 
            // textBoxViewSceneDstEndPoint
            // 
            this.textBoxViewSceneDstEndPoint.Location = new System.Drawing.Point(603, 7);
            this.textBoxViewSceneDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewSceneDstEndPoint.Name = "textBoxViewSceneDstEndPoint";
            this.textBoxViewSceneDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxViewSceneDstEndPoint.TabIndex = 3;
            // 
            // textBoxViewSceneSrcEndPoint
            // 
            this.textBoxViewSceneSrcEndPoint.Location = new System.Drawing.Point(444, 8);
            this.textBoxViewSceneSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewSceneSrcEndPoint.Name = "textBoxViewSceneSrcEndPoint";
            this.textBoxViewSceneSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxViewSceneSrcEndPoint.TabIndex = 2;
            // 
            // textBoxViewSceneAddr
            // 
            this.textBoxViewSceneAddr.Location = new System.Drawing.Point(285, 7);
            this.textBoxViewSceneAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViewSceneAddr.Name = "textBoxViewSceneAddr";
            this.textBoxViewSceneAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxViewSceneAddr.TabIndex = 1;
            // 
            // buttonViewScene
            // 
            this.buttonViewScene.Location = new System.Drawing.Point(4, 4);
            this.buttonViewScene.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewScene.Name = "buttonViewScene";
            this.buttonViewScene.Size = new System.Drawing.Size(112, 32);
            this.buttonViewScene.TabIndex = 0;
            this.buttonViewScene.Text = "View Scene";
            this.buttonViewScene.UseVisualStyleBackColor = true;
            this.buttonViewScene.Click += new System.EventHandler(this.buttonViewScene_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage8.Controls.Add(this.textBoxMoveToColorTempRate);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorTempTemp);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorTempDstEp);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorTempSrcEp);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorTempAddr);
            this.tabPage8.Controls.Add(this.buttonMoveToColorTemp);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorTime);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorY);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorX);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorDstEp);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorSrcEp);
            this.tabPage8.Controls.Add(this.textBoxMoveToColorAddr);
            this.tabPage8.Controls.Add(this.buttonMoveToColor);
            this.tabPage8.Controls.Add(this.textBoxMoveToHueTime);
            this.tabPage8.Controls.Add(this.textBoxMoveToHueDir);
            this.tabPage8.Controls.Add(this.textBoxMoveToHueHue);
            this.tabPage8.Controls.Add(this.textBoxMoveToHueDstEp);
            this.tabPage8.Controls.Add(this.textBoxMoveToHueSrcEp);
            this.tabPage8.Controls.Add(this.buttonMoveToHue);
            this.tabPage8.Controls.Add(this.textBoxMoveToHueAddr);
            this.tabPage8.Location = new System.Drawing.Point(4, 28);
            this.tabPage8.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1903, 590);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Color Cluster";
            // 
            // textBoxMoveToColorTempRate
            // 
            this.textBoxMoveToColorTempRate.Location = new System.Drawing.Point(780, 89);
            this.textBoxMoveToColorTempRate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorTempRate.Name = "textBoxMoveToColorTempRate";
            this.textBoxMoveToColorTempRate.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorTempRate.TabIndex = 19;
            // 
            // textBoxMoveToColorTempTemp
            // 
            this.textBoxMoveToColorTempTemp.Location = new System.Drawing.Point(621, 89);
            this.textBoxMoveToColorTempTemp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorTempTemp.Name = "textBoxMoveToColorTempTemp";
            this.textBoxMoveToColorTempTemp.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorTempTemp.TabIndex = 18;
            // 
            // textBoxMoveToColorTempDstEp
            // 
            this.textBoxMoveToColorTempDstEp.Location = new System.Drawing.Point(462, 89);
            this.textBoxMoveToColorTempDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorTempDstEp.Name = "textBoxMoveToColorTempDstEp";
            this.textBoxMoveToColorTempDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorTempDstEp.TabIndex = 17;
            // 
            // textBoxMoveToColorTempSrcEp
            // 
            this.textBoxMoveToColorTempSrcEp.Location = new System.Drawing.Point(303, 89);
            this.textBoxMoveToColorTempSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorTempSrcEp.Name = "textBoxMoveToColorTempSrcEp";
            this.textBoxMoveToColorTempSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorTempSrcEp.TabIndex = 16;
            // 
            // textBoxMoveToColorTempAddr
            // 
            this.textBoxMoveToColorTempAddr.Location = new System.Drawing.Point(144, 89);
            this.textBoxMoveToColorTempAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorTempAddr.Name = "textBoxMoveToColorTempAddr";
            this.textBoxMoveToColorTempAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorTempAddr.TabIndex = 15;
            // 
            // buttonMoveToColorTemp
            // 
            this.buttonMoveToColorTemp.Location = new System.Drawing.Point(6, 86);
            this.buttonMoveToColorTemp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveToColorTemp.Name = "buttonMoveToColorTemp";
            this.buttonMoveToColorTemp.Size = new System.Drawing.Size(128, 32);
            this.buttonMoveToColorTemp.TabIndex = 14;
            this.buttonMoveToColorTemp.Text = "MoveToTemp";
            this.buttonMoveToColorTemp.UseVisualStyleBackColor = true;
            this.buttonMoveToColorTemp.Click += new System.EventHandler(this.buttonMoveToColorTemp_Click);
            // 
            // textBoxMoveToColorTime
            // 
            this.textBoxMoveToColorTime.Location = new System.Drawing.Point(939, 48);
            this.textBoxMoveToColorTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorTime.Name = "textBoxMoveToColorTime";
            this.textBoxMoveToColorTime.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorTime.TabIndex = 13;
            // 
            // textBoxMoveToColorY
            // 
            this.textBoxMoveToColorY.Location = new System.Drawing.Point(780, 48);
            this.textBoxMoveToColorY.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorY.Name = "textBoxMoveToColorY";
            this.textBoxMoveToColorY.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorY.TabIndex = 12;
            // 
            // textBoxMoveToColorX
            // 
            this.textBoxMoveToColorX.Location = new System.Drawing.Point(621, 50);
            this.textBoxMoveToColorX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorX.Name = "textBoxMoveToColorX";
            this.textBoxMoveToColorX.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorX.TabIndex = 11;
            // 
            // textBoxMoveToColorDstEp
            // 
            this.textBoxMoveToColorDstEp.Location = new System.Drawing.Point(462, 48);
            this.textBoxMoveToColorDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorDstEp.Name = "textBoxMoveToColorDstEp";
            this.textBoxMoveToColorDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorDstEp.TabIndex = 10;
            // 
            // textBoxMoveToColorSrcEp
            // 
            this.textBoxMoveToColorSrcEp.Location = new System.Drawing.Point(303, 48);
            this.textBoxMoveToColorSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorSrcEp.Name = "textBoxMoveToColorSrcEp";
            this.textBoxMoveToColorSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorSrcEp.TabIndex = 9;
            // 
            // textBoxMoveToColorAddr
            // 
            this.textBoxMoveToColorAddr.Location = new System.Drawing.Point(144, 50);
            this.textBoxMoveToColorAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToColorAddr.Name = "textBoxMoveToColorAddr";
            this.textBoxMoveToColorAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToColorAddr.TabIndex = 8;
            // 
            // buttonMoveToColor
            // 
            this.buttonMoveToColor.Location = new System.Drawing.Point(6, 46);
            this.buttonMoveToColor.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveToColor.Name = "buttonMoveToColor";
            this.buttonMoveToColor.Size = new System.Drawing.Size(128, 32);
            this.buttonMoveToColor.TabIndex = 7;
            this.buttonMoveToColor.Text = "MoveToColor";
            this.buttonMoveToColor.UseVisualStyleBackColor = true;
            this.buttonMoveToColor.Click += new System.EventHandler(this.buttonMoveToColor_Click);
            // 
            // textBoxMoveToHueTime
            // 
            this.textBoxMoveToHueTime.Location = new System.Drawing.Point(939, 8);
            this.textBoxMoveToHueTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToHueTime.Name = "textBoxMoveToHueTime";
            this.textBoxMoveToHueTime.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToHueTime.TabIndex = 6;
            // 
            // textBoxMoveToHueDir
            // 
            this.textBoxMoveToHueDir.Location = new System.Drawing.Point(780, 8);
            this.textBoxMoveToHueDir.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToHueDir.Name = "textBoxMoveToHueDir";
            this.textBoxMoveToHueDir.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToHueDir.TabIndex = 5;
            // 
            // textBoxMoveToHueHue
            // 
            this.textBoxMoveToHueHue.Location = new System.Drawing.Point(621, 8);
            this.textBoxMoveToHueHue.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToHueHue.Name = "textBoxMoveToHueHue";
            this.textBoxMoveToHueHue.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToHueHue.TabIndex = 4;
            // 
            // textBoxMoveToHueDstEp
            // 
            this.textBoxMoveToHueDstEp.Location = new System.Drawing.Point(462, 8);
            this.textBoxMoveToHueDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToHueDstEp.Name = "textBoxMoveToHueDstEp";
            this.textBoxMoveToHueDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToHueDstEp.TabIndex = 3;
            // 
            // textBoxMoveToHueSrcEp
            // 
            this.textBoxMoveToHueSrcEp.Location = new System.Drawing.Point(303, 8);
            this.textBoxMoveToHueSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToHueSrcEp.Name = "textBoxMoveToHueSrcEp";
            this.textBoxMoveToHueSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToHueSrcEp.TabIndex = 2;
            // 
            // buttonMoveToHue
            // 
            this.buttonMoveToHue.Location = new System.Drawing.Point(6, 6);
            this.buttonMoveToHue.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveToHue.Name = "buttonMoveToHue";
            this.buttonMoveToHue.Size = new System.Drawing.Size(128, 32);
            this.buttonMoveToHue.TabIndex = 1;
            this.buttonMoveToHue.Text = "MoveToHue";
            this.buttonMoveToHue.UseVisualStyleBackColor = true;
            this.buttonMoveToHue.Click += new System.EventHandler(this.buttonMoveToHue_Click);
            // 
            // textBoxMoveToHueAddr
            // 
            this.textBoxMoveToHueAddr.Location = new System.Drawing.Point(144, 8);
            this.textBoxMoveToHueAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMoveToHueAddr.Name = "textBoxMoveToHueAddr";
            this.textBoxMoveToHueAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxMoveToHueAddr.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.comboBoxLockUnlock);
            this.tabPage1.Controls.Add(this.textBoxLockUnlockDstEp);
            this.tabPage1.Controls.Add(this.textBoxLockUnlockSrcEp);
            this.tabPage1.Controls.Add(this.textBoxLockUnlockAddr);
            this.tabPage1.Controls.Add(this.buttonLockUnlock);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1903, 590);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "Door Lock Cluster";
            // 
            // comboBoxLockUnlock
            // 
            this.comboBoxLockUnlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLockUnlock.FormattingEnabled = true;
            this.comboBoxLockUnlock.Location = new System.Drawing.Point(604, 8);
            this.comboBoxLockUnlock.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLockUnlock.Name = "comboBoxLockUnlock";
            this.comboBoxLockUnlock.Size = new System.Drawing.Size(180, 26);
            this.comboBoxLockUnlock.TabIndex = 4;
            // 
            // textBoxLockUnlockDstEp
            // 
            this.textBoxLockUnlockDstEp.Location = new System.Drawing.Point(446, 8);
            this.textBoxLockUnlockDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLockUnlockDstEp.Name = "textBoxLockUnlockDstEp";
            this.textBoxLockUnlockDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxLockUnlockDstEp.TabIndex = 3;
            // 
            // textBoxLockUnlockSrcEp
            // 
            this.textBoxLockUnlockSrcEp.Location = new System.Drawing.Point(286, 8);
            this.textBoxLockUnlockSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLockUnlockSrcEp.Name = "textBoxLockUnlockSrcEp";
            this.textBoxLockUnlockSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxLockUnlockSrcEp.TabIndex = 2;
            // 
            // textBoxLockUnlockAddr
            // 
            this.textBoxLockUnlockAddr.Location = new System.Drawing.Point(128, 8);
            this.textBoxLockUnlockAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLockUnlockAddr.Name = "textBoxLockUnlockAddr";
            this.textBoxLockUnlockAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxLockUnlockAddr.TabIndex = 1;
            // 
            // buttonLockUnlock
            // 
            this.buttonLockUnlock.Location = new System.Drawing.Point(6, 6);
            this.buttonLockUnlock.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLockUnlock.Name = "buttonLockUnlock";
            this.buttonLockUnlock.Size = new System.Drawing.Size(112, 32);
            this.buttonLockUnlock.TabIndex = 0;
            this.buttonLockUnlock.Text = "LockUnlock";
            this.buttonLockUnlock.UseVisualStyleBackColor = true;
            this.buttonLockUnlock.Click += new System.EventHandler(this.buttonLockUnlock_Click);
            // 
            // tabPage15
            // 
            this.tabPage15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage15.Controls.Add(this.textBoxHVACRaiseLowData);
            this.tabPage15.Controls.Add(this.textBoxHVACDstEndPoint);
            this.tabPage15.Controls.Add(this.textBoxHVACSrcEndPoint);
            this.tabPage15.Controls.Add(this.comboBoxHVACSetMode);
            this.tabPage15.Controls.Add(this.textBoxHVACAddress);
            this.tabPage15.Controls.Add(this.comboBoxHVACAddressMode);
            this.tabPage15.Controls.Add(this.SetRaiseLower_button1);
            this.tabPage15.Location = new System.Drawing.Point(4, 28);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Size = new System.Drawing.Size(1903, 590);
            this.tabPage15.TabIndex = 17;
            this.tabPage15.Text = "HVAC";
            // 
            // textBoxHVACRaiseLowData
            // 
            this.textBoxHVACRaiseLowData.Location = new System.Drawing.Point(814, 30);
            this.textBoxHVACRaiseLowData.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHVACRaiseLowData.Name = "textBoxHVACRaiseLowData";
            this.textBoxHVACRaiseLowData.Size = new System.Drawing.Size(148, 28);
            this.textBoxHVACRaiseLowData.TabIndex = 12;
            // 
            // textBoxHVACDstEndPoint
            // 
            this.textBoxHVACDstEndPoint.Location = new System.Drawing.Point(658, 30);
            this.textBoxHVACDstEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHVACDstEndPoint.Name = "textBoxHVACDstEndPoint";
            this.textBoxHVACDstEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxHVACDstEndPoint.TabIndex = 11;
            // 
            // textBoxHVACSrcEndPoint
            // 
            this.textBoxHVACSrcEndPoint.Location = new System.Drawing.Point(502, 30);
            this.textBoxHVACSrcEndPoint.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHVACSrcEndPoint.Name = "textBoxHVACSrcEndPoint";
            this.textBoxHVACSrcEndPoint.Size = new System.Drawing.Size(148, 28);
            this.textBoxHVACSrcEndPoint.TabIndex = 10;
            // 
            // comboBoxHVACSetMode
            // 
            this.comboBoxHVACSetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHVACSetMode.FormattingEnabled = true;
            this.comboBoxHVACSetMode.Location = new System.Drawing.Point(970, 32);
            this.comboBoxHVACSetMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHVACSetMode.Name = "comboBoxHVACSetMode";
            this.comboBoxHVACSetMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxHVACSetMode.TabIndex = 9;
            // 
            // textBoxHVACAddress
            // 
            this.textBoxHVACAddress.AutoCompleteCustomSource.AddRange(new string[] {
            "aa"});
            this.textBoxHVACAddress.Location = new System.Drawing.Point(346, 30);
            this.textBoxHVACAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHVACAddress.Name = "textBoxHVACAddress";
            this.textBoxHVACAddress.Size = new System.Drawing.Size(148, 28);
            this.textBoxHVACAddress.TabIndex = 8;
            // 
            // comboBoxHVACAddressMode
            // 
            this.comboBoxHVACAddressMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHVACAddressMode.FormattingEnabled = true;
            this.comboBoxHVACAddressMode.Location = new System.Drawing.Point(190, 28);
            this.comboBoxHVACAddressMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxHVACAddressMode.Name = "comboBoxHVACAddressMode";
            this.comboBoxHVACAddressMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxHVACAddressMode.TabIndex = 7;
            // 
            // SetRaiseLower_button1
            // 
            this.SetRaiseLower_button1.Location = new System.Drawing.Point(21, 26);
            this.SetRaiseLower_button1.Margin = new System.Windows.Forms.Padding(4);
            this.SetRaiseLower_button1.Name = "SetRaiseLower_button1";
            this.SetRaiseLower_button1.Size = new System.Drawing.Size(161, 36);
            this.SetRaiseLower_button1.TabIndex = 1;
            this.SetRaiseLower_button1.Text = "SetRaiseLower";
            this.SetRaiseLower_button1.UseVisualStyleBackColor = true;
            this.SetRaiseLower_button1.Click += new System.EventHandler(this.SetRaiseLower_button1_Click);
            // 
            // tabPage13
            // 
            this.tabPage13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage13.Controls.Add(this.comboBoxEnrollRspCode);
            this.tabPage13.Controls.Add(this.textBoxEnrollRspZone);
            this.tabPage13.Controls.Add(this.textBoxEnrollRspDstEp);
            this.tabPage13.Controls.Add(this.textBoxEnrollRspSrcEp);
            this.tabPage13.Controls.Add(this.textBoxEnrollRspAddr);
            this.tabPage13.Controls.Add(this.comboBoxEnrollRspAddrMode);
            this.tabPage13.Controls.Add(this.buttonEnrollResponse);
            this.tabPage13.Location = new System.Drawing.Point(4, 28);
            this.tabPage13.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage13.Size = new System.Drawing.Size(1903, 590);
            this.tabPage13.TabIndex = 13;
            this.tabPage13.Text = "IAS Cluster";
            // 
            // comboBoxEnrollRspCode
            // 
            this.comboBoxEnrollRspCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnrollRspCode.FormattingEnabled = true;
            this.comboBoxEnrollRspCode.Location = new System.Drawing.Point(766, 12);
            this.comboBoxEnrollRspCode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEnrollRspCode.Name = "comboBoxEnrollRspCode";
            this.comboBoxEnrollRspCode.Size = new System.Drawing.Size(193, 26);
            this.comboBoxEnrollRspCode.TabIndex = 7;
            // 
            // textBoxEnrollRspZone
            // 
            this.textBoxEnrollRspZone.Location = new System.Drawing.Point(970, 11);
            this.textBoxEnrollRspZone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnrollRspZone.Name = "textBoxEnrollRspZone";
            this.textBoxEnrollRspZone.Size = new System.Drawing.Size(148, 28);
            this.textBoxEnrollRspZone.TabIndex = 6;
            // 
            // textBoxEnrollRspDstEp
            // 
            this.textBoxEnrollRspDstEp.Location = new System.Drawing.Point(608, 12);
            this.textBoxEnrollRspDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnrollRspDstEp.Name = "textBoxEnrollRspDstEp";
            this.textBoxEnrollRspDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxEnrollRspDstEp.TabIndex = 4;
            // 
            // textBoxEnrollRspSrcEp
            // 
            this.textBoxEnrollRspSrcEp.Location = new System.Drawing.Point(448, 12);
            this.textBoxEnrollRspSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnrollRspSrcEp.Name = "textBoxEnrollRspSrcEp";
            this.textBoxEnrollRspSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxEnrollRspSrcEp.TabIndex = 3;
            // 
            // textBoxEnrollRspAddr
            // 
            this.textBoxEnrollRspAddr.Location = new System.Drawing.Point(290, 12);
            this.textBoxEnrollRspAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEnrollRspAddr.Name = "textBoxEnrollRspAddr";
            this.textBoxEnrollRspAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxEnrollRspAddr.TabIndex = 2;
            // 
            // comboBoxEnrollRspAddrMode
            // 
            this.comboBoxEnrollRspAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnrollRspAddrMode.FormattingEnabled = true;
            this.comboBoxEnrollRspAddrMode.Location = new System.Drawing.Point(130, 11);
            this.comboBoxEnrollRspAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEnrollRspAddrMode.Name = "comboBoxEnrollRspAddrMode";
            this.comboBoxEnrollRspAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxEnrollRspAddrMode.TabIndex = 1;
            // 
            // buttonEnrollResponse
            // 
            this.buttonEnrollResponse.Location = new System.Drawing.Point(9, 8);
            this.buttonEnrollResponse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnrollResponse.Name = "buttonEnrollResponse";
            this.buttonEnrollResponse.Size = new System.Drawing.Size(112, 32);
            this.buttonEnrollResponse.TabIndex = 0;
            this.buttonEnrollResponse.Text = "Enroll Rsp";
            this.buttonEnrollResponse.UseVisualStyleBackColor = true;
            this.buttonEnrollResponse.Click += new System.EventHandler(this.buttonEnrollResponse_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage9.Controls.Add(this.buttonZllTouchlinkFactoryReset);
            this.tabPage9.Controls.Add(this.buttonZllTouchlinkInitiate);
            this.tabPage9.Location = new System.Drawing.Point(4, 28);
            this.tabPage9.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1903, 590);
            this.tabPage9.TabIndex = 9;
            this.tabPage9.Text = "ZLL Touchlink";
            // 
            // buttonZllTouchlinkFactoryReset
            // 
            this.buttonZllTouchlinkFactoryReset.Location = new System.Drawing.Point(6, 47);
            this.buttonZllTouchlinkFactoryReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZllTouchlinkFactoryReset.Name = "buttonZllTouchlinkFactoryReset";
            this.buttonZllTouchlinkFactoryReset.Size = new System.Drawing.Size(112, 32);
            this.buttonZllTouchlinkFactoryReset.TabIndex = 1;
            this.buttonZllTouchlinkFactoryReset.Text = "Reset";
            this.buttonZllTouchlinkFactoryReset.UseVisualStyleBackColor = true;
            this.buttonZllTouchlinkFactoryReset.Click += new System.EventHandler(this.buttonZllTouchlinkFactoryReset_Click);
            // 
            // buttonZllTouchlinkInitiate
            // 
            this.buttonZllTouchlinkInitiate.Location = new System.Drawing.Point(6, 6);
            this.buttonZllTouchlinkInitiate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZllTouchlinkInitiate.Name = "buttonZllTouchlinkInitiate";
            this.buttonZllTouchlinkInitiate.Size = new System.Drawing.Size(112, 32);
            this.buttonZllTouchlinkInitiate.TabIndex = 0;
            this.buttonZllTouchlinkInitiate.Text = "Initiate";
            this.buttonZllTouchlinkInitiate.UseVisualStyleBackColor = true;
            this.buttonZllTouchlinkInitiate.Click += new System.EventHandler(this.buttonZllTouchlinkInitiate_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage10.Controls.Add(this.comboBoxZllOnOffEffectID);
            this.tabPage10.Controls.Add(this.textBoxZllOnOffEffectsGradient);
            this.tabPage10.Controls.Add(this.textBoxZllOnOffEffectsDstEp);
            this.tabPage10.Controls.Add(this.textBoxZllOnOffEffectsSrcEp);
            this.tabPage10.Controls.Add(this.textBoxZllOnOffEffectsAddr);
            this.tabPage10.Controls.Add(this.buttonZllOnOffEffects);
            this.tabPage10.Location = new System.Drawing.Point(4, 28);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1903, 590);
            this.tabPage10.TabIndex = 10;
            this.tabPage10.Text = "ZLL On/Off Cluster";
            // 
            // comboBoxZllOnOffEffectID
            // 
            this.comboBoxZllOnOffEffectID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZllOnOffEffectID.FormattingEnabled = true;
            this.comboBoxZllOnOffEffectID.Location = new System.Drawing.Point(620, 8);
            this.comboBoxZllOnOffEffectID.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxZllOnOffEffectID.Name = "comboBoxZllOnOffEffectID";
            this.comboBoxZllOnOffEffectID.Size = new System.Drawing.Size(180, 26);
            this.comboBoxZllOnOffEffectID.TabIndex = 7;
            // 
            // textBoxZllOnOffEffectsGradient
            // 
            this.textBoxZllOnOffEffectsGradient.Location = new System.Drawing.Point(810, 8);
            this.textBoxZllOnOffEffectsGradient.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllOnOffEffectsGradient.Name = "textBoxZllOnOffEffectsGradient";
            this.textBoxZllOnOffEffectsGradient.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllOnOffEffectsGradient.TabIndex = 6;
            // 
            // textBoxZllOnOffEffectsDstEp
            // 
            this.textBoxZllOnOffEffectsDstEp.Location = new System.Drawing.Point(460, 8);
            this.textBoxZllOnOffEffectsDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllOnOffEffectsDstEp.Name = "textBoxZllOnOffEffectsDstEp";
            this.textBoxZllOnOffEffectsDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllOnOffEffectsDstEp.TabIndex = 4;
            // 
            // textBoxZllOnOffEffectsSrcEp
            // 
            this.textBoxZllOnOffEffectsSrcEp.Location = new System.Drawing.Point(302, 8);
            this.textBoxZllOnOffEffectsSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllOnOffEffectsSrcEp.Name = "textBoxZllOnOffEffectsSrcEp";
            this.textBoxZllOnOffEffectsSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllOnOffEffectsSrcEp.TabIndex = 3;
            // 
            // textBoxZllOnOffEffectsAddr
            // 
            this.textBoxZllOnOffEffectsAddr.Location = new System.Drawing.Point(142, 8);
            this.textBoxZllOnOffEffectsAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllOnOffEffectsAddr.Name = "textBoxZllOnOffEffectsAddr";
            this.textBoxZllOnOffEffectsAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllOnOffEffectsAddr.TabIndex = 2;
            // 
            // buttonZllOnOffEffects
            // 
            this.buttonZllOnOffEffects.Location = new System.Drawing.Point(6, 6);
            this.buttonZllOnOffEffects.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZllOnOffEffects.Name = "buttonZllOnOffEffects";
            this.buttonZllOnOffEffects.Size = new System.Drawing.Size(128, 32);
            this.buttonZllOnOffEffects.TabIndex = 0;
            this.buttonZllOnOffEffects.Text = "On/Off Effects";
            this.buttonZllOnOffEffects.UseVisualStyleBackColor = true;
            this.buttonZllOnOffEffects.Click += new System.EventHandler(this.buttonZllOnOffEffects_Click);
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage11.Controls.Add(this.textBoxZllMoveToHueHue);
            this.tabPage11.Controls.Add(this.textBoxZllMoveToHueTransTime);
            this.tabPage11.Controls.Add(this.textBoxZllMoveToHueDirection);
            this.tabPage11.Controls.Add(this.textBoxZllMoveToHueDstEp);
            this.tabPage11.Controls.Add(this.textBoxZllMoveToHueSrcEp);
            this.tabPage11.Controls.Add(this.textBoxZllMoveToHueAddr);
            this.tabPage11.Controls.Add(this.button8);
            this.tabPage11.Controls.Add(this.button7);
            this.tabPage11.Controls.Add(this.button6);
            this.tabPage11.Controls.Add(this.button5);
            this.tabPage11.Controls.Add(this.buttonZllMoveToHue);
            this.tabPage11.Location = new System.Drawing.Point(4, 28);
            this.tabPage11.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(1903, 590);
            this.tabPage11.TabIndex = 11;
            this.tabPage11.Text = "ZLL Color Cluster";
            // 
            // textBoxZllMoveToHueHue
            // 
            this.textBoxZllMoveToHueHue.Location = new System.Drawing.Point(620, 8);
            this.textBoxZllMoveToHueHue.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllMoveToHueHue.Name = "textBoxZllMoveToHueHue";
            this.textBoxZllMoveToHueHue.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllMoveToHueHue.TabIndex = 10;
            // 
            // textBoxZllMoveToHueTransTime
            // 
            this.textBoxZllMoveToHueTransTime.Location = new System.Drawing.Point(938, 8);
            this.textBoxZllMoveToHueTransTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllMoveToHueTransTime.Name = "textBoxZllMoveToHueTransTime";
            this.textBoxZllMoveToHueTransTime.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllMoveToHueTransTime.TabIndex = 9;
            // 
            // textBoxZllMoveToHueDirection
            // 
            this.textBoxZllMoveToHueDirection.Location = new System.Drawing.Point(778, 8);
            this.textBoxZllMoveToHueDirection.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllMoveToHueDirection.Name = "textBoxZllMoveToHueDirection";
            this.textBoxZllMoveToHueDirection.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllMoveToHueDirection.TabIndex = 8;
            // 
            // textBoxZllMoveToHueDstEp
            // 
            this.textBoxZllMoveToHueDstEp.Location = new System.Drawing.Point(460, 8);
            this.textBoxZllMoveToHueDstEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllMoveToHueDstEp.Name = "textBoxZllMoveToHueDstEp";
            this.textBoxZllMoveToHueDstEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllMoveToHueDstEp.TabIndex = 7;
            // 
            // textBoxZllMoveToHueSrcEp
            // 
            this.textBoxZllMoveToHueSrcEp.Location = new System.Drawing.Point(302, 8);
            this.textBoxZllMoveToHueSrcEp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllMoveToHueSrcEp.Name = "textBoxZllMoveToHueSrcEp";
            this.textBoxZllMoveToHueSrcEp.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllMoveToHueSrcEp.TabIndex = 6;
            // 
            // textBoxZllMoveToHueAddr
            // 
            this.textBoxZllMoveToHueAddr.Location = new System.Drawing.Point(142, 8);
            this.textBoxZllMoveToHueAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxZllMoveToHueAddr.Name = "textBoxZllMoveToHueAddr";
            this.textBoxZllMoveToHueAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxZllMoveToHueAddr.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 172);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 32);
            this.button8.TabIndex = 4;
            this.button8.Text = "Color Loop";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 130);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 32);
            this.button7.TabIndex = 3;
            this.button7.Text = "Hue and Sat";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 89);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 32);
            this.button6.TabIndex = 2;
            this.button6.Text = "Step Hue";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 47);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 32);
            this.button5.TabIndex = 1;
            this.button5.Text = "Move Hue";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttonZllMoveToHue
            // 
            this.buttonZllMoveToHue.Location = new System.Drawing.Point(6, 6);
            this.buttonZllMoveToHue.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZllMoveToHue.Name = "buttonZllMoveToHue";
            this.buttonZllMoveToHue.Size = new System.Drawing.Size(128, 32);
            this.buttonZllMoveToHue.TabIndex = 0;
            this.buttonZllMoveToHue.Text = "Move to Hue";
            this.buttonZllMoveToHue.UseVisualStyleBackColor = true;
            this.buttonZllMoveToHue.Click += new System.EventHandler(this.buttonZllMoveToHue_Click);
            // 
            // tabPage14
            // 
            this.tabPage14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage14.Controls.Add(this.textBoxOTASetWaitForDataParamsRequestBlockDelay);
            this.tabPage14.Controls.Add(this.textBoxOTASetWaitForDataParamsRequestTime);
            this.tabPage14.Controls.Add(this.textBoxOTASetWaitForDataParamsCurrentTime);
            this.tabPage14.Controls.Add(this.textBoxOTASetWaitForDataParamsSrcEP);
            this.tabPage14.Controls.Add(this.textBoxOTASetWaitForDataParamsTargetAddr);
            this.tabPage14.Controls.Add(this.buttonOTASetWaitForDataParams);
            this.tabPage14.Controls.Add(this.textBoxOtaFileOffset);
            this.tabPage14.Controls.Add(this.label9);
            this.tabPage14.Controls.Add(this.label8);
            this.tabPage14.Controls.Add(this.textBoxOtaDownloadStatus);
            this.tabPage14.Controls.Add(this.label7);
            this.tabPage14.Controls.Add(this.progressBarOtaDownloadProgress);
            this.tabPage14.Controls.Add(this.textBoxOTAImageNotifyJitter);
            this.tabPage14.Controls.Add(this.textBoxOTAImageNotifyManuID);
            this.tabPage14.Controls.Add(this.textBoxOTAImageNotifyImageType);
            this.tabPage14.Controls.Add(this.textBoxOTAImageNotifyFileVersion);
            this.tabPage14.Controls.Add(this.comboBoxOTAImageNotifyType);
            this.tabPage14.Controls.Add(this.textBoxOTAImageNotifyDstEP);
            this.tabPage14.Controls.Add(this.textBoxOTAImageNotifySrcEP);
            this.tabPage14.Controls.Add(this.textBoxOTAImageNotifyTargetAddr);
            this.tabPage14.Controls.Add(this.comboBoxOTAImageNotifyAddrMode);
            this.tabPage14.Controls.Add(this.buttonOTAImageNotify);
            this.tabPage14.Controls.Add(this.textBoxOtaFileSize);
            this.tabPage14.Controls.Add(this.label6);
            this.tabPage14.Controls.Add(this.textBoxOtaFileVersion);
            this.tabPage14.Controls.Add(this.label5);
            this.tabPage14.Controls.Add(this.textBoxOtaFileImageType);
            this.tabPage14.Controls.Add(this.label2);
            this.tabPage14.Controls.Add(this.label1);
            this.tabPage14.Controls.Add(this.textBoxOtaFileManuCode);
            this.tabPage14.Controls.Add(this.buttonOTALoadNewImage);
            this.tabPage14.Location = new System.Drawing.Point(4, 28);
            this.tabPage14.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Size = new System.Drawing.Size(1903, 590);
            this.tabPage14.TabIndex = 14;
            this.tabPage14.Text = "OTA Cluster";
            // 
            // textBoxOTASetWaitForDataParamsRequestBlockDelay
            // 
            this.textBoxOTASetWaitForDataParamsRequestBlockDelay.Location = new System.Drawing.Point(813, 98);
            this.textBoxOTASetWaitForDataParamsRequestBlockDelay.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTASetWaitForDataParamsRequestBlockDelay.Name = "textBoxOTASetWaitForDataParamsRequestBlockDelay";
            this.textBoxOTASetWaitForDataParamsRequestBlockDelay.Size = new System.Drawing.Size(170, 28);
            this.textBoxOTASetWaitForDataParamsRequestBlockDelay.TabIndex = 36;
            // 
            // textBoxOTASetWaitForDataParamsRequestTime
            // 
            this.textBoxOTASetWaitForDataParamsRequestTime.Location = new System.Drawing.Point(632, 98);
            this.textBoxOTASetWaitForDataParamsRequestTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTASetWaitForDataParamsRequestTime.Name = "textBoxOTASetWaitForDataParamsRequestTime";
            this.textBoxOTASetWaitForDataParamsRequestTime.Size = new System.Drawing.Size(170, 28);
            this.textBoxOTASetWaitForDataParamsRequestTime.TabIndex = 35;
            // 
            // textBoxOTASetWaitForDataParamsCurrentTime
            // 
            this.textBoxOTASetWaitForDataParamsCurrentTime.Location = new System.Drawing.Point(450, 98);
            this.textBoxOTASetWaitForDataParamsCurrentTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTASetWaitForDataParamsCurrentTime.Name = "textBoxOTASetWaitForDataParamsCurrentTime";
            this.textBoxOTASetWaitForDataParamsCurrentTime.Size = new System.Drawing.Size(170, 28);
            this.textBoxOTASetWaitForDataParamsCurrentTime.TabIndex = 34;
            // 
            // textBoxOTASetWaitForDataParamsSrcEP
            // 
            this.textBoxOTASetWaitForDataParamsSrcEP.Location = new System.Drawing.Point(294, 98);
            this.textBoxOTASetWaitForDataParamsSrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTASetWaitForDataParamsSrcEP.Name = "textBoxOTASetWaitForDataParamsSrcEP";
            this.textBoxOTASetWaitForDataParamsSrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxOTASetWaitForDataParamsSrcEP.TabIndex = 33;
            // 
            // textBoxOTASetWaitForDataParamsTargetAddr
            // 
            this.textBoxOTASetWaitForDataParamsTargetAddr.Location = new System.Drawing.Point(135, 98);
            this.textBoxOTASetWaitForDataParamsTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTASetWaitForDataParamsTargetAddr.Name = "textBoxOTASetWaitForDataParamsTargetAddr";
            this.textBoxOTASetWaitForDataParamsTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxOTASetWaitForDataParamsTargetAddr.TabIndex = 32;
            // 
            // buttonOTASetWaitForDataParams
            // 
            this.buttonOTASetWaitForDataParams.Location = new System.Drawing.Point(4, 93);
            this.buttonOTASetWaitForDataParams.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOTASetWaitForDataParams.Name = "buttonOTASetWaitForDataParams";
            this.buttonOTASetWaitForDataParams.Size = new System.Drawing.Size(122, 36);
            this.buttonOTASetWaitForDataParams.TabIndex = 31;
            this.buttonOTASetWaitForDataParams.Text = "WaitParams";
            this.buttonOTASetWaitForDataParams.UseVisualStyleBackColor = true;
            this.buttonOTASetWaitForDataParams.Click += new System.EventHandler(this.buttonOTASetWaitForDataParams_Click);
            // 
            // textBoxOtaFileOffset
            // 
            this.textBoxOtaFileOffset.Location = new System.Drawing.Point(1066, 137);
            this.textBoxOtaFileOffset.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtaFileOffset.Name = "textBoxOtaFileOffset";
            this.textBoxOtaFileOffset.ReadOnly = true;
            this.textBoxOtaFileOffset.Size = new System.Drawing.Size(144, 28);
            this.textBoxOtaFileOffset.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(976, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "File Offset";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Progress";
            // 
            // textBoxOtaDownloadStatus
            // 
            this.textBoxOtaDownloadStatus.Location = new System.Drawing.Point(135, 137);
            this.textBoxOtaDownloadStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtaDownloadStatus.Name = "textBoxOtaDownloadStatus";
            this.textBoxOtaDownloadStatus.ReadOnly = true;
            this.textBoxOtaDownloadStatus.Size = new System.Drawing.Size(148, 28);
            this.textBoxOtaDownloadStatus.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Download Status";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // progressBarOtaDownloadProgress
            // 
            this.progressBarOtaDownloadProgress.Location = new System.Drawing.Point(375, 134);
            this.progressBarOtaDownloadProgress.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarOtaDownloadProgress.Maximum = 1000;
            this.progressBarOtaDownloadProgress.Name = "progressBarOtaDownloadProgress";
            this.progressBarOtaDownloadProgress.Size = new System.Drawing.Size(592, 30);
            this.progressBarOtaDownloadProgress.TabIndex = 19;
            // 
            // textBoxOTAImageNotifyJitter
            // 
            this.textBoxOTAImageNotifyJitter.Location = new System.Drawing.Point(1491, 53);
            this.textBoxOTAImageNotifyJitter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTAImageNotifyJitter.Name = "textBoxOTAImageNotifyJitter";
            this.textBoxOTAImageNotifyJitter.Size = new System.Drawing.Size(163, 28);
            this.textBoxOTAImageNotifyJitter.TabIndex = 18;
            // 
            // textBoxOTAImageNotifyManuID
            // 
            this.textBoxOTAImageNotifyManuID.Location = new System.Drawing.Point(1324, 53);
            this.textBoxOTAImageNotifyManuID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTAImageNotifyManuID.Name = "textBoxOTAImageNotifyManuID";
            this.textBoxOTAImageNotifyManuID.Size = new System.Drawing.Size(156, 28);
            this.textBoxOTAImageNotifyManuID.TabIndex = 17;
            // 
            // textBoxOTAImageNotifyImageType
            // 
            this.textBoxOTAImageNotifyImageType.Location = new System.Drawing.Point(1136, 53);
            this.textBoxOTAImageNotifyImageType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTAImageNotifyImageType.Name = "textBoxOTAImageNotifyImageType";
            this.textBoxOTAImageNotifyImageType.Size = new System.Drawing.Size(178, 28);
            this.textBoxOTAImageNotifyImageType.TabIndex = 16;
            // 
            // textBoxOTAImageNotifyFileVersion
            // 
            this.textBoxOTAImageNotifyFileVersion.Location = new System.Drawing.Point(976, 53);
            this.textBoxOTAImageNotifyFileVersion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTAImageNotifyFileVersion.Name = "textBoxOTAImageNotifyFileVersion";
            this.textBoxOTAImageNotifyFileVersion.Size = new System.Drawing.Size(148, 28);
            this.textBoxOTAImageNotifyFileVersion.TabIndex = 15;
            // 
            // comboBoxOTAImageNotifyType
            // 
            this.comboBoxOTAImageNotifyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOTAImageNotifyType.FormattingEnabled = true;
            this.comboBoxOTAImageNotifyType.Location = new System.Drawing.Point(772, 53);
            this.comboBoxOTAImageNotifyType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOTAImageNotifyType.Name = "comboBoxOTAImageNotifyType";
            this.comboBoxOTAImageNotifyType.Size = new System.Drawing.Size(193, 26);
            this.comboBoxOTAImageNotifyType.TabIndex = 14;
            // 
            // textBoxOTAImageNotifyDstEP
            // 
            this.textBoxOTAImageNotifyDstEP.Location = new System.Drawing.Point(614, 54);
            this.textBoxOTAImageNotifyDstEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTAImageNotifyDstEP.Name = "textBoxOTAImageNotifyDstEP";
            this.textBoxOTAImageNotifyDstEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxOTAImageNotifyDstEP.TabIndex = 13;
            // 
            // textBoxOTAImageNotifySrcEP
            // 
            this.textBoxOTAImageNotifySrcEP.Location = new System.Drawing.Point(453, 54);
            this.textBoxOTAImageNotifySrcEP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTAImageNotifySrcEP.Name = "textBoxOTAImageNotifySrcEP";
            this.textBoxOTAImageNotifySrcEP.Size = new System.Drawing.Size(148, 28);
            this.textBoxOTAImageNotifySrcEP.TabIndex = 12;
            this.textBoxOTAImageNotifySrcEP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxOTAImageNotifyTargetAddr
            // 
            this.textBoxOTAImageNotifyTargetAddr.Location = new System.Drawing.Point(294, 54);
            this.textBoxOTAImageNotifyTargetAddr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOTAImageNotifyTargetAddr.Name = "textBoxOTAImageNotifyTargetAddr";
            this.textBoxOTAImageNotifyTargetAddr.Size = new System.Drawing.Size(148, 28);
            this.textBoxOTAImageNotifyTargetAddr.TabIndex = 11;
            // 
            // comboBoxOTAImageNotifyAddrMode
            // 
            this.comboBoxOTAImageNotifyAddrMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOTAImageNotifyAddrMode.FormattingEnabled = true;
            this.comboBoxOTAImageNotifyAddrMode.Location = new System.Drawing.Point(135, 54);
            this.comboBoxOTAImageNotifyAddrMode.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOTAImageNotifyAddrMode.Name = "comboBoxOTAImageNotifyAddrMode";
            this.comboBoxOTAImageNotifyAddrMode.Size = new System.Drawing.Size(148, 26);
            this.comboBoxOTAImageNotifyAddrMode.TabIndex = 10;
            // 
            // buttonOTAImageNotify
            // 
            this.buttonOTAImageNotify.Location = new System.Drawing.Point(4, 48);
            this.buttonOTAImageNotify.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOTAImageNotify.Name = "buttonOTAImageNotify";
            this.buttonOTAImageNotify.Size = new System.Drawing.Size(122, 36);
            this.buttonOTAImageNotify.TabIndex = 9;
            this.buttonOTAImageNotify.Text = "Image Notify";
            this.buttonOTAImageNotify.UseVisualStyleBackColor = true;
            this.buttonOTAImageNotify.Click += new System.EventHandler(this.buttonOTAImageNotify_Click);
            // 
            // textBoxOtaFileSize
            // 
            this.textBoxOtaFileSize.Location = new System.Drawing.Point(772, 10);
            this.textBoxOtaFileSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtaFileSize.Name = "textBoxOtaFileSize";
            this.textBoxOtaFileSize.ReadOnly = true;
            this.textBoxOtaFileSize.Size = new System.Drawing.Size(103, 28);
            this.textBoxOtaFileSize.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(723, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Size";
            // 
            // textBoxOtaFileVersion
            // 
            this.textBoxOtaFileVersion.Location = new System.Drawing.Point(609, 10);
            this.textBoxOtaFileVersion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtaFileVersion.Name = "textBoxOtaFileVersion";
            this.textBoxOtaFileVersion.ReadOnly = true;
            this.textBoxOtaFileVersion.Size = new System.Drawing.Size(103, 28);
            this.textBoxOtaFileVersion.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "File Version";
            // 
            // textBoxOtaFileImageType
            // 
            this.textBoxOtaFileImageType.Location = new System.Drawing.Point(424, 10);
            this.textBoxOtaFileImageType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtaFileImageType.Name = "textBoxOtaFileImageType";
            this.textBoxOtaFileImageType.ReadOnly = true;
            this.textBoxOtaFileImageType.Size = new System.Drawing.Size(73, 28);
            this.textBoxOtaFileImageType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Image Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manu Code";
            // 
            // textBoxOtaFileManuCode
            // 
            this.textBoxOtaFileManuCode.Location = new System.Drawing.Point(237, 10);
            this.textBoxOtaFileManuCode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOtaFileManuCode.Name = "textBoxOtaFileManuCode";
            this.textBoxOtaFileManuCode.ReadOnly = true;
            this.textBoxOtaFileManuCode.Size = new System.Drawing.Size(73, 28);
            this.textBoxOtaFileManuCode.TabIndex = 1;
            // 
            // buttonOTALoadNewImage
            // 
            this.buttonOTALoadNewImage.Location = new System.Drawing.Point(4, 4);
            this.buttonOTALoadNewImage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOTALoadNewImage.Name = "buttonOTALoadNewImage";
            this.buttonOTALoadNewImage.Size = new System.Drawing.Size(122, 36);
            this.buttonOTALoadNewImage.TabIndex = 0;
            this.buttonOTALoadNewImage.Text = "Load Image";
            this.buttonOTALoadNewImage.UseVisualStyleBackColor = true;
            this.buttonOTALoadNewImage.Click += new System.EventHandler(this.buttonOTALoadNewImage_Click);
            // 
            // buttonMessageViewClear
            // 
            this.buttonMessageViewClear.Location = new System.Drawing.Point(1816, 667);
            this.buttonMessageViewClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMessageViewClear.Name = "buttonMessageViewClear";
            this.buttonMessageViewClear.Size = new System.Drawing.Size(112, 32);
            this.buttonMessageViewClear.TabIndex = 23;
            this.buttonMessageViewClear.Text = "Clear";
            this.buttonMessageViewClear.UseVisualStyleBackColor = true;
            this.buttonMessageViewClear.Click += new System.EventHandler(this.buttonMessageViewClear_Click);
            // 
            // buttonClearRaw
            // 
            this.buttonClearRaw.Location = new System.Drawing.Point(1053, 667);
            this.buttonClearRaw.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearRaw.Name = "buttonClearRaw";
            this.buttonClearRaw.Size = new System.Drawing.Size(112, 32);
            this.buttonClearRaw.TabIndex = 19;
            this.buttonClearRaw.Text = "Clear";
            this.buttonClearRaw.UseVisualStyleBackColor = true;
            this.buttonClearRaw.Click += new System.EventHandler(this.buttonClearRaw_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1168, 674);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Received Message View";
            // 
            // richTextBoxMessageView
            // 
            this.richTextBoxMessageView.Location = new System.Drawing.Point(1173, 706);
            this.richTextBoxMessageView.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxMessageView.Name = "richTextBoxMessageView";
            this.richTextBoxMessageView.Size = new System.Drawing.Size(754, 334);
            this.richTextBoxMessageView.TabIndex = 17;
            this.richTextBoxMessageView.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 674);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Raw Data";
            // 
            // richTextBoxCommandResponse
            // 
            this.richTextBoxCommandResponse.Location = new System.Drawing.Point(18, 706);
            this.richTextBoxCommandResponse.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxCommandResponse.Name = "richTextBoxCommandResponse";
            this.richTextBoxCommandResponse.Size = new System.Drawing.Size(1146, 334);
            this.richTextBoxCommandResponse.TabIndex = 4;
            this.richTextBoxCommandResponse.Text = "";
            // 
            // openOtaFileDialog
            // 
            this.openOtaFileDialog.FileName = "openFileDialog1";
            this.openOtaFileDialog.Filter = "OTA|*.ota";
            this.openOtaFileDialog.Title = "Select an OTA Image";
            // 
            // textBoxAddSceneExtensionsLen
            // 
            this.textBoxAddSceneExtensionsLen.Location = new System.Drawing.Point(1713, 48);
            this.textBoxAddSceneExtensionsLen.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddSceneExtensionsLen.Name = "textBoxAddSceneExtensionsLen";
            this.textBoxAddSceneExtensionsLen.Size = new System.Drawing.Size(148, 28);
            this.textBoxAddSceneExtensionsLen.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1947, 1076);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonClearRaw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxCommandResponse);
            this.Controls.Add(this.richTextBoxMessageView);
            this.Controls.Add(this.buttonMessageViewClear);
            this.Controls.Add(this.label4);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ZigBee Gateway User Interface";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.AHIControl.ResumeLayout(false);
            this.AHIControl.PerformLayout();
            this.BasicClusterTab.ResumeLayout(false);
            this.BasicClusterTab.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.tabPage15.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPortToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPort;
        private System.Windows.Forms.ToolStripStatusLabel toolStripPortSettings;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSetEPID;
        private System.Windows.Forms.Button buttonGetVersion;
        private System.Windows.Forms.Button buttonSetCMSK;
        private System.Windows.Forms.RichTextBox richTextBoxCommandResponse;
        private System.Windows.Forms.TextBox textBoxSetEPID;
        private System.Windows.Forms.TextBox textBoxSetCMSK;
        private System.Windows.Forms.Button buttonSetSecurity;
        private System.Windows.Forms.Button buttonSetDeviceType;
        private System.Windows.Forms.TextBox textBoxSetSecurityKeySeqNbr;
        private System.Windows.Forms.Button buttonErasePD;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonBind;
        private System.Windows.Forms.Button buttonStartNWK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxMessageView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClearRaw;
        private System.Windows.Forms.Button buttonMessageViewClear;
        private System.Windows.Forms.ComboBox comboBoxSetType;
        private System.Windows.Forms.ComboBox comboBoxSetKeyState;
        private System.Windows.Forms.ComboBox comboBoxSetKeyType;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonPermitJoin;
        private System.Windows.Forms.TextBox textBoxPermitJoinAddr;
        private System.Windows.Forms.TextBox textBoxPermitJoinInterval;
        private System.Windows.Forms.ComboBox comboBoxPermitJoinTCsignificance;
        private System.Windows.Forms.ComboBox comboBoxSecurityKey;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonIeeeAddrReq;
        private System.Windows.Forms.Button buttonNwkAddrReq;
        private System.Windows.Forms.TextBox textBoxNodeDescReq;
        private System.Windows.Forms.Button buttonNodeDescReq;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonOnOff;
        private System.Windows.Forms.TextBox textBoxOnOffAddr;
        private System.Windows.Forms.TextBox textBoxOnOffSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxOnOffDstEndPoint;
        private System.Windows.Forms.Button buttonMatchReq;
        private System.Windows.Forms.Button buttonActiveEpReq;
        private System.Windows.Forms.Button buttonPowerDescReq;
        private System.Windows.Forms.Button buttonSimpleDescReq;
        private System.Windows.Forms.TextBox textBoxSimpleReqEndPoint;
        private System.Windows.Forms.TextBox textBoxSimpleReqAddr;
        private System.Windows.Forms.TextBox textBoxPowerReqAddr;
        private System.Windows.Forms.TextBox textBoxActiveEpAddr;
        private System.Windows.Forms.TextBox textBoxMatchReqAddr;
        private System.Windows.Forms.TextBox textBoxMatchReqNbrInputClusters;
        private System.Windows.Forms.TextBox textBoxMatchReqNbrOutputClusters;
        private System.Windows.Forms.TextBox textBoxMatchReqProfileID;
        private System.Windows.Forms.TextBox textBoxMatchReqInputClusters;
        private System.Windows.Forms.TextBox textBoxMatchReqOutputClusters;
        private System.Windows.Forms.TextBox textBoxComplexReqAddr;
        private System.Windows.Forms.Button buttonComplexReq;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox textBoxMoveToLevelAddr;
        private System.Windows.Forms.Button buttonMoveToLevel;
        private System.Windows.Forms.TextBox textBoxMoveToLevelTransTime;
        private System.Windows.Forms.TextBox textBoxMoveToLevelLevel;
        private System.Windows.Forms.TextBox textBoxMoveToLevelDstEndPoint;
        private System.Windows.Forms.TextBox textBoxMoveToLevelSrcEndPoint;
        private System.Windows.Forms.Button buttonIdQuery;
        private System.Windows.Forms.Button buttonIdSend;
        private System.Windows.Forms.TextBox textBoxIdSendTime;
        private System.Windows.Forms.TextBox textBoxIdSendDstEp;
        private System.Windows.Forms.TextBox textBoxSendIdSrcEp;
        private System.Windows.Forms.TextBox textBoxSendIdAddr;
        private System.Windows.Forms.TextBox textBoxIdQueryDstEp;
        private System.Windows.Forms.TextBox textBoxIdQuerySrcEp;
        private System.Windows.Forms.TextBox textBoxIdQueryAddr;
        private System.Windows.Forms.TextBox textBoxMoveToHueTime;
        private System.Windows.Forms.TextBox textBoxMoveToHueDir;
        private System.Windows.Forms.TextBox textBoxMoveToHueHue;
        private System.Windows.Forms.TextBox textBoxMoveToHueDstEp;
        private System.Windows.Forms.TextBox textBoxMoveToHueSrcEp;
        private System.Windows.Forms.Button buttonMoveToHue;
        private System.Windows.Forms.TextBox textBoxMoveToHueAddr;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox comboBoxLockUnlock;
        private System.Windows.Forms.TextBox textBoxLockUnlockDstEp;
        private System.Windows.Forms.TextBox textBoxLockUnlockSrcEp;
        private System.Windows.Forms.TextBox textBoxLockUnlockAddr;
        private System.Windows.Forms.Button buttonLockUnlock;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button buttonZllTouchlinkInitiate;
        private System.Windows.Forms.Button buttonZllTouchlinkFactoryReset;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TextBox textBoxZllOnOffEffectsGradient;
        private System.Windows.Forms.TextBox textBoxZllOnOffEffectsDstEp;
        private System.Windows.Forms.TextBox textBoxZllOnOffEffectsSrcEp;
        private System.Windows.Forms.TextBox textBoxZllOnOffEffectsAddr;
        private System.Windows.Forms.Button buttonZllOnOffEffects;
        private System.Windows.Forms.ComboBox comboBoxZllOnOffEffectID;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonZllMoveToHue;
        private System.Windows.Forms.TextBox textBoxZllMoveToHueAddr;
        private System.Windows.Forms.TextBox textBoxZllMoveToHueSrcEp;
        private System.Windows.Forms.TextBox textBoxZllMoveToHueDstEp;
        private System.Windows.Forms.TextBox textBoxZllMoveToHueDirection;
        private System.Windows.Forms.TextBox textBoxZllMoveToHueTransTime;
        private System.Windows.Forms.TextBox textBoxZllMoveToHueHue;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.TextBox textBoxAddGroupDstEp;
        private System.Windows.Forms.TextBox textBoxAddGroupSrcEp;
        private System.Windows.Forms.TextBox textBoxAddGroupAddr;
        private System.Windows.Forms.TextBox textBoxAddGroupGroupAddr;
        private System.Windows.Forms.TextBox textBoxIeeeReqStartIndex;
        private System.Windows.Forms.ComboBox comboBoxIeeeReqType;
        private System.Windows.Forms.TextBox textBoxIeeeReqAddr;
        private System.Windows.Forms.TextBox textBoxIeeeReqTargetAddr;
        private System.Windows.Forms.TextBox textBoxNwkAddrReqTargetAddr;
        private System.Windows.Forms.TextBox textBoxNwkAddrReqExtAddr;
        private System.Windows.Forms.TextBox textBoxNwkAddrReqStartIndex;
        private System.Windows.Forms.ComboBox comboBoxNwkAddrReqType;
        private System.Windows.Forms.TextBox textBoxViewGroupGroupAddr;
        private System.Windows.Forms.TextBox textBoxViewGroupDstEp;
        private System.Windows.Forms.TextBox textBoxViewGroupSrcEp;
        private System.Windows.Forms.TextBox textBoxViewGroupAddr;
        private System.Windows.Forms.Button buttonViewGroup;
        private System.Windows.Forms.Button buttonStartScan;
        private System.Windows.Forms.ComboBox comboBoxOnOffCommand;
		private System.Windows.Forms.Button buttonRecoverNwk;
        private System.Windows.Forms.Button buttonRestoreNwk;
        private System.Windows.Forms.Button buttonMgmtLqiReq;
        private System.Windows.Forms.TextBox textBoxBindTargetEP;
        private System.Windows.Forms.TextBox textBoxBindClusterID;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Button buttonReadAttrib;
        private System.Windows.Forms.TextBox textBoxReadAttribTargetAddr;
        private System.Windows.Forms.TextBox textBoxReadAttribSrcEP;
        private System.Windows.Forms.TextBox textBoxReadAttribDstEP;
        private System.Windows.Forms.TextBox textBoxReadAttribClusterID;
        private System.Windows.Forms.TextBox textBoxReadAttribID1;
        private System.Windows.Forms.ComboBox comboBoxReadAttribDirection;
        private System.Windows.Forms.TextBox textBoxReadAttribCount;
        private System.Windows.Forms.Button buttonWriteAttrib;
        private System.Windows.Forms.TextBox textBoxConfigReportTargetAddr;
        private System.Windows.Forms.Button buttonConfigReport;
        private System.Windows.Forms.TextBox textBoxConfigReportSrcEP;
        private System.Windows.Forms.TextBox textBoxConfigReportClusterID;
        private System.Windows.Forms.TextBox textBoxConfigReportDstEP;
        private System.Windows.Forms.ComboBox comboBoxConfigReportDirection;
        private System.Windows.Forms.TextBox textBoxConfigReportMinInterval;
        private System.Windows.Forms.TextBox textBoxConfigReportAttribID;
        private System.Windows.Forms.TextBox textBoxConfigReportAttribType;
        private System.Windows.Forms.ComboBox comboBoxConfigReportAttribDirection;
        private System.Windows.Forms.ComboBox comboBoxBindAddrMode;
        private System.Windows.Forms.TextBox textBoxBindDestAddr;
        private System.Windows.Forms.TextBox textBoxBindDestEP;
        private System.Windows.Forms.TextBox textBoxReadAllAttribAddr;
        private System.Windows.Forms.Button buttonReadAllAttrib;
        private System.Windows.Forms.TextBox textBoxReadAllAttribDstEP;
        private System.Windows.Forms.TextBox textBoxReadAllAttribSrcEP;
        private System.Windows.Forms.ComboBox comboBoxReadAllAttribDirection;
        private System.Windows.Forms.TextBox textBoxReadAllAttribClusterID;
        private System.Windows.Forms.TextBox textBoxGetGroupDstEp;
        private System.Windows.Forms.TextBox textBoxGetGroupSrcEp;
        private System.Windows.Forms.TextBox textBoxGetGroupTargetAddr;
        private System.Windows.Forms.Button buttonGetGroup;
        private System.Windows.Forms.TextBox textBoxGetGroupCount;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.TextBox textBoxRemoveGroupGroupAddr;
        private System.Windows.Forms.TextBox textBoxRemoveGroupDstEp;
        private System.Windows.Forms.TextBox textBoxRemoveGroupSrcEp;
        private System.Windows.Forms.TextBox textBoxRemoveGroupTargetAddr;
        private System.Windows.Forms.TextBox textBoxRemoveAllGroupDstEp;
        private System.Windows.Forms.TextBox textBoxRemoveAllGroupSrcEp;
        private System.Windows.Forms.TextBox textBoxRemoveAllGroupTargetAddr;
        private System.Windows.Forms.Button buttonGroupRemoveAll;
        private System.Windows.Forms.ComboBox comboBoxOnOffAddrMode;
        private System.Windows.Forms.ComboBox comboBoxMoveToLevelAddrMode;
        private System.Windows.Forms.Button buttonUnBind;
        private System.Windows.Forms.TextBox textBoxUnBindTargetExtAddr;
        private System.Windows.Forms.TextBox textBoxUnBindTargetEP;
        private System.Windows.Forms.TextBox textBoxUnBindClusterID;
        private System.Windows.Forms.TextBox textBoxUnBindDestAddr;
        private System.Windows.Forms.ComboBox comboBoxUnBindAddrMode;
        private System.Windows.Forms.TextBox textBoxUnBindDestEP;
        private System.Windows.Forms.Button buttonMoveToColor;
        private System.Windows.Forms.TextBox textBoxMoveToColorTime;
        private System.Windows.Forms.TextBox textBoxMoveToColorY;
        private System.Windows.Forms.TextBox textBoxMoveToColorX;
        private System.Windows.Forms.TextBox textBoxMoveToColorDstEp;
        private System.Windows.Forms.TextBox textBoxMoveToColorSrcEp;
        private System.Windows.Forms.TextBox textBoxMoveToColorAddr;
        private System.Windows.Forms.Button buttonDiscoverAttributes;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesMaxIDs;
        private System.Windows.Forms.ComboBox comboBoxDiscoverAttributesDirection;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesClusterID;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesDstEp;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesSrcEp;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesAddr;
        private System.Windows.Forms.Button buttonMgmtLeave;
        private System.Windows.Forms.ComboBox comboBoxMgmtLeaveChildren;
        private System.Windows.Forms.ComboBox comboBoxMgmtLeaveReJoin;
        private System.Windows.Forms.TextBox textBoxMgmtLeaveExtAddr;
        private System.Windows.Forms.TextBox textBoxMgmtLeaveAddr;
        private System.Windows.Forms.TextBox textBoxConfigReportChange;
        private System.Windows.Forms.TextBox textBoxConfigReportTimeOut;
        private System.Windows.Forms.TextBox textBoxConfigReportMaxInterval;
        private System.Windows.Forms.ComboBox comboBoxWriteAttribDirection;
        private System.Windows.Forms.TextBox textBoxWriteAttribClusterID;
        private System.Windows.Forms.TextBox textBoxWriteAttribDstEP;
        private System.Windows.Forms.TextBox textBoxWriteAttribSrcEP;
        private System.Windows.Forms.TextBox textBoxWriteAttribTargetAddr;
        private System.Windows.Forms.TextBox textBoxWriteAttribData;
        private System.Windows.Forms.TextBox textBoxWriteAttribID;
        private System.Windows.Forms.TextBox textBoxMoveToColorTempDstEp;
        private System.Windows.Forms.TextBox textBoxMoveToColorTempSrcEp;
        private System.Windows.Forms.TextBox textBoxMoveToColorTempAddr;
        private System.Windows.Forms.Button buttonMoveToColorTemp;
        private System.Windows.Forms.TextBox textBoxMoveToColorTempRate;
        private System.Windows.Forms.TextBox textBoxMoveToColorTempTemp;
        private System.Windows.Forms.ComboBox comboBoxMoveToLevelOnOff;
        private System.Windows.Forms.ComboBox comboBoxConfigReportAddrMode;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.ComboBox comboBoxEnrollRspAddrMode;
        private System.Windows.Forms.Button buttonEnrollResponse;
        private System.Windows.Forms.TextBox textBoxEnrollRspDstEp;
        private System.Windows.Forms.TextBox textBoxEnrollRspSrcEp;
        private System.Windows.Forms.TextBox textBoxEnrollRspAddr;
        private System.Windows.Forms.TextBox textBoxEnrollRspZone;
        private System.Windows.Forms.ComboBox comboBoxEnrollRspCode;
        private System.Windows.Forms.TextBox textBoxWriteAttribDataType;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.Button buttonOTALoadNewImage;
        private System.Windows.Forms.OpenFileDialog openOtaFileDialog;
        private System.Windows.Forms.TextBox textBoxOtaFileManuCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOtaFileImageType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOtaFileVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOtaFileSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxReadAttribManuSpecific;
        private System.Windows.Forms.TextBox textBoxReadAttribManuID;
        private System.Windows.Forms.TextBox textBoxWriteAttribManuID;
        private System.Windows.Forms.ComboBox comboBoxWriteAttribManuSpecific;
        private System.Windows.Forms.Button buttonReadReportConfig;
        private System.Windows.Forms.ComboBox comboBoxReadReportConfigAddrMode;
        private System.Windows.Forms.TextBox textBoxReadReportConfigTargetAddr;
        private System.Windows.Forms.TextBox textBoxReadReportConfigDstEP;
        private System.Windows.Forms.TextBox textBoxReadReportConfigSrcEP;
        private System.Windows.Forms.TextBox textBoxReadReportConfigClusterID;
        private System.Windows.Forms.TextBox textBoxReadReportConfigAttribID;
        private System.Windows.Forms.ComboBox comboBoxReadReportConfigDirIsRx;
        private System.Windows.Forms.ComboBox comboBoxReadReportConfigDirection;
        private System.Windows.Forms.TextBox textBoxManyToOneRouteRequesRadius;
        private System.Windows.Forms.Button buttonManyToOneRouteRequest;
        private System.Windows.Forms.ComboBox comboBoxManyToOneRouteRequestCacheRoute;
        private System.Windows.Forms.Button buttonMgmtNwkUpdate;
        private System.Windows.Forms.ComboBox comboBoxMgmtNwkUpdateAddrMode;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateTargetAddr;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateChannelMask;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateScanDuration;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateScanCount;
        private System.Windows.Forms.Button buttonDiscoverCommands;
        private System.Windows.Forms.ComboBox comboBoxDiscoverCommandsAddrMode;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsTargetAddr;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsDstEP;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsSrcEP;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsClusterID;
        private System.Windows.Forms.ComboBox comboBoxDiscoverCommandsDirection;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsCommandID;
        private System.Windows.Forms.ComboBox comboBoxDiscoverCommandsManuSpecific;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsManuID;
        private System.Windows.Forms.TextBox textBoxDiscoverCommandsMaxCommands;
        private System.Windows.Forms.ComboBox comboBoxDiscoverAttributesExtended;
        private System.Windows.Forms.ComboBox comboBoxDiscoverCommandsRxGen;
        private System.Windows.Forms.TextBox textBoxMgmtNwkUpdateNwkManagerAddr;
        private System.Windows.Forms.TabPage BasicClusterTab;
        private System.Windows.Forms.ComboBox comboBoxBasicResetTargetAddrMode;
        private System.Windows.Forms.Button buttonBasicReset;
        private System.Windows.Forms.TextBox textBoxBasicResetDstEP;
        private System.Windows.Forms.TextBox textBoxBasicResetSrcEP;
        private System.Windows.Forms.TextBox textBoxBasicResetTargetAddr;
        private System.Windows.Forms.Button buttonOTAImageNotify;
        private System.Windows.Forms.ComboBox comboBoxOTAImageNotifyAddrMode;
        private System.Windows.Forms.TextBox textBoxOTAImageNotifyTargetAddr;
        private System.Windows.Forms.TextBox textBoxOTAImageNotifyDstEP;
        private System.Windows.Forms.TextBox textBoxOTAImageNotifySrcEP;
        private System.Windows.Forms.ComboBox comboBoxOTAImageNotifyType;
        private System.Windows.Forms.TextBox textBoxOTAImageNotifyFileVersion;
        private System.Windows.Forms.TextBox textBoxOTAImageNotifyImageType;
        private System.Windows.Forms.TextBox textBoxOTAImageNotifyManuID;
        private System.Windows.Forms.TextBox textBoxOTAImageNotifyJitter;
        private System.Windows.Forms.ProgressBar progressBarOtaDownloadProgress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOtaDownloadStatus;
        private System.Windows.Forms.TextBox textBoxOtaFileOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGroupAddIfIdentifyDstEp;
        private System.Windows.Forms.TextBox textBoxGroupAddIfIndentifyingTargetAddr;
        private System.Windows.Forms.Button buttonGroupAddIfIdentifying;
        private System.Windows.Forms.TextBox textBoxGroupAddIfIdentifyGroupID;
        private System.Windows.Forms.TextBox textBoxGroupAddIfIdentifySrcEp;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBoxGetSceneMembershipGroupID;
        private System.Windows.Forms.TextBox textBoxGetSceneMembershipDstEndPoint;
        private System.Windows.Forms.TextBox textBoxGetSceneMembershipSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxGetSceneMembershipAddr;
        private System.Windows.Forms.ComboBox comboBoxGetSceneMembershipAddrMode;
        private System.Windows.Forms.Button buttonGetSceneMembership;
        private System.Windows.Forms.TextBox textBoxRecallSceneSceneId;
        private System.Windows.Forms.TextBox textBoxRecallSceneGroupId;
        private System.Windows.Forms.TextBox textBoxRecallSceneDstEndPoint;
        private System.Windows.Forms.TextBox textBoxRecallSceneSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxRecallSceneAddr;
        private System.Windows.Forms.ComboBox comboBoxRecallSceneAddrMode;
        private System.Windows.Forms.Button buttonRecallScene;
        private System.Windows.Forms.TextBox textBoxStoreSceneSceneId;
        private System.Windows.Forms.TextBox textBoxStoreSceneGroupId;
        private System.Windows.Forms.TextBox textBoxStoreSceneDstEndPoint;
        private System.Windows.Forms.TextBox textBoxStoreSceneSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxStoreSceneAddr;
        private System.Windows.Forms.ComboBox comboBoxStoreSceneAddrMode;
        private System.Windows.Forms.Button buttonStoreScene;
        private System.Windows.Forms.TextBox textBoxAddSceneMaxNameLen;
        private System.Windows.Forms.TextBox textBoxAddSceneNameLen;
        private System.Windows.Forms.TextBox textBoxAddSceneName;
        private System.Windows.Forms.TextBox textBoxAddSceneTransTime;
        private System.Windows.Forms.TextBox textBoxAddSceneSceneId;
        private System.Windows.Forms.TextBox textBoxAddSceneGroupId;
        private System.Windows.Forms.TextBox textBoxAddSceneDstEndPoint;
        private System.Windows.Forms.TextBox textBoxAddSceneSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxAddSceneAddr;
        private System.Windows.Forms.ComboBox comboBoxAddSceneAddrMode;
        private System.Windows.Forms.Button buttonAddScene;
        private System.Windows.Forms.ComboBox comboBoxViewSceneAddrMode;
        private System.Windows.Forms.TextBox textBoxViewSceneSceneId;
        private System.Windows.Forms.TextBox textBoxViewSceneGroupId;
        private System.Windows.Forms.TextBox textBoxViewSceneDstEndPoint;
        private System.Windows.Forms.TextBox textBoxViewSceneSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxViewSceneAddr;
        private System.Windows.Forms.Button buttonViewScene;
        private System.Windows.Forms.Button buttonRemoveAllScenes;
        private System.Windows.Forms.TextBox textBoxRemoveAllScenesGroupID;
        private System.Windows.Forms.TextBox textBoxRemoveAllScenesDstEndPoint;
        private System.Windows.Forms.TextBox textBoxRemoveAllScenesSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxRemoveAllScenesAddr;
        private System.Windows.Forms.ComboBox comboBoxRemoveAllScenesAddrMode;
        private System.Windows.Forms.Button buttonRemoveScene;
        private System.Windows.Forms.TextBox textBoxRemoveSceneSceneID;
        private System.Windows.Forms.TextBox textBoxRemoveSceneGroupID;
        private System.Windows.Forms.TextBox textBoxRemoveSceneDstEndPoint;
        private System.Windows.Forms.TextBox textBoxRemoveSceneSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxRemoveSceneAddr;
        private System.Windows.Forms.ComboBox comboBoxRemoveSceneAddrMode;
        private System.Windows.Forms.Button buttonPermitJoinState;
        private System.Windows.Forms.TextBox textBoxRemoveChildAddr;
        private System.Windows.Forms.TextBox textBoxRemoveParentAddr;
        private System.Windows.Forms.Button buttonRemoveDevice;
        private System.Windows.Forms.ComboBox comboBoxLeaveChildren;
        private System.Windows.Forms.ComboBox comboBoxLeaveReJoin;
        private System.Windows.Forms.TextBox textBoxLeaveAddr;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.TextBox textBoxLqiReqStartIndex;
        private System.Windows.Forms.TextBox textBoxLqiReqTargetAddr;
        private System.Windows.Forms.TextBox textBoxRestoreNwkFrameCounter;
        private System.Windows.Forms.ToolTip toolTipGeneralTooltip;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsData;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsClusterID;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsDstEP;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsSrcEP;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsTargetAddr;
        private System.Windows.Forms.ComboBox comboBoxRawDataCommandsAddrMode;
        private System.Windows.Forms.Button buttonRawDataSend;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsRadius;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsSecurityMode;
        private System.Windows.Forms.TextBox textBoxRawDataCommandsProfileID;
        private System.Windows.Forms.TextBox textBoxUserReqAddr;
        private System.Windows.Forms.Button buttonUserReq;
        private System.Windows.Forms.TextBox textBoxUserSetReqAddr;
        private System.Windows.Forms.Button buttonUserSetReq;
        private System.Windows.Forms.TextBox textBoxUserSetReqDescription;
        private System.Windows.Forms.TextBox textBoxOTASetWaitForDataParamsRequestBlockDelay;
        private System.Windows.Forms.TextBox textBoxOTASetWaitForDataParamsRequestTime;
        private System.Windows.Forms.TextBox textBoxOTASetWaitForDataParamsCurrentTime;
        private System.Windows.Forms.TextBox textBoxOTASetWaitForDataParamsSrcEP;
        private System.Windows.Forms.TextBox textBoxOTASetWaitForDataParamsTargetAddr;
        private System.Windows.Forms.Button buttonOTASetWaitForDataParams;
        private System.Windows.Forms.TextBox textBoxDiscoverAttributesStartAttrId;
        private System.Windows.Forms.TextBox textBoxBindTargetExtAddr;
        private System.Windows.Forms.TabPage AHIControl;
        private System.Windows.Forms.TextBox textBoxDioSetDirectionOutputPinMask;
        private System.Windows.Forms.TextBox textBoxDioSetDirectionInputPinMask;
        private System.Windows.Forms.Button buttonDioSetDirection;
        private System.Windows.Forms.TextBox textBoxIPNConfigPollPeriod;
        private System.Windows.Forms.ComboBox comboBoxIPNConfigRegisterCallback;
        private System.Windows.Forms.TextBox textBoxIPNConfigDioStatusOutDioMask;
        private System.Windows.Forms.TextBox textBoxIPNConfigDioRfActiveOutDioMask;
        private System.Windows.Forms.ComboBox comboBoxIPNConfigEnable;
        private System.Windows.Forms.Button buttonInPacketNotification;
        private System.Windows.Forms.TextBox textBoxDioSetOutputOffPinMask;
        private System.Windows.Forms.TextBox textBoxDioSetOutputOnPinMask;
        private System.Windows.Forms.Button buttonDioSetOutput;
        private System.Windows.Forms.TextBox textBoxIPNConfigDioTxConfInDioMask;
        private System.Windows.Forms.ComboBox comboBoxIPNConfigTimerId;
        private System.Windows.Forms.Label labelUnimplemented;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.Button SetRaiseLower_button1;
        private System.Windows.Forms.TextBox textBoxHVACAddress;
        private System.Windows.Forms.ComboBox comboBoxHVACAddressMode;
        private System.Windows.Forms.ComboBox comboBoxHVACSetMode;
        private System.Windows.Forms.TextBox textBoxHVACRaiseLowData;
        private System.Windows.Forms.TextBox textBoxHVACDstEndPoint;
        private System.Windows.Forms.TextBox textBoxHVACSrcEndPoint;
        private System.Windows.Forms.TextBox textBoxAddSceneExtensionsLen;
    }
}

