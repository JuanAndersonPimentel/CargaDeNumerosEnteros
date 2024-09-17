

namespace CargaDeNumerosEnteros
{
    public class CargaDeNumeros
    {
        public void calcular()
        //declarar variables
        {
            int num1 = 0;
            int num2 = 0;
            int producto = 0;
            int suma = 0;
            string linea = string.Empty;

            try
            {
                //pedir los numeros por teclado
                Console.WriteLine("ingrese el valor del num1: ");
                linea = Console.ReadLine();


                //Validar el tipo de datos
                if (!int.TryParse(linea, out num1))
                {
                    Console.WriteLine("el num1 es invalido.");
                    return;
                }

                Console.WriteLine("ingrese el valor del num2: ");
                linea = Console.ReadLine();

                if (!int.TryParse(linea, out num2))
                {
                    Console.WriteLine("el num2 es invalido.");
                    return;
                }


                suma = (num1 + num2);
                producto = (num1 * num2);

                Console.WriteLine($"la suma es:  {suma} y el producto es: {producto}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ocurrio el siguiente error: {ex.Message} realizando operacion");
            }
        }
    }
}
