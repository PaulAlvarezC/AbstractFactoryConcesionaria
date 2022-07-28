using AbstractFactoryConcesionaria.Productos;

namespace AbstractFactoryConcesionaria
{
    public class Aplicacion
    {
        IConcesionaria concesionaria;
        List<IProductos> listaProductos;

        public Aplicacion(IConcesionaria concesionaria) {
            this.concesionaria = concesionaria;
            listaProductos = new List<IProductos>();
        }

        public void CrearModelo() {
            Chasis chasis = concesionaria.CrearChasis("13DR23FE34");
            Motor motor = concesionaria.CrearMotor("V8");
            Auto auto = concesionaria.CrearAuto("SUV");

            listaProductos.Add(chasis);
            listaProductos.Add(motor);
            listaProductos.Add(auto);
        }

        public void Ensamblar() {
            string datos = "";
            foreach (var obj in listaProductos) {
                datos += obj.Ensamblar();
            }

            Console.WriteLine(datos);
        }
    }
}

