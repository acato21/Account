﻿namespace Account.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) 
            : base(message)
        { 
        }
    }
}
