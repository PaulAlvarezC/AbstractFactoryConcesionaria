using AbstractFactoryConcesionaria.Productos;
using AbstractFactoryConcesionaria.Chevrolet;

namespace AbstractFactoryConcesionaria
{
    public class VallejoAraujo : IConcesionaria
    {
        public Auto CrearAuto(string datosAuto)
        {
            return new ChevroletAuto(datosAuto);
        }

        public Chasis CrearChasis(string datosChasis)
        {
            return new ChevroletChasis(datosChasis);
        }

        public Motor CrearMotor(string datosMotor)
        {
            return new ChevroletMotor(datosMotor);
        }
    }
}

