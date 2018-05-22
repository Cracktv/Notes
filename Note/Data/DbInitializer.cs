using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zametki.Models;

namespace Zametki.Data
{
    public class DbInitializer
    {
        public static void Initialize(ZametkiContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
            new User{FirstName="Carson",SecondName="Alexander"},
            new User{FirstName="Meredith",SecondName="Alonso"},
            new User{FirstName="Arturo",SecondName="Anand"},
            new User{FirstName="Gytis",SecondName="Barzdukas"},
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();


            var notes = new Note[]
            {
            new Note{UserID=1},
            new Note{UserID=2},
            new Note{UserID=3},
            new Note{UserID=4},
            };
            foreach (Note e in notes)
            {
                context.Notes.Add(e);
            }
            context.SaveChanges();
        }
    }
}
