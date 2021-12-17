using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionSystem2._0
{
    internal class Voter
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public bool IsSick { get; set; }
        public Ballot Ballot 
        {
            get
            {
                return Ballot;
            }
            set
            {
                if (Ballot != null)
                {
                    Ballot.RemoveVoter(this);
                }
                Ballot = value;
            }
        }
        public Voter(int id, string name)
        {
            Id = id;
            Name = name;
            IsSick = false;
            Ballot = null;
        }
    }
}
