using System.IO;
using System;

namespace MailTO.FileRead
{
    class ReadFile:Files
    {
        //переменные для отправки данных на сервер
        private string smtpServerR;

        private string mailServerR;

        private string passServerR;

        private int portServerR;        

        private string mailToServerR;

        private string subjecServertR;

        //переменная пути к лог файлу
        private string pathR;
        //переменная пути для удаления лог файла
        private string filePathForDelete;

        private iniFile reader = new iniFile();


        //Для записи в лог файл
        private string logMess = DateTime.Now.ToString("hh:mm dd-MM-yyyy") +"|  "+ FileIni + " данный файл не существует.";

        private string messFileNotExist = DateTime.Now.ToString("hh:mm dd-MM-yyyy") + "|  " + NameFile + " данный файл не существует.";

        //Строка сообщения из лог файла
        private string messageString;

        //проверка ини файла на существование и вытаскивание данных с ини
        public ReadFile()
        {
            if (File.Exists(FileIni))
            {
                SmtpServerR = reader.IniReadValue(SectionClient, SmtpServer);
                MailServerR = reader.IniReadValue(SectionClient, MailSRV);
                PassServerR = reader.IniReadValue(SectionClient, PassSRV);
                PortServerR = int.Parse(reader.IniReadValue(SectionClient, PortSRV));
                PathR = reader.IniReadValue(SectionClient, PathToFile);

                MailToServerR = reader.IniReadValue(SectionMailTo, MailToS);
                SubjecServertR = reader.IniReadValue(SectionMailTo, SubjectS);
                readSection();
            }
            else
            {
                new WriteLog(logMess);
            }
                        
        }

        //проверка лог файла после архивирования
        private void readSection()
        {
            if (File.Exists(PathR + NameFile))
            {
                MessageString = readFile(PathR + NameFile);
                FilePathForDelete = PathR + NameFile;
            }
            else
            {
                MessageString = messFileNotExist;
                new WriteLog(messFileNotExist);
            }
        }

        public string MessageString
        {
            get
            {
                return messageString;
            }

            set
            {
                messageString = value;
            }
        }

        public string SmtpServerR
        {
            get
            {
                return smtpServerR;
            }

            set
            {
                smtpServerR = value;
            }
        }

        public string MailServerR
        {
            get
            {
                return mailServerR;
            }

            set
            {
                mailServerR = value;
            }
        }

        public string PassServerR
        {
            get
            {
                return passServerR;
            }

            set
            {
                passServerR = value;
            }
        }

        public int PortServerR
        {
            get
            {
                return portServerR;
            }

            set
            {
                portServerR = value;
            }
        }

        public string PathR
        {
            get
            {
                return pathR;
            }

            set
            {
                pathR = value;
            }
        }

        public string MailToServerR
        {
            get
            {
                return mailToServerR;
            }

            set
            {
                mailToServerR = value;
            }
        }

        public string SubjecServertR
        {
            get
            {
                return subjecServertR;
            }

            set
            {
                subjecServertR = value;
            }
        }

        public string FilePathForDelete
        {
            get
            {
                return filePathForDelete;
            }

            set
            {
                filePathForDelete = value;
            }
        }

        //Чтение с лог файла
        private string readFile(string path)
        {
            return File.ReadAllText(path);
        }

        

        
    }
}
