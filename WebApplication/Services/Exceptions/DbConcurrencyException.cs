using System;


namespace WebApplication.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string massage) : base(massage)
        {

        }
    }
}
