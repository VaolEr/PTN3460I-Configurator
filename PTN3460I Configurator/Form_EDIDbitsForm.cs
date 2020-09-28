using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static PTN3460I_Configurator.USB;
using System.Diagnostics;

namespace PTN3460I_Configurator
{

    public partial class Form_EDIDbitsForm : Form
    {
        byte[] default_cfg = {0x00, 0x0B, 0x03, 0x00, 0x03, 0x00, 0x00, 0x00, 0x01, 0xFE, 0x00, 0x00, 0x08, 0x00, 0x00, 0x0C,
                              0x07, 0xFF, 0x00, 0x0A, 0x14, 0x00, 0x01, 0x02, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x12, 0x34, 0x56, 0x78,
                              0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF};

        byte[] line = new byte[256];
        int redbytes = 0;

        byte[] EDID_cfg_FROM_EEPROM = new byte[256];
        public byte[] EDID_cfg_TO_EEPROM = new byte[256];

        Label[] EDID_cfg_from_file_labels = new Label[256];
        Label[] HI_file_labels = new Label[16];
        Label[] VI_file_labels = new Label[16];
        //--------------------------------------------------//
        Label[] EDID_cfg_from_EEPROM_labels = new Label[256];
        Label[] HI_EEPROM_labels = new Label[16];
        Label[] VI_EEPROM_labels = new Label[16];

