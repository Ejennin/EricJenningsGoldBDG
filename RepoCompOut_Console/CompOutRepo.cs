using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoCompOut_Repo
{ 
    public class CompOutRepo
    {//create
        private List<CompOutContent> _compOutContent = new List<CompOutContent>();

        public bool AddCompOuting(CompOutContent item)
        {
            int startingCount = _compOutContent.Count;
            _compOutContent.Add(item);
            bool wasAdded = _compOutContent.Count == startingCount + 1;
            return wasAdded;
        }
        //Read
        public List<CompOutContent> GetCompOutContent()
        {
            return _compOutContent;
        }

        public double GetTotalCost()
        {
            List<CompOutContent> listOfOutings = _compOutContent;
            double totcost = 0;
            foreach (CompOutContent compOutContent in listOfOutings)
            {
                totcost += compOutContent.CostOfEvent;
            }
            return totcost;
        }
        public double GetTotolCostByEventType(string EventType)
        {
            List<CompOutContent> listOfOutings = _compOutContent ;
            double totTypeCost = 0;
            foreach (CompOutContent compOutContent in listOfOutings)
            {
                if (EventType == (compOutContent.EventType).ToString())
                {
                    totTypeCost += compOutContent.CostOfEvent;

                }
                return totTypeCost;
            }
            return 0;
        }
        


    }
    
}
