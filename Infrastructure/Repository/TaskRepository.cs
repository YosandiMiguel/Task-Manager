
using System.Linq;
using DB.Entities;
using DB.Repository;
using Infrastructure.Core;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Tls;

namespace Infrastructure.Repository
{
    public class TaskRepository : BaseRepository<Tasks, int>, ITasksRepository
    {
        public readonly TasksContext context;

        public TaskRepository(TasksContext context) : base(context)
        {
            this.context = context;
        }

        public override void Create(Tasks entity)
        {
            if(context.tasks.Any(tsk => tsk.title == entity.title))
            {
                throw new Exception("Esta tarea ya esta creada");
            }
        }

        public void MarkAsCompleted(int Id)
        {
            throw new NotImplementedException();
        }

        public void MarkAsUncompleted(int Id)
        {
            throw new NotImplementedException();
        }
    }

}