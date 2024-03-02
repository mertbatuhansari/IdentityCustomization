using NetCoreIdentity.Models.Enums;

namespace NetCoreIdentity.Models.Entities
{
    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        //Relational Properties

        public virtual AppUser AppUser { get; set; }
    }
}
