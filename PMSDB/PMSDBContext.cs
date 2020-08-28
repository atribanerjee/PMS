using PMSDB.POCO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDB
{
    public partial class PMSDBContext:DbContext
    {
        public PMSDBContext(String connectionString)
            : base("name=PMSDBContext")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Database.Connection.ConnectionString = connectionString;

        }
        public DbSet<POCO.Type> Type { get; set; }
        public DbSet<Content> Content { get; set; }
    }
}
