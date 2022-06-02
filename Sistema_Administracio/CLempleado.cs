using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema
{
    public class CLempleado
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
        public CLempleado(string aNombre, string aApellido, DateTime aFechaNacimiento, double aSueldoBasico,DateTime aFechaIngreso, char aEstadoCivil, cargos aCargo)
        {
            nombre = aNombre;
            apellido = aApellido;
            fechaNacimiento=aFechaNacimiento;
            sueldoBasico = aSueldoBasico;
            fechaIngreso=aFechaIngreso;
            estadoCivil=aEstadoCivil;
            cargo=aCargo;

        }
        public int Antiguedad()
        {
            int year = DateTime.Now.Year-fechaIngreso.Year;
            return year;
        }
        public int Edad ()
        {
            int aux = DateTime.Now.Year-fechaNacimiento.Year;
            return aux;
        }
        public int Jubilacion()
        {
            int restantes = 0;
            if (genero == 'M' || genero == 'm')
            {
                restantes = 60 - Edad();
            }
            else
            {
                if (genero == 'H' || genero == 'h')
                {
                    restantes = 65 - Edad();
                }
            }
            return restantes;
        }
        }
    }

