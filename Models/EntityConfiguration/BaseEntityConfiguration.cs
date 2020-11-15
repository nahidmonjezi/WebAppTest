using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using WebAppTest.Models.Entities;

namespace WebAppTest.Models.EntityConfiguration
{

    public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntites
    {
        private readonly Guid _shopid;

        protected BaseEntityConfiguration(Guid shopid)
        {
            _shopid = shopid;
        }

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // throw new System.NotImplementedException();
            builder.HasKey(c => c.id);
            builder.Property(c => c.id).IsRequired().ValueGeneratedOnAdd().HasValueGenerator<GuidValueGenerator>();
            builder.Property(c => c.title).IsRequired().HasMaxLength(500);
            builder.Property(c => c.modified_at).IsRequired();
            builder.Property(c => c.created_at).IsRequired();

            builder.HasQueryFilter(c => c.shopid == _shopid);

        }
    }
}