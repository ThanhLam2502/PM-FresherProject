using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entitties.Models
{
    public class User
    {
        public User()
        {
            Tasks = new HashSet<TaskProject>();
        }

        [Key]
        [Column("UserID")]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }

        
        public  ICollection<TaskProject> Tasks { get; set; }
        public  ICollection<Project> Projects { get; set; }
        public  ICollection<Comment> Comments { get; set; }
    }
}
