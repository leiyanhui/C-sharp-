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
            Database_Connect dataBaseCnn = new Database_Connect();
        }

        /*string username = "leiyh";
        string passwd = "123456".ToString();*/

        /////////////////////////////////////////////////////////按钮区//////////////////////////////////////////////////////////////////////////////////////

        private void BtnSubmit_Click(object sender, EventArgs e)
            
        {
            string user_name = userName.Text;
            string pass_wd = passWord.Text;

            // 数据库获=获取userInfo
            MySql mysql = new MySql("127.0.0.1", "bim", "root", "root");
            string sqlStr = string.Format("select * from user where username= \"{0}\"", user_name);
            string[] userInfo = mysql.Read(sqlStr);
            if (user_name == userInfo[0] && pass_wd == userInfo[1])
            {
                if (MessageBox.Show("登录成功，马上跳转页面......", "Sucessed", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
                if (MessageBox.Show("确定退出登录？", "Question?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else {

                MessageBox.Show("账号或密码错误，请重新核对", "Waring");
            }
 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*string user_name = userName.Text;
            string pass_wd = passWord.Text;
            MySql mysql = new MySql("127.0.0.1", "bim", "root", "root");
            string sqlStr = "select * from user, arg0;";
            Console.WriteLine(sqlStr);
            string [] userInfo = mysql.Read(sqlStr);*/
        }

        /////////////////////////////////////////////////////////标签区//////////////////////////////////////////////////////////////////////////////////////
        private void label1_Click(object sender, EventArgs e)
        {
            //LabelMainName.Text = "Welcome To IASF！";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////文本框区//////////////////////////////////////////////////////////////////////////////////////
        private void username_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            passWord.UseSystemPasswordChar = true;
            Console.Write(sender);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
