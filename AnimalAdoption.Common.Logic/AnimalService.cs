using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class AnimalService
    {
        public Animal[] ListAnimals => new Animal[] {
            new Animal { Id = 1, Name = "Tiger 1", Age = 50, Description = "Tiger 1 Description" },
            new Animal { Id = 2, Name = "Tiger 2", Age = 50, Description = "Tiger 2 Description" },
            new Animal { Id = 3, Name = "Tiger 3", Age = 50, Description = "Tiger 3 Description" },
        };
    }
}
