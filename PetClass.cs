using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFLearning1
{
    internal class PetClass
    {
        public string PetName { get; set; }
        public string AnimalType { get; set; }
        public string Breed { get; set; }
        public string Colour { get; set; }
        public string Suburb { get; set; }
        public string OwnerName { get; set; }


        public PetClass(string petName, string animalType, string breed, string colour, string suburb, string ownerName)
        {
            PetName = petName;
            AnimalType = animalType;
            Breed = breed;
            Colour = colour;
            Suburb = suburb;
            OwnerName = ownerName;
        }
    }
}
