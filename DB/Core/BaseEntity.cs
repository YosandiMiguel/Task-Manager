
namespace DB.Core
{
    public abstract class BaseEntity
    {
        public DateTime? creationDate { get; set; }
        public bool? isDeleted { get; set; }
        public BaseEntity(DateTime creationDate)
        {
            this.creationDate = creationDate;
            this.isDeleted = false;
        }

        public DateTime modfDate { get; set; }
        public DateTime deletedDate { get; set; }
    }
}
