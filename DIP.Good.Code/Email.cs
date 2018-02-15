using DIP.Good.Code.Interfaces;

namespace DIP.Good.Code
{
    public class Email : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            throw new System.NotImplementedException();
        }
    }
}