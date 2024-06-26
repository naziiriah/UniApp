﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using UniApp.Data;
using UniApp.Models;
using UniApp.Models.SchoolViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace UniApp.Pages.Instructors
{
    public class InstructorCoursesPageModel : PageModel
    {
        public List<AssignedCourse> AssignedCourseDataList;

        public void PopulateAssignedCourseData(SchoolContext context, Instructor instructor)
        {
            var allCourses = context.Course;
            var instructorCourses = new HashSet<int>(instructor.Courses.Select(c => c.CourseID));
            AssignedCourseDataList = new List<AssignedCourse>();
            foreach (var course in allCourses)
            {
                AssignedCourseDataList.Add(new AssignedCourse 
                {
                    CourseID = course.CourseID,
                    Title = course.Title,
                    Assigned = instructorCourses.Contains(course.CourseID)
                });
            }
        }
    }

}