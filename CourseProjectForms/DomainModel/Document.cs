using System;
using System.Collections.Generic;


namespace CourseProjectForms.DomainModel
{
    public class Document
    {
        public Int32 Id { get; set; }

        public DateTime Date { get; set; }

        public String PathToImage { get; set; }

        public Int32 CaseId { get; set; }
        public Case Case { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public Document()
        {
            Comments = new List<Comment>();
        }
    }
}