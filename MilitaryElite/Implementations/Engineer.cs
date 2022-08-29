using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            Repairs = new List<IRepair>();
        }

        public List<IRepair> Repairs { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            string baseInfo = base.ToString();

            stringBuilder.AppendLine(baseInfo);
            stringBuilder.AppendLine($"Corps: {Corps}");
            stringBuilder.AppendLine("Repairs:");

            foreach (var item in Repairs)
            {
                stringBuilder.AppendLine($"  {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
