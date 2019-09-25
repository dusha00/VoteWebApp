using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using VoteWebApp.Models;

namespace VoteWebApp.Common
{
    public class DapperHelper
    {
        public static void test()
        {
            SQLiteConnectionStringBuilder sb = new SQLiteConnectionStringBuilder();
            sb.DataSource = "sqllite/test.db";
            SQLiteConnection connection = new SQLiteConnection(sb.ToString());
            connection.Open();
            string sql = "select * from company";
            var res = connection.Query<Company>(sql);
            connection.Close();
        }
    }
}
