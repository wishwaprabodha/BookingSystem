namespace DAO.Model
{
    class Booking
    {


        public int BookId { get; set; }
        public string AppointDate { get; set; }
        public string AppointTime { get; set; }
        public int BookContactNumber { get; set; }
        public bool BookStatus { get; set; }
        public int Empid { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public Booking(int bookId, string appointDate, string appointTime, int bookContactNumber, bool bookStatus, int empid, int patientId, int doctorId)
        {
            BookId = bookId;
            AppointDate = appointDate;
            AppointTime = appointTime;
            BookContactNumber = bookContactNumber;
            BookStatus = bookStatus;
            Empid = empid;
            PatientId = patientId;
            DoctorId = doctorId;
        }
    }
}
