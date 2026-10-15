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
    }
}
