using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GreatestMoviesEver.Models
{
    public class GreatestMoviesEverContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GreatestMoviesEverContext() : base("name=GreatestMoviesEverContext")
        {
        }

        public System.Data.Entity.DbSet<GreatestMoviesEver.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<GreatestMoviesEver.Actor> Actors { get; set; }

        public System.Data.Entity.DbSet<GreatestMoviesEver.Movie> Movies { get; set; }
    }
}
