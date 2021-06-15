using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace APIProject
{
    class DapperConnection
    {
        string connectionString = "Server=SAILS-TDM06;Database=CovidData;User ID=SAILS-TDM06;Password=sails@123";
        private IDbConnection connected { get; set; }
        public DapperConnection()
        {
            connected = new SqlConnection(connectionString);
        }

        public List<TableCasesTime> GetAllCasesData()
        {
            return this.connected.Query<TableCasesTime>("SELECT * from cases_time_series").ToList();
        }
        public void AddCasesData(TableCasesTime cases)
        {
            string sql3 = "INSERT INTO cases_time_series(dailyconfirmed,dailydeceased,dailyrecovered,date,dateymd,totalconfirmed,totaldeceased,totalrecovered)VALUES(@dailyconfirmed,@dailydeceased,@dailyrecovered,@date,@dateymd,@totalconfirmed,@totaldeceased,@totalrecovered)";
            connected.Execute(sql3, cases);
        }
    }
}
