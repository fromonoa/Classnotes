using ClassNotes.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassNotes.Api.Data
{
    public class NotesDBContext : DbContext
    {
        public NotesDBContext(DbContextOptions<NotesDBContext> options) : base(options)
        {
        }
        public DbSet<Note> Notes => Set<Note>();
    }
}
