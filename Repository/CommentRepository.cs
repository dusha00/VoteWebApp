using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using VoteWebApp.Models;
using Dapper;

namespace VoteWebApp.Repository
{
    public class CommentRepository
    {
        private string connectionString;
        public CommentRepository()
        {
            SQLiteConnectionStringBuilder sb = new SQLiteConnectionStringBuilder();
            sb.DataSource = "sqllite/Vote.db";
            connectionString = sb.ToString();
        }
        private SQLiteConnection Connection
        {
            get
            {
                return new SQLiteConnection(connectionString);
            }
        }
        public void Add(CommentModel comment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("INSERT INTO COMMENT (TOPICID,CONTENT,CreateTime) VALUES(@TOPICID,@CONTENT,@CreateTime)", comment);
            }
        }
        public IEnumerable<CommentModel> RangeQuery(DateTime searchDate, int pageIndex, int pageSize)
        {
            using (IDbConnection dbConnection = Connection)
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("pageIndex", pageIndex);
                parameters.Add("pageSize", pageSize);
                parameters.Add("createTime", searchDate);
                var list = dbConnection.Query<CommentModel>("select * from Comment where createTime>@CreateTime limit (@pageIndex-1)*@pageSize,@pageSize", parameters);
                return list;
            }
        }
    }
}
