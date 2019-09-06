using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Task")]
        public string Activity { get; set; }
        [DisplayName("Summary")]
        public string Details { get; set; }
        [DisplayName("Status")]
        public bool IsComplete { get; set; }
        [DisplayName("Activity Date")]
        [DataType(DataType.Date)]
        public DateTime ActivityDate { get; set; }
    }
}
