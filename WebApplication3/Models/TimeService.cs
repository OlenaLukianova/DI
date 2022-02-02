using System;

namespace WebApplication3.Models
{
    public class TimeService
    {
        private static TimeService instance;

        // Private constructor so it doesn't create any more instances
        private TimeService() { }
        // The Public Property that intercepts the creation requests
        public static TimeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TimeService();
                }
                return instance;
            }
        }
        public string localDate = DateTime.Now.ToString("hh.mm.ss.ffffff");

        public string Id = Guid.NewGuid().ToString();
    }
}

