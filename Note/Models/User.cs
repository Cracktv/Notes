using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zametki.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }


        public ICollection<Note> Notes { get; set; }
    }
}
