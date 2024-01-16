namespace ejercicio3.repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribame cuanto pesa el saco, dimelo con un numero entero");
            int numeroEntero = Convert.ToInt32(Console.ReadLine());

            int capacidadMaxima = 4000;
            
            int numeroDeSacos = capacidadMaxima / numeroEntero ;

            Console.WriteLine("El numero de sacos que puede cargar el camion es: " + numeroDeSacos);

        }
    }
}