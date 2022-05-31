using Calculadora;

public class PrimerEjercicio
{
    public static void Main ()
    {
        int operacion;
        char opcion='y';
        double resultado;
        calcu calculo = new calcu();
        do
        {
            do
            {
                Console.WriteLine("Seleccione un tipo de operacion: ");
                Console.WriteLine("1) SUMA");
                Console.WriteLine("2) RESTA");
                Console.WriteLine("3) MULTIPLICACION");
                Console.WriteLine("4) DIVISION");
                operacion = Convert.ToInt32(Console.ReadLine());
            } while (operacion < 0 && operacion > 5);

            Console.Write("Escriba el primer numero ");
            calculo.firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Escriba el segundo numero: ");
            calculo.secondNumber= Convert.ToDouble(Console.ReadLine());

            switch (operacion)
            {
                case 1:
                    resultado = calculo.suma();
                    Console.WriteLine($"El resultado es: {resultado}");
                    break;
                case 2:
                    resultado = calculo.resta();
                    Console.WriteLine($"El resultado es: {resultado}");
                    break;
                case 3:
                    resultado = calculo.producto();
                    Console.WriteLine($"El resultado es:  {resultado}");
                    break;
                case 4: 
                    if (calculo.secondNumber!=0)
                    {
                        resultado = calculo.division();
                        Console.WriteLine($"El resultado es: {resultado}");
                        
                    }else
                    {
                        resultado = 0;
                        Console.WriteLine("No se puede dividir en 0");
                    }
                    break;
            }
            calculo.firstNumber = calculo.Limpiar();
            calculo.secondNumber = calculo.Limpiar();
            resultado = calculo.Limpiar();
            Console.WriteLine("Desea seguir usando la calculadora? [Y/N]");
            opcion = Convert.ToChar(Console.ReadLine());
        } while (opcion== 'Y' || opcion== 'y');
    }
}