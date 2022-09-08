using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace TelephoneDirectory.Models
{
    public class FileManager
    {
        private static string _filePath = "d:/TelephoneDirectory.txt";
        public static void WriteInFile(List<PhoneRecord> phoneRecords)
        {
            string jsonData = JsonSerializer.Serialize(phoneRecords);
            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                streamWriter.WriteLine(jsonData);
            }
        }

        public static List<PhoneRecord> ReadFromFile()
        {
            if (!File.Exists(_filePath))
            {
                using (StreamWriter streamWriter = new StreamWriter(_filePath))
                {
                    streamWriter.Write("");
                }
            }

            List<PhoneRecord> phoneRecords;
            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                phoneRecords = JsonSerializer.Deserialize<List<PhoneRecord>>(streamReader.ReadToEnd());
            }

            return phoneRecords;
        }
    }
}