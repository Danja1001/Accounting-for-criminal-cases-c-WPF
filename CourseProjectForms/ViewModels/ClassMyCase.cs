using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CourseProjectForms
{
   public class ClassMyCase
    {
        public int id;
        public string title;
        public string lawyer;
        public string description;
        public DateTime dateSrart;
        public DateTime dateStop;

        public ClassMyCase()
        {
            id = 0;
            title = "";
            lawyer = "";
            description = "";
            dateStop = dateSrart = DateTime.Now;

        }
        public ClassMyCase(int inId, string inTitle, string inLawyer, string inDescription, DateTime inDateStart, DateTime inDateStop)
        {
            this.id = inId;
            this.title = inTitle;
            this.lawyer = inLawyer;
            this.description = inDescription;
            this.dateSrart = inDateStart;
            this.dateStop = inDateStop;
        }
        public ClassMyCase(string info) // 123!Kill!Расследование убийства на улице Вязов!Иванов!12.12.2012!01.01.0101
        {
            if (info != "")
            {
                string[] val = info.Split('!');
                    id = Convert.ToInt32(val[0]);
                    title = val[1];
                    description = val[2];
                    dateSrart = Convert.ToDateTime(val[4]);

                if (val.Length == 6)
                {
                  
                    lawyer = val[3];
                   
                    dateStop = Convert.ToDateTime(val[5]);
                }
            }   
        }


        public ClassMyCase(int inId, string inTitle, string inDescription, DateTime inDateStart)
        {
            this.id = inId;
            this.title = inTitle;
            this.description = inDescription;
            this.dateSrart = inDateStart;
        }
    }
}
