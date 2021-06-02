using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.Models
{
    public class Academy
    {
        public Academy(string location, string name)
        {
            Location = location;
            Name = name;
            Students = new List<Student>();
        }

        public string Location { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; }
    }
}
