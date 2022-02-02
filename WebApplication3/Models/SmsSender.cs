namespace WebApplication3.Models
{
    public class SmsSender : ISender
    {
        public string Send()
        {
            return "Sent by SMS";
        }
    }
}
