using RSI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Web.Routing;

namespace RSI.Controllers
{
    public class CommentsController : Controller
    {
        // GET: Comments

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";
            return Content(String.Format("pageIndex={0}&sortby={1)",pageIndex, sortby));
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
            return"Homepage";
        }
    }
}