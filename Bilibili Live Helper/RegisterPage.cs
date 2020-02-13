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
    public partial class RegisterPage : MetroFramework.Forms.MetroForm
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //注册
            string userName = this.tb_UserName.Text;
            string password = this.tb_Password.Text;
            string password1 = this.tb_Password1.Text;

            if (userName!=null&&password!=null&&password1!=null&&password==password1)
            {
                string sqlCmd = string.Format("Insert [User] Values ('{0}','{1}','{2}') ", userName, password,DateTime.Now.Date);
                if (DBhelper.ExecuteSqlCommand(sqlCmd))
                {
                    //注册成功
                    MessageBox.Show("注册成功");
                }
                else
                {
                    //注册失败
                    MessageBox.Show("注册失败");
                }
            }
            else
            {
                MessageBox.Show("请好好检查哦");
            }


        }
    }
}
