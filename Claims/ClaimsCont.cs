using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Claims_Repo
{
    public class ClaimsCont
    {
        public string ClaimID { get; set; }
        public string ClaimType { get; set; }
        public String Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DtOfIncdnt { get; set; }
        public DateTime DtOfClaim { get; set; }
        public bool IsValid { get; set; }

        public ClaimsCont() { }

        public ClaimsCont(string claimID, string claimType, String description, double claimAmount, DateTime dtOfIncdnt, DateTime dtOfClaim, bool isValid)
        {
            ClaimID = claimID;
            ClaimType = claimType;
            Description = description;
            ClaimAmount = claimAmount;
            DtOfIncdnt = dtOfIncdnt;
            DtOfClaim = dtOfClaim;
            IsValid = isValid;
        }
        
      
            
        
    }
}



   




