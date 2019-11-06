using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cowsay_cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandManager cm = new CommandManager();
            cm.Sprejem(args);
        }
    }
}
