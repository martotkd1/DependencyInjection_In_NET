using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_In_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Exclaim("Hello DI!");

            IMessageWriter writer2 = new SecureMessageWriter(new ConsoleMessageWriter());
            var salutation2 = new Salutation(writer2);
            salutation2.Exclaim("Hello Secured DI!");

            Console.ReadLine();
        }
    }
}
