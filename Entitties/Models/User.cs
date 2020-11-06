using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entitties.Models
{
    public class User
    {
        [Key]
        [Column("UserID")]
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Image { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<TaskUser> TaskUsers { get; set; }

    }
}
