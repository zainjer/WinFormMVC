using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vplquiz.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PhoneNum { get; set; }
        public string Specialization { get; set; }
        public string Experience { get; set; }
    }
}
