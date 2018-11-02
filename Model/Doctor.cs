using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Doctor
    {
        Doctor()
        {
            DoctorId = 1;
        }

        public int DoctorId { get; }
        public string DoctorName { get; set; }
        public string DoctorNic { get; set; }
        public int DoctorContactNumber { get; set; }
        public string DoctorAddress { get; set; }
        public string Doctorspeciality { get; set; }
        public string DoctorDescription { get; set; }
    }
}
