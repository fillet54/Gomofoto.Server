﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FiftyCuatro.Gomofoto.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}