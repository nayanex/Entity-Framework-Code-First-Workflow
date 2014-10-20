using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOneProject
{
    public class Patient
    {
        public Patient()
        {
            Visits = new List<Visit>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public AnimalType AnimalType { get; set; }
        public DateTime? FirstVisit { get; set; }
        public List<Visit> Visits { get; set; }
    }
}
