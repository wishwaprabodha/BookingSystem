namespace DAO.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorNic { get; set; }
        public int DoctorContactNumber { get; set; }
        public string DoctorAddress { get; set; }
        public string Doctorspeciality { get; set; }
        public string DoctorDescription { get; set; }


        public Doctor(int doctorId, string doctorName, string doctorNic, int doctorContactNumber, string doctorAddress, string doctorspeciality, string doctorDescription)
        {
            DoctorId = doctorId;
            DoctorName = doctorName;
            DoctorNic = doctorNic;
            DoctorContactNumber = doctorContactNumber;
            DoctorAddress = doctorAddress;
            Doctorspeciality = doctorspeciality;
            DoctorDescription = doctorDescription;
        }
    }





}
