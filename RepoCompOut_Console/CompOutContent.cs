using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoCompOut_Repo
{
    
    public class CompOutContent
    {
        public int AttendCount { get; set; }
        public double TotCostPerson { get; set; }
        public double CostOfEvent
        {
            get
            {
                return AttendCount * TotCostPerson;
            }
        }

        public string EventType { get; set; }
        public  DateTime EventDate { get; set; }
        public CompOutContent() { }

        public CompOutContent(int attendCount, double totCostPerson, string eventType, DateTime eventDate )
        {
            AttendCount = attendCount;
            TotCostPerson = totCostPerson;
            
            EventType = eventType;
            EventDate = eventDate;
        }
    
    }
}
