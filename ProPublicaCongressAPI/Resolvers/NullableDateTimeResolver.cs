using AutoMapper;
using System;

namespace ProPublicaCongressAPI.Resolvers
{
    internal class NullableDateTimeResolver : IMemberValueResolver<object, object, string, DateTime?>
    {
        public DateTime? Resolve(object source, object destination, string sourceMember, DateTime? destinationMember, ResolutionContext context)
        {
            if(String.IsNullOrWhiteSpace(sourceMember))
            {
                return null;
            }

            DateTime parsedDateTime;
            bool success = DateTime.TryParse(sourceMember, out parsedDateTime);

            if(!success)
            {
                return null;
            }

            return parsedDateTime;
        }
    }
}