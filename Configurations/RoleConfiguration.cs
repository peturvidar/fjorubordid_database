using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace fjorubordid_database.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>

    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {

                    Name = "User", 
                    NormalizedName= "USER",
                },

                new IdentityRole
                {

                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                }
                );
        }
    }
}
