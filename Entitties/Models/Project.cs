using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitties.Models
{
    public enum ProjectStatus
    {
        Open = 0,
        Close,
    }
    public class Project
    {
        [Key]
        [Column("ProjectID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("ProjectName")]
        public string Name { get; set; }
 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProjectStatus Status { get; set; }

        public int AssignTo { get; set; }

        public virtual User User { get; set; }
        public ICollection<TaskProject> Tasks { get; set; }
    }
}
