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
            //office 2007 or 2013
            string strCon = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0;'";

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
                        Console.WriteLine(ds.Tables[0].Rows[i]["Name"].ToString());//注意：列名不区分大小写

                    }
                }
            }
            return true;
        }
        public bool OledbWrite(string filePath)
        {
            //需要安装AccessDatabaseEngine
            string strCon = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0 Xml;'";
            using (OleDbConnection ole_conn = new OleDbConnection(strCon))
            {
                ole_conn.Open();
                using (OleDbCommand ole_cmd = ole_conn.CreateCommand())
                {
                    ole_cmd.CommandText = "insert into [Sheet1$](col1,name) values('Excel','SUN')";
                    ole_cmd.ExecuteNonQuery();//执行SQL语句
                    Console.WriteLine("数据插入成功......");
                }
            }
            return true;
        }
    }
}
