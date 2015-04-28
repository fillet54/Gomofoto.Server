using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiftyCuatro.Gomofoto.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public User()
        {
            Albums = new List<Album>();
        }
    }
}