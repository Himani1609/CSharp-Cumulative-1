namespace Csharp_Cumulative_Assignment_1.Models
{


    public class Course
    {
        // 
        public int CourseId { get; set; }

        // 
        public string CourseCode { get; set; }

        // 
        public DateTime CourseStartDate { get; set; }

        // 
        public DateTime CourseFinishDate { get; set; }

        // Unique identifier for each teacher. It is used as the Foreign key in Courses table.
        public int TeacherId { get; set; }

        // 
        public string CourseName { get; set; }
    }
}
