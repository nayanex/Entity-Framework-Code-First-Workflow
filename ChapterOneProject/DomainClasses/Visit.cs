using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterOneProject
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string ReasonForVisit { get; set; }
        public string Outcome { get; set; }
        public decimal Weight { get; set; }
        public int PatientId { get; set; }
    }
}
