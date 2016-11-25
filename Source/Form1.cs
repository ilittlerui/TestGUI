using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Globalization;
using PortSet;
using ListManagement;
using System.IO;
using System.Collections;



#if false
/** Serial link message types */
typedef enum
{
    /* Common Commands */
    E_SL_MSG_STATUS = 0x8000,
    E_SL_MSG_LOG = 0x8001,

    E_SL_MSG_DATA_INDICATION = 0x8002,

    E_SL_MSG_NODE_CLUSTER_LIST = 0x8003,
    E_SL_MSG_NODE_ATTRIBUTE_LIST = 0x8004,
    E_SL_MSG_NODE_COMMAND_ID_LIST = 0x8005,
    E_SL_MSG_NODE_NON_FACTORY_NEW_RESTART = 0x8006,
    E_SL_MSG_NODE_FACTORY_NEW_RESTART = 0x8007,
    E_SL_MSG_GET_VERSION = 0x0010,
    E_SL_MSG_VERSION_LIST = 0x8010,

    E_SL_MSG_SET_EXT_PANID = 0x0020,
    E_SL_MSG_SET_CHANNELMASK = 0x0021,
    E_SL_MSG_SET_SECURITY = 0x0022,
    E_SL_MSG_SET_DEVICETYPE = 0x0023,
    E_SL_MSG_START_NETWORK = 0x0024,
    E_SL_MSG_START_SCAN = 0x0025,
    E_SL_MSG_NETWORK_JOINED_FORMED = 0x8024,
    E_SL_MSG_NETWORK_REMOVE_DEVICE = 0x0026,
    E_SL_MSG_NETWORK_WHITELIST_ENABLE = 0x0027,
    E_SL_MSG_ADD_AUTHENTICATE_DEVICE = 0x0028,
    E_SL_MSG_AUTHENTICATE_DEVICE_RESPONSE = 0x8028,

    E_SL_MSG_RESET = 0x0011,
    E_SL_MSG_ERASE_PERSISTENT_DATA = 0x0012,
    E_SL_MSG_ZLL_FACTORY_NEW = 0x0013,
    E_SL_MSG_GET_PERMIT_JOIN = 0x0014,
    E_SL_MSG_GET_PERMIT_JOIN_RESPONSE = 0x8014,
    E_SL_MSG_BIND = 0x0030,
    E_SL_MSG_BIND_RESPONSE = 0x8030,
    E_SL_MSG_UNBIND = 0x0031,
    E_SL_MSG_UNBIND_RESPONSE = 0x8031,

    E_SL_MSG_NETWORK_ADDRESS_REQUEST = 0x0040,
    E_SL_MSG_NETWORK_ADDRESS_RESPONSE = 0x8040,
    E_SL_MSG_IEEE_ADDRESS_REQUEST = 0x0041,
    E_SL_MSG_IEEE_ADDRESS_RESPONSE = 0x8041,
    E_SL_MSG_NODE_DESCRIPTOR_REQUEST = 0x0042,
    E_SL_MSG_NODE_DESCRIPTOR_RESPONSE = 0x8042,
    E_SL_MSG_SIMPLE_DESCRIPTOR_REQUEST = 0x0043,
    E_SL_MSG_SIMPLE_DESCRIPTOR_RESPONSE = 0x8043,
    E_SL_MSG_POWER_DESCRIPTOR_REQUEST = 0x0044,
    E_SL_MSG_POWER_DESCRIPTOR_RESPONSE = 0x8044,
    E_SL_MSG_ACTIVE_ENDPOINT_REQUEST = 0x0045,
    E_SL_MSG_ACTIVE_ENDPOINT_RESPONSE = 0x8045,
    E_SL_MSG_MATCH_DESCRIPTOR_REQUEST = 0x0046,
    E_SL_MSG_MATCH_DESCRIPTOR_RESPONSE = 0x8046,
    E_SL_MSG_MANAGEMENT_LEAVE_REQUEST = 0x0047,
    E_SL_MSG_MANAGEMENT_LEAVE_RESPONSE = 0x8047,
    E_SL_MSG_LEAVE_INDICATION = 0x8048,
    E_SL_MSG_PERMIT_JOINING_REQUEST = 0x0049,
    E_SL_MSG_MANAGEMENT_NETWORK_UPDATE_REQUEST = 0x004A,
    E_SL_MSG_MANAGEMENT_NETWORK_UPDATE_RESPONSE = 0x804A,
    E_SL_MSG_SYSTEM_SERVER_DISCOVERY = 0x004B,
    E_SL_MSG_SYSTEM_SERVER_DISCOVERY_RESPONSE = 0x804B,
    E_SL_MSG_DEVICE_ANNOUNCE = 0x004D,
    E_SL_MSG_MANAGEMENT_LQI_REQUEST = 0x004E,
    E_SL_MSG_MANAGEMENT_LQI_RESPONSE = 0x804E,

    /* Group Cluster */
    E_SL_MSG_ADD_GROUP = 0x0060,
    E_SL_MSG_ADD_GROUP_RESPONSE = 0x8060,
    E_SL_MSG_VIEW_GROUP = 0x0061,
    E_SL_MSG_VIEW_GROUP_RESPONSE = 0x8061,
    E_SL_MSG_GET_GROUP_MEMBERSHIP = 0x0062,
    E_SL_MSG_GET_GROUP_MEMBERSHIP_RESPONSE = 0x8062,
    E_SL_MSG_REMOVE_GROUP = 0x0063,
    E_SL_MSG_REMOVE_GROUP_RESPONSE = 0x8063,
    E_SL_MSG_REMOVE_ALL_GROUPS = 0x0064,
    E_SL_MSG_ADD_GROUP_IF_IDENTIFY = 0x0065,

    /* Identify Cluster */
    E_SL_MSG_IDENTIFY_SEND = 0x0070,
    E_SL_MSG_IDENTIFY_QUERY = 0x0071,

    /* Level Cluster */
    E_SL_MSG_MOVE_TO_LEVEL = 0x0080,
    E_SL_MSG_MOVE_TO_LEVEL_ONOFF = 0x0081,
    E_SL_MSG_MOVE_STEP = 0x0082,
    E_SL_MSG_MOVE_STOP_MOVE = 0x0083,
    E_SL_MSG_MOVE_STOP_ONOFF = 0x0084,

    /* Scenes Cluster */
    E_SL_MSG_VIEW_SCENE = 0x00A0,
    E_SL_MSG_VIEW_SCENE_RESPONSE = 0x80A0,
    E_SL_MSG_ADD_SCENE = 0x00A1,
    E_SL_MSG_ADD_SCENE_RESPONSE = 0x80A1,
    E_SL_MSG_REMOVE_SCENE = 0x00A2,
    E_SL_MSG_REMOVE_SCENE_RESPONSE = 0x80A2,
    E_SL_MSG_REMOVE_ALL_SCENES = 0x00A3,
    E_SL_MSG_REMOVE_ALL_SCENES_RESPONSE = 0x80A3,
    E_SL_MSG_STORE_SCENE = 0x00A4,
    E_SL_MSG_STORE_SCENE_RESPONSE = 0x80A4,
    E_SL_MSG_RECALL_SCENE = 0x00A5,
    E_SL_MSG_SCENE_MEMBERSHIP_REQUEST = 0x00A6,
    E_SL_MSG_SCENE_MEMBERSHIP_RESPONSE = 0x80A6,

    /* Colour Cluster */
    E_SL_MSG_MOVE_TO_HUE = 0x00B0,
    E_SL_MSG_MOVE_HUE = 0x00B1,
    E_SL_MSG_STEP_HUE = 0x00B2,
    E_SL_MSG_MOVE_TO_SATURATION = 0x00B3,
    E_SL_MSG_MOVE_SATURATION = 0x00B4,
    E_SL_MSG_STEP_SATURATION = 0x00B5,
    E_SL_MSG_MOVE_TO_HUE_SATURATION = 0x00B6,
    E_SL_MSG_MOVE_TO_COLOUR = 0x00B7,
    E_SL_MSG_MOVE_COLOUR = 0x00B8,
    E_SL_MSG_STEP_COLOUR = 0x00B9,

//# ifdef APP_COMMISSIONING_ENABLED
//    /* ZLL Commands */
//    /* Touchlink */
//    E_SL_MSG_INITIATE_TOUCHLINK = 0x00D0,
//    E_SL_MSG_TOUCHLINK_STATUS = 0x00D1,
//    E_SL_MSG_TOUCHLINK_FACTORY_RESET = 0x00D2,
//#endif
    /* Identify Cluster */
    E_SL_MSG_IDENTIFY_TRIGGER_EFFECT = 0x00E0,

    /* On/Off Cluster */
    E_SL_MSG_ONOFF_NOEFFECTS = 0x0092,
    E_SL_MSG_ONOFF_TIMED = 0x0093,
    E_SL_MSG_ONOFF_EFFECTS = 0x0094,
    E_SL_MSG_ONOFF_UPDATE = 0x8095,

    /* Scenes Cluster */
    E_SL_MSG_ADD_ENHANCED_SCENE = 0x00A7,
    E_SL_MSG_VIEW_ENHANCED_SCENE = 0x00A8,
    E_SL_MSG_COPY_SCENE = 0x00A9,

    /* Colour Cluster */
    E_SL_MSG_ENHANCED_MOVE_TO_HUE = 0x00BA,
    E_SL_MSG_ENHANCED_MOVE_HUE = 0x00BB,
    E_SL_MSG_ENHANCED_STEP_HUE = 0x00BC,
    E_SL_MSG_ENHANCED_MOVE_TO_HUE_SATURATION = 0x00BD,
    E_SL_MSG_COLOUR_LOOP_SET = 0x00BE,
    E_SL_MSG_STOP_MOVE_STEP = 0x00BF,
    E_SL_MSG_MOVE_TO_COLOUR_TEMPERATURE = 0x00C0,
    E_SL_MSG_MOVE_COLOUR_TEMPERATURE = 0x00C1,
    E_SL_MSG_STEP_COLOUR_TEMPERATURE = 0x00C2,


    /* Door Lock Cluster */
    E_SL_MSG_LOCK_UNLOCK_DOOR = 0x00F0,

    /* ZHA Commands */
    E_SL_MSG_READ_ATTRIBUTE_REQUEST = 0x0100,
    E_SL_MSG_READ_ATTRIBUTE_RESPONSE = 0x8100,
    E_SL_MSG_DEFAULT_RESPONSE = 0x8101,
    E_SL_MSG_REPORT_IND_ATTR_RESPONSE = 0x8102,
    E_SL_MSG_WRITE_ATTRIBUTE_REQUEST = 0x0110,
    E_SL_MSG_WRITE_ATTRIBUTE_RESPONSE = 0x8110,
    E_SL_MSG_CONFIG_REPORTING_REQUEST = 0x0120,
    E_SL_MSG_CONFIG_REPORTING_RESPONSE = 0x8120,
    E_SL_MSG_REPORT_ATTRIBUTES = 0x8121,
    E_SL_MSG_ATTRIBUTE_DISCOVERY_REQUEST = 0x0140,
    E_SL_MSG_ATTRIBUTE_DISCOVERY_RESPONSE = 0x8140,

    E_SL_MSG_SAVE_PDM_RECORD = 0x0200,
    E_SL_MSG_SAVE_PDM_RECORD_RESPONSE = 0x8200,
    E_SL_MSG_LOAD_PDM_RECORD_REQUEST = 0x0201,
    E_SL_MSG_LOAD_PDM_RECORD_RESPONSE = 0x8201,
    E_SL_MSG_DELETE_PDM_RECORD = 0x0202,

    E_SL_MSG_PDM_HOST_AVAILABLE = 0x0300,
    E_SL_MSG_ASC_LOG_MSG = 0x0301,
    E_SL_MSG_PDM_HOST_AVAILABLE_RESPONSE = 0x8300,



    /* IAS Cluster */
    E_SL_MSG_SEND_IAS_ZONE_ENROLL_RSP = 0x0400,
    E_SL_MSG_IAS_ZONE_STATUS_CHANGE_NOTIFY = 0x8401,


    /* OTA Cluster //暂未实现*/
    E_SL_MSG_LOAD_NEW_IMAGE = 0x0500,
    E_SL_MSG_BLOCK_REQUEST = 0x8501,
    E_SL_MSG_BLOCK_SEND = 0x0502,
    E_SL_MSG_UPGRADE_END_REQUEST = 0x8503,
    E_SL_MSG_UPGRADE_END_RESPONSE = 0x0504,
    E_SL_MSG_IMAGE_NOTIFY = 0x0505,

    /*Network Recovery               暂未实现*/
    E_SL_MSG_NWK_RECOVERY_EXTRACT_REQ = 0x0600,
    E_SL_MSG_NWK_RECOVERY_EXTRACT_RSP = 0x8600,
    E_SL_MSG_NWK_RECOVERY_RESTORE_REQ = 0x0601,
    E_SL_MSG_NWK_RECOVERY_RESTORE_RSP = 0x8601,

    E_SL_MSG_ROUTE_DISCOVERY_CONFIRM = 0x8701,
    E_SL_MSG_APS_DATA_CONFIRM_FAILED = 0x8702,


    /* Persistant data manager messages   暂未实现*/
    E_SL_MSG_PDM_AVAILABLE_REQUEST = 0x0300,
    E_SL_MSG_PDM_AVAILABLE_RESPONSE = 0x8300,
    E_SL_MSG_PDM_SAVE_RECORD_REQUEST = 0x0200,
    E_SL_MSG_PDM_SAVE_RECORD_RESPONSE = 0x8200,
    E_SL_MSG_PDM_LOAD_RECORD_REQUEST = 0x0201,
    E_SL_MSG_PDM_LOAD_RECORD_RESPONSE = 0x8201,
    E_SL_MSG_PDM_DELETE_ALL_RECORDS_REQUEST = 0x0202,
    E_SL_MSG_PDM_DELETE_ALL_RECORDS_RESPONSE = 0x8202,

}
teSL_MsgType;

#endif

namespace ZGWUI
{
    public partial class Form1 : Form
    {
		NetworkRecovery nwkRecovery = new NetworkRecovery();
        ListManager listManager;

        byte[] au8OTAFile = new byte[262144]; // 256k max file size
        byte u8OtaInProgress = 0;               //OTA 正在进行
        byte u8OTAWaitForDataParamsPending = 0;         // OTA等待数据参数阻塞
        UInt16 u16OTAWaitForDataParamsTargetAddr;       //等待数据参数 目标地址
        byte u8OTAWaitForDataParamsSrcEndPoint;         //等待数据参数 endpoint
        UInt32 u32OTAWaitForDataParamsCurrentTime;      //等待数据参数    当前时间
        UInt32 u32OTAWaitForDataParamsRequestTime;      //等待数据参数    请求时间
        UInt16 u16OTAWaitForDataParamsBlockDelay;       //等待数据参数    block Deay
        UInt32 u32OtaFileIdentifier;                    // OTA 文件标识符
        UInt16 u16OtaFileHeaderVersion;                 //OTA 文件 header 版本
        UInt16 u16OtaFileHeaderLength;                  //OTA 文件 header 长度
        UInt16 u16OtaFileHeaderControlField;            //OTA 文件控制域
        UInt16 u16OtaFileManufacturerCode;              //
        UInt16 u16OtaFileImageType;
        UInt32 u32OtaFileVersion;
        UInt16 u16OtaFileStackVersion;
        UInt32 u32OtaFileTotalImage;
        byte u8OtaFileSecurityCredVersion;
        UInt64 u64OtaFileUpgradeFileDest;
        UInt16 u16OtaFileMinimumHwVersion;
        UInt16 u16OtaFileMaxHwVersion;
        //UInt32 u32CurrentOffset = 0;
        public Form1()
        {
            InitializeComponent();
            GUIinitialize();

            listManager = new ListManager();
        }

        #region GUI intialization functions

        private void GUIinitialize()
        {
            comboBoxSetKeyState.Items.Add("NO NETWORK KEY");
            comboBoxSetKeyState.Items.Add("PRECONFIGURED NETWORK KEY");
            comboBoxSetKeyState.Items.Add("DEFAULT NETWORK KEY");
            comboBoxSetKeyState.Items.Add("PRECONFIGURED LINK KEY");
            comboBoxSetKeyState.Items.Add("ZLL LINK KEY");
            comboBoxSetKeyState.SelectedIndex = 3;

            comboBoxSetKeyType.Items.Add("UNIQUE LINK KEY");
            comboBoxSetKeyType.Items.Add("GLOBAL LINK KEY");
            comboBoxSetKeyType.SelectedIndex = 1;

            comboBoxSetType.Items.Add("COORDINATOR");
            comboBoxSetType.Items.Add("ROUTER");
            comboBoxSetType.SelectedIndex = 0;

            comboBoxPermitJoinTCsignificance.Items.Add("NO CHANGE");
            comboBoxPermitJoinTCsignificance.Items.Add("POLICY AS SPEC");
            comboBoxPermitJoinTCsignificance.SelectedIndex = 0;

            comboBoxSecurityKey.Items.Add("5A6967426565416C6C69616E63653039");
            comboBoxSecurityKey.Items.Add("D0D1D2D3D4D5D6D7D8D9DADBDCDDDEDF");
            comboBoxSecurityKey.SelectedIndex = 0;

            textBoxSetEPID.ForeColor = System.Drawing.Color.Gray;
            textBoxSetEPID.Text = "Extended PAN ID (64-bit Hex)";
            textBoxSetEPID.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxSetCMSK.ForeColor = System.Drawing.Color.Gray;
            textBoxSetCMSK.Text = "Single Channel or Mask (32-bit Hex)";
            textBoxSetCMSK.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxPermitJoinInterval.ForeColor = System.Drawing.Color.Gray;
            textBoxPermitJoinInterval.Text = "Interval (8-bit Hex)";
            textBoxPermitJoinInterval.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxSetSecurityKeySeqNbr.ForeColor = System.Drawing.Color.Gray;
            textBoxSetSecurityKeySeqNbr.Text = "SQN";
            textBoxSetSecurityKeySeqNbr.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxMatchReqNbrInputClusters.ForeColor = System.Drawing.Color.Gray;
            textBoxMatchReqNbrInputClusters.Text = "Inputs (8-bit Hex)";
            textBoxMatchReqNbrInputClusters.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxMatchReqNbrOutputClusters.ForeColor = System.Drawing.Color.Gray;
            textBoxMatchReqNbrOutputClusters.Text = "Outputs (8-bit Hex)";
            textBoxMatchReqNbrOutputClusters.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxMatchReqInputClusters.ForeColor = System.Drawing.Color.Gray;
            textBoxMatchReqInputClusters.Text = "Clusters (16-bit Hex)";
            textBoxMatchReqInputClusters.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxMatchReqOutputClusters.ForeColor = System.Drawing.Color.Gray;
            textBoxMatchReqOutputClusters.Text = "Clusters (16-bit Hex)";
            textBoxMatchReqOutputClusters.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxUserSetReqDescription.ForeColor = System.Drawing.Color.Gray;
            textBoxUserSetReqDescription.Text = "User Description (String)";
            textBoxUserSetReqDescription.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            addrModeComboBoxInit(ref comboBoxBindAddrMode);
            destShortIeeeAddrTextBoxInit(ref textBoxBindDestAddr);
            dstEndPointTextBoxInit(ref textBoxBindDestEP);

            addrModeComboBoxInit(ref comboBoxUnBindAddrMode);
            destShortIeeeAddrTextBoxInit(ref textBoxUnBindDestAddr);
            dstEndPointTextBoxInit(ref textBoxUnBindDestEP);            

            // Management tab text box initialization
            targetExtendedAddrTextBoxInit(ref textBoxBindTargetExtAddr);
            targetEndPointTextBoxInit(ref textBoxBindTargetEP);
            clusterIdTextBoxInit(ref textBoxBindClusterID);

            targetExtendedAddrTextBoxInit(ref textBoxUnBindTargetExtAddr);
            targetEndPointTextBoxInit(ref textBoxUnBindTargetEP);
            clusterIdTextBoxInit(ref textBoxUnBindClusterID);

            shortAddrTextBoxInit(ref textBoxPermitJoinAddr);
            shortAddrTextBoxInit(ref textBoxNodeDescReq);            
            shortAddrTextBoxInit(ref textBoxSimpleReqAddr);            
            shortAddrTextBoxInit(ref textBoxPowerReqAddr);
            shortAddrTextBoxInit(ref textBoxActiveEpAddr);
            shortAddrTextBoxInit(ref textBoxMatchReqAddr);
            shortAddrTextBoxInit(ref textBoxComplexReqAddr);
            shortAddrTextBoxInit(ref textBoxUserReqAddr);
            shortAddrTextBoxInit(ref textBoxUserSetReqAddr);
            shortAddrTextBoxInit(ref textBoxLqiReqTargetAddr);
            profileIdTextBoxInit(ref textBoxMatchReqProfileID);            
            dstEndPointTextBoxInit(ref textBoxSimpleReqEndPoint);   
            targetShortAddrTextBoxInit(ref textBoxIeeeReqTargetAddr);
            shortAddrTextBoxInit(ref textBoxIeeeReqAddr);
            startIndexTextBoxInit(ref textBoxIeeeReqStartIndex);
            startIndexTextBoxInit(ref textBoxLqiReqStartIndex);
            comboBoxIeeeReqType.Items.Add("SINGLE");
            comboBoxIeeeReqType.Items.Add("EXTENDED");
            comboBoxIeeeReqType.SelectedIndex = 0;
            targetShortAddrTextBoxInit(ref textBoxNwkAddrReqTargetAddr);
            extendedAddrTextBoxInit(ref textBoxNwkAddrReqExtAddr);
            startIndexTextBoxInit(ref textBoxNwkAddrReqStartIndex);
            comboBoxNwkAddrReqType.Items.Add("SINGLE");
            comboBoxNwkAddrReqType.Items.Add("EXTENDED");
            comboBoxNwkAddrReqType.SelectedIndex = 0;

            // Restore Network Recovery
            textBoxRestoreNwkFrameCounter.ForeColor = System.Drawing.Color.Gray;
            textBoxRestoreNwkFrameCounter.Text = "Out Frame Counter (32-bit Hex)";
            textBoxRestoreNwkFrameCounter.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            // Remove Device Request UI
            extendedAddrTextBoxInit(ref textBoxRemoveParentAddr);
            extendedAddrTextBoxInit(ref textBoxRemoveChildAddr);

            // Management Leave Request UI
            extendedAddrTextBoxInit(ref textBoxMgmtLeaveExtAddr);
            targetShortAddrTextBoxInit(ref textBoxMgmtLeaveAddr);
            comboBoxMgmtLeaveReJoin.Items.Add("DO NOT REJOIN");
            comboBoxMgmtLeaveReJoin.Items.Add("REJOIN");
            comboBoxMgmtLeaveReJoin.SelectedIndex = 1;
            comboBoxMgmtLeaveChildren.Items.Add("DO NOT REMOVE CHILDREN");
            comboBoxMgmtLeaveChildren.Items.Add("REMOVE CHILDREN");
            comboBoxMgmtLeaveChildren.SelectedIndex = 1;

            // Leave Request UI
            extendedAddrTextBoxInit(ref textBoxLeaveAddr);
            comboBoxLeaveReJoin.Items.Add("DO NOT REJOIN");
            comboBoxLeaveReJoin.Items.Add("REJOIN");
            comboBoxLeaveReJoin.SelectedIndex = 1;
            comboBoxLeaveChildren.Items.Add("DO NOT REMOVE CHILDREN");
            comboBoxLeaveChildren.Items.Add("REMOVE CHILDREN");
            comboBoxLeaveChildren.SelectedIndex = 1;

            // General tab initialization
            addrModeComboBoxInit(ref comboBoxMgmtNwkUpdateAddrMode);
            targetShortAddrTextBoxInit(ref textBoxMgmtNwkUpdateTargetAddr);
            textBoxMgmtNwkUpdateChannelMask.ForeColor = System.Drawing.Color.Gray;
            textBoxMgmtNwkUpdateChannelMask.Text = "ChanMask (32-bit Hex)";
            textBoxMgmtNwkUpdateChannelMask.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
            scanDurationTextBoxInit(ref textBoxMgmtNwkUpdateScanDuration);
            textBoxMgmtNwkUpdateScanCount.ForeColor = System.Drawing.Color.Gray;
            textBoxMgmtNwkUpdateScanCount.Text = "Count (8-bit Hex)";
            textBoxMgmtNwkUpdateScanCount.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxMgmtNwkUpdateNwkManagerAddr.ForeColor = System.Drawing.Color.Gray;
            textBoxMgmtNwkUpdateNwkManagerAddr.Text = "NwkMan Addr (16-bit Hex)";
            textBoxMgmtNwkUpdateNwkManagerAddr.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
           
            targetShortAddrTextBoxInit(ref textBoxReadAttribTargetAddr);
            srcEndPointTextBoxInit(ref textBoxReadAttribSrcEP);
            dstEndPointTextBoxInit(ref textBoxReadAttribDstEP);
            clusterIdTextBoxInit(ref textBoxReadAttribClusterID);            
            comboBoxReadAttribDirection.Items.Add("TO SERVER");
            comboBoxReadAttribDirection.Items.Add("TO CLIENT");
            comboBoxReadAttribDirection.SelectedIndex = 0;
            attributeIdTextBoxInit(ref textBoxReadAttribID1);            
            attributeCountTextBoxInit(ref textBoxReadAttribCount);
            manufacturerSpecificComboBoxInit(ref comboBoxReadAttribManuSpecific);
            manufacturerIdTextBoxInit(ref textBoxReadAttribManuID);

            targetShortAddrTextBoxInit(ref textBoxWriteAttribTargetAddr);
            srcEndPointTextBoxInit(ref textBoxWriteAttribSrcEP);
            dstEndPointTextBoxInit(ref textBoxWriteAttribDstEP);
            clusterIdTextBoxInit(ref textBoxWriteAttribClusterID);
            comboBoxWriteAttribDirection.Items.Add("TO SERVER");
            comboBoxWriteAttribDirection.Items.Add("TO CLIENT");
            comboBoxWriteAttribDirection.SelectedIndex = 0;
            attributeIdTextBoxInit(ref textBoxWriteAttribID);
            attribDataTextBoxInit(ref textBoxWriteAttribData);
            attribDataTypeTextBoxInit(ref textBoxWriteAttribDataType);
            manufacturerSpecificComboBoxInit(ref comboBoxWriteAttribManuSpecific);
            manufacturerIdTextBoxInit(ref textBoxWriteAttribManuID);
            
            targetShortAddrTextBoxInit(ref textBoxConfigReportTargetAddr);
            addrModeComboBoxZCLInit(ref comboBoxConfigReportAddrMode);
            srcEndPointTextBoxInit(ref textBoxConfigReportSrcEP);
            dstEndPointTextBoxInit(ref textBoxConfigReportDstEP);
            clusterIdTextBoxInit(ref textBoxConfigReportClusterID);
            comboBoxConfigReportDirection.Items.Add("TO SERVER");
            comboBoxConfigReportDirection.Items.Add("TO CLIENT");
            comboBoxConfigReportDirection.SelectedIndex = 0;            
            comboBoxConfigReportAttribDirection.Items.Add("TX SERVER");
            comboBoxConfigReportAttribDirection.Items.Add("Rx CLIENT");
            comboBoxConfigReportAttribDirection.SelectedIndex = 0;                      
            attributeTypeTextBoxInit(ref textBoxConfigReportAttribType);
            attributeIdTextBoxInit(ref textBoxConfigReportAttribID);
            minIntervalTextBoxInit(ref textBoxConfigReportMinInterval);
            maxIntervalTextBoxInit(ref textBoxConfigReportMaxInterval);
            timeOutPeriodTextBoxInit(ref textBoxConfigReportTimeOut);
            reportChangeTextBoxInit(ref textBoxConfigReportChange);

            targetShortAddrTextBoxInit(ref textBoxReadAllAttribAddr);
            srcEndPointTextBoxInit(ref textBoxReadAllAttribSrcEP);
            dstEndPointTextBoxInit(ref textBoxReadAllAttribDstEP);
            clusterIdTextBoxInit(ref textBoxReadAllAttribClusterID);
            comboBoxReadAllAttribDirection.Items.Add("TO SERVER");
            comboBoxReadAllAttribDirection.Items.Add("TO CLIENT");
            comboBoxReadAllAttribDirection.SelectedIndex = 0;

            targetShortAddrTextBoxInit(ref textBoxDiscoverAttributesAddr);
            srcEndPointTextBoxInit(ref textBoxDiscoverAttributesSrcEp);
            dstEndPointTextBoxInit(ref textBoxDiscoverAttributesDstEp);
            clusterIdTextBoxInit(ref textBoxDiscoverAttributesClusterID);
            attributeIdTextBoxInit(ref textBoxDiscoverAttributesStartAttrId);
            

            comboBoxDiscoverAttributesDirection.Items.Add("TO SERVER");
            comboBoxDiscoverAttributesDirection.Items.Add("TO CLIENT");
            comboBoxDiscoverAttributesDirection.SelectedIndex = 0;
            maxIDsTextBoxInit(ref textBoxDiscoverAttributesMaxIDs);
            comboBoxDiscoverAttributesExtended.Items.Add("STANDARD");
            comboBoxDiscoverAttributesExtended.Items.Add("EXTENDED");
            comboBoxDiscoverAttributesExtended.SelectedIndex = 0;

            addrModeComboBoxZCLInit(ref comboBoxDiscoverCommandsAddrMode);
            targetShortAddrTextBoxInit(ref textBoxDiscoverCommandsTargetAddr);
            srcEndPointTextBoxInit(ref textBoxDiscoverCommandsSrcEP);
            dstEndPointTextBoxInit(ref textBoxDiscoverCommandsDstEP);
            clusterIdTextBoxInit(ref textBoxDiscoverCommandsClusterID);

            addrModeComboBoxZCLInit(ref comboBoxRawDataCommandsAddrMode);
            targetShortAddrTextBoxInit(ref textBoxRawDataCommandsTargetAddr);
            srcEndPointTextBoxInit(ref textBoxRawDataCommandsSrcEP);
            dstEndPointTextBoxInit(ref textBoxRawDataCommandsDstEP);
            profileIdTextBoxInit(ref textBoxRawDataCommandsProfileID);
            clusterIdTextBoxInit(ref textBoxRawDataCommandsClusterID);

            textBoxRawDataCommandsSecurityMode.ForeColor = System.Drawing.Color.Gray;
            textBoxRawDataCommandsSecurityMode.Text = "Security Mode (8-bit Hex)";
            textBoxRawDataCommandsSecurityMode.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxRawDataCommandsRadius.ForeColor = System.Drawing.Color.Gray;
            textBoxRawDataCommandsRadius.Text = "Radius (8-bit Hex)";
            textBoxRawDataCommandsRadius.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);

