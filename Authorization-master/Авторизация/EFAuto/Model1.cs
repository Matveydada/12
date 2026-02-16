using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Авторизация.EFAuto
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Роли> Роли { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Роли>()
                .HasMany(e => e.Пользователи)
                .WithRequired(e => e.Роли)
                .HasForeignKey(e => e.Роль)
                .WillCascadeOnDelete(false);
        }
    }
}
