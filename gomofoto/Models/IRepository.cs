using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiftyCuatro.Gomofoto.Models
{
    public interface IRepository
    {
        string Metadata { get; }
        SaveResult SaveChanges(JObject saveBundle);

        IQueryable<User> Users();
        IQueryable<Album> Albums();
        IQueryable<Photo> Photos();
    }
}
