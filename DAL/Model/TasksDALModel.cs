using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAway.DAL.Model
{
    public class TasksDALModel
    {
        public int Id { get; set; }
        public int TaskID { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool IsImportant { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateCompleted { get; set; }
    }
}
