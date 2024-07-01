
using DB.Entities;
using DB.Repository;


namespace Infrastructure.Interfaces
{
    public interface ITasksRepository : IBaseRepository<Tasks,int>
    {
        public void MarkAsCompleted(int Id);
        public void MarkAsUncompleted(int Id);

    }
}