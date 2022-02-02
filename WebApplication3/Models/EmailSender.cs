namespace WebApplication3.Models
{
    public class EmailSender : ISender
    {
        public string Send()
        {
            return "Sent by Email";
        }
    }
}
