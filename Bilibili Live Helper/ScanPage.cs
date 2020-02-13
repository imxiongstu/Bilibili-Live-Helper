using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
namespace Bilibili_Live_Helper
{
    public partial class ScanPage : MetroFramework.Forms.MetroForm
    {
        public ScanPage()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string host = "https://passport.bilibili.com/qrcode/getLoginInfo";
            string postData = "oauthKey=" + oauthKey + "&gourl=https://passport.bilibili.com/account/security";
            JObject scanEndText = JObject.Parse(BiliHelper.BiliPostRequest(host, postData, out CookieContainer myCookieContainer));
            //判断扫码是否成功
            if (scanEndText["status"].ToString() == "True")
            {
                MessageBox.Show("扫码成功");
                BiliHelper.Data.BiliCookie = myCookieContainer;

                //进入工具主页
                ToolsPage toolsPageFrm = new ToolsPage();
                toolsPageFrm.Show();
                this.Hide();
                this.timer1.Stop();
            }
        }
        string oauthKey;
        private void LoginPage_Load(object sender, EventArgs e)
        {
            //获取本地已经登录过的账号
            string savaPath = System.IO.Directory.GetCurrentDirectory() + @"\账号库\";
            DirectoryInfo Dir = new DirectoryInfo(savaPath);
            if (Directory.Exists(savaPath))
            {
                this.metroComboBox1.DataSource = Dir.GetFiles();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //获取二维码登录
            string host = "https://passport.bilibili.com/qrcode/getLoginUrl";
            string toQRcodeApi = "http://qr.topscan.com/api.php?text=";
            JObject QRcodeUrl = JObject.Parse(BiliHelper.BiliGetRequest(host));
            oauthKey = QRcodeUrl["data"]["oauthKey"].ToString();
            this.pictureBox1.ImageLocation = toQRcodeApi + QRcodeUrl["data"]["url"];
            this.timer1.Start();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //选择账号登录
            string savaPath = System.IO.Directory.GetCurrentDirectory() + @"\账号库\";
            string user = savaPath + this.metroComboBox1.Text;
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(user, FileMode.Open))
            {
                CookieContainer myCookieContainer = (CookieContainer)bf.Deserialize(fs);//反序列Cookie数据
                BiliHelper.Data.BiliCookie = myCookieContainer;//设置为全局Cookie
            }
            ToolsPage ToolsPageFrm = new ToolsPage();
            ToolsPageFrm.Show();
        }
    }
}
