using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using CovidData.Models;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Mvc;

namespace CovidData.Controllers
{
    public class BasicDataController : ApiController
    {
        public HttpResponseMessage Get()
        {
            DataTable table = new DataTable();
            string query = @"select * from daily_cases";
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["dailycases"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }
        public string Post(BasicData day)
        {
            try
            {
                DataTable table = new DataTable();
                string query = @"insert into daily_cases values('" + day.dailyconfirmed + @"')";
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["dailycases"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "Added Successfully";
            }
            catch (Exception)
            {
                return "failwd to add";
            }
        }
    }
}