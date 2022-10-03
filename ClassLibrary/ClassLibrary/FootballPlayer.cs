using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class FootballPlayer
    {
        private readonly int MINIMUM_NAME_CHARACTERS = 2;
        private readonly int MINIMUM_AGE = 1;
        private readonly int MINIMUM_SHIRTNUMBER = 1;
        private readonly int MAXIMUM_SHIRTNUMBER = 99;

        private int _id;
        private string? _name;
        private int _age;
        private int _shirtNumber;

        public FootballPlayer(int id, string? name, int age, int shirtNumber)
        {
            _id = id;
            Validate(name, age, shirtNumber);
        }

        public int Id { get => _id; }
        public string? Name { get => _name; }
        public int Age { get => _age; }
        public int ShirtNumber { get => _shirtNumber; }

        public void NameValidation(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name can not be null");
            }
            if (name.Length < MINIMUM_NAME_CHARACTERS)

            {
                throw new ArgumentOutOfRangeException("name must be at least 2 characters long");
            }

            _name = name;
        }

        public void AgeValidation(int age)
        {
            if (age < MINIMUM_AGE)
            {
                throw new ArgumentOutOfRangeException("age can not be less than 1");
            }

            _age = age;
        }

        public void ShirtNumberValidation(int shirtNumber)
        {
            if (shirtNumber < MINIMUM_SHIRTNUMBER || shirtNumber > MAXIMUM_SHIRTNUMBER)
            {
                throw new ArgumentOutOfRangeException("shirtNumber must be between 1 - 99");
            }

            _shirtNumber = shirtNumber;
        }

        public void Validate(string name, int age, int shirtNumber)
        {
            NameValidation(name);
            AgeValidation(age);
            ShirtNumberValidation(shirtNumber);
        }
    }
}
