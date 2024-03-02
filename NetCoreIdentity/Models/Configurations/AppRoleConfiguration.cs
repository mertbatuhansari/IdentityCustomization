using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreIdentity.Models.Entities;

namespace NetCoreIdentity.Models.Configurations
{
    public class AppRoleConfiguration : BaseConfiguration<AppRole>
    {
        public override void Configure(EntityTypeBuilder<AppRole> builder)
        {
            base.Configure(builder);            
            builder.HasMany(x=>x.UserRoles).WithOne(x=>x.Role).HasForeignKey(x=>x.RoleId).IsRequired();
        }
    }
}
