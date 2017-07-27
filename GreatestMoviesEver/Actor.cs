using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreatestMoviesEver
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        public string ActorName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }

    }
}