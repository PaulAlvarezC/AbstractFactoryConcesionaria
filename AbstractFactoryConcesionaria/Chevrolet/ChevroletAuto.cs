using System;
using AbstractFactoryConcesionaria.Productos;

namespace AbstractFactoryConcesionaria.Chevrolet
{
    public class ChevroletAuto : Auto
    {
        string datos;

        public ChevroletAuto(string datos)
        {
            this.datos = datos;
        }

        public override string Ensamblar()
        {
            string resultado = "";

            switch (datos) {
                case "SUV":
                    resultado = "Chevrolet => Tipo: " + datos + "\n";
                    break;

                case "Camioneta":
                    resultado = "Chevrolet => Tipo: " + datos + "\n";
                    break;
            }

            return resultado;
        }
    }
}

