using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Voting.Models
{
    public class Candidate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PoliticalPartyName { get; set; }
    }
}