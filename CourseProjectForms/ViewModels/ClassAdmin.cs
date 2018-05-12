using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectForms
{
    class ClassAdmin
    {
        public string username;
        public int id;
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public int IBAN;
        public int PhotoId;


        public ClassAdmin()
        {
            username = "Admin";
            id = 0;
            FirstName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            IBAN = 0;
            PhotoId = 0;
        }


        public ClassAdmin(string InFirstName, string InLastName, DateTime InDateOfBirth, int InIBAN)
        {
            this.FirstName = InFirstName;
            this.LastName = InLastName;
            this.DateOfBirth = InDateOfBirth;
            this.IBAN = InIBAN;
        }


        public ClassAdmin(string info) //!id!FirstName!LastName!DateOfBirth!IBAN!PhotoId
        {
            if(info != "")
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                FirstName = val[1];
                LastName = val[2];
                DateOfBirth = Convert.ToDateTime(val[3]);
                IBAN = Convert.ToInt32(val[4]);
                if (val.Length == 6)
                    PhotoId = Convert.ToInt32(val[5]);

            }
        }


        public ClassAdmin(string InFirstName, string InLastName, DateTime InDateOfBirth, int InIBAN, int InPhotoId)
        {
            this.FirstName = InFirstName;
            this.LastName = InLastName;
            this.DateOfBirth = InDateOfBirth;
            this.IBAN = InIBAN;
            this.PhotoId = InPhotoId;
        }
    }

}
