using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{

    public class EfContext:DbContext
    {
        public EfContext() : base("ShopConnection")
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Music> Musics { get; set; }
        public virtual DbSet<Genre> Genres{ get; set; }
        public virtual DbSet<Authors> Authors{ get; set; }
    }
}
