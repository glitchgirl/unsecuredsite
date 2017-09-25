using RSI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RSI.Controllers
{
    public class SaveCommentsController : Controller
    {
        // GET: SaveComments
        public ActionResult Index()
        {
            var model = new SafeCommentViewModel();
            //model.SafeComments = GetComments();
            return View(model);
        }
      

        [HttpPost, ValidateInput(false)]
        public void SaveComment(string comment)
        {
            //SqlConnection connection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=\"\\\\agsdatw01\\users\\morgan.smith\\Documents\\Visual Studio 2015\\Projects\\RSI\\RSI\\App_Data\\aspnet-RSI-20170831032957.mdf\";Initial Catalog=aspnet-RSI-20170831032957;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            //connection.Open();

            //SqlCommand command = new SqlCommand();
            //command.CommandText = string.Format("INSERT INTO CommentTable VALUES('{0}')", comment);
            //command.CommandType = CommandType.Text;
            //command.Connection = connection;
            //command.ExecuteNonQuery();
            //connection.Close();

            //Response.Redirect("Index");
            //RedirectToAction("Index");
        }

        //public List<Comment> GetComments()
        //{
        //    var comments = new List<Comment>();

        //    SqlConnection connection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=\"\\\\agsdatw01\\users\\morgan.smith\\Documents\\Visual Studio 2015\\Projects\\RSI\\RSI\\App_Data\\aspnet-RSI-20170831032957.mdf\";Initial Catalog=aspnet-RSI-20170831032957;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        //    connection.Open();

        //    SqlCommand command = new SqlCommand("SELECT CommentText FROM CommentTable", connection);

        //    using (SqlDataReader rdr = command.ExecuteReader())
        //    {
        //        while (rdr.Read())
        //        {
        //            comments.Add(new Comment { CommentText = (string)rdr["CommentText"] });
        //        }
        //    }

        //    connection.Close();
        //    return comments;
        //}
    }
}
