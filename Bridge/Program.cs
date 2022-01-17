using Bridge.Abstraction;
using Bridge.Bridge;
using Bridge.ImplementationClass;
using Bridge.RedefinedAbstraction;
using System;

namespace Bridge
{
    class Program
    {
        static void Main()
        {
            IMessageSender email = new EmailSender();
            IMessageSender queue = new MSMQSender();
            IMessageSender web = new WebServiceSender();

            Message message = new SystemMessage();
            message.Subject = "Mensagem teste";
            message.Body = "Olá, essa é uma mensagem de teste";

            message.MessageSender = email;
            message.Send();

            message.MessageSender = queue;
            message.Send();

            message.MessageSender = web;
            message.Send();

            UserMessage usermsg = new();
            usermsg.Subject = "Mensagem teste";
            usermsg.Body = "Olá, essa é uma mensagem de teste";
            usermsg.UserComments = "Espero que todos consigam fazer o exemplo";

            usermsg.MessageSender = email;
            usermsg.Send();

            Console.ReadKey();
        }
    }
}
