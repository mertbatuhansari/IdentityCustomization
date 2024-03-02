using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetCoreIdentity.Models.Entities;

namespace NetCoreIdentity.Models.Configurations
{
    public class AppUserProfileConfiguration:BaseConfiguration<AppUserProfile>
    {   //Şuan için kullanmayacağım fakat ilerleyen zamanlarda lazım olur diye hazır dursun.
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);
        }
    }
}
