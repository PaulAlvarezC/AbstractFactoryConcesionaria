using AbstractFactoryConcesionaria.Productos;

namespace AbstractFactoryConcesionaria
{
    public interface IConcesionaria
    {
        public Auto CrearAuto(string datosAuto);
        public Chasis CrearChasis(string datosChasis);
        public Motor CrearMotor(string datosMotor);
    }
}

