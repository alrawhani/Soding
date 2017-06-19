using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodingTasksManager.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string ResponsibleName { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}