using HoneWork003.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneWork003
{
    class TicketStartEquityComparer : IEqualityComparer<TrainStationTable>
    {
        public bool Equals(TrainStationTable x, TrainStationTable y)
        {
            return x.StartStation == y.StartStation;
        }

        public int GetHashCode(TrainStationTable obj)
        {
            return obj.StartStation.GetHashCode();
        }
    }

    class TicketEndEquityComparer : IEqualityComparer<TrainStationTable>
    {
        public bool Equals(TrainStationTable x, TrainStationTable y)
        {
            return x.EndStation == y.EndStation;
        }

        public int GetHashCode(TrainStationTable obj)
        {
            return obj.EndStation.GetHashCode();
        }
    }


}
