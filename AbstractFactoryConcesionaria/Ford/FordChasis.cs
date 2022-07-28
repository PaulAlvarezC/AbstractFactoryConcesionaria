using System;
using AbstractFactoryConcesionaria.Productos;

namespace AbstractFactoryConcesionaria.Ford
{
    public class FordChasis : Chasis
    {
        string datos;

        public FordChasis(string datos) {
            this.datos = datos;
        }
        public override string Ensamblar() {
            return "Ford => " + datos + "\n";
        }
    }
}

