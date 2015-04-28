using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiftyCuatro.Gomofoto.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Photo> Photos { get; set; }

        public Album()
        {
            Photos = new List<Photo>();
        }
    }
}
