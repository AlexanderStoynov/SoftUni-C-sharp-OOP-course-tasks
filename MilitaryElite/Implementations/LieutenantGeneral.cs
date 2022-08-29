using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string baseinfo = base.ToString();

            stringBuilder.AppendLine(baseinfo);
            stringBuilder.AppendLine("Privates:");

            foreach (var item in Privates)
            {
                stringBuilder.AppendLine($"  {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
