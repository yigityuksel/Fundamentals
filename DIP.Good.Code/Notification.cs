using System.Collections.Generic;
using DIP.Good.Code.Interfaces;

namespace DIP.Good.Code
{
    public class Notification
    {

        /// <summary>
        /// so in here, we do not depend on concrete classes, we depend on abstractions(IMessage Interface).
        /// </summary>

        private ICollection<IMessage> _messages;

        public Notification(ICollection<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }

    }
}