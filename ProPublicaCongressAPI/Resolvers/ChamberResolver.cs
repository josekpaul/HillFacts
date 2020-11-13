using AutoMapper;
using ProPublicaCongressAPI.Contracts;
using System;

namespace ProPublicaCongressAPI.Resolvers
{
    internal class ChamberResolver : IMemberValueResolver<object, object, string, Chamber>
    {
        public Chamber Resolve(object source, object destination, string sourceMember, Chamber destinationMember, ResolutionContext context)
        {
            Chamber chamber;
            if (!Enum.TryParse<Chamber>(sourceMember, out chamber))
            {
                chamber = Chamber.Unknown;
            }

            return chamber;
        }
    }
}