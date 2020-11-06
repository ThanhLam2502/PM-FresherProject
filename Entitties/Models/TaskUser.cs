using Entitties.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class TaskUser
    {
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int TaskID { get; set; }
        public virtual TaskProject Task { get; set; }
    }
}
