using MailTO.FileRead;
using MailTO;
using System;

namespace MailTO
{
    class Program
    {
        private static ReadFile read = new ReadFile();
        private static MailTo mail = new MailTo();
        static void Main(string[] args)
        {
            mail.mailCreate(read.SmtpServerR, read.MailServerR, read.PassServerR, read.MailToServerR, read.SubjecServertR, 
                            read.MessageString, read.PortServerR, read.FilePathForDelete);
        }
    }
}
