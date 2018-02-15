namespace DIP.Bad.Code
{
    public class Notification
    {

        /// <summary>
        /// As we see here, high-level class (which sends notification), has dependend on low level classes (Email - SMS). 
        /// In other way, high-level class depends on low level concrete classes(implemented classs).
        /// </summary>

        private Email _email;
        private SMS _sms;
        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}