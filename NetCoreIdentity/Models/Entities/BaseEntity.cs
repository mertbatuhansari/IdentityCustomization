using NetCoreIdentity.Models.Enums;
using NetCoreIdentity.Models.Interfaces;

namespace NetCoreIdentity.Models.Entities
{
    public abstract class BaseEntity : IEntity
    {
        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
