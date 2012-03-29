using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace createEventSource
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(writeErr());
            Console.ReadLine();
        }

        public static string writeErr()
        {
            string source = "Eimza";
            if (!EventLog.SourceExists(source))
            {
                System.Diagnostics.Debug.WriteLine("asdfasdfasdf");
                EventLog.CreateEventSource(source, "HATA");
                return "createe";
            }

            EventLog.WriteEntry(source, "Hata Mesajı Denem", EventLogEntryType.Error);
            return "yazdı";
        }
    }
}
