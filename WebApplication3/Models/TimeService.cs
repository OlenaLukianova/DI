using System;

namespace WebApplication3.Models
{
    public class TimeService
    {
        public string localDate = DateTime.Now.ToString("hh.mm.ss.ffffff");

        public string Id = Guid.NewGuid().ToString();
    }
}

