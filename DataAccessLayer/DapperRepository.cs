using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using ClothingStore.Core;

namespace DataAccessLayer
{
    public class DapperRepository : IRepository<Clothing>
    {
        private string _connectionString = "Server=DESKTOP-UFS9MSM\\SQLEXPRESS01; Database=clothing_store; Trusted_Connection=True;";
        public void Add(Clothing item)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO Clothes (Name, Category, Size, Price) VALUES (@Name, @Category, @Size, @Price)";
                db.Execute(sql, item);
            }
        }
        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Clothes WHERE ID = @id";
                db.Execute(sql, new { id });
            }
        }
        public List<Clothing> ReadAll()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Clothes";
                return db.Query<Clothing>(sql).ToList();
            }
        }
        public Clothing ReadById(int id)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Clothes WHERE ID = @id";
                return db.QueryFirstOrDefault<Clothing>(sql, new { id });
            }
        }
        public void Update(Clothing item)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sql = "UPDATE Clothes SET Name = @Name, Category = @Category, Size = @Size, Price = @Price WHERE ID = @ID";
                db.Execute(sql, item);
            }
        }
    }
}
