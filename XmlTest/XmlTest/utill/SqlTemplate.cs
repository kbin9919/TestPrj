using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XmlTest.utill
{
    public class SqlTemplate
    {
        private string connStr = "Server=127.0.0.1; Database=tempdb; User Id=sa; Password=1234;";
        //public string connStr { get; set; }
        public SqlTemplate() { }

        public DataTable Select(string sql)
        {
            DataTable dt = new DataTable();
            using var executor = new CustomSqlConnection.Builder()
                                              .SetConnectionString(connStr)
                                              .SetCommand(sql)
                                              .Build();


            return executor.Fill();
        }

        public DataTable Select(string sql, int timeout)
        {
            DataTable dt = new DataTable();

            using var executor = new CustomSqlConnection.Builder()
                                              .SetConnectionString(connStr)
                                              .SetCommand(sql)
                                              .SetTimeout(timeout)
                                              .Build();

            return executor.Fill();
        }

        public int Execute(string sql, bool isTran = false)
        {
            using var executor = new CustomSqlConnection.Builder()
                                              .SetConnectionString(connStr)
                                              .SetCommand(sql)
                                              .UseTransaction(isTran)
                                              .Build();
            try
            {
                int result = executor.ExecuteNonQuery();
                executor.Commit();

                return result;
            }
            catch
            {
                executor.Rollback();
                throw;
            }
        }

        public int Execute(string sql, int timeout, bool isTran = false)
        {
            using var executor = new CustomSqlConnection.Builder()
                                              .SetConnectionString(connStr)
                                              .SetCommand(sql)
                                              .SetTimeout(timeout)
                                              .UseTransaction(isTran)
                                              .Build();

            try
            {
                int result = executor.ExecuteNonQuery();
                executor.Commit();

                return result;
            }
            catch
            {
                executor.Rollback();
                throw;
            }
        }

        public int Execute(List<string> sqls, bool isTran = false)
        {
            using var executor = new CustomSqlConnection.Builder()
                                              .SetConnectionString(connStr)
                                              .SetCommand(sqls)
                                              .UseTransaction(isTran)
                                              .Build();
            try
            {
                int result = executor.ExecuteNonQuery();
                executor.Commit();

                return result;
            }
            catch
            {
                executor.Rollback();
                throw;
            }
        }

        public int Execute(List<string> sqls, int timeout, bool isTran = false)
        {
            using var executor = new CustomSqlConnection.Builder()
                                              .SetConnectionString(connStr)
                                              .SetCommand(sqls)
                                              .SetTimeout(timeout)
                                              .UseTransaction(isTran)
                                              .Build();

            try
            {
                int result = executor.ExecuteNonQuery();
                executor.Commit();

                return result;
            }
            catch
            {
                executor.Rollback();
                throw;
            }
        }
        
    }
}
