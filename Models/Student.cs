using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentInformation.Models
{
    public class Student
    {
        public Guid ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        
        //[DataType(DataType.EmailAddress)]
        //public object EmailAddress;
        

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
        

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}