using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace genericsFactory
{
    public class Cat: IAnimal
    {
        private string _nombre;
        public Cat(string nombre) 
        {
            this._nombre = nombre;
        }

        public void camina()
        {
            throw new NotImplementedException();
        }
    }
}
