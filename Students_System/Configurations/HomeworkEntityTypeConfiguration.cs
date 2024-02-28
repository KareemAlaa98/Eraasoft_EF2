using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Students_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_System.Configurations
{
    internal class HomeworkEntityTypeConfiguration : IEntityTypeConfiguration<HomeworkSubmission>
    {
        public void Configure(EntityTypeBuilder<HomeworkSubmission> builder)
        {
            builder.Property(e => e.Content).HasColumnType("varchar(1000)").IsRequired();
            builder.Property(e => e.ContentType).IsRequired();
            builder.Property(e => e.SubmissionTime).IsRequired();
        }
    }
}
