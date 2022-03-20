using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjectLayer
{
    public class Appointment
    {
        public string BookingId { get; set; }
        public DateTime BookingDateAndTime { get; set; }
        public DateTime AppointmentDateAndTime { get; set; }
        public string AppointedPatient { get; set; }
        public string PreferredDoctor { get; set; }
        public float ConsultationFee { get; set; }
        public string FeeStatus { get; set; }
        public string AppointmentStatus { get; set; }
    }
}
