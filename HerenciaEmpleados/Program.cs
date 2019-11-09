using System;

namespace HerenciaEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa!");
            Empleado Israel = new Empleado("Israel");
            Israel.Salario=500.50;
            var nombre = Israel.getNombre();
            Console.WriteLine("El salario del empleado "+nombre+" es: "+Israel.Salario);
        }
    }

    class Empleado
    {
        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return nombre;
        }

        private double evaluarSalario(double salario)
        {
            if (salario < 0) return 0;
            else return salario;
        }

        //creacion de propiedad
        public double Salario
        {

            get { return this.salario; }
            set { this.salario = evaluarSalario(value); }

        }

        public void setSalario(double salario)
        {

        }



        private string nombre;
        private double salario;
    }
}
