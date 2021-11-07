using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1.Entidades
{
    public class Controlador
    {
        public static List<Cliente> ValidarLista(List<Cliente> cli)
        {


            if (cli.Any())
            {
               return cli;
            }
           
            return null;

        } 
        }
}
