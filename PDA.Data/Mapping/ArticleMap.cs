using Microsoft.EntityFrameworkCore;
using PDA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDA2.Data.Mapping
{
    internal class ArticleMap
    {
        public class CalEventMap : IEntityTypeConfiguration<Article>
        {

            public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Article> builder)
            {
                builder.HasKey(x => x.Id);
                builder.ToTable("cal_event");
            }
        }
    }
}
