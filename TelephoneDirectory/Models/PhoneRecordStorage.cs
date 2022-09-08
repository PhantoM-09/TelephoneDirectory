using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelephoneDirectory.Models
{
    public class PhoneRecordStorage
    {
        private static List<PhoneRecord> phoneRecords = new List<PhoneRecord>();

        public static void SaveCollection()
        {
            FileManager.WriteInFile(phoneRecords);
        }

        public static void LoadCollection()
        {
            phoneRecords = FileManager.ReadFromFile();
        }

        public static List<PhoneRecord> GetCollection()
        {
            return phoneRecords;
        }

        public static void AddElement(PhoneRecord phoneRecord)
        {
            if (phoneRecords.Count == 0)
                phoneRecord.Id = 1;
            else
                phoneRecord.Id = phoneRecords[phoneRecords.Count - 1].Id + 1;

            phoneRecords.Add(phoneRecord);
        }

        public static void DeleteElement(int idDeleted)
        {
            phoneRecords.Remove(phoneRecords.FirstOrDefault(i => i.Id == idDeleted));
        }

        public static void UpdateElement(PhoneRecord phoneRecord)
        {
            PhoneRecord updatedPhoneRecord = phoneRecords.FirstOrDefault(i => i.Id == phoneRecord.Id);
            updatedPhoneRecord.LastName = phoneRecord.LastName;
            updatedPhoneRecord.PhoneNumber = phoneRecord.PhoneNumber;
        }

        public static PhoneRecord GetElement(int id)
        {
            return phoneRecords.FirstOrDefault(i => i.Id == id);
        }
    }
}