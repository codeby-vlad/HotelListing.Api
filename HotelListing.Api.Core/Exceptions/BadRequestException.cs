﻿namespace HotelListing.Api.Core.Exceptions
{
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string message) : base(message)
        {
            
        }
    }
}
