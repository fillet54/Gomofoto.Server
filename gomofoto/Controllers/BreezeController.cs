using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Breeze.WebApi2;
using System.Web.Http;
using FiftyCuatro.Gomofoto.Models;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using System.Web.Http.Cors;

namespace FiftyCuatro.Gomofoto.Controllers
{
    [BreezeController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BreezeController : ApiController
    {
        private readonly IRepository _Repo;

        public BreezeController(IRepository repo)
        {
            _Repo = repo;
        }

        [HttpGet]
        public string Metadata()
        {
            return _Repo.Metadata;
        }

        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _Repo.SaveChanges(saveBundle);
        }

        [HttpGet]
        public IQueryable<User> Users()
        {
            return _Repo.Users();
        }

        [HttpGet]
        public IQueryable<Album> Albums()
        {
            return _Repo.Albums();
        }

        [HttpGet]
        public IQueryable<Photo> Photos()
        {
            return _Repo.Photos();
        }
    }
}