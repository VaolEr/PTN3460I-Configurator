using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTN3460I_Configurator
{
    public partial class Form_ControlPanelForm : Form
    {
        public byte[] LED_panel_cfg_array = {1, 2, 3};

        public bool LED_panel_ON = false;
        public bool BackLight_ON = false;
        public byte PWM_step_count = 0;

        public Form_ControlPanelForm()
        {
            Form_MainForm myForm_MainForm = this.Owner as Form_MainForm;

            LED_panel_cfg_array = Form_MainForm.Usb_GET_LED_panel_cfg();
            if (LED_panel_cfg_array[2] > 10) LED_panel_cfg_array[2] = 5;
            PWM_step_count = LED_panel_cfg_array[2];
            InitializeComponent();

            Check_States(LED_panel_cfg_array[0], LED_panel_cfg_array[1]);

            Check_PWM(LED_panel_cfg_array[2]);

            //label4.Text = LED_panel_cfg_array[0].ToString("X");
            //label5.Text = LED_panel_cfg_array[1].ToString("X");
            //label6.Text = LED_panel_cfg_array[2].ToString("X");
        }



        
        
        private void Check_PWM(byte PWM_step_count)
        {
            switch (PWM_step_count)
            {
                case 0:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_OFF;
                    break;
                case 1:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_10;
                    break;
                case 2:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_20;
                    break;
                case 3:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_30;
                    break;
                case 4:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_40;
                    break;
                case 5:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_50;
                    break;
                case 6:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_60;
                    break;
                case 7:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_70;
                    break;
                case 8:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_80;
                    break;
                case 9:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_90;
                    break;
                case 10:
                    pictureBox_BackLight_PWM.Image = global::PTN3460I_Configurator.Properties.Resources.PWM_100;
                    break;
            }
            label6.Text = PWM_step_count.ToString() +"0%";
        }

        private void Check_States(byte LED_panel, byte BackLight)
        {
            if (LED_panel == 0xAA) { 
                LED_panel_ON = true;
                pictureBox_LED_Panel.Image = global::PTN3460I_Configurator.Properties.Resources.LED_on;
                label4.Text = "ON";
            }
            if (LED_panel == 0x55) { 
                LED_panel_ON = false;
                pictureBox_LED_Panel.Image = global::PTN3460I_Configurator.Properties.Resources.LED_off;
                label4.Text = "OFF";
            }

            if (BackLight == 0xAA) {
                BackLight_ON = true;
                pictureBox_BackLight.Image = global::PTN3460I_Configurator.Properties.Resources.BackLight_on;
                label5.Text = "ON";
            }
            if (BackLight == 0x55) {
                BackLight_ON = false;
                pictureBox_BackLight.Image = global::PTN3460I_Configurator.Properties.Resources.BackLight_off;
                label5.Text = "OFF";
            }
        }
        private void button_LED_Panel_On_Off_Click(object sender, EventArgs e)
        {
            LED_panel_ON = !LED_panel_ON;
            if (LED_panel_ON)
            {
                pictureBox_LED_Panel.Image = global::PTN3460I_Configurator.Properties.Resources.LED_on;
                LED_panel_cfg_array[0] = 0xAA;
            }
            else
            {
                pictureBox_LED_Panel.Image = global::PTN3460I_Configurator.Properties.Resources.LED_off;
                LED_panel_cfg_array[0] = 0x55;
            }
            Form_MainForm.Usb_SET_LED_panel_cfg(LED_panel_cfg_array);
            Check_States(LED_panel_cfg_array[0], LED_panel_cfg_array[1]);

        }

        private void button_BL_On_Off_Click(object sender, EventArgs e)
        {
            BackLight_ON = !BackLight_ON;
            if (BackLight_ON)
            {
                LED_panel_cfg_array[1] = 0xAA;
                pictureBox_BackLight.Image = global::PTN3460I_Configurator.Properties.Resources.BackLight_on;
                Check_PWM(LED_panel_cfg_array[2]);
            }
            else
            {
                LED_panel_cfg_array[1] = 0x55;
                pictureBox_BackLight.Image = global::PTN3460I_Configurator.Properties.Resources.BackLight_off;
            }
            Form_MainForm.Usb_SET_LED_panel_cfg(LED_panel_cfg_array);
            Check_States(LED_panel_cfg_array[0], LED_panel_cfg_array[1]);
        }

        private void button_BL_PWM_Up_Click(object sender, EventArgs e)
        {
            if (PWM_step_count < 10) PWM_step_count++;
            LED_panel_cfg_array[2] = PWM_step_count;
            Check_PWM(LED_panel_cfg_array[2]);
            Form_MainForm.Usb_SET_LED_panel_cfg(LED_panel_cfg_array);
        }

        private void button_BL_PWM_Down_Click(object sender, EventArgs e)
        {
            if (PWM_step_count > 0) PWM_step_count--;
            LED_panel_cfg_array[2] = PWM_step_count;
            Check_PWM(LED_panel_cfg_array[2]);
            Form_MainForm.Usb_SET_LED_panel_cfg(LED_panel_cfg_array);
        }

        private void Form_ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    Hide();
                    Form_MainForm myForm_MainForm = this.Owner as Form_MainForm;
                    Form_MainForm.control_panel_is_open = false;
                    myForm_MainForm.Show();
                }
        }
    }
}
