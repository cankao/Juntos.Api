using Juntos.Api.Users.Domain.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juntos.Api.Users.Infrastructure.Maps
{
    public class UserMap : IEntityTypeConfiguration<UserDTO>
    {
        public void Configure(EntityTypeBuilder<UserDTO> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Login).IsRequired();
            builder.Property(x => x.Password);
            builder.Property(x => x.Email);                
        }
    }
}
