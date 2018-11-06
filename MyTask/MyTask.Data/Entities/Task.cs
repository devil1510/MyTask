using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTask.Data.Entities
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Subject { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public List<Category> Categories { get; set; }
        public List<Link> Links { get; set; }
        public Status Status { get; set; }
        public List<User> Assignees { get; set; }
        public Priority Priority { get; set; }
    }
}
