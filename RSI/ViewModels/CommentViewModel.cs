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
        public Comments Comment{ get; set; }
        public List<Commenters> Commenters { get; set; }
    }

}