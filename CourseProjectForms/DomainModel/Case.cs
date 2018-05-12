using System;
using System.Collections.Generic;


namespace CourseProjectForms.DomainModel
{
    public class Case
    {
        public Int32 Id { get; set; }

        public String Title { get; set; }

        public String Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public ICollection<Lawyer> Lawyers { get; set; }

        public ICollection<Document> Documents { get; set; }

        public Case()
        {
            Lawyers = new List<Lawyer>();
            Documents = new List<Document>();
        }
    }
}