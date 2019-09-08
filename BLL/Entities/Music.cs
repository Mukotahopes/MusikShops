using BLL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    [Table("tblMusic")]
    public class Music
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual Genre GenrOf { get; set; }
        public virtual Authors Authors { get; set; }
    }
}
