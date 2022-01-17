using Bridge.Bridge;
using System;

namespace Bridge.ImplementationClass
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Email\n{subject}\n{body}\n");
        }
    }
}
