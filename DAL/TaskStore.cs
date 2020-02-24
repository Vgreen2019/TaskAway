using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAway.DAL.Model;

namespace TaskAway.DAL
{
    public class TaskStore : ITaskStore
    {
        public void AddTask(TasksDALModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public TasksDALModel EditTask()
        {
            throw new NotImplementedException();
        }

        public void RemoveTask(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TasksDALModel> SelectAllTasks()
        {
            throw new NotImplementedException();
        }

        public TasksDALModel SelectTask(int id)
        {
            throw new NotImplementedException();
        }
    }
}
