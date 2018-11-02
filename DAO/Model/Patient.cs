namespace DAO.Model
{
    class Patient
    {

        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpNic { get; set; }
        public int EmpContactNumber { get; set; }
        public string EmpAddress { get; set; }
        public string EmpUsername { get; set; }
        public string EmpPassword { get; set; }
        public string EmpAccess { get; set; }

        public Patient(int empId, string empName, string empNic, int empContactNumber, string empAddress, string empUsername, string empPassword, string empAccess)
        {
            EmpId = empId;
            EmpName = empName;
            EmpNic = empNic;
            EmpContactNumber = empContactNumber;
            EmpAddress = empAddress;
            EmpUsername = empUsername;
            EmpPassword = empPassword;
            EmpAccess = empAccess;
        }
    }
}
