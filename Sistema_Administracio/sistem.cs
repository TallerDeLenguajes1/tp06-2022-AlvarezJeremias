using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema
{
    public class empleado
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private char genero;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        public enum cargos {
            auxiliar,
            ingeniero,
            administrativo,
            especialista,
            investigador,

        }
        private cargos cargo;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;

        }
        public string Apellido
        {
            get => apellido;
            set=> apellido = value;
        }
        public DateTime FechaNacimiento
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public char Genero
        {
            get => genero;
            set => genero = value;
        }
        public double SueldoBasico
        {
            get => sueldoBasico; set => sueldoBasico = value;
        }
        public DateTime FechaIngreso
        {
            get => fechaIngreso; set => fechaIngreso = value;
        }
        public char EstadoCivil
        {
            get => estadoCivil; set => estadoCivil = value;
        }
        public cargos Cargo
        {
            get=>cargo;
            set=>cargo=value;
        }
        public void constructor ()
        {
            Nombre = "";
            Apellido = "";
            FechaNacimiento =new DateTime();
            Genero = 'm';
            SueldoBasico = 0;
            FechaIngreso = new DateTime();
            EstadoCivil = 'S';
        }
        public int Antiguedad()
        {
            int year = DateTime.Now.Year-FechaIngreso.Year;
            return year;
        }
        public int Edad ()
        {
            int aux = DateTime.Now.Year-FechaNacimiento.Year;
            return aux;
        }
        public int Jubilacion()
        {
            int restantes = 0;
            if (Genero == 'M' || Genero == 'm')
            {
                restantes = 60 - Edad();
            }
            else
            {
                if (Genero == 'H' || Genero == 'h')
                {
                    restantes = 65 - Edad();
                }
            }
            return restantes;
        }
        }
    }

