using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{
    public class Consultation
    {
        public string PrescriptionId { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public string CPhysician { get; set; }
        public string AppointmentDetails { get; set; }
        public string Diagnosis { get; set; }
        public string Dosage { get; set; }
    }
}
