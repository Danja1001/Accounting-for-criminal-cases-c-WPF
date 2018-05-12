using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CourseProjectForms.DB.Mappings
{
    public class CaseMap : EntityTypeConfiguration<CourseProjectForms.DomainModel.Case>
    {
        public CaseMap()
        {
            ToTable("Case");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(x => x.Title).HasMaxLength(400).IsRequired();
            Property(x => x.Description).IsMaxLength().IsOptional();
            Property(x => x.StartDate).IsRequired();
            Property(x => x.EndDate).IsOptional();

            HasMany(x => x.Lawyers)
                .WithMany(x => x.Cases)
                .Map(cs =>
                {
                    cs.MapLeftKey("CaseId");
                    cs.MapRightKey("LawyerId");
                    cs.ToTable("LawyerToCase");
                });
        }
    }
}