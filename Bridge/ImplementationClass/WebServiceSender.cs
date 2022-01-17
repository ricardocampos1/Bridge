using Bridge.Bridge;
using System;

namespace Bridge.ImplementationClass
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Web Service\n{subject}\n{body}\n");
        }
    }
}
