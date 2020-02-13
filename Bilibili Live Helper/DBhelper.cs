using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bilibili_Live_Helper
{
    public static class DBhelper
    {
        public static string conStr = "Data Source=180.76.233.143;Initial Catalog=BiliBiliDB;Persist Security Info=True;User ID=sa;Password=xiongjie520";
        public static SqlConnection SqlCon = null;
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public static void InitConnection()
        {
            if (SqlCon == null)
                SqlCon = new SqlConnection(conStr);
            if (SqlCon.State == ConnectionState.Closed)
                SqlCon.Open();
            if (SqlCon.State == ConnectionState.Broken)
            {
                SqlCon.Close();
                SqlCon.Open();
            }
        }
        /// <summary>
        /// 查询数据表
        /// </summary>
        /// <param name="cmdStr"></param>
        /// <returns></returns>
        public static DataTable GetDataTabel(string cmdStr)
        {
            InitConnection();
            DataSet dt = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmdStr, SqlCon);
            da.Fill(dt);
            SqlCon.Close();
            return dt.Tables[0];
        }
        /// <summary>
        /// 执行SQL命令
        /// </summary>
        /// <param name="sqlCmd"></param>
        /// <returns></returns>
        public static bool ExecuteSqlCommand(string sqlCmd)
        {
            InitConnection();
            SqlCommand SqlCmd = new SqlCommand(sqlCmd, SqlCon);
            int r = SqlCmd.ExecuteNonQuery();
            SqlCon.Close();
            return r > 0;
        }
    }
}
