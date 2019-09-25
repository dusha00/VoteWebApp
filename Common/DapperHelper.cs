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
        public static IEnumerable<T> Query<T>(string sql)
        {
            SQLiteConnectionStringBuilder sb = new SQLiteConnectionStringBuilder();
            sb.DataSource = "sqllite/test.db";
            SQLiteConnection connection = new SQLiteConnection(sb.ToString());
            connection.Open();
            var res = connection.Query<T>(sql);
            connection.Close();
            return res;
        }
    }
}
