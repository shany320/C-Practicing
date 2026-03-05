using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_Assignment03.Part02.Q3
{
    class Email_Notification_Service : Inotification_service
    {
        public void Send_notification(string recipient, string message)
        {
            Console.WriteLine($"This Mail to {recipient} : {message}");
        }
    }
    class SMS_Notification_Service : Inotification_service
    {
        public void Send_notification(string recipient, string message)
        {
            Console.WriteLine($"This SMS to {recipient} : {message}");
        }
    }
    class Push_Notification_Service : Inotification_service
    {
        public void Send_notification(string recipient, string message)
        {
            Console.WriteLine($"This Message to {recipient} : {message}");
        }
    }
}
