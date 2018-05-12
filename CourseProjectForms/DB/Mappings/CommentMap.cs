using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CourseProjectForms.DB.Mappings
{
    public class CommentMap : EntityTypeConfiguration<CourseProjectForms.DomainModel.Comment>
    {
        public CommentMap()
        {
            ToTable("Comment");

            HasKey(x => x.Id);

            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            Property(x => x.Description).IsMaxLength().IsRequired();
            Property(x => x.Date).IsRequired();
            Property(x => x.LawyerId).IsRequired();
            Property(x => x.DocumentId).IsRequired();
            


            HasRequired(x => x.Lawyer)
                .WithMany(x => x.Comments);

            HasRequired(x => x.Document)
                .WithMany(x => x.Comments);
        }
    }
}