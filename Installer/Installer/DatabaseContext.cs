using System;
using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace Installer
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DatabaseContext : DbContext
    {
        public DbSet<Operator> Operators { get; set; }
        public DbSet<TowerDetail> TowerDetails { get; set; }

        public DatabaseContext():base("DatabaseContext")
        {
        }

        public DatabaseContext(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {

        }


    }
}
