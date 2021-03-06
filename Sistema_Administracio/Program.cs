using System;
using sistema;

public class SegundoEjercicio
{
    public static void Main()
    {
        Console.WriteLine("-----Sistema de administracion de empleados-----");
        Console.WriteLine("Introduzca los datos del primer empleado a continuacion");
        Console.Write("Nombre: ");
        string auxNombre = Console.ReadLine();
        Console.Write("Apellido: ");
        string auxApellido = Console.ReadLine();
        Console.Write("Estado Civil [S/C/D/V] (Solter@/Casad@/Divorciad@/Viud@]: ");
        char auxEstadoCivil = Convert.ToChar(Console.ReadLine());
        Console.Write("Genero [M/F]: ");
        char auxGenero = Convert.ToChar(Console.ReadLine());
        Console.Write("Sueldo Basico: ");
        double auxSueldo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ahora especifique la fecha de Nacimiento: ");
        Console.Write("Dia: ");
        int diaNacimiento = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mes: ");
        int mesNacimiento = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ano: ");
        int anoNacimiento = Convert.ToInt32(Console.ReadLine());
        DateTime auxFechaNacimiento = new DateTime (anoNacimiento,mesNacimiento,diaNacimiento);
        Console.WriteLine("Siguiente, especifique la fecha de ingreso a la empresa: ");
        Console.Write("Dia: ");
        int diaIngreso = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mes: ");
        int mesIngreso = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ano: ");
        int anoIngreso = Convert.ToInt32(Console.ReadLine());
        DateTime auxFechaIngreso = new DateTime(anoIngreso , mesIngreso , diaIngreso);
        Console.WriteLine("Por ultimo, ingrese el cargo que ocupa el empleado: ");
        Console.WriteLine("1) AUXILIAR");
        Console.WriteLine("2) INGENIERO");
        Console.WriteLine("3) ADMINISTRATIVO");
        Console.WriteLine("4) ESPECIALISTA");
        Console.WriteLine("5) INVESTIGADOR");
        int aux = Convert.ToInt32(Console.ReadLine());
        CLempleado.cargos auxCargo;
        switch (aux) {
            case 1:
                auxCargo = CLempleado.cargos.auxiliar;
                break;
            case 2:
                auxCargo = CLempleado.cargos.ingeniero;
                break;
            case 3:
                auxCargo = CLempleado.cargos.administrativo;
                break;
            case 4:
                auxCargo = CLempleado.cargos.especialista;
                break;
            case 5:
                auxCargo = CLempleado.cargos.investigador;
                break;
                default: auxCargo = CLempleado.cargos.auxiliar;
                break;
        }
        

        CLempleado empleado1 = new CLempleado(auxNombre,auxApellido,auxFechaNacimiento,auxSueldo,auxFechaIngreso,auxEstadoCivil,auxCargo,auxGenero);
        int antiguedad = empleado1.Antiguedad();
        Console.WriteLine($"Años de antiguedad : {antiguedad}");
        int restan = empleado1.Jubilacion();
        Console.WriteLine($"Años restantes para la jubilacion:  {restan}");
        double salario = Math.Round(empleado1.SalarioTotal());
        Console.WriteLine($"Salario total del empleado: {salario}");
    }
}