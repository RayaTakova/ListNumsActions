using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins":
                        //TODO
                        break;
                    case "del":
                        //TODO
                        break;
                    case "contains":
                        //TODO
                        break;
                    case "remove":
                        int index = int.Parse(cmd[1]);
                        nums.RemoveAt(index);
                        break;
                    case "cut":
                        int num = int.Parse(cmd[1]);
                        for (int i = 0; i < num; i++)
                        {
                            nums.RemoveAt(0);
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
