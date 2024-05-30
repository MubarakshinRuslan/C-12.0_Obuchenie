using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class BasePerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age {  get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public BasePerson(string firstName, string lastName, DateTime birthday, string gender, string email = "no email")
        {
            FirstName = firstName;
            LastName = lastName;
            TimeSpan lifeTime = DateTime.Now - birthday;
            Age = (int)Math.Round(lifeTime.TotalDays / 365);
            BirthDate = birthday;
            Email = email;
            Gender = gender;
        }

        public virtual void Greet()
        {
            Console.WriteLine($"Hello, {FirstName}!");
        }

        ~BasePerson()
        {
            Console.WriteLine("вызван деструктор");
        }
    }
}
