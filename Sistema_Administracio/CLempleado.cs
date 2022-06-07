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
            auxiliar=1,
            ingeniero=2,
            administrativo=3,
            especialista=4,
            investigador=5
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
        public CLempleado(string aNombre, string aApellido, DateTime aFechaNacimiento, double aSueldoBasico,DateTime aFechaIngreso, char aEstadoCivil, cargos aCargo,char aGenero)
        {
            nombre = aNombre;
            apellido = aApellido;
            fechaNacimiento=aFechaNacimiento;
            sueldoBasico = aSueldoBasico;
            fechaIngreso=aFechaIngreso;
            estadoCivil=aEstadoCivil;
            cargo=aCargo;
            genero = aGenero;

        }
        public int Antiguedad()
        {
            int year;
            if  (fechaIngreso.Month>=DateTime.Now.Month)
            {
                year = DateTime.Now.Year - fechaIngreso.Year;
            } else
            {
                year = DateTime.Now.Year - fechaIngreso.Year  - 1;
            }
            return year;
        }
        public int Edad ()
        {
            int aux;
            if (fechaNacimiento.Month>= DateTime.Now.Month)
            {
                aux= DateTime.Now.Year - fechaNacimiento.Year;
            }
            else
            {
                    aux= DateTime.Now.Year - fechaNacimiento.Year -1;
            }
            return aux;
        }
        public int Jubilacion()
        {
            int restantes = 0;
            if (genero == 'F' || genero == 'f')
            {
                restantes = 60 - Edad();
            }
            else
            {
                if (genero == 'M' || genero == 'm')
                {
                    restantes = 65 - Edad();
                }
                else
                {
                    Console.WriteLine("Genero indicado incorrectamente");
                }
            }
            return restantes;
        }
        public double SalarioTotal()
        {
            double extra = 0;
            if (Antiguedad() <=20)
            {
                extra += Antiguedad() *0.1f * sueldoBasico;

            }else if (Antiguedad() >20)
            {
                extra += SueldoBasico * 0.25f;            }

            if (Cargo == cargos.ingeniero || Cargo == cargos.especialista)
            {
                extra += sueldoBasico * 0.5f;
            }

            if (estadoCivil == 'C')
            {
                extra += 15000;
            }
            return sueldoBasico + extra;
        }
        }
    }

