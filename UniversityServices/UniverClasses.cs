using System.Data;

namespace UniversityServices
{
    public class University
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int FacultyId { get; set; }
    }

    public class Resident
    {
        public int Id { get; set; }
        public string? Role { get; set; }
        public int FacultyId { get; set; }
        public DataSetDateTime? Starting { get; set; }
        public DataSetDateTime? Ending { get; set; }
    }
}