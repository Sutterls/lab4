using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class EmailBox
    {
        public List<Email> Emails { get; set; }
        public EmailBox(List<Email> emails)
        {
            Emails = emails;
        }

        public void DisplayEmailsByDate()
        {
            var emailsByDate = Emails.GroupBy(e => e.Date.Date); /// группировка писем по дате отправки (без учета времени)

            foreach (var group in emailsByDate)
            {
                Console.WriteLine($"Date: {group.Key}"); /// вывод даты
                Console.WriteLine($"Number of emails: {group.Count()}"); /// вывод количества писем
            }
        }
    }
}

