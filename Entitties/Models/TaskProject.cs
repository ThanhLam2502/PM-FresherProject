using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitties.Models
{
    public enum TaskStatus
    {
        NotStarted = 0,
        InProgress,
        Completed,
        Closed,
    }
    [Table("Task")]
    public class TaskProject
    {
        public TaskProject()
        {
            Users = new HashSet<User>();
        }

        [Key]
        [Column("TaskID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string TaskName { get; set; }
        public string AttachFiles { get; set; }

        [Index]
        public TaskStatus Status { get; set; }

        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }

        public  ICollection<User> Users { get; set; }
        public  ICollection<Comment> Comments { get; set; }
    }
}
