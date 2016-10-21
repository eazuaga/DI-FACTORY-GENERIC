using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genericsFactory
{
    public class Dog : IAnimal
    {
        private string _nombre;
        public Dog(string nombre) 
        {
            this._nombre = nombre;

        }
        public void camina()
        {
            throw new NotImplementedException();
        }
    }
}
