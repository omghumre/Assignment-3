﻿using StudentManagement.Models;

namespace StudentManagement.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