            textBoxRawDataCommandsData.ForeColor = System.Drawing.Color.Gray;
            textBoxRawDataCommandsData.Text = "Raw Data (Format: Byte:Byte:Byte)";
            textBoxRawDataCommandsData.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
            textBoxRawDataCommandsData.TextChanged += new EventHandler(textBoxRawDataCommandsData_TextChanged);

            comboBoxDiscoverCommandsDirection.Items.Add("TO SERVER");
            comboBoxDiscoverCommandsDirection.Items.Add("TO CLIENT");
            comboBoxDiscoverCommandsDirection.SelectedIndex = 0;                                                
            commandIDTextBoxInit(ref textBoxDiscoverCommandsCommandID);
            manufacturerSpecificComboBoxInit(ref comboBoxDiscoverCommandsManuSpecific);
            manufacturerIdTextBoxInit(ref textBoxDiscoverCommandsManuID);
            maxCommandsTextBoxInit(ref textBoxDiscoverCommandsMaxCommands);            
            comboBoxDiscoverCommandsRxGen.Items.Add("RECEIVED");
            comboBoxDiscoverCommandsRxGen.Items.Add("GENERATED");
            comboBoxDiscoverCommandsRxGen.SelectedIndex = 0;

            addrModeComboBoxZCLInit(ref comboBoxReadReportConfigAddrMode);
            targetShortAddrTextBoxInit(ref textBoxReadReportConfigTargetAddr);
            srcEndPointTextBoxInit(ref textBoxReadReportConfigSrcEP);
            dstEndPointTextBoxInit(ref textBoxReadReportConfigDstEP);
            clusterIdTextBoxInit(ref textBoxReadReportConfigClusterID);
            comboBoxReadReportConfigDirection.Items.Add("TO SERVER");
            comboBoxReadReportConfigDirection.Items.Add("TO CLIENT");
            comboBoxReadReportConfigDirection.SelectedIndex = 0;           
            attributeIdTextBoxInit(ref textBoxReadReportConfigAttribID);
            comboBoxReadReportConfigDirIsRx.Items.Add("DIR TX");
            comboBoxReadReportConfigDirIsRx.Items.Add("DIR RX");
            comboBoxReadReportConfigDirIsRx.SelectedIndex = 1;

            comboBoxManyToOneRouteRequestCacheRoute.Items.Add("NO CACHE");
            comboBoxManyToOneRouteRequestCacheRoute.Items.Add("CACHE");
            comboBoxManyToOneRouteRequestCacheRoute.SelectedIndex = 1;
            radiusTextBoxInit(ref textBoxManyToOneRouteRequesRadius);

            // Basic cluster tab initialization
            addrModeComboBoxZCLInit(ref comboBoxBasicResetTargetAddrMode);
            shortAddrTextBoxInit(ref textBoxBasicResetTargetAddr);
            srcEndPointTextBoxInit(ref textBoxBasicResetSrcEP);
            dstEndPointTextBoxInit(ref textBoxBasicResetDstEP);

            // Scenes cluster tab initialization
            addrModeComboBoxZCLInit(ref comboBoxViewSceneAddrMode);
            shortAddrTextBoxInit(ref textBoxViewSceneAddr);
            srcEndPointTextBoxInit(ref textBoxViewSceneSrcEndPoint);
            dstEndPointTextBoxInit(ref textBoxViewSceneDstEndPoint);
            groupIdTextBoxInit(ref textBoxViewSceneGroupId);
            sceneIdTextBoxInit(ref textBoxViewSceneSceneId);

            addrModeComboBoxZCLInit(ref comboBoxAddSceneAddrMode);
            shortAddrTextBoxInit(ref textBoxAddSceneAddr);
            srcEndPointTextBoxInit(ref textBoxAddSceneSrcEndPoint);
            dstEndPointTextBoxInit(ref textBoxAddSceneDstEndPoint);
            groupIdTextBoxInit(ref textBoxAddSceneGroupId);
            sceneIdTextBoxInit(ref textBoxAddSceneSceneId);
            time16bitTextBoxInit(ref textBoxAddSceneTransTime);
            nameStringTextBoxInit(ref textBoxAddSceneName);
            stringLenTextBoxInit(ref textBoxAddSceneNameLen);
            stringMaxLenTextBoxInit(ref textBoxAddSceneMaxNameLen);

            addrModeComboBoxZCLInit(ref comboBoxStoreSceneAddrMode);
            shortAddrTextBoxInit(ref textBoxStoreSceneAddr);
            srcEndPointTextBoxInit(ref textBoxStoreSceneSrcEndPoint);
            dstEndPointTextBoxInit(ref textBoxStoreSceneDstEndPoint);
            groupIdTextBoxInit(ref textBoxStoreSceneGroupId);
            sceneIdTextBoxInit(ref textBoxStoreSceneSceneId);

            addrModeComboBoxZCLInit(ref comboBoxRecallSceneAddrMode);
            shortAddrTextBoxInit(ref textBoxRecallSceneAddr);
            srcEndPointTextBoxInit(ref textBoxRecallSceneSrcEndPoint);
            dstEndPointTextBoxInit(ref textBoxRecallSceneDstEndPoint);
            groupIdTextBoxInit(ref textBoxRecallSceneGroupId);
            sceneIdTextBoxInit(ref textBoxRecallSceneSceneId);

            addrModeComboBoxZCLInit(ref comboBoxGetSceneMembershipAddrMode);
            shortAddrTextBoxInit(ref textBoxGetSceneMembershipAddr);
            srcEndPointTextBoxInit(ref textBoxGetSceneMembershipSrcEndPoint);
            dstEndPointTextBoxInit(ref textBoxGetSceneMembershipDstEndPoint);
            groupIdTextBoxInit(ref textBoxGetSceneMembershipGroupID);

            addrModeComboBoxZCLInit(ref comboBoxRemoveAllScenesAddrMode);
            shortAddrTextBoxInit(ref textBoxRemoveAllScenesAddr);
            srcEndPointTextBoxInit(ref textBoxRemoveAllScenesSrcEndPoint);
            dstEndPointTextBoxInit(ref textBoxRemoveAllScenesDstEndPoint);
            groupIdTextBoxInit(ref textBoxRemoveAllScenesGroupID);

            addrModeComboBoxZCLInit(ref comboBoxRemoveSceneAddrMode);
            shortAddrTextBoxInit(ref textBoxRemoveSceneAddr);
            srcEndPointTextBoxInit(ref textBoxRemoveSceneSrcEndPoint);
            dstEndPointTextBoxInit(ref textBoxRemoveSceneDstEndPoint);
            groupIdTextBoxInit(ref textBoxRemoveSceneGroupID);
            sceneIdTextBoxInit(ref textBoxRemoveSceneSceneID);

            // Group cluster tab initialization
            shortAddrTextBoxInit(ref textBoxAddGroupAddr);
            dstEndPointTextBoxInit(ref textBoxAddGroupDstEp);
            srcEndPointTextBoxInit(ref textBoxAddGroupSrcEp);
            groupIdTextBoxInit(ref textBoxAddGroupGroupAddr);
            shortAddrTextBoxInit(ref textBoxViewGroupAddr);
            dstEndPointTextBoxInit(ref textBoxViewGroupDstEp);
            srcEndPointTextBoxInit(ref textBoxViewGroupSrcEp);
            groupIdTextBoxInit(ref textBoxViewGroupGroupAddr);
            shortAddrTextBoxInit(ref textBoxGetGroupTargetAddr);
            dstEndPointTextBoxInit(ref textBoxGetGroupDstEp);
            srcEndPointTextBoxInit(ref textBoxGetGroupSrcEp);
            groupCountTextBoxInit(ref textBoxGetGroupCount);
            shortAddrTextBoxInit(ref textBoxRemoveGroupTargetAddr);
            srcEndPointTextBoxInit(ref textBoxRemoveGroupSrcEp);
            dstEndPointTextBoxInit(ref textBoxRemoveGroupDstEp);
            groupIdTextBoxInit(ref textBoxRemoveGroupGroupAddr);
            shortAddrTextBoxInit(ref textBoxRemoveAllGroupTargetAddr);
            srcEndPointTextBoxInit(ref textBoxRemoveAllGroupSrcEp);
            dstEndPointTextBoxInit(ref textBoxRemoveAllGroupDstEp);

            shortAddrTextBoxInit(ref textBoxGroupAddIfIndentifyingTargetAddr);
            dstEndPointTextBoxInit(ref textBoxGroupAddIfIdentifyDstEp);
            srcEndPointTextBoxInit(ref textBoxGroupAddIfIdentifySrcEp);
            groupIdTextBoxInit(ref textBoxGroupAddIfIdentifyGroupID);

            // On/off cluster tab initialization
            addrModeComboBoxZCLInit(ref comboBoxOnOffAddrMode);
            shortAddrTextBoxInit(ref textBoxOnOffAddr);
            dstEndPointTextBoxInit(ref textBoxOnOffDstEndPoint);
            srcEndPointTextBoxInit(ref textBoxOnOffSrcEndPoint);
            comboBoxOnOffCommand.Items.Add("Off");
            comboBoxOnOffCommand.Items.Add("On");
            comboBoxOnOffCommand.Items.Add("Toggle");
            comboBoxOnOffCommand.SelectedIndex = 0;

            // Level cluster tab initialization
            addrModeComboBoxZCLInit(ref comboBoxMoveToLevelAddrMode);
            shortAddrTextBoxInit(ref textBoxMoveToLevelAddr);
            srcEndPointTextBoxInit(ref textBoxMoveToLevelSrcEndPoint);
            dstEndPointTextBoxInit(ref textBoxMoveToLevelDstEndPoint);
            withOnOffComboBoxInit(ref comboBoxMoveToLevelOnOff);
            levelTextBoxInit(ref textBoxMoveToLevelLevel);
            time16bitTextBoxInit(ref textBoxMoveToLevelTransTime);

            // Identify cluster initialization
            shortAddrTextBoxInit(ref textBoxSendIdAddr);
            shortAddrTextBoxInit(ref textBoxIdQueryAddr);
            srcEndPointTextBoxInit(ref textBoxSendIdSrcEp);
            srcEndPointTextBoxInit(ref textBoxIdQuerySrcEp);
            dstEndPointTextBoxInit(ref textBoxIdSendDstEp);
            dstEndPointTextBoxInit(ref textBoxIdQueryDstEp);
            time16bitTextBoxInit(ref textBoxIdSendTime);       
            
            // Color cluster initialization
            shortAddrTextBoxInit(ref textBoxMoveToHueAddr);
            srcEndPointTextBoxInit(ref textBoxMoveToHueSrcEp);
            dstEndPointTextBoxInit(ref textBoxMoveToHueDstEp);
            hueTextBoxInit(ref textBoxMoveToHueHue);
            directionTextBoxInit(ref textBoxMoveToHueDir);
            time16bitTextBoxInit(ref textBoxMoveToHueTime);

            shortAddrTextBoxInit(ref textBoxMoveToColorAddr);
            srcEndPointTextBoxInit(ref textBoxMoveToColorSrcEp);
            dstEndPointTextBoxInit(ref textBoxMoveToColorDstEp);
            time16bitTextBoxInit(ref textBoxMoveToColorTime);
            xCoordTextBoxInit(ref textBoxMoveToColorX);
            yCoordTextBoxInit(ref textBoxMoveToColorY);

            shortAddrTextBoxInit(ref textBoxMoveToColorTempAddr);
            srcEndPointTextBoxInit(ref textBoxMoveToColorTempSrcEp);
            dstEndPointTextBoxInit(ref textBoxMoveToColorTempDstEp);
            colorTempTextBoxInit(ref textBoxMoveToColorTempTemp);
            time16bitTextBoxInit(ref textBoxMoveToColorTempRate);

            // Lock cluster initialization
            comboBoxLockUnlock.Items.Add("LOCK");
            comboBoxLockUnlock.Items.Add("UNLOCK");
            comboBoxLockUnlock.SelectedIndex = 0;
            shortAddrTextBoxInit(ref textBoxLockUnlockAddr);
            srcEndPointTextBoxInit(ref textBoxLockUnlockSrcEp);
            dstEndPointTextBoxInit(ref textBoxLockUnlockDstEp);

            // IAS cluster tab initialization
            addrModeComboBoxZCLInit(ref comboBoxEnrollRspAddrMode);
            shortAddrTextBoxInit(ref textBoxEnrollRspAddr);
            dstEndPointTextBoxInit(ref textBoxEnrollRspDstEp);
            srcEndPointTextBoxInit(ref textBoxEnrollRspSrcEp);
            comboBoxEnrollRspCode.Items.Add("SUCCESS");
            comboBoxEnrollRspCode.Items.Add("NOT SUPPORTED");
            comboBoxEnrollRspCode.Items.Add("NO ENROLL PERMIT");
            comboBoxEnrollRspCode.Items.Add("TOO MANY ZONES");
            comboBoxEnrollRspCode.SelectedIndex = 0;
            zoneIdTextBoxInit(ref textBoxEnrollRspZone);

            // ZLL On/Off cluster tab initialization
            shortAddrTextBoxInit(ref textBoxZllOnOffEffectsAddr);
            srcEndPointTextBoxInit(ref textBoxZllOnOffEffectsSrcEp);
            dstEndPointTextBoxInit(ref textBoxZllOnOffEffectsDstEp);             
            gradientTextBoxInit(ref textBoxZllOnOffEffectsGradient);
            comboBoxZllOnOffEffectID.Items.Add("OFF");
            comboBoxZllOnOffEffectID.Items.Add("ON");
            comboBoxZllOnOffEffectID.Items.Add("TOGGLE");
            comboBoxZllOnOffEffectID.SelectedIndex = 0;

            // ZLL color cluster tab initialization
            shortAddrTextBoxInit(ref textBoxZllMoveToHueAddr);
            srcEndPointTextBoxInit(ref textBoxZllMoveToHueSrcEp);
            dstEndPointTextBoxInit(ref textBoxZllMoveToHueDstEp);
            hueTextBoxInit(ref textBoxZllMoveToHueHue);
            directionTextBoxInit(ref textBoxZllMoveToHueDirection);
            time8bitTextBoxInit(ref textBoxZllMoveToHueTransTime);

            // OTA cluster tab initialization
            addrModeComboBoxZCLInit(ref comboBoxOTAImageNotifyAddrMode);
            shortAddrTextBoxInit(ref textBoxOTAImageNotifyTargetAddr);
            srcEndPointTextBoxInit(ref textBoxOTAImageNotifySrcEP);
            dstEndPointTextBoxInit(ref textBoxOTAImageNotifyDstEP);
            comboBoxOTAImageNotifyType.Items.Add("JITTER");
            comboBoxOTAImageNotifyType.Items.Add("MDID JITTER");
            comboBoxOTAImageNotifyType.Items.Add("ITYPE MDID JITTER");
            comboBoxOTAImageNotifyType.Items.Add("ITYPE MDID VER JITTER");
            comboBoxOTAImageNotifyType.SelectedIndex = 0;
            fileVersionTextBoxInit(ref textBoxOTAImageNotifyFileVersion);
            imageTypeTextBoxInit(ref textBoxOTAImageNotifyImageType);
            manufacturerIdTextBoxInit(ref textBoxOTAImageNotifyManuID);
            queryJitterTextBoxInit(ref textBoxOTAImageNotifyJitter);

            shortAddrTextBoxInit(ref textBoxOTASetWaitForDataParamsTargetAddr);
            srcEndPointTextBoxInit(ref textBoxOTASetWaitForDataParamsSrcEP);
            currentTme32bitTextBoxInit(ref textBoxOTASetWaitForDataParamsCurrentTime);
            requestTme32bitTextBoxInit(ref textBoxOTASetWaitForDataParamsRequestTime);
            blockDelay16bitTextBoxInit(ref textBoxOTASetWaitForDataParamsRequestBlockDelay);
            time16bitTextBoxInit(ref textBoxIPNConfigPollPeriod);

            DIOMaskInit(ref textBoxDioSetDirectionOutputPinMask);
            DIOMaskInit(ref textBoxDioSetDirectionInputPinMask);

            DIOMaskInit(ref textBoxDioSetOutputOnPinMask);
            DIOMaskInit(ref textBoxDioSetOutputOffPinMask);

            DIOMaskInit(ref textBoxIPNConfigDioRfActiveOutDioMask);
            DIOMaskInit(ref textBoxIPNConfigDioStatusOutDioMask);
            comboBoxIPNConfigEnable.SelectedIndex = 0;
            comboBoxIPNConfigRegisterCallback.SelectedIndex = 0;
        }

        private void DIOMaskInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "DIO Mask (32-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }


