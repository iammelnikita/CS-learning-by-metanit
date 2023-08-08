using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyLib
{
    public class PublicState
    {
        internal void PrintInternal() => Console.WriteLine("internal");
        protected internal void PrintProtectedInternal() => Console.WriteLine("protected internal");
        public void PrintPublic() => Console.WriteLine("public");
    }

    class DefaultState { } //default - internal

    internal class  InternalState { }
}
