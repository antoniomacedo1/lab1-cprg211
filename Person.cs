using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_antoniomacedo
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColor { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColor = favoriteColor;
            Age = age;
            IsWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine( $"{PersonId}: {FirstName} {LastName}'s favorite color is: {FavoriteColor}");
        }

        public void ChangeFavoriteColor()
        { 
            FavoriteColor = "White";
        }

        public void GetAgeInTenYears()
        {
            Console.WriteLine($"{FirstName} {LastName}'s age in ten years is: {Age + 10} ");
        }

        public override string ToString()
        {
            List<string> personInfo = new List<string>
            {
                $"Person ID: {PersonId}",
                $"First Name: {FirstName}",
                $"Last Name: {LastName}",
                $"Favourite Color: {FavoriteColor}",
                $"Age: {Age}",
                $"Is Working: {IsWorking}"
            };

            return string.Join("\n", personInfo);
        }
    }
}
