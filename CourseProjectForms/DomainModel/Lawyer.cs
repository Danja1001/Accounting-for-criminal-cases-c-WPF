using System;
using System.Collections.Generic;


namespace CourseProjectForms.DomainModel
{
    public class Lawyer
    {
        public Int32 Id { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Case> Cases { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public Lawyer()
        {
            Cases = new List<Case>();
            Comments = new List<Comment>();
        }
    }
}