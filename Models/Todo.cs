using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public string Activity { get; set; }
        public string Details { get; set; }
        public bool IsComplete { get; set; }
        [DataType(DataType.Date)]
        public DateTime ActivityDate { get; set; }
    }
}
