using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zametki.Models
{
    public class Note
    {
        public int NoteID { get; set; }
        public string Title { get; set; }
        public string Zapis { get; set; }
        public int UserID { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public User User { get; set; }
    }
}
