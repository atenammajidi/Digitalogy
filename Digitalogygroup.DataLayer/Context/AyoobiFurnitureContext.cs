using Digitalogygroup.DataLayer.Entities.Content;
using Digitalogygroup.DataLayer.Entities.Permissions;
using Digitalogygroup.DataLayer.Entities.Products;
using Digitalogygroup.DataLayer.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Digitalogygroup.DataLayer.Context
{
    public class DigitalogygroupContext : DbContext
    {

        public DigitalogygroupContext(DbContextOptions<DigitalogygroupContext> options):base(options)
        {

        }

        #region User

        public DbSet<Tbl_Role> Tbl_Role { get; set; }
        public DbSet<Tbl_User> Tbl_User { get; set; }
        public DbSet<Tbl_UserRole> Tbl_UserRole { get; set; }
        #endregion

        #region product

        public DbSet<Tbl_File> Tbl_File { get; set; }
        public DbSet<Tbl_Language> Tbl_Language { get; set; }
        public DbSet<Tbl_Product> Tbl_Product { get; set; }
        public DbSet<Tbl_ProductGroup> Tbl_ProductGroup { get; set; }
        public DbSet<Tbl_SlidShow> tbl_SlidShow { get; set; }
        #endregion

        public DbSet<Tbl_Permission> Tbl_Permission { get; set; }
        public DbSet<Tbl_RolePermission> Tbl_RolePermission { get; set; }
        public DbSet<Tbl_content> Tbl_content  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Tbl_Role>()
                .HasQueryFilter(r => !r.IsDelete);

            base.OnModelCreating(modelBuilder);
        }
    }
}
