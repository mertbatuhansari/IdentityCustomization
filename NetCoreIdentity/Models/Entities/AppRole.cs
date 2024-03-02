using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using NetCoreIdentity.Models.Enums;
using NetCoreIdentity.Models.Interfaces;

namespace NetCoreIdentity.Models.Entities
{
    public class AppRole : IdentityRole<int>, IEntity
    {    
        public AppRole()
        {            
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
              

        //Relational Properties

        public virtual List<AppUserRole> UserRoles { get; set; }
    }
}
