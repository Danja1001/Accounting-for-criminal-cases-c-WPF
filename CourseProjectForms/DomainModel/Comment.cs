using System;


namespace CourseProjectForms.DomainModel
{
    public class Comment
    {
        public Int32 Id { get; set; }

        public String Description { get; set; }

        public DateTime Date { get; set; }

        public Int32 LawyerId { get; set; }
        public Lawyer Lawyer { get; set; }

        public Int32 DocumentId { get; set; }
        public Document Document { get; set; }
    }
}