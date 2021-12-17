using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionSystem2._0
{
    internal class Candidate : Voter
    {
        public Party Party
        {
            get { return Party; }
            set
            {
                if (Party != null)
                {
                    Party.RemoveCandidate(this);
                }
                Party = value;
            }
        }
        public Candidate(int id, string name) : base(id, name)
        {
            Party = null;
        }
    }
}
