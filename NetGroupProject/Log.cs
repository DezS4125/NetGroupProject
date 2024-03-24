using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetGroupProject
{
    internal class Log
    {
        string logContent;
        string logFilePath = @"../../logs/app.log";
        TextBox logTextBox;
        public Log(TextBox logControlForm) { 
            if (!System.IO.File.Exists(logFilePath))
            {
                System.IO.File.Create(logFilePath).Close();
            }
            logTextBox = logControlForm;
            logTextBox.Text = System.IO.File.ReadAllText(logFilePath);

        }
        public void readLogFile()
        {
            logTextBox.Text = System.IO.File.ReadAllText(logFilePath);
        }
        public void writeLogFile()
        {
            string logMessage = "This is a log message.";

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logFilePath, true))
            {
                writer.WriteLine(DateTime.Now.ToString() + ": " + logMessage);
            }
        }
    }
}
