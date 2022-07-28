using System;
using AbstractFactoryConcesionaria.Productos;

namespace AbstractFactoryConcesionaria.Chevrolet
{
    public class ChevroletMotor : Motor
    {
        string datos;

        public ChevroletMotor(string datos)
        {
            this.datos = datos;
        }
        public override string Ensamblar()
        {
            return "Chevrolet => " + datos + "\n";
        }
    }
}

