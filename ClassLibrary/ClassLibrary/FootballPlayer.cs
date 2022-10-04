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

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public void NameValidation()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("name can not be null");
            }
            if (Name.Length < MINIMUM_NAME_CHARACTERS)

            {
                throw new ArgumentOutOfRangeException("name must be at least 2 characters long");
            }
        }

        public void AgeValidation()
        {
            if (Age < MINIMUM_AGE)
            {
                throw new ArgumentOutOfRangeException("age can not be less than 1");
            }
        }

        public void ShirtNumberValidation()
        {
            if (ShirtNumber < MINIMUM_SHIRTNUMBER || ShirtNumber > MAXIMUM_SHIRTNUMBER)
            {
                throw new ArgumentOutOfRangeException("shirtNumber must be between 1 - 99");
            }
        }

        public void Validate()
        {
            NameValidation();
            AgeValidation();
            ShirtNumberValidation();
        }
    }
}
