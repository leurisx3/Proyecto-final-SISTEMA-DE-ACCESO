using System;
using System.Collections.Generic;

namespace Proyecto_final_sistema_de_acceso
{
    class Program
    {
        static void Main(string[] args)
        {
            //USUARIO 1

            string primerUsuario = "123-1234567-1";
            string nombrePrimerUsuario = "Jose";
            int clavePrimerUsuario = 1234;
            var fechaDeCreacionUsuario1 = new DateTime(2000, 3, 1);
            var estadoPrimerUsuario = "inactivo";

            //USUARIO 2

            string segundoUsuario = "234-2345678-2";
            string nombreSegundoUsuario = "Enrique";
            int claveSegundoUsuario = 2345;
            var fechaDeCreacionUsuario2 = new DateTime(2015, 5, 4);
            var estadoSegundoUsuario = "activo";
            
            //USUARIO 3

            string tercerUsuario = "345-3456789-3";
            string nombreTercerUsuario = "Pedro";
            int claveTercerUsuario= 3456;
            var fechaDeCreacionUsuario3 = new DateTime(2010, 10, 5);
            var estadoTercerUsuario = "activo";

            //Creando variable para autenticar

            bool comprobandoAutenticacion = false;

            //ASIGNANDO EL ROL CON EL QUE SE DESEA INICIAR EL USUARIO

            Console.WriteLine("SUPERVISOR = (s), ADMINISTRADOR = (a), VENDEDOR = (v)");
            Console.Write("Que rol desea utilizar? ");
            char rolParaUsuario = Convert.ToChar(Console.ReadLine());

            //VALIDANDO QUE LA CLAVE ES CORRECTA
        
            switch (rolParaUsuario)
            {
                case 's':
                    do
                    {
                        string usuario = IntroduzcaUsuario("");
                        int clave = IntroduzcaClave(0);

                        if (usuario == primerUsuario && clave == clavePrimerUsuario)
                        {
                            comprobandoAutenticacion = false;
                            AvisoBienvenido(nombrePrimerUsuario, "Supervisor. Pero este usuario esta inactivo, intente otro usuario");
                        }

                        else if (usuario == segundoUsuario && clave == claveSegundoUsuario)
                        {
                          comprobandoAutenticacion = true;
                          AvisoBienvenido(nombreSegundoUsuario, "Supervisor");
                        }

                        else if (usuario == tercerUsuario && clave == claveTercerUsuario)
                        {
                            comprobandoAutenticacion = true;
                            AvisoBienvenido(nombreTercerUsuario, "Supervisor");
                        }

                        else
                        {
                           comprobandoAutenticacion = false;
                           AvisoAutenticacionErronea();
                        }  

                    } while (comprobandoAutenticacion == false);
                    break;

                case 'a':
                    do
                    {
                       string usuario = IntroduzcaUsuario("");
                       int clave = IntroduzcaClave(0);

                        if (usuario == primerUsuario && clave == clavePrimerUsuario)
                        {
                            comprobandoAutenticacion = false;
                            AvisoBienvenido(nombrePrimerUsuario, "Administrador. Pero este usuario esta inactivo, intente otro usuario");
                        }

                        else if (usuario == segundoUsuario && clave == claveSegundoUsuario)
                        {
                            comprobandoAutenticacion = true;
                            AvisoBienvenido(nombreSegundoUsuario, "Administrador");
                        }

                        else if (usuario == tercerUsuario && clave == claveTercerUsuario)
                        {
                            comprobandoAutenticacion = true;
                            AvisoBienvenido(nombreTercerUsuario, "Administrador");
                        }

                        else
                        {
                            comprobandoAutenticacion = false;
                            AvisoAutenticacionErronea();
                        }

                    } while (comprobandoAutenticacion == false);
                    break;

                case 'v':
                    do
                    {
                       string usuario = IntroduzcaUsuario("");
                       int clave = IntroduzcaClave(0);

                        if (usuario == primerUsuario && clave == clavePrimerUsuario)
                        {
                            comprobandoAutenticacion = false;
                            AvisoBienvenido(nombrePrimerUsuario, "Vendedor. Pero este usuario esta inactivo, intente otro usuario");
                        }

                        else if (usuario == segundoUsuario && clave == claveSegundoUsuario)
                        {
                            comprobandoAutenticacion = true;
                            AvisoBienvenido(nombreSegundoUsuario, "Vendedor");
                        }

                        else if (usuario == tercerUsuario && clave == claveTercerUsuario)
                        {
                            comprobandoAutenticacion = true;
                            AvisoBienvenido(nombreTercerUsuario, "Vendedor");
                        }

                        else
                        {
                            comprobandoAutenticacion = false;
                            AvisoAutenticacionErronea();
                        }

                    } while (comprobandoAutenticacion == false);
                    break;
            }

            static string IntroduzcaUsuario(string user)
            {
                Console.Write("Ingresar cuenta usuario: ");
                return user = Console.ReadLine();
            }

            static int IntroduzcaClave(int password)
            {
                Console.Write("Ingresar clave del usuario: ");
                return password = Convert.ToInt32(Console.ReadLine());
            }

            static void AvisoAutenticacionErronea()
            {
                Console.WriteLine("USUARIO O CLAVE INCORRECTA, FAVOR INTRODUCIR NUEVAMENTE.");
            }

            static void AvisoBienvenido(string u, string r)
            {
                Console.WriteLine($"Acabas de ingresar con el usuario {u} y su rol es {r}");
            }
        }
    }
}