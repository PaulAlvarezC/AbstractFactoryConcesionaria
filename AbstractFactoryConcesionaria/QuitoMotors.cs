using AbstractFactoryConcesionaria.Productos;
using AbstractFactoryConcesionaria.Ford;

namespace AbstractFactoryConcesionaria
{
    public class QuitoMotors : IConcesionaria
    {
        public Auto CrearAuto(string datosAuto)
        {
            return new FordAuto(datosAuto);
        }

        public Chasis CrearChasis(string datosChasis)
        {
            return new FordChasis(datosChasis);
        }

        public Motor CrearMotor(string datosMotor)
        {
            return new FordMotor(datosMotor);
        }
    }
}

