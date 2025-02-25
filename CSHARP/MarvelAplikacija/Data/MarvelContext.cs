using Microsoft.EntityFrameworkCore;

namespace MarvelAplikacija.Data
{
    public class MarvelContext : DbContext
    {
        internal object timovi;
        internal object Timovi;
        internal object? heroji;
        internal object identiteti;

        public MarvelContext(DbContextOptions<MarvelContext> options) : base(options)
        {

        }
        public DbSet<identiteti> Identitet { get; set; }


    }
}
