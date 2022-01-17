using Bridge.Bridge;
using System;

namespace Bridge.ImplementationClass
{
    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"MSMQ\n{subject}\n{body}\n");
        }
    }
}
