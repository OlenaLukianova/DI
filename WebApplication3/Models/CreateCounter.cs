using System;

namespace WebApplication3.Models
{
    public class CreateCounter : ISinglton, IScoped, ITransient
    {
        private int counter;
        public int GetCounter()
        {
            return counter++;
        }
    }
}
