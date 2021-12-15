using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionSystem2._0
{
    internal class Party
    {
        public string Name { get; set; }
        public List<Candidate> Candidates { get; private set; }
        public Party(string name)
        {
            Name = name;
            Candidates = new List<Candidate>();
        }
        public bool AddCandidate(Candidate candidate)
        {
            if(candidate.Party == null)
            {
                Candidates.Add(candidate);
                return true;
            }
            return false;
        }
        public bool RemoveCandidate(Candidate candidate)
        {

            if (Candidates.Remove(candidate))
            {
                candidate.Party = null;
                return true;
            }
            return false;
        }
    }
}
