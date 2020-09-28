using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibUsbDotNet;
using LibUsbDotNet.Info;
using LibUsbDotNet.Main;
using System.Collections.ObjectModel;
using System.Threading;
using System.IO;
using System.Globalization;
using static PTN3460I_Configurator.USB;
using static PTN3460I_Configurator.CRC;
using System.Diagnostics;
using System.Management;

namespace PTN3460I_Configurator
{
    public partial class Form_MainForm : Form
    {
        static Form_EDIDbitsForm my_Form_EDIDbitsForm = new Form_EDIDbitsForm();
        
        class BitState
        {

            public const byte LOW = 0;
            public const byte OPEN = 1;
            public const byte HIGH = 2;

            public static byte[] configuration_bits = { 1, 1, 1, 1, 1, 1, 1, 215 };

            public static void GetConfig(RadioButton[][] radioButtons)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (radioButtons[i][0].Checked == true) configuration_bits[i] = LOW;
                    if (radioButtons[i][1].Checked == true) configuration_bits[i] = OPEN;
                    if (radioButtons[i][2].Checked == true) configuration_bits[i] = HIGH;
                }
            }
            public static void UncheckRadiobuttons(RadioButton[][] radioButtons)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (radioButtons[i][0].Checked == true) radioButtons[i][0].Checked = false;
                    if (radioButtons[i][1].Checked == true) radioButtons[i][1].Checked = false;
                    if (radioButtons[i][2].Checked == true) radioButtons[i][2].Checked = false;
                }
            }

            public static void SetDefaultRadioButtonsState(RadioButton[][] radioButtons)
            {
                int i = 0;
                while (i != 7)
                {
                    switch (i)
                    {
                        case 0:
                            radioButtons[i][0].Checked = false;
                            radioButtons[i][1].Checked = false;
                            radioButtons[i][2].Checked = true;
                            i++;
                            break;
                        case 1:
                            radioButtons[i][0].Checked = true;
                            radioButtons[i][1].Checked = false;
                            radioButtons[i][2].Checked = false;
                            i++;
                            break;
                        case 2:
                            radioButtons[i][0].Checked = true;
                            radioButtons[i][1].Checked = false;
                            radioButtons[i][2].Checked = false;
                            i++;
                            break;
                        case 3:
                            radioButtons[i][0].Checked = false;
                            radioButtons[i][1].Checked = false;
                            radioButtons[i][2].Checked = true;
                            i++;
                            break;
                        case 4:
                            radioButtons[i][0].Checked = true;
                            radioButtons[i][1].Checked = false;
                            radioButtons[i][2].Checked = false;
                            i++;
                            break;
                        case 5:
                            radioButtons[i][0].Checked = true;
                            radioButtons[i][1].Checked = false;
                            radioButtons[i][2].Checked = false;
                            i++;
                            break;
                        case 6:
                            radioButtons[i][0].Checked = true;
                            radioButtons[i][1].Checked = false;
                            radioButtons[i][2].Checked = false;
                            i++;
                            break;
                    }

                }

            }

            public static void SetRadioButtonsState(RadioButton[][] radioButtons, byte[] configuration)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (configuration[i] == LOW)
                    {
                        radioButtons[i][0].Checked = true;
                        radioButtons[i][1].Checked = false;
                        radioButtons[i][2].Checked = false;
                    }
                    if (configuration[i] == OPEN)
                    {
                        radioButtons[i][0].Checked = false;
                        radioButtons[i][1].Checked = true;
                        radioButtons[i][2].Checked = false;
                    }
                    if (configuration[i] == HIGH)
                    {
                        radioButtons[i][0].Checked = false;
                        radioButtons[i][1].Checked = false;
                        radioButtons[i][2].Checked = true;
                    }
                }
            }
        }


        public static int Initial_Form_Width = 1060;
        public static int Max_Form_Width = 1520;
        public static int Current_Form_Width = 0;

        #region Class for new visualisation of Tool Strip Menu
        public class Cols : ProfessionalColorTable
        {
            //--------------------------------------------------------------------------------//
            public override Color StatusStripGradientBegin
            {
                get { return Color.FromArgb(40, 40, 40); }
            }
            public override Color StatusStripGradientEnd
            {
                get { return Color.FromArgb(40, 40, 40); }
            }

            public override Color ToolStripBorder
            {
                get { return Color.FromArgb(40, 40, 40); }
            }
            //-------------------------------------------------------------------------------//
            public override Color MenuItemSelected
            {
                // 51, 153, 255 - устанавливаем голубой цвет выбранного элемента
                // (или задаете свой)
                get { return Color.FromArgb(70, 70, 70); }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.FromArgb(60, 60, 60); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.FromArgb(60, 60, 60); }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.FromArgb(30,30,30); }
            }

            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(30, 30, 30); }
            }

            public override Color MenuItemBorder
            {
                get { return Color.FromArgb(60, 60, 60); }
            }
        }

        private void SetWhiteColor(ToolStripMenuItem item)
        {
            item.ForeColor = Color.White;
            foreach (ToolStripMenuItem it in item.DropDownItems)
            {
                SetWhiteColor(it);
            }
        }
        #endregion

        public static Int32 USB_VID = 0xF056;
        public static Int32 USB_PID = 0x0025;
        public static USB USB_device = new USB(USB_VID, USB_PID);

        String DeviceInfo = "";
        public String DeviceStatus = "0";


        public Form_MainForm()
        {
            InitializeComponent();

            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new Cols());
            statusStrip1.Renderer = new ToolStripProfessionalRenderer(new Cols());

            this.Width = Initial_Form_Width;
            Current_Form_Width = this.Width;

            MoveWindowToCenterScreen(this);

            #region Set the start window to INDUSTRIAL PTN3460I mode
            this.Text = "PTN3460/I Configurator - INDUSTRIAL";
            richTextBox_CFG3.Text = "                 DP lane selection\n LOW  - 2-lane DP configuration\n OPEN - This mode is unavailable!\n HIGH - 1-lane DP configuration";
            radioButton_OPEN_CFG3.Enabled = false;
            richTextBox_CFG4.Text = "              Emulation bit on/off selection\n LOW  - Emulation ON, EDID is read from internal flash\n OPEN - This mode is unavailable!\n HIGH - Emulation OFF, EDID is read from DDC bus";
            radioButton_OPEN_CFG4.Enabled = false;
            #endregion

            #region Prepare the GUI to work
            Read_Write_status_toolStripStatusLabel.Text = "...";
            toolStripStatusLabel_DeviceStatus.Text = "";
            toolStripStatusLabel_DeviceErrorMessage.Text = "";
            EDID_EEPROM_toolStripStatusLabel.Text = "EDID EEPROM...";
            STM_EEPROM_toolStripStatusLabel.Text = "STM EEPROM...";

            Update_RB_BackColor();
            #endregion

            #region Description of Radio Button massives 
            RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
            RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
            RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
            RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
            RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
            RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
            RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

            RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

            RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
            RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
            RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
            RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
            RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
            RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
            RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

            RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };
            BitState.GetConfig(radioButtons_SettingsBitsState);

            RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
            RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
            RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
            RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
            RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
            RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
            RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

            RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

            RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
            RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
            RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
            RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
            RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
            RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
            RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

            RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
            #endregion
            ConnectToUsbDeviceFunc();

            CheckForErrors();
        }

        #region Menu Settings -> PTN 3460 type select menu items
        private void commercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            industrialToolStripMenuItem.Checked = false;
            commercialToolStripMenuItem.Checked = true;

            this.Text = "PTN3460/I Configurator - COMMERCIAL";

            richTextBox_CFG3.Text = "              LVDS clock frequency spread depth control\n" + " LOW  - 0%\n" + " OPEN - 1% \n" + " HIGH - 0.5%";

            radioButton_OPEN_CFG3.Enabled = true;

            richTextBox_CFG4.Text = "                 LVDS output swing (typical value)\n LOW  - 250 mV\n OPEN - 300 mV\n HIGH - 400 mV";

            radioButton_OPEN_CFG4.Enabled = true;

            label_CFG_bits_description.Text = "CFG bits description - Commercial type";
        }

        private void industrialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commercialToolStripMenuItem.Checked = false;
            industrialToolStripMenuItem.Checked = true;

            this.Text = "PTN3460/I Configurator - INDUSTRIAL";

            richTextBox_CFG3.Text = "                 DP lane selection\n LOW  - 2-lane DP configuration\n OPEN - This mode is unavailable!\n HIGH - 1-lane DP configuration";

            radioButton_OPEN_CFG3.Enabled = false;

            richTextBox_CFG4.Text = "              Emulation bit on/off selection\n LOW  - Emulation ON, EDID is read from internal flash\n OPEN - This mode is unavailable!\n HIGH - Emulation OFF, EDID is read from DDC bus";

            radioButton_OPEN_CFG4.Enabled = false;

            label_CFG_bits_description.Text = "CFG bits description - Industrial type";
        }
        #endregion

        private void CheckForErrors()
        {
            if (toolStripStatusLabel_DeviceErrorMessage.Text == "")
            {
                toolStripStatusLabel_DeviceErrorMessage.Visible = false;
                toolStripStatusLabel5.Visible = false;
            }
            if (toolStripStatusLabel_DeviceErrorMessage.Text != "")
            {
                toolStripStatusLabel_DeviceErrorMessage.Visible = true;
                toolStripStatusLabel5.Visible = true;
            }
        }
        public void StatesIfDeviceNotFound()
        {
            EDID_EEPROM_toolStripStatusLabel.Text = "EDID EEPROM  no info.";
            STM_EEPROM_toolStripStatusLabel.Text = "STM EEPROM  no info.";

            toolStripStatusLabel_DeviceStatus.Text = DeviceStatus;
            toolStripStatusLabel_DeviceStatus.Image = global::PTN3460I_Configurator.Properties.Resources.not_availible;
            toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;

            pTNPinsConfigToolStripMenuItem.Enabled = false;
            eDIDToolStripMenuItem.Enabled = false;
            Reset_PTN_ToolStripMenuItem.Enabled = false;
            controlPanelToolStripMenuItem.Enabled = false;
        }
        private void ConnectToUsbDeviceFunc()
        {
            USB_device.FindUSBDevice();

            DeviceStatus = USB_device.DeviceInfoStatus;

            if (DeviceStatus == "Connected Full" || DeviceStatus == "Connected")
            {
                pTNPinsConfigToolStripMenuItem.Enabled = true;
                eDIDToolStripMenuItem.Enabled = true;
                Reset_PTN_ToolStripMenuItem.Enabled = true;
                controlPanelToolStripMenuItem.Enabled = true;

                Update_RB_BackColor();

                DeviceInfo = "VID/PID 0x" + USB_device.USB_VID.ToString("X4") + "/0x" + USB_device.USB_PID.ToString("X4");
                DeviceStatus = USB_device.DeviceInfoStatus;

                toolStripStatusLabel_DeviceStatus.Text = DeviceStatus;
                toolStripStatusLabel_DeviceStatus.Image = global::PTN3460I_Configurator.Properties.Resources.connected;
                toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;

                UsbGetTechDataRequest();
                if (TechInfoBuffer[0] == STM32_EEPROM_online) 
                {
                    STM_EEPROM_toolStripStatusLabel.Text = "STM32 EEPROM";
                    STM_EEPROM_toolStripStatusLabel.Image = global::PTN3460I_Configurator.Properties.Resources.connect;
                }
                if (TechInfoBuffer[0] == STM32_EEPROM_not_found) 
                {
                    STM_EEPROM_toolStripStatusLabel.Text = "STM32 EEPROM";
                    STM_EEPROM_toolStripStatusLabel.Image = global::PTN3460I_Configurator.Properties.Resources.not_availible;
                } 

                if (TechInfoBuffer[1] == EDID_EEPROM_online) 
                { 
                    EDID_EEPROM_toolStripStatusLabel.Text = "EDID EEPROM";
                    EDID_EEPROM_toolStripStatusLabel.Image = global::PTN3460I_Configurator.Properties.Resources.connect;
                }
                if (TechInfoBuffer[1] == EDID_EEPROM_not_found)
                {
                    EDID_EEPROM_toolStripStatusLabel.Text = "EDID EEPROM";
                    EDID_EEPROM_toolStripStatusLabel.Image = global::PTN3460I_Configurator.Properties.Resources.not_availible;
                }

                if (TechInfoBuffer[6] == EEPROM_CFG_storage_priority)
                {
                    Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Checked = false;
                    Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Checked = true;

                    Priority_CFG_bits_storage_toolStripStatusLabel.Text = "CFG storage priority: EEPROM";
                    richTextBox_cfg_bits_setup_mem_type.Text = "   EEPROM";
                }
                if (TechInfoBuffer[6] == FLASH_CFG_storage_priority)
                {
                    Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Checked = false;
                    Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Checked = true;

                    Priority_CFG_bits_storage_toolStripStatusLabel.Text = "CFG storage priority: FLASH";
                    richTextBox_cfg_bits_setup_mem_type.Text = "       FLASH";
                }

            }
            else
            {
                EDID_EEPROM_toolStripStatusLabel.Text = "EDID EEPROM  no info.";
                STM_EEPROM_toolStripStatusLabel.Text = "STM EEPROM  no info.";

                toolStripStatusLabel_DeviceStatus.Text = DeviceStatus;
                toolStripStatusLabel_DeviceStatus.Image = global::PTN3460I_Configurator.Properties.Resources.not_availible;
                toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;

                pTNPinsConfigToolStripMenuItem.Enabled = false;
                eDIDToolStripMenuItem.Enabled = false;
                Reset_PTN_ToolStripMenuItem.Enabled = false;
            }

        }

        #region Menu File items
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectToUsbDeviceFunc();
            CheckForErrors();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.DiconnectUSB();
            DeviceStatus = USB_device.DeviceInfoStatus;
            toolStripStatusLabel_DeviceStatus.Text = DeviceStatus;

            pTNPinsConfigToolStripMenuItem.Enabled = false;
            eDIDToolStripMenuItem.Enabled = false;
            Reset_PTN_ToolStripMenuItem.Enabled = false;
            controlPanelToolStripMenuItem.Enabled = false;

            toolStripStatusLabel_DeviceStatus.Image = null;

            Priority_CFG_bits_storage_toolStripStatusLabel.Text = "CFG storage priority: no info";

            STM_EEPROM_toolStripStatusLabel.Text = "STM32 EEPROM no info";
            STM_EEPROM_toolStripStatusLabel.Image = null;

            EDID_EEPROM_toolStripStatusLabel.Text = "EDID EEPROM no info";
            EDID_EEPROM_toolStripStatusLabel.Image = null;

            toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;
            CheckForErrors();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Radio Button massives 
            RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
            RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
            RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
            RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
            RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
            RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
            RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

            RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

            RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
            RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
            RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
            RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
            RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
            RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
            RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

            RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };

            RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
            RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
            RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
            RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
            RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
            RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
            RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

            RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

            RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
            RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
            RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
            RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
            RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
            RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
            RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

            RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
            #endregion

            Read_Write_status_toolStripStatusLabel.Text = "Data actions...";
            toolStripStatusLabel_DeviceStatus.Text = "";
            BitState.UncheckRadiobuttons(radioButtons_CurrentBitsState);
            BitState.SetDefaultRadioButtonsState(radioButtons_SettingsBitsState);

            Update_RB_BackColor();
            CheckForErrors();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.DiconnectUSB();
            this.Close();
        }
        #region Items save and load
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion

        #region View Settings Functions
        static void MoveWindowToCenterScreen(Form form)
        {
            var screen = Screen.FromControl(form);
            form.Top = screen.Bounds.Height / 2 - form.Height / 2;
            form.Left = screen.Bounds.Width / 2 - form.Width / 2;
        }

        private void Form1_LocationChanged()
        {
            Size size = SystemInformation.PrimaryMonitorSize;
            if (this.Location.X < 0)
            {
                this.Location = new Point(0, this.Location.Y);
            }
            if (this.Location.Y < 0)
            {
                this.Location = new Point(this.Location.X, 0);
            }
            if (this.Location.X + this.Size.Width > size.Width)
            {
                this.Location = new Point(size.Width - this.Size.Width, this.Location.Y);
            }
            if (this.Location.Y + this.Size.Height > size.Height)
            {
                this.Location = new Point(this.Location.X, size.Height - this.Size.Height);
            }
        }

        public int index_of_call = 0;
        void Show_panel_bits(Panel panel)
        {
            Update_RB_BackColor();
            if (index_of_call < 2) index_of_call++;
            else index_of_call = 2;

            if (index_of_call == 1)
            {
                //for (int i = this.Width; i < Initial_Form_Width + 220; i += 15)
                for (int i = Width; i < Current_Form_Width + panel.Width + 6 + 1; i+=10)
                {
                    Application.DoEvents();
                    Size = new Size(i, Size.Height);
                }
                Current_Form_Width = this.Width;
                panel.Location = new Point(1038, 34);
            }
            if (index_of_call == 2)
            {
                for (int i = Width; i < Current_Form_Width + panel.Width +6 + 1; i += 10)
                {
                    Application.DoEvents();
                    Size = new Size(i, Size.Height);
                }
                Current_Form_Width = this.Width;
                panel.Location = new Point(1268, 34);
            }
            panel.Visible = true;
            //MoveWindowToCenterScreen(this);
            Form1_LocationChanged();
        }

        void Hide_panel_bits(Panel groupbox1, Panel groupbox2)
        {
            Update_RB_BackColor();
            groupbox1.Visible = false;
            if (index_of_call == 1)
            {
                for (int i = Width-6-1-3; i > Initial_Form_Width -10; i -= 10)
                {
                    Application.DoEvents();
                    Size = new Size(i, Size.Height);
                }
                Current_Form_Width = this.Width;
            }
            if (index_of_call == 2)
            {
                for (int i = Width; i > Initial_Form_Width + groupbox2.Width; i -= 10)
                {
                    Application.DoEvents();
                    Size = new Size(i, Size.Height);
                }
                Current_Form_Width = this.Width;
                groupbox2.Location = new Point(1038, 34);
            }

            if (index_of_call > 0) index_of_call--;
            else index_of_call = 0;
            //MoveWindowToCenterScreen(this);
            Form1_LocationChanged();
        }
        private void FLASH_bits_Show_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Show_panel_bits(panel_FLASH_bits);

            FLASH_bits_Show_ToolStripMenuItem.Enabled = false;
            FLASH_bits_Hide_ToolStripMenuItem.Enabled = true;
        }

        private void FLASH_bits_Hide_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide_panel_bits(panel_FLASH_bits, panel_EEPROM_bits);

            FLASH_bits_Show_ToolStripMenuItem.Enabled = true;
            FLASH_bits_Hide_ToolStripMenuItem.Enabled = false;
        }

        private void EEPROM_bits_Show_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show_panel_bits(panel_EEPROM_bits);

            EEPROM_bits_Show_ToolStripMenuItem.Enabled = false;
            EEPROM_bits_Hide_ToolStripMenuItem.Enabled = true;
        }

        private void EEPROM_bits_Hide_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide_panel_bits(panel_EEPROM_bits, panel_FLASH_bits);

            EEPROM_bits_Show_ToolStripMenuItem.Enabled = true;
            EEPROM_bits_Hide_ToolStripMenuItem.Enabled = false;
        }

        void Update_RB_BackColor()
        {
            #region Radio Button massives 
            RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
            RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
            RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
            RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
            RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
            RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
            RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

            RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

            RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
            RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
            RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
            RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
            RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
            RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
            RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

            RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };

            RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
            RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
            RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
            RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
            RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
            RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
            RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

            RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

            RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
            RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
            RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
            RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
            RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
            RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
            RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

            RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
            #endregion
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (radioButtons_SettingsBitsState[i][j].Checked == true) radioButtons_SettingsBitsState[i][j].BackColor = Color.FromArgb(80, 80, 80);
                    if (radioButtons_SettingsBitsState[i][j].Checked == false) radioButtons_SettingsBitsState[i][j].BackColor = Color.FromArgb(40, 40, 40);

                    if (radioButtons_CurrentBitsState[i][j].Checked == true) radioButtons_CurrentBitsState[i][j].BackColor = Color.FromArgb(80, 80, 80);
                    if (radioButtons_CurrentBitsState[i][j].Checked == false) radioButtons_CurrentBitsState[i][j].BackColor = Color.FromArgb(40, 40, 40);

                    if (radioButtons_FLASH[i][j].Checked == true) radioButtons_FLASH[i][j].BackColor = Color.FromArgb(80, 80, 80);
                    if (radioButtons_FLASH[i][j].Checked == false) radioButtons_FLASH[i][j].BackColor = Color.FromArgb(40, 40, 40);

                    if (radioButtons_EEPROM[i][j].Checked == true) radioButtons_EEPROM[i][j].BackColor = Color.FromArgb(80, 80, 80);
                    if (radioButtons_EEPROM[i][j].Checked == false) radioButtons_EEPROM[i][j].BackColor = Color.FromArgb(40, 40, 40);
                }
            }
        }
        #endregion

        #region defines for RepoertID's & TechInfos
        int ReportID_toHost_CURRENT_CFG_STATE = 1;      // ReportID for read current PTN3460 configuration to host program  
        static int ReportID_toHost_CFG_FROM_EEPROM = 2;        // ReportID for read PTN3460 configuration stored in EEPROM
        int STM_CFG = 55;                               // Value for identify STM32 CFG from EEPROM
        static int PTN_CFG_1 = 155;                              // Value for identify PTN EDID & CFG from EEPROM part 1
        static int PTN_CFG_2 = 165;                              // Value for identify PTN EDID & CFG from EEPROM part 2
        int ReportID_toHost_CFG_FROM_FLASH = 3;         // ReportID for read PTN3460 configuration stored in STM32 FLASH
        static int ReportID_toHost_Tech_Info = 4;       // ReportID for read technical info, statuses from STM32 Core program 
        //---------------------------------------------------//
        static int ReportID_fromHost_READ_CFG_State_Request = 101;    // ReportID from host: read request the current PTN3460 cfg state
        static int ReportID_fromHost_READ_CFG_FROM_EEPROM   = 102;    // ReportID from host: read request the EEPROM PTN3460 cfg state
        static int ReportID_fromHost_READ_CFG_FROM_FLASH    = 103;    // ReportID from host: read request the FLASH PTN3460 cfg state
        //---------------------------------------------------//
        int ReportID_fromHost_WRITE_CFG_Online          = 111;        // ReportID from host: request for write current PTN3460 cfg state
        static int ReportID_fromHost_WRITE_CFG_EEPROM   = 112;        // ReportID from host: request for write PTN3460 cfg to EEPROM
        int ReportID_fromHost_WRITE_CFG_FLASH           = 113;        // ReportID from host: request for write PTN3460 cfg to FLASH
        //---------------------------------------------------//
        static int ReportID_fromHost_READ_EDID_PTN_EEPROM   = 201;   // ReportID from host: read request the EDID
        static int ReportID_fromHost_WRITE_EDID_PTN_EEPROM  = 211;   // ReportID from host: request for write the new EDID
        //---------------------------------------------------//
        static int READ_I2C_id   = 0xCA;               // ReportID from host: read request the EDID
        static int WRITE_I2C_id  = 212;               // ReportID from host: request for write the new EDID
        //---------------------------------------------------//
        int ReportID_fromHost_RESET_PTN = 250;                      // ReportID from host for RESET the PTN3460 processor
        //**************************************************************************************************************************//
        int STM32_EEPROM_online = 0xCC;
        int STM32_EEPROM_not_found = 0xEE;

        public static int EDID_EEPROM_online = 0xCC;
        public static int EDID_EEPROM_not_found = 0xEE;

        int STM32_Flash_data_write_OK = 0xFA;
        int STM32_Flash_data_write_Error = 0xFD;

        int STM32_EEPROM_data_write_OK = 0xAA;
        int STM32_EEPROM_data_write_Error = 0xDD;

        static int EDID_EEPROM_data_write_OK = 0xEA;
        static int EDID_EEPROM_data_write_Error = 0xED;

        static byte EEPROM_CFG_storage_priority = 0xEE;
        static byte FLASH_CFG_storage_priority = 0x32;
        #endregion
        private static void __pause(int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();
        }

        public static byte[] TechInfoBuffer = { 0, 0, 0, 0, 0, 0, 0, 0};
        private static void UsbGetTechDataRequest()
        {
            USB_device.USBwriteBuffer[1] = 0xAA;
            USB_device.SendData(ReportID_fromHost_READ_CFG_State_Request, 2);

            USB_device.GetData(ReportID_toHost_Tech_Info);

            for (int i = 0; i < 8; i++) TechInfoBuffer[i] = USB_device.USBreadDataBuffer[i];
        }

        
        
        public static void Usb_SET_LED_panel_cfg(byte[] data)
        {
            USB_device.USBwriteBuffer[1] = 0xEF;
            for (int i = 0; i < 3; i++) USB_device.USBwriteBuffer[i + 2] = data[i];
            USB_device.SendData(ReportID_fromHost_READ_CFG_State_Request, 5);

            //USB_device.GetData(ReportID_toHost_Tech_Info);

            //for (int i = 0; i < 8; i++) TechInfoBuffer[i] = USB_device.USBreadDataBuffer[i];
        }
        public static byte[] Usb_GET_LED_panel_cfg()
        {
            byte[] array = { 0, 0, 0 };
            USB_device.USBwriteBuffer[1] = 0xDE;
            USB_device.SendData(ReportID_fromHost_READ_CFG_State_Request, 2);

            USB_device.GetData(ReportID_toHost_Tech_Info);

            //for (int i = 0; i < 3; i++) Form_ControlPanelForm.LED_panel_cfg_array[i] = USB_device.USBreadDataBuffer[i];
            for (int i = 0; i < 3; i++) array[i] = USB_device.USBreadDataBuffer[i];
            return array;
        }
        #region Read / Write current state config
        private void Current_State_PTN_Configuration_bits_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.DetectDeviceOnBus(USB_VID, USB_PID);
            if (USB_device.DeviceOnBusDetected)
            {
                #region Radio Button massives 
                RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
                RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
                RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
                RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
                RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
                RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
                RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

                RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
                RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
                RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
                RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
                RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
                RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
                RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

                RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
                RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
                RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
                RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
                RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
                RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
                RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

                RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

                RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
                RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
                RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
                RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
                RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
                RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
                RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

                RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
                #endregion
                richTextBox_current_bits_state_mem_type.Text = "Reading...";
                USB_device.USBwriteBuffer[1] = 0x01;
                USB_device.SendData(ReportID_fromHost_READ_CFG_State_Request, 2);

                USB_device.GetData(ReportID_toHost_CURRENT_CFG_STATE);
                byte[] CurrentConfiguration = { 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int i = 0; i < 8; i++) CurrentConfiguration[i] = USB_device.USBreadDataBuffer[i];

                BitState.SetRadioButtonsState(radioButtons_CurrentBitsState, CurrentConfiguration);


                if (CurrentConfiguration[7] == EEPROM_CFG_storage_priority)
                {
                    richTextBox_current_bits_state_mem_type.Text = "   EEPROM";
                }
                if (CurrentConfiguration[7] == FLASH_CFG_storage_priority)
                {
                    richTextBox_current_bits_state_mem_type.Text = "       FLASH";
                }

                toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;
                CheckForErrors();
            }
            else
            {
                StatesIfDeviceNotFound();
            }
        }

        private void Write_CFG_to_STM32_Online_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.DetectDeviceOnBus(USB_VID, USB_PID);
            if (USB_device.DeviceOnBusDetected)
            {
                #region Radio Button massives 
                RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
                RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
                RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
                RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
                RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
                RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
                RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

                RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
                RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
                RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
                RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
                RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
                RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
                RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

                RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
                RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
                RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
                RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
                RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
                RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
                RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

                RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

                RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
                RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
                RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
                RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
                RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
                RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
                RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

                RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
                #endregion

                BitState.GetConfig(radioButtons_SettingsBitsState);

                for (int i = 0; i < 7; i++)
                {
                    USB_device.USBwriteBuffer[i + 1] = BitState.configuration_bits[i];
                }
                USB_device.SendData(ReportID_fromHost_WRITE_CFG_Online, 8);

                toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;

                __pause(1000);

                Current_State_PTN_Configuration_bits_ToolStripMenuItem_Click(Read_CFG_from_STM32_Current_state_ToolStripMenuItem, e);
                CheckForErrors();
            }
            else
            {
                StatesIfDeviceNotFound();
            }
        }
        #endregion

        #region Read / Write PTN config FLASH
        private void Read_CFG_from_STM32_FLASH_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.DetectDeviceOnBus(USB_VID, USB_PID);
            if (USB_device.DeviceOnBusDetected)
            {
                Random rnd = new Random();
                Read_Write_status_toolStripStatusLabel.Text = "Reading data...";
                richTextBox_cfg_in_flash_mem_type.Text = "Reading...";
                int up_data_prsnt = 0;
                #region Radio Button massives 
                RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
                RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
                RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
                RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
                RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
                RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
                RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

                RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
                RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
                RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
                RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
                RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
                RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
                RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

                RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
                RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
                RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
                RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
                RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
                RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
                RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

                RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

                RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
                RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
                RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
                RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
                RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
                RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
                RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

                RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
                #endregion

                if ((index_of_call == 0 || index_of_call == 1) && FLASH_bits_Show_ToolStripMenuItem.Enabled == true) FLASH_bits_Show_ToolStripMenuItem_Click(sender, e);
                up_data_prsnt = up_data_prsnt + rnd.Next(3, 8);
                Read_Write_status_toolStripStatusLabel.Text = "Reading flash data " + Convert.ToString(up_data_prsnt) + "%";

                USB_device.SendData(ReportID_fromHost_READ_CFG_FROM_FLASH, 2);
                up_data_prsnt = up_data_prsnt + rnd.Next(3, 8);
                Read_Write_status_toolStripStatusLabel.Text = "Reading flash data " + Convert.ToString(up_data_prsnt) + "%";

                USB_device.GetData(ReportID_toHost_CFG_FROM_FLASH);
                byte[] CurrentConfiguration = { 0, 0, 0, 0, 0, 0, 0, 0 };
                for (int i = 0; i < 8; i++)
                {
                    CurrentConfiguration[i] = USB_device.USBreadDataBuffer[i];

                    up_data_prsnt = up_data_prsnt + i + rnd.Next(5, 9);
                    Read_Write_status_toolStripStatusLabel.Text = "Reading flash data " + Convert.ToString(up_data_prsnt) + "%";
                    __pause(100);
                }
                Read_Write_status_toolStripStatusLabel.Text = "Reading flash data 97%";

                BitState.SetRadioButtonsState(radioButtons_FLASH, CurrentConfiguration);

                if (CurrentConfiguration[7] == EEPROM_CFG_storage_priority)
                {
                    richTextBox_cfg_in_flash_mem_type.Text = "   EEPROM";
                }
                if (CurrentConfiguration[7] == FLASH_CFG_storage_priority)
                {
                    richTextBox_cfg_in_flash_mem_type.Text = "       FLASH";
                }

                Read_Write_status_toolStripStatusLabel.Text = "Reading flash data 100%";

                toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;
                CheckForErrors();
            }
            else
            {
                StatesIfDeviceNotFound();
            }
        }

        private void Write_CFG_to_STM32_FLASH_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.DetectDeviceOnBus(USB_VID, USB_PID);
            if (USB_device.DeviceOnBusDetected)
            {
                Random rnd = new Random();
                Read_Write_status_toolStripStatusLabel.Text = "Updating data...";
                int up_data_prsnt = 0;
                #region Radio Button massives 
                RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
                RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
                RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
                RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
                RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
                RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
                RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

                RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
                RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
                RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
                RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
                RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
                RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
                RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

                RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
                RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
                RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
                RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
                RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
                RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
                RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

                RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

                RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
                RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
                RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
                RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
                RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
                RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
                RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

                RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
                #endregion

                BitState.GetConfig(radioButtons_SettingsBitsState);

                for (int i = 0; i < 7; i++)
                {
                    USB_device.USBwriteBuffer[i + 1] = BitState.configuration_bits[i];
                    up_data_prsnt = up_data_prsnt + i + rnd.Next(1, 3);
                    Read_Write_status_toolStripStatusLabel.Text = "Updating flash data " + Convert.ToString(up_data_prsnt) + "%";
                    __pause(100);
                }

                if (Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Checked) USB_device.USBwriteBuffer[8] = EEPROM_CFG_storage_priority;
                if (Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Checked) USB_device.USBwriteBuffer[8] = FLASH_CFG_storage_priority;
                up_data_prsnt = up_data_prsnt + rnd.Next(3, 8);
                Read_Write_status_toolStripStatusLabel.Text = "Updating flash data " + Convert.ToString(up_data_prsnt) + "%";

                USB_device.SendData(ReportID_fromHost_WRITE_CFG_FLASH, 9);

                toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;
                CheckForErrors();
                Read_Write_status_toolStripStatusLabel.Text = "Updating flash data 97%";
                __pause(1000);

                UsbGetTechDataRequest();
                if (TechInfoBuffer[2] == STM32_Flash_data_write_OK) Read_Write_status_toolStripStatusLabel.Text = "All data wrote to FLASH succesful!";
                if (TechInfoBuffer[2] == STM32_Flash_data_write_Error) Read_Write_status_toolStripStatusLabel.Text = "The recording to FLASH failed!";
            }
            else
            {
                StatesIfDeviceNotFound();
            }
        }

        #endregion

        #region Read / Write PTN config EEPROM
        private void Read_CFG_from_STM32_EEPROM_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Radio Button massives 
            RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
            RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
            RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
            RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
            RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
            RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
            RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

            RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

            RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
            RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
            RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
            RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
            RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
            RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
            RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

            RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };

            RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
            RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
            RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
            RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
            RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
            RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
            RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

            RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

            RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
            RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
            RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
            RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
            RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
            RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
            RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

            RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
            #endregion
            USB_device.DetectDeviceOnBus(USB_VID, USB_PID);
            if (USB_device.DeviceOnBusDetected)
            {
                try
                {
                    if (TechInfoBuffer[0] == STM32_EEPROM_not_found)
                    {
                        panel_EEPROM_bits.BackColor = Color.FromArgb(225, 28, 0);
                    }
                    else
                    {
                        Random rnd = new Random();
                        Read_Write_status_toolStripStatusLabel.Text = "Reading data...";
                        richTextBox_cfg_in_eeprom_mem_type.Text = "Reading...";
                        int up_data_prsnt = 0;

                        panel_EEPROM_bits.BackColor = Color.FromArgb(225, 128, 0);

                        if ((index_of_call == 0 || index_of_call == 1) && EEPROM_bits_Show_ToolStripMenuItem.Enabled == true) EEPROM_bits_Show_ToolStripMenuItem_Click(sender, e);
                        up_data_prsnt = up_data_prsnt + rnd.Next(3, 8);
                        Read_Write_status_toolStripStatusLabel.Text = "Reading STM32 EEPROM data " + Convert.ToString(up_data_prsnt) + "%";

                        USB_device.USBwriteBuffer[1] = 0x00;
                        USB_device.SendData(ReportID_fromHost_READ_CFG_FROM_EEPROM, 2);
                        up_data_prsnt = up_data_prsnt + rnd.Next(3, 8);
                        Read_Write_status_toolStripStatusLabel.Text = "Reading STM32 EEPROM data " + Convert.ToString(up_data_prsnt) + "%";

                        USB_device.GetData(ReportID_toHost_CFG_FROM_EEPROM);
                        byte[] CurrentConfiguration = { 0, 0, 0, 0, 0, 0, 0, 0 };
                        if (USB_device.USBreadDataBuffer[0] == STM_CFG)
                        {
                            for (int i = 1; i < 9; i++)
                            {
                                CurrentConfiguration[i - 1] = USB_device.USBreadDataBuffer[i];
                                up_data_prsnt = up_data_prsnt + i + rnd.Next(5, 9);
                                Read_Write_status_toolStripStatusLabel.Text = "Reading STM32 EEPROM data " + Convert.ToString(up_data_prsnt) + "%";
                                __pause(100);
                            }
                        }
                        Read_Write_status_toolStripStatusLabel.Text = "Reading STM32 EEPROM data 97%";

                        BitState.SetRadioButtonsState(radioButtons_EEPROM, CurrentConfiguration);

                        if (CurrentConfiguration[7] == EEPROM_CFG_storage_priority)
                        {
                            richTextBox_cfg_in_eeprom_mem_type.Text = "   EEPROM";
                        }
                        if (CurrentConfiguration[7] == FLASH_CFG_storage_priority)
                        {
                            richTextBox_cfg_in_eeprom_mem_type.Text = "       FLASH";
                        }
                        Read_Write_status_toolStripStatusLabel.Text = "Reading STM32 EEPROM data 100%";

                        toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;
                        CheckForErrors();
                    }
                }
                catch (AccessViolationException exc)
                {
                    toolStripStatusLabel_DeviceErrorMessage.Text = exc.Message + "aaaa";
                    CheckForErrors();
                }
            }
            else
            {
                StatesIfDeviceNotFound();
            }
        }
        private void Write_CFG_to_STM32_EEPROM_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.DetectDeviceOnBus(USB_VID, USB_PID);
            if (USB_device.DeviceOnBusDetected)
            {
                Random rnd = new Random();
                Read_Write_status_toolStripStatusLabel.Text = "Updating data...";
                int up_data_prsnt = 0;
                #region Radio Button massives 
                RadioButton[] radioButtons_CurrentBitsState_PD_N = { radioButton_STATE_LOW_PD_N, radioButton_STATE_OPEN_PD_N, radioButton_STATE_HIGH_PD_N };
                RadioButton[] radioButtons_CurrentBitsState_DEV_CFG = { radioButton_STATE_LOW_DEV_CFG, radioButton_STATE_OPEN_DEV_CFG, radioButton_STATE_HIGH_DEV_CFG };
                RadioButton[] radioButtons_CurrentBitsState_TESTMODE = { radioButton_STATE_LOW_TESTMODE, radioButton_STATE_OPEN_TESTMODE, radioButton_STATE_HIGH_TESTMODE };
                RadioButton[] radioButtons_CurrentBitsState_CFG1 = { radioButton_STATE_LOW_CFG1, radioButton_STATE_OPEN_CFG1, radioButton_STATE_HIGH_CFG1 };
                RadioButton[] radioButtons_CurrentBitsState_CFG2 = { radioButton_STATE_LOW_CFG2, radioButton_STATE_OPEN_CFG2, radioButton_STATE_HIGH_CFG2 };
                RadioButton[] radioButtons_CurrentBitsState_CFG3 = { radioButton_STATE_LOW_CFG3, radioButton_STATE_OPEN_CFG3, radioButton_STATE_HIGH_CFG3 };
                RadioButton[] radioButtons_CurrentBitsState_CFG4 = { radioButton_STATE_LOW_CFG4, radioButton_STATE_OPEN_CFG4, radioButton_STATE_HIGH_CFG4 };

                RadioButton[][] radioButtons_CurrentBitsState = {   radioButtons_CurrentBitsState_PD_N,
                                                                radioButtons_CurrentBitsState_DEV_CFG,
                                                                radioButtons_CurrentBitsState_TESTMODE,
                                                                radioButtons_CurrentBitsState_CFG1,
                                                                radioButtons_CurrentBitsState_CFG2,
                                                                radioButtons_CurrentBitsState_CFG3,
                                                                radioButtons_CurrentBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_SettingsBitsState_PD_N = { radioButton_LOW_PD_N, radioButton_OPEN_PD_N, radioButton_HIGH_PD_N };
                RadioButton[] radioButtons_SettingsBitsState_DEV_CFG = { radioButton_LOW_DEV_CFG, radioButton_OPEN_DEV_CFG, radioButton_HIGH_DEV_CFG };
                RadioButton[] radioButtons_SettingsBitsState_TESTMODE = { radioButton_LOW_TESTMODE, radioButton_OPEN_TESTMODE, radioButton_HIGH_TESTMODE };
                RadioButton[] radioButtons_SettingsBitsState_CFG1 = { radioButton_LOW_CFG1, radioButton_OPEN_CFG1, radioButton_HIGH_CFG1 };
                RadioButton[] radioButtons_SettingsBitsState_CFG2 = { radioButton_LOW_CFG2, radioButton_OPEN_CFG2, radioButton_HIGH_CFG2 };
                RadioButton[] radioButtons_SettingsBitsState_CFG3 = { radioButton_LOW_CFG3, radioButton_OPEN_CFG3, radioButton_HIGH_CFG3 };
                RadioButton[] radioButtons_SettingsBitsState_CFG4 = { radioButton_LOW_CFG4, radioButton_OPEN_CFG4, radioButton_HIGH_CFG4 };

                RadioButton[][] radioButtons_SettingsBitsState = {  radioButtons_SettingsBitsState_PD_N,
                                                                radioButtons_SettingsBitsState_DEV_CFG,
                                                                radioButtons_SettingsBitsState_TESTMODE,
                                                                radioButtons_SettingsBitsState_CFG1,
                                                                radioButtons_SettingsBitsState_CFG2,
                                                                radioButtons_SettingsBitsState_CFG3,
                                                                radioButtons_SettingsBitsState_CFG4
                                                            };

                RadioButton[] radioButtons_FLASH_PD_N = { radioButton_FLASH_LOW_PD_N, radioButton_FLASH_OPEN_PD_N, radioButton_FLASH_HIGH_PD_N };
                RadioButton[] radioButtons_FLASH_DEV_CFG = { radioButton_FLASH_LOW_DEV_CFG, radioButton_FLASH_OPEN_DEV_CFG, radioButton_FLASH_HIGH_DEV_CFG };
                RadioButton[] radioButtons_FLASH_TESTMODE = { radioButton_FLASH_LOW_TESTMODE, radioButton_FLASH_OPEN_TESTMODE, radioButton_FLASH_HIGH_TESTMODE };
                RadioButton[] radioButtons_FLASH_CFG1 = { radioButton_FLASH_LOW_CFG1, radioButton_FLASH_OPEN_CFG1, radioButton_FLASH_HIGH_CFG1 };
                RadioButton[] radioButtons_FLASH_CFG2 = { radioButton_FLASH_LOW_CFG2, radioButton_FLASH_OPEN_CFG2, radioButton_FLASH_HIGH_CFG2 };
                RadioButton[] radioButtons_FLASH_CFG3 = { radioButton_FLASH_LOW_CFG3, radioButton_FLASH_OPEN_CFG3, radioButton_FLASH_HIGH_CFG3 };
                RadioButton[] radioButtons_FLASH_CFG4 = { radioButton_FLASH_LOW_CFG4, radioButton_FLASH_OPEN_CFG4, radioButton_FLASH_HIGH_CFG4 };

                RadioButton[][] radioButtons_FLASH = {  radioButtons_FLASH_PD_N,
                                                    radioButtons_FLASH_DEV_CFG,
                                                    radioButtons_FLASH_TESTMODE,
                                                    radioButtons_FLASH_CFG1,
                                                    radioButtons_FLASH_CFG2,
                                                    radioButtons_FLASH_CFG3,
                                                    radioButtons_FLASH_CFG4
                                                 };

                RadioButton[] radioButtons_EEPROM_PD_N = { radioButton_EEPROM_LOW_PD_N, radioButton_EEPROM_OPEN_PD_N, radioButton_EEPROM_HIGH_PD_N };
                RadioButton[] radioButtons_EEPROM_DEV_CFG = { radioButton_EEPROM_LOW_DEV_CFG, radioButton_EEPROM_OPEN_DEV_CFG, radioButton_EEPROM_HIGH_DEV_CFG };
                RadioButton[] radioButtons_EEPROM_TESTMODE = { radioButton_EEPROM_LOW_TESTMODE, radioButton_EEPROM_OPEN_TESTMODE, radioButton_EEPROM_HIGH_TESTMODE };
                RadioButton[] radioButtons_EEPROM_CFG1 = { radioButton_EEPROM_LOW_CFG1, radioButton_EEPROM_OPEN_CFG1, radioButton_EEPROM_HIGH_CFG1 };
                RadioButton[] radioButtons_EEPROM_CFG2 = { radioButton_EEPROM_LOW_CFG2, radioButton_EEPROM_OPEN_CFG2, radioButton_EEPROM_HIGH_CFG2 };
                RadioButton[] radioButtons_EEPROM_CFG3 = { radioButton_EEPROM_LOW_CFG3, radioButton_EEPROM_OPEN_CFG3, radioButton_EEPROM_HIGH_CFG3 };
                RadioButton[] radioButtons_EEPROM_CFG4 = { radioButton_EEPROM_LOW_CFG4, radioButton_EEPROM_OPEN_CFG4, radioButton_EEPROM_HIGH_CFG4 };

                RadioButton[][] radioButtons_EEPROM = {  radioButtons_EEPROM_PD_N,
                                                     radioButtons_EEPROM_DEV_CFG,
                                                     radioButtons_EEPROM_TESTMODE,
                                                     radioButtons_EEPROM_CFG1,
                                                     radioButtons_EEPROM_CFG2,
                                                     radioButtons_EEPROM_CFG3,
                                                     radioButtons_EEPROM_CFG4
                                                  };
                #endregion

                BitState.GetConfig(radioButtons_SettingsBitsState);

                for (int i = 0; i < 7; i++)
                {
                    USB_device.USBwriteBuffer[i + 1] = BitState.configuration_bits[i];
                    up_data_prsnt = up_data_prsnt + i + rnd.Next(1, 3);
                    Read_Write_status_toolStripStatusLabel.Text = "Updating STM32 EEPROM data " + Convert.ToString(up_data_prsnt) + "%";
                    __pause(100);
                }

                if (Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Checked) USB_device.USBwriteBuffer[8] = EEPROM_CFG_storage_priority;
                if (Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Checked) USB_device.USBwriteBuffer[8] = FLASH_CFG_storage_priority;
                up_data_prsnt = up_data_prsnt + rnd.Next(3, 8);
                Read_Write_status_toolStripStatusLabel.Text = "Updating EEPROM data " + Convert.ToString(up_data_prsnt) + "%";

                USB_device.SendData(ReportID_fromHost_WRITE_CFG_EEPROM, 9);

                toolStripStatusLabel_DeviceErrorMessage.Text = USB_device.ErrorMessage;
                CheckForErrors();
                Read_Write_status_toolStripStatusLabel.Text = "Updating STM32 EEPROM data 97%";

                __pause(1000);

                UsbGetTechDataRequest();
                if (TechInfoBuffer[3] == STM32_EEPROM_data_write_OK) Read_Write_status_toolStripStatusLabel.Text = "All data wrote to STM32 EEPROM succesful!";
                if (TechInfoBuffer[3] == STM32_EEPROM_data_write_Error) Read_Write_status_toolStripStatusLabel.Text = "The recording to STM32 EEPROM failed!";
            }
            else
            {
                StatesIfDeviceNotFound();
            }
        }
        #endregion

        #region Read / Write EDID from EEPROM
        public static byte[] EDID_from_EEPROM_buff = new byte[256];
        public static String ErrorMessage = "";
        public static String StatusMessage;
        public static void Read_EDID_from_PTN_EEPROM()
        {
                ErrorMessage = "";
                if (TechInfoBuffer[2] == EDID_EEPROM_not_found) my_Form_EDIDbitsForm.label_EDID_EEPROM_not_found.Visible = true;
                else my_Form_EDIDbitsForm.label_EDID_EEPROM_not_found.Visible = false;

                USB_device.USBwriteBuffer[1] = 0xC9;

                USB_device.SendData(ReportID_fromHost_READ_EDID_PTN_EEPROM, 2);
                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Download data 33%";
                StatusMessage = "Download data 33%";

                USB_device.GetData(ReportID_toHost_CFG_FROM_EEPROM);
                if (USB_device.USBreadDataBuffer[0] == PTN_CFG_1)
                    for (int i = 0; i < 128; i++) EDID_from_EEPROM_buff[i] = USB_device.USBreadDataBuffer[i + 1];
                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Download data 65%";
                StatusMessage = "Download data 65%";

                USB_device.GetData(ReportID_toHost_CFG_FROM_EEPROM);
                if (USB_device.USBreadDataBuffer[0] == PTN_CFG_2)
                    for (int i = 128; i < 256; i++) EDID_from_EEPROM_buff[i] = USB_device.USBreadDataBuffer[i - 127];
                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Download data 82%";
                StatusMessage = "Download data 82%";
                __pause(500);
                ErrorMessage = USB_device.ErrorMessage;
        }
        public static void Write_EDID_to_PTN_EEPROM()
        {
                ErrorMessage = "";
                for (int i = 1; i < 63; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[i - 1];//[ri][0]***[62-1] = 1 + (61-0+1) = 63
                USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);
                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 31%";
                StatusMessage = "Uploading data 31%";
                __pause(1000);
                for (int i = 1; i < 63; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[61 + i]; //[ri][61+1]***[61+62] = 1 + (61+62-61-1+1) = 63
                USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);
                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 48%";
                StatusMessage = "Uploading data 48%";
                __pause(1000);
                for (int i = 1; i < 63; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[123 + i];//[ri][123+1]***[123+62] = 1 + (123+62-123-1+1) = 63
                USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);
                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 53%";
                StatusMessage = "Uploading data 53%";
                __pause(1000);
                for (int i = 1; i < 63; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[185 + i];//[ri][185+1]***[185+62] = 1 + (185+62-185-1+1) = 63
                USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);
                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 67%";
                StatusMessage = "Uploading data 67%";
                __pause(1000);
                for (int i = 1; i < 9; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[247 + i];//[ri][247+1]***[247+8] = 1 + (247+8-247-1+1) = 9
                USB_device.USBwriteBuffer[9] = 7; //idicator of destination memory
                USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);


                ErrorMessage = USB_device.ErrorMessage;
                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 80%";
                StatusMessage = "Uploading data 80%";
                __pause(1000);

                UsbGetTechDataRequest();

                if (TechInfoBuffer[4] == EDID_EEPROM_data_write_OK) StatusMessage = "All data wrote to EDID EEPROM succesful!";
                if (TechInfoBuffer[4] == EDID_EEPROM_data_write_Error) StatusMessage = "The recording to EDID EEPROM failed!";

                my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 85%";
                StatusMessage = "Uploading data 85%";
                __pause(300);
        }
        #endregion

        #region I2C read write functions
        public static void I2C_Read()
        {
            ErrorMessage = "";
            //if (TechInfoBuffer[2] == EDID_EEPROM_not_found) my_Form_EDIDbitsForm.label_EDID_EEPROM_not_found.Visible = true;
            //else my_Form_EDIDbitsForm.label_EDID_EEPROM_not_found.Visible = false;

            USB_device.USBwriteBuffer[1] = Convert.ToByte(READ_I2C_id);

            USB_device.SendData(ReportID_fromHost_READ_EDID_PTN_EEPROM, 2);

            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Download data 33%";
            StatusMessage = "Download data 33%";

            USB_device.GetData(ReportID_toHost_CFG_FROM_EEPROM);
            if (USB_device.USBreadDataBuffer[0] == PTN_CFG_1)
                for (int i = 0; i < 128; i++) EDID_from_EEPROM_buff[i] = USB_device.USBreadDataBuffer[i + 1];
            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Download data 65%";
            StatusMessage = "Download data 65%";

            USB_device.GetData(ReportID_toHost_CFG_FROM_EEPROM);
            if (USB_device.USBreadDataBuffer[0] == PTN_CFG_2)
                for (int i = 128; i < 256; i++) EDID_from_EEPROM_buff[i] = USB_device.USBreadDataBuffer[i - 127];
            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Download data 82%";
            StatusMessage = "Download data 82%";
            __pause(500);
            ErrorMessage = USB_device.ErrorMessage;
        }

        public static void I2C_Write()
        {
            ErrorMessage = "";
            for (int i = 1; i < 63; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[i - 1];//[ri][0]***[62-1] = 1 + (61-0+1) = 63
            USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);
            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 31%";
            StatusMessage = "Uploading data 31%";
            __pause(1000);
            for (int i = 1; i < 63; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[61 + i]; //[ri][61+1]***[61+62] = 1 + (61+62-61-1+1) = 63
            USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);
            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 48%";
            StatusMessage = "Uploading data 48%";
            __pause(1000);
            for (int i = 1; i < 63; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[123 + i];//[ri][123+1]***[123+62] = 1 + (123+62-123-1+1) = 63
            USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);
            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 53%";
            StatusMessage = "Uploading data 53%";
            __pause(1000);
            for (int i = 1; i < 63; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[185 + i];//[ri][185+1]***[185+62] = 1 + (185+62-185-1+1) = 63
            USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);
            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 67%";
            StatusMessage = "Uploading data 67%";
            __pause(1000);
            
            for (int i = 1; i < 9; i++) USB_device.USBwriteBuffer[i] = my_Form_EDIDbitsForm.EDID_cfg_TO_EEPROM[247 + i];//[ri][247+1]***[247+8] = 1 + (247+8-247-1+1) = 9
            USB_device.USBwriteBuffer[9] = 212;
            USB_device.SendData(ReportID_fromHost_WRITE_EDID_PTN_EEPROM, 63);


            ErrorMessage = USB_device.ErrorMessage;
            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 80%";
            StatusMessage = "Uploading data 80%";
            __pause(1000);

            UsbGetTechDataRequest();

            if (TechInfoBuffer[4] == EDID_EEPROM_data_write_OK) StatusMessage = "All data wrote to EDID EEPROM succesful!";
            if (TechInfoBuffer[4] == EDID_EEPROM_data_write_Error) StatusMessage = "The recording to EDID EEPROM failed!";

            my_Form_EDIDbitsForm.label_data_upload_status.Text = "Uploading data 85%";
            StatusMessage = "Uploading data 85%";
            __pause(300);
        }

        #endregion

        #region Reset PTN 3460 request
        private void Reset_PTN_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.SendData(ReportID_fromHost_RESET_PTN, 8);
            CheckForErrors();
        }
        #endregion

        /// <summary>
        /// Check the checked state of RadioButtons and then set the color for checked RadioButtons
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.RadioButton"/> instance containing the event data.</param>
        private void Checked_changed_RB(object sender, EventArgs e)
        {
            Update_RB_BackColor();
        }

        private void eDIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            my_Form_EDIDbitsForm.Owner = this;

            if (DeviceStatus == "Connected Full" || DeviceStatus == "Connected")
            {
                my_Form_EDIDbitsForm.EDID_upload_to_EEPROM_toolStripMenuItem.Enabled = true;
                my_Form_EDIDbitsForm.EDID_download_from_EEPROM_toolStripMenuItem.Enabled = true;
            }
            else
            {
                my_Form_EDIDbitsForm.EDID_upload_to_EEPROM_toolStripMenuItem.Enabled = false;
                my_Form_EDIDbitsForm.EDID_download_from_EEPROM_toolStripMenuItem.Enabled = false;
            }

            if(TechInfoBuffer[1] == EDID_EEPROM_not_found)
            {
                my_Form_EDIDbitsForm.label_EDID_EEPROM_not_found.Visible = true;
            }
            if (TechInfoBuffer[1] == EDID_EEPROM_online)
            {
                my_Form_EDIDbitsForm.label_EDID_EEPROM_not_found.Visible = false;
            }
            my_Form_EDIDbitsForm.Show();
            CheckForErrors();
        }

        #region Menu Help items functions
        private void About_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form_About f = new Form_About())
            {
                f.ShowDialog();
            }
            CheckForErrors();
        }

        private void Show_device_info_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DeviceInfo, "Device VID & PID data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            CheckForErrors();
        }
        #endregion

        private void Set_priority_CFG_storage(object sender, EventArgs e)
        {
            if(sender.Equals(Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem))
            {
                Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Checked = false;
                Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Checked = true;

                richTextBox_cfg_bits_setup_mem_type.Text = "   EEPROM";
            }
            if (sender.Equals(Priority_CFG_bits_storage_FLASH_ToolStripMenuItem))
            {
                Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Checked = false;
                Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Checked = true;

                richTextBox_cfg_bits_setup_mem_type.Text = "       FLASH";
            }
        }
        public static byte[] LED_panel_cfg_array = { 1, 2, 3 };
        public static bool control_panel_is_open = false;
        private void controlPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            USB_device.DetectDeviceOnBus(USB_VID, USB_PID);
            if (USB_device.DeviceOnBusDetected)
            {
                if (control_panel_is_open == false)
                {
                    Form_ControlPanelForm my_Form_ControlPanelForm = new Form_ControlPanelForm();
                    my_Form_ControlPanelForm.Owner = this;
                    if (index_of_call == 0) my_Form_ControlPanelForm.Location = new System.Drawing.Point(this.Width - 40, this.Location.Y + 29);
                    if (index_of_call == 1) my_Form_ControlPanelForm.Location = new System.Drawing.Point(this.Width - 154, this.Location.Y + 29);
                    if (index_of_call == 2) my_Form_ControlPanelForm.Location = new System.Drawing.Point(this.Width - 270, this.Location.Y + 29);
                    my_Form_ControlPanelForm.Show();

                    control_panel_is_open = true;

                    CheckForErrors();
                }
            }
            else
            {
                StatesIfDeviceNotFound();
                MessageBox.Show("USB device not found! Check the connection!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void GetMonitorEdid()
        {
            String[] array = new String[10];
            try
            {
                var searcher = new ManagementObjectSearcher("root\\WMI", "SELECT * FROM WmiMonitorID");

                foreach (var queryObj in searcher.Get())
                {
                    //Console.WriteLine("-----------------------------------");
                    //Console.WriteLine("WmiMonitorID instance");
                    //Console.WriteLine("-----------------------------------");
                    //Console.WriteLine("Active: {0}", queryObj["Active"]);
                    //Console.WriteLine("InstanceName: {0}", queryObj["InstanceName"]);
                    dynamic InstName = queryObj["InstanceName"];
                    array[0] = InstName;
                    dynamic snid = queryObj["SerialNumberID"];
                    array[1] = snid.Length.ToString(); ;
                    //Console.WriteLine("SerialNumberID: (length) {0}", snid.Length);

                    //Console.WriteLine("YearOfManufacture: {0}", queryObj["YearOfManufacture"]);
                    dynamic YoM = queryObj["YearOfManufacture"];

                    //var q2 = new StringBuilder(YoM.Length);
                    //for (int i = 0; i < YoM.Length && YoM[i] != '\0'; i++)
                    //{
                    //    q2.Append(Char.ConvertFromUtf32(YoM[i]));
                    //}
                    array[2] = YoM.ToString();

                    dynamic code = queryObj["ProductCodeID"];
                    var sb = new StringBuilder(code.Length);
                    for (int i = 0; i < code.Length && code[i] != '\0'; i++)
                    {
                        sb.Append(Char.ConvertFromUtf32(code[i]));
                    }
                    string pcid = sb.ToString();
                    array[3] = pcid;
                    //Console.WriteLine("ProductCodeID: " + pcid);

                    MessageBox.Show("Name: " + array[0]+"\n" + "ID length: " + array[1]+"\n" + "Year of Maufacture: " + array[2]+"\n" + "Product Code: " + array[3] , "WmiMonitorID instance", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (ManagementException e)
            {
                //Console.WriteLine("An error occurred while querying for WMI data: " + e.Message);
            }
        }

        private void monitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetMonitorEdid();
        }
    }
}
