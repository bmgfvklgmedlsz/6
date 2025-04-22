using _6;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace _6
{
    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Companies> Companies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Companies>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Companies>()
                .Property(e => e.City)
                .IsUnicode(false);
        }
    }
}


