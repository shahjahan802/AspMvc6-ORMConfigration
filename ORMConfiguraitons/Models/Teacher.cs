using System;
using System.Collections.Generic;

namespace ORMConfiguraitons.Models
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rank { get; set; }
        public string Department { get; set; }
        public DateTime? Dob { get; set; }
        public string Cnic { get; set; }
        public string Mobile { get; set; }
    }
}
