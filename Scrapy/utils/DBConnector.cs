using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrapy.utils
{
    class DBConnector
    {
        private static OdbcConnection odbcConnection = new OdbcConnection(@"Dsn=MysqlODBC;uid=root");
        public static void Excute(string command)
        {
            if (odbcConnection.State == ConnectionState.Closed)
            {
                odbcConnection.Open();
            }
            Logger.Log("[DEBUG] " + command);
            OdbcCommand cmd = new OdbcCommand(command, odbcConnection);
            int res = cmd.ExecuteNonQuery();
        }
        public static List<String> ShowTables()
        {
            List<String> Tablenames = new List<String>();
            if (odbcConnection.State == ConnectionState.Closed)
            {
                odbcConnection.Open();
            }
            string command = "show tables";
            Logger.Log("[DEBUG] " + command);
            OdbcCommand cmd = new OdbcCommand(command, odbcConnection);
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Tablenames.Add(reader.GetString(0));
            }
            return Tablenames;
        }
        public static List<string[]> SelectAllFromTable(string tablename)
        {
            List<string[]> data = new List<string[]>();
            if (odbcConnection.State == ConnectionState.Closed)
            {
                odbcConnection.Open();
            }
            string command = "select * from `" + tablename + "`;";
            Logger.Log("[DEBUG] " + command);
            OdbcCommand cmd = new OdbcCommand(command, odbcConnection);
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data.Add(new string[] {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                });
            }
            return data;
        }
        public static List<string[]> Select(string tablename, string filter, string keyword)
        {
            List<string[]> data = new List<string[]>();
            string field = "";
            if (filter == "公司名称")
            {
                field = "CompanyName";
            }else if (filter=="工作地"){
                field = "WorkPlace";
            }
            if (odbcConnection.State == ConnectionState.Closed)
            {
                odbcConnection.Open();
            }
            string command = "select * from `" + tablename + "`"+" where "+ field + "='"+keyword+"';";
            Logger.Log("[DEBUG] " + command);
            OdbcCommand cmd = new OdbcCommand(command, odbcConnection);
            OdbcDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                data.Add(new string[] {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                });
            }
            return data;
        }
        public static void DropTable(string tablename)
        {
            if (odbcConnection.State == ConnectionState.Closed)
            {
                odbcConnection.Open();
            }
            string command = "drop table `" + tablename + "`;";
            Logger.Log("[DEBUG] "+command);
            OdbcCommand cmd = new OdbcCommand(command, odbcConnection);
            int res = cmd.ExecuteNonQuery();
        }
    }
}
