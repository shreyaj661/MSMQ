using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MSMQ
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Latest Message");

            MessageQueue MyQueue;
            if (MessageQueue.Exists(@".\Private$\MyQueue"))
            {
                MyQueue = new MessageQueue(@".\Private$\MyQueue");
                Message MyMessage = MyQueue.Receive();
                // Set FOrmatter for Messge

                MyMessage.Formatter = new BinaryMessageFormatter();
                Console.WriteLine(MyMessage.Body.ToString());
                Console.Read();
            }
        }
    }

}
