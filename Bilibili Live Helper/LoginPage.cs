using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilibili_Live_Helper
{
    public partial class LoginPage :MetroFramework.Forms.MetroForm
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //登录
            string userName = this.tb_UserName.Text;
            string password = this.tb_Password.Text;
            string sqlCmd = string.Format("Select * From [User] Where UserName='{0}' and Password='{1}'", userName, password);
            if (DBhelper.GetDataTabel(sqlCmd).Rows.Count>0)
            {
                MessageBox.Show("登录成功");
                ScanPage ScanPageFrm = new ScanPage();
                ScanPageFrm.Show();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterPage RegisterPageFrm = new RegisterPage();
            RegisterPageFrm.Show();
        }
    }
}
