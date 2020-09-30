using System;

namespace DPRN2_U1_A2_JACC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capturar datos del empleado
            //nimero de empleado...
            Console.WriteLine("Ingrese numero de empleado: ");
            var numeroDeEmpleado = 358794;

            //Nombre del empleado...
            Console.Write("Ingrese el nombre: ");
            var nombreEmpleado = "Javier Castorena";

            //Numero telefonico del empleado...
            Console.WriteLine("Ingrese numero de telefono: ");
            ulong numeroTelefonico = 6864584892;

            //Correo electronico...
            Console.Write("Ingrese el correo electronico: ");
            var correoElectronico = "Javier.castorena@reconext.com";

            //Salario Mensual...
            Console.Write("Ingrese el salario mensual: ");
            var salarioMensualEmpleado = 0;

            //Bono mensual...
            Console.Write("Ingrese el bono mensual: ");
            var bonoMensual = 0;

            //Crear nuevo empleado con los datos capturardos.
            Empleado empl = new Empleado();
            empl.setNumEmpleado(numeroDeEmpleado);
            empl.setNombre(nombreEmpleado);
            empl.setNumTelefonico(numeroTelefonico);
            empl.setCorreoElectronico(correoElectronico);
            empl.setSalarioMensual(salarioMensualEmpleado);
            empl.setBonoMensual(bonoMensual);

            mostrarEmpleado(empl);

        }
        //Mostrar los datos del empleado y el menu de administracion...
        static void mostrarEmpleado(Empleado empl)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Administar empleado\n");
                Console.WriteLine("Numero de empleado: " + empl.getNumEmpleado());
                Console.WriteLine("Nombre: " + empl.getNombre());
                Console.WriteLine("Numero telefonico; " + empl.getNumTelefonico());
                Console.WriteLine("Correo electronico: " + empl.getCorreoElectronico());
                Console.WriteLine("Sueldo mensual: $" + empl.getSalarioMensual());
                Console.WriteLine("Bono mensual: $" + empl.getBonoMensual());
                Console.WriteLine("\n Menu. \n q.- Asignar salario mensual: \n a.- Asignar bono mensual \n z.- Aumentar salario 10% \n x.- Salir. ");

                try
                {
                    var opt = Console.ReadKey();

                    switch (opt.KeyChar)
                    {
                        case 'q':
                            empl.asignarSalarioMensual();
                            break;
                        case 'a':
                            empl.asignarBonoMensual();
                            break;
                        case 'z':
                            Console.WriteLine("\n");
                            empl.AumentarSalarioEn10();
                            break;
                        case 'x':
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\nOpcion invalida!");
                            break;
                    }

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    Console.WriteLine("Opcion invalida!!");
                }

            }
        }
    }


    class Empleado
    {
        private int NumEmpleado;
        private string Nombre;
        private ulong NumTelefonico;
        private string CorreoElectronico;
        private double SalarioMensual;
        private double BonoMensual;

        public Empleado()
        {

        }

        //constructores polimorficos
        public Empleado(int NumeroEmpleado)
        {
            this.NumEmpleado = NumeroEmpleado;
        }

        public Empleado(int NumeroEmpleado, string Nombre)
        {
            this.NumEmpleado = NumeroEmpleado;
            this.NumEmpleado = NumeroEmpleado;
        }

        public Empleado(int NumeroEmpleado, string Nombre, uint NumeroTelefono)
        {
            this.NumEmpleado = NumeroEmpleado;
            this.NumEmpleado = NumeroEmpleado;
            this.NumTelefonico = NumeroTelefono;
        }

        //set
        public void setNumEmpleado(int _NumEmpleado)
        {
            this.NumEmpleado = _NumEmpleado;
        }

        public void setNombre(string _Nombre)
        {
            this.Nombre = _Nombre;
        }

        public void setNumTelefonico(ulong _NumTelefonico)
        {
            this.NumTelefonico = _NumTelefonico;
        }

        public void setCorreoElectronico(string _CorreoElectronico)
        {
            this.CorreoElectronico = _CorreoElectronico;
        }

        public void setSalarioMensual(double _SalarioMensual)
        {
            this.SalarioMensual = _SalarioMensual;
        }
        public void setBonoMensual(double _BonoMensual)
        {
            this.BonoMensual = _BonoMensual;
        }

        //get
        public int getNumEmpleado()
        {
            return NumEmpleado;
        }

        public string getNombre()
        {
            return Nombre;
        }

        public ulong getNumTelefonico()
        {
            return NumTelefonico;
        }

        public string getCorreoElectronico()
        {
            return CorreoElectronico;
        }

        public double getSalarioMensual()
        {
            return SalarioMensual;
        }

        public double getBonoMensual()
        {
            return BonoMensual;
        }

        //metodo asignar salario mensual
        public void asignarSalarioMensual()
        {
            Console.Write("\nIngrese cantidad: ");
            this.SalarioMensual = Convert.ToDouble(Console.ReadLine());
            if (SalarioMensual <= 0)
            {
                this.SalarioMensual = 0;
            }
            Console.WriteLine("Salario mensual asignado!");
        }

        //aumentar salario en 10%
        public void AumentarSalarioEn10()
        {
            double aumento = SalarioMensual * .10;
            Console.WriteLine("El Salario mensual actualemente de {0} es de {1}", Nombre, SalarioMensual);
            this.SalarioMensual += aumento;
            Console.WriteLine("Al salario de {0} se le aplico un aumento de {1} y ahora su salario mensual es de {2}", Nombre, aumento, SalarioMensual);
        }

        //Asignar bono.
        public void asignarBonoMensual()
        {
            Console.Write("\nIngese Cantidad del bono: ");
            this.BonoMensual = Convert.ToDouble(Console.ReadLine());
            if (this.BonoMensual < 0)
            {
                this.BonoMensual = 0;
            }
        }


    }
}
