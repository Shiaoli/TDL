﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TDL.Models
{
    public class TDLEntities:DbContext
    {
        public TDLEntities() : base("TDLEntities")
        {

        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}