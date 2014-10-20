using ChapterOneProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetConsole
{
    class CreatePatient
    {
        private static void CreateNewPatient()
        {
            var dog = new AnimalType { TypeName = "Dog" };
            var patient = new Patient
            {
                Name = "Sampson",
                BirthDate = new DateTime(2008, 1, 28),
                AnimalType = dog,
                Visits = new List<Visit>
                {
                    new Visit
                    {
                        Date = new DateTime(2011, 9, 1)
                    }
                }
            };

            using (var context = new VetContext())
            {
                context.Patients.Add(patient);
                context.SaveChanges();
            }
        }

        static void Main(string[] args)
        {
            CreateNewPatient();
        }
    }
}
