 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAway.DAL.Model
{
    public class SubtasksDALModel
    {
        public int TaskID { get; set; }
        public int SubtaskID { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
