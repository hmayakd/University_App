﻿namespace University_App.Models
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Subject { get; set; }
    }
}
