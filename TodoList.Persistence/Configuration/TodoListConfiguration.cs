using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain = TodoList.Domain;

namespace TodoList.Persistence.Configuration
{
    public class TodoListConfiguration : IEntityTypeConfiguration<Domain.TodoList>
    {
        public void Configure(EntityTypeBuilder<Domain.TodoList> builder)
        {
            builder.ToTable("Todos");

            builder.HasKey(t => t.Id);

            builder
                .HasMany(t => t.Todos)
                .WithOne(t => t.TodoList)
                .HasForeignKey(t => t.TodoListId);
        }
    }
}
