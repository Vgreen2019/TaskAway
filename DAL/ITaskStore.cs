using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAway.DAL.Model;

namespace TaskAway.DAL
{ 
    public interface ITaskStore
    {
        TasksDALModel SelectTask(int id);
        IEnumerable<TasksDALModel> SelectAllTasks();
        void AddTask(TasksDALModel model);
        void RemoveTask(int id);
        TasksDALModel EditTask();
        void DeleteTask(int id);
        
    }
}
