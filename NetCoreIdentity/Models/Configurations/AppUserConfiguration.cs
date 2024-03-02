using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreIdentity.Models.Entities;

namespace NetCoreIdentity.Models.Configurations
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id); //Zaten Identity class'ında Id gelecek. Onun için igrone ettik.
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.Id); //Kullanıcım profille 1'e 1 ve profilim de kullanıcı ile 1'e 1 ilişkilidir.
            builder.HasMany(x=>x.Orders).WithOne(x=>x.AppUser).HasForeignKey(x => x.AppUserID);
            builder.HasMany(x=>x.UserRoles).WithOne(x=>x.User).HasForeignKey(x=>x.UserId).IsRequired();
        }

    }
}
