using DataGatherer.Models.Domain;
using System.Collections.Generic;
using DataGatherer.Models.DAL;
using System.Linq;

namespace DataAnalyzer.Domain
{
    public class ParticipantStore
    {

        public List<MyParticipant> Participants { get; set; }

        private DataGathererContext context;

        public ParticipantStore()
        {
            context = new DataGathererContext(); 
        }

        public ParticipantStore(DataGathererContext context, int champId)
        {
            Participants = new List<MyParticipant>();
            this.context = context; 
            foreach(MyParticipant p in context.Participants)
            {
                Participants.Add(p);
            }
        }

        public List<MyParticipant> GetParticipantsWithChamp(int champId)
        {
            return context.Participants.Where(p => p.ChampionId == champId).ToList() ; 
        }



    }
}