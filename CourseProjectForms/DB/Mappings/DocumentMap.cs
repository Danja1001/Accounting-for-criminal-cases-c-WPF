using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CourseProjectForms.DB.Mappings
{
    public class DocumentMap : EntityTypeConfiguration<CourseProjectForms.DomainModel.Document>
    {
        public DocumentMap()
        {
            ToTable("Document");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(x => x.Date).IsRequired();
            Property(x => x.PathToImage).HasMaxLength(400).IsRequired();
            Property(x => x.CaseId).IsRequired();
            

            HasRequired(x => x.Case)
                .WithMany(x => x.Documents);
        }
    }
}