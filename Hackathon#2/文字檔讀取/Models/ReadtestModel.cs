namespace Hackathon007.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.IO;

    public partial class ReadtestModel : DbContext
    {
        public ReadtestModel()
            : base("name=ReadtestModel1")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory",Directory.GetCurrentDirectory());

        }

        public virtual DbSet<ReadtestTable> ReadtestTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
