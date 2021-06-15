using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ListData
{
    public class DapperConnection
    {
        string connectionString = "Server=SAILS-TDM06;Database=CovidData;User ID=SAILS-TDM06;Password=sails@123";
        private IDbConnection conn { get; set; }
        public DapperConnection()
        {
            conn = new SqlConnection(connectionString);
        }
        public void AddEmployee(travel_history employee)
        {
            conn.Execute("MyData", employee, commandType: CommandType.StoredProcedure);
        }
    }
}
