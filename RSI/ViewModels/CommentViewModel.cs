using RSI.Models;
using RSI.Views.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RSI.ViewModels
{
    public class CommentViewModel
    {
        public List<Comment> Comments{ get; set; }
        public List<Commenter> Commenters { get; set; }
    }

}