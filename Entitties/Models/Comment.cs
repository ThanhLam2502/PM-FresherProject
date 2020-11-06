using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entitties.Models
{
    public class Comment
    {
        [Key]
        [Column("CommentID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Content { get; set; }
        public int ParentCommentID { get; set; }

        public int UserID { get; set; }
        public int TaskID { get; set; }
    }
}
