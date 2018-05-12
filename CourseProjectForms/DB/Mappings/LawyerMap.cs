using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace CourseProjectForms.DB.Mappings
{
    public class LawyerMap : EntityTypeConfiguration<CourseProjectForms.DomainModel.Lawyer>
    {
        public LawyerMap()
        {
            ToTable("Lawyer");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(x => x.FirstName).HasMaxLength(255).IsRequired();
            Property(x => x.LastName).HasMaxLength(255).IsRequired();
            Property(x => x.Email).HasMaxLength(255).IsRequired();
            Property(x => x.Password).HasMaxLength(255).IsRequired();
            Property(x => x.DateOfBirth).IsRequired();
        }
    }
}