﻿using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace UniApp.Models;

public class Instructor : Person
{
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Hire Date")]
    public DateTime HireDate { get; set; }

    [Display(Name = "Full Name")]
    public string FullName
    {
        get { return LastName + ", " + FirstName; }
    }

    public ICollection<Course> Courses { get; set; }
    public OfficeAssignment OfficeAssignment { get; set; }
}
