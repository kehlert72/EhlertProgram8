using System;
using OrganizationNamespace;
using IFundingNamespace;

namespace ClubNamespace
{
    public class Club : Organization, IFunding
    {
        // Private member data
        private string meetingLocation;
        private string meetingDay;
        private string meetingTime;

        public Club(string name, string pContact, string mLoc, string mDay, string mTime) : base (name, pContact)
        {
            meetingLocation = mLoc;
            meetingDay = mDay;
            meetingTime = mTime;
        }

        // Required method - because of interface
        public void SetFundingAmt()
        {
            FundedAmt = 600M;
        }
    }
}
