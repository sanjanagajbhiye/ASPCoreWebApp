using System.ComponentModel.DataAnnotations;

namespace ASPCoreWebApp.Models
{
    public class Student
    {
            public int studentId { get; set; }

            [Required]
            public string studentName { get; set; }
            [Required]
            public string gender { get; set; }
            [Required]
            public int age { get; set; }
            [Required]
            public string standard { get; set; }
            [Required]
            public DateTime dob { get; set; }
      
    }
}
