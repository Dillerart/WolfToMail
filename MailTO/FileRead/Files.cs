namespace MailTO.FileRead
{
    class Files
    {
        private const string sectionClient = "Client";

        private const string smtpServer = "SMTP";

        private const string mailSRV = "MAIL";

        private const string passSRV = "PASS";

        private const string portSRV = "PORT";

        private const string sectionMailTo = "MailTo";

        private const string mailToS = "Mail";

        private const string subjectS = "Subject";

        private const string fileIni = @".\Mail.ini";

        private const string pathToFile = "PATH";

        private static string nameFile = "MailLogFile.log";



        public static string SectionClient
        {
            get
            {
                return sectionClient;
            }
        }

        public static string SmtpServer
        {
            get
            {
                return smtpServer;
            }
        }

        public static string MailSRV
        {
            get
            {
                return mailSRV;
            }
        }

        public static string PassSRV
        {
            get
            {
                return passSRV;
            }
        }

        public static string PortSRV
        {
            get
            {
                return portSRV;
            }
        }

        public static string SectionMailTo
        {
            get
            {
                return sectionMailTo;
            }
        }

        public static string MailToS
        {
            get
            {
                return mailToS;
            }
        }

        public static string SubjectS
        {
            get
            {
                return subjectS;
            }
        }

        public static string FileIni
        {
            get
            {
                return fileIni;
            }
        }
      

        public static string PathToFile
        {
            get
            {
                return pathToFile;
            }
        }

        public static string NameFile
        {
            get
            {
                return nameFile;
            }

            set
            {
                nameFile = value;
            }
        }
    }
}
