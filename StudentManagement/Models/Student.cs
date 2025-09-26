﻿using StudentManagement.Models;

namespace StudentManagement.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
