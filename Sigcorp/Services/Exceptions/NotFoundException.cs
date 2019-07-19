using System;


namespace Sigcorp.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message ) : base(message)
        {

        }
    }
}
