using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Activity { get; set; }
        public string Details { get; set; }
        public bool IsComplete { get; set; }
        public DateTime ActivityDate { get; set; }
    }
}
