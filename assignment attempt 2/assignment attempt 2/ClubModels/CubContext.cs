using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace assignment_attempt_2.ClubModels
{
    public class CubContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<ClubEvent> ClubEvents { get; set; }

        public CubContext() :base ("DefaultConnection")
        {
            
        }

        public static CubContext create()
        {
            return new CubContext();
        }
              
    }
}