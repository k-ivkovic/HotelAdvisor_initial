using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelAdvisor.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int HotelId { get; set; }

   //     public string UserId { get; set; }

        public string Text { get; set; }

        public string Title { get; set; }

        public decimal Rating { get; set; }

        public DateTime DateAdded { get; set; }

     //   public virtual ApplicationUser User { get; set; }

   //     public virtual Hotel Hotel { get; set; }
    }
}