using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_PollBall_end.Services
{
    public interface IPollResultsService
    {
        void AddVote(SelectedGame game);
        SortedDictionary<SelectedGame, int> GetVoteResult();
    }
}
