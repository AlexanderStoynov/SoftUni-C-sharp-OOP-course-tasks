using MilitaryElite.Implementations;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<int, ISoldier> soldiers = new Dictionary<int, ISoldier>();

            while(input[0] != "End")
            {
                string action = input[0];
                int id = int.Parse(input[1]);
                string firstName = input[2];
                string lastName = input[3];

                if(action == "Private")
                {
                    decimal salary = decimal.Parse(input[4]);

                    IPrivate @private = new Private(id, firstName, lastName, salary);

                    soldiers.Add(id, @private);
                }

                else if(action == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(input[4]);
                    
                    ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

                    for (int i = 5; i < input.Length; i++)
                    {
                        int solderId = int.Parse(input[i]);
                         
                        IPrivate @private = soldiers[solderId] as IPrivate;

                        lieutenantGeneral.Privates.Add(@private);
                    }

                    soldiers.Add(id, lieutenantGeneral);
                }

                else if(action == "Engineer")
                {
                    decimal salary = decimal.Parse(input[4]);
                    string corps = input[5];

                    bool isValid = Enum.TryParse<Corps>(corps, out Corps result);

                    if (!isValid)
                    {
                        input = Console.ReadLine().Split().ToArray();
                        continue;
                    }

                    IEngineer engineer = new Engineer(id, firstName, lastName, salary, result);

                    for (int i = 6; i < input.Length; i += 2)
                    {
                        string partName = input[i];
                        int hours = int.Parse(input[i + 1]);
                        IRepair repair = new Repair(partName, hours);

                        engineer.Repairs.Add(repair);
                    }

                    soldiers.Add(id, engineer); 
                }

                else if(action == "Commando")
                {
                    decimal salary = decimal.Parse(input[4]);
                    string corps = input[5];

                    bool isValid = Enum.TryParse<Corps>(corps, out Corps result);

                    if (!isValid)
                    {
                        input = Console.ReadLine().Split().ToArray();
                        continue;
                    }

                    IComando comando = new Commando(id, firstName, lastName, salary, result);

                    for (int i = 6; i < input.Length; i += 2)
                    {
                        string missionCode = input[i];
                        string missionState = input[i + 1];

                        bool isValidMisiion = Enum.TryParse(missionState, out Status status);

                        if(!isValidMisiion)
                        {
                            continue;
                        }

                        IMission mission = new Mission(missionCode, status);

                        comando.Missions.Add(mission);
                    }

                    soldiers.Add(id, comando);
                }

                else if(action == "Spy")
                {
                    int codeNumber = int.Parse(input[4]);

                    ISpy spy = new Spy(id, firstName, lastName, codeNumber);

                    soldiers.Add(id, spy);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            foreach (var item in soldiers)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }
    }
}
