using System;
using OrganizationNamespace;

namespace IntramuralNamespace
{
    public class Intramural : Organization
    {
        private string sportType;

        public Intramural(string name, string pContact, string sport) : base(name, pContact)
        {
            sportType = sport;
        }

        public Intramural()
        {
            sportType = "unknown";
        }

        public string SportType
        {
            get
            {
                return sportType;
            }
            set
            {
                sportType = value;
            }
        }
    }
}
