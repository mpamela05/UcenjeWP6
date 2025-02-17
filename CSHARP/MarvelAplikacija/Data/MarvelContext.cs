using MarvelAplikacija.Models;
using Microsoft.EntityFrameworkCore;

namespace MarvelAplikacija.Data
{
    public class MarvelContext : DbContext
    {

        public MarvelContext(DbContextOptions<MarvelContext> options) : base(options)
        {

        }
        public DbSet<identiteti> Identitet { get; set; }


    }
}
