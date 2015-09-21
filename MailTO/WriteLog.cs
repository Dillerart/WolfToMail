using System.IO;

namespace MailTO
{
    class WriteLog
    {
        private string logFile = @".\MailLog.log";

        //Запись в лог файл события отправки сообщений
        public WriteLog(string log)
        {
            using (StreamWriter sw = File.AppendText(logFile))
            {
                sw.WriteLine(log);
            }
        }
    }
}
