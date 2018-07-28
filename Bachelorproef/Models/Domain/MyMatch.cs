using DataGatherer.Domain;
using RiotSharp.Endpoints.MatchEndpoint;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataGatherer
{
    class MyMatch
    {
        public long Id { get; set; }
        public long MatchId { get; set; }
        public long GameCreation { get; set; }
        public ICollection <MyParticipant> Participants{ get; set; }
        public long MatchDuration { get; set; }

        public MyMatch()
        {
            Id = 0;
            Participants = new List<MyParticipant>();
        }

        public MyMatch(long matchId, long gameCreation, ICollection<MyParticipant> participants, long matchDuration)
        {
            Id = 0; 
            MatchId = matchId;
            GameCreation = gameCreation;
            Participants = participants;
            MatchDuration = matchDuration;
        }

        public MyMatch(Match match)
        {
            Id = 0;
            MatchId = match.GameId;
            GameCreation = match.GameCreation.Ticks;
            MatchDuration = match.GameDuration.Ticks;

            Participants = new List<MyParticipant>();

            foreach(Participant p in match.Participants)
            {
                long summonerId=0;
                foreach(ParticipantIdentity pi in match.ParticipantIdentities)
                {
                    if (pi.ParticipantId == p.ParticipantId) summonerId = pi.Player.SummonerId;
                }
                Participants.Add(new MyParticipant(p, match.GameId, summonerId, p.Timeline.Lane, p.Timeline.Role));
            }
        }
    }
}
