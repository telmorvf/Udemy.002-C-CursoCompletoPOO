namespace _047._2_Classe_MembrosInstancia
{
    class Calculadora
    {
        public double Pi = 3.14;

        public double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
