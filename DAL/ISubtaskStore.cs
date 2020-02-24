using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAway.DAL.Model;

namespace TaskAway.DAL
{
    public interface ISubtaskStore
    { 
        void AddSubtask(SubtasksDALModel model);
        void DeleteSubtask(int id);
        SubtasksDALModel EditSubtask(SubtasksDALModel model);
        IEnumerable<SubtasksDALModel> SelectAllSubtasks();
    }
}