        #region Class for new visualisation of Tool Strip Menu
        public class Cols : ProfessionalColorTable
        {
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
                get { return Color.FromArgb(60, 60, 60); }
            }

            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.FromArgb(70, 70, 70); }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.FromArgb(80, 80, 80); }
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

        public Form_EDIDbitsForm()
        {
            String[] values = {"00","01","02","03","04","05","06","07","08","09","0A","0B","0C","0D","0E","0F"};
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new Cols());

            Form_MainForm myForm_MainForm = this.Owner as Form_MainForm;

            CreateLabelsForTables(EDID_cfg_from_file_labels, 256);
            CreateLabelsForTables(HI_file_labels, 16);
            CreateLabelsForTables(VI_file_labels, 16);

            CreateLabelsForTables(EDID_cfg_from_EEPROM_labels, 256);
            CreateLabelsForTables(HI_EEPROM_labels, 16);
            CreateLabelsForTables(VI_EEPROM_labels, 16);

            InitializeLabelsForTables(tableLayoutPanel_EDID_and_PTN_cfg_bits, EDID_cfg_from_file_labels, 256, "");
            InitializeLabelsForTables(tableLayoutPanel1, HI_file_labels, 16, "");
            InitializeLabelsForTables(tableLayoutPanel2, VI_file_labels, 16, "");

            InitializeLabelsForTables(tableLayoutPanel_EDID_cfg_from_EEPROM, EDID_cfg_from_EEPROM_labels, 256, "");
            InitializeLabelsForTables(tableLayoutPanel4, HI_EEPROM_labels, 16, "");
            InitializeLabelsForTables(tableLayoutPanel3, VI_EEPROM_labels, 16, "");

            #region Label arrays defines
            //Label[] EDID_and_cfg_bits_labels = {
            //    label1,   label2,   label3,   label4,   label5,   label6,   label7,   label8,   label9,   label10,  label11,  label12,  label13,  label14,  label15,  label16,
            //    label17,  label18,  label19,  label20,  label21,  label22,  label23,  label24,  label25,  label26,  label27,  label28,  label29,  label30,  label31,  label32,
            //    label33,  label34,  label35,  label36,  label37,  label38,  label39,  label40,  label41,  label42,  label43,  label44,  label45,  label46,  label47,  label48,
            //    label49,  label50,  label51,  label52,  label53,  label54,  label55,  label56,  label57,  label58,  label59,  label60,  label61,  label62,  label63,  label64,
            //    label65,  label66,  label67,  label68,  label69,  label70,  label71,  label72,  label73,  label74,  label75,  label76,  label77,  label78,  label79,  label80,
            //    label81,  label82,  label83,  label84,  label85,  label86,  label87,  label88,  label89,  label90,  label91,  label92,  label93,  label94,  label95,  label96,
            //    label97,  label98,  label99,  label100, label101, label102, label103, label104, label105, label106, label107, label108, label109, label110, label11,  label112,
            //    label113, label114, label115, label116, label117, label118, label119, label120, label121, label122, label123, label124, label125, label126, label127, label128,
            //    label129, label130, label131, label132, label133, label134, label135, label136, label137, label138, label139, label140, label141, label142, label143, label144,
            //    label145, label146, label147, label148, label149, label150, label151, label152, label153, label154, label155, label156, label157, label158, label159, label160,
            //    label161, label162, label163, label164, label165, label166, label167, label168, label169, label170, label171, label172, label173, label174, label175, label176,
            //    label177, label178, label179, label180, label181, label182, label183, label184, label185, label186, label187, label188, label189, label190, label191, label192,
            //    label193, label194, label195, label196, label197, label198, label199, label200, label201, label202, label203, label204, label205, label206, label207, label208,
            //    label209, label210, label211, label212, label213, label214, label215, label216, label217, label218, label219, label220, label221, label222, label223, label224,
            //    label225, label226, label227, label228, label229, label230, label231, label232, label233, label234, label235, label236, label237, label238, label239, label240,
            //    label241, label242, label243, label244, label245, label246, label247, label248, label249, label250, label251, label252, label253, label254, label255, label256
            //};
            //Label[] horizontal_array = new[] {
            //    label257, label258, label259, label260, label261, label262, label263, label264, label265, label266, label267, label268, label269, label270, label271, label272
            //};
            //Label[] vertical_array = new[] {
            //    label273, label274, label275, label276, label277, label278, label279, label280, label281, label282, label283, label284, label285, label286, label287, label288
            //};
            #endregion

            #region Initalize the fields on start
            for (int i = 0; i < 16; i++)
            {
                //horizontal_array[i].Text = values[i];
                //vertical_array[i].Text = values[i];
                HI_file_labels[i].Text = values[i];
                HI_file_labels[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                HI_file_labels[i].ForeColor = System.Drawing.Color.White;

                VI_file_labels[i].Text = values[i];
                VI_file_labels[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                VI_file_labels[i].ForeColor = System.Drawing.Color.White;

                HI_EEPROM_labels[i].Text = values[i];
                HI_EEPROM_labels[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                HI_EEPROM_labels[i].ForeColor = System.Drawing.Color.White;

                VI_EEPROM_labels[i].Text = values[i];
                VI_EEPROM_labels[i].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                VI_EEPROM_labels[i].ForeColor = System.Drawing.Color.White;
            }
            #endregion

        }

        private static void __pause(int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();
        }

        private void CreateLabelsForTables(Label[] labels_array, int labels_count)
        {
            for (int i = 0; i < labels_count; i++)
            {
                labels_array[i] = new Label();
                labels_array[i].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                labels_array[i].AutoSize = true;
                labels_array[i].BackColor = System.Drawing.SystemColors.ControlLightLight;
                labels_array[i].Margin = new System.Windows.Forms.Padding(1);
                labels_array[i].Name = "label_EEPROM_EDID_data_" + Convert.ToString(i);
                labels_array[i].Size = new System.Drawing.Size(28, 28);
                labels_array[i].Text = "00";
                labels_array[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
        }
        private void InitializeLabelsForTables(TableLayoutPanel tableLayoutPanel, Label[] labels_array, int labels_count, String init_text)
        {
            for (int i = 0; i < labels_count; i++)
            {
                labels_array[i].Text = init_text;
                tableLayoutPanel.Controls.Add(labels_array[i]);
            }
        }

        private void WriteNewDataToLabel(Label label, string text)
        {
            label.Text = text;
        }
        private void Form_EDIDbitsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                Form_MainForm myForm_MainForm = this.Owner as Form_MainForm;
                myForm_MainForm.Show();
            }
        }

        private void OPEN_EDID_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog()
            {
                Filter = "binary (*.bin;*.BIN)|*.bin;*.BIN|txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 0,
                RestoreDirectory = true
            };
            try
            {
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.Text = "PTN3460/I Configurator - EDID & CFG loader [ " + OpenFileDialog1.FileName + " ]";

                    BinaryReader reader = new BinaryReader(File.Open(OpenFileDialog1.FileName, FileMode.Open));
                    redbytes = reader.Read(line, 0, 256);

                    for (int i = 0; i < 256; i++)
                    {
                        EDID_cfg_TO_EEPROM[i] = line[i];
                        WriteNewDataToLabel(EDID_cfg_from_file_labels[i], EDID_cfg_TO_EEPROM[i].ToString("X"));
                    }
                }

            }
            catch (Exception ex)
            {

            }
            ClearHighlightBytes();
        }

        private void ClearHighlightBytes()
        {
            for (int i = 0; i < 256; i++)
            {
              ChangeLabelBackColor(EDID_cfg_from_file_labels[i], System.Drawing.SystemColors.ControlLightLight);
              ChangeLabelBackColor(EDID_cfg_from_EEPROM_labels[i], System.Drawing.SystemColors.ControlLightLight);
            }
        }
        private void EDID_download_from_EEPROM_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MainForm myForm_MainForm = this.Owner as Form_MainForm;
            Form_MainForm.USB_device.DetectDeviceOnBus(Form_MainForm.USB_VID, Form_MainForm.USB_PID);
            if (Form_MainForm.USB_device.DeviceOnBusDetected)
            {

                ClearHighlightBytes();
                label_data_upload_status.Text = "Downloading data 7%";

                Form_MainForm.Read_EDID_from_PTN_EEPROM();
                label_data_upload_status.Text = "Downloading data 97%";

                __pause(300);
                for (int i = 0; i < 256; i++) WriteNewDataToLabel(EDID_cfg_from_EEPROM_labels[i], Form_MainForm.EDID_from_EEPROM_buff[i].ToString("X"));
                label_data_upload_status.Text = "Downloading data 100%";

                myForm_MainForm.toolStripStatusLabel_DeviceErrorMessage.Text = Form_MainForm.ErrorMessage;
        }
            else
            {
                myForm_MainForm.StatesIfDeviceNotFound();
                MessageBox.Show("USB device not found! Check the connection!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
}

        private void EDID_upload_to_EEPROM_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MainForm myForm_MainForm = this.Owner as Form_MainForm;
            Form_MainForm.USB_device.DetectDeviceOnBus(Form_MainForm.USB_VID, Form_MainForm.USB_PID);
            if (Form_MainForm.USB_device.DeviceOnBusDetected)
            {
                myForm_MainForm.Read_Write_status_toolStripStatusLabel.Text = "Updating data...";
                label_data_upload_status.Text = "Uploading data 3%";

                __pause(300);
                ClearHighlightBytes();
                label_data_upload_status.Text = "Uploading data 7%";

                Form_MainForm.Write_EDID_to_PTN_EEPROM();

                myForm_MainForm.toolStripStatusLabel_DeviceErrorMessage.Text = Form_MainForm.ErrorMessage;
                label_data_upload_status.Text = "Uploading data 100%";
            }
            else
            {
                myForm_MainForm.StatesIfDeviceNotFound();
                MessageBox.Show("USB device not found! Check the connection!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void ChangeLabelBackColor(Label label, Color color)
        {
            label.BackColor = color;
        }
        private void EDID_CFG_check_Differences_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool data_comparison_flag = true;
            for(int i = 0; i <256; i++)
            {
                if(EDID_cfg_from_file_labels[i].Text != EDID_cfg_from_EEPROM_labels[i].Text)
                {
                    ChangeLabelBackColor(EDID_cfg_from_file_labels[i], Color.FromArgb(194, 124, 81));
                    ChangeLabelBackColor(EDID_cfg_from_EEPROM_labels[i], Color.FromArgb(194, 124, 81));
                    data_comparison_flag = false;
                }
                else
                {                    
                    ChangeLabelBackColor(EDID_cfg_from_file_labels[i], System.Drawing.SystemColors.ControlLightLight);
                    ChangeLabelBackColor(EDID_cfg_from_EEPROM_labels[i], System.Drawing.SystemColors.ControlLightLight);
                }
            }
            if(data_comparison_flag == true) MessageBox.Show("The data is completely identical!", "Comparison results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else MessageBox.Show("Data doesn't match! Differences are highlighted in color.", "Comparison results", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void toolStripMenuItem_I2C_Read_Click(object sender, EventArgs e)
        {
            Form_MainForm myForm_MainForm = this.Owner as Form_MainForm;
            Form_MainForm.USB_device.DetectDeviceOnBus(Form_MainForm.USB_VID, Form_MainForm.USB_PID);
            if (Form_MainForm.USB_device.DeviceOnBusDetected)
            {

                ClearHighlightBytes();
                label_data_upload_status.Text = "Downloading data 7%";

                Form_MainForm.Read_EDID_from_PTN_EEPROM();
                label_data_upload_status.Text = "Downloading data 97%";

                __pause(300);
                for (int i = 0; i < 256; i++) WriteNewDataToLabel(EDID_cfg_from_EEPROM_labels[i], Form_MainForm.EDID_from_EEPROM_buff[i].ToString("X"));
                label_data_upload_status.Text = "Downloading data 100%";

                myForm_MainForm.toolStripStatusLabel_DeviceErrorMessage.Text = Form_MainForm.ErrorMessage;
            }
            else
            {
                myForm_MainForm.StatesIfDeviceNotFound();
                MessageBox.Show("USB device not found! Check the connection!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
