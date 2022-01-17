using Bridge.Abstraction;

namespace Bridge.RedefinedAbstraction
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
