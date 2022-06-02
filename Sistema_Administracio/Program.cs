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
        Console.Write("Genero: ");
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
        DateTime auxFechaNacimiento = new DateTime (anoNacimiento-mesNacimiento-diaNacimiento);
        Console.WriteLine("Siguiente, especifique la fecha de ingreso a la empresa: ");
        Console.Write("Dia: ");
        int diaIngreso = Convert.ToInt32(Console.ReadLine());
        Console.Write("Mes: ");
        int mesIngreso = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ano: ");
        int anoIngreso = Convert.ToInt32(Console.ReadLine());
        DateTime auxFechaIngreso = new DateTime(anoIngreso - mesIngreso - diaIngreso);
        Console.WriteLine("Por ultimo, ingrese el cargo que ocupa el empleado: ");
        Console.WriteLine("1) AUXILIAR");
        Console.WriteLine("2) INGENIERO");
        Console.WriteLine("3) ADMINISTRATIVO");
        Console.WriteLine("4) ESPECIALISTA");
        Console.WriteLine("5) INVESTIGADOR");
        sistema.CLempleado.cargos auxCargo = CLempleado.cargos.(Convert.ToInt32(Console.ReadLine());
        

        CLempleado empleado1 = new CLempleado(auxNombre,auxApellido,auxFechaNacimiento,auxSueldo,auxFechaIngreso,auxEstadoCivil,auxCargo);

    }
}