using System;
namespace OfficeApp.DTO
{
    public class Attendance
    {
        public Attendance()
        {
        }

        public string EmployeeName { get; set; }

        public string Note { get; set; }

        public DateTime AttendanceDate { get; set; }

    }
}
