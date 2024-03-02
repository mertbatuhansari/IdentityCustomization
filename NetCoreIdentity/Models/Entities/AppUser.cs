using Microsoft.AspNetCore.Identity;
using NetCoreIdentity.Models.Enums;
using NetCoreIdentity.Models.Interfaces;

namespace NetCoreIdentity.Models.Entities
{
    public class AppUser : IdentityUser<int>, IEntity //int vermezsek id otomatik olarak guid yani string olur.
    {
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties

        public virtual List<AppUserRole> UserRoles { get; set; }
        public virtual AppUserProfile Profile { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
