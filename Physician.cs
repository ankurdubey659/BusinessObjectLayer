using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{
    public class Physician
    {
        public string PhysicianId { get; set; }
        public string PhysicianFirstName { get; set; }
        public string PhysicianMiddleName { get; set; }
        public string PhysicianLastName { get; set; }
        public string PhysicianSpeciality { get; set; }
        public string PhysicianQualification { get; set; }
        public long PhysicianPhoneNumber { get; set; }
        public string PhysicianEmail { get; set; }
    }
}
