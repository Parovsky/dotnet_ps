using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = "INFO "
                + DateTime.Now + " "
                + LoginValidation.currentUserName + " "
                + LoginValidation.currentUserRole + " "
                + activity;
            currentSessionActivities.Add(activityLine);
            WriteLogInFile(activityLine);
        }

        static public void LogError(string errorMessage)
        {
            string errorMessageLine = "ERROR "
                + DateTime.Now + " "
                + LoginValidation.currentUserName + " "
                + LoginValidation.currentUserRole + " "
                + errorMessage;
            currentSessionActivities.Add(errorMessage);
            WriteLogInFile(errorMessage);
        }

        static private void WriteLogInFile(string activity)
        {
            if (File.Exists("test.txt") == true)
            {
                File.AppendAllText("test.txt", activity + "\n");
            }
        }

        static public void ShowLogFile()
        {
            if(File.Exists("test.txt") == true)
            {
                StreamReader outputFile = new StreamReader("test.txt");
                string line = null;
                do
                {
                    line = outputFile.ReadLine();
                    Console.WriteLine(line);
                } while (line != null);
                outputFile.Close();
            }
        }

        static public void ShowCurrentActivities()
        {
            StringBuilder sb = new StringBuilder();
            foreach(string line in currentSessionActivities)
            {
                sb.Append(line + "\n");
            }
            Console.WriteLine(sb);
        }
    }
}
