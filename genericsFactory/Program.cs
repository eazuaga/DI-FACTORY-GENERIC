using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genericsFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory<IAnimal>.Register(1, () => new Dog("Fido"));
            Factory<IAnimal>.Register(2, () => new Cat("Garfield"));

            // no need to pass parameters now:
            IAnimal animal = Factory<IAnimal>.Create(1);
        }
    }
}
