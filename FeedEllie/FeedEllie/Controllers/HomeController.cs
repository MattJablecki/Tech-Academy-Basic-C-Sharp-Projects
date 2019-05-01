using FeedEllie.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FeedEllie.Controllers
{
    public class HomeController : Controller
    {

        private readonly string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Feeding; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
       

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Feed(string feedName, string feedDate, string feedTime, string food)
        {

            if (string.IsNullOrEmpty(feedName) || string.IsNullOrEmpty(feedDate) || string.IsNullOrEmpty(feedTime) || string.IsNullOrEmpty(food))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {                
                string queryString = @"INSERT INTO Feed (FeedName, FeedDate, FeedTime, Food) VALUES
                                      (@FeedName, @FeedDate, @FeedTime, @Food)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FeedName", SqlDbType.VarChar);
                    command.Parameters.Add("@FeedDate", SqlDbType.Date);
                    command.Parameters.Add("@FeedTime", SqlDbType.Time);
                    command.Parameters.Add("@Food", SqlDbType.VarChar);                   

                    command.Parameters["@FeedName"].Value = feedName;
                    command.Parameters["@FeedDate"].Value = feedDate;
                    command.Parameters["@FeedTime"].Value = feedTime;
                    command.Parameters["@Food"].Value = food;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                    return View("Fed");
            }
        }
        [HttpPost]
        public ActionResult Nap(string napName, string napDate, string startTime, string endTime)
        {
            if (string.IsNullOrEmpty(napName) || string.IsNullOrEmpty(napDate) || string.IsNullOrEmpty(startTime) || string.IsNullOrEmpty(endTime)
)
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                
                string queryString = @"INSERT INTO Nap (NapName, NapDate, StartTime, EndTime) VALUES
                                       (@NapName, @NapDate, @StartTime, @EndTime)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@NapName", SqlDbType.VarChar);
                    command.Parameters.Add("@NapDate", SqlDbType.Date);
                    command.Parameters.Add("@StartTime", SqlDbType.Time);
                    command.Parameters.Add("@EndTime", SqlDbType.Time);
                    

                    command.Parameters["@NapName"].Value = napName;
                    command.Parameters["@NapDate"].Value = napDate;
                    command.Parameters["@StartTime"].Value = startTime;
                    command.Parameters["@EndTime"].Value = endTime;
                    

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                return View("Nap");
            }
        }
        public ActionResult AdminFeed()
        {
            string queryString = @"SELECT FeedName, FeedDate, FeedTime, Food from Feed"; 
            List<Feedings> feedings = new List<Feedings>();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var feeding = new Feedings();
                    feeding.FeedName = reader["FeedName"].ToString();
                    feeding.FeedDate = Convert.ToDateTime(reader["FeedDate"]);
                    feeding.FeedTime = reader["FeedTime"].ToString();
                    feeding.Food = reader["Food"].ToString();
                    feedings.Add(feeding);

                }
            }
                return View("AdminFeed");
        }
        public ActionResult AdminNap()
        {
            string queryString = @"SELECT NapName, NapDate, StartTime, EndTime from Nap";
            List<Naps> naps = new List<Naps>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var nap = new Naps();
                    nap.NapName = reader["NapName"].ToString();
                    nap.NapDate = Convert.ToDateTime(reader["NapDate"]);
                    nap.StartTime = Convert.ToDateTime(reader["StartTime"]);
                    nap.StartTime = Convert.ToDateTime(reader["StartTime"]);
                    naps.Add(nap);

                }
            }
            return View("AdminNap");
        }
    }
}