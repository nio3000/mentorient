using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mentorient.Models
{
    public class Student
    {
        public int Id { get; set; } 

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments {get; set;}
    }
}