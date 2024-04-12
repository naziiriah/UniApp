using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UniApp.Models;

public class Student : Person
{
    public DateTime EnrollmentDate { get; set; }

    [Display(Name = "Full Name")]
    public string FullName
    {
        get
        {
            return FirstName + " " + LastName;
        }
    }

    public ICollection<Enrollment> Enrollments { get; set; }

}
