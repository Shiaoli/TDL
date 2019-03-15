using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TDL.Models;
using System.Data.Entity;

namespace TDL.DAL
{
    public class TDLContext:DbContext
    {
        public TDLContext() : base("TDLContext")
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}