using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{
    public class Patient
    {
        public string PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientAddressCode { get; set; }
        public DateTime PatientDOB { get; set; }
        public float PatientBMI { get; set; }
        public bool IsDiabeticPatient { get; set; }
        public string PatientMedicalHistory { get; set; }
        public long PatientPhoneNumber { get; set; }
    }
}
