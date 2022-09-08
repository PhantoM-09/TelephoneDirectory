using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelephoneDirectory.Models
{
    public class PhoneRecordStInitializer
    {
        public static void CreateStorage()
        {
            PhoneRecordStorage.LoadCollection();
        }
    }
}