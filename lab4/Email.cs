using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Email
    {
        public DateTime Date { get; set; }
        public string RecipientAddress { get; set; }

        public Email(DateTime date, string recipientAddress)
        {
            Date = date;

            if (string.IsNullOrWhiteSpace(recipientAddress)) /// проверка на запись адреса отправителя
            {
                throw new ArgumentException("RecipientAddress mustn't be empty or null");
            }
            RecipientAddress = recipientAddress;
        }
    }
}
