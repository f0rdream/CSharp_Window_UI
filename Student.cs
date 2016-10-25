using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_UI
{
    public class Student
    {
        public string Name { get; set; }
        public decimal ID { get; set; }
        public string StuClass { get; set; }
        public string School { get; set; }
        public string Region { get; set; }
        public DateTime StuDate { get; set; }
        public string Health { get; set; }
        public decimal IDCard { get; set; }
        public decimal PostNum { get; set; }
        public decimal PhoneNum { get; set; }

        public Student(string Name, decimal ID, string StuClass, string School, string Region, DateTime StuDate,
            string Health, decimal IDCard, decimal PostNum, decimal PhoneNum)
        {
            this.Name = Name;
            this.ID = ID;
            this.StuClass = StuClass;
            this.School = School;
            this.Region = Region;
            this.StuDate = StuDate;
            this.Health = Health;
            this.IDCard = IDCard;
            this.PostNum = PostNum;
            this.PhoneNum = PhoneNum;
        }
    }
}
