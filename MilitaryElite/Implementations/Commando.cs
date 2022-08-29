using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Implementations
{
    public class Commando : SpecialisedSoldier, IComando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName)
        {
            var mission = this.Missions.FirstOrDefault(x => x.CodeName == codeName);

            mission.Status = Status.Finished;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            string baseInfo = base.ToString();

            stringBuilder.AppendLine(baseInfo);
            stringBuilder.AppendLine($"Corps: {Corps}");
            stringBuilder.AppendLine("Missions:");

            foreach (var item in Missions)
            {
                stringBuilder.AppendLine($"  {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
