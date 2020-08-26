using System;

namespace Core.Entities
{
    public class Owner : EntitieBase
    {
        public String FullName { get; set; }
        public string Profile { get; set; }
        public string Avater { get; set; }

        public Address Address { get; set; }
    }
}
