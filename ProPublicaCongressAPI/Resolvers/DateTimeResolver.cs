using AutoMapper;
using System;

namespace ProPublicaCongressAPI.Resolvers
{
    internal class DateTimeResolver : IMemberValueResolver<object, object, string, DateTime>
    {
        public DateTime Resolve(object source, object destination, string sourceMember, DateTime destinationMember, ResolutionContext context)
        {
            if(sourceMember.EndsWith(" UTC"))
            {
                sourceMember = sourceMember.Replace(" UTC", "Z");
            }

            DateTime parsedDateTime;
            DateTime.TryParse(sourceMember, out parsedDateTime);
            return parsedDateTime;
        }
    }
}