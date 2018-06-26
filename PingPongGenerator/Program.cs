using System;
using System.Collections.Generic;

namespace PingPongGenerator
{

    public class PingPong
    {
        public int inputtedNumber;
        public bool PingPongCheck(int inputtedNumber)
        {
            if (inputtedNumber % 5 == 0 && inputtedNumber % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PingCheck(int inputtedNumber)
        {
            if (inputtedNumber % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PongCheck(int inputtedNumber)
        {
            if (inputtedNumber % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public List<string> numberList = new List<string>();
        public List<string> CreateList(int inputtedNumber)
        {

            for (int i = 1; i <= inputtedNumber; ++i)
            {
                if (PingPongCheck(i))
                {
                    numberList.Add("ping pong");
                }
                else if (PingCheck(i))
                {
                    numberList.Add("ping");

                }
                else if (PongCheck(i))
                {
                    numberList.Add("pong");
                }
                else
                {
                    numberList.Add(i.ToString());
                }
                Console.WriteLine(numberList[i-1]);
            }

            return numberList;


        }

    }
        class Program
        {
            static void Main(string[] args)
            {
            while (true)
            {
                Console.WriteLine("Enter a number!");
                //public string stringInputtedNumber = Console.ReadLine();
                int inputtedNumber = int.Parse(Console.ReadLine());
                PingPong myPingPong = new PingPong();
                myPingPong.CreateList(inputtedNumber);
            }
            }
        }
    
}
