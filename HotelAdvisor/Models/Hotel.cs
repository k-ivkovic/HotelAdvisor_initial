using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelAdvisor.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public int HouseNumber { get; set; }

        public string City { get; set; }

        public string Image { get; set; }

        public bool IsActive { get; set; }

    //    public virtual ICollection<Comment> Comments { get; set; }

    }
}