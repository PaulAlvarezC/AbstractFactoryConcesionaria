namespace AbstractFactoryConcesionaria
{
    public class Programa
    {
        static void Main(string[] args)
        {
            Aplicacion vallejoAraujo = new Aplicacion(new VallejoAraujo());
            vallejoAraujo.CrearModelo();
            vallejoAraujo.Ensamblar();

            Aplicacion quitoMotors = new Aplicacion(new QuitoMotors());
            quitoMotors.CrearModelo();
            quitoMotors.Ensamblar();
        }
    }
}