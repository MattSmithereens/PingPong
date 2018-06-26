using System;

namespace PingPongGenerator
{

    public class PingPong
    {
        public int inputtedNumber;
        public string PingPongCheck(int inputtedNumber)
        {
            if (inputtedNumber % 5 == 0 && inputtedNumber % 3 == 0)
            {
                return "ping pong";
            }
            else
            {
                return inputtedNumber.ToString();
            }
        }

        public string PingCheck(int inputtedNumber)
        {
            if (inputtedNumber % 3 == 0) {
                return "ping";
            } else {
                return inputtedNumber.ToString();
            }
        }

        public string PongCheck(int inputtedNumber)
        {
            if (inputtedNumber % 5 == 0)
            {
                return "pong";
            }
            else
            {
                return inputtedNumber.ToString();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
