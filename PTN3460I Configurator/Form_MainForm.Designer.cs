using System.Drawing;

namespace PTN3460I_Configurator
{
    partial class Form_MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTNPinsConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Read_CFG_from_STM32_Current_state_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Write_CFG_to_STM32_Online_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fLASHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eEPROMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.priorityStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fLASHBitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FLASH_bits_Show_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FLASH_bits_Hide_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eEPROMBitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EEPROM_bits_Show_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EEPROM_bits_Hide_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.controlPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTN3460ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.industrialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Reset_PTN_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Show_device_info_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.About_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_DeviceStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Priority_CFG_bits_storage_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.STM_EEPROM_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.EDID_EEPROM_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Read_Write_status_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_DeviceErrorMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox_PD_N = new System.Windows.Forms.RichTextBox();
            this.richTextBox_TESTMODE = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CFG3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CFG2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CFG1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CFG4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_DEV_CFG = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_STATE_LOW_PD_N = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_HIGH_PD_N = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_OPEN_PD_N = new System.Windows.Forms.RadioButton();
            this.label_PD_N = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_STATE_LOW_CFG4 = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_OPEN_CFG4 = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_HIGH_CFG4 = new System.Windows.Forms.RadioButton();
            this.label_CFG_4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_STATE_LOW_CFG3 = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_OPEN_CFG3 = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_HIGH_CFG3 = new System.Windows.Forms.RadioButton();
            this.label_CFG_3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_STATE_LOW_CFG2 = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_OPEN_CFG2 = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_HIGH_CFG2 = new System.Windows.Forms.RadioButton();
            this.label_CFG_2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_STATE_LOW_CFG1 = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_OPEN_CFG1 = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_HIGH_CFG1 = new System.Windows.Forms.RadioButton();
            this.label_CFG_1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_STATE_LOW_TESTMODE = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_OPEN_TESTMODE = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_HIGH_TESTMODE = new System.Windows.Forms.RadioButton();
            this.label_TESTMODE = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label_DEV_CFG = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_STATE_LOW_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_OPEN_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.radioButton_STATE_HIGH_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_LOW_PD_N = new System.Windows.Forms.RadioButton();
            this.radioButton_HIGH_PD_N = new System.Windows.Forms.RadioButton();
            this.radioButton_OPEN_PD_N = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_OPEN_CFG4 = new System.Windows.Forms.RadioButton();
            this.radioButton_HIGH_CFG4 = new System.Windows.Forms.RadioButton();
            this.radioButton_LOW_CFG4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_LOW_CFG3 = new System.Windows.Forms.RadioButton();
            this.radioButton_OPEN_CFG3 = new System.Windows.Forms.RadioButton();
            this.radioButton_HIGH_CFG3 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_LOW_CFG2 = new System.Windows.Forms.RadioButton();
            this.radioButton_OPEN_CFG2 = new System.Windows.Forms.RadioButton();
            this.radioButton_HIGH_CFG2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_LOW_CFG1 = new System.Windows.Forms.RadioButton();
            this.radioButton_OPEN_CFG1 = new System.Windows.Forms.RadioButton();
            this.radioButton_HIGH_CFG1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel28 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel29 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_LOW_TESTMODE = new System.Windows.Forms.RadioButton();
            this.radioButton_OPEN_TESTMODE = new System.Windows.Forms.RadioButton();
            this.radioButton_HIGH_TESTMODE = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel30 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel31 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_LOW_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.radioButton_OPEN_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.radioButton_HIGH_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel32 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel33 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel34 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_FLASH_LOW_PD_N = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_HIGH_PD_N = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_OPEN_PD_N = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel35 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel36 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_FLASH_LOW_CFG4 = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_OPEN_CFG4 = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_HIGH_CFG4 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel37 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel38 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_FLASH_LOW_CFG3 = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_OPEN_CFG3 = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_HIGH_CFG3 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel39 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel40 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_FLASH_LOW_CFG2 = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_OPEN_CFG2 = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_HIGH_CFG2 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel41 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel42 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_FLASH_LOW_CFG1 = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_OPEN_CFG1 = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_HIGH_CFG1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel43 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel44 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_FLASH_LOW_TESTMODE = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_OPEN_TESTMODE = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_HIGH_TESTMODE = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.tableLayoutPanel45 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.tableLayoutPanel46 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_FLASH_LOW_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_OPEN_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.radioButton_FLASH_HIGH_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel47 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel48 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel49 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_EEPROM_LOW_PD_N = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_HIGH_PD_N = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_OPEN_PD_N = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel50 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel51 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_EEPROM_LOW_CFG4 = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_OPEN_CFG4 = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_HIGH_CFG4 = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.tableLayoutPanel52 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel53 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_EEPROM_LOW_CFG3 = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_OPEN_CFG3 = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_HIGH_CFG3 = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel54 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel55 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_EEPROM_LOW_CFG2 = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_OPEN_CFG2 = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_HIGH_CFG2 = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.tableLayoutPanel56 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel57 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_EEPROM_LOW_CFG1 = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_OPEN_CFG1 = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_HIGH_CFG1 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.tableLayoutPanel58 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel59 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_EEPROM_LOW_TESTMODE = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_OPEN_TESTMODE = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_HIGH_TESTMODE = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.tableLayoutPanel60 = new System.Windows.Forms.TableLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel61 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton_EEPROM_LOW_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_OPEN_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.radioButton_EEPROM_HIGH_DEV_CFG = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox_cfg_bits_setup_mem_type = new System.Windows.Forms.RichTextBox();
            this.label_frame_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_CFG_bits_description = new System.Windows.Forms.Label();
            this.panel_current_state_bits = new System.Windows.Forms.Panel();
            this.richTextBox_current_bits_state_mem_type = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel_FLASH_bits = new System.Windows.Forms.Panel();
            this.richTextBox_cfg_in_flash_mem_type = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel_EEPROM_bits = new System.Windows.Forms.Panel();
            this.richTextBox_cfg_in_eeprom_mem_type = new System.Windows.Forms.RichTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tableLayoutPanel28.SuspendLayout();
            this.tableLayoutPanel29.SuspendLayout();
            this.tableLayoutPanel30.SuspendLayout();
            this.tableLayoutPanel31.SuspendLayout();
            this.tableLayoutPanel32.SuspendLayout();
            this.tableLayoutPanel33.SuspendLayout();
            this.tableLayoutPanel34.SuspendLayout();
            this.tableLayoutPanel35.SuspendLayout();
            this.tableLayoutPanel36.SuspendLayout();
            this.tableLayoutPanel37.SuspendLayout();
            this.tableLayoutPanel38.SuspendLayout();
            this.tableLayoutPanel39.SuspendLayout();
            this.tableLayoutPanel40.SuspendLayout();
            this.tableLayoutPanel41.SuspendLayout();
            this.tableLayoutPanel42.SuspendLayout();
            this.tableLayoutPanel43.SuspendLayout();
            this.tableLayoutPanel44.SuspendLayout();
            this.tableLayoutPanel45.SuspendLayout();
            this.tableLayoutPanel46.SuspendLayout();
            this.tableLayoutPanel47.SuspendLayout();
            this.tableLayoutPanel48.SuspendLayout();
            this.tableLayoutPanel49.SuspendLayout();
            this.tableLayoutPanel50.SuspendLayout();
            this.tableLayoutPanel51.SuspendLayout();
            this.tableLayoutPanel52.SuspendLayout();
            this.tableLayoutPanel53.SuspendLayout();
            this.tableLayoutPanel54.SuspendLayout();
            this.tableLayoutPanel55.SuspendLayout();
            this.tableLayoutPanel56.SuspendLayout();
            this.tableLayoutPanel57.SuspendLayout();
            this.tableLayoutPanel58.SuspendLayout();
            this.tableLayoutPanel59.SuspendLayout();
            this.tableLayoutPanel60.SuspendLayout();
            this.tableLayoutPanel61.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_current_state_bits.SuspendLayout();
            this.panel_FLASH_bits.SuspendLayout();
            this.panel_EEPROM_bits.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.pTNPinsConfigToolStripMenuItem,
            this.eDIDToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.monitorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1504, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.disconnectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.clearToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pTNPinsConfigToolStripMenuItem
            // 
            this.pTNPinsConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineModeToolStripMenuItem,
            this.toolStripSeparator4,
            this.fLASHToolStripMenuItem,
            this.eEPROMToolStripMenuItem,
            this.toolStripSeparator6,
            this.priorityStorageToolStripMenuItem});
            this.pTNPinsConfigToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pTNPinsConfigToolStripMenuItem.Name = "pTNPinsConfigToolStripMenuItem";
            this.pTNPinsConfigToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.pTNPinsConfigToolStripMenuItem.Text = "PTN CFG bits";
            this.pTNPinsConfigToolStripMenuItem.ToolTipText = "PTN 3460 configuration settings using pin\'s state";
            // 
            // onlineModeToolStripMenuItem
            // 
            this.onlineModeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.onlineModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Read_CFG_from_STM32_Current_state_ToolStripMenuItem,
            this.Write_CFG_to_STM32_Online_ToolStripMenuItem});
            this.onlineModeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.onlineModeToolStripMenuItem.Name = "onlineModeToolStripMenuItem";
            this.onlineModeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.onlineModeToolStripMenuItem.Text = "Online mode";
            // 
            // Read_CFG_from_STM32_Current_state_ToolStripMenuItem
            // 
            this.Read_CFG_from_STM32_Current_state_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Read_CFG_from_STM32_Current_state_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Read_CFG_from_STM32_Current_state_ToolStripMenuItem.Name = "Read_CFG_from_STM32_Current_state_ToolStripMenuItem";
            this.Read_CFG_from_STM32_Current_state_ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.Read_CFG_from_STM32_Current_state_ToolStripMenuItem.Text = "Read";
            this.Read_CFG_from_STM32_Current_state_ToolStripMenuItem.Click += new System.EventHandler(this.Current_State_PTN_Configuration_bits_ToolStripMenuItem_Click);
            // 
            // Write_CFG_to_STM32_Online_ToolStripMenuItem
            // 
            this.Write_CFG_to_STM32_Online_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Write_CFG_to_STM32_Online_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Write_CFG_to_STM32_Online_ToolStripMenuItem.Name = "Write_CFG_to_STM32_Online_ToolStripMenuItem";
            this.Write_CFG_to_STM32_Online_ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.Write_CFG_to_STM32_Online_ToolStripMenuItem.Text = "Write";
            this.Write_CFG_to_STM32_Online_ToolStripMenuItem.Click += new System.EventHandler(this.Write_CFG_to_STM32_Online_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(151, 6);
            // 
            // fLASHToolStripMenuItem
            // 
            this.fLASHToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fLASHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem,
            this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem});
            this.fLASHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fLASHToolStripMenuItem.Name = "fLASHToolStripMenuItem";
            this.fLASHToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fLASHToolStripMenuItem.Text = "FLASH";
            // 
            // Read_CFG_from_STM32_FLASH_ToolStripMenuItem
            // 
            this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem.Name = "Read_CFG_from_STM32_FLASH_ToolStripMenuItem";
            this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem.Text = "Read";
            this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem.Click += new System.EventHandler(this.Read_CFG_from_STM32_FLASH_ToolStripMenuItem_Click);
            // 
            // Write_CFG_to_STM32_FLASH_ToolStripMenuItem
            // 
            this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem.Name = "Write_CFG_to_STM32_FLASH_ToolStripMenuItem";
            this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem.Text = "Write";
            this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem.Click += new System.EventHandler(this.Write_CFG_to_STM32_FLASH_ToolStripMenuItem_Click);
            // 
            // eEPROMToolStripMenuItem
            // 
            this.eEPROMToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.eEPROMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem,
            this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem});
            this.eEPROMToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eEPROMToolStripMenuItem.Name = "eEPROMToolStripMenuItem";
            this.eEPROMToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.eEPROMToolStripMenuItem.Text = "EEPROM";
            // 
            // Read_CFG_from_STM32_EEPROM_ToolStripMenuItem
            // 
            this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem.Name = "Read_CFG_from_STM32_EEPROM_ToolStripMenuItem";
            this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem.Text = "Read";
            this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem.Click += new System.EventHandler(this.Read_CFG_from_STM32_EEPROM_ToolStripMenuItem_Click);
            // 
            // Write_CFG_to_STM32_EEPROM_ToolStripMenuItem
            // 
            this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem.Name = "Write_CFG_to_STM32_EEPROM_ToolStripMenuItem";
            this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem.Text = "Write";
            this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem.Click += new System.EventHandler(this.Write_CFG_to_STM32_EEPROM_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(151, 6);
            // 
            // priorityStorageToolStripMenuItem
            // 
            this.priorityStorageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.priorityStorageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem,
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem});
            this.priorityStorageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.priorityStorageToolStripMenuItem.Name = "priorityStorageToolStripMenuItem";
            this.priorityStorageToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.priorityStorageToolStripMenuItem.Text = "Priority storage";
            this.priorityStorageToolStripMenuItem.ToolTipText = "Select the priority of CFG storage";
            // 
            // Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem
            // 
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.CheckOnClick = true;
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Name = "Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem";
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Text = "EEPROM";
            this.Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem.Click += new System.EventHandler(this.Set_priority_CFG_storage);
            // 
            // Priority_CFG_bits_storage_FLASH_ToolStripMenuItem
            // 
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.CheckOnClick = true;
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Name = "Priority_CFG_bits_storage_FLASH_ToolStripMenuItem";
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Text = "FLASH";
            this.Priority_CFG_bits_storage_FLASH_ToolStripMenuItem.Click += new System.EventHandler(this.Set_priority_CFG_storage);
            // 
            // eDIDToolStripMenuItem
            // 
            this.eDIDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eDIDToolStripMenuItem.Name = "eDIDToolStripMenuItem";
            this.eDIDToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.eDIDToolStripMenuItem.Text = "EDID";
            this.eDIDToolStripMenuItem.ToolTipText = "EDID & CFG for PTN 3460 EEPROM";
            this.eDIDToolStripMenuItem.Click += new System.EventHandler(this.eDIDToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fLASHBitsToolStripMenuItem,
            this.eEPROMBitsToolStripMenuItem,
            this.toolStripSeparator7,
            this.controlPanelToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fLASHBitsToolStripMenuItem
            // 
            this.fLASHBitsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fLASHBitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FLASH_bits_Show_ToolStripMenuItem,
            this.FLASH_bits_Hide_ToolStripMenuItem});
            this.fLASHBitsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fLASHBitsToolStripMenuItem.Name = "fLASHBitsToolStripMenuItem";
            this.fLASHBitsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.fLASHBitsToolStripMenuItem.Text = "FLASH bits";
            // 
            // FLASH_bits_Show_ToolStripMenuItem
            // 
            this.FLASH_bits_Show_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FLASH_bits_Show_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.FLASH_bits_Show_ToolStripMenuItem.Name = "FLASH_bits_Show_ToolStripMenuItem";
            this.FLASH_bits_Show_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FLASH_bits_Show_ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.FLASH_bits_Show_ToolStripMenuItem.Text = "Show";
            this.FLASH_bits_Show_ToolStripMenuItem.Click += new System.EventHandler(this.FLASH_bits_Show_ToolStripMenuItem_Click);
            // 
            // FLASH_bits_Hide_ToolStripMenuItem
            // 
            this.FLASH_bits_Hide_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FLASH_bits_Hide_ToolStripMenuItem.Enabled = false;
            this.FLASH_bits_Hide_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.FLASH_bits_Hide_ToolStripMenuItem.Name = "FLASH_bits_Hide_ToolStripMenuItem";
            this.FLASH_bits_Hide_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.FLASH_bits_Hide_ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.FLASH_bits_Hide_ToolStripMenuItem.Text = "Hide";
            this.FLASH_bits_Hide_ToolStripMenuItem.Click += new System.EventHandler(this.FLASH_bits_Hide_ToolStripMenuItem_Click);
            // 
            // eEPROMBitsToolStripMenuItem
            // 
            this.eEPROMBitsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.eEPROMBitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EEPROM_bits_Show_ToolStripMenuItem,
            this.EEPROM_bits_Hide_ToolStripMenuItem});
            this.eEPROMBitsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eEPROMBitsToolStripMenuItem.Name = "eEPROMBitsToolStripMenuItem";
            this.eEPROMBitsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.eEPROMBitsToolStripMenuItem.Text = "EEPROM bits";
            // 
            // EEPROM_bits_Show_ToolStripMenuItem
            // 
            this.EEPROM_bits_Show_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EEPROM_bits_Show_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EEPROM_bits_Show_ToolStripMenuItem.Name = "EEPROM_bits_Show_ToolStripMenuItem";
            this.EEPROM_bits_Show_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.EEPROM_bits_Show_ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.EEPROM_bits_Show_ToolStripMenuItem.Text = "Show";
            this.EEPROM_bits_Show_ToolStripMenuItem.Click += new System.EventHandler(this.EEPROM_bits_Show_ToolStripMenuItem_Click);
            // 
            // EEPROM_bits_Hide_ToolStripMenuItem
            // 
            this.EEPROM_bits_Hide_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EEPROM_bits_Hide_ToolStripMenuItem.Enabled = false;
            this.EEPROM_bits_Hide_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.EEPROM_bits_Hide_ToolStripMenuItem.Name = "EEPROM_bits_Hide_ToolStripMenuItem";
            this.EEPROM_bits_Hide_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.EEPROM_bits_Hide_ToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.EEPROM_bits_Hide_ToolStripMenuItem.Text = "Hide";
            this.EEPROM_bits_Hide_ToolStripMenuItem.Click += new System.EventHandler(this.EEPROM_bits_Hide_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(184, 6);
            // 
            // controlPanelToolStripMenuItem
            // 
            this.controlPanelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.controlPanelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.controlPanelToolStripMenuItem.Image = global::PTN3460I_Configurator.Properties.Resources.light_automation_w16;
            this.controlPanelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.controlPanelToolStripMenuItem.Name = "controlPanelToolStripMenuItem";
            this.controlPanelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.controlPanelToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.controlPanelToolStripMenuItem.Text = "Control panel";
            this.controlPanelToolStripMenuItem.Click += new System.EventHandler(this.controlPanelToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pTN3460ToolStripMenuItem,
            this.toolStripSeparator3,
            this.Reset_PTN_ToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // pTN3460ToolStripMenuItem
            // 
            this.pTN3460ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pTN3460ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commercialToolStripMenuItem,
            this.industrialToolStripMenuItem});
            this.pTN3460ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pTN3460ToolStripMenuItem.Name = "pTN3460ToolStripMenuItem";
            this.pTN3460ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.pTN3460ToolStripMenuItem.Text = "PTN 3460 type select";
            // 
            // commercialToolStripMenuItem
            // 
            this.commercialToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.commercialToolStripMenuItem.CheckOnClick = true;
            this.commercialToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.commercialToolStripMenuItem.Name = "commercialToolStripMenuItem";
            this.commercialToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.commercialToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.commercialToolStripMenuItem.Text = "Commercial (3460 )";
            this.commercialToolStripMenuItem.Click += new System.EventHandler(this.commercialToolStripMenuItem_Click);
            // 
            // industrialToolStripMenuItem
            // 
            this.industrialToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.industrialToolStripMenuItem.Checked = true;
            this.industrialToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.industrialToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.industrialToolStripMenuItem.Name = "industrialToolStripMenuItem";
            this.industrialToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.industrialToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.industrialToolStripMenuItem.Text = "Industrial (3460 I)";
            this.industrialToolStripMenuItem.Click += new System.EventHandler(this.industrialToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // Reset_PTN_ToolStripMenuItem
            // 
            this.Reset_PTN_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Reset_PTN_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Reset_PTN_ToolStripMenuItem.Name = "Reset_PTN_ToolStripMenuItem";
            this.Reset_PTN_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.Reset_PTN_ToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.Reset_PTN_ToolStripMenuItem.Text = "Reset PTN";
            this.Reset_PTN_ToolStripMenuItem.Click += new System.EventHandler(this.Reset_PTN_ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Show_device_info_toolStripMenuItem,
            this.toolStripSeparator5,
            this.About_ToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Show_device_info_toolStripMenuItem
            // 
            this.Show_device_info_toolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Show_device_info_toolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.Show_device_info_toolStripMenuItem.Name = "Show_device_info_toolStripMenuItem";
            this.Show_device_info_toolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.Show_device_info_toolStripMenuItem.Text = "Device Info";
            this.Show_device_info_toolStripMenuItem.Click += new System.EventHandler(this.Show_device_info_toolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(246, 6);
            // 
            // About_ToolStripMenuItem
            // 
            this.About_ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.About_ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.About_ToolStripMenuItem.Name = "About_ToolStripMenuItem";
            this.About_ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.About_ToolStripMenuItem.Text = "About PTN33460/I configurator...";
            this.About_ToolStripMenuItem.Click += new System.EventHandler(this.About_ToolStripMenuItem_Click);
            // 
            // monitorsToolStripMenuItem
            // 
            this.monitorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.monitorsToolStripMenuItem.Name = "monitorsToolStripMenuItem";
            this.monitorsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.monitorsToolStripMenuItem.Text = "Monitors";
            this.monitorsToolStripMenuItem.Click += new System.EventHandler(this.monitorsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_DeviceStatus,
            this.toolStripStatusLabel2,
            this.Priority_CFG_bits_storage_toolStripStatusLabel,
            this.toolStripStatusLabel4,
            this.STM_EEPROM_toolStripStatusLabel,
            this.toolStripStatusLabel6,
            this.EDID_EEPROM_toolStripStatusLabel,
            this.toolStripStatusLabel3,
            this.Read_Write_status_toolStripStatusLabel,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel_DeviceErrorMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 615);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1504, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_DeviceStatus
            // 
            this.toolStripStatusLabel_DeviceStatus.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel_DeviceStatus.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.toolStripStatusLabel_DeviceStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripStatusLabel_DeviceStatus.Name = "toolStripStatusLabel_DeviceStatus";
            this.toolStripStatusLabel_DeviceStatus.Size = new System.Drawing.Size(184, 17);
            this.toolStripStatusLabel_DeviceStatus.Text = "toolStripStatusLabel_DeviceStatus";
            this.toolStripStatusLabel_DeviceStatus.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripStatusLabel_DeviceStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolStripStatusLabel_DeviceStatus.ToolTipText = "Device connection status";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Image = global::PTN3460I_Configurator.Properties.Resources.separator;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            // 
            // Priority_CFG_bits_storage_toolStripStatusLabel
            // 
            this.Priority_CFG_bits_storage_toolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Priority_CFG_bits_storage_toolStripStatusLabel.Name = "Priority_CFG_bits_storage_toolStripStatusLabel";
            this.Priority_CFG_bits_storage_toolStripStatusLabel.Size = new System.Drawing.Size(134, 17);
            this.Priority_CFG_bits_storage_toolStripStatusLabel.Text = "Priority CFG bits storage";
            this.Priority_CFG_bits_storage_toolStripStatusLabel.ToolTipText = "Priority of using memory";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel4.Enabled = false;
            this.toolStripStatusLabel4.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel4.Image = global::PTN3460I_Configurator.Properties.Resources.separator;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
            // 
            // STM_EEPROM_toolStripStatusLabel
            // 
            this.STM_EEPROM_toolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.STM_EEPROM_toolStripStatusLabel.Name = "STM_EEPROM_toolStripStatusLabel";
            this.STM_EEPROM_toolStripStatusLabel.Size = new System.Drawing.Size(99, 17);
            this.STM_EEPROM_toolStripStatusLabel.Text = "STM_EEPROM_SL";
            this.STM_EEPROM_toolStripStatusLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.STM_EEPROM_toolStripStatusLabel.ToolTipText = "Status of STM32 EEPROM";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel6.Enabled = false;
            this.toolStripStatusLabel6.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel6.Image = global::PTN3460I_Configurator.Properties.Resources.separator;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 17);
            // 
            // EDID_EEPROM_toolStripStatusLabel
            // 
            this.EDID_EEPROM_toolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EDID_EEPROM_toolStripStatusLabel.Name = "EDID_EEPROM_toolStripStatusLabel";
            this.EDID_EEPROM_toolStripStatusLabel.Size = new System.Drawing.Size(100, 17);
            this.EDID_EEPROM_toolStripStatusLabel.Text = "EDID_EEPROM_SL";
            this.EDID_EEPROM_toolStripStatusLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EDID_EEPROM_toolStripStatusLabel.ToolTipText = "Status of EDID EEPROM";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel3.Enabled = false;
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Image = global::PTN3460I_Configurator.Properties.Resources.separator;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(16, 17);
            // 
            // Read_Write_status_toolStripStatusLabel
            // 
            this.Read_Write_status_toolStripStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Read_Write_status_toolStripStatusLabel.Name = "Read_Write_status_toolStripStatusLabel";
            this.Read_Write_status_toolStripStatusLabel.Size = new System.Drawing.Size(64, 17);
            this.Read_Write_status_toolStripStatusLabel.Text = "R/W status";
            this.Read_Write_status_toolStripStatusLabel.ToolTipText = "Data status";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabel5.Enabled = false;
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel5.Image = global::PTN3460I_Configurator.Properties.Resources.separator;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(16, 17);
            // 
            // toolStripStatusLabel_DeviceErrorMessage
            // 
            this.toolStripStatusLabel_DeviceErrorMessage.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel_DeviceErrorMessage.ForeColor = System.Drawing.Color.OrangeRed;
            this.toolStripStatusLabel_DeviceErrorMessage.Image = global::PTN3460I_Configurator.Properties.Resources.bug;
            this.toolStripStatusLabel_DeviceErrorMessage.Name = "toolStripStatusLabel_DeviceErrorMessage";
            this.toolStripStatusLabel_DeviceErrorMessage.Size = new System.Drawing.Size(239, 17);
            this.toolStripStatusLabel_DeviceErrorMessage.Text = "toolStripStatusLabel_DeviceErrorMessage";
            this.toolStripStatusLabel_DeviceErrorMessage.ToolTipText = "Error message field";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_PD_N, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_TESTMODE, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_CFG3, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_CFG2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_CFG1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_CFG4, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox_DEV_CFG, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(554, 543);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // richTextBox_PD_N
            // 
            this.richTextBox_PD_N.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_PD_N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_PD_N.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_PD_N.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_PD_N.ForeColor = System.Drawing.Color.White;
            this.richTextBox_PD_N.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_PD_N.Name = "richTextBox_PD_N";
            this.richTextBox_PD_N.ReadOnly = true;
            this.richTextBox_PD_N.Size = new System.Drawing.Size(548, 71);
            this.richTextBox_PD_N.TabIndex = 18;
            this.richTextBox_PD_N.TabStop = false;
            this.richTextBox_PD_N.Text = "               Chip power down settings (active low)\n LOW  - device is in Deep po" +
    "wer-down \n OPEN - device will not enter Deep power-saving state\n HIGH - device i" +
    "n Active state (preffered)";
            // 
            // richTextBox_TESTMODE
            // 
            this.richTextBox_TESTMODE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_TESTMODE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_TESTMODE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_TESTMODE.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.richTextBox_TESTMODE.Location = new System.Drawing.Point(3, 157);
            this.richTextBox_TESTMODE.Name = "richTextBox_TESTMODE";
            this.richTextBox_TESTMODE.ReadOnly = true;
            this.richTextBox_TESTMODE.Size = new System.Drawing.Size(548, 71);
            this.richTextBox_TESTMODE.TabIndex = 17;
            this.richTextBox_TESTMODE.TabStop = false;
            this.richTextBox_TESTMODE.Text = "                    TESTMODE settings pin\n LOW  - CFG[4:1] operate as configurati" +
    "on pins\n OPEN - CFG[4:1] operate as JTAG pins\n HIGH - CFG[4:1] operate as JTAG p" +
    "ins";
            // 
            // richTextBox_CFG3
            // 
            this.richTextBox_CFG3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CFG3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_CFG3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_CFG3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_CFG3.ForeColor = System.Drawing.Color.White;
            this.richTextBox_CFG3.Location = new System.Drawing.Point(3, 388);
            this.richTextBox_CFG3.Name = "richTextBox_CFG3";
            this.richTextBox_CFG3.ReadOnly = true;
            this.richTextBox_CFG3.Size = new System.Drawing.Size(548, 71);
            this.richTextBox_CFG3.TabIndex = 15;
            this.richTextBox_CFG3.TabStop = false;
            this.richTextBox_CFG3.Text = "              LVDS clock frequency spread depth control\n LOW  - 0% \n OPEN - 1% \n " +
    "HIGH - 0.5% ";
            // 
            // richTextBox_CFG2
            // 
            this.richTextBox_CFG2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CFG2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_CFG2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_CFG2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_CFG2.ForeColor = System.Drawing.Color.White;
            this.richTextBox_CFG2.Location = new System.Drawing.Point(3, 311);
            this.richTextBox_CFG2.Name = "richTextBox_CFG2";
            this.richTextBox_CFG2.ReadOnly = true;
            this.richTextBox_CFG2.Size = new System.Drawing.Size(548, 71);
            this.richTextBox_CFG2.TabIndex = 15;
            this.richTextBox_CFG2.TabStop = false;
            this.richTextBox_CFG2.Text = "                       LVDS data format settings\n LOW  - VESA 24 bit per pixel\n O" +
    "PEN - JEIDA 24 bit per pixel\n HIGH - VESA or JEIDA 18 bbp";
            // 
            // richTextBox_CFG1
            // 
            this.richTextBox_CFG1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CFG1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_CFG1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_CFG1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_CFG1.ForeColor = System.Drawing.Color.White;
            this.richTextBox_CFG1.Location = new System.Drawing.Point(3, 234);
            this.richTextBox_CFG1.Name = "richTextBox_CFG1";
            this.richTextBox_CFG1.ReadOnly = true;
            this.richTextBox_CFG1.Size = new System.Drawing.Size(548, 71);
            this.richTextBox_CFG1.TabIndex = 0;
            this.richTextBox_CFG1.TabStop = false;
            this.richTextBox_CFG1.Text = "                       Nuber of LVDS links\n LOW  - single LVDS bus\n OPEN - do not" +
    " use that mode!\n HIGH - dual LVDS bus";
            // 
            // richTextBox_CFG4
            // 
            this.richTextBox_CFG4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_CFG4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_CFG4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_CFG4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_CFG4.ForeColor = System.Drawing.Color.White;
            this.richTextBox_CFG4.Location = new System.Drawing.Point(3, 465);
            this.richTextBox_CFG4.Name = "richTextBox_CFG4";
            this.richTextBox_CFG4.ReadOnly = true;
            this.richTextBox_CFG4.Size = new System.Drawing.Size(548, 75);
            this.richTextBox_CFG4.TabIndex = 16;
            this.richTextBox_CFG4.TabStop = false;
            this.richTextBox_CFG4.Text = "                 LVDS output swing (typical value)\n LOW  - 250 mV \n OPEN - 300 mV" +
    " \n HIGH - 400 mV ";
            // 
            // richTextBox_DEV_CFG
            // 
            this.richTextBox_DEV_CFG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_DEV_CFG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_DEV_CFG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_DEV_CFG.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.richTextBox_DEV_CFG.Location = new System.Drawing.Point(3, 80);
            this.richTextBox_DEV_CFG.Name = "richTextBox_DEV_CFG";
            this.richTextBox_DEV_CFG.ReadOnly = true;
            this.richTextBox_DEV_CFG.Size = new System.Drawing.Size(548, 71);
            this.richTextBox_DEV_CFG.TabIndex = 18;
            this.richTextBox_DEV_CFG.TabStop = false;
            this.richTextBox_DEV_CFG.Text = resources.GetString("richTextBox_DEV_CFG.Text");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel16, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel14, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label_PD_N, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel4.TabIndex = 16;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.radioButton_STATE_LOW_PD_N, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.radioButton_STATE_HIGH_PD_N, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.radioButton_STATE_OPEN_PD_N, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // radioButton_STATE_LOW_PD_N
            // 
            this.radioButton_STATE_LOW_PD_N.AutoCheck = false;
            this.radioButton_STATE_LOW_PD_N.AutoSize = true;
            this.radioButton_STATE_LOW_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_LOW_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_LOW_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_LOW_PD_N.Location = new System.Drawing.Point(4, 4);
            this.radioButton_STATE_LOW_PD_N.Name = "radioButton_STATE_LOW_PD_N";
            this.radioButton_STATE_LOW_PD_N.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_LOW_PD_N.TabIndex = 0;
            this.radioButton_STATE_LOW_PD_N.Text = "LOW";
            this.radioButton_STATE_LOW_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_LOW_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_STATE_LOW_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_HIGH_PD_N
            // 
            this.radioButton_STATE_HIGH_PD_N.AutoCheck = false;
            this.radioButton_STATE_HIGH_PD_N.AutoSize = true;
            this.radioButton_STATE_HIGH_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_HIGH_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_HIGH_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_HIGH_PD_N.Location = new System.Drawing.Point(140, 4);
            this.radioButton_STATE_HIGH_PD_N.Name = "radioButton_STATE_HIGH_PD_N";
            this.radioButton_STATE_HIGH_PD_N.Size = new System.Drawing.Size(62, 31);
            this.radioButton_STATE_HIGH_PD_N.TabIndex = 2;
            this.radioButton_STATE_HIGH_PD_N.Text = "HIGH";
            this.radioButton_STATE_HIGH_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_HIGH_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_STATE_HIGH_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_OPEN_PD_N
            // 
            this.radioButton_STATE_OPEN_PD_N.AutoCheck = false;
            this.radioButton_STATE_OPEN_PD_N.AutoSize = true;
            this.radioButton_STATE_OPEN_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_OPEN_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_OPEN_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_OPEN_PD_N.Location = new System.Drawing.Point(72, 4);
            this.radioButton_STATE_OPEN_PD_N.Name = "radioButton_STATE_OPEN_PD_N";
            this.radioButton_STATE_OPEN_PD_N.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_OPEN_PD_N.TabIndex = 1;
            this.radioButton_STATE_OPEN_PD_N.Text = "OPEN";
            this.radioButton_STATE_OPEN_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_OPEN_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_STATE_OPEN_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label_PD_N
            // 
            this.label_PD_N.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_PD_N.AutoSize = true;
            this.label_PD_N.ForeColor = System.Drawing.Color.White;
            this.label_PD_N.Location = new System.Drawing.Point(82, 0);
            this.label_PD_N.Name = "label_PD_N";
            this.label_PD_N.Size = new System.Drawing.Size(48, 26);
            this.label_PD_N.TabIndex = 0;
            this.label_PD_N.Text = "PD_N";
            this.label_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.label_CFG_4, 0, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(212, 75);
            this.tableLayoutPanel16.TabIndex = 15;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel17.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel17.ColumnCount = 3;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.Controls.Add(this.radioButton_STATE_LOW_CFG4, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.radioButton_STATE_OPEN_CFG4, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.radioButton_STATE_HIGH_CFG4, 2, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(206, 41);
            this.tableLayoutPanel17.TabIndex = 14;
            // 
            // radioButton_STATE_LOW_CFG4
            // 
            this.radioButton_STATE_LOW_CFG4.AutoCheck = false;
            this.radioButton_STATE_LOW_CFG4.AutoSize = true;
            this.radioButton_STATE_LOW_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_LOW_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_LOW_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_LOW_CFG4.Location = new System.Drawing.Point(4, 4);
            this.radioButton_STATE_LOW_CFG4.Name = "radioButton_STATE_LOW_CFG4";
            this.radioButton_STATE_LOW_CFG4.Size = new System.Drawing.Size(61, 33);
            this.radioButton_STATE_LOW_CFG4.TabIndex = 14;
            this.radioButton_STATE_LOW_CFG4.Text = "LOW";
            this.radioButton_STATE_LOW_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_LOW_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_STATE_LOW_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_OPEN_CFG4
            // 
            this.radioButton_STATE_OPEN_CFG4.AutoCheck = false;
            this.radioButton_STATE_OPEN_CFG4.AutoSize = true;
            this.radioButton_STATE_OPEN_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_OPEN_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_OPEN_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_OPEN_CFG4.Location = new System.Drawing.Point(72, 4);
            this.radioButton_STATE_OPEN_CFG4.Name = "radioButton_STATE_OPEN_CFG4";
            this.radioButton_STATE_OPEN_CFG4.Size = new System.Drawing.Size(61, 33);
            this.radioButton_STATE_OPEN_CFG4.TabIndex = 15;
            this.radioButton_STATE_OPEN_CFG4.Text = "OPEN";
            this.radioButton_STATE_OPEN_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_OPEN_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_STATE_OPEN_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_HIGH_CFG4
            // 
            this.radioButton_STATE_HIGH_CFG4.AutoCheck = false;
            this.radioButton_STATE_HIGH_CFG4.AutoSize = true;
            this.radioButton_STATE_HIGH_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_HIGH_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_HIGH_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_HIGH_CFG4.Location = new System.Drawing.Point(140, 4);
            this.radioButton_STATE_HIGH_CFG4.Name = "radioButton_STATE_HIGH_CFG4";
            this.radioButton_STATE_HIGH_CFG4.Size = new System.Drawing.Size(62, 33);
            this.radioButton_STATE_HIGH_CFG4.TabIndex = 16;
            this.radioButton_STATE_HIGH_CFG4.Text = "HIGH";
            this.radioButton_STATE_HIGH_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_HIGH_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_STATE_HIGH_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label_CFG_4
            // 
            this.label_CFG_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_CFG_4.AutoSize = true;
            this.label_CFG_4.ForeColor = System.Drawing.Color.White;
            this.label_CFG_4.Location = new System.Drawing.Point(77, 0);
            this.label_CFG_4.Name = "label_CFG_4";
            this.label_CFG_4.Size = new System.Drawing.Size(58, 28);
            this.label_CFG_4.TabIndex = 6;
            this.label_CFG_4.Text = "CFG 4";
            this.label_CFG_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.label_CFG_3, 0, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel14.TabIndex = 15;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel15.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel15.Controls.Add(this.radioButton_STATE_LOW_CFG3, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.radioButton_STATE_OPEN_CFG3, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.radioButton_STATE_HIGH_CFG3, 2, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel15.TabIndex = 14;
            // 
            // radioButton_STATE_LOW_CFG3
            // 
            this.radioButton_STATE_LOW_CFG3.AutoCheck = false;
            this.radioButton_STATE_LOW_CFG3.AutoSize = true;
            this.radioButton_STATE_LOW_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_LOW_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_LOW_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_LOW_CFG3.Location = new System.Drawing.Point(4, 4);
            this.radioButton_STATE_LOW_CFG3.Name = "radioButton_STATE_LOW_CFG3";
            this.radioButton_STATE_LOW_CFG3.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_LOW_CFG3.TabIndex = 14;
            this.radioButton_STATE_LOW_CFG3.Text = "LOW";
            this.radioButton_STATE_LOW_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_LOW_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_STATE_LOW_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_OPEN_CFG3
            // 
            this.radioButton_STATE_OPEN_CFG3.AutoCheck = false;
            this.radioButton_STATE_OPEN_CFG3.AutoSize = true;
            this.radioButton_STATE_OPEN_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_OPEN_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_OPEN_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_OPEN_CFG3.Location = new System.Drawing.Point(72, 4);
            this.radioButton_STATE_OPEN_CFG3.Name = "radioButton_STATE_OPEN_CFG3";
            this.radioButton_STATE_OPEN_CFG3.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_OPEN_CFG3.TabIndex = 15;
            this.radioButton_STATE_OPEN_CFG3.Text = "OPEN";
            this.radioButton_STATE_OPEN_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_OPEN_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_STATE_OPEN_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_HIGH_CFG3
            // 
            this.radioButton_STATE_HIGH_CFG3.AutoCheck = false;
            this.radioButton_STATE_HIGH_CFG3.AutoSize = true;
            this.radioButton_STATE_HIGH_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_HIGH_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_HIGH_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_HIGH_CFG3.Location = new System.Drawing.Point(140, 4);
            this.radioButton_STATE_HIGH_CFG3.Name = "radioButton_STATE_HIGH_CFG3";
            this.radioButton_STATE_HIGH_CFG3.Size = new System.Drawing.Size(62, 31);
            this.radioButton_STATE_HIGH_CFG3.TabIndex = 16;
            this.radioButton_STATE_HIGH_CFG3.Text = "HIGH";
            this.radioButton_STATE_HIGH_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_HIGH_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_STATE_HIGH_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label_CFG_3
            // 
            this.label_CFG_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_CFG_3.AutoSize = true;
            this.label_CFG_3.ForeColor = System.Drawing.Color.White;
            this.label_CFG_3.Location = new System.Drawing.Point(77, 0);
            this.label_CFG_3.Name = "label_CFG_3";
            this.label_CFG_3.Size = new System.Drawing.Size(58, 26);
            this.label_CFG_3.TabIndex = 5;
            this.label_CFG_3.Text = "CFG 3";
            this.label_CFG_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel13, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.label_CFG_2, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 311);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel12.TabIndex = 15;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel13.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.Controls.Add(this.radioButton_STATE_LOW_CFG2, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.radioButton_STATE_OPEN_CFG2, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.radioButton_STATE_HIGH_CFG2, 2, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel13.TabIndex = 14;
            // 
            // radioButton_STATE_LOW_CFG2
            // 
            this.radioButton_STATE_LOW_CFG2.AutoCheck = false;
            this.radioButton_STATE_LOW_CFG2.AutoSize = true;
            this.radioButton_STATE_LOW_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_LOW_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_LOW_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_LOW_CFG2.Location = new System.Drawing.Point(4, 4);
            this.radioButton_STATE_LOW_CFG2.Name = "radioButton_STATE_LOW_CFG2";
            this.radioButton_STATE_LOW_CFG2.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_LOW_CFG2.TabIndex = 14;
            this.radioButton_STATE_LOW_CFG2.Text = "LOW";
            this.radioButton_STATE_LOW_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_LOW_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_STATE_LOW_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_OPEN_CFG2
            // 
            this.radioButton_STATE_OPEN_CFG2.AutoCheck = false;
            this.radioButton_STATE_OPEN_CFG2.AutoSize = true;
            this.radioButton_STATE_OPEN_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_OPEN_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_OPEN_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_OPEN_CFG2.Location = new System.Drawing.Point(72, 4);
            this.radioButton_STATE_OPEN_CFG2.Name = "radioButton_STATE_OPEN_CFG2";
            this.radioButton_STATE_OPEN_CFG2.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_OPEN_CFG2.TabIndex = 15;
            this.radioButton_STATE_OPEN_CFG2.Text = "OPEN";
            this.radioButton_STATE_OPEN_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_OPEN_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_STATE_OPEN_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_HIGH_CFG2
            // 
            this.radioButton_STATE_HIGH_CFG2.AutoCheck = false;
            this.radioButton_STATE_HIGH_CFG2.AutoSize = true;
            this.radioButton_STATE_HIGH_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_HIGH_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_HIGH_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_HIGH_CFG2.Location = new System.Drawing.Point(140, 4);
            this.radioButton_STATE_HIGH_CFG2.Name = "radioButton_STATE_HIGH_CFG2";
            this.radioButton_STATE_HIGH_CFG2.Size = new System.Drawing.Size(62, 31);
            this.radioButton_STATE_HIGH_CFG2.TabIndex = 16;
            this.radioButton_STATE_HIGH_CFG2.Text = "HIGH";
            this.radioButton_STATE_HIGH_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_HIGH_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_STATE_HIGH_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label_CFG_2
            // 
            this.label_CFG_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_CFG_2.AutoSize = true;
            this.label_CFG_2.ForeColor = System.Drawing.Color.White;
            this.label_CFG_2.Location = new System.Drawing.Point(77, 0);
            this.label_CFG_2.Name = "label_CFG_2";
            this.label_CFG_2.Size = new System.Drawing.Size(58, 26);
            this.label_CFG_2.TabIndex = 4;
            this.label_CFG_2.Text = "CFG 2";
            this.label_CFG_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.label_CFG_1, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel10.TabIndex = 15;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel11.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.Controls.Add(this.radioButton_STATE_LOW_CFG1, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.radioButton_STATE_OPEN_CFG1, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.radioButton_STATE_HIGH_CFG1, 2, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel11.TabIndex = 14;
            // 
            // radioButton_STATE_LOW_CFG1
            // 
            this.radioButton_STATE_LOW_CFG1.AutoCheck = false;
            this.radioButton_STATE_LOW_CFG1.AutoSize = true;
            this.radioButton_STATE_LOW_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_LOW_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_LOW_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_LOW_CFG1.Location = new System.Drawing.Point(4, 4);
            this.radioButton_STATE_LOW_CFG1.Name = "radioButton_STATE_LOW_CFG1";
            this.radioButton_STATE_LOW_CFG1.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_LOW_CFG1.TabIndex = 14;
            this.radioButton_STATE_LOW_CFG1.Text = "LOW";
            this.radioButton_STATE_LOW_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_LOW_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_STATE_LOW_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_OPEN_CFG1
            // 
            this.radioButton_STATE_OPEN_CFG1.AutoCheck = false;
            this.radioButton_STATE_OPEN_CFG1.AutoSize = true;
            this.radioButton_STATE_OPEN_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_OPEN_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_OPEN_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_OPEN_CFG1.Location = new System.Drawing.Point(72, 4);
            this.radioButton_STATE_OPEN_CFG1.Name = "radioButton_STATE_OPEN_CFG1";
            this.radioButton_STATE_OPEN_CFG1.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_OPEN_CFG1.TabIndex = 15;
            this.radioButton_STATE_OPEN_CFG1.Text = "OPEN";
            this.radioButton_STATE_OPEN_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_OPEN_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_STATE_OPEN_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_HIGH_CFG1
            // 
            this.radioButton_STATE_HIGH_CFG1.AutoCheck = false;
            this.radioButton_STATE_HIGH_CFG1.AutoSize = true;
            this.radioButton_STATE_HIGH_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_HIGH_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_HIGH_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_HIGH_CFG1.Location = new System.Drawing.Point(140, 4);
            this.radioButton_STATE_HIGH_CFG1.Name = "radioButton_STATE_HIGH_CFG1";
            this.radioButton_STATE_HIGH_CFG1.Size = new System.Drawing.Size(62, 31);
            this.radioButton_STATE_HIGH_CFG1.TabIndex = 16;
            this.radioButton_STATE_HIGH_CFG1.Text = "HIGH";
            this.radioButton_STATE_HIGH_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_HIGH_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_STATE_HIGH_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label_CFG_1
            // 
            this.label_CFG_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_CFG_1.AutoSize = true;
            this.label_CFG_1.ForeColor = System.Drawing.Color.White;
            this.label_CFG_1.Location = new System.Drawing.Point(77, 0);
            this.label_CFG_1.Name = "label_CFG_1";
            this.label_CFG_1.Size = new System.Drawing.Size(58, 26);
            this.label_CFG_1.TabIndex = 3;
            this.label_CFG_1.Text = "CFG 1";
            this.label_CFG_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label_TESTMODE, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 157);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel8.TabIndex = 15;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Controls.Add(this.radioButton_STATE_LOW_TESTMODE, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.radioButton_STATE_OPEN_TESTMODE, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.radioButton_STATE_HIGH_TESTMODE, 2, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel9.TabIndex = 14;
            // 
            // radioButton_STATE_LOW_TESTMODE
            // 
            this.radioButton_STATE_LOW_TESTMODE.AutoCheck = false;
            this.radioButton_STATE_LOW_TESTMODE.AutoSize = true;
            this.radioButton_STATE_LOW_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_LOW_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_LOW_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_LOW_TESTMODE.Location = new System.Drawing.Point(4, 4);
            this.radioButton_STATE_LOW_TESTMODE.Name = "radioButton_STATE_LOW_TESTMODE";
            this.radioButton_STATE_LOW_TESTMODE.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_LOW_TESTMODE.TabIndex = 14;
            this.radioButton_STATE_LOW_TESTMODE.Text = "LOW";
            this.radioButton_STATE_LOW_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_LOW_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_STATE_LOW_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_OPEN_TESTMODE
            // 
            this.radioButton_STATE_OPEN_TESTMODE.AutoCheck = false;
            this.radioButton_STATE_OPEN_TESTMODE.AutoSize = true;
            this.radioButton_STATE_OPEN_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_OPEN_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_OPEN_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_OPEN_TESTMODE.Location = new System.Drawing.Point(72, 4);
            this.radioButton_STATE_OPEN_TESTMODE.Name = "radioButton_STATE_OPEN_TESTMODE";
            this.radioButton_STATE_OPEN_TESTMODE.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_OPEN_TESTMODE.TabIndex = 15;
            this.radioButton_STATE_OPEN_TESTMODE.Text = "OPEN";
            this.radioButton_STATE_OPEN_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_OPEN_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_STATE_OPEN_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_HIGH_TESTMODE
            // 
            this.radioButton_STATE_HIGH_TESTMODE.AutoCheck = false;
            this.radioButton_STATE_HIGH_TESTMODE.AutoSize = true;
            this.radioButton_STATE_HIGH_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_HIGH_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_HIGH_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_HIGH_TESTMODE.Location = new System.Drawing.Point(140, 4);
            this.radioButton_STATE_HIGH_TESTMODE.Name = "radioButton_STATE_HIGH_TESTMODE";
            this.radioButton_STATE_HIGH_TESTMODE.Size = new System.Drawing.Size(62, 31);
            this.radioButton_STATE_HIGH_TESTMODE.TabIndex = 16;
            this.radioButton_STATE_HIGH_TESTMODE.Text = "HIGH";
            this.radioButton_STATE_HIGH_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_HIGH_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_STATE_HIGH_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label_TESTMODE
            // 
            this.label_TESTMODE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_TESTMODE.AutoSize = true;
            this.label_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.label_TESTMODE.Location = new System.Drawing.Point(62, 0);
            this.label_TESTMODE.Name = "label_TESTMODE";
            this.label_TESTMODE.Size = new System.Drawing.Size(88, 26);
            this.label_TESTMODE.TabIndex = 2;
            this.label_TESTMODE.Text = "TESTMODE";
            this.label_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label_DEV_CFG, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel6.TabIndex = 15;
            // 
            // label_DEV_CFG
            // 
            this.label_DEV_CFG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_DEV_CFG.AutoSize = true;
            this.label_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.label_DEV_CFG.Location = new System.Drawing.Point(67, 0);
            this.label_DEV_CFG.Name = "label_DEV_CFG";
            this.label_DEV_CFG.Size = new System.Drawing.Size(78, 26);
            this.label_DEV_CFG.TabIndex = 1;
            this.label_DEV_CFG.Text = "DEV_CFG";
            this.label_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.radioButton_STATE_LOW_DEV_CFG, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.radioButton_STATE_OPEN_DEV_CFG, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.radioButton_STATE_HIGH_DEV_CFG, 2, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel7.TabIndex = 14;
            // 
            // radioButton_STATE_LOW_DEV_CFG
            // 
            this.radioButton_STATE_LOW_DEV_CFG.AutoCheck = false;
            this.radioButton_STATE_LOW_DEV_CFG.AutoSize = true;
            this.radioButton_STATE_LOW_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_LOW_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_LOW_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_LOW_DEV_CFG.Location = new System.Drawing.Point(4, 4);
            this.radioButton_STATE_LOW_DEV_CFG.Name = "radioButton_STATE_LOW_DEV_CFG";
            this.radioButton_STATE_LOW_DEV_CFG.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_LOW_DEV_CFG.TabIndex = 14;
            this.radioButton_STATE_LOW_DEV_CFG.Text = "LOW";
            this.radioButton_STATE_LOW_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_LOW_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_STATE_LOW_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_OPEN_DEV_CFG
            // 
            this.radioButton_STATE_OPEN_DEV_CFG.AutoCheck = false;
            this.radioButton_STATE_OPEN_DEV_CFG.AutoSize = true;
            this.radioButton_STATE_OPEN_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_OPEN_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_OPEN_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_OPEN_DEV_CFG.Location = new System.Drawing.Point(72, 4);
            this.radioButton_STATE_OPEN_DEV_CFG.Name = "radioButton_STATE_OPEN_DEV_CFG";
            this.radioButton_STATE_OPEN_DEV_CFG.Size = new System.Drawing.Size(61, 31);
            this.radioButton_STATE_OPEN_DEV_CFG.TabIndex = 15;
            this.radioButton_STATE_OPEN_DEV_CFG.Text = "OPEN";
            this.radioButton_STATE_OPEN_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_OPEN_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_STATE_OPEN_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_STATE_HIGH_DEV_CFG
            // 
            this.radioButton_STATE_HIGH_DEV_CFG.AutoCheck = false;
            this.radioButton_STATE_HIGH_DEV_CFG.AutoSize = true;
            this.radioButton_STATE_HIGH_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_STATE_HIGH_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_STATE_HIGH_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_STATE_HIGH_DEV_CFG.Location = new System.Drawing.Point(140, 4);
            this.radioButton_STATE_HIGH_DEV_CFG.Name = "radioButton_STATE_HIGH_DEV_CFG";
            this.radioButton_STATE_HIGH_DEV_CFG.Size = new System.Drawing.Size(62, 31);
            this.radioButton_STATE_HIGH_DEV_CFG.TabIndex = 16;
            this.radioButton_STATE_HIGH_DEV_CFG.Text = "HIGH";
            this.radioButton_STATE_HIGH_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_STATE_HIGH_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_STATE_HIGH_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel18, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel20, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel22, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel24, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel26, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel28, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel30, 0, 1);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(218, 543);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel19, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel18.TabIndex = 16;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel19.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel19.ColumnCount = 3;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.Controls.Add(this.radioButton_LOW_PD_N, 0, 0);
            this.tableLayoutPanel19.Controls.Add(this.radioButton_HIGH_PD_N, 2, 0);
            this.tableLayoutPanel19.Controls.Add(this.radioButton_OPEN_PD_N, 1, 0);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel19.TabIndex = 14;
            // 
            // radioButton_LOW_PD_N
            // 
            this.radioButton_LOW_PD_N.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_LOW_PD_N.AutoSize = true;
            this.radioButton_LOW_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_LOW_PD_N.Location = new System.Drawing.Point(4, 4);
            this.radioButton_LOW_PD_N.Name = "radioButton_LOW_PD_N";
            this.radioButton_LOW_PD_N.Size = new System.Drawing.Size(61, 31);
            this.radioButton_LOW_PD_N.TabIndex = 0;
            this.radioButton_LOW_PD_N.Text = "LOW";
            this.radioButton_LOW_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_LOW_PD_N.UseVisualStyleBackColor = false;
            this.radioButton_LOW_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_HIGH_PD_N
            // 
            this.radioButton_HIGH_PD_N.AutoSize = true;
            this.radioButton_HIGH_PD_N.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.radioButton_HIGH_PD_N.Checked = true;
            this.radioButton_HIGH_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_HIGH_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_HIGH_PD_N.Location = new System.Drawing.Point(140, 4);
            this.radioButton_HIGH_PD_N.Name = "radioButton_HIGH_PD_N";
            this.radioButton_HIGH_PD_N.Size = new System.Drawing.Size(62, 31);
            this.radioButton_HIGH_PD_N.TabIndex = 2;
            this.radioButton_HIGH_PD_N.TabStop = true;
            this.radioButton_HIGH_PD_N.Text = "HIGH";
            this.radioButton_HIGH_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_HIGH_PD_N.UseVisualStyleBackColor = false;
            this.radioButton_HIGH_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_OPEN_PD_N
            // 
            this.radioButton_OPEN_PD_N.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OPEN_PD_N.AutoSize = true;
            this.radioButton_OPEN_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_OPEN_PD_N.Location = new System.Drawing.Point(72, 4);
            this.radioButton_OPEN_PD_N.Name = "radioButton_OPEN_PD_N";
            this.radioButton_OPEN_PD_N.Size = new System.Drawing.Size(61, 31);
            this.radioButton_OPEN_PD_N.TabIndex = 1;
            this.radioButton_OPEN_PD_N.Text = "OPEN";
            this.radioButton_OPEN_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.radioButton_OPEN_PD_N, "Open state of pin");
            this.radioButton_OPEN_PD_N.UseVisualStyleBackColor = false;
            this.radioButton_OPEN_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PD_N";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.tableLayoutPanel21, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel20.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(212, 75);
            this.tableLayoutPanel20.TabIndex = 15;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel21.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel21.ColumnCount = 3;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel21.Controls.Add(this.radioButton_OPEN_CFG4, 1, 0);
            this.tableLayoutPanel21.Controls.Add(this.radioButton_HIGH_CFG4, 2, 0);
            this.tableLayoutPanel21.Controls.Add(this.radioButton_LOW_CFG4, 0, 0);
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(206, 41);
            this.tableLayoutPanel21.TabIndex = 14;
            // 
            // radioButton_OPEN_CFG4
            // 
            this.radioButton_OPEN_CFG4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OPEN_CFG4.AutoSize = true;
            this.radioButton_OPEN_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_OPEN_CFG4.Location = new System.Drawing.Point(72, 4);
            this.radioButton_OPEN_CFG4.Name = "radioButton_OPEN_CFG4";
            this.radioButton_OPEN_CFG4.Size = new System.Drawing.Size(61, 33);
            this.radioButton_OPEN_CFG4.TabIndex = 15;
            this.radioButton_OPEN_CFG4.Text = "OPEN";
            this.radioButton_OPEN_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_OPEN_CFG4.UseVisualStyleBackColor = false;
            this.radioButton_OPEN_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_HIGH_CFG4
            // 
            this.radioButton_HIGH_CFG4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_HIGH_CFG4.AutoSize = true;
            this.radioButton_HIGH_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_HIGH_CFG4.Location = new System.Drawing.Point(140, 4);
            this.radioButton_HIGH_CFG4.Name = "radioButton_HIGH_CFG4";
            this.radioButton_HIGH_CFG4.Size = new System.Drawing.Size(62, 33);
            this.radioButton_HIGH_CFG4.TabIndex = 16;
            this.radioButton_HIGH_CFG4.Text = "HIGH";
            this.radioButton_HIGH_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_HIGH_CFG4.UseVisualStyleBackColor = false;
            this.radioButton_HIGH_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_LOW_CFG4
            // 
            this.radioButton_LOW_CFG4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_LOW_CFG4.AutoSize = true;
            this.radioButton_LOW_CFG4.Checked = true;
            this.radioButton_LOW_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_LOW_CFG4.Location = new System.Drawing.Point(4, 4);
            this.radioButton_LOW_CFG4.Name = "radioButton_LOW_CFG4";
            this.radioButton_LOW_CFG4.Size = new System.Drawing.Size(61, 33);
            this.radioButton_LOW_CFG4.TabIndex = 14;
            this.radioButton_LOW_CFG4.TabStop = true;
            this.radioButton_LOW_CFG4.Text = "LOW";
            this.radioButton_LOW_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_LOW_CFG4.UseVisualStyleBackColor = false;
            this.radioButton_LOW_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "CFG 4";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel22.ColumnCount = 1;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel23, 0, 1);
            this.tableLayoutPanel22.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 2;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel22.TabIndex = 15;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel23.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel23.ColumnCount = 3;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel23.Controls.Add(this.radioButton_LOW_CFG3, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.radioButton_OPEN_CFG3, 1, 0);
            this.tableLayoutPanel23.Controls.Add(this.radioButton_HIGH_CFG3, 2, 0);
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel23.TabIndex = 14;
            // 
            // radioButton_LOW_CFG3
            // 
            this.radioButton_LOW_CFG3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_LOW_CFG3.AutoSize = true;
            this.radioButton_LOW_CFG3.Checked = true;
            this.radioButton_LOW_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_LOW_CFG3.Location = new System.Drawing.Point(4, 4);
            this.radioButton_LOW_CFG3.Name = "radioButton_LOW_CFG3";
            this.radioButton_LOW_CFG3.Size = new System.Drawing.Size(61, 31);
            this.radioButton_LOW_CFG3.TabIndex = 14;
            this.radioButton_LOW_CFG3.TabStop = true;
            this.radioButton_LOW_CFG3.Text = "LOW";
            this.radioButton_LOW_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_LOW_CFG3.UseVisualStyleBackColor = false;
            this.radioButton_LOW_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_OPEN_CFG3
            // 
            this.radioButton_OPEN_CFG3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OPEN_CFG3.AutoSize = true;
            this.radioButton_OPEN_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_OPEN_CFG3.Location = new System.Drawing.Point(72, 4);
            this.radioButton_OPEN_CFG3.Name = "radioButton_OPEN_CFG3";
            this.radioButton_OPEN_CFG3.Size = new System.Drawing.Size(61, 31);
            this.radioButton_OPEN_CFG3.TabIndex = 15;
            this.radioButton_OPEN_CFG3.Text = "OPEN";
            this.radioButton_OPEN_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_OPEN_CFG3.UseVisualStyleBackColor = false;
            this.radioButton_OPEN_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_HIGH_CFG3
            // 
            this.radioButton_HIGH_CFG3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_HIGH_CFG3.AutoSize = true;
            this.radioButton_HIGH_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_HIGH_CFG3.Location = new System.Drawing.Point(140, 4);
            this.radioButton_HIGH_CFG3.Name = "radioButton_HIGH_CFG3";
            this.radioButton_HIGH_CFG3.Size = new System.Drawing.Size(62, 31);
            this.radioButton_HIGH_CFG3.TabIndex = 16;
            this.radioButton_HIGH_CFG3.Text = "HIGH";
            this.radioButton_HIGH_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_HIGH_CFG3.UseVisualStyleBackColor = false;
            this.radioButton_HIGH_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "CFG 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel24.ColumnCount = 1;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel24.Controls.Add(this.tableLayoutPanel25, 0, 1);
            this.tableLayoutPanel24.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel24.Location = new System.Drawing.Point(3, 311);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 2;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel24.TabIndex = 15;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel25.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel25.ColumnCount = 3;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel25.Controls.Add(this.radioButton_LOW_CFG2, 0, 0);
            this.tableLayoutPanel25.Controls.Add(this.radioButton_OPEN_CFG2, 1, 0);
            this.tableLayoutPanel25.Controls.Add(this.radioButton_HIGH_CFG2, 2, 0);
            this.tableLayoutPanel25.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 1;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel25.TabIndex = 14;
            // 
            // radioButton_LOW_CFG2
            // 
            this.radioButton_LOW_CFG2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_LOW_CFG2.AutoSize = true;
            this.radioButton_LOW_CFG2.Checked = true;
            this.radioButton_LOW_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_LOW_CFG2.Location = new System.Drawing.Point(4, 4);
            this.radioButton_LOW_CFG2.Name = "radioButton_LOW_CFG2";
            this.radioButton_LOW_CFG2.Size = new System.Drawing.Size(61, 31);
            this.radioButton_LOW_CFG2.TabIndex = 14;
            this.radioButton_LOW_CFG2.TabStop = true;
            this.radioButton_LOW_CFG2.Text = "LOW";
            this.radioButton_LOW_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_LOW_CFG2.UseVisualStyleBackColor = false;
            this.radioButton_LOW_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_OPEN_CFG2
            // 
            this.radioButton_OPEN_CFG2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OPEN_CFG2.AutoSize = true;
            this.radioButton_OPEN_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_OPEN_CFG2.Location = new System.Drawing.Point(72, 4);
            this.radioButton_OPEN_CFG2.Name = "radioButton_OPEN_CFG2";
            this.radioButton_OPEN_CFG2.Size = new System.Drawing.Size(61, 31);
            this.radioButton_OPEN_CFG2.TabIndex = 15;
            this.radioButton_OPEN_CFG2.Text = "OPEN";
            this.radioButton_OPEN_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_OPEN_CFG2.UseVisualStyleBackColor = false;
            this.radioButton_OPEN_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_HIGH_CFG2
            // 
            this.radioButton_HIGH_CFG2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_HIGH_CFG2.AutoSize = true;
            this.radioButton_HIGH_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_HIGH_CFG2.Location = new System.Drawing.Point(140, 4);
            this.radioButton_HIGH_CFG2.Name = "radioButton_HIGH_CFG2";
            this.radioButton_HIGH_CFG2.Size = new System.Drawing.Size(62, 31);
            this.radioButton_HIGH_CFG2.TabIndex = 16;
            this.radioButton_HIGH_CFG2.Text = "HIGH";
            this.radioButton_HIGH_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_HIGH_CFG2.UseVisualStyleBackColor = false;
            this.radioButton_HIGH_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(84, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "CFG 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel26.ColumnCount = 1;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Controls.Add(this.tableLayoutPanel27, 0, 1);
            this.tableLayoutPanel26.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel26.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 2;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel26.TabIndex = 15;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel27.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel27.ColumnCount = 3;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel27.Controls.Add(this.radioButton_LOW_CFG1, 0, 0);
            this.tableLayoutPanel27.Controls.Add(this.radioButton_OPEN_CFG1, 1, 0);
            this.tableLayoutPanel27.Controls.Add(this.radioButton_HIGH_CFG1, 2, 0);
            this.tableLayoutPanel27.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 1;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel27.TabIndex = 14;
            // 
            // radioButton_LOW_CFG1
            // 
            this.radioButton_LOW_CFG1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_LOW_CFG1.AutoSize = true;
            this.radioButton_LOW_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_LOW_CFG1.Location = new System.Drawing.Point(4, 4);
            this.radioButton_LOW_CFG1.Name = "radioButton_LOW_CFG1";
            this.radioButton_LOW_CFG1.Size = new System.Drawing.Size(61, 31);
            this.radioButton_LOW_CFG1.TabIndex = 14;
            this.radioButton_LOW_CFG1.Text = "LOW";
            this.radioButton_LOW_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_LOW_CFG1.UseVisualStyleBackColor = false;
            this.radioButton_LOW_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_OPEN_CFG1
            // 
            this.radioButton_OPEN_CFG1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OPEN_CFG1.AutoSize = true;
            this.radioButton_OPEN_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_OPEN_CFG1.Location = new System.Drawing.Point(72, 4);
            this.radioButton_OPEN_CFG1.Name = "radioButton_OPEN_CFG1";
            this.radioButton_OPEN_CFG1.Size = new System.Drawing.Size(61, 31);
            this.radioButton_OPEN_CFG1.TabIndex = 15;
            this.radioButton_OPEN_CFG1.Text = "OPEN";
            this.radioButton_OPEN_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_OPEN_CFG1.UseVisualStyleBackColor = false;
            this.radioButton_OPEN_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_HIGH_CFG1
            // 
            this.radioButton_HIGH_CFG1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_HIGH_CFG1.AutoSize = true;
            this.radioButton_HIGH_CFG1.Checked = true;
            this.radioButton_HIGH_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_HIGH_CFG1.Location = new System.Drawing.Point(140, 4);
            this.radioButton_HIGH_CFG1.Name = "radioButton_HIGH_CFG1";
            this.radioButton_HIGH_CFG1.Size = new System.Drawing.Size(62, 31);
            this.radioButton_HIGH_CFG1.TabIndex = 16;
            this.radioButton_HIGH_CFG1.TabStop = true;
            this.radioButton_HIGH_CFG1.Text = "HIGH";
            this.radioButton_HIGH_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_HIGH_CFG1.UseVisualStyleBackColor = false;
            this.radioButton_HIGH_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "CFG 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel28
            // 
            this.tableLayoutPanel28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel28.ColumnCount = 1;
            this.tableLayoutPanel28.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel28.Controls.Add(this.tableLayoutPanel29, 0, 1);
            this.tableLayoutPanel28.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel28.Location = new System.Drawing.Point(3, 157);
            this.tableLayoutPanel28.Name = "tableLayoutPanel28";
            this.tableLayoutPanel28.RowCount = 2;
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel28.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel28.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel28.TabIndex = 15;
            // 
            // tableLayoutPanel29
            // 
            this.tableLayoutPanel29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel29.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel29.ColumnCount = 3;
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel29.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel29.Controls.Add(this.radioButton_LOW_TESTMODE, 0, 0);
            this.tableLayoutPanel29.Controls.Add(this.radioButton_OPEN_TESTMODE, 1, 0);
            this.tableLayoutPanel29.Controls.Add(this.radioButton_HIGH_TESTMODE, 2, 0);
            this.tableLayoutPanel29.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel29.Name = "tableLayoutPanel29";
            this.tableLayoutPanel29.RowCount = 1;
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel29.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel29.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel29.TabIndex = 14;
            // 
            // radioButton_LOW_TESTMODE
            // 
            this.radioButton_LOW_TESTMODE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_LOW_TESTMODE.AutoSize = true;
            this.radioButton_LOW_TESTMODE.Checked = true;
            this.radioButton_LOW_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_LOW_TESTMODE.Location = new System.Drawing.Point(4, 4);
            this.radioButton_LOW_TESTMODE.Name = "radioButton_LOW_TESTMODE";
            this.radioButton_LOW_TESTMODE.Size = new System.Drawing.Size(61, 31);
            this.radioButton_LOW_TESTMODE.TabIndex = 14;
            this.radioButton_LOW_TESTMODE.TabStop = true;
            this.radioButton_LOW_TESTMODE.Text = "LOW";
            this.radioButton_LOW_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_LOW_TESTMODE.UseVisualStyleBackColor = false;
            this.radioButton_LOW_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_OPEN_TESTMODE
            // 
            this.radioButton_OPEN_TESTMODE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OPEN_TESTMODE.AutoSize = true;
            this.radioButton_OPEN_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_OPEN_TESTMODE.Location = new System.Drawing.Point(72, 4);
            this.radioButton_OPEN_TESTMODE.Name = "radioButton_OPEN_TESTMODE";
            this.radioButton_OPEN_TESTMODE.Size = new System.Drawing.Size(61, 31);
            this.radioButton_OPEN_TESTMODE.TabIndex = 15;
            this.radioButton_OPEN_TESTMODE.Text = "OPEN";
            this.radioButton_OPEN_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_OPEN_TESTMODE.UseVisualStyleBackColor = false;
            this.radioButton_OPEN_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_HIGH_TESTMODE
            // 
            this.radioButton_HIGH_TESTMODE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_HIGH_TESTMODE.AutoSize = true;
            this.radioButton_HIGH_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_HIGH_TESTMODE.Location = new System.Drawing.Point(140, 4);
            this.radioButton_HIGH_TESTMODE.Name = "radioButton_HIGH_TESTMODE";
            this.radioButton_HIGH_TESTMODE.Size = new System.Drawing.Size(62, 31);
            this.radioButton_HIGH_TESTMODE.TabIndex = 16;
            this.radioButton_HIGH_TESTMODE.Text = "HIGH";
            this.radioButton_HIGH_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_HIGH_TESTMODE.UseVisualStyleBackColor = false;
            this.radioButton_HIGH_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "TESTMODE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel30
            // 
            this.tableLayoutPanel30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel30.ColumnCount = 1;
            this.tableLayoutPanel30.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel30.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel30.Controls.Add(this.tableLayoutPanel31, 0, 1);
            this.tableLayoutPanel30.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel30.Name = "tableLayoutPanel30";
            this.tableLayoutPanel30.RowCount = 2;
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel30.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel30.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel30.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "DEV_CFG";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel31
            // 
            this.tableLayoutPanel31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel31.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel31.ColumnCount = 3;
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel31.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel31.Controls.Add(this.radioButton_LOW_DEV_CFG, 0, 0);
            this.tableLayoutPanel31.Controls.Add(this.radioButton_OPEN_DEV_CFG, 1, 0);
            this.tableLayoutPanel31.Controls.Add(this.radioButton_HIGH_DEV_CFG, 2, 0);
            this.tableLayoutPanel31.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel31.Name = "tableLayoutPanel31";
            this.tableLayoutPanel31.RowCount = 1;
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel31.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel31.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel31.TabIndex = 14;
            // 
            // radioButton_LOW_DEV_CFG
            // 
            this.radioButton_LOW_DEV_CFG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_LOW_DEV_CFG.AutoSize = true;
            this.radioButton_LOW_DEV_CFG.Checked = true;
            this.radioButton_LOW_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_LOW_DEV_CFG.Location = new System.Drawing.Point(4, 4);
            this.radioButton_LOW_DEV_CFG.Name = "radioButton_LOW_DEV_CFG";
            this.radioButton_LOW_DEV_CFG.Size = new System.Drawing.Size(61, 31);
            this.radioButton_LOW_DEV_CFG.TabIndex = 14;
            this.radioButton_LOW_DEV_CFG.TabStop = true;
            this.radioButton_LOW_DEV_CFG.Text = "LOW";
            this.radioButton_LOW_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_LOW_DEV_CFG.UseVisualStyleBackColor = false;
            this.radioButton_LOW_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_OPEN_DEV_CFG
            // 
            this.radioButton_OPEN_DEV_CFG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_OPEN_DEV_CFG.AutoSize = true;
            this.radioButton_OPEN_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_OPEN_DEV_CFG.Location = new System.Drawing.Point(72, 4);
            this.radioButton_OPEN_DEV_CFG.Name = "radioButton_OPEN_DEV_CFG";
            this.radioButton_OPEN_DEV_CFG.Size = new System.Drawing.Size(61, 31);
            this.radioButton_OPEN_DEV_CFG.TabIndex = 15;
            this.radioButton_OPEN_DEV_CFG.Text = "OPEN";
            this.radioButton_OPEN_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_OPEN_DEV_CFG.UseVisualStyleBackColor = false;
            this.radioButton_OPEN_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_HIGH_DEV_CFG
            // 
            this.radioButton_HIGH_DEV_CFG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_HIGH_DEV_CFG.AutoSize = true;
            this.radioButton_HIGH_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_HIGH_DEV_CFG.Location = new System.Drawing.Point(140, 4);
            this.radioButton_HIGH_DEV_CFG.Name = "radioButton_HIGH_DEV_CFG";
            this.radioButton_HIGH_DEV_CFG.Size = new System.Drawing.Size(62, 31);
            this.radioButton_HIGH_DEV_CFG.TabIndex = 16;
            this.radioButton_HIGH_DEV_CFG.Text = "HIGH";
            this.radioButton_HIGH_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_HIGH_DEV_CFG.UseVisualStyleBackColor = false;
            this.radioButton_HIGH_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // tableLayoutPanel32
            // 
            this.tableLayoutPanel32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel32.ColumnCount = 1;
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel32.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel33, 0, 0);
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel35, 0, 6);
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel37, 0, 5);
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel39, 0, 4);
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel41, 0, 3);
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel43, 0, 2);
            this.tableLayoutPanel32.Controls.Add(this.tableLayoutPanel45, 0, 1);
            this.tableLayoutPanel32.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel32.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel32.Name = "tableLayoutPanel32";
            this.tableLayoutPanel32.RowCount = 7;
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel32.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel32.Size = new System.Drawing.Size(218, 543);
            this.tableLayoutPanel32.TabIndex = 0;
            // 
            // tableLayoutPanel33
            // 
            this.tableLayoutPanel33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel33.ColumnCount = 1;
            this.tableLayoutPanel33.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel33.Controls.Add(this.tableLayoutPanel34, 0, 1);
            this.tableLayoutPanel33.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel33.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel33.Name = "tableLayoutPanel33";
            this.tableLayoutPanel33.RowCount = 2;
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel33.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel33.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel33.TabIndex = 16;
            // 
            // tableLayoutPanel34
            // 
            this.tableLayoutPanel34.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel34.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel34.ColumnCount = 3;
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel34.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel34.Controls.Add(this.radioButton_FLASH_LOW_PD_N, 0, 0);
            this.tableLayoutPanel34.Controls.Add(this.radioButton_FLASH_HIGH_PD_N, 2, 0);
            this.tableLayoutPanel34.Controls.Add(this.radioButton_FLASH_OPEN_PD_N, 1, 0);
            this.tableLayoutPanel34.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel34.Name = "tableLayoutPanel34";
            this.tableLayoutPanel34.RowCount = 1;
            this.tableLayoutPanel34.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel34.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel34.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel34.TabIndex = 14;
            // 
            // radioButton_FLASH_LOW_PD_N
            // 
            this.radioButton_FLASH_LOW_PD_N.AutoCheck = false;
            this.radioButton_FLASH_LOW_PD_N.AutoSize = true;
            this.radioButton_FLASH_LOW_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_LOW_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_LOW_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_LOW_PD_N.Location = new System.Drawing.Point(4, 4);
            this.radioButton_FLASH_LOW_PD_N.Name = "radioButton_FLASH_LOW_PD_N";
            this.radioButton_FLASH_LOW_PD_N.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_LOW_PD_N.TabIndex = 0;
            this.radioButton_FLASH_LOW_PD_N.Text = "LOW";
            this.radioButton_FLASH_LOW_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_LOW_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_LOW_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_HIGH_PD_N
            // 
            this.radioButton_FLASH_HIGH_PD_N.AutoCheck = false;
            this.radioButton_FLASH_HIGH_PD_N.AutoSize = true;
            this.radioButton_FLASH_HIGH_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_HIGH_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_HIGH_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_HIGH_PD_N.Location = new System.Drawing.Point(140, 4);
            this.radioButton_FLASH_HIGH_PD_N.Name = "radioButton_FLASH_HIGH_PD_N";
            this.radioButton_FLASH_HIGH_PD_N.Size = new System.Drawing.Size(62, 31);
            this.radioButton_FLASH_HIGH_PD_N.TabIndex = 2;
            this.radioButton_FLASH_HIGH_PD_N.Text = "HIGH";
            this.radioButton_FLASH_HIGH_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_HIGH_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_HIGH_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_OPEN_PD_N
            // 
            this.radioButton_FLASH_OPEN_PD_N.AutoCheck = false;
            this.radioButton_FLASH_OPEN_PD_N.AutoSize = true;
            this.radioButton_FLASH_OPEN_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_OPEN_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_OPEN_PD_N.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_OPEN_PD_N.Location = new System.Drawing.Point(72, 4);
            this.radioButton_FLASH_OPEN_PD_N.Name = "radioButton_FLASH_OPEN_PD_N";
            this.radioButton_FLASH_OPEN_PD_N.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_OPEN_PD_N.TabIndex = 1;
            this.radioButton_FLASH_OPEN_PD_N.Text = "OPEN";
            this.radioButton_FLASH_OPEN_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_OPEN_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_OPEN_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(82, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "PD_N";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel35
            // 
            this.tableLayoutPanel35.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel35.ColumnCount = 1;
            this.tableLayoutPanel35.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel35.Controls.Add(this.tableLayoutPanel36, 0, 1);
            this.tableLayoutPanel35.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel35.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanel35.Name = "tableLayoutPanel35";
            this.tableLayoutPanel35.RowCount = 2;
            this.tableLayoutPanel35.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel35.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel35.Size = new System.Drawing.Size(212, 75);
            this.tableLayoutPanel35.TabIndex = 15;
            // 
            // tableLayoutPanel36
            // 
            this.tableLayoutPanel36.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel36.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel36.ColumnCount = 3;
            this.tableLayoutPanel36.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel36.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel36.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel36.Controls.Add(this.radioButton_FLASH_LOW_CFG4, 0, 0);
            this.tableLayoutPanel36.Controls.Add(this.radioButton_FLASH_OPEN_CFG4, 1, 0);
            this.tableLayoutPanel36.Controls.Add(this.radioButton_FLASH_HIGH_CFG4, 2, 0);
            this.tableLayoutPanel36.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel36.Name = "tableLayoutPanel36";
            this.tableLayoutPanel36.RowCount = 1;
            this.tableLayoutPanel36.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel36.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel36.Size = new System.Drawing.Size(206, 41);
            this.tableLayoutPanel36.TabIndex = 14;
            // 
            // radioButton_FLASH_LOW_CFG4
            // 
            this.radioButton_FLASH_LOW_CFG4.AutoCheck = false;
            this.radioButton_FLASH_LOW_CFG4.AutoSize = true;
            this.radioButton_FLASH_LOW_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_LOW_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_LOW_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_LOW_CFG4.Location = new System.Drawing.Point(4, 4);
            this.radioButton_FLASH_LOW_CFG4.Name = "radioButton_FLASH_LOW_CFG4";
            this.radioButton_FLASH_LOW_CFG4.Size = new System.Drawing.Size(61, 33);
            this.radioButton_FLASH_LOW_CFG4.TabIndex = 14;
            this.radioButton_FLASH_LOW_CFG4.Text = "LOW";
            this.radioButton_FLASH_LOW_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_LOW_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_LOW_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_OPEN_CFG4
            // 
            this.radioButton_FLASH_OPEN_CFG4.AutoCheck = false;
            this.radioButton_FLASH_OPEN_CFG4.AutoSize = true;
            this.radioButton_FLASH_OPEN_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_OPEN_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_OPEN_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_OPEN_CFG4.Location = new System.Drawing.Point(72, 4);
            this.radioButton_FLASH_OPEN_CFG4.Name = "radioButton_FLASH_OPEN_CFG4";
            this.radioButton_FLASH_OPEN_CFG4.Size = new System.Drawing.Size(61, 33);
            this.radioButton_FLASH_OPEN_CFG4.TabIndex = 15;
            this.radioButton_FLASH_OPEN_CFG4.Text = "OPEN";
            this.radioButton_FLASH_OPEN_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_OPEN_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_OPEN_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_HIGH_CFG4
            // 
            this.radioButton_FLASH_HIGH_CFG4.AutoCheck = false;
            this.radioButton_FLASH_HIGH_CFG4.AutoSize = true;
            this.radioButton_FLASH_HIGH_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_HIGH_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_HIGH_CFG4.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_HIGH_CFG4.Location = new System.Drawing.Point(140, 4);
            this.radioButton_FLASH_HIGH_CFG4.Name = "radioButton_FLASH_HIGH_CFG4";
            this.radioButton_FLASH_HIGH_CFG4.Size = new System.Drawing.Size(62, 33);
            this.radioButton_FLASH_HIGH_CFG4.TabIndex = 16;
            this.radioButton_FLASH_HIGH_CFG4.Text = "HIGH";
            this.radioButton_FLASH_HIGH_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_HIGH_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_HIGH_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(77, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "CFG 4";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel37
            // 
            this.tableLayoutPanel37.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel37.ColumnCount = 1;
            this.tableLayoutPanel37.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel37.Controls.Add(this.tableLayoutPanel38, 0, 1);
            this.tableLayoutPanel37.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel37.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel37.Name = "tableLayoutPanel37";
            this.tableLayoutPanel37.RowCount = 2;
            this.tableLayoutPanel37.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel37.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel37.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel37.TabIndex = 15;
            // 
            // tableLayoutPanel38
            // 
            this.tableLayoutPanel38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel38.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel38.ColumnCount = 3;
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel38.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel38.Controls.Add(this.radioButton_FLASH_LOW_CFG3, 0, 0);
            this.tableLayoutPanel38.Controls.Add(this.radioButton_FLASH_OPEN_CFG3, 1, 0);
            this.tableLayoutPanel38.Controls.Add(this.radioButton_FLASH_HIGH_CFG3, 2, 0);
            this.tableLayoutPanel38.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel38.Name = "tableLayoutPanel38";
            this.tableLayoutPanel38.RowCount = 1;
            this.tableLayoutPanel38.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel38.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel38.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel38.TabIndex = 14;
            // 
            // radioButton_FLASH_LOW_CFG3
            // 
            this.radioButton_FLASH_LOW_CFG3.AutoCheck = false;
            this.radioButton_FLASH_LOW_CFG3.AutoSize = true;
            this.radioButton_FLASH_LOW_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_LOW_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_LOW_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_LOW_CFG3.Location = new System.Drawing.Point(4, 4);
            this.radioButton_FLASH_LOW_CFG3.Name = "radioButton_FLASH_LOW_CFG3";
            this.radioButton_FLASH_LOW_CFG3.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_LOW_CFG3.TabIndex = 14;
            this.radioButton_FLASH_LOW_CFG3.Text = "LOW";
            this.radioButton_FLASH_LOW_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_LOW_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_LOW_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_OPEN_CFG3
            // 
            this.radioButton_FLASH_OPEN_CFG3.AutoCheck = false;
            this.radioButton_FLASH_OPEN_CFG3.AutoSize = true;
            this.radioButton_FLASH_OPEN_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_OPEN_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_OPEN_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_OPEN_CFG3.Location = new System.Drawing.Point(72, 4);
            this.radioButton_FLASH_OPEN_CFG3.Name = "radioButton_FLASH_OPEN_CFG3";
            this.radioButton_FLASH_OPEN_CFG3.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_OPEN_CFG3.TabIndex = 15;
            this.radioButton_FLASH_OPEN_CFG3.Text = "OPEN";
            this.radioButton_FLASH_OPEN_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_OPEN_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_OPEN_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_HIGH_CFG3
            // 
            this.radioButton_FLASH_HIGH_CFG3.AutoCheck = false;
            this.radioButton_FLASH_HIGH_CFG3.AutoSize = true;
            this.radioButton_FLASH_HIGH_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_HIGH_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_HIGH_CFG3.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_HIGH_CFG3.Location = new System.Drawing.Point(140, 4);
            this.radioButton_FLASH_HIGH_CFG3.Name = "radioButton_FLASH_HIGH_CFG3";
            this.radioButton_FLASH_HIGH_CFG3.Size = new System.Drawing.Size(62, 31);
            this.radioButton_FLASH_HIGH_CFG3.TabIndex = 16;
            this.radioButton_FLASH_HIGH_CFG3.Text = "HIGH";
            this.radioButton_FLASH_HIGH_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_HIGH_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_HIGH_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(77, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 26);
            this.label12.TabIndex = 5;
            this.label12.Text = "CFG 3";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel39
            // 
            this.tableLayoutPanel39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel39.ColumnCount = 1;
            this.tableLayoutPanel39.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel39.Controls.Add(this.tableLayoutPanel40, 0, 1);
            this.tableLayoutPanel39.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel39.Location = new System.Drawing.Point(3, 311);
            this.tableLayoutPanel39.Name = "tableLayoutPanel39";
            this.tableLayoutPanel39.RowCount = 2;
            this.tableLayoutPanel39.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel39.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel39.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel39.TabIndex = 15;
            // 
            // tableLayoutPanel40
            // 
            this.tableLayoutPanel40.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel40.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel40.ColumnCount = 3;
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel40.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel40.Controls.Add(this.radioButton_FLASH_LOW_CFG2, 0, 0);
            this.tableLayoutPanel40.Controls.Add(this.radioButton_FLASH_OPEN_CFG2, 1, 0);
            this.tableLayoutPanel40.Controls.Add(this.radioButton_FLASH_HIGH_CFG2, 2, 0);
            this.tableLayoutPanel40.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel40.Name = "tableLayoutPanel40";
            this.tableLayoutPanel40.RowCount = 1;
            this.tableLayoutPanel40.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel40.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel40.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel40.TabIndex = 14;
            // 
            // radioButton_FLASH_LOW_CFG2
            // 
            this.radioButton_FLASH_LOW_CFG2.AutoCheck = false;
            this.radioButton_FLASH_LOW_CFG2.AutoSize = true;
            this.radioButton_FLASH_LOW_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_LOW_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_LOW_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_LOW_CFG2.Location = new System.Drawing.Point(4, 4);
            this.radioButton_FLASH_LOW_CFG2.Name = "radioButton_FLASH_LOW_CFG2";
            this.radioButton_FLASH_LOW_CFG2.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_LOW_CFG2.TabIndex = 14;
            this.radioButton_FLASH_LOW_CFG2.Text = "LOW";
            this.radioButton_FLASH_LOW_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_LOW_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_LOW_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_OPEN_CFG2
            // 
            this.radioButton_FLASH_OPEN_CFG2.AutoCheck = false;
            this.radioButton_FLASH_OPEN_CFG2.AutoSize = true;
            this.radioButton_FLASH_OPEN_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_OPEN_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_OPEN_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_OPEN_CFG2.Location = new System.Drawing.Point(72, 4);
            this.radioButton_FLASH_OPEN_CFG2.Name = "radioButton_FLASH_OPEN_CFG2";
            this.radioButton_FLASH_OPEN_CFG2.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_OPEN_CFG2.TabIndex = 15;
            this.radioButton_FLASH_OPEN_CFG2.Text = "OPEN";
            this.radioButton_FLASH_OPEN_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_OPEN_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_OPEN_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_HIGH_CFG2
            // 
            this.radioButton_FLASH_HIGH_CFG2.AutoCheck = false;
            this.radioButton_FLASH_HIGH_CFG2.AutoSize = true;
            this.radioButton_FLASH_HIGH_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_HIGH_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_HIGH_CFG2.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_HIGH_CFG2.Location = new System.Drawing.Point(140, 4);
            this.radioButton_FLASH_HIGH_CFG2.Name = "radioButton_FLASH_HIGH_CFG2";
            this.radioButton_FLASH_HIGH_CFG2.Size = new System.Drawing.Size(62, 31);
            this.radioButton_FLASH_HIGH_CFG2.TabIndex = 16;
            this.radioButton_FLASH_HIGH_CFG2.Text = "HIGH";
            this.radioButton_FLASH_HIGH_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_HIGH_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_HIGH_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(77, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 26);
            this.label13.TabIndex = 4;
            this.label13.Text = "CFG 2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel41
            // 
            this.tableLayoutPanel41.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel41.ColumnCount = 1;
            this.tableLayoutPanel41.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel41.Controls.Add(this.tableLayoutPanel42, 0, 1);
            this.tableLayoutPanel41.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel41.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel41.Name = "tableLayoutPanel41";
            this.tableLayoutPanel41.RowCount = 2;
            this.tableLayoutPanel41.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel41.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel41.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel41.TabIndex = 15;
            // 
            // tableLayoutPanel42
            // 
            this.tableLayoutPanel42.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel42.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel42.ColumnCount = 3;
            this.tableLayoutPanel42.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel42.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel42.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel42.Controls.Add(this.radioButton_FLASH_LOW_CFG1, 0, 0);
            this.tableLayoutPanel42.Controls.Add(this.radioButton_FLASH_OPEN_CFG1, 1, 0);
            this.tableLayoutPanel42.Controls.Add(this.radioButton_FLASH_HIGH_CFG1, 2, 0);
            this.tableLayoutPanel42.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel42.Name = "tableLayoutPanel42";
            this.tableLayoutPanel42.RowCount = 1;
            this.tableLayoutPanel42.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel42.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel42.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel42.TabIndex = 14;
            // 
            // radioButton_FLASH_LOW_CFG1
            // 
            this.radioButton_FLASH_LOW_CFG1.AutoCheck = false;
            this.radioButton_FLASH_LOW_CFG1.AutoSize = true;
            this.radioButton_FLASH_LOW_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_LOW_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_LOW_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_LOW_CFG1.Location = new System.Drawing.Point(4, 4);
            this.radioButton_FLASH_LOW_CFG1.Name = "radioButton_FLASH_LOW_CFG1";
            this.radioButton_FLASH_LOW_CFG1.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_LOW_CFG1.TabIndex = 14;
            this.radioButton_FLASH_LOW_CFG1.Text = "LOW";
            this.radioButton_FLASH_LOW_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_LOW_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_LOW_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_OPEN_CFG1
            // 
            this.radioButton_FLASH_OPEN_CFG1.AutoCheck = false;
            this.radioButton_FLASH_OPEN_CFG1.AutoSize = true;
            this.radioButton_FLASH_OPEN_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_OPEN_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_OPEN_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_OPEN_CFG1.Location = new System.Drawing.Point(72, 4);
            this.radioButton_FLASH_OPEN_CFG1.Name = "radioButton_FLASH_OPEN_CFG1";
            this.radioButton_FLASH_OPEN_CFG1.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_OPEN_CFG1.TabIndex = 15;
            this.radioButton_FLASH_OPEN_CFG1.Text = "OPEN";
            this.radioButton_FLASH_OPEN_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_OPEN_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_OPEN_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_HIGH_CFG1
            // 
            this.radioButton_FLASH_HIGH_CFG1.AutoCheck = false;
            this.radioButton_FLASH_HIGH_CFG1.AutoSize = true;
            this.radioButton_FLASH_HIGH_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_HIGH_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_HIGH_CFG1.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_HIGH_CFG1.Location = new System.Drawing.Point(140, 4);
            this.radioButton_FLASH_HIGH_CFG1.Name = "radioButton_FLASH_HIGH_CFG1";
            this.radioButton_FLASH_HIGH_CFG1.Size = new System.Drawing.Size(62, 31);
            this.radioButton_FLASH_HIGH_CFG1.TabIndex = 16;
            this.radioButton_FLASH_HIGH_CFG1.Text = "HIGH";
            this.radioButton_FLASH_HIGH_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_HIGH_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_HIGH_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(77, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 26);
            this.label14.TabIndex = 3;
            this.label14.Text = "CFG 1";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel43
            // 
            this.tableLayoutPanel43.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel43.ColumnCount = 1;
            this.tableLayoutPanel43.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel43.Controls.Add(this.tableLayoutPanel44, 0, 1);
            this.tableLayoutPanel43.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel43.Location = new System.Drawing.Point(3, 157);
            this.tableLayoutPanel43.Name = "tableLayoutPanel43";
            this.tableLayoutPanel43.RowCount = 2;
            this.tableLayoutPanel43.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel43.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel43.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel43.TabIndex = 15;
            // 
            // tableLayoutPanel44
            // 
            this.tableLayoutPanel44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel44.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel44.ColumnCount = 3;
            this.tableLayoutPanel44.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel44.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel44.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel44.Controls.Add(this.radioButton_FLASH_LOW_TESTMODE, 0, 0);
            this.tableLayoutPanel44.Controls.Add(this.radioButton_FLASH_OPEN_TESTMODE, 1, 0);
            this.tableLayoutPanel44.Controls.Add(this.radioButton_FLASH_HIGH_TESTMODE, 2, 0);
            this.tableLayoutPanel44.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel44.Name = "tableLayoutPanel44";
            this.tableLayoutPanel44.RowCount = 1;
            this.tableLayoutPanel44.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel44.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel44.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel44.TabIndex = 14;
            // 
            // radioButton_FLASH_LOW_TESTMODE
            // 
            this.radioButton_FLASH_LOW_TESTMODE.AutoCheck = false;
            this.radioButton_FLASH_LOW_TESTMODE.AutoSize = true;
            this.radioButton_FLASH_LOW_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_LOW_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_LOW_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_LOW_TESTMODE.Location = new System.Drawing.Point(4, 4);
            this.radioButton_FLASH_LOW_TESTMODE.Name = "radioButton_FLASH_LOW_TESTMODE";
            this.radioButton_FLASH_LOW_TESTMODE.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_LOW_TESTMODE.TabIndex = 14;
            this.radioButton_FLASH_LOW_TESTMODE.Text = "LOW";
            this.radioButton_FLASH_LOW_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_LOW_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_LOW_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_OPEN_TESTMODE
            // 
            this.radioButton_FLASH_OPEN_TESTMODE.AutoCheck = false;
            this.radioButton_FLASH_OPEN_TESTMODE.AutoSize = true;
            this.radioButton_FLASH_OPEN_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_OPEN_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_OPEN_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_OPEN_TESTMODE.Location = new System.Drawing.Point(72, 4);
            this.radioButton_FLASH_OPEN_TESTMODE.Name = "radioButton_FLASH_OPEN_TESTMODE";
            this.radioButton_FLASH_OPEN_TESTMODE.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_OPEN_TESTMODE.TabIndex = 15;
            this.radioButton_FLASH_OPEN_TESTMODE.Text = "OPEN";
            this.radioButton_FLASH_OPEN_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_OPEN_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_OPEN_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_HIGH_TESTMODE
            // 
            this.radioButton_FLASH_HIGH_TESTMODE.AutoCheck = false;
            this.radioButton_FLASH_HIGH_TESTMODE.AutoSize = true;
            this.radioButton_FLASH_HIGH_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_HIGH_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_HIGH_TESTMODE.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_HIGH_TESTMODE.Location = new System.Drawing.Point(140, 4);
            this.radioButton_FLASH_HIGH_TESTMODE.Name = "radioButton_FLASH_HIGH_TESTMODE";
            this.radioButton_FLASH_HIGH_TESTMODE.Size = new System.Drawing.Size(62, 31);
            this.radioButton_FLASH_HIGH_TESTMODE.TabIndex = 16;
            this.radioButton_FLASH_HIGH_TESTMODE.Text = "HIGH";
            this.radioButton_FLASH_HIGH_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_HIGH_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_HIGH_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(62, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 26);
            this.label15.TabIndex = 2;
            this.label15.Text = "TESTMODE";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel45
            // 
            this.tableLayoutPanel45.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel45.ColumnCount = 1;
            this.tableLayoutPanel45.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel45.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel45.Controls.Add(this.tableLayoutPanel46, 0, 1);
            this.tableLayoutPanel45.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel45.Name = "tableLayoutPanel45";
            this.tableLayoutPanel45.RowCount = 2;
            this.tableLayoutPanel45.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel45.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel45.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel45.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(67, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 26);
            this.label16.TabIndex = 1;
            this.label16.Text = "DEV_CFG";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel46
            // 
            this.tableLayoutPanel46.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel46.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel46.ColumnCount = 3;
            this.tableLayoutPanel46.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel46.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel46.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel46.Controls.Add(this.radioButton_FLASH_LOW_DEV_CFG, 0, 0);
            this.tableLayoutPanel46.Controls.Add(this.radioButton_FLASH_OPEN_DEV_CFG, 1, 0);
            this.tableLayoutPanel46.Controls.Add(this.radioButton_FLASH_HIGH_DEV_CFG, 2, 0);
            this.tableLayoutPanel46.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel46.Name = "tableLayoutPanel46";
            this.tableLayoutPanel46.RowCount = 1;
            this.tableLayoutPanel46.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel46.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel46.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel46.TabIndex = 14;
            // 
            // radioButton_FLASH_LOW_DEV_CFG
            // 
            this.radioButton_FLASH_LOW_DEV_CFG.AutoCheck = false;
            this.radioButton_FLASH_LOW_DEV_CFG.AutoSize = true;
            this.radioButton_FLASH_LOW_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_LOW_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_LOW_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_LOW_DEV_CFG.Location = new System.Drawing.Point(4, 4);
            this.radioButton_FLASH_LOW_DEV_CFG.Name = "radioButton_FLASH_LOW_DEV_CFG";
            this.radioButton_FLASH_LOW_DEV_CFG.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_LOW_DEV_CFG.TabIndex = 14;
            this.radioButton_FLASH_LOW_DEV_CFG.Text = "LOW";
            this.radioButton_FLASH_LOW_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_LOW_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_LOW_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_OPEN_DEV_CFG
            // 
            this.radioButton_FLASH_OPEN_DEV_CFG.AutoCheck = false;
            this.radioButton_FLASH_OPEN_DEV_CFG.AutoSize = true;
            this.radioButton_FLASH_OPEN_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_OPEN_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_OPEN_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_OPEN_DEV_CFG.Location = new System.Drawing.Point(72, 4);
            this.radioButton_FLASH_OPEN_DEV_CFG.Name = "radioButton_FLASH_OPEN_DEV_CFG";
            this.radioButton_FLASH_OPEN_DEV_CFG.Size = new System.Drawing.Size(61, 31);
            this.radioButton_FLASH_OPEN_DEV_CFG.TabIndex = 15;
            this.radioButton_FLASH_OPEN_DEV_CFG.Text = "OPEN";
            this.radioButton_FLASH_OPEN_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_OPEN_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_OPEN_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_FLASH_HIGH_DEV_CFG
            // 
            this.radioButton_FLASH_HIGH_DEV_CFG.AutoCheck = false;
            this.radioButton_FLASH_HIGH_DEV_CFG.AutoSize = true;
            this.radioButton_FLASH_HIGH_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_FLASH_HIGH_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_FLASH_HIGH_DEV_CFG.ForeColor = System.Drawing.Color.White;
            this.radioButton_FLASH_HIGH_DEV_CFG.Location = new System.Drawing.Point(140, 4);
            this.radioButton_FLASH_HIGH_DEV_CFG.Name = "radioButton_FLASH_HIGH_DEV_CFG";
            this.radioButton_FLASH_HIGH_DEV_CFG.Size = new System.Drawing.Size(62, 31);
            this.radioButton_FLASH_HIGH_DEV_CFG.TabIndex = 16;
            this.radioButton_FLASH_HIGH_DEV_CFG.Text = "HIGH";
            this.radioButton_FLASH_HIGH_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_FLASH_HIGH_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_FLASH_HIGH_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // tableLayoutPanel47
            // 
            this.tableLayoutPanel47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel47.ColumnCount = 1;
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel47.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel47.Controls.Add(this.tableLayoutPanel48, 0, 0);
            this.tableLayoutPanel47.Controls.Add(this.tableLayoutPanel50, 0, 6);
            this.tableLayoutPanel47.Controls.Add(this.tableLayoutPanel52, 0, 5);
            this.tableLayoutPanel47.Controls.Add(this.tableLayoutPanel54, 0, 4);
            this.tableLayoutPanel47.Controls.Add(this.tableLayoutPanel56, 0, 3);
            this.tableLayoutPanel47.Controls.Add(this.tableLayoutPanel58, 0, 2);
            this.tableLayoutPanel47.Controls.Add(this.tableLayoutPanel60, 0, 1);
            this.tableLayoutPanel47.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel47.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel47.Name = "tableLayoutPanel47";
            this.tableLayoutPanel47.RowCount = 7;
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel47.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel47.Size = new System.Drawing.Size(218, 543);
            this.tableLayoutPanel47.TabIndex = 0;
            // 
            // tableLayoutPanel48
            // 
            this.tableLayoutPanel48.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel48.ColumnCount = 1;
            this.tableLayoutPanel48.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel48.Controls.Add(this.tableLayoutPanel49, 0, 1);
            this.tableLayoutPanel48.Controls.Add(this.label17, 0, 0);
            this.tableLayoutPanel48.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel48.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel48.Name = "tableLayoutPanel48";
            this.tableLayoutPanel48.RowCount = 2;
            this.tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel48.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel48.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel48.TabIndex = 16;
            // 
            // tableLayoutPanel49
            // 
            this.tableLayoutPanel49.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel49.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel49.ColumnCount = 3;
            this.tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel49.Controls.Add(this.radioButton_EEPROM_LOW_PD_N, 0, 0);
            this.tableLayoutPanel49.Controls.Add(this.radioButton_EEPROM_HIGH_PD_N, 2, 0);
            this.tableLayoutPanel49.Controls.Add(this.radioButton_EEPROM_OPEN_PD_N, 1, 0);
            this.tableLayoutPanel49.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel49.Name = "tableLayoutPanel49";
            this.tableLayoutPanel49.RowCount = 1;
            this.tableLayoutPanel49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel49.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel49.TabIndex = 14;
            // 
            // radioButton_EEPROM_LOW_PD_N
            // 
            this.radioButton_EEPROM_LOW_PD_N.AutoCheck = false;
            this.radioButton_EEPROM_LOW_PD_N.AutoSize = true;
            this.radioButton_EEPROM_LOW_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_LOW_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_LOW_PD_N.Location = new System.Drawing.Point(4, 4);
            this.radioButton_EEPROM_LOW_PD_N.Name = "radioButton_EEPROM_LOW_PD_N";
            this.radioButton_EEPROM_LOW_PD_N.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_LOW_PD_N.TabIndex = 0;
            this.radioButton_EEPROM_LOW_PD_N.Text = "LOW";
            this.radioButton_EEPROM_LOW_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_LOW_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_LOW_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_HIGH_PD_N
            // 
            this.radioButton_EEPROM_HIGH_PD_N.AutoCheck = false;
            this.radioButton_EEPROM_HIGH_PD_N.AutoSize = true;
            this.radioButton_EEPROM_HIGH_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_HIGH_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_HIGH_PD_N.Location = new System.Drawing.Point(140, 4);
            this.radioButton_EEPROM_HIGH_PD_N.Name = "radioButton_EEPROM_HIGH_PD_N";
            this.radioButton_EEPROM_HIGH_PD_N.Size = new System.Drawing.Size(62, 31);
            this.radioButton_EEPROM_HIGH_PD_N.TabIndex = 2;
            this.radioButton_EEPROM_HIGH_PD_N.Text = "HIGH";
            this.radioButton_EEPROM_HIGH_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_HIGH_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_HIGH_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_OPEN_PD_N
            // 
            this.radioButton_EEPROM_OPEN_PD_N.AutoCheck = false;
            this.radioButton_EEPROM_OPEN_PD_N.AutoSize = true;
            this.radioButton_EEPROM_OPEN_PD_N.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_OPEN_PD_N.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_OPEN_PD_N.Location = new System.Drawing.Point(72, 4);
            this.radioButton_EEPROM_OPEN_PD_N.Name = "radioButton_EEPROM_OPEN_PD_N";
            this.radioButton_EEPROM_OPEN_PD_N.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_OPEN_PD_N.TabIndex = 1;
            this.radioButton_EEPROM_OPEN_PD_N.Text = "OPEN";
            this.radioButton_EEPROM_OPEN_PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_OPEN_PD_N.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_OPEN_PD_N.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(82, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 26);
            this.label17.TabIndex = 0;
            this.label17.Text = "PD_N";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel50
            // 
            this.tableLayoutPanel50.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel50.ColumnCount = 1;
            this.tableLayoutPanel50.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel50.Controls.Add(this.tableLayoutPanel51, 0, 1);
            this.tableLayoutPanel50.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel50.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel50.Location = new System.Drawing.Point(3, 465);
            this.tableLayoutPanel50.Name = "tableLayoutPanel50";
            this.tableLayoutPanel50.RowCount = 2;
            this.tableLayoutPanel50.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel50.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel50.Size = new System.Drawing.Size(212, 75);
            this.tableLayoutPanel50.TabIndex = 15;
            // 
            // tableLayoutPanel51
            // 
            this.tableLayoutPanel51.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel51.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel51.ColumnCount = 3;
            this.tableLayoutPanel51.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel51.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel51.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel51.Controls.Add(this.radioButton_EEPROM_LOW_CFG4, 0, 0);
            this.tableLayoutPanel51.Controls.Add(this.radioButton_EEPROM_OPEN_CFG4, 1, 0);
            this.tableLayoutPanel51.Controls.Add(this.radioButton_EEPROM_HIGH_CFG4, 2, 0);
            this.tableLayoutPanel51.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel51.Name = "tableLayoutPanel51";
            this.tableLayoutPanel51.RowCount = 1;
            this.tableLayoutPanel51.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel51.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel51.Size = new System.Drawing.Size(206, 41);
            this.tableLayoutPanel51.TabIndex = 14;
            // 
            // radioButton_EEPROM_LOW_CFG4
            // 
            this.radioButton_EEPROM_LOW_CFG4.AutoCheck = false;
            this.radioButton_EEPROM_LOW_CFG4.AutoSize = true;
            this.radioButton_EEPROM_LOW_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_LOW_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_LOW_CFG4.Location = new System.Drawing.Point(4, 4);
            this.radioButton_EEPROM_LOW_CFG4.Name = "radioButton_EEPROM_LOW_CFG4";
            this.radioButton_EEPROM_LOW_CFG4.Size = new System.Drawing.Size(61, 33);
            this.radioButton_EEPROM_LOW_CFG4.TabIndex = 14;
            this.radioButton_EEPROM_LOW_CFG4.Text = "LOW";
            this.radioButton_EEPROM_LOW_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_LOW_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_LOW_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_OPEN_CFG4
            // 
            this.radioButton_EEPROM_OPEN_CFG4.AutoCheck = false;
            this.radioButton_EEPROM_OPEN_CFG4.AutoSize = true;
            this.radioButton_EEPROM_OPEN_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_OPEN_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_OPEN_CFG4.Location = new System.Drawing.Point(72, 4);
            this.radioButton_EEPROM_OPEN_CFG4.Name = "radioButton_EEPROM_OPEN_CFG4";
            this.radioButton_EEPROM_OPEN_CFG4.Size = new System.Drawing.Size(61, 33);
            this.radioButton_EEPROM_OPEN_CFG4.TabIndex = 15;
            this.radioButton_EEPROM_OPEN_CFG4.Text = "OPEN";
            this.radioButton_EEPROM_OPEN_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_OPEN_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_OPEN_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_HIGH_CFG4
            // 
            this.radioButton_EEPROM_HIGH_CFG4.AutoCheck = false;
            this.radioButton_EEPROM_HIGH_CFG4.AutoSize = true;
            this.radioButton_EEPROM_HIGH_CFG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_HIGH_CFG4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_HIGH_CFG4.Location = new System.Drawing.Point(140, 4);
            this.radioButton_EEPROM_HIGH_CFG4.Name = "radioButton_EEPROM_HIGH_CFG4";
            this.radioButton_EEPROM_HIGH_CFG4.Size = new System.Drawing.Size(62, 33);
            this.radioButton_EEPROM_HIGH_CFG4.TabIndex = 16;
            this.radioButton_EEPROM_HIGH_CFG4.Text = "HIGH";
            this.radioButton_EEPROM_HIGH_CFG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_HIGH_CFG4.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_HIGH_CFG4.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(77, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 28);
            this.label18.TabIndex = 6;
            this.label18.Text = "CFG 4";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel52
            // 
            this.tableLayoutPanel52.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel52.ColumnCount = 1;
            this.tableLayoutPanel52.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel52.Controls.Add(this.tableLayoutPanel53, 0, 1);
            this.tableLayoutPanel52.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel52.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel52.Location = new System.Drawing.Point(3, 388);
            this.tableLayoutPanel52.Name = "tableLayoutPanel52";
            this.tableLayoutPanel52.RowCount = 2;
            this.tableLayoutPanel52.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel52.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel52.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel52.TabIndex = 15;
            // 
            // tableLayoutPanel53
            // 
            this.tableLayoutPanel53.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel53.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel53.ColumnCount = 3;
            this.tableLayoutPanel53.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel53.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel53.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel53.Controls.Add(this.radioButton_EEPROM_LOW_CFG3, 0, 0);
            this.tableLayoutPanel53.Controls.Add(this.radioButton_EEPROM_OPEN_CFG3, 1, 0);
            this.tableLayoutPanel53.Controls.Add(this.radioButton_EEPROM_HIGH_CFG3, 2, 0);
            this.tableLayoutPanel53.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel53.Name = "tableLayoutPanel53";
            this.tableLayoutPanel53.RowCount = 1;
            this.tableLayoutPanel53.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel53.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel53.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel53.TabIndex = 14;
            // 
            // radioButton_EEPROM_LOW_CFG3
            // 
            this.radioButton_EEPROM_LOW_CFG3.AutoCheck = false;
            this.radioButton_EEPROM_LOW_CFG3.AutoSize = true;
            this.radioButton_EEPROM_LOW_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_LOW_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_LOW_CFG3.Location = new System.Drawing.Point(4, 4);
            this.radioButton_EEPROM_LOW_CFG3.Name = "radioButton_EEPROM_LOW_CFG3";
            this.radioButton_EEPROM_LOW_CFG3.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_LOW_CFG3.TabIndex = 14;
            this.radioButton_EEPROM_LOW_CFG3.Text = "LOW";
            this.radioButton_EEPROM_LOW_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_LOW_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_LOW_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_OPEN_CFG3
            // 
            this.radioButton_EEPROM_OPEN_CFG3.AutoCheck = false;
            this.radioButton_EEPROM_OPEN_CFG3.AutoSize = true;
            this.radioButton_EEPROM_OPEN_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_OPEN_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_OPEN_CFG3.Location = new System.Drawing.Point(72, 4);
            this.radioButton_EEPROM_OPEN_CFG3.Name = "radioButton_EEPROM_OPEN_CFG3";
            this.radioButton_EEPROM_OPEN_CFG3.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_OPEN_CFG3.TabIndex = 15;
            this.radioButton_EEPROM_OPEN_CFG3.Text = "OPEN";
            this.radioButton_EEPROM_OPEN_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_OPEN_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_OPEN_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_HIGH_CFG3
            // 
            this.radioButton_EEPROM_HIGH_CFG3.AutoCheck = false;
            this.radioButton_EEPROM_HIGH_CFG3.AutoSize = true;
            this.radioButton_EEPROM_HIGH_CFG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_HIGH_CFG3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_HIGH_CFG3.Location = new System.Drawing.Point(140, 4);
            this.radioButton_EEPROM_HIGH_CFG3.Name = "radioButton_EEPROM_HIGH_CFG3";
            this.radioButton_EEPROM_HIGH_CFG3.Size = new System.Drawing.Size(62, 31);
            this.radioButton_EEPROM_HIGH_CFG3.TabIndex = 16;
            this.radioButton_EEPROM_HIGH_CFG3.Text = "HIGH";
            this.radioButton_EEPROM_HIGH_CFG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_HIGH_CFG3.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_HIGH_CFG3.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(77, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 26);
            this.label19.TabIndex = 5;
            this.label19.Text = "CFG 3";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel54
            // 
            this.tableLayoutPanel54.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel54.ColumnCount = 1;
            this.tableLayoutPanel54.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel54.Controls.Add(this.tableLayoutPanel55, 0, 1);
            this.tableLayoutPanel54.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel54.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel54.Location = new System.Drawing.Point(3, 311);
            this.tableLayoutPanel54.Name = "tableLayoutPanel54";
            this.tableLayoutPanel54.RowCount = 2;
            this.tableLayoutPanel54.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel54.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel54.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel54.TabIndex = 15;
            // 
            // tableLayoutPanel55
            // 
            this.tableLayoutPanel55.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel55.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel55.ColumnCount = 3;
            this.tableLayoutPanel55.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel55.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel55.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel55.Controls.Add(this.radioButton_EEPROM_LOW_CFG2, 0, 0);
            this.tableLayoutPanel55.Controls.Add(this.radioButton_EEPROM_OPEN_CFG2, 1, 0);
            this.tableLayoutPanel55.Controls.Add(this.radioButton_EEPROM_HIGH_CFG2, 2, 0);
            this.tableLayoutPanel55.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel55.Name = "tableLayoutPanel55";
            this.tableLayoutPanel55.RowCount = 1;
            this.tableLayoutPanel55.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel55.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel55.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel55.TabIndex = 14;
            // 
            // radioButton_EEPROM_LOW_CFG2
            // 
            this.radioButton_EEPROM_LOW_CFG2.AutoCheck = false;
            this.radioButton_EEPROM_LOW_CFG2.AutoSize = true;
            this.radioButton_EEPROM_LOW_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_LOW_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_LOW_CFG2.Location = new System.Drawing.Point(4, 4);
            this.radioButton_EEPROM_LOW_CFG2.Name = "radioButton_EEPROM_LOW_CFG2";
            this.radioButton_EEPROM_LOW_CFG2.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_LOW_CFG2.TabIndex = 14;
            this.radioButton_EEPROM_LOW_CFG2.Text = "LOW";
            this.radioButton_EEPROM_LOW_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_LOW_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_LOW_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_OPEN_CFG2
            // 
            this.radioButton_EEPROM_OPEN_CFG2.AutoCheck = false;
            this.radioButton_EEPROM_OPEN_CFG2.AutoSize = true;
            this.radioButton_EEPROM_OPEN_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_OPEN_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_OPEN_CFG2.Location = new System.Drawing.Point(72, 4);
            this.radioButton_EEPROM_OPEN_CFG2.Name = "radioButton_EEPROM_OPEN_CFG2";
            this.radioButton_EEPROM_OPEN_CFG2.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_OPEN_CFG2.TabIndex = 15;
            this.radioButton_EEPROM_OPEN_CFG2.Text = "OPEN";
            this.radioButton_EEPROM_OPEN_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_OPEN_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_OPEN_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_HIGH_CFG2
            // 
            this.radioButton_EEPROM_HIGH_CFG2.AutoCheck = false;
            this.radioButton_EEPROM_HIGH_CFG2.AutoSize = true;
            this.radioButton_EEPROM_HIGH_CFG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_HIGH_CFG2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_HIGH_CFG2.Location = new System.Drawing.Point(140, 4);
            this.radioButton_EEPROM_HIGH_CFG2.Name = "radioButton_EEPROM_HIGH_CFG2";
            this.radioButton_EEPROM_HIGH_CFG2.Size = new System.Drawing.Size(62, 31);
            this.radioButton_EEPROM_HIGH_CFG2.TabIndex = 16;
            this.radioButton_EEPROM_HIGH_CFG2.Text = "HIGH";
            this.radioButton_EEPROM_HIGH_CFG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_HIGH_CFG2.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_HIGH_CFG2.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(77, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 26);
            this.label20.TabIndex = 4;
            this.label20.Text = "CFG 2";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel56
            // 
            this.tableLayoutPanel56.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel56.ColumnCount = 1;
            this.tableLayoutPanel56.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel56.Controls.Add(this.tableLayoutPanel57, 0, 1);
            this.tableLayoutPanel56.Controls.Add(this.label21, 0, 0);
            this.tableLayoutPanel56.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel56.Location = new System.Drawing.Point(3, 234);
            this.tableLayoutPanel56.Name = "tableLayoutPanel56";
            this.tableLayoutPanel56.RowCount = 2;
            this.tableLayoutPanel56.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel56.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel56.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel56.TabIndex = 15;
            // 
            // tableLayoutPanel57
            // 
            this.tableLayoutPanel57.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel57.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel57.ColumnCount = 3;
            this.tableLayoutPanel57.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel57.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel57.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel57.Controls.Add(this.radioButton_EEPROM_LOW_CFG1, 0, 0);
            this.tableLayoutPanel57.Controls.Add(this.radioButton_EEPROM_OPEN_CFG1, 1, 0);
            this.tableLayoutPanel57.Controls.Add(this.radioButton_EEPROM_HIGH_CFG1, 2, 0);
            this.tableLayoutPanel57.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel57.Name = "tableLayoutPanel57";
            this.tableLayoutPanel57.RowCount = 1;
            this.tableLayoutPanel57.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel57.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel57.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel57.TabIndex = 14;
            // 
            // radioButton_EEPROM_LOW_CFG1
            // 
            this.radioButton_EEPROM_LOW_CFG1.AutoCheck = false;
            this.radioButton_EEPROM_LOW_CFG1.AutoSize = true;
            this.radioButton_EEPROM_LOW_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_LOW_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_LOW_CFG1.Location = new System.Drawing.Point(4, 4);
            this.radioButton_EEPROM_LOW_CFG1.Name = "radioButton_EEPROM_LOW_CFG1";
            this.radioButton_EEPROM_LOW_CFG1.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_LOW_CFG1.TabIndex = 14;
            this.radioButton_EEPROM_LOW_CFG1.Text = "LOW";
            this.radioButton_EEPROM_LOW_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_LOW_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_LOW_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_OPEN_CFG1
            // 
            this.radioButton_EEPROM_OPEN_CFG1.AutoCheck = false;
            this.radioButton_EEPROM_OPEN_CFG1.AutoSize = true;
            this.radioButton_EEPROM_OPEN_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_OPEN_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_OPEN_CFG1.Location = new System.Drawing.Point(72, 4);
            this.radioButton_EEPROM_OPEN_CFG1.Name = "radioButton_EEPROM_OPEN_CFG1";
            this.radioButton_EEPROM_OPEN_CFG1.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_OPEN_CFG1.TabIndex = 15;
            this.radioButton_EEPROM_OPEN_CFG1.Text = "OPEN";
            this.radioButton_EEPROM_OPEN_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_OPEN_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_OPEN_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_HIGH_CFG1
            // 
            this.radioButton_EEPROM_HIGH_CFG1.AutoCheck = false;
            this.radioButton_EEPROM_HIGH_CFG1.AutoSize = true;
            this.radioButton_EEPROM_HIGH_CFG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_HIGH_CFG1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_HIGH_CFG1.Location = new System.Drawing.Point(140, 4);
            this.radioButton_EEPROM_HIGH_CFG1.Name = "radioButton_EEPROM_HIGH_CFG1";
            this.radioButton_EEPROM_HIGH_CFG1.Size = new System.Drawing.Size(62, 31);
            this.radioButton_EEPROM_HIGH_CFG1.TabIndex = 16;
            this.radioButton_EEPROM_HIGH_CFG1.Text = "HIGH";
            this.radioButton_EEPROM_HIGH_CFG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_HIGH_CFG1.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_HIGH_CFG1.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(77, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 26);
            this.label21.TabIndex = 3;
            this.label21.Text = "CFG 1";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel58
            // 
            this.tableLayoutPanel58.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel58.ColumnCount = 1;
            this.tableLayoutPanel58.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel58.Controls.Add(this.tableLayoutPanel59, 0, 1);
            this.tableLayoutPanel58.Controls.Add(this.label22, 0, 0);
            this.tableLayoutPanel58.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel58.Location = new System.Drawing.Point(3, 157);
            this.tableLayoutPanel58.Name = "tableLayoutPanel58";
            this.tableLayoutPanel58.RowCount = 2;
            this.tableLayoutPanel58.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel58.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel58.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel58.TabIndex = 15;
            // 
            // tableLayoutPanel59
            // 
            this.tableLayoutPanel59.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel59.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel59.ColumnCount = 3;
            this.tableLayoutPanel59.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel59.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel59.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel59.Controls.Add(this.radioButton_EEPROM_LOW_TESTMODE, 0, 0);
            this.tableLayoutPanel59.Controls.Add(this.radioButton_EEPROM_OPEN_TESTMODE, 1, 0);
            this.tableLayoutPanel59.Controls.Add(this.radioButton_EEPROM_HIGH_TESTMODE, 2, 0);
            this.tableLayoutPanel59.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel59.Name = "tableLayoutPanel59";
            this.tableLayoutPanel59.RowCount = 1;
            this.tableLayoutPanel59.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel59.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel59.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel59.TabIndex = 14;
            // 
            // radioButton_EEPROM_LOW_TESTMODE
            // 
            this.radioButton_EEPROM_LOW_TESTMODE.AutoCheck = false;
            this.radioButton_EEPROM_LOW_TESTMODE.AutoSize = true;
            this.radioButton_EEPROM_LOW_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_LOW_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_LOW_TESTMODE.Location = new System.Drawing.Point(4, 4);
            this.radioButton_EEPROM_LOW_TESTMODE.Name = "radioButton_EEPROM_LOW_TESTMODE";
            this.radioButton_EEPROM_LOW_TESTMODE.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_LOW_TESTMODE.TabIndex = 14;
            this.radioButton_EEPROM_LOW_TESTMODE.Text = "LOW";
            this.radioButton_EEPROM_LOW_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_LOW_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_LOW_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_OPEN_TESTMODE
            // 
            this.radioButton_EEPROM_OPEN_TESTMODE.AutoCheck = false;
            this.radioButton_EEPROM_OPEN_TESTMODE.AutoSize = true;
            this.radioButton_EEPROM_OPEN_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_OPEN_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_OPEN_TESTMODE.Location = new System.Drawing.Point(72, 4);
            this.radioButton_EEPROM_OPEN_TESTMODE.Name = "radioButton_EEPROM_OPEN_TESTMODE";
            this.radioButton_EEPROM_OPEN_TESTMODE.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_OPEN_TESTMODE.TabIndex = 15;
            this.radioButton_EEPROM_OPEN_TESTMODE.Text = "OPEN";
            this.radioButton_EEPROM_OPEN_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_OPEN_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_OPEN_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_HIGH_TESTMODE
            // 
            this.radioButton_EEPROM_HIGH_TESTMODE.AutoCheck = false;
            this.radioButton_EEPROM_HIGH_TESTMODE.AutoSize = true;
            this.radioButton_EEPROM_HIGH_TESTMODE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_HIGH_TESTMODE.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_HIGH_TESTMODE.Location = new System.Drawing.Point(140, 4);
            this.radioButton_EEPROM_HIGH_TESTMODE.Name = "radioButton_EEPROM_HIGH_TESTMODE";
            this.radioButton_EEPROM_HIGH_TESTMODE.Size = new System.Drawing.Size(62, 31);
            this.radioButton_EEPROM_HIGH_TESTMODE.TabIndex = 16;
            this.radioButton_EEPROM_HIGH_TESTMODE.Text = "HIGH";
            this.radioButton_EEPROM_HIGH_TESTMODE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_HIGH_TESTMODE.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_HIGH_TESTMODE.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(62, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 26);
            this.label22.TabIndex = 2;
            this.label22.Text = "TESTMODE";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel60
            // 
            this.tableLayoutPanel60.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel60.ColumnCount = 1;
            this.tableLayoutPanel60.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel60.Controls.Add(this.label23, 0, 0);
            this.tableLayoutPanel60.Controls.Add(this.tableLayoutPanel61, 0, 1);
            this.tableLayoutPanel60.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel60.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel60.Name = "tableLayoutPanel60";
            this.tableLayoutPanel60.RowCount = 2;
            this.tableLayoutPanel60.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel60.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel60.Size = new System.Drawing.Size(212, 71);
            this.tableLayoutPanel60.TabIndex = 15;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(67, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 26);
            this.label23.TabIndex = 1;
            this.label23.Text = "DEV_CFG";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel61
            // 
            this.tableLayoutPanel61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel61.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel61.ColumnCount = 3;
            this.tableLayoutPanel61.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel61.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel61.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel61.Controls.Add(this.radioButton_EEPROM_LOW_DEV_CFG, 0, 0);
            this.tableLayoutPanel61.Controls.Add(this.radioButton_EEPROM_OPEN_DEV_CFG, 1, 0);
            this.tableLayoutPanel61.Controls.Add(this.radioButton_EEPROM_HIGH_DEV_CFG, 2, 0);
            this.tableLayoutPanel61.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel61.Name = "tableLayoutPanel61";
            this.tableLayoutPanel61.RowCount = 1;
            this.tableLayoutPanel61.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel61.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel61.Size = new System.Drawing.Size(206, 39);
            this.tableLayoutPanel61.TabIndex = 14;
            // 
            // radioButton_EEPROM_LOW_DEV_CFG
            // 
            this.radioButton_EEPROM_LOW_DEV_CFG.AutoCheck = false;
            this.radioButton_EEPROM_LOW_DEV_CFG.AutoSize = true;
            this.radioButton_EEPROM_LOW_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_LOW_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_LOW_DEV_CFG.Location = new System.Drawing.Point(4, 4);
            this.radioButton_EEPROM_LOW_DEV_CFG.Name = "radioButton_EEPROM_LOW_DEV_CFG";
            this.radioButton_EEPROM_LOW_DEV_CFG.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_LOW_DEV_CFG.TabIndex = 14;
            this.radioButton_EEPROM_LOW_DEV_CFG.Text = "LOW";
            this.radioButton_EEPROM_LOW_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_LOW_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_LOW_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_OPEN_DEV_CFG
            // 
            this.radioButton_EEPROM_OPEN_DEV_CFG.AutoCheck = false;
            this.radioButton_EEPROM_OPEN_DEV_CFG.AutoSize = true;
            this.radioButton_EEPROM_OPEN_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_OPEN_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_OPEN_DEV_CFG.Location = new System.Drawing.Point(72, 4);
            this.radioButton_EEPROM_OPEN_DEV_CFG.Name = "radioButton_EEPROM_OPEN_DEV_CFG";
            this.radioButton_EEPROM_OPEN_DEV_CFG.Size = new System.Drawing.Size(61, 31);
            this.radioButton_EEPROM_OPEN_DEV_CFG.TabIndex = 15;
            this.radioButton_EEPROM_OPEN_DEV_CFG.Text = "OPEN";
            this.radioButton_EEPROM_OPEN_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_OPEN_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_OPEN_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // radioButton_EEPROM_HIGH_DEV_CFG
            // 
            this.radioButton_EEPROM_HIGH_DEV_CFG.AutoCheck = false;
            this.radioButton_EEPROM_HIGH_DEV_CFG.AutoSize = true;
            this.radioButton_EEPROM_HIGH_DEV_CFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButton_EEPROM_HIGH_DEV_CFG.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_EEPROM_HIGH_DEV_CFG.Location = new System.Drawing.Point(140, 4);
            this.radioButton_EEPROM_HIGH_DEV_CFG.Name = "radioButton_EEPROM_HIGH_DEV_CFG";
            this.radioButton_EEPROM_HIGH_DEV_CFG.Size = new System.Drawing.Size(62, 31);
            this.radioButton_EEPROM_HIGH_DEV_CFG.TabIndex = 16;
            this.radioButton_EEPROM_HIGH_DEV_CFG.Text = "HIGH";
            this.radioButton_EEPROM_HIGH_DEV_CFG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_EEPROM_HIGH_DEV_CFG.UseVisualStyleBackColor = true;
            this.radioButton_EEPROM_HIGH_DEV_CFG.CheckedChanged += new System.EventHandler(this.Checked_changed_RB);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.richTextBox_cfg_bits_setup_mem_type);
            this.panel1.Controls.Add(this.label_frame_name);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 573);
            this.panel1.TabIndex = 20;
            // 
            // richTextBox_cfg_bits_setup_mem_type
            // 
            this.richTextBox_cfg_bits_setup_mem_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_cfg_bits_setup_mem_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_cfg_bits_setup_mem_type.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_cfg_bits_setup_mem_type.ForeColor = System.Drawing.Color.White;
            this.richTextBox_cfg_bits_setup_mem_type.Location = new System.Drawing.Point(153, 6);
            this.richTextBox_cfg_bits_setup_mem_type.Multiline = false;
            this.richTextBox_cfg_bits_setup_mem_type.Name = "richTextBox_cfg_bits_setup_mem_type";
            this.richTextBox_cfg_bits_setup_mem_type.ReadOnly = true;
            this.richTextBox_cfg_bits_setup_mem_type.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_cfg_bits_setup_mem_type.Size = new System.Drawing.Size(65, 19);
            this.richTextBox_cfg_bits_setup_mem_type.TabIndex = 22;
            this.richTextBox_cfg_bits_setup_mem_type.TabStop = false;
            this.richTextBox_cfg_bits_setup_mem_type.Text = "      M-type";
            this.toolTip1.SetToolTip(this.richTextBox_cfg_bits_setup_mem_type, "Shows the selection of CFG priority storage memory");
            // 
            // label_frame_name
            // 
            this.label_frame_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_frame_name.AutoSize = true;
            this.label_frame_name.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_frame_name.ForeColor = System.Drawing.Color.Black;
            this.label_frame_name.Location = new System.Drawing.Point(6, 6);
            this.label_frame_name.Name = "label_frame_name";
            this.label_frame_name.Size = new System.Drawing.Size(95, 18);
            this.label_frame_name.TabIndex = 21;
            this.label_frame_name.Text = "CFG bits setup";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label_CFG_bits_description);
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Location = new System.Drawing.Point(242, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 573);
            this.panel2.TabIndex = 21;
            // 
            // label_CFG_bits_description
            // 
            this.label_CFG_bits_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CFG_bits_description.AutoSize = true;
            this.label_CFG_bits_description.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CFG_bits_description.ForeColor = System.Drawing.Color.Black;
            this.label_CFG_bits_description.Location = new System.Drawing.Point(138, 6);
            this.label_CFG_bits_description.Name = "label_CFG_bits_description";
            this.label_CFG_bits_description.Size = new System.Drawing.Size(227, 18);
            this.label_CFG_bits_description.TabIndex = 22;
            this.label_CFG_bits_description.Text = "CFG bits description - Industrial type";
            // 
            // panel_current_state_bits
            // 
            this.panel_current_state_bits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_current_state_bits.Controls.Add(this.richTextBox_current_bits_state_mem_type);
            this.panel_current_state_bits.Controls.Add(this.label25);
            this.panel_current_state_bits.Controls.Add(this.tableLayoutPanel1);
            this.panel_current_state_bits.Location = new System.Drawing.Point(808, 34);
            this.panel_current_state_bits.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel_current_state_bits.Name = "panel_current_state_bits";
            this.panel_current_state_bits.Size = new System.Drawing.Size(224, 573);
            this.panel_current_state_bits.TabIndex = 22;
            // 
            // richTextBox_current_bits_state_mem_type
            // 
            this.richTextBox_current_bits_state_mem_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_current_bits_state_mem_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_current_bits_state_mem_type.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_current_bits_state_mem_type.ForeColor = System.Drawing.Color.White;
            this.richTextBox_current_bits_state_mem_type.Location = new System.Drawing.Point(153, 6);
            this.richTextBox_current_bits_state_mem_type.Multiline = false;
            this.richTextBox_current_bits_state_mem_type.Name = "richTextBox_current_bits_state_mem_type";
            this.richTextBox_current_bits_state_mem_type.ReadOnly = true;
            this.richTextBox_current_bits_state_mem_type.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_current_bits_state_mem_type.Size = new System.Drawing.Size(65, 19);
            this.richTextBox_current_bits_state_mem_type.TabIndex = 23;
            this.richTextBox_current_bits_state_mem_type.TabStop = false;
            this.richTextBox_current_bits_state_mem_type.Text = "NA";
            this.toolTip1.SetToolTip(this.richTextBox_current_bits_state_mem_type, "Shows CFG storage memory");
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(6, 6);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 18);
            this.label25.TabIndex = 21;
            this.label25.Text = "Current bits state";
            // 
            // panel_FLASH_bits
            // 
            this.panel_FLASH_bits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_FLASH_bits.Controls.Add(this.richTextBox_cfg_in_flash_mem_type);
            this.panel_FLASH_bits.Controls.Add(this.label26);
            this.panel_FLASH_bits.Controls.Add(this.tableLayoutPanel32);
            this.panel_FLASH_bits.Location = new System.Drawing.Point(1038, 34);
            this.panel_FLASH_bits.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel_FLASH_bits.Name = "panel_FLASH_bits";
            this.panel_FLASH_bits.Size = new System.Drawing.Size(224, 573);
            this.panel_FLASH_bits.TabIndex = 23;
            this.panel_FLASH_bits.Visible = false;
            // 
            // richTextBox_cfg_in_flash_mem_type
            // 
            this.richTextBox_cfg_in_flash_mem_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_cfg_in_flash_mem_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_cfg_in_flash_mem_type.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_cfg_in_flash_mem_type.ForeColor = System.Drawing.Color.White;
            this.richTextBox_cfg_in_flash_mem_type.Location = new System.Drawing.Point(153, 6);
            this.richTextBox_cfg_in_flash_mem_type.Multiline = false;
            this.richTextBox_cfg_in_flash_mem_type.Name = "richTextBox_cfg_in_flash_mem_type";
            this.richTextBox_cfg_in_flash_mem_type.ReadOnly = true;
            this.richTextBox_cfg_in_flash_mem_type.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_cfg_in_flash_mem_type.Size = new System.Drawing.Size(65, 19);
            this.richTextBox_cfg_in_flash_mem_type.TabIndex = 23;
            this.richTextBox_cfg_in_flash_mem_type.TabStop = false;
            this.richTextBox_cfg_in_flash_mem_type.Text = "NA";
            this.toolTip1.SetToolTip(this.richTextBox_cfg_in_flash_mem_type, "Shows CFG storage memory");
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(6, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(103, 18);
            this.label26.TabIndex = 21;
            this.label26.Text = "Config in FLASH";
            // 
            // panel_EEPROM_bits
            // 
            this.panel_EEPROM_bits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_EEPROM_bits.Controls.Add(this.richTextBox_cfg_in_eeprom_mem_type);
            this.panel_EEPROM_bits.Controls.Add(this.label27);
            this.panel_EEPROM_bits.Controls.Add(this.tableLayoutPanel47);
            this.panel_EEPROM_bits.Location = new System.Drawing.Point(1268, 34);
            this.panel_EEPROM_bits.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.panel_EEPROM_bits.Name = "panel_EEPROM_bits";
            this.panel_EEPROM_bits.Size = new System.Drawing.Size(224, 573);
            this.panel_EEPROM_bits.TabIndex = 23;
            this.panel_EEPROM_bits.Visible = false;
            // 
            // richTextBox_cfg_in_eeprom_mem_type
            // 
            this.richTextBox_cfg_in_eeprom_mem_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.richTextBox_cfg_in_eeprom_mem_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_cfg_in_eeprom_mem_type.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox_cfg_in_eeprom_mem_type.ForeColor = System.Drawing.Color.White;
            this.richTextBox_cfg_in_eeprom_mem_type.Location = new System.Drawing.Point(153, 6);
            this.richTextBox_cfg_in_eeprom_mem_type.Multiline = false;
            this.richTextBox_cfg_in_eeprom_mem_type.Name = "richTextBox_cfg_in_eeprom_mem_type";
            this.richTextBox_cfg_in_eeprom_mem_type.ReadOnly = true;
            this.richTextBox_cfg_in_eeprom_mem_type.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_cfg_in_eeprom_mem_type.Size = new System.Drawing.Size(65, 19);
            this.richTextBox_cfg_in_eeprom_mem_type.TabIndex = 23;
            this.richTextBox_cfg_in_eeprom_mem_type.TabStop = false;
            this.richTextBox_cfg_in_eeprom_mem_type.Text = "NA";
            this.toolTip1.SetToolTip(this.richTextBox_cfg_in_eeprom_mem_type, "Shows CFG storage memory");
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(6, 6);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(116, 18);
            this.label27.TabIndex = 21;
            this.label27.Text = "Config in EEPROM";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1504, 637);
            this.Controls.Add(this.panel_EEPROM_bits);
            this.Controls.Add(this.panel_FLASH_bits);
            this.Controls.Add(this.panel_current_state_bits);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PTN3460/I Configurator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.tableLayoutPanel23.ResumeLayout(false);
            this.tableLayoutPanel23.PerformLayout();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel24.PerformLayout();
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel25.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel27.PerformLayout();
            this.tableLayoutPanel28.ResumeLayout(false);
            this.tableLayoutPanel28.PerformLayout();
            this.tableLayoutPanel29.ResumeLayout(false);
            this.tableLayoutPanel29.PerformLayout();
            this.tableLayoutPanel30.ResumeLayout(false);
            this.tableLayoutPanel30.PerformLayout();
            this.tableLayoutPanel31.ResumeLayout(false);
            this.tableLayoutPanel31.PerformLayout();
            this.tableLayoutPanel32.ResumeLayout(false);
            this.tableLayoutPanel33.ResumeLayout(false);
            this.tableLayoutPanel33.PerformLayout();
            this.tableLayoutPanel34.ResumeLayout(false);
            this.tableLayoutPanel34.PerformLayout();
            this.tableLayoutPanel35.ResumeLayout(false);
            this.tableLayoutPanel35.PerformLayout();
            this.tableLayoutPanel36.ResumeLayout(false);
            this.tableLayoutPanel36.PerformLayout();
            this.tableLayoutPanel37.ResumeLayout(false);
            this.tableLayoutPanel37.PerformLayout();
            this.tableLayoutPanel38.ResumeLayout(false);
            this.tableLayoutPanel38.PerformLayout();
            this.tableLayoutPanel39.ResumeLayout(false);
            this.tableLayoutPanel39.PerformLayout();
            this.tableLayoutPanel40.ResumeLayout(false);
            this.tableLayoutPanel40.PerformLayout();
            this.tableLayoutPanel41.ResumeLayout(false);
            this.tableLayoutPanel41.PerformLayout();
            this.tableLayoutPanel42.ResumeLayout(false);
            this.tableLayoutPanel42.PerformLayout();
            this.tableLayoutPanel43.ResumeLayout(false);
            this.tableLayoutPanel43.PerformLayout();
            this.tableLayoutPanel44.ResumeLayout(false);
            this.tableLayoutPanel44.PerformLayout();
            this.tableLayoutPanel45.ResumeLayout(false);
            this.tableLayoutPanel45.PerformLayout();
            this.tableLayoutPanel46.ResumeLayout(false);
            this.tableLayoutPanel46.PerformLayout();
            this.tableLayoutPanel47.ResumeLayout(false);
            this.tableLayoutPanel48.ResumeLayout(false);
            this.tableLayoutPanel48.PerformLayout();
            this.tableLayoutPanel49.ResumeLayout(false);
            this.tableLayoutPanel49.PerformLayout();
            this.tableLayoutPanel50.ResumeLayout(false);
            this.tableLayoutPanel50.PerformLayout();
            this.tableLayoutPanel51.ResumeLayout(false);
            this.tableLayoutPanel51.PerformLayout();
            this.tableLayoutPanel52.ResumeLayout(false);
            this.tableLayoutPanel52.PerformLayout();
            this.tableLayoutPanel53.ResumeLayout(false);
            this.tableLayoutPanel53.PerformLayout();
            this.tableLayoutPanel54.ResumeLayout(false);
            this.tableLayoutPanel54.PerformLayout();
            this.tableLayoutPanel55.ResumeLayout(false);
            this.tableLayoutPanel55.PerformLayout();
            this.tableLayoutPanel56.ResumeLayout(false);
            this.tableLayoutPanel56.PerformLayout();
            this.tableLayoutPanel57.ResumeLayout(false);
            this.tableLayoutPanel57.PerformLayout();
            this.tableLayoutPanel58.ResumeLayout(false);
            this.tableLayoutPanel58.PerformLayout();
            this.tableLayoutPanel59.ResumeLayout(false);
            this.tableLayoutPanel59.PerformLayout();
            this.tableLayoutPanel60.ResumeLayout(false);
            this.tableLayoutPanel60.PerformLayout();
            this.tableLayoutPanel61.ResumeLayout(false);
            this.tableLayoutPanel61.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_current_state_bits.ResumeLayout(false);
            this.panel_current_state_bits.PerformLayout();
            this.panel_FLASH_bits.ResumeLayout(false);
            this.panel_FLASH_bits.PerformLayout();
            this.panel_EEPROM_bits.ResumeLayout(false);
            this.panel_EEPROM_bits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem pTN3460ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_PD_N;
        private System.Windows.Forms.Label label_DEV_CFG;
        private System.Windows.Forms.Label label_TESTMODE;
        private System.Windows.Forms.Label label_CFG_1;
        private System.Windows.Forms.Label label_CFG_2;
        private System.Windows.Forms.Label label_CFG_3;
        private System.Windows.Forms.Label label_CFG_4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.RadioButton radioButton_STATE_LOW_CFG4;
        private System.Windows.Forms.RadioButton radioButton_STATE_OPEN_CFG4;
        private System.Windows.Forms.RadioButton radioButton_STATE_HIGH_CFG4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.RadioButton radioButton_STATE_LOW_CFG3;
        private System.Windows.Forms.RadioButton radioButton_STATE_OPEN_CFG3;
        private System.Windows.Forms.RadioButton radioButton_STATE_HIGH_CFG3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.RadioButton radioButton_STATE_LOW_CFG2;
        private System.Windows.Forms.RadioButton radioButton_STATE_OPEN_CFG2;
        private System.Windows.Forms.RadioButton radioButton_STATE_HIGH_CFG2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.RadioButton radioButton_STATE_LOW_CFG1;
        private System.Windows.Forms.RadioButton radioButton_STATE_OPEN_CFG1;
        private System.Windows.Forms.RadioButton radioButton_STATE_HIGH_CFG1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.RadioButton radioButton_STATE_LOW_TESTMODE;
        private System.Windows.Forms.RadioButton radioButton_STATE_OPEN_TESTMODE;
        private System.Windows.Forms.RadioButton radioButton_STATE_HIGH_TESTMODE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.RadioButton radioButton_STATE_LOW_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_STATE_OPEN_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_STATE_HIGH_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_STATE_LOW_PD_N;
        private System.Windows.Forms.RadioButton radioButton_STATE_OPEN_PD_N;
        private System.Windows.Forms.RadioButton radioButton_STATE_HIGH_PD_N;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.RadioButton radioButton_LOW_PD_N;
        private System.Windows.Forms.RadioButton radioButton_HIGH_PD_N;
        private System.Windows.Forms.RadioButton radioButton_OPEN_PD_N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.RadioButton radioButton_LOW_CFG4;
        private System.Windows.Forms.RadioButton radioButton_OPEN_CFG4;
        private System.Windows.Forms.RadioButton radioButton_HIGH_CFG4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.RadioButton radioButton_LOW_CFG3;
        private System.Windows.Forms.RadioButton radioButton_OPEN_CFG3;
        private System.Windows.Forms.RadioButton radioButton_HIGH_CFG3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.RadioButton radioButton_LOW_CFG2;
        private System.Windows.Forms.RadioButton radioButton_OPEN_CFG2;
        private System.Windows.Forms.RadioButton radioButton_HIGH_CFG2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.RadioButton radioButton_LOW_CFG1;
        private System.Windows.Forms.RadioButton radioButton_OPEN_CFG1;
        private System.Windows.Forms.RadioButton radioButton_HIGH_CFG1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel28;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel29;
        private System.Windows.Forms.RadioButton radioButton_LOW_TESTMODE;
        private System.Windows.Forms.RadioButton radioButton_OPEN_TESTMODE;
        private System.Windows.Forms.RadioButton radioButton_HIGH_TESTMODE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel30;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel31;
        private System.Windows.Forms.RadioButton radioButton_LOW_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_OPEN_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_HIGH_DEV_CFG;
        private System.Windows.Forms.RichTextBox richTextBox_CFG1;
        private System.Windows.Forms.RichTextBox richTextBox_CFG3;
        private System.Windows.Forms.RichTextBox richTextBox_CFG2;
        private System.Windows.Forms.RichTextBox richTextBox_CFG4;
        private System.Windows.Forms.RichTextBox richTextBox_TESTMODE;
        private System.Windows.Forms.RichTextBox richTextBox_PD_N;
        private System.Windows.Forms.RichTextBox richTextBox_DEV_CFG;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Reset_PTN_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commercialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem industrialToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DeviceStatus;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fLASHBitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FLASH_bits_Show_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FLASH_bits_Hide_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eEPROMBitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EEPROM_bits_Show_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EEPROM_bits_Hide_ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel32;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel33;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel34;
        private System.Windows.Forms.RadioButton radioButton_FLASH_LOW_PD_N;
        private System.Windows.Forms.RadioButton radioButton_FLASH_HIGH_PD_N;
        private System.Windows.Forms.RadioButton radioButton_FLASH_OPEN_PD_N;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel35;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel36;
        private System.Windows.Forms.RadioButton radioButton_FLASH_LOW_CFG4;
        private System.Windows.Forms.RadioButton radioButton_FLASH_OPEN_CFG4;
        private System.Windows.Forms.RadioButton radioButton_FLASH_HIGH_CFG4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel37;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel38;
        private System.Windows.Forms.RadioButton radioButton_FLASH_LOW_CFG3;
        private System.Windows.Forms.RadioButton radioButton_FLASH_OPEN_CFG3;
        private System.Windows.Forms.RadioButton radioButton_FLASH_HIGH_CFG3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel39;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel40;
        private System.Windows.Forms.RadioButton radioButton_FLASH_LOW_CFG2;
        private System.Windows.Forms.RadioButton radioButton_FLASH_OPEN_CFG2;
        private System.Windows.Forms.RadioButton radioButton_FLASH_HIGH_CFG2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel41;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel42;
        private System.Windows.Forms.RadioButton radioButton_FLASH_LOW_CFG1;
        private System.Windows.Forms.RadioButton radioButton_FLASH_OPEN_CFG1;
        private System.Windows.Forms.RadioButton radioButton_FLASH_HIGH_CFG1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel43;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel44;
        private System.Windows.Forms.RadioButton radioButton_FLASH_LOW_TESTMODE;
        private System.Windows.Forms.RadioButton radioButton_FLASH_OPEN_TESTMODE;
        private System.Windows.Forms.RadioButton radioButton_FLASH_HIGH_TESTMODE;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel45;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel46;
        private System.Windows.Forms.RadioButton radioButton_FLASH_LOW_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_FLASH_OPEN_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_FLASH_HIGH_DEV_CFG;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel47;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel48;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel49;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_LOW_PD_N;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_HIGH_PD_N;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_OPEN_PD_N;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel50;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel51;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_LOW_CFG4;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_OPEN_CFG4;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_HIGH_CFG4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel52;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel53;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_LOW_CFG3;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_OPEN_CFG3;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_HIGH_CFG3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel54;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel55;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_LOW_CFG2;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_OPEN_CFG2;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_HIGH_CFG2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel56;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel57;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_LOW_CFG1;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_OPEN_CFG1;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_HIGH_CFG1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel58;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel59;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_LOW_TESTMODE;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_OPEN_TESTMODE;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_HIGH_TESTMODE;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel60;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel61;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_LOW_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_OPEN_DEV_CFG;
        private System.Windows.Forms.RadioButton radioButton_EEPROM_HIGH_DEV_CFG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_frame_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_CFG_bits_description;
        private System.Windows.Forms.Panel panel_current_state_bits;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel_FLASH_bits;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel_EEPROM_bits;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public  System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DeviceErrorMessage;
        private System.Windows.Forms.ToolStripMenuItem eDIDToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem pTNPinsConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Read_CFG_from_STM32_Current_state_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Write_CFG_to_STM32_Online_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fLASHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Read_CFG_from_STM32_FLASH_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Write_CFG_to_STM32_FLASH_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eEPROMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Read_CFG_from_STM32_EEPROM_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Write_CFG_to_STM32_EEPROM_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel STM_EEPROM_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel EDID_EEPROM_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel Read_Write_status_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem Show_device_info_toolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem priorityStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Priority_CFG_bits_storage_EEPROM_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Priority_CFG_bits_storage_FLASH_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel Priority_CFG_bits_storage_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.RichTextBox richTextBox_cfg_bits_setup_mem_type;
        private System.Windows.Forms.RichTextBox richTextBox_current_bits_state_mem_type;
        private System.Windows.Forms.RichTextBox richTextBox_cfg_in_flash_mem_type;
        private System.Windows.Forms.RichTextBox richTextBox_cfg_in_eeprom_mem_type;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem controlPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorsToolStripMenuItem;
    }
}

