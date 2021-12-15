using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionSystem2._0
{
    internal class Ballot
    {
        public int Id { get; private set; }
        public string Location { get; private set; }
        public string Discreption { get; set; }
        public bool IsOpen { get; set; }
        private readonly Dictionary<Voter, bool> voters;

        public Ballot(int id, string loc, string discreption)
        {
            voters = new Dictionary<Voter, bool>();
            IsOpen = false;
            Discreption = discreption;
            Location = loc;
            Id = id;
        }
        public bool AddVoter(Voter voter)
        {
            if(voter.Ballot == null)
            {
                voter.Ballot = this;
                voters.Add(voter, false);
                return true;
            }
            return false;
        }
        public bool RemoveVoter(Voter v)
        {
            if(voters.Remove(v))
            {
                v.Ballot = null;
                return true;
            }
            return false;
        }
    }
}
