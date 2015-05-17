namespace FiftyCuatro.Gomofoto.Migrations
{
    using FiftyCuatro.Gomofoto.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FiftyCuatro.Gomofoto.Models.GomofotoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FiftyCuatro.Gomofoto.Models.GomofotoContext context)
        {
            var users = new List<User>
            {
                new User { FirstName = "Phillip", LastName="Gomez", Username="fillet54", EmailAddress="gomez.phillip@gmail.com" }
            };
            users.ForEach(u => context.Users.AddOrUpdate(u));
            context.SaveChanges();

            var albums = new List<Album>
            { 
                new Album { Name="First Album", Description="Album 1 Desc", User=users[0]},
                new Album { Name="Second Album", Description="Album 2 Desc", User=users[0]}

            };
            albums.ForEach(a => context.Albums.AddOrUpdate(a));
            context.SaveChanges();

            var photos = new List<Photo>
            {
                new Photo { Title="Picture1", Description="Picture 1 Desc", Url="sample_pic.png", Album=albums[0] },
                new Photo { Title="Picture2", Description="Picture 2 Desc", Url="sample_pic.png", Album=albums[0] },
                new Photo { Title="Picture3", Description="Picture 3 Desc", Url="sample_pic.png", Album=albums[0] },
                new Photo { Title="Picture4", Description="Picture 4 Desc", Url="sample_pic.png", Album=albums[1] },
                new Photo { Title="Picture5", Description="Picture 5 Desc", Url="sample_pic.png", Album=albums[1] },
            };
            photos.ForEach(p => context.Photos.AddOrUpdate(p));
            context.SaveChanges();
        }
    }
}
