using System;
using AbstractFactoryConcesionaria.Productos;

namespace AbstractFactoryConcesionaria.Ford
{
    public class FordMotor : Motor
    {
        string datos;

        public FordMotor(string datos)
        {
            this.datos = datos;
        }
        public override string Ensamblar()
        {
            return "Ford => " + datos + "\n";
        }
    }
}

