/* 
 * CPRG 211 Lab 1
 * Author: Antonio Macedo
 * 
 * 
 */



namespace lab1_antoniomacedo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            gina.DisplayPersonInfo();
            Console.WriteLine(mike.ToString());
            ian.ChangeFavoriteColor();
            ian.DisplayPersonInfo();
            mary.GetAgeInTenYears();

            Relation relation1 = new Relation();
            Relation relation2 = new Relation();
            relation1.RelationshipType = "sister";
            relation1.ShowRelationShip(gina, mary);
            relation2.RelationshipType = "brother";
            relation2.ShowRelationShip(ian, mike);

            List<Person> people = new List<Person>();
            people.Add(ian);
            people.Add(gina);
            people.Add(mike);
            people.Add(mary);

            double AvgAge = 0;
            double Total = 0;
            Person Youngest = null;
            Person Oldest = null;

            foreach (Person person in people)
            {
                Total += person.Age;
            }

            AvgAge = Total / people.Count;
            Console.WriteLine($"Average  age is: {AvgAge}");

            for (int i = 0; i < people.Count; i++)
            {
                if (i == 0)
                {
                    Youngest = people[i];
                    Oldest = people[i];
                }
                else
                {
                    if (people[i].Age > Oldest.Age)
                    {
                        Oldest = people[i];
                    }
                    if (people[i].Age < Youngest.Age)
                    {
                        Youngest = people[i];
                    }
                }
            }

            Console.WriteLine($"The youngest person is: {Youngest.FirstName}");
            Console.WriteLine($"The oldest person is: {Oldest.FirstName}");

            foreach (Person person in people)
            {
                if(person.FirstName.StartsWith("M"))
                {
                    Console.WriteLine(person.ToString());
                }
            }

            foreach(Person person in people)
            {
                if(person.FavoriteColor == "Blue")
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}
