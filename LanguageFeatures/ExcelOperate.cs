using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public class ExcelOperate
    {
        public bool OledbRead(string filePath)
        {
            //office 2003
            //String strCon = "Provider=Microsoft..OLEDB.4.0;" + "Data Source=" + filePath + ";" + "Extended Properties='Excel 8.0;HDR=Yes;IMEX=2'";
            //IMEX：只有是0才能成功更新，1或2都有错误提示，操作必须使用一个可更新的查询，2也有奇怪？
            //当 IMEX=0 时为“写出模式”，这个模式开启的 Excel 档案只能用来做“写入”用途。
　　          //当 IMEX=1 时为“写入模式”，这个模式开启的 Excel 档案只能用来做“读取”用途。
　　          //当 IMEX=2 时为“混合模式”，这个模式开启的 Excel 档案可同时支援“读取”与“写入”用途。
            //office 2007 or 2013
            //string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=2'";
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath
                + ";Extended Properties='Excel 12.0;'";
            //实例化一个Oledbconnection类(实现了IDisposable,要using)
            using (OleDbConnection ole_conn = new OleDbConnection(strCon))
            {
                ole_conn.Open();
                using (OleDbCommand ole_cmd = ole_conn.CreateCommand())
                {
                    //类似SQL的查询语句这个[Sheet1$对应Excel文件中的一个工作表]
                    ole_cmd.CommandText = "select * from [Sheet1$]";
                    OleDbDataAdapter adapter = new OleDbDataAdapter(ole_cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "Sheet1");
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        Console.WriteLine(ds.Tables[0].Rows[i]["col1"].ToString());//注意：列名不区分大小写

                    }
                }
            }
            return true;
        }
        public bool OledbWrite(string filePath)
        {
            string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath
                + ";Extended Properties='Excel 12.0;'";
            using (OleDbConnection ole_conn = new OleDbConnection(strCon))
            {
                ole_conn.Open();
                using (OleDbCommand ole_cmd = ole_conn.CreateCommand())
                {
                    ole_cmd.CommandText = "insert into [Sheet1$](Col1,col2)values('DJ001','点击科技')";
                    ole_cmd.ExecuteNonQuery();//执行SQL语句
                    Console.WriteLine("数据插入成功......");
                }
            }
            return true;
        }
    }
}
