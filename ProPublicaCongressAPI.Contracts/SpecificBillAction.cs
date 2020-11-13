using System;

namespace ProPublicaCongressAPI.Contracts
{
    public class SpecificBillAction
    {
        public DateTime DateTimeOccurred { get; set; }

        public string Description { get; set; }
        
        public int Id { get; set; }
        
        public Chamber Chamber { get; set; }
        
        public string ActionType { get; set; }
    }
}