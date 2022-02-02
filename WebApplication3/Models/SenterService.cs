using Autofac.Features.AttributeFilters;

namespace WebApplication3.Models
{
    public class SenterService
    {
        private readonly ISender senderSms;
        private readonly ISender senderEmail;
        private readonly TimeService timeService;
        
        public SenterService([KeyFilter("senderEmail")] ISender senderEmail, 
                             [KeyFilter("senderSms")] ISender senderSMS, 
                             TimeService timeService)
        {
            this.senderSms = senderSMS;
            this.senderEmail = senderEmail;
            this.timeService = timeService;
        }

        public string SentByEmail()
        {
            return senderEmail.Send();
        }
        public string SentBySms()
        {
            return senderSms.Send();
        }
        
        public string GetTime()
        {
            return timeService.localDate;
        }
        public string GetId()
        {
            return timeService.Id;
        }
    }
}
