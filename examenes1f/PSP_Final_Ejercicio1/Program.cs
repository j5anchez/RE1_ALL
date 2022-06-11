/*


The task can return a result. There is no direct mechanism to return the result from a thread.
    
    
*/


using System;
using System.Threading; // Necesario para utilizar thread.sleep
using System.Net.Mail;
using System.Net;
using MailKit.Net;

namespace tareas
{
    public class Tareas1
    {
        public static void Main(string[] args)
        {
            EstanteriaRefrescos Refrescos = new EstanteriaRefrescos(50);

        }

        class EstanteriaRefrescos
        {
            double Stock { get; set; } // campo de clase para poder acceder a sus valores.
            private Object bloqueaAlmacen = new Object(); //Objeto creado y necesario para el bloqueo
            public bool almacenlleno = false;
            public EstanteriaRefrescos(double Stock) //Creamos el constructor de la clase en la que se establece un stock del almacén.
            {
                this.Stock = Stock;
            }

            public double RetirarProducto(double cantidad, string sabor) // método con el que el fendwich retirará el producto
            {

                //RetirarProductoA COMPLETAR************************************************************************************************************

                return 2.3;
            }

            public void SendMail(string toEmail, string mensaje, string reponedor)
            {
                //Envío de email A COMPLETAR**************************************************************************************************************

            }
        }
    }
}

      /*      static Object obj = new Object();

        public static void Main()
        {
            ThreadPool.QueueUserWorkItem(ShowThreadInformation);
            var th1 = new Thread(ShowThreadInformation);
            th1.Start();
            var th2 = new Thread(ShowThreadInformation);
            th2.IsBackground = true;
            th2.Start();
            Thread.Sleep(5000);
            ShowThreadInformation(null);
            Console.ReadKey();
        }

        private static void ShowThreadInformation(Object state)
        {
            lock (obj)
            {
                var th = Thread.CurrentThread;
                Console.WriteLine("Managed thread #{0}: ", th.ManagedThreadId);
                Console.WriteLine("   Background thread: {0}", th.IsBackground);
                Console.WriteLine("   Thread pool thread: {0}", th.IsThreadPoolThread);
                Console.WriteLine("   Priority: {0}", th.Priority);
                Console.WriteLine("   Culture: {0}", th.CurrentCulture.Name);
                Console.WriteLine("   UI culture: {0}", th.CurrentUICulture.Name);
                Console.WriteLine();
            }
        }
    }
}
    // The example displays output like the following:
    //       Managed thread #6:
    //          Background thread: True
    //          Thread pool thread: False
    //          Priority: Normal
    //          Culture: en-US
    //          UI culture: en-US
    //       
    //       Managed thread #3:
    //          Background thread: True
    //          Thread pool thread: True
    //          Priority: Normal
    //          Culture: en-US
    //          UI culture: en-US
    //       
    //       Managed thread #4:
    //          Background thread: False
    //          Thread pool thread: False
    //          Priority: Normal
    //          Culture: en-US
    //          UI culture: en-US
    //       
    //       Managed thread #1:
    //          Background thread: False
    //          Thread pool thread: False
    //          Priority: Normal
    //          Culture: en-US
    //          UI culture: en-US
    
    

    

    internal sealed class Foo
    {
        private Object bar = null;

        private void CreateBarOnNewThread()
        {
            var thread = new Thread(this.CreateBar);

            thread.Start();

            // Do other stuff while the new thread
            // creates our bar.
            Console.WriteLine("Doing crazy stuff.");

            // Wait for the other thread to finish.
            thread.Join();

            // Use this.bar here...
        }

        private void CreateBar()
        {
            // Creating a bar takes a long time.
            Thread.Sleep(1000);

            this.bar = new Object();
        }
    }*/

