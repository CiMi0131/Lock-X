using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lock_X
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        bool izinVer = false;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                izinVer = true;
                this.Close();
            }
            if (e.KeyCode == Keys.F2)
            {
                Settings1.Default.Reset();
            }


            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == labelSifre.Text)
                {
                    izinVer = true;
                    this.Close();
                }
                else
                {
                    label3.Text = ("Şifre Yanlış!");

                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Text == labelSifre.Text)
                {
                    label5.Show();
                    textBox3.Show();
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labelSifre.Text = textBox3.Text;
                Settings1.Default.SavedPassword = labelSifre.Text;
                Settings1.Default.Save();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Hide();
            textBox3.Hide();
            labelSifre.Text = Settings1.Default.SavedPassword;
        }
    }
}
