using RSI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Web.Routing;
using RSI.ViewModels;

namespace RSI.Controllers
{
    public class CommentsController : Controller
    {
        // GET: Comments
            public ActionResult Index()
            {
                var model = new CommentViewModel();
                return PartialView("Index", model);
            }

        

            public string SaveComment(string comment)
            {
                SqlConnection connection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=\"\\\\agsdatw01\\users\\morgan.smith\\Documents\\Visual Studio 2015\\Projects\\RSI\\RSI\\App_Data\\aspnet-RSI-20170831032957.mdf\";Initial Catalog=aspnet-RSI-20170831032957;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = string.Format("INSERT INTO CommentTable VALUES('{0}')",comment);
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.ExecuteNonQuery();
                RedirectToAction("Index");
                return "saved";
            }

            public ActionResult ListComments()
             {

                SqlCommand command = new SqlCommand();
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                var commentos = new List<string>();
                string comment = (string)reader["CommentText"];
                commentos.Add(comment);
                }
               reader.Close();
               return View("Index");
               
             }
    }
}