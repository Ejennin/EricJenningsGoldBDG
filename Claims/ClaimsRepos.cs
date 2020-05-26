using Claims_Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claims
{
    public class ClaimsRepos
    {
        private List<ClaimsCont> _listOfContent = new List<ClaimsCont>();

        public void AddContentToList(ClaimsCont item)
        {
            _listOfContent.Add(item);
        }

        public List<ClaimsCont> GetClaimsList()
        {
            return _listOfContent;
        }

        private ClaimsCont GetClaimsContbyID(string claimId)
        {
            foreach (ClaimsCont item in _listOfContent)
            {
                if (item.ClaimID==claimId)
                {
                    return item;
                }
            }

            return null;
        }

        public bool UpdateClaim (string claimId, ClaimsCont newItem)
        {
            ClaimsCont oldItem = GetClaimsContbyID(claimId);

            if (oldItem != null)
            
            
            {
                oldItem.ClaimID = newItem.ClaimID;
                oldItem.ClaimType = newItem.ClaimType;
                oldItem.Description = newItem.Description;
                oldItem.ClaimAmount = newItem.ClaimAmount;
                oldItem.DtOfIncdnt = newItem.DtOfIncdnt;
                oldItem.DtOfClaim = newItem.DtOfClaim;
                oldItem.IsValid = newItem.IsValid;
                return true;
            }
            else
            {
                return false;
            }


        }


    }
}
