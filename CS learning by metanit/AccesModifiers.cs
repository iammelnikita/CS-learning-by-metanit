using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using MyLib;

namespace CS_learning_by_metanit
{
    internal class AccessModifiers
    {
        class StateConsumer
        {
            public void PrintState()
            {
                { 
                    /*DefaultState defaultState = new DefaultState(); //error, because default internal
                    InternalState intetnalState = new InternalState(); //internal*/

                    PublicState publicState = new MyLib.PublicState();
                    /*publicState.PrintEnternal(); //error, because internal
                    publicState.PrintProtectedInternal(); //such problem*/
                    publicState.PrintPublic();

                } //classes and methods

                { 
                    State state = new State();

                    /*Console.WriteLine(state.defaultVar); //error, because default it has private modifiers
                    Console.WriteLine(state.privateVar);

                    Console.WriteLine(state.protectedPrivateVar); //error, because AccessModifiers class isn't descended of State class

                    Console.WriteLine(state.protectedVar); //error, because AccessModifiers class isn't descended of State class*/

                    Console.WriteLine(state.internalVar); //available from anywhere in this project

                    Console.WriteLine(state.protectedInternalVar); // available from anywhere in this project also

                    Console.WriteLine(state.publicVar);

                    Console.WriteLine("Methods");

                    /*state.Print();
                    state.PrintPrivate();
                    state.PrintProtectedPrivate();
                    state.PrintProtected();*/

                    state.PrintInternal();
                    state.PrintProtectedInternal();
                    state.PrintPublic();
                } //examples values
            }
        }

        class State //default has internal modifier
        {
            string defaultVar = "default"; //private
            private string privateVar = "private"; //available only from current class

            protected private string protectedPrivateVar = "protectedPrivate"; //available from current class and from derived classes in this project

            protected string protectedVar = "protected"; //available from this class and derived classes

            internal string internalVar = "internal"; //available anywhere in this project

            protected internal string protectedInternalVar = "protectedInternal"; //available anywhere in this project and from descended classes

            public string publicVar = "public"; //available anywhere in this program and for another programs and assemblies

            void Print() => Console.WriteLine(defaultVar); //default has private modifier
            private void PrintPrivate() => Console.WriteLine(privateVar); //available only from current class


            protected private void PrintProtectedPrivate() => Console.WriteLine(protectedPrivateVar);

            protected void PrintProtected() => Console.WriteLine(protectedVar);

            internal void PrintInternal() => Console.WriteLine(internalVar);

            protected internal void PrintProtectedInternal() => Console.WriteLine(protectedInternalVar);

            public void PrintPublic() => Console.WriteLine(publicVar);
        }
    }
}
