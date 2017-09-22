using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;


namespace RSI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Comments");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Comments(string comment)
        {
            SqlConnection connection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=\"\\\\agsdatw01\\users\\morgan.smith\\Documents\\Visual Studio 2015\\Projects\\RSI\\RSI\\App_Data\\aspnet - RSI - 20170831032957.mdf\";Initial Catalog=aspnet-RSI-20170831032957;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = string.Format("INSERT INTO CommentText VALUES({0})", comment);
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.ExecuteNonQuery();
            return View("Save");
        }
    }
}