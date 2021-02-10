using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automailapp_MrQuang
{
    public partial class SettingLogin : Form
    {
        public SettingLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingLogin_Load(object sender, EventArgs e)
        {   
            ///distance 1
            string[] distance1= Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistanceLetterInput.Split(' ');
            Distance1_1.Text = distance1[0];
            Distance1_2.Text = distance1[1];
            ///distance 2
            string[] distance2 = Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistanceUsPa.Split(' ');
            Distance2_1.Text = distance2[0];
            Distance2_2.Text = distance2[1];
            ///distance 3
            string[] distance3 = Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistancePaLogin.Split(' ');
            Distance_3_1.Text = distance3[0];
            Distance3_2.Text = distance3[1];

        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistanceLetterInput = Distance1_1.Text + " " + Distance1_2.Text;
            Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistanceUsPa = Distance2_1.Text + " " + Distance2_2.Text;
            Automailapp_MrQuang.Properties.Settings.Default.SettingLogin_DistancePaLogin = Distance_3_1.Text + " " + Distance3_2.Text;
            Automailapp_MrQuang.Properties.Settings.Default.Save();
            this.Close();
        }

        private void ButtonCancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
