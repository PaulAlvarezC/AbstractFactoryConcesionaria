using System;
using AbstractFactoryConcesionaria.Productos;

namespace AbstractFactoryConcesionaria.Ford
{
    public class FordAuto : Auto
    {
        string datos;

        public FordAuto(string datos)
        {
            this.datos = datos;
        }
        public override string Ensamblar()
        {
            string resultado = "";

            switch (datos)
            {
                case "SUV":
                    resultado = "Ford => Tipo: " + datos + "\n";
                    break;

                case "Camioneta":
                    resultado = "Ford => Tipo: " + datos + "\n";
                    break;
            }

            return resultado;
        }
    }
}

