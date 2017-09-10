using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DI_In_NET
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
