namespace lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Email> emails = new List<Email>() /// создаем список писем
        {
            new Email(new DateTime(2021, 12, 31), "i@mail.ru"),
            new Email(new DateTime(2022, 7, 22), "you@gmail.com"),
            new Email(new DateTime(2023, 2, 16), "we@yandex.ru"),
            new Email(new DateTime(2018, 5, 8), "she@bk.ru"),
            new Email(new DateTime(2023, 2, 16), "he@mail.ru")
        };

            EmailBox emailBox = new EmailBox(emails);
            emailBox.DisplayEmailsByDate();
        }
    }
 }

