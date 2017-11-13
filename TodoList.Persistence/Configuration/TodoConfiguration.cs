using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoList.Domain;

namespace TodoList.Persistence.Configuration
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("Todos");

            builder.HasKey(t => t.Id);

            builder
                .HasOne(t => t.TodoList)
                .WithMany(t => t.Todos)
                .HasForeignKey(t => t.TodoListId);

        }
    }
}
