using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPT_show
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }
        public new event EventHandler DoubleClick;
        bool isClicked = false;
        private void BtnSubmit_Click(object sender, EventArgs e)
            
        {

            if (isClicked)
            {
                btn();
                this.isClicked = false;
            }
            else {
                LabelMainName.Text = "Change Color Now";
                this.isClicked = true;
            }

        }
        private void btn() {
            System.Threading.Thread.Sleep(3000);
            LabelMainName.ForeColor = System.Drawing.Color.Red;
            LabelMainName.Text = "Welcome To IASF！";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            LabelMainName.Text = "Welcome To IASF！";
        }


    }
}
