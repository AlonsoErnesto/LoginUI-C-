using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUI
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
     

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();

            this.Hide();
            form1.Visible = true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2GradientPanel1_MouseEnter(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2GradientPanel)sender).ShadowDecoration.Color = Color.DeepPink;
        }

        private void guna2GradientPanel8_MouseLeave(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2GradientPanel)sender).ShadowDecoration.Color = Color.FromArgb(17, 22,32);
        }

        private void guna2GradientPanel1_MouseHover(object sender, EventArgs e)
        {
            ((Guna.UI2.WinForms.Guna2GradientPanel)sender).ShadowDecoration.Color = Color.FromArgb(17, 22, 32);
        }

        private void guna2CirclePictureBox18_Click(object sender, EventArgs e)
        {

        }

    }
}
