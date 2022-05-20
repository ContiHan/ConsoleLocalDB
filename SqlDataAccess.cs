using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ConsoleLocalDB
{
    internal class SqlDataAccess
    {
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danie\OneDrive\Dokumenty\C#\ConsoleLocalDB\Database.mdf;Integrated Security=True";
        public List<SqlData> GetSqlDataByName(string name)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<SqlData>($"SELECT * FROM dbo.[Table] WHERE Name = '{name}'").ToList();
            }
        }

        public List<SqlData> GetAllSqlData()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                return connection.Query<SqlData>($"SELECT * FROM dbo.[Table]").ToList();
            }
        }

        public void AddToSqlDb(string name, byte age)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Query<SqlData>($"INSERT INTO dbo.[Table](Name, Age) VALUES('{name}', {age})");
            }
        }
    }
 }
