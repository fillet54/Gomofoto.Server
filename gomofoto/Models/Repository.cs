using Breeze.ContextProvider.EF6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiftyCuatro.Gomofoto.Models
{
    public class Repository : IRepository
    {
        private readonly EFContextProvider<GomofotoContext> _Provider = new EFContextProvider<GomofotoContext>();

        public string Metadata
        {
            get { return _Provider.Metadata();  }
        }

        public Breeze.ContextProvider.SaveResult SaveChanges(Newtonsoft.Json.Linq.JObject saveBundle)
        {
            return _Provider.SaveChanges(saveBundle);
        }

        public IQueryable<User> Users()
        {
            return _Provider.Context.Users;
        }

        public IQueryable<Album> Albums()
        {
            return _Provider.Context.Albums;
        }

        public IQueryable<Photo> Photos()
        {
            return _Provider.Context.Photos;
        }
    }
}