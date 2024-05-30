using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class PoliceMan : BasePerson
    {
        public string Rang { get; set; }
        public PoliceMan(string firstName, string lastName, DateTime birthday, string gender, string email = "no email", string rang = "Officer") : base(firstName, lastName, birthday, gender, email)
        {
            Rang = rang;
        }

        public override void Greet()
        {
            Console.WriteLine($"Good afternoon, {Rang} {LastName}!");
        }
    }
}
