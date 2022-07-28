using System;
using AbstractFactoryConcesionaria.Productos;

namespace AbstractFactoryConcesionaria.Chevrolet
{
    public class ChevroletChasis : Chasis
    {
        string datos;

        public ChevroletChasis(string datos) {
            this.datos = datos;
        }
        public override string Ensamblar() {
            return "Chevrolet => " + datos + "\n";

        }
    }
}

