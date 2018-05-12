using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using CourseProjectForms.DomainModel;


namespace CourseProjectForms.DB
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            Initialize();
        }

        public IDbSet<Lawyer> Lawyers { get; set; }
        public IDbSet<Case> Cases { get; set; }
        public IDbSet<Document> Documents { get; set; }
        public IDbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Get all maps from this assembly.
            modelBuilder.Configurations.AddFromAssembly(
                GetType().Assembly    
            );
        }
        
        private void Initialize()
        {
            Database.SetInitializer<DatabaseContext>(null);
        }
    }
}