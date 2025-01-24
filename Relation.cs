using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_antoniomacedo
{
    public class Relation
    {
        public string RelationshipType { get; set; }
        public void ShowRelationShip(Person person1, Person person2)
        {
            switch (RelationshipType)
            {
                case "sister":
                    Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: Sisterhood");
                    break;
                case "brother":
                    Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: Brotherhood");
                    break;
                case "mother":
                    Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: Motherhood");
                    break;
                case "father":
                    Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: Fatherhood");
                    break;
            }
        }
    }
}
