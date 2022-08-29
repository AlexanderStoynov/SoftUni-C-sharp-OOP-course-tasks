using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface IComando : ISpecialisedSoldier
    {
        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName);

    }
}