        private void queryJitterTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Query Jitter (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void imageTypeTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Image Type (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void fileVersionTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Version (32-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void scanDurationTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Duration (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void radiusTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Radius (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void stringLenTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Len (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void colorTempTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "TempK (16-bit Dec)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void withOnOffComboBoxInit(ref ComboBox comboBox)
        {
            comboBox.Items.Add("Without OnOff");
            comboBox.Items.Add("With OnOff");
            comboBox.SelectedIndex = 0;
        }

        private void attribDataTypComboBoxInit(ref ComboBox comboBox)
        {            
            comboBox.Items.Add("Bound Addr");
            comboBox.Items.Add("Group Addr");
            comboBox.Items.Add("Short Addr");
            comboBox.Items.Add("IEEE Addr");
            comboBox.SelectedIndex = 0;
        }

        private void manufacturerSpecificComboBoxInit(ref ComboBox comboBox)
        {
            comboBox.Items.Add("STANDARD");
            comboBox.Items.Add("CUSTOM");
            comboBox.SelectedIndex = 0;
        }

        private void attribDataTypeTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Type (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void manufacturerIdTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Manu ID (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void attribDataTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Data";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void reportChangeTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Change (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void timeOutPeriodTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "TimeOut (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void minIntervalTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Min Intv (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void maxIntervalTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Max Intv (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void nameStringTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Name (String)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void stringMaxLenTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Max Len (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void maxIDsTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Max ID's (8-Bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void zoneIdTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Zone ID (8-Bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void addrModeComboBoxInit(ref ComboBox comboBox)
        {
            comboBox.Items.Add("Bound");
            comboBox.Items.Add("Group");
            comboBox.Items.Add("Short");
            comboBox.Items.Add("IEEE");
            comboBox.SelectedIndex = 0;
        }

        private void addrModeComboBoxZCLInit(ref ComboBox comboBox)
        {
            comboBox.Items.Add("Bound");
            comboBox.Items.Add("Group");
            comboBox.Items.Add("Short");
            comboBox.Items.Add("IEEE");
            comboBox.Items.Add("Broadcast");
            comboBox.Items.Add("No Transmit");
            comboBox.Items.Add("Bound No Ack");
            comboBox.Items.Add("Short No Ack");
            comboBox.Items.Add("IEEE No Ack");
            comboBox.SelectedIndex = 0;
        }

        private void startIndexTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Start Idx (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void effectIdTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Effect ID (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void gradientTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Gradient (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void directionTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Dir (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void hueTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Hue (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void xCoordTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "X (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void yCoordTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Y (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void currentTme32bitTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Current Time (32-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void requestTme32bitTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Request Time (32-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void blockDelay16bitTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Block Delay (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }


        private void time8bitTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Time (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void time16bitTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Time (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void levelTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Level (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void profileIdTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Profile (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void clusterIdTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Cluster (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void attributeIdTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Attrib (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void attributeCountTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Attrib Count";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void attributeTypeTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Attrib Type";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void targetShortAddrTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Target (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void commandIDTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Cmd ID (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void maxCommandsTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Max Cmds (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void shortAddrTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Address (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void destShortAddrTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Dst Addr (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void destShortIeeeAddrTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Dst Addr (16-bit or 64-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void extendedAddrTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Address (64-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void AddrTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Address";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void targetExtendedAddrTextBoxInit(ref ComboBox comboBox)
        {
            comboBox.ForeColor = System.Drawing.Color.Gray;
            comboBox.Text = "Target Address (64-bit Hex)";
        }

        private void targetExtendedAddrTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Target Address (64-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void dstEndPointTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Dst EP (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void targetEndPointTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Target EP (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void srcEndPointTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Src EP (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void groupCountTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Group Count";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void sceneIdTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Scene ID (8-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        private void groupIdTextBoxInit(ref TextBox textBox)
        {
            textBox.ForeColor = System.Drawing.Color.Gray;
            textBox.Text = "Group ID (16-bit Hex)";
            textBox.MouseClick += new MouseEventHandler(textBoxClearSetTextBlack_MouseClick);
        }

        #endregion
        
        #region ToolTip

        private void showToolTipWindow(string s)
        {
            Point p = this.PointToClient(Cursor.Position);
            toolTipGeneralTooltip.Show(s, this, p.X - 25, p.Y - 5);
        }

        private void hideToolTipWindow()
        {
            toolTipGeneralTooltip.Hide(this);
        }

        #endregion

        #region menu strip functions

        private bool bPortConfigured = false;

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("The port must be closed before changing the settings");
                return;
            }
            else
            {
                PortSettings settings = new PortSettings();

                if (settings.ShowDialog() == DialogResult.OK)
                {
                    serialPort1.PortName = settings.selectedPort;
                    serialPort1.BaudRate = settings.selectedBaudRate;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity   = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceivedHandler);                    

                    displayPortSettings();

                    bPortConfigured = true;
                }
            }
        }

        private void openPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bPortConfigured == true)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                        openPortToolStripMenuItem.Text = "Open Port";
                    }
                    else
                    {
                        serialPort1.Open();
                        openPortToolStripMenuItem.Text = "Close Port";
                    }
                    displayPortSettings();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error - openPortToolStripMenuItem_Click Exception: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Error - No Port Selected");
            }
        }

        private void displayPortSettings()
        {
            toolStripPortSettings.Text = serialPort1.PortName;
            toolStripPortSettings.Text += " ";
            toolStripPortSettings.Text += serialPort1.BaudRate.ToString();
            toolStripPortSettings.Text += "-";
            toolStripPortSettings.Text += serialPort1.DataBits.ToString();
            toolStripPortSettings.Text += "-";
            toolStripPortSettings.Text += (serialPort1.Parity.ToString())[0];
            toolStripPortSettings.Text += "-";

            if (serialPort1.StopBits.ToString() == "One")
            {
                toolStripPortSettings.Text += "1";
            }
            else
            {
                toolStripPortSettings.Text += "2";
            }

            toolStripPortSettings.Text += " ";

            if (serialPort1.IsOpen)
            {
                toolStripPortSettings.Text += "Open";
            }
            else
            {
                toolStripPortSettings.Text += "Closed";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                String version = System.IO.File.ReadAllText(path + "\\..\\..\\VERSION.txt");

                MessageBox.Show("NXP ZigBee Gateway User Interface - Version " + version);
            }
            catch (FileNotFoundException fnfEx)
            {
                MessageBox.Show("Version File not found\nPlease run ZGWUI in Directory: \n\nJN-AN-1223-ZigBee-IoT-Gateway-Control-Bridge");
            }
        }

        #endregion 

        #region management command button handlers

        private void buttonMgmtLeave_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt64 u64ExtAddr;

            if (bStringToUint16(textBoxMgmtLeaveAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint64(textBoxMgmtLeaveExtAddr.Text, out u64ExtAddr) == true)
                {
                    sendMgmtLeaveRequest(u16ShortAddr, u64ExtAddr, (byte)comboBoxMgmtLeaveReJoin.SelectedIndex, (byte)comboBoxMgmtLeaveChildren.SelectedIndex);
                }
            }            

        }

        private void buttonUnBind_Click(object sender, EventArgs e)
        {            
            UInt64 u64TargetExtAddr;
            UInt16 u16ClusterID;
            UInt64 u64DstAddr;
            byte u8TargetEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint64(textBoxUnBindTargetExtAddr.Text, out u64TargetExtAddr) == true)
            {
                if (bStringToUint8(textBoxUnBindTargetEP.Text, out u8TargetEndPoint) == true)
                {
                    if (bStringToUint16(textBoxUnBindClusterID.Text, out u16ClusterID) == true)
                    {
                        if (bStringToUint64(textBoxUnBindDestAddr.Text, out u64DstAddr) == true)
                        {
                            if (bStringToUint8(textBoxUnBindDestEP.Text, out u8DstEndPoint) == true)
                            {
                                sendUnBindRequest(u64TargetExtAddr, u8TargetEndPoint, u16ClusterID, (byte)comboBoxUnBindAddrMode.SelectedIndex, u64DstAddr, u8DstEndPoint);
                            }
                        }
                    }
                }
            }                     
        }

        private void buttonBind_Click(object sender, EventArgs e)
        {
            UInt64 u64TargetExtAddr;
            UInt16 u16ClusterID;
            UInt64 u64DstAddr;
            byte u8TargetEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint64(textBoxBindTargetExtAddr.Text, out u64TargetExtAddr) == true)
            {
                if (bStringToUint8(textBoxBindTargetEP.Text, out u8TargetEndPoint) == true)
                {
                    if (bStringToUint16(textBoxBindClusterID.Text, out u16ClusterID) == true)
                    {
                        if (bStringToUint64(textBoxBindDestAddr.Text, out u64DstAddr) == true)
                        {
                            if (bStringToUint8(textBoxBindDestEP.Text, out u8DstEndPoint) == true)
                            {
                                sendBindRequest(u64TargetExtAddr, u8TargetEndPoint, u16ClusterID, (byte)comboBoxBindAddrMode.SelectedIndex, u64DstAddr, u8DstEndPoint);
                            }                            
                        }                         
                    }
                }
            }
        }

        private void buttonSetCMSK_Click(object sender, EventArgs e)
        {
            UInt32 u32ChannelMask;

            // First check if user is entering a single channel or a 32-bit mask..
            if (UInt32.TryParse(textBoxSetCMSK.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out u32ChannelMask) == true)
            {
                if (u32ChannelMask >= 11 && u32ChannelMask <= 26)
                {
                    // User is specifying a single channel, we must create the 32-bit mask from this                                        
                    UInt32 u32ChannelMaskTemp = 1;

                    for (int i = 0; i < u32ChannelMask; i++)
                    {
                        u32ChannelMaskTemp <<= 1;
                    }
                    u32ChannelMask = u32ChannelMaskTemp;
               
                    // Set channel mask
                    setChannelMask(u32ChannelMask);
                }
                else
                {
                    // User has entered a channel bit mask
                    if (bStringToUint32(textBoxSetCMSK.Text, out u32ChannelMask) == true)
                    {
                        // Set channel mask
                        setChannelMask(u32ChannelMask);
                    }
                }
            }
        }

        private void buttonMgmtLqiReq_Click_1(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            byte u8StartIndex;

            if (bStringToUint16(textBoxLqiReqTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxLqiReqStartIndex.Text, out u8StartIndex) == true)
                {
                    sendMgmtLqiRequest(u16TargetAddr, u8StartIndex);
                }
            }
        }

        private void buttonNwkAddrReq_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt64 u64ExtAddr;            
            byte u8StartIndex;

            if (bStringToUint16(textBoxNwkAddrReqTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint64(textBoxNwkAddrReqExtAddr.Text, out u64ExtAddr) == true)
                {
                    if (bStringToUint8(textBoxNwkAddrReqStartIndex.Text, out u8StartIndex) == true)
                    {
                        sendNwkAddrRequest(u16TargetAddr, u64ExtAddr, (byte)comboBoxNwkAddrReqType.SelectedIndex, u8StartIndex);
                    }
                }
            }
        }

        private void buttonIeeeAddrReq_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16ShortAddr;            
            byte u8StartIndex;

            if (bStringToUint16(textBoxIeeeReqTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint16(textBoxIeeeReqAddr.Text, out u16ShortAddr) == true)
                {
                    if (bStringToUint8(textBoxIeeeReqStartIndex.Text, out u8StartIndex) == true)
                    {
                        sendIeeeAddrRequest(u16TargetAddr, u16ShortAddr, (byte)comboBoxIeeeReqType.SelectedIndex, u8StartIndex);
                    }
                }
            }
        }

        private void buttonComplexReq_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;

            if (bStringToUint16(textBoxComplexReqAddr.Text, out u16ShortAddr) == true)
            {
                complexDescriptorRequest(u16ShortAddr);
            }            
        }

        private void buttonUserReq_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;

            if (bStringToUint16(textBoxUserReqAddr.Text, out u16ShortAddr) == true)
            {
                userDescriptorRequest(u16ShortAddr);
            }  
        }

        private void buttonUserSetReq_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;

            if (bStringToUint16(textBoxUserSetReqAddr.Text, out u16ShortAddr) == true)
            {
                if (textBoxUserSetReqDescription.Text != "")
                {
                    userDescriptorSetRequest(u16ShortAddr, textBoxUserSetReqDescription.Text);
                }
            }  
        }

        private void buttonMatchReq_Click(object sender, EventArgs e)
        {            
            UInt16 u16ShortAddr;
            UInt16 u16ProfileID;
            byte u8NbrInputClusters;
            byte u8NbrOutputClusters;            
            UInt16[] au16InputClusters = new UInt16[8];
            UInt16[] au16OutputClusters = new UInt16[8];           
            
            if (bStringToUint16(textBoxMatchReqAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint16(textBoxMatchReqProfileID.Text, out u16ProfileID) == true)
                {
                    if (bStringToUint8(textBoxMatchReqNbrInputClusters.Text, out u8NbrInputClusters) == true)
                    {
                        if ((u8NbrInputClusters == 0) ||
                            ((u8NbrInputClusters > 0) &&
                             (bStringToUint16Array(textBoxMatchReqInputClusters.Text, out au16InputClusters) == true)))
                        {
                            if (bStringToUint8(textBoxMatchReqNbrOutputClusters.Text, out u8NbrOutputClusters) == true)
                            {
                                if ((u8NbrOutputClusters == 0) ||
                                    ((u8NbrOutputClusters > 0) &&
                                    (bStringToUint16Array(textBoxMatchReqOutputClusters.Text, out au16OutputClusters) == true)))
                                {
                                    matchDescriptorRequest(u16ShortAddr, u16ProfileID, u8NbrInputClusters, au16InputClusters, u8NbrOutputClusters, au16OutputClusters);
                                }
                            }
                        }                        
                    }
                }                
            }
        }

        private void buttonActiveEpReq_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;

            if (bStringToUint16(textBoxActiveEpAddr.Text, out u16ShortAddr) == true)
            {
                activeEndpointDescriptorRequest(u16ShortAddr);
            }            
        }

        private void buttonSimpleDescReq_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr; 
            byte u8EndPoint;

            if (bStringToUint16(textBoxSimpleReqAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxSimpleReqEndPoint.Text, out u8EndPoint) == true)
                {
                    simpleDescriptorRequest(u16ShortAddr, u8EndPoint);
                }
            }
        }

        private void buttonPowerDescReq_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;

            if (bStringToUint16(textBoxPowerReqAddr.Text, out u16ShortAddr) == true)
            {
                powerDescriptorRequest(u16ShortAddr);
            }
        }

        private void buttonPermitJoin_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8Interval;

            if (bStringToUint16(textBoxPermitJoinAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxPermitJoinInterval.Text, out u8Interval) == true)
                {
                    setPermitJoin((UInt16)u16ShortAddr, u8Interval, (byte)comboBoxPermitJoinTCsignificance.SelectedIndex);
                }
            }
        }
                                        
        private void buttonSetDeviceType_Click(object sender, EventArgs e)
        {
            // Set device type
            setDeviceType((byte)comboBoxSetType.SelectedIndex);
        }

        private void buttonSetEPID_Click(object sender, EventArgs e)
        {
            UInt64 u64ExtendedPanID;

            if (bStringToUint64(textBoxSetEPID.Text, out u64ExtendedPanID) == true)
            {
                // Set channel mask
                setExtendedPanID(u64ExtendedPanID);
            }
        }

        private void buttonGetVersion_Click(object sender, EventArgs e)
        {
            transmitCommand(0x0010, 0, null);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            // Transmit command
            transmitCommand(0x0011, 0, null);
        }

        private void buttonErasePD_Click(object sender, EventArgs e)
        {
            // Transmit command
            transmitCommand(0x0012, 0, null);
        }

        private void buttonStartNWK_Click(object sender, EventArgs e)
        {
            // Transmit command
            transmitCommand(0x0024, 0, null);
        }

        private void buttonStartScan_Click(object sender, EventArgs e)
        {
            transmitCommand(0x0025, 0, null);
        }

        private void buttonSetSecurity_Click(object sender, EventArgs e)
        {
            byte u8SeqNbr;
            byte[] au8keyData;

            if (bStringToUint8(textBoxSetSecurityKeySeqNbr.Text, out u8SeqNbr) == true)
            {
                if (bStringToUint128(comboBoxSecurityKey.Text, out au8keyData) == true)
                {
                    // Set key state information
                    setSecurityKeyState((byte)comboBoxSetKeyState.SelectedIndex, u8SeqNbr, (byte)comboBoxSetKeyType.SelectedIndex, au8keyData);
                }
            }            
        }

        private void buttonNodeDescReq_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;

            if (bStringToUint16(textBoxNodeDescReq.Text, out u16ShortAddr) == true)
            {
                nodeDescriptorRequest(u16ShortAddr);
            }
        }

        #endregion

		

        #region general command button handlers        

        /* Unsupported*/
		private void buttonRecoverNwk_Click(object sender, EventArgs e)
        {            
            transmitCommand(0x0600, 0, null);
        }

        /* Unsuported */
        private void buttonRestoreNwk_Click(object sender, EventArgs e)
        {
            UInt32 u32OutFrameCounter = 0;
            byte[] baBuff = new byte[nwkRecovery.iGetSize()];

            if (textBoxRestoreNwkFrameCounter.TextLength < 10 && textBoxRestoreNwkFrameCounter.TextLength != 0)
            {
                bStringToUint32(textBoxRestoreNwkFrameCounter.Text, out u32OutFrameCounter);
                nwkRecovery.NetworkRecoverySetOutFrameCounter(u32OutFrameCounter);
            }

            nwkRecovery.NetworkRecoveryConstructBuffer(ref baBuff);
            transmitCommand(0x0601, nwkRecovery.iGetSize(), baBuff);
        }
        private void buttonDiscoverCommands_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16ClusterID;
            UInt16 u16ManuID;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8CommandId;
            byte u8MaxCommands;

            if (bStringToUint16(textBoxDiscoverCommandsTargetAddr.Text, out u16TargetAddr) == true)
            {                            
                if (bStringToUint8(textBoxDiscoverCommandsSrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxDiscoverCommandsDstEP.Text, out u8DstEndPoint) == true)
                    {                        
                        if (bStringToUint16(textBoxDiscoverCommandsClusterID.Text, out u16ClusterID) == true)
                        {
                            if (bStringToUint8(textBoxDiscoverCommandsCommandID.Text, out u8CommandId) == true)
                            {
                                if (bStringToUint16(textBoxDiscoverCommandsManuID.Text, out u16ManuID) == true)
                                {                                
                                    if (bStringToUint8(textBoxDiscoverCommandsMaxCommands.Text, out u8MaxCommands) == true)
                                    {
                                        sendDiscoverCommandsRequest((byte)comboBoxDiscoverCommandsAddrMode.SelectedIndex, u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16ClusterID, (byte)comboBoxDiscoverCommandsDirection.SelectedIndex, u8CommandId, (byte)comboBoxDiscoverCommandsManuSpecific.SelectedIndex, u16ManuID, u8MaxCommands, (byte)comboBoxDiscoverCommandsRxGen.SelectedIndex);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonMgmtNwkUpdate_Click(object sender, EventArgs e)
        {
            UInt32 u32ChannelMask;
            UInt16 u16TargetAddr;
            UInt16 u16NwkManangerAddr;
            byte u8ScanDuration;
            byte u8ScanCount;

            if (bStringToUint16(textBoxMgmtNwkUpdateTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint32(textBoxMgmtNwkUpdateChannelMask.Text, out u32ChannelMask) == true)
                {
                    if (bStringToUint8(textBoxMgmtNwkUpdateScanDuration.Text, out u8ScanDuration) == true)
                    {
                        if (bStringToUint8(textBoxMgmtNwkUpdateScanCount.Text, out u8ScanCount) == true)
                        {
                            if (bStringToUint16(textBoxMgmtNwkUpdateNwkManagerAddr.Text, out u16NwkManangerAddr) == true)
                            {
                                sendMgmtNwkUpdateRequest((byte)comboBoxMgmtNwkUpdateAddrMode.SelectedIndex, u16TargetAddr, u32ChannelMask, u8ScanDuration, u8ScanCount, u16NwkManangerAddr);
                            }
                        }
                    }
                }
            }
        }

        private void buttonManyToOneRouteRequest_Click(object sender, EventArgs e)
        {
            byte u8Radius;

            if (bStringToUint8(textBoxManyToOneRouteRequesRadius.Text, out u8Radius) == true)
            {
                sendOneToManyRouteRequest((byte)comboBoxManyToOneRouteRequestCacheRoute.SelectedIndex, u8Radius);
            }
        }

        private void buttonWriteAttrib_Click_1(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16ClusterID;
            UInt16 u16AttribID;
            UInt16 u16ManuID;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8AttribType;
            byte[] au8Data = new byte[64];
            byte u8DataLen = 0;

            if (bStringToUint16(textBoxWriteAttribTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxWriteAttribSrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxWriteAttribDstEP.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxWriteAttribClusterID.Text, out u16ClusterID) == true)
                        {
                            if (bStringToUint16(textBoxWriteAttribID.Text, out u16AttribID) == true)
                            {
                                if (bStringToUint16(textBoxWriteAttribManuID.Text, out u16ManuID) == true)
                                {
                                    if (bStringToUint8(textBoxWriteAttribDataType.Text, out u8AttribType) == true)
                                    {
                                        if (u8AttribType == 0x42)
                                        {
                                            // if the data is a character string get the length make make this is the first byte                                         
                                            au8Data[0] = (byte)System.Text.Encoding.ASCII.GetBytes(textBoxWriteAttribData.Text, 0, textBoxWriteAttribData.TextLength, au8Data, 1);
                                            u8DataLen = au8Data[0];
                                            u8DataLen++;
                                        }
                                        else if (u8AttribType == 0x21)
                                        {
                                            UInt16 u16Data;

                                            /* Data is a uint16 */
                                            if (bStringToUint16(textBoxWriteAttribData.Text, out u16Data) == true)
                                            {
                                                u8DataLen = 2;
                                                au8Data[1] = (byte)u16Data;
                                                au8Data[0] = (byte)(u16Data >> 8);
                                            }
                                        }
                                        else
                                        {
                                            for (int i = 0; i < textBoxWriteAttribData.TextLength; i+=2)
                                            {
                                                byte u8Data = 0;
                                                if (bStringToUint8(textBoxWriteAttribData.Text.Substring(i, 2), out u8Data) == true)
                                                {
                                                    au8Data[i] = u8Data;
                                                }
                                                else
                                                {
                                                    return;
                                                }
                                                u8DataLen++;
                                            }
                                        }
                                        sendWriteAttribRequest(u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16ClusterID, (byte)comboBoxReadAttribDirection.SelectedIndex, (byte)comboBoxWriteAttribManuSpecific.SelectedIndex, u16ManuID, 1, u16AttribID, u8AttribType, au8Data, u8DataLen);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonReadAttrib_Click_1(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16ClusterID;
            UInt16 u16AttribID1;
            UInt16 u16ManuID;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8AttribCount;

            if (bStringToUint16(textBoxReadAttribTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxReadAttribSrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxReadAttribDstEP.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxReadAttribClusterID.Text, out u16ClusterID) == true)
                        {
                            if (bStringToUint8(textBoxReadAttribCount.Text, out u8AttribCount) == true)
                            {
                                if (bStringToUint16(textBoxReadAttribID1.Text, out u16AttribID1) == true)
                                {
                                    if (bStringToUint16(textBoxReadAttribManuID.Text, out u16ManuID) == true)
                                    {
                                        sendReadAttribRequest(u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16ClusterID, (byte)comboBoxReadAttribDirection.SelectedIndex, (byte)comboBoxReadAttribManuSpecific.SelectedIndex, u16ManuID, u8AttribCount, u16AttribID1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonReadReportConfig_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint; 
            UInt16 u16ClusterID;
            UInt16 u16AttribID;

            if (bStringToUint16(textBoxReadReportConfigTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxReadReportConfigSrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxReadReportConfigDstEP.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxReadReportConfigClusterID.Text, out u16ClusterID) == true)
                        {
                            if (bStringToUint16(textBoxReadReportConfigAttribID.Text, out u16AttribID) == true)
                            {
                                sendReadReportConfigRequest((byte)comboBoxReadReportConfigAddrMode.SelectedIndex, u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16ClusterID, (byte)comboBoxReadReportConfigDirection.SelectedIndex, 1, 0, 0, (byte)comboBoxReadReportConfigDirIsRx.SelectedIndex, u16AttribID);
                            }
                        }
                    }
                }
            }
        }

        private void buttonConfigReport_Click_1(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16ClusterID;
            UInt16 u16AttribId;
            UInt16 u16MinInterval;
            UInt16 u16MaxInterval;
            UInt16 u16TimeOut;            
            byte u8SrcEndPoint;
            byte u8DstEndPoint;            
            byte u8Change;
            byte u8AttribType;

            if (bStringToUint16(textBoxConfigReportTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxConfigReportSrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxConfigReportDstEP.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxConfigReportClusterID.Text, out u16ClusterID) == true)
                        {
                            if (bStringToUint8(textBoxConfigReportAttribType.Text, out u8AttribType) == true)
                            {
                                if (bStringToUint16(textBoxConfigReportAttribID.Text, out u16AttribId) == true)
                                {
                                    if (bStringToUint16(textBoxConfigReportMinInterval.Text, out u16MinInterval) == true)
                                    {
                                        if (bStringToUint16(textBoxConfigReportMaxInterval.Text, out u16MaxInterval) == true)
                                        {
                                            if (bStringToUint16(textBoxConfigReportTimeOut.Text, out u16TimeOut) == true)
                                            {
                                                if (bStringToUint8(textBoxConfigReportChange.Text, out u8Change) == true)
                                                {
                                                    sendConfigReportRequest((byte)comboBoxConfigReportAddrMode.SelectedIndex, u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16ClusterID, (byte)comboBoxConfigReportDirection.SelectedIndex, (byte)comboBoxConfigReportAttribDirection.SelectedIndex, u8AttribType, u16AttribId, u16MinInterval, u16MaxInterval, u16TimeOut, u8Change);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonDiscoverAttributes_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16ClusterID;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8AttribsMax;
            byte u8AttribOffset;

            if (bStringToUint16(textBoxDiscoverAttributesAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxDiscoverAttributesSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxDiscoverAttributesDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxDiscoverAttributesClusterID.Text, out u16ClusterID) == true)
                        {
                            if (bStringToUint8(textBoxDiscoverAttributesMaxIDs.Text, out u8AttribsMax) == true)
                            {
                                if (bStringToUint8(textBoxDiscoverAttributesStartAttrId.Text, out u8AttribOffset) == true)
                                {
                                    sendDiscoverAttributesRequest(u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16ClusterID, u8AttribOffset, (byte)comboBoxDiscoverAttributesDirection.SelectedIndex, 0, 0, u8AttribsMax, (byte)comboBoxDiscoverAttributesExtended.SelectedIndex);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonReadAllAttrib_Click(object sender, EventArgs e)
        {
            UInt16 u16DstAddr;
            UInt16 u16ClusterID;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxReadAllAttribAddr.Text, out u16DstAddr) == true)
            {
                if (bStringToUint8(textBoxReadAllAttribSrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxReadAllAttribDstEP.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxReadAllAttribClusterID.Text, out u16ClusterID) == true)
                        {
                            sendReadAllAttribRequest(u16DstAddr, u8SrcEndPoint, u8DstEndPoint, u16ClusterID, (byte)comboBoxReadAttribDirection.SelectedIndex, 0, 0);
                        }
                    }
                }
            }
        }

        private void buttonPermitJoinState_Click(object sender, EventArgs e)
        {
            vSendPermitRejoinStateRequest();
        }

        #endregion

        #region basic cluster command button handlers

        private void buttonBasicReset_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxBasicResetTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxBasicResetSrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxBasicResetDstEP.Text, out u8DstEndPoint) == true)
                    {
                        sendBasicResetFactoryDefaultCommand((byte)comboBoxBasicResetTargetAddrMode.SelectedIndex, u16TargetAddr, u8SrcEndPoint, u8DstEndPoint);
                    }
                }
            }
        }

        #endregion
        
        #region OTA cluster button handlers


        private void buttonOTASetWaitForDataParams_Click(object sender, EventArgs e)
        {
            if (bStringToUint16(textBoxOTASetWaitForDataParamsTargetAddr.Text, out u16OTAWaitForDataParamsTargetAddr) == true)
            {
                if (bStringToUint8(textBoxOTASetWaitForDataParamsSrcEP.Text, out u8OTAWaitForDataParamsSrcEndPoint) == true)
                {
                    if (bStringToUint32(textBoxOTASetWaitForDataParamsCurrentTime.Text, out u32OTAWaitForDataParamsCurrentTime) == true)
                    {
                        if (bStringToUint32(textBoxOTASetWaitForDataParamsRequestTime.Text, out u32OTAWaitForDataParamsRequestTime) == true)
                        {
                            if (bStringToUint16(textBoxOTASetWaitForDataParamsRequestBlockDelay.Text, out u16OTAWaitForDataParamsBlockDelay) == true)
                            {
                                // Set flag indicating that next time we get a block request we should reply with a wait for data message
                                u8OTAWaitForDataParamsPending = 1;
                            }
                        }
                    }
                }
            }
        }

        private void buttonOTAImageNotify_Click(object sender, EventArgs e)
        {
            UInt32 u32FileVersion;
            UInt16 u16TargetAddr;
            UInt16 u16ImageType;
            UInt16 u16ManuCode;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8Jitter;

            if (bStringToUint16(textBoxOTAImageNotifyTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxOTAImageNotifySrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxOTAImageNotifyDstEP.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint32(textBoxOTAImageNotifyFileVersion.Text, out u32FileVersion) == true)
                        {
                            if (bStringToUint16(textBoxOTAImageNotifyImageType.Text, out u16ImageType) == true)
                            {
                                if (bStringToUint16(textBoxOTAImageNotifyManuID.Text, out u16ManuCode) == true)
                                {
                                    if (bStringToUint8(textBoxOTAImageNotifyJitter.Text, out u8Jitter) == true)
                                    {
                                        sendOtaImageNotify((byte)comboBoxOTAImageNotifyAddrMode.SelectedIndex, u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, (byte)comboBoxOTAImageNotifyType.SelectedIndex, u32FileVersion, u16ImageType, u16ManuCode, u8Jitter);
                                    }
                                }
                            }
                        }                    
                    }
                }
            }
        }

        private void buttonOTALoadNewImage_Click(object sender, EventArgs e)
        {
            if (openOtaFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                FileStream otaFileStream = null;

                try
                {
                    otaFileStream = File.OpenRead(openOtaFileDialog.FileName);                    
                    otaFileStream.Read(au8OTAFile, 0, Convert.ToInt32(otaFileStream.Length));

                    byte[] au8OtaFileHeaderString = null;
                    au8OtaFileHeaderString = new byte[32];
                    byte i;

                    //文件的 21~52 共 32 个字节
                    for (i = 0; i < 32; i++)
                    {
                        au8OtaFileHeaderString[i] = au8OTAFile[20 + i];     //Ota文件头 20-51 共32个字节
                    }

                    //文件的前 20 个字节
                    u32OtaFileIdentifier = BitConverter.ToUInt32(au8OTAFile, 0);        //  文件标识符
                    u16OtaFileHeaderVersion = BitConverter.ToUInt16(au8OTAFile, 4);     //  header版本
                    u16OtaFileHeaderLength = BitConverter.ToUInt16(au8OTAFile, 6);      //  header长度
                    u16OtaFileHeaderControlField = BitConverter.ToUInt16(au8OTAFile, 8);//  header控制域
                    u16OtaFileManufacturerCode = BitConverter.ToUInt16(au8OTAFile, 10); //  Manufacture Code
                    u16OtaFileImageType = BitConverter.ToUInt16(au8OTAFile, 12);        //  Image Type
                    u32OtaFileVersion = BitConverter.ToUInt32(au8OTAFile, 14);          //  File Version
                    u16OtaFileStackVersion = BitConverter.ToUInt16(au8OTAFile, 18);     //  Stack Version


                    u32OtaFileTotalImage = BitConverter.ToUInt32(au8OTAFile, 52);       //  Total Image
                    u8OtaFileSecurityCredVersion = au8OTAFile[56];                      //  SecurityCredVersion
                    u64OtaFileUpgradeFileDest = BitConverter.ToUInt64(au8OTAFile, 57);  //  UpgradeFile Dest
                    u16OtaFileMinimumHwVersion = BitConverter.ToUInt16(au8OTAFile, 65); //  MinimumHw Version   最小硬件版本
                    u16OtaFileMaxHwVersion = BitConverter.ToUInt16(au8OTAFile, 67);     //  Max Hw Version  最大硬件版本

                    textBoxOtaFileManuCode.Text = u16OtaFileManufacturerCode.ToString("X4");        //  
                    textBoxOtaFileImageType.Text = u16OtaFileImageType.ToString("X4");
                    textBoxOtaFileVersion.Text = u32OtaFileVersion.ToString("X8");
                    textBoxOtaFileSize.Text = u32OtaFileTotalImage.ToString();

                    //发送 ota new image 消息               文件标识符                  header版本      header长度                    header控制域                制造商码                  Image类型            File版本               Stack版本             headerString            Total Image             SecurityCred版本              UpgradeFileDest            最小硬件版本               最大硬件版本
                    sendOtaLoadNewImage(0x02, 0x0000, u32OtaFileIdentifier, u16OtaFileHeaderVersion, u16OtaFileHeaderLength, u16OtaFileHeaderControlField, u16OtaFileManufacturerCode, u16OtaFileImageType, u32OtaFileVersion, u16OtaFileStackVersion, au8OtaFileHeaderString, u32OtaFileTotalImage, u8OtaFileSecurityCredVersion, u64OtaFileUpgradeFileDest, u16OtaFileMinimumHwVersion, u16OtaFileMaxHwVersion);                                
                }
                finally
                {
                    if (otaFileStream != null)
                    {
                        otaFileStream.Close();
                        otaFileStream.Dispose();
                    }
                }
            }            
        }

        #endregion

        #region group cluster button handlers

        private void buttonGroupAddIfIdentifying_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16GroupAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxGroupAddIfIndentifyingTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxGroupAddIfIdentifySrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxGroupAddIfIdentifyDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxGroupAddIfIdentifyGroupID.Text, out u16GroupAddr) == true)
                        {
                            sendGroupAddIfIdentifying(u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupAddr);
                        }
                    }
                }
            }
        }

        private void buttonGroupRemoveAll_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxRemoveAllGroupTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxRemoveAllGroupSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxRemoveAllGroupDstEp.Text, out u8DstEndPoint) == true)
                    {
                        sendGroupRemoveAll(u16TargetAddr, u8SrcEndPoint, u8DstEndPoint);
                    }
                }
            }
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16GroupAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxRemoveGroupTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxRemoveGroupSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxRemoveGroupDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxRemoveGroupGroupAddr.Text, out u16GroupAddr) == true)
                        {
                            sendGroupRemove(u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupAddr);
                        }
                    }
                }
            }
        }

        private void buttonGetGroup_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8GroupCount;
            UInt16[] au16GroupList = new UInt16[8];

            if (bStringToUint16(textBoxGetGroupTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxGetGroupSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxGetGroupDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint8(textBoxGetGroupCount.Text, out u8GroupCount) == true)
                        {
                            if (listManager.getListCount() >= u8GroupCount)
                            {
                                if (bStringToUint16Array(listManager.getListAsString(), out au16GroupList) == true)
                                {
                                    sendGroupGet(u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u8GroupCount, au16GroupList);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid Parameter");
                            }
                        }
                    }
                }
            }
        }

        private void buttonViewGroup_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxViewGroupAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxViewGroupSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxViewGroupDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxViewGroupGroupAddr.Text, out u16GroupAddr) == true)
                        {
                            sendViewGroup(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupAddr);
                        }
                    }
                }
            }
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxAddGroupAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxAddGroupSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxAddGroupDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxAddGroupGroupAddr.Text, out u16GroupAddr) == true)
                        {
                            sendGroupAdd(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupAddr);
                        }
                    }
                }
            }
        }

        #endregion

        #region on/off cluster button handlers

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;            
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxOnOffAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxOnOffSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {                
                    if (bStringToUint8(textBoxOnOffDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        sendClusterOnOff((byte)comboBoxOnOffAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, (byte)comboBoxOnOffCommand.SelectedIndex);
                        //sendClusterMoveToLevel((byte)comboBoxOnOffAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, 0, 181, 0x000F);
                    }
                }                
            }            
        }

        private void buttonOnOffTimed_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region level cluster button handlers

        private void buttonMoveToLevel_Click_1(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16TransTime;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8Level;

            if (bStringToUint16(textBoxMoveToLevelAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxMoveToLevelSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxMoveToLevelDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint8(textBoxMoveToLevelLevel.Text, out u8Level) == true)
                        {
                            if (bStringToUint16(textBoxMoveToLevelTransTime.Text, out u16TransTime) == true)
                            {
                                sendClusterMoveToLevel((byte)comboBoxMoveToLevelAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, (byte)comboBoxMoveToLevelOnOff.SelectedIndex, u8Level, u16TransTime);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region identify cluster button handlers

        private void buttonIdSend_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;            
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            UInt16 u16Time;

            if (bStringToUint16(textBoxSendIdAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxSendIdSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxIdSendDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxIdSendTime.Text, out u16Time) == true)
                        {
                            sendIdentify(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16Time);                         
                        }
                    }
                }
            }
        }

        private void buttonIdQuery_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxIdQueryAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxIdQuerySrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxIdQueryDstEp.Text, out u8DstEndPoint) == true)
                    {
                        sendIdentifyQuery(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint);
                    }
                }
            }
        }

        #endregion

        #region scene cluster button handlers

        private void buttonRemoveScene_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupId;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8SceneId;

            if (bStringToUint16(textBoxRemoveSceneAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxRemoveSceneSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxRemoveSceneDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxRemoveSceneGroupID.Text, out u16GroupId) == true)
                        {
                            if (bStringToUint8(textBoxRemoveSceneSceneID.Text, out u8SceneId) == true)
                            {
                                sendRemoveScene((byte)comboBoxRemoveSceneAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupId, u8SceneId);
                            }
                        }
                    }
                }
            }
        }

        private void buttonRemoveAllScenes_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupId;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxRemoveAllScenesAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxRemoveAllScenesSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxRemoveAllScenesDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxRemoveAllScenesGroupID.Text, out u16GroupId) == true)
                        {
                            sendRemoveAllScenes((byte)comboBoxRemoveAllScenesAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupId);
                        }
                    }
                }
            }
        }

        private void buttonGetSceneMembership_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupId;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxGetSceneMembershipAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxGetSceneMembershipSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxGetSceneMembershipDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxGetSceneMembershipGroupID.Text, out u16GroupId) == true)
                        {
                            sendGetSceneMembership((byte)comboBoxGetSceneMembershipAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupId);
                        }
                    }
                }
            }
        }

        private void buttonAddScene_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupId;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8SceneId;
            UInt16 u16TransTime;
            byte u8NameLen;
            byte u8NameMaxLen;

            if (bStringToUint16(textBoxAddSceneAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxAddSceneSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxAddSceneDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxAddSceneGroupId.Text, out u16GroupId) == true)
                        {
                            if (bStringToUint8(textBoxAddSceneSceneId.Text, out u8SceneId) == true)
                            {
                                if (bStringToUint16(textBoxAddSceneTransTime.Text, out u16TransTime) == true)
                                {
                                    if (bStringToUint8(textBoxAddSceneNameLen.Text, out u8NameLen) == true)
                                    {
                                        if (bStringToUint8(textBoxAddSceneMaxNameLen.Text, out u8NameMaxLen) == true)
                                        {
                                            sendAddScene((byte)comboBoxAddSceneAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupId, u8SceneId, u16TransTime, textBoxAddSceneName.Text, u8NameLen, u8NameMaxLen);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonViewScene_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupId;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8SceneId;

            if (bStringToUint16(textBoxViewSceneAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxViewSceneSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxViewSceneDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxViewSceneGroupId.Text, out u16GroupId) == true)
                        {
                            if (bStringToUint8(textBoxViewSceneSceneId.Text, out u8SceneId) == true)
                            {
                                sendViewScene((byte)comboBoxViewSceneAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupId, u8SceneId);
                            }
                        }
                    }
                }
            }
        }

        private void buttonStoreScene_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupId;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8SceneId;

            if (bStringToUint16(textBoxStoreSceneAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxStoreSceneSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxStoreSceneDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxStoreSceneGroupId.Text, out u16GroupId) == true)
                        {
                            if (bStringToUint8(textBoxStoreSceneSceneId.Text, out u8SceneId) == true)
                            {
                                sendStoreScene((byte)comboBoxStoreSceneAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupId, u8SceneId);
                            }
                        }
                    }
                }
            }
        }

        private void buttonRecallScene_Click_1(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            UInt16 u16GroupId;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8SceneId;

            if (bStringToUint16(textBoxRecallSceneAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxRecallSceneSrcEndPoint.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxRecallSceneDstEndPoint.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxRecallSceneGroupId.Text, out u16GroupId) == true)
                        {
                            if (bStringToUint8(textBoxRecallSceneSceneId.Text, out u8SceneId) == true)
                            {
                                sendRecallScene((byte)comboBoxRecallSceneAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16GroupId, u8SceneId);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region color cluster button handlers

        private void buttonMoveToColorTemp_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            UInt16 u16ColorTemp;
            UInt16 u16TransTime;

            if (bStringToUint16(textBoxMoveToColorTempAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxMoveToColorTempSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxMoveToColorTempDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16Decimal(textBoxMoveToColorTempTemp.Text, out u16ColorTemp) == true)
                        {
                            u16ColorTemp = (UInt16)((UInt32)1000000 / (UInt32)u16ColorTemp);

                            if (bStringToUint16(textBoxMoveToColorTempRate.Text, out u16TransTime) == true)
                            {
                                sendMoveToColorTemp(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16ColorTemp, u16TransTime);
                            }
                        }
                    }
                }
            }
        }

        private void buttonMoveToColor_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            UInt16 u16X;
            UInt16 u16Y;
            UInt16 u16Time;

            if (bStringToUint16(textBoxMoveToColorAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxMoveToColorSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxMoveToColorDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxMoveToColorX.Text, out u16X) == true)
                        {
                            if (bStringToUint16(textBoxMoveToColorY.Text, out u16Y) == true)
                            {
                                if (bStringToUint16(textBoxMoveToColorTime.Text, out u16Time) == true)
                                {
                                    sendMoveToColor(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u16X, u16Y, u16Time);
                                }
                            }
                        }
                    }
                }
            }            
        }

        private void buttonMoveToHue_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8Hue;
            byte u8Direction;
            UInt16 u16Time;

            if (bStringToUint16(textBoxMoveToHueAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxMoveToHueSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxMoveToHueDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint8(textBoxMoveToHueHue.Text, out u8Hue) == true)
                        {
                            if (bStringToUint8(textBoxMoveToHueDir.Text, out u8Direction) == true)
                            {
                                if (bStringToUint16(textBoxMoveToHueTime.Text, out u16Time) == true)
                                {
                                    sendMoveToHue(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u8Hue, u8Direction, u16Time);
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region lock cluster button handlers

        private void buttonLockUnlock_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;

            if (bStringToUint16(textBoxLockUnlockAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxLockUnlockSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxLockUnlockDstEp.Text, out u8DstEndPoint) == true)
                    {
                        sendLockUnlock(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, (byte)comboBoxLockUnlock.SelectedIndex);                        
                    }
                }
            }
        }

        #endregion

        #region IAS cluster button handlers
  
        private void buttonEnrollResponse_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8ZoneId;

            if (bStringToUint16(textBoxEnrollRspAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxEnrollRspSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxEnrollRspDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint8(textBoxEnrollRspZone.Text, out u8ZoneId) == true)
                        {
                            sendIASEnrollResponse((byte)comboBoxEnrollRspAddrMode.SelectedIndex, u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, (byte)comboBoxEnrollRspCode.SelectedIndex, u8ZoneId);
                        }
                    }
                }
            }            
        }
        #endregion

        #region touchlink command button handlers

        private void buttonZllTouchlinkFactoryReset_Click(object sender, EventArgs e)
        {
            sendTouchlinkFactoryReset();
        }

        private void buttonZllTouchlinkInitiate_Click(object sender, EventArgs e)
        {
            sendTouchlinkInitiate();
        }

        #endregion

        #region ZLL on/off command button handlers

        private void buttonZllOnOffEffects_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            byte u8EffectGrad;

            if (bStringToUint16(textBoxZllOnOffEffectsAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxZllOnOffEffectsSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxZllOnOffEffectsDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint8(textBoxZllOnOffEffectsGradient.Text, out u8EffectGrad) == true)
                        {
                            sendZllClusterOnOff(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, (byte)comboBoxZllOnOffEffectID.SelectedIndex, u8EffectGrad);
                        }
                    }
                }
            }            
        }

        #endregion

        #region ZLL color cluster button handlers

        private void buttonZllMoveToHue_Click(object sender, EventArgs e)
        {
            UInt16 u16ShortAddr;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            UInt32 u32Hue;
            byte u8Direction;
            byte u8Time;

            if (bStringToUint16(textBoxZllMoveToHueAddr.Text, out u16ShortAddr) == true)
            {
                if (bStringToUint8(textBoxZllMoveToHueSrcEp.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxZllMoveToHueDstEp.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint32(textBoxZllMoveToHueHue.Text, out u32Hue) == true)
                        {
                            if (bStringToUint8(textBoxZllMoveToHueDirection.Text, out u8Direction) == true)
                            {
                                if (bStringToUint8(textBoxZllMoveToHueTransTime.Text, out u8Time) == true)
                                {
                                    sendEnhancedMoveToHue(u16ShortAddr, u8SrcEndPoint, u8DstEndPoint, u32Hue, u8Direction, u8Time);
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region general input handling functions

        private bool bStringToUint8(string inputString, out byte u8Data)
        {
            bool bResult = true;

            if (Byte.TryParse(inputString, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out u8Data) == false)
            {
                // Show error message
                MessageBox.Show("Invalid Parameter");
                bResult = false;
            }
            return bResult;
        }

        private bool bStringToUint16(string inputString, out UInt16 u16Data)
        {
            bool bResult = true;
            
            if (UInt16.TryParse(inputString, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out u16Data) == false)
            {
                // Show error message
                MessageBox.Show("Invalid Parameter");
                bResult = false;
            }
            return bResult;
        }

        private bool bStringToUint16Decimal(string inputString, out UInt16 u16Data)
        {
            bool bResult = true;

            if (UInt16.TryParse(inputString, NumberStyles.Integer, CultureInfo.CurrentCulture, out u16Data) == false)
            {
                // Show error message
                MessageBox.Show("Invalid Parameter");
                bResult = false;
            }
            return bResult;
        }

        private bool bStringToUint32(string inputString, out UInt32 u32Data)
        {
            bool bResult = true;

            if (UInt32.TryParse(inputString, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out u32Data) == false)
            {
                // Show error message
                MessageBox.Show("Invalid Parameter");
                bResult = false;
            }
            return bResult;
        }

        private bool bStringToUint64(string inputString, out UInt64 u64Data)
        {
            bool bResult = true;

            if (UInt64.TryParse(inputString, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out u64Data) == false)
            {
                // Show error message
                MessageBox.Show("Invalid Parameter");
                bResult = false;
            }
            return bResult;
        }

        private bool bStringToUint128(string inputString, out byte[] au8Data)
        {
            bool bResult = true;            
            au8Data = new byte[16];
            
            if (inputString.Length == 32)
            {
                for (int i = 0; i < inputString.Length; i += 2)
                {
                    if (bStringToUint8(inputString.Substring(i, 2), out au8Data[i / 2]) == false)
                    {
                        bResult = false;
                        break;
                    }
                }
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }

        private bool bStringToUint16Array(string inputString, out UInt16[] au16Data)
        {
            bool bResult = true;
            au16Data = new UInt16[8];

            if ((inputString.Length % 4) == 0)
            {
                for (int i = 0; i < inputString.Length; i += 4)
                {
                    if (bStringToUint16(inputString.Substring(i, 4), out au16Data[i / 4]) == false)
                    {
                        bResult = false;
                        break;
                    }
                }
            }
            else
            {
                bResult = false;
            }
            return bResult;
        }

        private void textBoxClearSetTextBlack_MouseClick(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            textBox.ForeColor = System.Drawing.Color.Black;
            textBox.Text = "";
        }

        #endregion

        #region command transmit functions

        private void sendBasicResetFactoryDefaultCommand(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            commandData[u8Len++] = u8DstAddrMode; 
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;

            // Transmit command
            transmitCommand(0x0050, u8Len, commandData);
        }

        private void sendMgmtNwkUpdateRequest(byte u8DstAddrMode, UInt16 u16ShortAddr, UInt32 u32ChannelMask, byte u8ScanDuration, byte u8ScanCount, UInt16 u16NwkManangerAddr)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            //commandData[u8Len++] = u8DstAddrMode; // u8DstAddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = (byte)(u32ChannelMask >> 24);
            commandData[u8Len++] = (byte)(u32ChannelMask >> 16);
            commandData[u8Len++] = (byte)(u32ChannelMask >> 8);
            commandData[u8Len++] = (byte)u32ChannelMask;
            commandData[u8Len++] = u8ScanDuration;
            commandData[u8Len++] = u8ScanCount;
            commandData[u8Len++] = (byte)(u16NwkManangerAddr >> 8);
            commandData[u8Len++] = (byte)u16NwkManangerAddr;
         
            // Transmit command
            transmitCommand(0x004A, u8Len, commandData);
        }

        private void sendOneToManyRouteRequest(byte u8CacheRoute, byte u8Radius)
        {
            byte[] commandData = null;
            commandData = new byte[128];
            byte u8Len = 0;

            commandData[u8Len++] = 0; // u8DstAddrMode;
            commandData[u8Len++] = 0; // (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = 0; // (byte)u16ShortAddr;
            commandData[u8Len++] = u8CacheRoute;
            commandData[u8Len++] = u8Radius;

            // Transmit command
            transmitCommand(0x004F, u8Len, commandData);
        }

        private void sendReadReportConfigRequest(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ClusterID, byte u8DirServerClient, byte u8NbrAttribs, byte u8ManuSpecific, UInt16 u16ManuID, byte u8DirIsRx, UInt16 u16AttribId)
        {
            byte[] commandData = null;
            commandData = new byte[128];
            byte u8Len = 0;

            commandData[u8Len++] = u8DstAddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = (byte)(u16ClusterID >> 8);
            commandData[u8Len++] = (byte)u16ClusterID;
            commandData[u8Len++] = u8DirServerClient;
            commandData[u8Len++] = u8NbrAttribs;
            commandData[u8Len++] = u8ManuSpecific;
            commandData[u8Len++] = (byte)(u16ManuID >> 8);
            commandData[u8Len++] = (byte)u16ManuID;
            commandData[u8Len++] = u8DirIsRx;
            commandData[u8Len++] = (byte)(u16AttribId >> 8);
            commandData[u8Len++] = (byte)u16AttribId;
            
            // Transmit command
            transmitCommand(0x0122, u8Len, commandData);
        }
        
        private void sendOtaEndResponse(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8SeqNbr, UInt32 u32UpgradeTime, UInt32 u32CurrentTime, UInt32 u32FileVersion, UInt16 u16ImageType, UInt16 u16ManuCode)
        {
            byte[] commandData = null;
            commandData = new byte[128];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = u8SeqNbr;
            commandData[u8Len++] = (byte)(u32UpgradeTime >> 24);
            commandData[u8Len++] = (byte)(u32UpgradeTime >> 16);
            commandData[u8Len++] = (byte)(u32UpgradeTime >> 8);
            commandData[u8Len++] = (byte)u32UpgradeTime;
            commandData[u8Len++] = (byte)(u32CurrentTime >> 24);
            commandData[u8Len++] = (byte)(u32CurrentTime >> 16);
            commandData[u8Len++] = (byte)(u32CurrentTime >> 8);
            commandData[u8Len++] = (byte)u32CurrentTime;
            commandData[u8Len++] = (byte)(u32FileVersion >> 24);
            commandData[u8Len++] = (byte)(u32FileVersion >> 16);
            commandData[u8Len++] = (byte)(u32FileVersion >> 8);
            commandData[u8Len++] = (byte)u32FileVersion;
            commandData[u8Len++] = (byte)(u16ImageType >> 8);
            commandData[u8Len++] = (byte)u16ImageType;
            commandData[u8Len++] = (byte)(u16ManuCode >> 8);
            commandData[u8Len++] = (byte)u16ManuCode;

            // Transmit command
            transmitCommand(0x0504, u8Len, commandData);
        }

        private void sendOtaBlock(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8SeqNbr, byte u8Status, UInt32 u32FileOffset, UInt32 u32FileVersion, UInt16 u16ImageType, UInt16 u16ManuCode, byte u8DataSize, byte[] au8Data)
        {
            byte[] commandData = null;
            commandData = new byte[128];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = u8SeqNbr;
            commandData[u8Len++] = u8Status;
            commandData[u8Len++] = (byte)(u32FileOffset >> 24);
            commandData[u8Len++] = (byte)(u32FileOffset >> 16);
            commandData[u8Len++] = (byte)(u32FileOffset >> 8);
            commandData[u8Len++] = (byte)u32FileOffset;
            commandData[u8Len++] = (byte)(u32FileVersion >> 24);
            commandData[u8Len++] = (byte)(u32FileVersion >> 16);
            commandData[u8Len++] = (byte)(u32FileVersion >> 8);
            commandData[u8Len++] = (byte)u32FileVersion;
            commandData[u8Len++] = (byte)(u16ImageType >> 8);
            commandData[u8Len++] = (byte)u16ImageType;
            commandData[u8Len++] = (byte)(u16ManuCode >> 8);
            commandData[u8Len++] = (byte)u16ManuCode;
            commandData[u8Len++] = u8DataSize;

            byte i;
            for (i = 0; i < u8DataSize; i++)
            {
                commandData[u8Len++] = au8Data[u32FileOffset + i];
            }

            // Transmit command
            transmitCommand(0x0502, u8Len, commandData);
        }

        private void sendOtaSetWaitForDataParams(byte u8DstAddrMode, UInt16 u16TargetAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8SeqNbr, byte u8Status, UInt32 u32CurrentTime, UInt32 u32RequestTime, UInt16 u16BlockDelay)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;
            commandData[u8Len++] = (byte)(u16TargetAddr >> 8);
            commandData[u8Len++] = (byte)u16TargetAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = u8SeqNbr;
            commandData[u8Len++] = u8Status;
            commandData[u8Len++] = (byte)(u32CurrentTime >> 24);
            commandData[u8Len++] = (byte)(u32CurrentTime >> 16);
            commandData[u8Len++] = (byte)(u32CurrentTime >> 8);
            commandData[u8Len++] = (byte)u32CurrentTime;
            commandData[u8Len++] = (byte)(u32RequestTime >> 24);
            commandData[u8Len++] = (byte)(u32RequestTime >> 16);
            commandData[u8Len++] = (byte)(u32RequestTime >> 8);
            commandData[u8Len++] = (byte)u32RequestTime;
            commandData[u8Len++] = (byte)(u16BlockDelay >> 8);
            commandData[u8Len++] = (byte)u16BlockDelay;

            // Transmit command
            transmitCommand(0x0506, u8Len, commandData);
        }

        private void sendOtaImageNotify(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8NotifyType, UInt32 u32FileVersion, UInt16 u16ImageType, UInt16 u16ManuCode, byte u8Jitter)
        {
            byte[] commandData = null;
            commandData = new byte[16];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = u8NotifyType;
            commandData[u8Len++] = (byte)(u32FileVersion >> 24);
            commandData[u8Len++] = (byte)(u32FileVersion >> 16);
            commandData[u8Len++] = (byte)(u32FileVersion >> 8);
            commandData[u8Len++] = (byte)u32FileVersion;
            commandData[u8Len++] = (byte)(u16ImageType >> 8);
            commandData[u8Len++] = (byte)u16ImageType;
            commandData[u8Len++] = (byte)(u16ManuCode >> 8);
            commandData[u8Len++] = (byte)u16ManuCode;
            commandData[u8Len++] = u8Jitter;
  
            // Transmit command
            transmitCommand(0x0505, u8Len, commandData);
        }

        private void sendOtaLoadNewImage(byte u8DstAddrMode, UInt16 u16ShortAddr, UInt32 u32FileIdentifier, UInt16 u16HeaderVersion, UInt16 u16HeaderLength, UInt16 u16HeaderControlField, UInt16 u16ManufacturerCode, UInt16 u16ImageType, UInt32 u32FileVersion, UInt16 u16StackVersion, byte[] au8HeaderString, UInt32 u32TotalImage, byte u8SecurityCredVersion, UInt64 u64UpgradeFileDest, UInt16 u16MinimumHwVersion, UInt16 u16MaxHwVersion)
        {
            byte[] commandData = null;
            commandData = new byte[72];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = (byte)(u32FileIdentifier >> 24);
            commandData[u8Len++] = (byte)(u32FileIdentifier >> 16);
            commandData[u8Len++] = (byte)(u32FileIdentifier >> 8);
            commandData[u8Len++] = (byte)u32FileIdentifier;
            commandData[u8Len++] = (byte)(u16HeaderVersion >> 8);
            commandData[u8Len++] = (byte)u16HeaderVersion;
            commandData[u8Len++] = (byte)(u16HeaderLength >> 8);
            commandData[u8Len++] = (byte)u16HeaderLength;
            commandData[u8Len++] = (byte)(u16HeaderControlField >> 8);
            commandData[u8Len++] = (byte)u16HeaderControlField;
            commandData[u8Len++] = (byte)(u16ManufacturerCode >> 8);
            commandData[u8Len++] = (byte)u16ManufacturerCode;
            commandData[u8Len++] = (byte)(u16ImageType >> 8);
            commandData[u8Len++] = (byte)u16ImageType;
            commandData[u8Len++] = (byte)(u32FileVersion >> 24);
            commandData[u8Len++] = (byte)(u32FileVersion >> 16);
            commandData[u8Len++] = (byte)(u32FileVersion >> 8);
            commandData[u8Len++] = (byte)u32FileVersion;
            commandData[u8Len++] = (byte)(u16StackVersion >> 8);
            commandData[u8Len++] = (byte)u16StackVersion;

            if (au8HeaderString != null)
            {
                byte i;
                for (i = 0; i < 32; i++)
                {
                    commandData[u8Len++] = au8HeaderString[i];
                }
            }

            commandData[u8Len++] = (byte)(u32TotalImage >> 24);
            commandData[u8Len++] = (byte)(u32TotalImage >> 16);
            commandData[u8Len++] = (byte)(u32TotalImage >> 8);
            commandData[u8Len++] = (byte)u32TotalImage;
            commandData[u8Len++] = u8SecurityCredVersion;
            commandData[u8Len++] = (byte)(u64UpgradeFileDest >> 56);
            commandData[u8Len++] = (byte)(u64UpgradeFileDest >> 48);
            commandData[u8Len++] = (byte)(u64UpgradeFileDest >> 40);
            commandData[u8Len++] = (byte)(u64UpgradeFileDest >> 32);
            commandData[u8Len++] = (byte)(u64UpgradeFileDest >> 24);
            commandData[u8Len++] = (byte)(u64UpgradeFileDest >> 16);
            commandData[u8Len++] = (byte)(u64UpgradeFileDest >> 8);
            commandData[u8Len++] = (byte)u64UpgradeFileDest;
            commandData[u8Len++] = (byte)(u16MinimumHwVersion >> 8);
            commandData[u8Len++] = (byte)u16MinimumHwVersion;
            commandData[u8Len++] = (byte)(u16MaxHwVersion >> 8);
            commandData[u8Len++] = (byte)u16MaxHwVersion;
            
            // Transmit command
            transmitCommand(0x0500, u8Len, commandData);
        }

        private void sendIASEnrollResponse(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8Code, byte u8ZoneId)
        {
            byte[] commandData = null;
            commandData = new byte[7];
            byte u8Len = 7;

            // Build command payload   
            commandData[0] = u8DstAddrMode; 
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = u8Code;
            commandData[6] = u8ZoneId;

            // Transmit command
            transmitCommand(0x0400, u8Len, commandData);
        }

        private void sendMoveToColorTemp(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ColorTemp, UInt16 u16TransTime)
        {
            byte[] commandData = null;
            commandData = new byte[9];
            byte u8Len = 9;

            // Build command payload   
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16ColorTemp >> 8);
            commandData[6] = (byte)u16ColorTemp;
            commandData[7] = (byte)(u16TransTime >> 8);
            commandData[8] = (byte)u16TransTime;

            // Transmit command
            transmitCommand(0x00C0, u8Len, commandData);
        }

        private void sendWriteAttribRequest(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ClusterID, byte u8Direction, byte u8ManuSpecific, UInt16 u16ManuID, byte u8AttribCount, UInt16 u16AttribID, byte u8AttribType, byte[] au8Data, byte u8DataLen)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            int u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = 0x02; // Short address mode
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = (byte)(u16ClusterID >> 8);
            commandData[u8Len++] = (byte)u16ClusterID;
            commandData[u8Len++] = u8Direction;
            commandData[u8Len++] = u8ManuSpecific;
            commandData[u8Len++] = (byte)(u16ManuID >> 8);
            commandData[u8Len++] = (byte)u16ManuID;
            commandData[u8Len++] = u8AttribCount;
            commandData[u8Len++] = (byte)(u16AttribID >> 8);
            commandData[u8Len++] = (byte)u16AttribID;
            commandData[u8Len++] = u8AttribType;

            int i;
            for (i = 0; i < u8DataLen; i++)
            {
                commandData[u8Len] = au8Data[i];
                u8Len++;
            }

            /* Need to re-size the array because if we send more data, 
             * the control bridge will convert it to another write attribute */
            Array.Resize(ref commandData, u8Len); 

            // Transmit command
            transmitCommand(0x0110, u8Len, commandData);
        }

        private void sendRemoveScene(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupId, byte u8SceneId)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = (byte)(u16GroupId >> 8);
            commandData[u8Len++] = (byte)u16GroupId;
            commandData[u8Len++] = u8SceneId;

            // Transmit command
            transmitCommand(0x00A2, u8Len, commandData);
        }

        private void sendRemoveAllScenes(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupId)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;               // 0 
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);   // 1
            commandData[u8Len++] = (byte)u16ShortAddr;          // 2
            commandData[u8Len++] = u8SrcEndPoint;               // 3
            commandData[u8Len++] = u8DstEndPoint;               // 4
            commandData[u8Len++] = (byte)(u16GroupId >> 8);     // 5
            commandData[u8Len++] = (byte)u16GroupId;            // 6

            // Transmit command
            transmitCommand(0x00A3, u8Len, commandData);
        }

        private void sendGetSceneMembership(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupId)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;               // 0 
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);   // 1
            commandData[u8Len++] = (byte)u16ShortAddr;          // 2
            commandData[u8Len++] = u8SrcEndPoint;               // 3
            commandData[u8Len++] = u8DstEndPoint;               // 4
            commandData[u8Len++] = (byte)(u16GroupId >> 8);     // 5
            commandData[u8Len++] = (byte)u16GroupId;            // 6

            // Transmit command
            transmitCommand(0x00A6, u8Len, commandData);
        }

        private void sendAddScene(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupId, byte u8SceneId, UInt16 u16TransTime, String sName, byte u8NameLen, byte u8NameMaxLen)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8DstAddrMode;               // 0 
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);   // 1
            commandData[u8Len++] = (byte)u16ShortAddr;          // 2
            commandData[u8Len++] = u8SrcEndPoint;               // 3
            commandData[u8Len++] = u8DstEndPoint;               // 4
            commandData[u8Len++] = (byte)(u16GroupId >> 8);     // 5
            commandData[u8Len++] = (byte)u16GroupId;            // 6
            commandData[u8Len++] = u8SceneId;                   // 7
            commandData[u8Len++] = (byte)(u16TransTime >> 8);   // 8
            commandData[u8Len++] = (byte)u16TransTime;          // 9
            commandData[u8Len++] = u8NameLen;                   // 10
            commandData[u8Len++] = u8NameMaxLen;                // 11

            //System.Buffer.BlockCopy(sName.ToCharArray(), 0, commandData, u8Len, u8NameLen);
            u8Len += u8NameLen;

            // Transmit command
            transmitCommand(0x00A1, u8Len, commandData);
        }

        private void sendViewScene(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupId, byte u8SceneId)
        {
            byte[] commandData = null;
            commandData = new byte[8];
            byte u8Len = 8;
        
            // Build command payload   
            commandData[0] = u8DstAddrMode; 
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16GroupId >> 8);
            commandData[6] = (byte)u16GroupId;
            commandData[7] = u8SceneId;

            // Transmit command
            transmitCommand(0x00A0, u8Len, commandData);
        }

        private void sendStoreScene(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupId, byte u8SceneId)
        {
            byte[] commandData = null;
            commandData = new byte[8];
            byte u8Len = 8;

            // Build command payload   
            commandData[0] = u8DstAddrMode;
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16GroupId >> 8);
            commandData[6] = (byte)u16GroupId;
            commandData[7] = u8SceneId;

            // Transmit command
            transmitCommand(0x00A4, u8Len, commandData);
        }

        private void sendRecallScene(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupId, byte u8SceneId)
        {
            byte[] commandData = null;
            commandData = new byte[8];
            byte u8Len = 8;

            // Build command payload   
            commandData[0] = u8DstAddrMode;
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16GroupId >> 8);
            commandData[6] = (byte)u16GroupId;
            commandData[7] = u8SceneId;

            // Transmit command
            transmitCommand(0x00A5, u8Len, commandData);
        }

        private void sendUnBindRequest(UInt64 u64TargetExtAddr, byte u8TargetEndPoint, UInt16 u16ClusterID, byte u8DstAddrMode, UInt64 u64DstAddr, byte u8DstEndPoint)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 56);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 48);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 40);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 32);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 24);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 16);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 8);
            commandData[u8Len++] = (byte)u64TargetExtAddr;
            commandData[u8Len++] = u8TargetEndPoint;
            commandData[u8Len++] = (byte)(u16ClusterID >> 8);
            commandData[u8Len++] = (byte)u16ClusterID;
            commandData[u8Len++] = u8DstAddrMode;

            if (u8DstAddrMode == 3)
            {
                commandData[u8Len++] = (byte)(u64DstAddr >> 56);
                commandData[u8Len++] = (byte)(u64DstAddr >> 48);
                commandData[u8Len++] = (byte)(u64DstAddr >> 40);
                commandData[u8Len++] = (byte)(u64DstAddr >> 32);
                commandData[u8Len++] = (byte)(u64DstAddr >> 24);
                commandData[u8Len++] = (byte)(u64DstAddr >> 16);
                commandData[u8Len++] = (byte)(u64DstAddr >> 8);
                commandData[u8Len++] = (byte)u64DstAddr;
                commandData[u8Len++] = u8DstEndPoint;
            }
            else
            {
                commandData[u8Len++] = (byte)(u64DstAddr >> 8);
                commandData[u8Len++] = (byte)u64DstAddr;
                commandData[u8Len++] = u8DstEndPoint;
            }

            // Transmit command
            transmitCommand(0x0031, u8Len, commandData);
        }

        private void sendBindRequest(UInt64 u64TargetExtAddr, byte u8TargetEndPoint, UInt16 u16ClusterID, byte u8DstAddrMode, UInt64 u64DstAddr, byte u8DstEndPoint)
        {
            byte[] commandData = null;
            commandData = new byte[32];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 56);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 48);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 40);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 32);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 24);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 16);
            commandData[u8Len++] = (byte)(u64TargetExtAddr >> 8);
            commandData[u8Len++] = (byte)u64TargetExtAddr;
            commandData[u8Len++] = u8TargetEndPoint;
            commandData[u8Len++] = (byte)(u16ClusterID >> 8);
            commandData[u8Len++] = (byte)u16ClusterID;
            commandData[u8Len++] = u8DstAddrMode;

            if (u8DstAddrMode == 3)
            {
                commandData[u8Len++] = (byte)(u64DstAddr >> 56);
                commandData[u8Len++] = (byte)(u64DstAddr >> 48);
                commandData[u8Len++] = (byte)(u64DstAddr >> 40);
                commandData[u8Len++] = (byte)(u64DstAddr >> 32);
                commandData[u8Len++] = (byte)(u64DstAddr >> 24);
                commandData[u8Len++] = (byte)(u64DstAddr >> 16);
                commandData[u8Len++] = (byte)(u64DstAddr >> 8);
                commandData[u8Len++] = (byte)u64DstAddr;
                commandData[u8Len++] = u8DstEndPoint;
            }
            else
            {
                commandData[u8Len++] = (byte)(u64DstAddr >> 8);
                commandData[u8Len++] = (byte)u64DstAddr;
            }
            
            // Transmit command
            transmitCommand(0x0030, u8Len, commandData);
        }
        
        private void sendConfigReportRequest(byte u8DstAddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ClusterID, byte u8ReportDirection, byte u8AttribDirection, byte u8AttribType, UInt16 u16AttribId, UInt16 u16MinInterval, UInt16 u16MaxInterval, UInt16 u16TimeOut, byte u8Change)        
        {
            byte[] commandData = null;
            commandData = new byte[23];
            byte u8Len = 23;

            // Build command payload   
            commandData[0] = u8DstAddrMode;
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16ClusterID >> 8);
            commandData[6] = (byte)u16ClusterID;
            commandData[7] = u8ReportDirection;
            commandData[8] = 0; // ManuSpecific
            commandData[9] = 0; // ManuID
            commandData[10] = 0; // ManuID
            commandData[11] = 1; // Number of attributes

            commandData[12] = u8AttribDirection;
            commandData[13] = u8AttribType; 
            commandData[14] = (byte)(u16AttribId >> 8); 
            commandData[15] = (byte)u16AttribId; ;
            commandData[16] = (byte)(u16MinInterval >> 8);
            commandData[17] = (byte)u16MinInterval;
            commandData[18] = (byte)(u16MaxInterval >> 8);
            commandData[19] = (byte)u16MaxInterval;
            commandData[20] = (byte)(u16TimeOut >> 8); ;
            commandData[21] = (byte)u16TimeOut;    
            commandData[22] = u8Change;

            // Transmit command
            transmitCommand(0x0120, u8Len, commandData);
        }

        private void sendDiscoverCommandsRequest(byte u8AddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ClusterID, byte u8DirectionIsServerToClient, byte u8CommandId, byte u8ManuSpecific, UInt16 u16ManuID, byte u8MaxCommands, byte u8IsGenerated)
        {
            byte[] commandData = null;
            commandData = new byte[13];
            byte u8Len = 0;

            // Build command payload   
            commandData[u8Len++] = u8AddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = (byte)(u16ClusterID >> 8);
            commandData[u8Len++] = (byte)u16ClusterID;
            commandData[u8Len++] = u8DirectionIsServerToClient;
            commandData[u8Len++] = u8CommandId;
            commandData[u8Len++] = u8ManuSpecific;
            commandData[u8Len++] = (byte)(u16ManuID >> 8);
            commandData[u8Len++] = (byte)u16ManuID;
            commandData[u8Len++] = u8MaxCommands;

            if (u8IsGenerated == 0)
            {
                // Transmit command
                transmitCommand(0x0150, u8Len, commandData);
            }
            else
            {
                // Transmit command
                transmitCommand(0x0160, u8Len, commandData);
            }
        }

        private void sendRawDataCommandsRequest(byte u8AddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ProfileID, UInt16 u16ClusterID, byte u8SecurityMode, byte u8Radius, String stringRawData)
        {
            byte[] commandData = null;
            commandData = new byte[12];
            byte u8Len = 0;
            String stringData = "";

            // Build command payload   
            commandData[u8Len++] = u8AddrMode;
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = u8SrcEndPoint;
            commandData[u8Len++] = u8DstEndPoint;
            commandData[u8Len++] = (byte)(u16ClusterID >> 8);
            commandData[u8Len++] = (byte)u16ClusterID;
            commandData[u8Len++] = (byte)(u16ProfileID >> 8);
            commandData[u8Len++] = (byte)u16ProfileID;
            commandData[u8Len++] = u8SecurityMode;
            commandData[u8Len++] = u8Radius;

            stringData = stringRawData.Replace(" ", "");
            stringData = stringRawData.Replace(":", "");

            commandData[u8Len++] = (byte)(stringData.Length/2);

            for (int i = 0; i < stringData.Length; i += 2)
            {
                Array.Resize(ref commandData, u8Len + 1);
                commandData[u8Len++] = (byte)Convert.ToInt32(stringData.ToCharArray()[i].ToString() + stringData.ToCharArray()[i + 1].ToString(), 16);
            }
            
            // Transmit command
            transmitCommand(0x0530, u8Len, commandData);
            
        }

        private void sendDiscoverAttributesRequest(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ClusterID, UInt16 u16StartAttrib, byte u8Direction, byte u8ManuSpecific, UInt16 u16ManuID, byte u8AttribsMax, byte u8Extended)
        {
            byte[] commandData = null;
            commandData = new byte[14];
            byte u8Len = 14;

            // Build command payload   
            commandData[0]  = 0x02; // Short address mode
            commandData[1]  = (byte)(u16ShortAddr >> 8);
            commandData[2]  = (byte)u16ShortAddr;
            commandData[3]  = u8SrcEndPoint;
            commandData[4]  = u8DstEndPoint;
            commandData[5]  = (byte)(u16ClusterID >> 8);
            commandData[6]  = (byte)u16ClusterID;
            commandData[7]  = (byte)(u16StartAttrib >> 8);
            commandData[8]  = (byte)u16StartAttrib;
            commandData[9]  = u8Direction;
            commandData[10] = u8ManuSpecific;
            commandData[11] = (byte)(u16ManuID >> 8);
            commandData[12] = (byte)u16ManuID;
            commandData[13] = u8AttribsMax;

            // Transmit command
            if (u8Extended == 0)
            {
                transmitCommand(0x0140, u8Len, commandData);
            }
            else
            {
                transmitCommand(0x0141, u8Len, commandData);
            }
        }

        private void sendReadAllAttribRequest(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ClusterID, byte u8Direction, byte u8ManuSpecific, UInt16 u16ManuID)
        {
            byte[] commandData = null;
            commandData = new byte[11];
            byte u8Len = 11;

            // Build command payload   
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16ClusterID >> 8);
            commandData[6] = (byte)u16ClusterID;
            commandData[7] = u8Direction;
            commandData[8] = u8ManuSpecific;
            commandData[9] = (byte)(u16ManuID >> 8);
            commandData[10] = (byte)u16ManuID;

            // Transmit command
            transmitCommand(0x0130, u8Len, commandData);
        }

        private void sendReadAttribRequest(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16ClusterID, byte u8Direction, byte u8ManuSpecific, UInt16 u16ManuID, byte u8AttribCount, UInt16 u16AttribID1)
        {
            byte[] commandData = null;
            commandData = new byte[16];
            byte u8Len = 14;

            // Build command payload   
            commandData[0]  = 0x02; // Short address mode
            commandData[1]  = (byte)(u16ShortAddr >> 8);
            commandData[2]  = (byte)u16ShortAddr;
            commandData[3]  = u8SrcEndPoint;
            commandData[4]  = u8DstEndPoint;
            commandData[5]  = (byte)(u16ClusterID >> 8);
            commandData[6]  = (byte)u16ClusterID;
            commandData[7]  = u8Direction;
            commandData[8]  = u8ManuSpecific;
            commandData[9]  = (byte)(u16ManuID >> 8);
            commandData[10] = (byte)u16ManuID;
            commandData[11] = u8AttribCount;
            commandData[12] = (byte)(u16AttribID1 >> 8);
            commandData[13] = (byte)u16AttribID1;

            // Transmit command
            transmitCommand(0x0100, u8Len, commandData);
        }

        private void sendLockUnlock(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8LockUnlock)
        {            
            byte[] commandData = null;
            commandData = new byte[6];

            // Build command payload   
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = u8LockUnlock;

            // Transmit command
            transmitCommand(0x00F0, 6, commandData);
        }

        private void sendNwkAddrRequest(UInt16 u16TargetAddr, UInt64 u64ExtAddr, byte u8Type, byte u8StartIndex)
        {
            byte[] commandData = null;
            commandData = new byte[12];

            // Build command payload            
            commandData[0] = (byte)(u16TargetAddr >> 8);
            commandData[1] = (byte)u16TargetAddr;
            commandData[2] = (byte)(u64ExtAddr >> 56);
            commandData[3] = (byte)(u64ExtAddr >> 48);
            commandData[4] = (byte)(u64ExtAddr >> 40);
            commandData[5] = (byte)(u64ExtAddr >> 32);
            commandData[6] = (byte)(u64ExtAddr >> 24);
            commandData[7] = (byte)(u64ExtAddr >> 16);
            commandData[8] = (byte)(u64ExtAddr >> 8);
            commandData[9] = (byte)u64ExtAddr;            
            commandData[10] = u8Type;
            commandData[11] = u8StartIndex;

            // Transmit command
            transmitCommand(0x0040, 12, commandData);
        }

        private void sendIeeeAddrRequest(UInt16 u16TargetAddr, UInt16 u16ShortAddr, byte u8Type, byte u8StartIndex)
        {
            byte[] commandData = null;
            commandData = new byte[6];

            // Build command payload            
            commandData[0] = (byte)(u16TargetAddr >> 8);
            commandData[1] = (byte)u16TargetAddr;
            commandData[2] = (byte)(u16ShortAddr >> 8);
            commandData[3] = (byte)u16ShortAddr;
            commandData[4] = u8Type;
            commandData[5] = u8StartIndex;
            
            // Transmit command
            transmitCommand(0x0041, 6, commandData);
        }

        private void sendGroupAdd(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupAddr)
        {
            byte[] commandData = null;
            commandData = new byte[7];

            // Build command payload            
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16GroupAddr >> 8);
            commandData[6] = (byte)u16GroupAddr;

            // Transmit command
            transmitCommand(0x0060, 7, commandData);
        }

        private void sendViewGroup(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupAddr)
        {
            byte[] commandData = null;
            commandData = new byte[7];

            // Build command payload            
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16GroupAddr >> 8);
            commandData[6] = (byte)u16GroupAddr;

            // Transmit command
            transmitCommand(0x0061, 7, commandData);
        }        

        private void sendGroupRemove(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupAddr)
        {
            byte[] commandData = null;
            commandData = new byte[7];

            // Build command payload            
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16GroupAddr >> 8);
            commandData[6] = (byte)u16GroupAddr;
            
            // Transmit command
            transmitCommand(0x0063, 7, commandData);
        }
        
        private void sendGroupRemoveAll(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint)
        {
            byte[] commandData = null;
            commandData = new byte[5];

            // Build command payload            
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            
            // Transmit command
            transmitCommand(0x0064, 5, commandData);
        }

        private void sendGroupGet(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8GroupCount, UInt16[] au16GroupList)
        {
            byte[] commandData = null;
            commandData = new byte[6];
            byte u8Length = 0;

            // Build command payload            
            commandData[u8Length++] = 0x02; // Short address mode
            commandData[u8Length++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Length++] = (byte)u16ShortAddr;
            commandData[u8Length++] = u8SrcEndPoint;
            commandData[u8Length++] = u8DstEndPoint;
            commandData[u8Length++] = u8GroupCount;

            
            for (byte i = 0; i < u8GroupCount; i++)
            {
                Array.Resize(ref commandData, u8Length + 2);
                commandData[u8Length++] = (byte)(au16GroupList[i] >> 8);
                commandData[u8Length++] = (byte)(au16GroupList[i]);
            }

            // Transmit command
            transmitCommand(0x0062, u8Length, commandData);
        }

        private void sendGroupAddIfIdentifying(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16GroupID)
        {
            byte[] commandData = null;
            commandData = new byte[8];

            // Build command payload            
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16GroupID >> 8);
            commandData[6] = (byte)u16GroupID;

            // Transmit command
            transmitCommand(0x0065, 7, commandData);
        }

        private void sendEnhancedMoveToHue(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt32 u32Hue, byte u8Direction, byte u8Time)
        {
            byte[] commandData = null;
            commandData = new byte[10];

            // Build command payload            
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;
            commandData[2] = u8SrcEndPoint;
            commandData[3] = u8DstEndPoint;
            commandData[4] = (byte)(u32Hue >> 24);
            commandData[5] = (byte)(u32Hue >> 16);
            commandData[6] = (byte)(u32Hue >> 8);
            commandData[7] = (byte)u32Hue;
            commandData[8] = u8Direction;
            commandData[9] = u8Time;

            // Transmit command
            transmitCommand(0x00BA, 10, commandData);
        }

        private void sendZllClusterOnOff(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8EffectID, byte u8EffectGradient)
        {
            byte[] commandData = null;
            commandData = new byte[6];

            // Build command payload
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;
            commandData[2] = u8SrcEndPoint;
            commandData[3] = u8DstEndPoint;
            commandData[4] = u8EffectID;
            commandData[5] = u8EffectGradient;

            // Transmit command
            transmitCommand(0x0092, 6, commandData);
        }

        private void sendTouchlinkInitiate()
        {
            // Transmit command
            transmitCommand(0x00D0, 0, null);
        }

        private void sendTouchlinkFactoryReset()
        {
            // Transmit command
            transmitCommand(0x00D2, 0, null);
        }

        private void sendMoveToHue(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8Hue, byte u8Direction, UInt16 u16Time)
        {
            byte[] commandData = null;
            commandData = new byte[9];

            // Build command payload            
            commandData[0] = 0x02; // Address mode - short address
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = u8Hue;
            commandData[6] = u8Direction;
            commandData[7] = (byte)(u16Time >> 8);
            commandData[8] = (byte)u16Time;

            // Transmit command
            transmitCommand(0x00B0, 9, commandData);
        }

        private void sendMoveToColor(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16X, UInt16 u16Y, UInt16 u16Time)
        {
            byte[] commandData = null;
            commandData = new byte[11];

            // Build command payload            
            commandData[0]  = 0x02; // Address mode - short address
            commandData[1]  = (byte)(u16ShortAddr >> 8);
            commandData[2]  = (byte)u16ShortAddr;
            commandData[3]  = u8SrcEndPoint;
            commandData[4]  = u8DstEndPoint;
            commandData[5]  = (byte)(u16X >> 8);
            commandData[6]  = (byte)u16X;
            commandData[7]  = (byte)(u16Y >> 8);
            commandData[8]  = (byte)u16Y;
            commandData[9]  = (byte)(u16Time >> 8);
            commandData[10] = (byte)u16Time;

            // Transmit command
            transmitCommand(0x00B7, 11, commandData);
        }

        private void sendIdentify(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, UInt16 u16Time)
        {
            byte[] commandData = null;
            commandData = new byte[7];

            // Build command payload     
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = (byte)(u16Time >> 8);
            commandData[6] = (byte)u16Time;

            // Transmit command
            transmitCommand(0x0070, 7, commandData);
        }

        private void sendIdentifyQuery(UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint)
        {
            byte[] commandData = null;
            commandData = new byte[5];

            // Build command payload            
            commandData[0] = 0x02; // Short address mode
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;

            // Transmit command
            transmitCommand(0x0071, 5, commandData);
        }

        private void sendMgmtLeaveRequest(UInt16 u16ShortAddr, UInt64 u64ExtAddr, byte u8Rejoin, byte u8DoNotRemoveChildren)
        {
            byte[] commandData = null;
            commandData = new byte[12];

            // Build command payload            
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;
            commandData[2] = (byte)(u64ExtAddr >> 56);
            commandData[3] = (byte)(u64ExtAddr >> 48);
            commandData[4] = (byte)(u64ExtAddr >> 40);
            commandData[5] = (byte)(u64ExtAddr >> 32);
            commandData[6] = (byte)(u64ExtAddr >> 24);
            commandData[7] = (byte)(u64ExtAddr >> 16);
            commandData[8] = (byte)(u64ExtAddr >> 8);
            commandData[9] = (byte)u64ExtAddr;
            commandData[10] = u8Rejoin;
            commandData[11] = u8DoNotRemoveChildren;

            // Transmit command
            transmitCommand(0x0047, 12, commandData);
        }

        private void sendRemoveRequest(UInt64 u64ParentExtAddr, UInt64 u64ChildExtAddr)
        {
            byte[] commandData = null;
            commandData = new byte[16];

            // Build command payload            
            commandData[0] = (byte)(u64ParentExtAddr >> 56);
            commandData[1] = (byte)(u64ParentExtAddr >> 48);
            commandData[2] = (byte)(u64ParentExtAddr >> 40);
            commandData[3] = (byte)(u64ParentExtAddr >> 32);
            commandData[4] = (byte)(u64ParentExtAddr >> 24);
            commandData[5] = (byte)(u64ParentExtAddr >> 16);
            commandData[6] = (byte)(u64ParentExtAddr >> 8);
            commandData[7] = (byte)u64ParentExtAddr;

            commandData[8] = (byte)(u64ChildExtAddr >> 56);
            commandData[9] = (byte)(u64ChildExtAddr >> 48);
            commandData[10] = (byte)(u64ChildExtAddr >> 40);
            commandData[11] = (byte)(u64ChildExtAddr >> 32);
            commandData[12] = (byte)(u64ChildExtAddr >> 24);
            commandData[13] = (byte)(u64ChildExtAddr >> 16);
            commandData[14] = (byte)(u64ChildExtAddr >> 8);
            commandData[15] = (byte)u64ChildExtAddr;

            // Transmit command
            transmitCommand(0x0026, 16, commandData);
        }
        private void sendLeaveRequest(UInt64 u64ExtAddr, byte u8Rejoin, byte u8DoNotRemoveChildren)
        {
            byte[] commandData = null;
            commandData = new byte[10];

            // Build command payload            
            commandData[0] = (byte)(u64ExtAddr >> 56);
            commandData[1] = (byte)(u64ExtAddr >> 48);
            commandData[2] = (byte)(u64ExtAddr >> 40);
            commandData[3] = (byte)(u64ExtAddr >> 32);
            commandData[4] = (byte)(u64ExtAddr >> 24);
            commandData[5] = (byte)(u64ExtAddr >> 16);
            commandData[6] = (byte)(u64ExtAddr >> 8);
            commandData[7] = (byte)u64ExtAddr;

            commandData[8] = u8Rejoin;
            commandData[9] = u8DoNotRemoveChildren;

            // Transmit command
            transmitCommand(0x004C, 10, commandData);
        }

        private void sendClusterMoveToLevel(byte u8AddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8WithOnOff, byte u8Level, UInt16 u16TransTime)
        {
            byte[] commandData = null;
            commandData = new byte[9];

            // Build command payload            
            commandData[0] = u8AddrMode;
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = u8WithOnOff;
            commandData[6] = u8Level;
            commandData[7] = (byte)(u16TransTime >> 8);
            commandData[8] = (byte)u16TransTime;

            // Transmit command
            transmitCommand(0x0081, 9, commandData);
        }

        private void complexDescriptorRequest(UInt16 u16ShortAddr)
        {
            byte[] commandData = null;
            commandData = new byte[2];

            // Build command payload            
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;

            // Transmit command
            transmitCommand(0x0531, 2, commandData);
        }

        private void userDescriptorRequest(UInt16 u16ShortAddr)
        {
            byte[] commandData = null;
            commandData = new byte[2];

            // Build command payload            
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;

            // Transmit command
            transmitCommand(0x0532, 2, commandData);
        }

        private void userDescriptorSetRequest(UInt16 u16ShortAddr, String description)
        {
            byte[] commandData = null;
            char[] au8CharArry;
            byte u8Len = 0;
            commandData = new byte[3];

            au8CharArry = description.ToCharArray();

            // Build command payload            
            commandData[u8Len++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Len++] = (byte)u16ShortAddr;
            commandData[u8Len++] = (byte)(description.Length);

            Array.Resize(ref commandData, (u8Len + description.Length));

            foreach(char u8Byte in au8CharArry)
            {
                commandData[u8Len++] = (byte)u8Byte;
            }
            
            // Transmit command
            transmitCommand(0x0533, u8Len, commandData);
        }        

        private void sendMgmtLqiRequest(UInt16 u16ShortAddr, byte u8StartIndex)
        {
            byte[] commandData = null;
            commandData = new byte[4];

            // Build command payload            
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;
            commandData[2] = u8StartIndex;

            // Transmit command
            transmitCommand(0x004E, 3, commandData);
        }
        
        private void matchDescriptorRequest(UInt16 u16ShortAddr, UInt16 u16ProfileId, byte u8NbrInputClusters, UInt16[] au16InputClusters, byte u8NbrOutputClusters, UInt16[] au16OutputClusters)
        {
            byte[] commandData = null;
            commandData = new byte[128];
            byte u8Length = 0;

            // Build command payload            
            commandData[u8Length++] = (byte)(u16ShortAddr >> 8);
            commandData[u8Length++] = (byte)u16ShortAddr;
            commandData[u8Length++] = (byte)(u16ProfileId >> 8);
            commandData[u8Length++] = (byte)u16ProfileId;
            
            commandData[u8Length++] = u8NbrInputClusters;
            for (int i = 0; i < u8NbrInputClusters; i++)
            {
                commandData[u8Length++] = (byte)(au16InputClusters[i] >> 8);
                commandData[u8Length++] = (byte)au16InputClusters[i];
            }

            commandData[u8Length++] = u8NbrOutputClusters;
            for (int i = 0; i < u8NbrOutputClusters; i++)
            {
                commandData[u8Length++] = (byte)(au16OutputClusters[i] >> 8);
                commandData[u8Length++] = (byte)au16OutputClusters[i];
            }

            // Transmit command
            transmitCommand(0x0046, u8Length, commandData);
        }

        private void activeEndpointDescriptorRequest(UInt16 u16ShortAddr)
        {
            byte[] commandData = null;
            commandData = new byte[2];

            // Build command payload            
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;

            // Transmit command
            transmitCommand(0x0045, 2, commandData);
        }

        private void simpleDescriptorRequest(UInt16 u16ShortAddr, byte u8EndPoint)
        {
            byte[] commandData = null;
            commandData = new byte[3];

            // Build command payload
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;            
            commandData[2] = u8EndPoint;

            // Transmit command
            transmitCommand(0x0043, 3, commandData);
        }

        private void powerDescriptorRequest(UInt16 u16ShortAddr)
        {
            byte[] commandData = null;
            commandData = new byte[2];

            // Build command payload
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;
            
            // Transmit command
            transmitCommand(0x0044, 2, commandData);
        }

        private void nodeDescriptorRequest(UInt16 u16ShortAddr)
        {
            byte[] commandData = null;
            commandData = new byte[2];

            // Build command payload            
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;

            // Transmit command
            transmitCommand(0x0042, 2, commandData);
        }

        private void sendClusterOnOff(byte u8AddrMode, UInt16 u16ShortAddr, byte u8SrcEndPoint, byte u8DstEndPoint, byte u8CommandID)
        {
            byte[] commandData = null;
            commandData = new byte[6];

            // Build command payload
            commandData[0] = u8AddrMode;
            commandData[1] = (byte)(u16ShortAddr >> 8);
            commandData[2] = (byte)u16ShortAddr;            
            commandData[3] = u8SrcEndPoint;
            commandData[4] = u8DstEndPoint;
            commandData[5] = u8CommandID;
            
            // Transmit command
            transmitCommand(0x0092, 6, commandData);
        }

        private void setPermitJoin(UInt16 u16ShortAddr, byte u8Interval, byte u8TCsignificance)
        {
            byte[] commandData = null;
            commandData = new byte[4];

            // Build command payload
            commandData[0] = (byte)(u16ShortAddr >> 8);
            commandData[1] = (byte)u16ShortAddr;            
            commandData[2] = u8Interval;
            commandData[3] = u8TCsignificance;

            // Transmit command
            transmitCommand(0x0049, 4, commandData);
        }

        private void vSendPermitRejoinStateRequest()
        {
            // Transmit command
            transmitCommand(0x0014, 0, null);
        }

        private void setSecurityKeyState(byte keyState, byte keySeqNbr, byte keyType, byte[] keyData)
        {
            byte[] commandData = null;
            commandData = new byte[19];

            // Build command payload
            commandData[0] = keyState;
            commandData[1] = keySeqNbr;
            commandData[2] = keyType;
            for (int i = 0; i < 16; i++)
            {
                commandData[3 + i] = keyData[i];
            }

            // Transmit command
            transmitCommand(0x0022, 19, commandData);
        }

        private void setExtendedPanID(ulong ulExtPanID)
        {
            byte[] commandData = null;
            commandData = new byte[8];

            // Build command payload
            commandData[0] = (byte)(ulExtPanID >> 56);
            commandData[1] = (byte)(ulExtPanID >> 48);
            commandData[2] = (byte)(ulExtPanID >> 40);
            commandData[3] = (byte)(ulExtPanID >> 32);
            commandData[4] = (byte)(ulExtPanID >> 24);
            commandData[5] = (byte)(ulExtPanID >> 16);
            commandData[6] = (byte)(ulExtPanID >> 8);          
            commandData[7] = (byte)ulExtPanID;
            
            // Transmit command
            transmitCommand(0x0020, 8, commandData);
        }

        private void setChannelMask(uint uiMask)
        {
            byte[] commandData = null;
            commandData = new byte[4];

            // Build command payload
            commandData[0] = (byte)(uiMask >> 24);
            commandData[1] = (byte)(uiMask >> 16);
            commandData[2] = (byte)(uiMask >> 8); 
            commandData[3] = (byte)uiMask;
                              
            // Transmit command
            transmitCommand(0x0021, 4, commandData);
        }

        private void setDeviceType(byte deviceType)
        {
            byte[] commandData = null;
            commandData = new byte[1];

            // Build command payload
            commandData[0] = deviceType;

            // Transmit command
            transmitCommand(0x0023, 1, commandData);
        }

        private void sendIPNConfigureCommand(byte bEnabled, UInt32 u32RfActiveOutDioMask, UInt32 u32StatusOutDioMask, UInt32 u32TxConfInDioMask, byte bCallbackEnabled, UInt16 u16PollPeriod, byte u8TimerId)
        {
            byte[] commandData = null;
            commandData = new byte[17];
            byte u8Len = 17;

            // Build command payload   
            commandData[0] = bEnabled; // Short address mode
            commandData[1] = (byte)(u32RfActiveOutDioMask >> 24);
            commandData[2] = (byte)(u32RfActiveOutDioMask >> 16);
            commandData[3] = (byte)(u32RfActiveOutDioMask >> 8);
            commandData[4] = (byte)u32RfActiveOutDioMask;
            commandData[5] = (byte)(u32StatusOutDioMask >> 24);
            commandData[6] = (byte)(u32StatusOutDioMask >> 16);
            commandData[7] = (byte)(u32StatusOutDioMask >> 8);
            commandData[8] = (byte)u32StatusOutDioMask;
            commandData[9] = (byte)(u32TxConfInDioMask >> 24);
            commandData[10] = (byte)(u32TxConfInDioMask >> 16);
            commandData[11] = (byte)(u32TxConfInDioMask >> 8);
            commandData[12] = (byte)u32TxConfInDioMask;
            commandData[13] = bCallbackEnabled;
            commandData[14] = (byte)(u16PollPeriod >> 8);
            commandData[15] = (byte)u16PollPeriod;
            commandData[16] = u8TimerId;

            // Transmit command
            transmitCommand(0x0800, u8Len, commandData);
        }

        private void sendDioSetDirectionOutputCommand(UInt16 cmdId, UInt32 u32InputDIOMask, UInt32 u32OutputDIOMask)
        {
            byte[] commandData = null;
            commandData = new byte[8];
            byte u8Len = 8;

            // Build command payload   
            commandData[0] = (byte)(u32InputDIOMask >> 24);
            commandData[1] = (byte)(u32InputDIOMask >> 16);
            commandData[2] = (byte)(u32InputDIOMask >> 8);
            commandData[3] = (byte)u32InputDIOMask;
            commandData[4] = (byte)(u32OutputDIOMask >> 24);
            commandData[5] = (byte)(u32OutputDIOMask >> 16);
            commandData[6] = (byte)(u32OutputDIOMask >> 8);
            commandData[7] = (byte)u32OutputDIOMask;

            // Transmit command
            transmitCommand(cmdId, u8Len, commandData);
        }

        #endregion

        #region serial transmit functions

        private void transmitCommand(int iCommand, int iLength, byte[] data)
        {
            if (serialPort1.IsOpen)
            {
                int i;
                byte[] specialCharacter = null;
                specialCharacter = new byte[1];
                byte[] message = null;
                message = new byte[256];

                // Build message payload, starting with the type field                
                message[0] = (byte)(iCommand >> 8);
                message[1] = (byte)iCommand;

                // Add message length
                message[2] = (byte)(iLength >> 8);
                message[3] = (byte)iLength;

                // Calculate checksum of header
                byte csum = 0;
                csum ^= message[0];
                csum ^= message[1];
                csum ^= message[2];
                csum ^= message[3];

                // Add message data and update checksum
                if (data != null)
                {
                    for (i = 0; i < iLength; i++)
                    {
                        message[5 + i] = data[i];
                        csum ^= data[i];
                    }
                }

                // Add checksum               
                message[4] = csum;

                // Display data byte in terminal window
                if (iCommand != 0x502)
                {
                    richTextBoxCommandResponse.Text += DateTime.Now.Hour.ToString("D2");
                    richTextBoxCommandResponse.Text += ":";
                    richTextBoxCommandResponse.Text += DateTime.Now.Minute.ToString("D2");
                    richTextBoxCommandResponse.Text += ":";
                    richTextBoxCommandResponse.Text += DateTime.Now.Second.ToString("D2");
                    richTextBoxCommandResponse.Text += ".";
                    richTextBoxCommandResponse.Text += DateTime.Now.Millisecond.ToString("D3");
                    richTextBoxCommandResponse.Text += " -> ";
                }
                
                // Transmit the message, send start character first
                specialCharacter[0] = 1;
                if (iCommand == 0x502)
                {
                    writeByteNoRawDisplay(specialCharacter[0]);                    
                }
                else
                {
                    writeByte(specialCharacter[0]);
                }

                // Transmit message payload with byte stuffing as required                
                for (i = 0; i < iLength + 5; i++)
                {
                    // Check if stuffing is required
                    if (message[i] < 0x10)
                    {
                        // First send escape character then message byte XOR'd with 0x10
                        specialCharacter[0] = 2;
                        if (iCommand == 0x502)
                        {
                            writeByteNoRawDisplay(specialCharacter[0]);
                        }
                        else
                        {
                            writeByte(specialCharacter[0]);
                        }

                        int msg = message[i];
                        msg = msg ^ 0x10;
                        message[i] = (byte)msg;

                        if (iCommand == 0x502)
                        {
                            writeByteNoRawDisplay(message[i]);
                        }
                        else
                        {
                            writeByte(message[i]);
                        }
                    }
                    else
                    {
                        // Send the character with no modification
                        if (iCommand == 0x502)
                        {
                            writeByteNoRawDisplay(message[i]);
                        }
                        else
                        {
                            writeByte(message[i]);
                        }
                    }
                }

                // Send end character
                specialCharacter[0] = 3;
                if (iCommand == 0x502)
                {
                    writeByteNoRawDisplay(specialCharacter[0]);
                }
                else
                {
                    writeByte(specialCharacter[0]);
                }
                richTextBoxCommandResponse.Text += "\n";
            }
        }

        void writeByte(byte data)
        {
            byte[] dataArray = null;
            dataArray = new byte[1];
            dataArray[0] = data;

            // Display data byte in terminal window            
            richTextBoxCommandResponse.Text += Convert.ToByte(dataArray[0]).ToString("X2");
            richTextBoxCommandResponse.Text += " ";

            // Write data byte to serial port
            serialPort1.Write(dataArray, 0, 1);
        }

        void writeByteNoRawDisplay(byte data)
        {
            byte[] dataArray = null;
            dataArray = new byte[1];
            dataArray[0] = data;

            // Write data byte to serial port
            serialPort1.Write(dataArray, 0, 1);
        }

        #endregion

        #region message parser functions

        // define the delegate 
        public delegate void MessageParser();

        // define an instance of the delegate
        MessageParser messageParser;

        // Received message parser
        public void myMessageParser()
        {
            // Display raw message data first 
            displayRawCommandData(rxMessageType, rxMessageLength, rxMessageChecksum, rxMessageData);

            // Display decoded message
            displayDecodedCommand(rxMessageType, rxMessageLength, rxMessageData);
        }

        private void displayDecodedCommand(UInt16 u16Type, UInt16 u16Length, byte[] au8Data)
        {
            richTextBoxMessageView.Text += "Type: 0x";
            richTextBoxMessageView.Text += u16Type.ToString("X4");

            switch (u16Type)
            {
                case 0x8000:
                {
                    richTextBoxMessageView.Text += " (Status)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Length: " + u16Length.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[0].ToString("X2");

                    switch (au8Data[0])
                    {
                        case 0:
                        {
                            richTextBoxMessageView.Text += " (Success)";
                        }
                        break;

                        case 1:
                        {
                            richTextBoxMessageView.Text += " (Incorrect Parameters)";
                        }
                        break;

                        case 2:
                        {
                            richTextBoxMessageView.Text += " (Unhandled Command)";
                        }
                        break;

                        case 3:
                        {
                            richTextBoxMessageView.Text += " (Command Failed)";
                        }
                        break;

                        case 4:
                        {
                            richTextBoxMessageView.Text += " (Busy)";
                        }
                        break;

                        case 5:
                        {
                            richTextBoxMessageView.Text += " (Stack Already Started)";
                        }
                        break;

                        default:
                        {
                            richTextBoxMessageView.Text += " (ZigBee Error Code)";
                        }
                        break;
                    }

                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[1].ToString("X2");

                    if (u16Length > 2)
                    {
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Message: ";
                        string errorMessage = System.Text.Encoding.Default.GetString(au8Data);
                        richTextBoxMessageView.Text += errorMessage.Substring(2, (u16Length - 2));
                    }
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8001:
                {                    
                    richTextBoxMessageView.Text += " (Log)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Level: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Message: ";

                    string logMessage = System.Text.Encoding.Default.GetString(au8Data);
                    richTextBoxMessageView.Text += logMessage.Substring(1, (u16Length - 1));
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8002:
                {
                    UInt16 u16ProfileID = 0;
                    UInt16 u16ClusterID = 0;

                    u16ProfileID = au8Data[1];
                    u16ProfileID <<= 8;
                    u16ProfileID |= au8Data[2];

                    u16ClusterID = au8Data[3];
                    u16ClusterID <<= 8;
                    u16ClusterID |= au8Data[4];

                    richTextBoxMessageView.Text += " (Data Indication)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayProfileId(u16ProfileID);
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterID);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Source EndPoint: 0x" + au8Data[5].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Destination EndPoint: 0x" + au8Data[6].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Source Address Mode: 0x" + au8Data[7].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Source Address: ";

                    byte nextIndex = 0;

                    if (au8Data[9] == 0)
                    {
                        //0x00 = DstAddress and DstEndpoint not present                        
                        richTextBoxMessageView.Text += "Not Present";
                        richTextBoxMessageView.Text += "\n";

                        nextIndex = 10;
                    }
                    else if (au8Data[9] == 1)
                    {
                        UInt16 u16GroupAddr = 0;

                        u16GroupAddr   = au8Data[10];
                        u16GroupAddr <<= 8;
                        u16GroupAddr  |= au8Data[11];

                        //0x01 = 16-bit group address for DstAddress; DstEndpoint not present
                        richTextBoxMessageView.Text += u16GroupAddr.ToString("X4");
                        richTextBoxMessageView.Text += "\n";

                        nextIndex = 12;
                    }
                    else if (au8Data[9] == 2)
                    {
                        UInt16 u16DstAddress = 0;
                        UInt16 u16DstEndPoint1 = 0;

                        u16DstAddress = au8Data[10];
                        u16DstAddress <<= 8;
                        u16DstAddress |= au8Data[11];

                        u16DstEndPoint1 = au8Data[12];
                        u16DstEndPoint1 <<= 8;
                        u16DstEndPoint1 |= au8Data[13];

                        //0x02 = 16-bit address for DstAddress and DstEndpoint present
                        richTextBoxMessageView.Text += u16DstAddress.ToString("X4");
                        richTextBoxMessageView.Text += "  EndPoint: 0x" + u16DstEndPoint1.ToString("X4");
                        richTextBoxMessageView.Text += "\n";

                        nextIndex = 14;
                    }
                    else if (au8Data[9] == 3)
                    {
                        //0x03 = 64-bit extended address for DstAddress and DstEndpoint present
                    }
                    else
                    {
                        //0x04 - 0xff = reserved
                        nextIndex = 10;
                        richTextBoxMessageView.Text += "Not Valid";
                        richTextBoxMessageView.Text += "\n";
                    }

                    richTextBoxMessageView.Text += "  Destination Address Mode: 0x" + au8Data[nextIndex].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8003:
                {
                    UInt16 u16Entries = 0;
                    UInt16 u16ProfileID = 0;

                    u16ProfileID = au8Data[1];
                    u16ProfileID <<= 8;
                    u16ProfileID |= au8Data[2];

                    u16Entries = (UInt16)((u16Length - 3) / 2);
                    
                    richTextBoxMessageView.Text += " (Cluster List - Entries: ";
                    richTextBoxMessageView.Text += u16Entries.ToString();
                    richTextBoxMessageView.Text += ")\n";
                    richTextBoxMessageView.Text += "  Source EndPoint: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayProfileId(u16ProfileID);

                    for (int i = 3; i < u16Length; i+=2)
                    {
                        UInt16 u16ClusterID;

                        u16ClusterID = au8Data[i];
                        u16ClusterID <<= 8;
                        u16ClusterID |= au8Data[i + 1];

                        displayClusterId(u16ClusterID);
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x8004:
                {
                    UInt16 u16Entries = 0;
                    UInt16 u16ProfileID = 0;
                    UInt16 u16ClusterID = 0;

                    u16ProfileID = au8Data[1];
                    u16ProfileID <<= 8;
                    u16ProfileID |= au8Data[2];

                    u16ClusterID = au8Data[3];
                    u16ClusterID <<= 8;
                    u16ClusterID |= au8Data[4];

                    u16Entries = (UInt16)((u16Length - 5) / 2);

                    richTextBoxMessageView.Text += " (Cluster Attributes - Entries: ";
                    richTextBoxMessageView.Text += u16Entries.ToString();
                    richTextBoxMessageView.Text += ")\n";
                    richTextBoxMessageView.Text += " Source EndPoint: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayProfileId(u16ProfileID);
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterID);
                    richTextBoxMessageView.Text += "\n";

                    for (int i = 5; i < u16Length; i += 2)
                    {
                        UInt16 u16AttributeID = 0;

                        u16AttributeID = au8Data[i];
                        u16AttributeID <<= 8;
                        u16AttributeID |= au8Data[i + 1];

                        richTextBoxMessageView.Text += " Attribute ID: 0x" + u16AttributeID.ToString("X4");
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x8005:
                {
                    UInt16 u16Entries = 0;
                    UInt16 u16ProfileID = 0;
                    UInt16 u16ClusterID = 0;

                    u16ProfileID = au8Data[1];
                    u16ProfileID <<= 8;
                    u16ProfileID |= au8Data[2];

                    u16ClusterID = au8Data[3];
                    u16ClusterID <<= 8;
                    u16ClusterID |= au8Data[4];

                    u16Entries = (UInt16)(u16Length - 5);

                    richTextBoxMessageView.Text += " (Command IDs - Entries: ";
                    richTextBoxMessageView.Text += u16Entries.ToString();
                    richTextBoxMessageView.Text += ")\n";
                    richTextBoxMessageView.Text += " Source EndPoint: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayProfileId(u16ProfileID);
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterID);
                    richTextBoxMessageView.Text += "\n";

                    for (int i = 5; i < u16Length; i++)
                    {
                        richTextBoxMessageView.Text += " Command ID: 0x" + au8Data[i].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x8010:
                {
                    UInt16 u16Major = 0;
                    UInt16 u16Installer = 0;

                    u16Major   = au8Data[0];
                    u16Major <<= 8;
                    u16Major  |= au8Data[1];

                    u16Installer = au8Data[2];
                    u16Installer <<= 8;
                    u16Installer |= au8Data[3];

                    richTextBoxMessageView.Text += " (Version)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Length: " + u16Length.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Application: " + u16Major.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SDK: " + u16Installer.ToString();
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8024:
                {
                    UInt16 u16ShortAddr = 0;
                    UInt64 u64ExtAddr = 0;

                    u16ShortAddr   = au8Data[1];
                    u16ShortAddr <<= 8;
                    u16ShortAddr  |= au8Data[2];

                    for(int i = 0; i < 8; i++)
                    {
                        u64ExtAddr <<= 8;
                        u64ExtAddr  |= au8Data[3 + i];
                    }

                    richTextBoxMessageView.Text += " (Network Up)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Short Address: 0x" + u16ShortAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Extended Address: 0x" + u64ExtAddr.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Channel: " + au8Data[11].ToString();
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8014:
                {
                    richTextBoxMessageView.Text += " (Permit Join State)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "Permit Join: " + (au8Data[0] == 1 ? "TRUE" : "FALSE");
                    richTextBoxMessageView.Text += "\n";
                }
                break;
                case 0x8030:
                {
                    richTextBoxMessageView.Text += " (Bind Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8031:
                {
                    richTextBoxMessageView.Text += " (UnBind Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8041:
                {
                    UInt64 u64ExtAddr = 0;
                    UInt16 u16ShortAddr = 0;

                    for (int i = 0; i < 8; i++)
                    {
                        u64ExtAddr <<= 8;
                        u64ExtAddr |= au8Data[2 + i];
                    }

                    u16ShortAddr = au8Data[10];
                    u16ShortAddr <<= 8;
                    u16ShortAddr |= au8Data[11];

                    richTextBoxMessageView.Text += " (IEEE Address Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Extended Address: 0x" + u64ExtAddr.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Short Address: 0x" + u16ShortAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";

                    if (u16Length > 14)
                    {
                        richTextBoxMessageView.Text += "  Associated End Devices: " + au8Data[12].ToString();
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x8042:
                {
                    UInt16 u16ShortAddr = 0;
                    UInt16 u16ManufacturerCode = 0;
                    UInt16 u16RxSize = 0;
                    UInt16 u16TxSize = 0;
                    UInt16 u16ServerMask = 0;
                    UInt16 u16BitFields = 0;
                    byte u8DescriptorCapability = 0;
                    byte u8MacCapability = 0;
                    byte u8MaxBufferSize = 0;

                    u16ShortAddr   = au8Data[2];
                    u16ShortAddr <<= 8;
                    u16ShortAddr  |= au8Data[3];

                    u16ManufacturerCode   = au8Data[4];
                    u16ManufacturerCode <<= 8;
                    u16ManufacturerCode  |= au8Data[5];

                    u16RxSize = au8Data[6];
                    u16RxSize <<= 8;
                    u16RxSize |= au8Data[7];

                    u16TxSize = au8Data[8];
                    u16TxSize <<= 8;
                    u16TxSize |= au8Data[9];

                    u16ServerMask = au8Data[10];
                    u16ServerMask <<= 8;
                    u16ServerMask |= au8Data[11];

                    u8DescriptorCapability = au8Data[12];
                    u8MacCapability = au8Data[13];
                    u8MaxBufferSize = au8Data[14];

                    u16BitFields = au8Data[15];
                    u16BitFields <<= 8;
                    u16BitFields |= au8Data[16];
                   
                    richTextBoxMessageView.Text += " (Node Descriptor Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Short Address: 0x" + u16ShortAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Manufacturer Code: 0x" + u16ManufacturerCode.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Max Rx Size: " + u16RxSize.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Max Tx Size: " + u16TxSize.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Server Mask: 0x" + u16ServerMask.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    displayDescriptorCapability(u8DescriptorCapability);
                    displayMACcapability(u8MacCapability);
                    richTextBoxMessageView.Text += "  Max Buffer Size: " + u8MaxBufferSize.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Bit Fields: 0x" + u16BitFields.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8043:
                {
                    UInt16 u16ShortAddr = 0;                    
                    byte u8Length = 0;

                    u16ShortAddr = au8Data[2];
                    u16ShortAddr <<= 8;
                    u16ShortAddr |= au8Data[3];
                    u8Length = au8Data[4];

                    richTextBoxMessageView.Text += " (Simple Descriptor Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Short Address: 0x" + u16ShortAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Length: " + u8Length.ToString("");
                    richTextBoxMessageView.Text += "\n";

                    if (u8Length > 0)
                    {
                        byte u8InputClusterCount = 0;
                        UInt16 u16ProfileId = 0;
                        UInt16 u16DeviceId = 0;

                        u16ProfileId = au8Data[6];
                        u16ProfileId <<= 8;
                        u16ProfileId |= au8Data[7];
                        u16DeviceId = au8Data[8];
                        u16DeviceId <<= 8;
                        u16DeviceId |= au8Data[9];
                        u8InputClusterCount = au8Data[11];

                        richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[5].ToString("X2");
                        richTextBoxMessageView.Text += "\n";                        
                        displayProfileId(u16ProfileId);
                        richTextBoxMessageView.Text += "\n";
                        displayDeviceId(u16DeviceId);                        
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Input Cluster Count: " + u8InputClusterCount.ToString();
                        richTextBoxMessageView.Text += "\n";

                        UInt16 u16Index = 12;
                        for (int i = 0; i < u8InputClusterCount; i++)
                        {
                            UInt16 u16ClusterId = 0;

                            u16ClusterId = au8Data[(i * 2) + 12];
                            u16ClusterId <<= 8;
                            u16ClusterId |= au8Data[(i * 2) + 13];

                            richTextBoxMessageView.Text += "    Cluster " + i.ToString();
                            richTextBoxMessageView.Text += ":";
                            displayClusterId(u16ClusterId);
                            richTextBoxMessageView.Text += "\n";
                            u16Index+=2;
                        }

                        byte u8OutputClusterCount = au8Data[u16Index];
                        u16Index++;

                        richTextBoxMessageView.Text += "  Output Cluster Count: " + u8OutputClusterCount.ToString();
                        richTextBoxMessageView.Text += "\n";

                        for (int i = 0; i < u8OutputClusterCount; i++)
                        {
                            UInt16 u16ClusterId = 0;

                            u16ClusterId = au8Data[u16Index];
                            u16ClusterId <<= 8;
                            u16ClusterId |= au8Data[u16Index + 1];

                            richTextBoxMessageView.Text += "    Cluster " + i.ToString();
                            richTextBoxMessageView.Text += ":";
                            displayClusterId(u16ClusterId);
                            richTextBoxMessageView.Text += "\n";
                            u16Index += 2;
                        }
                    }
                }
                break;
                    /*
                case 0x8044:
                {
                    richTextBoxMessageView.Text += " (Power Descriptor Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;
                    */
                case 0x8045:
                {
                    UInt16 u16ShortAddr = 0;

                    u16ShortAddr = au8Data[2];
                    u16ShortAddr <<= 8;
                    u16ShortAddr |= au8Data[3];

                    richTextBoxMessageView.Text += " (Active Endpoints Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Short Address: 0x" + u16ShortAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Endpoint Count: " + au8Data[4].ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Endpoint List: ";
                    richTextBoxMessageView.Text += "\n";

                    for (int i = 0; i < au8Data[4]; i++)
                    {
                        richTextBoxMessageView.Text += "    Endpoint " + i.ToString();
                        richTextBoxMessageView.Text += ": ";
                        richTextBoxMessageView.Text += "0x" + au8Data[i + 5].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x8047:
                {
                    richTextBoxMessageView.Text += " (Leave Confirmation)";
                    richTextBoxMessageView.Text += "\n";
                    
                    if (u16Length == 2)
                    {
                        richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                    }
                    
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";

                    if (u16Length == 9)
                    {
                        UInt64 u64ExtAddr = 0;

                        for (int i = 0; i < 8; i++)
                        {
                            u64ExtAddr <<= 8;
                            u64ExtAddr |= au8Data[1 + i];
                        }

                        richTextBoxMessageView.Text += "  Extended Address: 0x" + u64ExtAddr.ToString("X8");
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x8048:
                {
                    UInt64 u64ExtAddr = 0;

                    for (int i = 0; i < 8; i++)
                    {
                        u64ExtAddr <<= 8;
                        u64ExtAddr |= au8Data[i];
                    }

                    richTextBoxMessageView.Text += " (Leave Indication)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Extended Address: 0x" + u64ExtAddr.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Rejoin Status: 0x" + au8Data[8].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x804A:
                {
                    byte u8ScannedChannelsListCount;
                    UInt16 u16TotalTx = 0;
                    UInt16 u16TxFailures = 0;
                    UInt32 u32ScannedChannels = 0;

                    u16TotalTx = au8Data[2];
                    u16TotalTx <<= 8;
                    u16TotalTx |= au8Data[3];
                    
                    u16TxFailures = au8Data[4];
                    u16TxFailures <<= 8;
                    u16TxFailures |= au8Data[5];

                    u32ScannedChannels = au8Data[6];
                    u32ScannedChannels <<= 8;
                    u32ScannedChannels |= au8Data[7];
                    u32ScannedChannels <<= 8; 
                    u32ScannedChannels |= au8Data[8];
                    u32ScannedChannels <<= 8;
                    u32ScannedChannels |= au8Data[9];

                    u8ScannedChannelsListCount = au8Data[10];

                    richTextBoxMessageView.Text += " (Mgmt Nwk Update Notify)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Total Tx: " + u16TotalTx.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Tx Failures: " + u16TxFailures.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Scanned Channels: 0x" + u32ScannedChannels.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Scanned Channels List Count: " + u8ScannedChannelsListCount.ToString();
                    richTextBoxMessageView.Text += "\n";

                    for (int x = 0; x < u8ScannedChannelsListCount; x++)
                    {
                        richTextBoxMessageView.Text += "  Value " + x.ToString();
                        richTextBoxMessageView.Text += ":  0x" + au8Data[11 + x].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x804E:
                {
                    byte u8NbTableEntries = 0;
                    byte u8StartIx = 0;
                    byte u8NbTableListCount = 0;

                    u8NbTableEntries = au8Data[2];
                    u8NbTableListCount = au8Data[3];                    
                    u8StartIx = au8Data[4];
                    
                    richTextBoxMessageView.Text += " (Mgmt LQI Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Nb Table Entries: " + u8NbTableEntries.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Start Index: " + u8StartIx.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Nb Table List Count: " + u8NbTableListCount.ToString();
                    richTextBoxMessageView.Text += "\n";

                    if (u8NbTableListCount > 0)
                    {
                        byte i;
                        UInt64 u64PanID = 0;
                        UInt64 u64ExtAddr = 0;
                        UInt16 u16NwkAddr = 0;
                        byte u8Lqi = 0;
                        byte u8Depth = 0;
                        byte u8Flags = 0;
                        byte u8PayloadIndex = 5;

                        for (i = 0; i < u8NbTableListCount; i++)
                        {
                            u16NwkAddr = 0;
                            for (int x = 0; x < 2; x++, u8PayloadIndex++)
                            {
                                u16NwkAddr <<= 8;
                                u16NwkAddr |= au8Data[u8PayloadIndex];
                            }

                            u64PanID = 0;
                            for (int x = 0; x < 8; x++, u8PayloadIndex++)
                            {
                                u64PanID <<= 8;
                                u64PanID |= au8Data[u8PayloadIndex];
                            }

                            u64ExtAddr = 0;
                            for (int x = 0; x < 8; x++, u8PayloadIndex++)
                            {
                                u64ExtAddr <<= 8;
                                u64ExtAddr |= au8Data[u8PayloadIndex];
                            }

                            u8Depth = au8Data[u8PayloadIndex++];
                            u8Lqi = au8Data[u8PayloadIndex++];                            
                            u8Flags = au8Data[u8PayloadIndex++];

                            richTextBoxMessageView.Text += "  Neighbor " + i.ToString();
                            richTextBoxMessageView.Text += ":";
                            richTextBoxMessageView.Text += "\n";
                            richTextBoxMessageView.Text += "    Extended Pan ID: 0x" + u64PanID.ToString("X8");
                            richTextBoxMessageView.Text += "\n";
                            richTextBoxMessageView.Text += "    Extended Address: 0x" + u64ExtAddr.ToString("X8");
                            richTextBoxMessageView.Text += "\n";
                            richTextBoxMessageView.Text += "    Nwk Address: 0x" + u16NwkAddr.ToString("X4");
                            richTextBoxMessageView.Text += "\n";
                            richTextBoxMessageView.Text += "    LQI: " + u8Lqi.ToString();
                            richTextBoxMessageView.Text += "\n";
                            richTextBoxMessageView.Text += "    Depth: " + u8Depth.ToString();
                            richTextBoxMessageView.Text += "\n";
                            richTextBoxMessageView.Text += "    Flags: 0x" + u8Flags.ToString("X2");
                            richTextBoxMessageView.Text += "\n";

                            byte u8DeviceType = (byte)(u8Flags & 0x03);
                            richTextBoxMessageView.Text += "    Device Type: ";

                            if (u8DeviceType == 0)
                            {
                                richTextBoxMessageView.Text += "Coordinator";
                            }
                            else if (u8DeviceType == 1)
                            {
                                richTextBoxMessageView.Text += "Router";
                            }
                            else if (u8DeviceType == 2)
                            {
                                richTextBoxMessageView.Text += "End Device";
                            }
                            else
                            {
                                richTextBoxMessageView.Text += "Unknown";
                            }
                            richTextBoxMessageView.Text += "\n";

                            byte u8PermitJoin = (byte)((u8Flags & 0x0C) >> 2);
                            richTextBoxMessageView.Text += "    Permit Joining: ";

                            if (u8PermitJoin == 0)
                            {
                                richTextBoxMessageView.Text += "Off";
                            }
                            else if (u8PermitJoin == 1)
                            {
                                richTextBoxMessageView.Text += "On";
                            }
                            else
                            {
                                richTextBoxMessageView.Text += "Unknown";
                            }
                            richTextBoxMessageView.Text += "\n";

                            byte u8Relationship = (byte)((u8Flags & 0x30) >> 4);
                            richTextBoxMessageView.Text += "    Relationship: ";

                            if (u8Relationship == 0)
                            {
                                richTextBoxMessageView.Text += "Parent";
                            }
                            else if (u8Relationship == 1)
                            {
                                richTextBoxMessageView.Text += "Child";
                            }
                            else if (u8Relationship == 2)
                            {
                                richTextBoxMessageView.Text += "Sibling";
                            }
                            else if (u8Relationship == 4)
                            {
                                richTextBoxMessageView.Text += "Previous Child";
                            }
                            else
                            {
                                richTextBoxMessageView.Text += "Unknown";
                            }
                            richTextBoxMessageView.Text += "\n";

                            byte u8RxOnWhenIdle = (byte)((u8Flags & 0xC0) >> 6);
                            richTextBoxMessageView.Text += "    RxOnWhenIdle: ";

                            if (u8RxOnWhenIdle == 0)
                            {
                                richTextBoxMessageView.Text += "No";
                            }
                            else if (u8RxOnWhenIdle == 1)
                            {
                                richTextBoxMessageView.Text += "Yes";
                            }
                            else
                            {
                                richTextBoxMessageView.Text += "Unknown";
                            }                            
                            richTextBoxMessageView.Text += "\n";
                        }
                    }
                }
                break;

                case 0x8050:
                {
                    UInt16 u16TableSize;
                    UInt16 u16TableEntries;

                    u16TableSize = au8Data[1];
                    u16TableSize <<= 8;
                    u16TableSize |= au8Data[2];

                    u16TableEntries = au8Data[3];
                    u16TableEntries <<= 8;
                    u16TableEntries |= au8Data[4];

                    richTextBoxMessageView.Text += " (Addr Map Table Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Table Size: " + u16TableSize.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Entries: " + u16TableEntries.ToString();
                    richTextBoxMessageView.Text += "\n";

                    byte i;
                    for (i = 0; i < u16TableEntries; i++)
                    {
                        UInt16 u16Addr;
                        UInt64 u64Addr;

                        u16Addr = au8Data[5 + (i * 8)];
                        u16Addr <<= 8;
                        u16Addr |= au8Data[6 + (i * 8)];

                        u64Addr = au8Data[7 + (i * 8)];
                        u64Addr <<= 8;
                        u64Addr |= au8Data[8 + (i * 8)];
                        u64Addr <<= 8;
                        u64Addr |= au8Data[9 + (i * 8)];
                        u64Addr <<= 8;
                        u64Addr |= au8Data[10 + (i * 8)];
                        u64Addr <<= 8;
                        u64Addr |= au8Data[11 + (i * 8)];
                        u64Addr <<= 8;
                        u64Addr |= au8Data[12 + (i * 8)];
                        u64Addr <<= 8;
                        u64Addr |= au8Data[13 + (i * 8)];
                        u64Addr <<= 8;
                        u64Addr |= au8Data[14 + (i * 8)];

                        richTextBoxMessageView.Text += "  Entry " + i.ToString();
                        richTextBoxMessageView.Text += ": 0x" + u16Addr.ToString("X4");
                        richTextBoxMessageView.Text += " 0x" + u64Addr.ToString("X8");

                        richTextBoxMessageView.Text += "\n";
                    }

                }
                break;

                case 0x8060:
                {
                    UInt16 u16ClusterId = 0;
                    UInt16 u16GroupId = 0;

                    u16ClusterId   = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId  |= au8Data[3];

                    u16GroupId   = au8Data[5];
                    u16GroupId <<= 8;
                    u16GroupId  |= au8Data[6];

                    richTextBoxMessageView.Text += " (Add Group Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Group: 0x" + u16GroupId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8061:
                {
                    UInt16 u16ClusterId = 0;
                    UInt16 u16GroupId = 0;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    u16GroupId = au8Data[5];
                    u16GroupId <<= 8;
                    u16GroupId |= au8Data[6];

                    richTextBoxMessageView.Text += " (View Group Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Group: 0x" + u16GroupId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8062:
                {
                    UInt16 u16ClusterId = 0;
                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    richTextBoxMessageView.Text += " (Get Group Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Capacity: " + au8Data[4].ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Count: " + au8Data[5].ToString();
                    richTextBoxMessageView.Text += "\n";

                    byte i;
                    for (i = 0; i < au8Data[5]; i++)
                    {
                        UInt16 u16GroupId;

                        u16GroupId = au8Data[6 + (i * 2)];
                        u16GroupId <<= 8;
                        u16GroupId |= au8Data[7 + (i * 2)];

                        richTextBoxMessageView.Text += "  Group " + i.ToString();
                        richTextBoxMessageView.Text += ": 0x" + u16GroupId.ToString("X4");
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x8063:
                {
                    UInt16 u16ClusterId = 0;
                    UInt16 u16GroupId = 0;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    u16GroupId = au8Data[5];
                    u16GroupId <<= 8;
                    u16GroupId |= au8Data[6];

                    richTextBoxMessageView.Text += " (Remove Group Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Group: 0x" + u16GroupId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8095:
                {
                    UInt16 u16ClusterId = 0;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    richTextBoxMessageView.Text += " (On/Off Update)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Addr Mode: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";

                    if (au8Data[4] == 0x03)
                    {
                    }
                    else
                    {
                        UInt16 u16Addr = 0;

                        u16Addr = au8Data[5];
                        u16Addr <<= 8;
                        u16Addr |= au8Data[6];

                        richTextBoxMessageView.Text += "  Src Addr Mode: 0x" + u16Addr.ToString("X4");
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Status: 0x" + au8Data[7].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x80A0:
                {
                    UInt16 u16ClusterId = 0, u16GroupId = 0, u16TransTime = 0, u16SceneLength = 0;
                    byte u8Status;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    u8Status = au8Data[4];

                    u16GroupId = au8Data[5];
                    u16GroupId <<= 8;
                    u16GroupId |= au8Data[6];


                    richTextBoxMessageView.Text += " (View Scene)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Cluster ID: 0x" + u16ClusterId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + u8Status.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Group ID: 0x" + u16GroupId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Scene Id: 0x" + au8Data[7].ToString("X2");

                    if (0 == u8Status)
                    {
                        u16TransTime = au8Data[8];
                        u16TransTime <<= 8;
                        u16TransTime |= au8Data[9];

                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Transition Time: 0x" + u16TransTime.ToString("X4");
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Scene Name Length: 0x" + au8Data[10].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Scene Name Max Length: 0x" + au8Data[11].ToString("X2");
                        richTextBoxMessageView.Text += "\n";

                        richTextBoxMessageView.Text += "  Scene Name: ";

                        byte i = 0;
                        for (i = 0; i < au8Data[10]; i++)
                        {
                            richTextBoxMessageView.Text += Convert.ToChar(au8Data[12 + i]);
                        }
                    
                        u16SceneLength = au8Data[12 + i];
                        u16SceneLength <<= 8;
                        u16SceneLength |= au8Data[13 + i];

                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Ext Scene Length: 0x" + u16SceneLength.ToString("X4");
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Ext Max Length: 0x" + au8Data[14 + i].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Scene Data: ";
                        richTextBoxMessageView.Text += "\n      ";
                    
                        for (byte c = 0; i < u16SceneLength; i++)
                        {
                            richTextBoxMessageView.Text += "0x" + au8Data[15 + i + c].ToString("X2") + " ";
                        }
                    }
                    
                }
                break;

                case 0x80A3:
                {
                    UInt16 u16ClusterId, u16GroupId;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    u16GroupId = au8Data[5];
                    u16GroupId <<= 8;
                    u16GroupId |= au8Data[6];

                    richTextBoxMessageView.Text += " (View Scene)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Cluster ID: 0x" + u16ClusterId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Group ID: 0x" + u16GroupId.ToString("X4");
                }
                break;

                case 0x80A2:
                {
                    UInt16 u16ClusterId, u16GroupId;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    u16GroupId = au8Data[5];
                    u16GroupId <<= 8;
                    u16GroupId |= au8Data[6];

                    richTextBoxMessageView.Text += " (View Scene)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Cluster ID: 0x" + u16ClusterId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Group ID: 0x" + u16GroupId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Scene ID: 0x" + au8Data[7].ToString("X2");
                }
                break;

                case 0x8100: // Read attribute response
                {
                    UInt16 u16ClusterId = 0;
                    UInt16 u16AttribId = 0;
                    UInt16 u16SrcAddr = 0;
                    UInt16 u16AttributeSize = 0;

                    u16SrcAddr = au8Data[1];
                    u16SrcAddr <<= 8;
                    u16SrcAddr |= au8Data[2];

                    u16ClusterId = au8Data[4];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[5];

                    u16AttribId = au8Data[6];
                    u16AttribId <<= 8;
                    u16AttribId |= au8Data[7];

                    u16AttributeSize = au8Data[10];
                    u16AttributeSize <<= 8;
                    u16AttributeSize |= au8Data[11];

                    richTextBoxMessageView.Text += " (Read Attrib Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Addr: 0x" + u16SrcAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";                    
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[3].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[8].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);                    
                    richTextBoxMessageView.Text += "\n";
                    displayAttribute(u16AttribId, au8Data[9], au8Data, 12, u16AttributeSize);
                }
                break;

                case 0x8101:
                {
                    UInt16 u16ClusterId = 0;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    richTextBoxMessageView.Text += " (Default Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Command: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[5].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8120:
                {
                    UInt16 u16ClusterId = 0;
                    UInt16 u16SrcAddr = 0;

                    u16ClusterId = au8Data[4];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[5];

                    u16SrcAddr = au8Data[1];
                    u16SrcAddr <<= 8;
                    u16SrcAddr |= au8Data[2];

                    richTextBoxMessageView.Text += " (Report Config Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Addr: 0x" + u16SrcAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[3].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[6].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8102:
                {
                    UInt16 u16SrcAddr = 0;
                    UInt16 u16ClusterId = 0;
                    UInt16 u16AttribId = 0;
                    UInt16 u16AttributeSize = 0;

                    u16SrcAddr = au8Data[1];
                    u16SrcAddr <<= 8;
                    u16SrcAddr |= au8Data[2];
                    
                    u16ClusterId = au8Data[4];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[5];

                    u16AttribId = au8Data[6];
                    u16AttribId <<= 8;
                    u16AttribId |= au8Data[7];

                    u16AttributeSize = au8Data[10];
                    u16AttributeSize <<= 8;
                    u16AttributeSize |= au8Data[11];

                    richTextBoxMessageView.Text += " (Attribute Report)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Addr: 0x" + u16SrcAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Ep: 0x" + au8Data[3].ToString("X2");
                    richTextBoxMessageView.Text += "\n";                    
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    displayAttribute(u16AttribId, au8Data[9], au8Data, 12, u16AttributeSize);
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[8].ToString("X2");
                    richTextBoxMessageView.Text += "\n";                                 
                }
                break;

                case 0x8122:
                {
                    UInt16 u16SrcAddr = 0;
                    UInt16 u16ClusterId = 0;
                    UInt16 u16AttribId = 0;
                    UInt16 u16MaxInterval = 0;
                    UInt16 u16MinInterval = 0;

                    u16SrcAddr = au8Data[1];
                    u16SrcAddr <<= 8;
                    u16SrcAddr |= au8Data[2];

                    u16ClusterId = au8Data[4];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[5];

                    u16AttribId = au8Data[8];
                    u16AttribId <<= 8;
                    u16AttribId |= au8Data[9];

                    u16MaxInterval = au8Data[10];
                    u16MaxInterval <<= 8;
                    u16MaxInterval |= au8Data[11];

                    u16MinInterval = au8Data[12];
                    u16MinInterval <<= 8;
                    u16MinInterval |= au8Data[13];

                    richTextBoxMessageView.Text += " (Attribute Config Report)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Addr: 0x" + u16SrcAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Ep: 0x" + au8Data[3].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[6].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayDataType(au8Data[7]);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute: 0x" + u16AttribId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Min Interval: " + u16MinInterval.ToString();
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Max Interval: " + u16MaxInterval.ToString();
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8140: // Discover attribute response
                {
                    UInt16 u16AttribId = 0;

                    u16AttribId = au8Data[2];
                    u16AttribId <<= 8;
                    u16AttribId |= au8Data[3];

                    richTextBoxMessageView.Text += " (Discover Attrib Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Complete: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayDataType(au8Data[1]);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute: 0x" + u16AttribId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8141: // Discover extended attribute response
                {
                    UInt16 u16AttribId = 0;

                    u16AttribId = au8Data[2];
                    u16AttribId <<= 8;
                    u16AttribId |= au8Data[3];

                    richTextBoxMessageView.Text += " (Discover Attrib Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Complete: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayDataType(au8Data[1]);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute: 0x" + u16AttribId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Flags: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8150: // Discover command received individual response
                {
                    richTextBoxMessageView.Text += " (Discover Command Received Individual Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Command: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Index: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8151: // Discover command received response
                {
                    richTextBoxMessageView.Text += " (Discover Command Received Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Complete: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Commands: " + au8Data[1].ToString();
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8160: // Discover command generated individual response
                {
                    richTextBoxMessageView.Text += " (Discover Command Generated Individual Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Command: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Index: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8161: // Discover command generated response
                {
                    richTextBoxMessageView.Text += " (Discover Command Generated Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Complete: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Commands: " + au8Data[1].ToString();
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8401:
                {
                    UInt16 u16ClusterId = 0;
                    UInt16 u16ZoneStatus = 0;
                    UInt16 u16Delay = 0;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    richTextBoxMessageView.Text += " (IAS Zone Status Change)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Addr Mode: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";

                    if (au8Data[4] == 0x03)
                    {
                    }
                    else
                    {
                        UInt16 u16Addr = 0;

                        u16Addr = au8Data[5];
                        u16Addr <<= 8;
                        u16Addr |= au8Data[6];

                        richTextBoxMessageView.Text += "  Src Addr Mode: 0x" + u16Addr.ToString("X4");
                        richTextBoxMessageView.Text += "\n";
                    }

                    u16ZoneStatus   = au8Data[7];
                    u16ZoneStatus <<= 8;
                    u16ZoneStatus  |= au8Data[8];

                    richTextBoxMessageView.Text += "  Zone Status: 0x" + u16ZoneStatus.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Ext Status: 0x" + au8Data[9].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Zone ID: 0x" + au8Data[10].ToString("X2");
                    richTextBoxMessageView.Text += "\n";

                    u16Delay   = au8Data[11];
                    u16Delay <<= 8;
                    u16Delay  |= au8Data[12];

                    richTextBoxMessageView.Text += "  Delay: 0x" + u16Delay.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x004D:
                {
                    UInt16 u16ShortAddr = 0;
                    UInt64 u64ExtAddr = 0;

                    u16ShortAddr = au8Data[0];
                    u16ShortAddr <<= 8;
                    u16ShortAddr |= au8Data[1];

                    for (int i = 0; i < 8; i++)
                    {
                        u64ExtAddr <<= 8;
                        u64ExtAddr |= au8Data[2 + i];
                    }

                    richTextBoxMessageView.Text += " (End Device Announce)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Short Address: 0x" + u16ShortAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Extended Address: 0x" + u64ExtAddr.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    displayMACcapability(au8Data[10]);
                }
                break;

                case 0x8501:                //  E_SL_MSG_BLOCK_REQUEST
                    {
                    byte u8Offset = 0;
                    byte u8SQN;
                    byte u8SrcEndpoint;
                    UInt16 u16ClusterId;
                    UInt16 u16SrcAddr;
                    byte u8SrcAddrMode;
                    UInt64 u64RequestNodeAddress;
                    UInt32 u32FileOffset;
                    UInt32 u32FileVersion;
                    UInt16 u16ImageType;
                    UInt16 u16ManufactureCode;
                    UInt16 u16BlockRequestDelay;
                    byte u8MaxDataSize;
                    byte u8FieldControl;

                    u8SQN = au8Data[u8Offset++];

                    u8SrcEndpoint = au8Data[u8Offset++];

                    u16ClusterId = au8Data[u8Offset++];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[u8Offset++];

                    u8SrcAddrMode = au8Data[u8Offset++];

                    u16SrcAddr = au8Data[u8Offset++];
                    u16SrcAddr <<= 8;
                    u16SrcAddr |= au8Data[u8Offset++];

                    u64RequestNodeAddress = au8Data[u8Offset++];
                    u64RequestNodeAddress <<= 8;
                    u64RequestNodeAddress |= au8Data[u8Offset++];
                    u64RequestNodeAddress <<= 8;
                    u64RequestNodeAddress |= au8Data[u8Offset++];
                    u64RequestNodeAddress <<= 8;
                    u64RequestNodeAddress |= au8Data[u8Offset++];
                    u64RequestNodeAddress <<= 8;
                    u64RequestNodeAddress |= au8Data[u8Offset++];
                    u64RequestNodeAddress <<= 8;
                    u64RequestNodeAddress |= au8Data[u8Offset++];
                    u64RequestNodeAddress <<= 8;
                    u64RequestNodeAddress |= au8Data[u8Offset++];
                    u64RequestNodeAddress <<= 8;
                    u64RequestNodeAddress |= au8Data[u8Offset++];

                    u32FileOffset = au8Data[u8Offset++];
                    u32FileOffset <<= 8;
                    u32FileOffset |= au8Data[u8Offset++];
                    u32FileOffset <<= 8;
                    u32FileOffset |= au8Data[u8Offset++];
                    u32FileOffset <<= 8;
                    u32FileOffset |= au8Data[u8Offset++];

                    u32FileVersion = au8Data[u8Offset++];
                    u32FileVersion <<= 8;
                    u32FileVersion |= au8Data[u8Offset++];
                    u32FileVersion <<= 8;
                    u32FileVersion |= au8Data[u8Offset++];
                    u32FileVersion <<= 8;
                    u32FileVersion |= au8Data[u8Offset++];

                    u16ImageType = au8Data[u8Offset++];
                    u16ImageType <<= 8;
                    u16ImageType |= au8Data[u8Offset++];

                    u16ManufactureCode = au8Data[u8Offset++];
                    u16ManufactureCode <<= 8;
                    u16ManufactureCode |= au8Data[u8Offset++];

                    u16BlockRequestDelay = au8Data[u8Offset++];
                    u16BlockRequestDelay <<= 8;
                    u16BlockRequestDelay |= au8Data[u8Offset++];

                    u8MaxDataSize = au8Data[u8Offset++];

                    u8FieldControl = au8Data[u8Offset++];

                    /*
                    richTextBoxMessageView.Text += " (OTA Block Request)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + u8SQN.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                     */

                    richTextBoxMessageView.Text = "";
                    richTextBoxCommandResponse.Text = "";


                    /*
                    richTextBoxMessageView.Text += "  Src Addr Mode: 0x" + u8SrcAddrMode.ToString("X2");
                    richTextBoxMessageView.Text += "\n";                    
                    richTextBoxMessageView.Text += "  Src Addr: 0x" + u16SrcAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + u8SrcEndpoint.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";

                    if ((u8FieldControl & 0x01) == 0x01)
                    {
                        richTextBoxMessageView.Text += "  Node Addr: 0x" + u64RequestNodeAddress.ToString("X16");
                        richTextBoxMessageView.Text += "\n";
                    }

                    richTextBoxMessageView.Text += "  File Offset: 0x" + u32FileOffset.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  File Version: 0x" + u32FileVersion.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Image Type: 0x" + u16ImageType.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Manu Code: 0x" + u16ManufactureCode.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Block Delay: 0x" + u16BlockRequestDelay.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Max Data Size: 0x" + u8MaxDataSize.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Field Control: 0x" + u8FieldControl.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    */
                    // Send response 
                    if (u8OTAWaitForDataParamsPending == 0)
                    {
                        byte u8NbrBytes = 0;

                        if ((u32FileOffset + u8MaxDataSize) > u32OtaFileTotalImage)
                        {
                            u8NbrBytes = (byte)(u32OtaFileTotalImage - u32FileOffset);
                        }
                        else
                        {
                            u8NbrBytes = u8MaxDataSize;
                        }
                        //  发送 block
                        sendOtaBlock(u8SrcAddrMode, u16SrcAddr, 1, u8SrcEndpoint, u8SQN, 0, u32FileOffset, u32FileVersion, u16ImageType, u16ManufactureCode, u8NbrBytes, au8OTAFile);
                    }
                    else
                    {
                        sendOtaSetWaitForDataParams(u8SrcAddrMode, u16SrcAddr, 1, u8SrcEndpoint, u8SQN, 0x97, u32OTAWaitForDataParamsCurrentTime, u32OTAWaitForDataParamsRequestTime, u16OTAWaitForDataParamsBlockDelay);
                        u8OTAWaitForDataParamsPending = 0;
                    }

                    if (u8OtaInProgress == 0)
                    {
                        u8OtaInProgress = 1;
                        textBoxOtaDownloadStatus.Text = "In Progress";
                        progressBarOtaDownloadProgress.Value = 0;
                        textBoxOtaFileOffset.Text = "0";
                    }
                    else
                    {
                        UInt32 u32PercentComplete = (u32FileOffset * 1000) / u32OtaFileTotalImage;
                        progressBarOtaDownloadProgress.Value = (int)u32PercentComplete;
                        textBoxOtaFileOffset.Text = u32FileOffset.ToString();
                    }
                }
                break;

                case 0x8503:            //E_SL_MSG_UPGRADE_END_REQUEST
                    {
                    byte u8Offset = 0;
                    byte u8SQN;
                    byte u8SrcEndpoint;
                    UInt16 u16ClusterId;
                    UInt16 u16SrcAddr;
                    byte u8SrcAddrMode;
                    UInt32 u32FileVersion;
                    UInt16 u16ImageType;
                    UInt16 u16ManufactureCode;
                    byte u8Status;

                    u8SQN = au8Data[u8Offset++];

                    u8SrcEndpoint = au8Data[u8Offset++];

                    u16ClusterId = au8Data[u8Offset++];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[u8Offset++];

                    u8SrcAddrMode = au8Data[u8Offset++];

                    u16SrcAddr = au8Data[u8Offset++];
                    u16SrcAddr <<= 8;
                    u16SrcAddr |= au8Data[u8Offset++];

                    u32FileVersion = au8Data[u8Offset++];
                    u32FileVersion <<= 8;
                    u32FileVersion |= au8Data[u8Offset++];
                    u32FileVersion <<= 8;
                    u32FileVersion |= au8Data[u8Offset++];
                    u32FileVersion <<= 8;
                    u32FileVersion |= au8Data[u8Offset++];

                    u16ImageType = au8Data[u8Offset++];
                    u16ImageType <<= 8;
                    u16ImageType |= au8Data[u8Offset++];

                    u16ManufactureCode = au8Data[u8Offset++];
                    u16ManufactureCode <<= 8;
                    u16ManufactureCode |= au8Data[u8Offset++];

                    u8Status = au8Data[u8Offset++];

                    richTextBoxMessageView.Text += " (OTA End Request)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + u8SQN.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Addr Mode: 0x" + u8SrcAddrMode.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Src Addr: 0x" + u16SrcAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + u8SrcEndpoint.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  File Version: 0x" + u32FileVersion.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Image Type: 0x" + u16ImageType.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Manu Code: 0x" + u16ManufactureCode.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + u8Status.ToString("X2");
                    richTextBoxMessageView.Text += "\n";

                    sendOtaEndResponse(u8SrcAddrMode, u16SrcAddr, 1, u8SrcEndpoint, u8SQN, 5, 10, u32FileVersion, u16ImageType, u16ManufactureCode);

                    textBoxOtaDownloadStatus.Text = "Complete";
                    u8OtaInProgress = 0;  
                }
                break;

                case 0x8110:
                {
                    UInt16 u16ClusterId = 0;
                    UInt16 u16AttribId = 0;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    u16AttribId = au8Data[4];
                    u16AttribId <<= 8;
                    u16AttribId |= au8Data[5];

                    richTextBoxMessageView.Text += " (Write Attrib Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  EndPoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    displayClusterId(u16ClusterId);
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute ID: 0x" + u16AttribId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[6].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;
				
				case 0x8600:
                {
                    nwkRecovery.NetworkRecoveryParseBuffer(au8Data);
                    richTextBoxMessageView.Text += " (Retrieve Network Recovery Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += nwkRecovery.ToString();
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8601:
                {
                    richTextBoxMessageView.Text += " (Restore Network Recovery Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Success = " + au8Data[0];
                    richTextBoxMessageView.Text += "\n";
                }
                break;
				case 0x80A4:
				{
				    UInt16 u16GroupId;
                    UInt16 u16ClusterId;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    u16GroupId = au8Data[5];
                    u16GroupId <<= 8;
                    u16GroupId |= au8Data[6];

                    richTextBoxMessageView.Text += " (Store Scene Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Tx Num: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Source Endpoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Cluster ID: 0x" + u16ClusterId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[4].ToString("X2");
					richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Group ID: 0x" + u16GroupId.ToString("X4");
					richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Scene ID: 0x" + au8Data[7].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
				}
                break;

                case 0x80A6:
                {
                    UInt16 u16GroupId;
                    UInt16 u16ClusterId;

                    u16ClusterId = au8Data[2];
                    u16ClusterId <<= 8;
                    u16ClusterId |= au8Data[3];

                    u16GroupId = au8Data[6];
                    u16GroupId <<= 8;
                    u16GroupId |= au8Data[7];

                    richTextBoxMessageView.Text += " (Get Scene Membership Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Tx Num: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Source Endpoint: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Cluster ID: 0x" + u16ClusterId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Capacity: 0x" + au8Data[5].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Group ID: 0x" + u16GroupId.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Scene Count: 0x" + au8Data[8].ToString("X2");

                    if (au8Data[7] != 0)
                    {
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Scene List: ";
                    }

                    byte i;

                    for (i = 0; i < au8Data[8]; i++)
                    {

                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "    Scene: 0x" + au8Data[i+8].ToString("X2");
                    }
                    richTextBoxMessageView.Text += "\n";
                }
                break;
				case 0x8046:
				{
					UInt16 u16AddrOfInterest;
					
					u16AddrOfInterest = au8Data[2];
					u16AddrOfInterest <<= 8;
					u16AddrOfInterest |= au8Data[3];

                    richTextBoxMessageView.Text += " (Match Descriptor Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
					richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Address Of Interest: 0x" + u16AddrOfInterest.ToString("X4");
					richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Match Length: " + au8Data[4];

                    if (au8Data[4] != 0)
                    {
                        richTextBoxMessageView.Text += "  Matched Endpoints: ";
                    }

					byte i;
					for (i = 0; i < au8Data[4]; i++)
                    {
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "    Endpoint " + au8Data[5 + i].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
					}
				}
                break;
				case 0x8044:
				{
                    richTextBoxMessageView.Text += " (Power Descriptor Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
					richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Power Source Level: " + Convert.ToString(au8Data[2] & 0x7, 2).PadLeft(4, '0');
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Current Power Source: " + Convert.ToString((au8Data[2] >> 4) & 0x7, 2).PadLeft(4, '0');
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Available Power Source: " + Convert.ToString((au8Data[3]) & 0x7, 2).PadLeft(4, '0');
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Current Power Mode: " + Convert.ToString((au8Data[3] >> 4) & 0x7, 2).PadLeft(4, '0');
                    richTextBoxMessageView.Text += "\n";
				}
                break;

                case 0x8701:
                {
                    richTextBoxMessageView.Text += " (Route Discovery Confirm)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Network Status: 0x" + au8Data[2].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;
                case 0x8702:
                {
                    UInt16 u16DestAddr;

                    u16DestAddr = au8Data[5];
                    u16DestAddr <<= 8;
                    u16DestAddr |= au8Data[6];

                    richTextBoxMessageView.Text += " (APS Data Confirm Fail)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Source Endpoint: 0x" + au8Data[2].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Destination Endpoint: 0x" + au8Data[3].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Destination Mode: 0x" + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Destination Address: 0x" + au8Data[2].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                case 0x8531:
                {
                    UInt16 u16AddressOfInterest;

                    u16AddressOfInterest = au8Data[2];
                    u16AddressOfInterest <<= 8;
                    u16AddressOfInterest |= au8Data[3];

                    richTextBoxMessageView.Text += " (Complex Descriptor Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Address of Interest: 0x" + u16AddressOfInterest.ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Length: " + au8Data[4].ToString("X2");
                    richTextBoxMessageView.Text += "\n";

                    if (au8Data[1] == 0)
                    {
                        richTextBoxMessageView.Text += "        XML Tag: " + au8Data[5].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "        Field Count: " + au8Data[6].ToString("X2");
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "        Complex Description: ";
                        for (int i = 0; i < au8Data[6]; i++)
                        {
                            char c = (char)au8Data[6 + i + 1];
                            richTextBoxMessageView.Text += c.ToString();
                        }
                        richTextBoxMessageView.Text += "\n";
                    }                                       
                }
                break;

                case 0x8532:
                {
                    byte u8StrLen;
                    UInt16 u16NwkAddr = 0;

                    u16NwkAddr = au8Data[2];
                    u16NwkAddr <<= 8;
                    u16NwkAddr |= au8Data[3];
                    u8StrLen = au8Data[4];

                    richTextBoxMessageView.Text += " (User Descriptor Request Response)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Nwk Address: 0x" + u16NwkAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";

                    if (au8Data[1] == 0)
                    {
                        richTextBoxMessageView.Text += "  Length: " + u8StrLen.ToString();
                        richTextBoxMessageView.Text += "\n";
                        richTextBoxMessageView.Text += "  Descriptor: ";

                        for (int i = 0; i < u8StrLen; i++)
                        {
                            char c = (char)au8Data[5 + i];
                            richTextBoxMessageView.Text += c.ToString();
                        }
                        richTextBoxMessageView.Text += "\n";
                    }
                }
                break;

                case 0x8533:
                {
                    byte u8StrLen;
                    UInt16 u16NwkAddr = 0;

                    u16NwkAddr = au8Data[2];
                    u16NwkAddr <<= 8;
                    u16NwkAddr |= au8Data[3];
                    u8StrLen = au8Data[4];

                    richTextBoxMessageView.Text += " (User Descriptor Set Confirm)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  SQN: 0x" + au8Data[0].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Status: 0x" + au8Data[1].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Nwk Address: 0x" + u16NwkAddr.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                }
                break;

                default:
                {
                    richTextBoxMessageView.Text += " (Unrecognized)";
                    richTextBoxMessageView.Text += "\n";
                }
                break;
            }
        }

        private void displayAttribute(UInt16 u16AttribId, byte u8AttribType, byte[] au8AttribData, byte u8AttribIndex, UInt16 u16AttrSize)
        {
            richTextBoxMessageView.Text += "  Attribute ID: 0x" + u16AttribId.ToString("X4");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "  Attribute Size: 0x" + u16AttrSize.ToString("X4");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "  Attribute Type: 0x" + u8AttribType.ToString("X2");
            
            switch (u8AttribType)
            {
                case 0x10:
                    richTextBoxMessageView.Text += " (Boolean)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute Data: 0x" + au8AttribData[u8AttribIndex].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    break;
                case 0x18:
                    richTextBoxMessageView.Text += " (8-bit Bitmap)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute Data: 0x" + au8AttribData[u8AttribIndex].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    break;
                case 0x20:
                    richTextBoxMessageView.Text += " (UINT8)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute Data: 0x" + au8AttribData[u8AttribIndex].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    break;
                case 0x21:
                    UInt16 u16Data;
                    u16Data   = au8AttribData[u8AttribIndex];
                    u16Data <<= 8;
                    u16Data  |= au8AttribData[u8AttribIndex + 1];
                    richTextBoxMessageView.Text += " (UINT16)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute Data: 0x" + u16Data.ToString("X4");
                    richTextBoxMessageView.Text += "\n";
                    break;
                case 0x23:
                    UInt32 u32Data;
                    u32Data = au8AttribData[u8AttribIndex];
                    u32Data <<= 8;
                    u32Data |= au8AttribData[u8AttribIndex + 1];
                    u32Data <<= 8;
                    u32Data |= au8AttribData[u8AttribIndex + 2];
                    u32Data <<= 8;
                    u32Data |= au8AttribData[u8AttribIndex + 3];
                    richTextBoxMessageView.Text += " (UINT32)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute Data: 0x" + u32Data.ToString("X8");
                    richTextBoxMessageView.Text += "\n";
                    break;
                case 0x29: 
                    richTextBoxMessageView.Text += " (INT16)";
                    richTextBoxMessageView.Text += "\n";
                    break;
                case 0x30:
                    richTextBoxMessageView.Text += " (8-bit Enumeration)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute Data: 0x" + au8AttribData[u8AttribIndex].ToString("X2");
                    richTextBoxMessageView.Text += "\n";
                    break;
                case 0x42:
                    richTextBoxMessageView.Text += " (Character String)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute Data (Len - " + u16AttrSize.ToString() + "): ";
                    for (int i = 0; i < u16AttrSize; i++)
                    {
                        char c = (char)au8AttribData[u8AttribIndex + i];
                        richTextBoxMessageView.Text += c.ToString();
                    }                    
                    richTextBoxMessageView.Text += "\n";
                    break;
                case 0xF0:
                    richTextBoxMessageView.Text += " (IEEE Address)";
                    richTextBoxMessageView.Text += "\n";
                    richTextBoxMessageView.Text += "  Attribute Data: " + au8AttribData[u8AttribIndex].ToString("X2");
                    richTextBoxMessageView.Text += ":" + au8AttribData[u8AttribIndex + 1].ToString("X2");
                    richTextBoxMessageView.Text += ":" + au8AttribData[u8AttribIndex + 2].ToString("X2");
                    richTextBoxMessageView.Text += ":" + au8AttribData[u8AttribIndex + 3].ToString("X2");
                    richTextBoxMessageView.Text += ":" + au8AttribData[u8AttribIndex + 4].ToString("X2");
                    richTextBoxMessageView.Text += ":" + au8AttribData[u8AttribIndex + 5].ToString("X2");
                    richTextBoxMessageView.Text += ":" + au8AttribData[u8AttribIndex + 6].ToString("X2");
                    richTextBoxMessageView.Text += ":" + au8AttribData[u8AttribIndex + 7].ToString("X2");                    
                    richTextBoxMessageView.Text += "\n";
                    break;
                default:
                    richTextBoxMessageView.Text += " (Unknown)";
                    richTextBoxMessageView.Text += "\n";
                    break;
            }                        
        }

        private void displayMACcapability(byte u8Capability)
        {
            richTextBoxMessageView.Text += "  MAC Capability: 0x" + u8Capability.ToString("X2");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "    Alternate PAN Coordinator: " + (((u8Capability & 0x01) == 0) ? "False" : "True");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "    Device Type: " + (((u8Capability & 0x02) == 0) ? "End Device" : "Router");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "    Power Source: " + (((u8Capability & 0x04) == 0) ? "Battery" : "AC");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "    Receiver On When Idle: " + (((u8Capability & 0x08) == 0) ? "False" : "True");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "    Security Capability: " + (((u8Capability & 0x40) == 0) ? "Standard" : "High");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "    Allocate Address: " + (((u8Capability & 0x80) == 0) ? "False" : "True");
            richTextBoxMessageView.Text += "\n";        
        }

        private void displayDescriptorCapability(byte u8Capability)
        {
            richTextBoxMessageView.Text += "  Descriptor Capability: 0x" + u8Capability.ToString("X2");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "    Ext Active EP List: " + (((u8Capability & 0x01) == 0) ? "No" : "Yes");
            richTextBoxMessageView.Text += "\n";
            richTextBoxMessageView.Text += "    Ext Simple Desc List: " + (((u8Capability & 0x02) == 0) ? "No" : "Yes");
            richTextBoxMessageView.Text += "\n";
        }

        private void displayDeviceId(UInt16 u16DeviceId)
        {
            Dictionary<int, string> deviceList = new Dictionary<int, string>();
            deviceList.Add(0x0000, " (Generic - On/Off Switch)");
            deviceList.Add(0x0001, " (Generic - Level Control Switch)");
            deviceList.Add(0x0002, " (Generic - On/Off Output)");
            deviceList.Add(0x0003, " (Generic - Level Controlable Output)");
            deviceList.Add(0x0004, " (Generic - Scene Selector)");
            deviceList.Add(0x0005, " (Generic - Configuration Tool)");
            deviceList.Add(0x0006, " (Generic - Remote Control)");
            deviceList.Add(0x0007, " (Generic - Combined Interface)");
            deviceList.Add(0x0008, " (Generic - Range Extender)");
            deviceList.Add(0x0009, " (Generic - Mains Power Outlet)");
            deviceList.Add(0x000C, " (Generic - Simple Sensor)");
            deviceList.Add(0x0051, " (Generic - Smart Plug)");
            deviceList.Add(0x0100, " (Lighting - On/Off Light)");
            deviceList.Add(0x0101, " (Lighting - Dimmable Light)");
            deviceList.Add(0x0102, " (Lighting - Color Dimmable Light)");
            deviceList.Add(0x0103, " (Lighting - On/Off Light Switch)");
            deviceList.Add(0x0104, " (Lighting - Dimmer Switch)");
            deviceList.Add(0x0105, " (Lighting - Color Dimmer Switch)");
            deviceList.Add(0x0106, " (Lighting - Light Sensor)");
            deviceList.Add(0x0107, " (Lighting - Occupancy Sensor)");
            deviceList.Add(0x0500, " (IAS - IAS Zone)");
            deviceList.Add(0x0501, " (IAS - IAS ACE)");
            deviceList.Add(0x0502, " (IAS - IAS WD)");

            
                                    
            richTextBoxMessageView.Text += "  Device ID: 0x" + u16DeviceId.ToString("X4");

            // The indexer throws an exception if the requested key is 
            // not in the dictionary. 
            try
            {
                richTextBoxMessageView.Text += deviceList[u16DeviceId];
            }
            catch (KeyNotFoundException)
            {
                richTextBoxMessageView.Text += " (Unknown)";
            }
        }

        private void displayProfileId(UInt16 u16ProfileId)
        {
            Dictionary<int, string> profileList = new Dictionary<int, string>();
            profileList.Add(0x0104, " (ZigBee HA)");
            profileList.Add(0xC05E, " (ZigBee LL)");

            richTextBoxMessageView.Text += "  Profile ID: 0x" + u16ProfileId.ToString("X4");

            // The indexer throws an exception if the requested key is 
            // not in the dictionary. 
            try
            {
                richTextBoxMessageView.Text += profileList[u16ProfileId];
            }
            catch (KeyNotFoundException)
            {
                richTextBoxMessageView.Text += " (Unknown)";
            }
        }

        private void displayClusterId(UInt16 u16ClusterId)
        {
            Dictionary<int, string> clusterList = new Dictionary<int, string>();
            clusterList.Add(0x0000, " (General: Basic)");
            clusterList.Add(0x0001, " (General: Power Config)");
            clusterList.Add(0x0002, " (General: Temperature Config)");
            clusterList.Add(0x0003, " (General: Identify)");
            clusterList.Add(0x0004, " (General: Groups)");
            clusterList.Add(0x0005, " (General: Scenes)");
            clusterList.Add(0x0006, " (General: On/Off)");
            clusterList.Add(0x0007, " (General: On/Off Config)");
            clusterList.Add(0x0008, " (General: Level Control)");
            clusterList.Add(0x0009, " (General: Alarms)");
            clusterList.Add(0x000A, " (General: Time)");
            clusterList.Add(0x000F, " (General: Binary Input Basic)");
            clusterList.Add(0x0019, " (General: OTA)");
            clusterList.Add(0x0101, " (General: Door Lock");
            clusterList.Add(0x0300, " (Lighting: Color Control)");
            clusterList.Add(0x0400, " (Measurement: Illuminance)");
            clusterList.Add(0x0402, " (Measurement: Temperature)");
            clusterList.Add(0x0406, " (Measurement: Occupancy Sensing)");
            clusterList.Add(0x0500, " (Security & Safety: IAS Zone)");
            clusterList.Add(0x0702, " (Smart Energy: Metering)");
            clusterList.Add(0x0B05, " (Misc: Diagnostics)");
            clusterList.Add(0x1000, " (ZLL: Commissioning)");

            richTextBoxMessageView.Text += "  Cluster ID: 0x" + u16ClusterId.ToString("X4");
            
            // The indexer throws an exception if the requested key is 
            // not in the dictionary. 
            try
            {
                richTextBoxMessageView.Text += clusterList[u16ClusterId];
            }
            catch (KeyNotFoundException)
            {
                richTextBoxMessageView.Text += " (Unknown)";
            }
        }

        private void displayDataType(byte u8Type)
        {
            Dictionary<byte, string> typeList = new Dictionary<byte, string>();
            typeList.Add(0x00, " (Null: No Data)");
            typeList.Add(0x10, " (Logical: Boolean)");
            typeList.Add(0x20, " (Unisgned Integer: UINT8)");
            typeList.Add(0x21, " (Unisgned Integer: UINT16)");
            typeList.Add(0x25, " (Unisgned Integer: UINT48)");
            typeList.Add(0x30, " (Enumeration: 8-bit)");
            typeList.Add(0x42, " (String: Character String)");

            richTextBoxMessageView.Text += "  Data Type: 0x" + u8Type.ToString("X2");

            // The indexer throws an exception if the requested key is 
            // not in the dictionary. 
            try
            {
                richTextBoxMessageView.Text += typeList[u8Type];
            }
            catch (KeyNotFoundException)
            {
                richTextBoxMessageView.Text += " (Unknown)";
            }
        }

        #endregion 

        #region serial receive functions

        private byte[] rxMessageData   = new byte[1024];
        private byte rxMessageChecksum = 0;
        private UInt16 rxMessageLength = 0;
        private uint rxMessageState    = 0;
        private UInt16 rxMessageType = 0;
        private uint rxMessageCount    = 0;
        private bool rxMessageInEscape = false;
        
        // Serial port event handlder 
        private void serialPort1_DataReceivedHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.BytesToRead > 0)
            {
                byte rxByte = (byte)serialPort1.ReadByte();

                if (rxByte == 0x01)
                {
                    // Start character received
                    rxMessageChecksum = 0;
                    rxMessageLength   = 0;
                    rxMessageType     = 0;
                    rxMessageState    = 0;
                    rxMessageCount    = 0;
                    rxMessageInEscape = false;
                }
                else if (rxByte == 0x02)
                {
                    rxMessageInEscape = true;
                }
                else if (rxByte == 0x03)
                {
                    // instantiate the delegate to be invoked by this thread
                    messageParser = new MessageParser(myMessageParser);

                    // invoke the delegate in the MainForm thread
                    this.Invoke(messageParser);
                }
                else
                {
                    if (rxMessageInEscape == true)
                    {
                        rxByte ^= 0x10;
                        rxMessageInEscape = false;
                    }
                    
                    // Parse character
                    switch (rxMessageState)
                    {
                        case 0:
                        {
                            rxMessageType = rxByte;
                            rxMessageType <<= 8;
                            rxMessageState++;
                        }
                        break;

                        case 1:
                        {
                            rxMessageType |= rxByte;
                            rxMessageState++;
                        }
                        break;

                        case 2:
                        {
                            rxMessageLength = rxByte;
                            rxMessageLength <<= 8;
                            rxMessageState++;
                        }
                        break;

                        case 3:
                        {
                            rxMessageLength |= rxByte;
                            rxMessageState++;
                        }
                        break;

                        case 4:
                        {
                            rxMessageChecksum = rxByte;
                            rxMessageState++;
                        }
                        break;

                        default:
                        {
                            rxMessageData[rxMessageCount++] = rxByte;
                        }
                        break;
                    }
                }
            }
        }

        private void displayRawCommandData(UInt16 u16Type, UInt16 u16Length, byte u8Checksum, byte[] au8Data)
        {
            byte tempByte;
            /* Dont display OTA block request/response as it slows down the process!! */
            if ((u8OtaInProgress == 0) || ((u16Type != 0x8000) && (u16Type != 0x8501) && (u16Type != 0x0502)))
            {
                richTextBoxCommandResponse.Text += DateTime.Now.Hour.ToString("D2");
                richTextBoxCommandResponse.Text += ":";
                richTextBoxCommandResponse.Text += DateTime.Now.Minute.ToString("D2");
                richTextBoxCommandResponse.Text += ":";
                richTextBoxCommandResponse.Text += DateTime.Now.Second.ToString("D2");
                richTextBoxCommandResponse.Text += ".";
                richTextBoxCommandResponse.Text += DateTime.Now.Millisecond.ToString("D3");
                richTextBoxCommandResponse.Text += " <- ";
                richTextBoxCommandResponse.Text += "01 ";

                if (u16Type != 0x8501)
                {
                    tempByte = (byte)(u16Type >> 8);
                    richTextBoxCommandResponse.Text += tempByte.ToString("X2");
                    richTextBoxCommandResponse.Text += " ";
                    tempByte = (byte)u16Type;
                    richTextBoxCommandResponse.Text += tempByte.ToString("X2");
                    richTextBoxCommandResponse.Text += " ";

                    tempByte = (byte)(u16Length >> 8);
                    richTextBoxCommandResponse.Text += tempByte.ToString("X2");
                    richTextBoxCommandResponse.Text += " ";
                    tempByte = (byte)u16Length;
                    richTextBoxCommandResponse.Text += tempByte.ToString("X2");
                    richTextBoxCommandResponse.Text += " ";

                    richTextBoxCommandResponse.Text += u8Checksum.ToString("X2");
                    richTextBoxCommandResponse.Text += " ";

                    for (int i = 0; i < u16Length; i++)
                    {
                        richTextBoxCommandResponse.Text += au8Data[i].ToString("X2");
                        richTextBoxCommandResponse.Text += " ";
                    }

                    richTextBoxCommandResponse.Text += "03";
                    richTextBoxCommandResponse.Text += "\n";
                }
            }
        }
        #endregion

        #region message display windows

        private void buttonClearRaw_Click(object sender, EventArgs e)
        {
            richTextBoxCommandResponse.Text = "";
        }

        private void buttonMessageViewClear_Click(object sender, EventArgs e)
        {
            richTextBoxMessageView.Text = "";
        }
        #endregion

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxConfigReportAttribDirection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBasicResetTargetAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            UInt64 u64ExtAddr = 0;

            if (bStringToUint64(textBoxLeaveAddr.Text, out u64ExtAddr) == true)
            {
                sendLeaveRequest(u64ExtAddr, (byte)comboBoxLeaveReJoin.SelectedIndex, (byte)comboBoxLeaveChildren.SelectedIndex);
            }
        }

        private void buttonRemoveDevice_Click(object sender, EventArgs e)
        {
            UInt64 u64ParentExtAddr = 0;
            UInt64 u64ChildExtAddr = 0;

            if (bStringToUint64(textBoxRemoveParentAddr.Text, out u64ParentExtAddr) == true)
            {
                if (bStringToUint64(textBoxRemoveChildAddr.Text, out u64ChildExtAddr) == true)
                {
                    sendRemoveRequest(u64ParentExtAddr, u64ChildExtAddr);
                }
            }
        }

        private void buttonRawDataSend_Click(object sender, EventArgs e)
        {
            UInt16 u16TargetAddr;
            UInt16 u16ClusterID;
            UInt16 u16ProfileID;
            byte u8SecurityMode, u8Radius;
            byte u8SrcEndPoint;
            byte u8DstEndPoint;
            String stringRawData = "";

            if (bStringToUint16(textBoxRawDataCommandsTargetAddr.Text, out u16TargetAddr) == true)
            {
                if (bStringToUint8(textBoxRawDataCommandsSrcEP.Text, out u8SrcEndPoint) == true)
                {
                    if (bStringToUint8(textBoxRawDataCommandsDstEP.Text, out u8DstEndPoint) == true)
                    {
                        if (bStringToUint16(textBoxRawDataCommandsProfileID.Text, out u16ProfileID) == true)
                        {
                            if (bStringToUint16(textBoxRawDataCommandsClusterID.Text, out u16ClusterID) == true)
                            {
                                if (bStringToUint8(textBoxRawDataCommandsSecurityMode.Text, out u8SecurityMode) == true)
                                {
                                    if (bStringToUint8(textBoxRawDataCommandsRadius.Text, out u8Radius) == true)
                                    {
                                        if (0 == (textBoxRawDataCommandsData.TextLength % 2))
                                        {
                                            stringRawData = textBoxRawDataCommandsData.Text;
                                            sendRawDataCommandsRequest((byte)comboBoxRawDataCommandsAddrMode.SelectedIndex, u16TargetAddr, u8SrcEndPoint, u8DstEndPoint, u16ProfileID, u16ClusterID, u8SecurityMode, u8Radius, stringRawData);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid Parameter");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        private void buttonInPacketNotification_Click(object sender, EventArgs e)
        {
            UInt32 u32RfActiveOutDioMask;
            UInt32 u32StatusOutDioMask;
            UInt32 u32TxConfInDioMask;
            UInt16 u16PollPeriod;

            if (bStringToUint32(textBoxIPNConfigDioRfActiveOutDioMask.Text, out u32RfActiveOutDioMask) == true)
            {
                if (bStringToUint32(textBoxIPNConfigDioStatusOutDioMask.Text, out u32StatusOutDioMask) == true)
                {
                    if (bStringToUint32(textBoxIPNConfigDioTxConfInDioMask.Text, out u32TxConfInDioMask) == true)
                    {
                        if (bStringToUint16(textBoxIPNConfigPollPeriod.Text, out u16PollPeriod) == true)
                        {
                            sendIPNConfigureCommand((byte)comboBoxIPNConfigEnable.SelectedIndex, u32RfActiveOutDioMask, u32StatusOutDioMask, u32TxConfInDioMask, (byte)comboBoxIPNConfigRegisterCallback.SelectedIndex, u16PollPeriod, (byte)comboBoxIPNConfigTimerId.SelectedIndex);
                        }
                    }
                }
            }
        }

        private void buttonDioSetDirection_Click(object sender, EventArgs e)
        {
            UInt32 u32InputDIOMask;
            UInt32 u32OutputDIOMask;

            if (bStringToUint32(textBoxDioSetDirectionInputPinMask.Text, out u32OutputDIOMask) == true)
            {
                if (bStringToUint32(textBoxDioSetDirectionOutputPinMask.Text, out u32InputDIOMask) == true)
                {
                    sendDioSetDirectionOutputCommand(0x0801, u32InputDIOMask, u32OutputDIOMask);
                }
            }
        }

        private void buttonDioSetOutput_Click(object sender, EventArgs e)
        {
            UInt32 u32InputDIOMask;
            UInt32 u32OutputDIOMask;

            if (bStringToUint32(textBoxDioSetOutputOnPinMask.Text, out u32OutputDIOMask) == true)
            {
                if (bStringToUint32(textBoxDioSetOutputOffPinMask.Text, out u32InputDIOMask) == true)
                {
                    sendDioSetDirectionOutputCommand(0x0802, u32InputDIOMask, u32OutputDIOMask);
                }
            }
        }

        #region Mouse Hover/Leave

        #region ManagementTab

        #region SetEPID
        private void textBoxSetEPID_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Extended PAN ID to be used (64-bit Hex)");
        }
        
        private void textBoxSetEPID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }
        #endregion
        
        #region SetCMSK
        private void textBoxSetCMSK_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Channel value (32-bit). Can be either Hex of Channel Mask or Single Decimal Channel");
        }

        private void textBoxSetCMSK_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }
        #endregion
        
        #region ManagementLeave

        private void textBoxMgmtLeaveAddr_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Destination address where the command will go (16-bit Hex)");
        }

        private void textBoxMgmtLeaveAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }


        private void textBoxMgmtLeaveExtAddr_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Device which is requested to leave (64-bit Hex)");
        }

        private void textBoxMgmtLeaveExtAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region Leave
        private void textBoxLeaveAddr_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Device which is requested to leave (64-bit Hex)");
        }
        private void textBoxLeaveAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region RemoveDevice
        private void textBoxRemoveParentAddr_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Parent address of the device to be removed (64-bit Hex)");
        }

        private void textBoxRemoveParentAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxRemoveChildAddr_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Address of the device to be removed (64-bit Hex)");
        }

        private void textBoxRemoveChildAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region PermitJoin
        private void textBoxPermitJoinAddr_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Address to set permit join value (8 bit-Hex)");
        }

        private void textBoxPermitJoinAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxPermitJoinInterval_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Permit join value (8-bit Hex)");
        }

        private void textBoxPermitJoinInterval_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region MatchDescriptorRequest

        private void textBoxMatchReqAddr_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address for the Match Descriptor Request (16-bit Hex)");
        }

        private void textBoxMatchReqAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxMatchReqProfileID_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Profile ID (16-bit Hex)");
        }

        private void textBoxMatchReqProfileID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxMatchReqNbrInputClusters_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Number of Intput Clusters (8-bit Hex)");
        }

        private void textBoxMatchReqNbrInputClusters_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxMatchReqInputClusters_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Input Cluster List (Array 16-bit Hex e.g. 00050010)");
        }

        private void textBoxMatchReqInputClusters_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxMatchReqNbrOutputClusters_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Number of Output Clusters (8-bit Hex)");
        }

        private void textBoxMatchReqNbrOutputClusters_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxMatchReqOutputClusters_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Output Cluster List (Array 16-bit Hex e.g. 00050010)");
        }

        private void textBoxMatchReqOutputClusters_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region BindRequest

        private void textBoxBindTargetExtAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("The Address the Request is Going to (32-bit Hex)");
        }

        private void textBoxBindTargetExtAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxBindTargetEP_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Endpoint Number the Request is going to (8-bit Hex)");
        }

        private void textBoxBindTargetEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxBindClusterID_MouseHover(object sender, EventArgs e)
        {
            showToolTipWindow("Cluster ID which will be put into the Binding Table (16-bit Hex)");
        }

        private void textBoxBindClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxBindAddrMode_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address Mode (8-bit Hex)");
        }

        private void comboBoxBindAddrMode_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxBindDestAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address which will be put into the binding table (32-bit Hex)");
        }

        private void textBoxBindDestAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxBindDestEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Endpoint Number which will be put into the binding table (32-bit Hex)");
        }

        private void textBoxBindDestEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region UnbindRequest

        private void textBoxUnBindTargetExtAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("The Address the Request is Going to (32-bit Hex)");
        }

        private void textBoxUnBindTargetExtAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxUnBindTargetEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Endpoint Number the Request is going to (8-bit Hex)");
        }

        private void textBoxUnBindTargetEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxUnBindClusterID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Cluster ID which will be removed from the Binding Table (16-bit Hex)");
        }

        private void textBoxUnBindClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxUnBindAddrMode_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address Mode (8-bit Hex)");
        }

        private void comboBoxUnBindAddrMode_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxUnBindDestAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address which will be removed from the binding table (32-bit Hex)");
        }

        private void textBoxUnBindDestAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxUnBindDestEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Endpoint Number which will be removed from the binding table (32-bit Hex)");
        }

        private void textBoxUnBindDestEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region ActiveEndpointRequest

        private void textBoxActiveEpAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxActiveEpAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region IEEERequest

        private void textBoxIeeeReqTargetAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address request will be sent to (16-bit Hex)");
        }

        private void textBoxIeeeReqTargetAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxIeeeReqAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("The short address associated with the requested IEEE address (16-bit Hex)");
        }

        private void textBoxIeeeReqAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxIeeeReqType_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Single for IEEE address of target\nExtended for IEEE address of target and neighbours");
        }

        private void comboBoxIeeeReqType_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxIeeeReqStartIndex_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Neighbour table index of the first neighbouring node to be included in the response (8-Bit Hex)");
        }

        private void textBoxIeeeReqStartIndex_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion 

        #region NetworkAddressRequest

        private void textBoxNwkAddrReqTargetAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address the request will be sent to (16-bit Hex)");
        }


        private void textBoxNwkAddrReqTargetAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxNwkAddrReqExtAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address associated with the short address required (32-bit Hex)");
        }

        private void textBoxNwkAddrReqExtAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxNwkAddrReqType_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Single for IEEE address of target\nExtended for IEEE address of target and neighbours");
        }

        private void comboBoxNwkAddrReqType_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxNwkAddrReqStartIndex_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Neighbour table index of the first neighbouring node to be included in the response (8-Bit Hex)");
        }

        private void textBoxNwkAddrReqStartIndex_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region NodeDescriptorRequest

        private void textBoxNodeDescReq_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxNodeDescReq_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region PowerDescriptorRequest

        private void textBoxPowerReqAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxPowerReqAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region SimpleDescriptorRequest

        private void textBoxSimpleReqAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxSimpleReqAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxSimpleReqEndPoint_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Endpoint Number (8-bit Hex)");
        }

        private void textBoxSimpleReqEndPoint_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region ComplexDescriptorRequest

        private void textBoxComplexReqAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxComplexReqAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxLqiReqTargetAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxLqiReqTargetAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxLqiReqStartIndex_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Starting index in the neighbour table (8-bit Hex)");
        }

        private void textBoxLqiReqStartIndex_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region UserDescriptorRequest

        private void textBoxUserReqAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxUserReqAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region UserDescriptorSetRequest

        private void textBoxUserSetReqAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxUserSetReqAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxUserSetReqDescription_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("User Description (String)");
        }

        private void textBoxUserSetReqDescription_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region NetworkRestoreRequest

        private void textBoxRestoreNwkFrameCounter_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Outgoing frame counter value to start from (16-bit Hex)");
        }

        private void textBoxRestoreNwkFrameCounter_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #endregion

        #region GeneralTab
        
        #region ReadAttributeRequest

        private void textBoxReadAttribTargetAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }


        private void textBoxReadAttribTargetAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAttribSrcEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Source Endpoint (8-bit Hex)");
        }

        private void textBoxReadAttribSrcEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAttribDstEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Endpoint (8-bit Hex)");
        }

        private void textBoxReadAttribDstEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAttribClusterID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Cluster ID (16-bit Hex)");
        }

        private void textBoxReadAttribClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxReadAttribDirection_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Server or Client Attribute");
        }

        private void comboBoxReadAttribDirection_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAttribCount_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Number of attributes to read (8-bit Hex)");
        }

        private void textBoxReadAttribCount_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAttribID1_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Attribute ID to be read (16-bit Hex)");
        }

        private void textBoxReadAttribID1_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxReadAttribManuSpecific_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Standard or Manufacturer Specific");
        }

        private void comboBoxReadAttribManuSpecific_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAttribManuID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Manufacturer Code (16-bit Hex)");
        }

        private void textBoxReadAttribManuID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }
        #endregion 

        #region WriteAttributeRequest

        private void textBoxWriteAttribTargetAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxWriteAttribTargetAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxWriteAttribSrcEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Source Endpoint (8-bit Hex)");
        }

        private void textBoxWriteAttribSrcEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxWriteAttribDstEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Endpoint (8-bit Hex)");
        }

        private void textBoxWriteAttribDstEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxWriteAttribClusterID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Cluster ID (16-bit Hex)");
        }

        private void textBoxWriteAttribClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxWriteAttribDirection_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Server or Client attribute");
        }

        private void comboBoxWriteAttribDirection_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxWriteAttribID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Attribute ID (16-bit Hex)");
        }

        private void textBoxWriteAttribID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxWriteAttribDataType_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Attribute ID (16-bit Hex)");
        }

        private void textBoxWriteAttribDataType_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxWriteAttribData_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Attribute Data");
        }

        private void textBoxWriteAttribData_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxWriteAttribManuSpecific_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Standard or Manufacturer specific attribute");
        }

        private void comboBoxWriteAttribManuSpecific_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxWriteAttribManuID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Manufacturer Code (16-bit Hex)");
        }

        private void textBoxWriteAttribManuID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }
        #endregion

        #region ConfigureReportingRequest

        private void comboBoxConfigReportAddrMode_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address Mode");
        }

        private void comboBoxConfigReportAddrMode_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportTargetAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxConfigReportTargetAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportSrcEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Source Endpoint (8-bit Hex)");
        }

        private void textBoxConfigReportSrcEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportDstEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Endpoint (16-bit Hex)");
        }

        private void textBoxConfigReportDstEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportClusterID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Cluster ID (16-bit Hex)");
        }

        private void textBoxConfigReportClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxConfigReportDirection_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Server or Client Attribute");
        }

        private void comboBoxConfigReportDirection_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxConfigReportAttribDirection_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Whether it will be sent by the server or recived by the client");
        }

        private void comboBoxConfigReportAttribDirection_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportAttribType_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Attribute Type (8-bit Hex)");
        }

        private void textBoxConfigReportAttribType_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportAttribID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Attribute ID (16-bit Hex)");
        }

        private void textBoxConfigReportAttribID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportMinInterval_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Minimum Interval e.g. On Change Time (16-bit Hex)");
        }

        private void textBoxConfigReportMinInterval_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportMaxInterval_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Maximum Interval e.g Periodic Report Time (16-bit Hex)");
        }

        private void textBoxConfigReportMaxInterval_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportTimeOut_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("How often a client will expect a report (16-bit Hex)");
        }

        private void textBoxConfigReportTimeOut_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxConfigReportChange_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Minimum change required before a On Change report is generated (8-bit Hex)");
        }

        private void textBoxConfigReportChange_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region ReadReportRequest

        private void comboBoxReadReportConfigAddrMode_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Address Mode");
        }

        private void comboBoxReadReportConfigAddrMode_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadReportConfigTargetAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxReadReportConfigTargetAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadReportConfigSrcEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Source Endpoint (8-bit Hex)");
        }

        private void textBoxReadReportConfigSrcEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadReportConfigDstEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Endpoint (8-bit Hex)");
        }

        private void textBoxReadReportConfigDstEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadReportConfigClusterID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Cluster ID (16-bit Hex)");
        }

        private void textBoxReadReportConfigClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxReadReportConfigDirection_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("To Server or Client");
        }

        private void comboBoxReadReportConfigDirection_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadReportConfigAttribID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Attribute ID (16-bit Hex)");
        }

        private void textBoxReadReportConfigAttribID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxReadReportConfigDirIsRx_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Whether it is for a device that is sending report or receiving them");
        }

        private void comboBoxReadReportConfigDirIsRx_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region ReadAllAttributeRequest

        private void textBoxReadAllAttribAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxReadAllAttribAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAllAttribSrcEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Source Endpoint (8-bit Hex)");
        }

        private void textBoxReadAllAttribSrcEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAllAttribDstEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Endpoint (8-bit Hex)");
        }

        private void textBoxReadAllAttribDstEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxReadAllAttribClusterID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Cluster ID (16-bit Hex)");
        }

        private void textBoxReadAllAttribClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxReadAllAttribDirection_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("To Server or Client");
        }

        private void comboBoxReadAllAttribDirection_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region Discover Attribute Request

        private void textBoxDiscoverAttributesAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxDiscoverAttributesAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxDiscoverAttributesSrcEp_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Source Endpoint (8-bit Hex)");
        }

        private void textBoxDiscoverAttributesSrcEp_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxDiscoverAttributesDstEp_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Endpoint (8-bit Hex)");
        }

        private void textBoxDiscoverAttributesDstEp_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxDiscoverAttributesStartAttrId_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Start Attr ID (8-bit Hex)");
        }

        private void textBoxDiscoverAttributesStartAttrId_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxDiscoverAttributesClusterID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Cluster ID (16-bit Hex)");
        }

        private void textBoxDiscoverAttributesClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxDiscoverAttributesDirection_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Attribute Direction");
        }

        private void comboBoxDiscoverAttributesDirection_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxDiscoverAttributesMaxIDs_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Number Of Attributes (8-bit Hex)");
        }

        private void textBoxDiscoverAttributesMaxIDs_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void comboBoxDiscoverAttributesExtended_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Standard or Extended");
        }

        private void comboBoxDiscoverAttributesExtended_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region Raw Data Send

        private void textBoxRawDataCommandsTargetAddr_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Address (16-bit Hex)");
        }

        private void textBoxRawDataCommandsTargetAddr_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxRawDataCommandsSrcEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Source Endpoint (8-bit Hex)");
        }

        private void textBoxRawDataCommandsSrcEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxRawDataCommandsProfileID_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Profile ID (16-bit Hex)");
        }

        private void textBoxRawDataCommandsProfileID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxRawDataCommandsDstEP_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Destination Endpoint (8-bit Hex)");
        }

        private void textBoxRawDataCommandsDstEP_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxRawDataCommandsClusterID_MouseEnter(object sender, EventArgs e)
        {

            showToolTipWindow("Cluster ID (16-bit Hex)");
        }

        private void textBoxRawDataCommandsClusterID_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxRawDataCommandsRadius_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Radius/Max Number Of Hops (8-bit Hex)");
        }

        private void textBoxRawDataCommandsRadius_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxRawDataCommandsSecurityMode_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Security Mode (8-bit Hex) - See zps_apl_af.h enum ZPS_teAplAfSecurityMode)");
        }

        private void textBoxRawDataCommandsSecurityMode_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxRawDataCommandsData_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Raw APS data (Array of 8-Bit Hex e.g 00:11:22:33)");
        }

        private void textBoxRawDataCommandsData_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }
        #endregion

        #endregion

        #region AHITab

        #region IPNConfigure

        private void comboBoxIPNConfigEnable_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Boolean to Enable IPN");
        }

        private void comboBoxIPNConfigEnable_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxIPNConfigDioInputPinMask_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("DIO Input Mask (32-Bit Hex)");
        }

        private void textBoxIPNConfigDioInputPinMask_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxIPNConfigDioOutputPinMask_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("DIO Output Mask (32-Bit Hex)");
        }

        private void textBoxIPNConfigDioOutputPinMask_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }
        
        private void comboBoxIPNConfigRegisterCallback_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Enable IPN callback on state change");
        }

        private void comboBoxIPNConfigRegisterCallback_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxIPNConfigPollPeriod_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("Poll period, units of 62500Hz clock (16-Bit Hex)");
        }

        private void textBoxIPNConfigPollPeriod_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }
        #endregion

        #region DIOSetDirection

        private void textBoxDioSetDirectionInputPinMask_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("DIO Input Mask (32-Bit Hex)");
        }

        private void textBoxDioSetDirectionInputPinMask_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxDioSetDirectionOutputPinMask_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("DIO Output Mask (32-Bit Hex)");
        }

        private void textBoxDioSetDirectionOutputPinMask_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion

        #region DIOSetOutput

        private void textBoxDioSetOutputOnPinMask_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("DIO Input On Mask (32-Bit Hex)");
        }

        private void textBoxDioSetOutputOnPinMask_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        private void textBoxDioSetOutputOffPinMask_MouseEnter(object sender, EventArgs e)
        {
            showToolTipWindow("DIO Output Off Mask (32-Bit Hex)");
        }

        private void textBoxDioSetOutputOffPinMask_MouseLeave(object sender, EventArgs e)
        {
            hideToolTipWindow();
        }

        #endregion
        #endregion

        #endregion

        #region Text Change

        private void textBoxRawDataCommandsData_TextChanged(object sender, EventArgs e)
        {
            String rawData = "";
            int iRawDataSize;

            rawData = textBoxRawDataCommandsData.Text;

            rawData = rawData.Replace(" ", "");
            rawData = rawData.Replace(":", "");

            iRawDataSize = rawData.Length;
            for (int i = iRawDataSize; i > 0; i--)
            {
                if ((i % 2) == 0)
                {
                    if (i != iRawDataSize)
                    {
                        rawData = rawData.Insert(i, ":");
                    }
                }
            }

            textBoxRawDataCommandsData.Text = rawData;
            textBoxRawDataCommandsData.SelectionStart = textBoxRawDataCommandsData.Text.Length;
        }

        #endregion

        #region List Management

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            if (listManager.ShowDialog() == DialogResult.OK)
            {

            }
        }

        #endregion















    }



}
