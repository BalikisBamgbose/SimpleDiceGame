using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLoops
{
    public class DiceGame
    {

        public static void DiceGam()
        {
            Console.WriteLine("*******Welcome to dice game******");
            int noOfTimes = 3;
            const int doublePoint = 2;
            const int tripplePoint = 6;
            bool flag = true;
            while (flag && !(noOfTimes ==0))
          { 
            Random random = new Random();
            int firstRoll = random.Next(1, 7);
            int secondRoll = random.Next(1, 7);
            int thirdRoll = random.Next(1, 7);
            int originalScore = firstRoll + secondRoll + thirdRoll;
                Console.WriteLine("Enter your nickname");
            string nickName = Console.ReadLine()!;
           
            Console.WriteLine($"Welcome {nickName} You have {noOfTimes} left \n Type S to start");
            string startGame = Console.ReadLine()!.ToLower();

            while (!startGame.Equals("s"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.ResetColor();
            }
            if (firstRoll == secondRoll && secondRoll == thirdRoll)
            {
                originalScore += tripplePoint;
                Console.WriteLine($"Congratulations {nickName}!!! you rolled double");
            }
            else if (firstRoll == secondRoll || secondRoll == thirdRoll || thirdRoll == firstRoll)
            {
                originalScore += doublePoint;
                Console.WriteLine($"Congratulations {nickName}!!! you rolled tripple");
            }
            else
            {
                Console.WriteLine($"Dice One : {firstRoll}\n Dice Two : {secondRoll}\n Dice Three : {thirdRoll}\n You have a total point of {originalScore}");
            }
            if (originalScore >= 10 && originalScore <= 13)
            {
                Console.WriteLine("Congratulations!!! you have won pen");
            }
            if (originalScore >= 14 && originalScore <= 16)
            {
                Console.WriteLine("Congratulations!!! you have won two pen");
            }
            if (originalScore == 21)
            {
                Console.WriteLine("Congratulations!!! you have won a car");
            }
            if (originalScore >= 22 && originalScore <= 16)
            {
                Console.WriteLine("Congratulations!!! you have won a house at banana Island");
            }
            noOfTimes--;
            string decision = string.Empty;
            string yes = "Y".ToLower();
            string no = "N".ToLower();
            if (!(noOfTimes > 0))
            {
                do
                {
                    Console.Write("Would you like to continue? : (y/n)");
                    decision = Console.ReadLine()!.ToLower();
                } while (!decision.Equals(yes) && !(decision.Equals(no)));
            }


            flag = decision.Equals("yes");
            if (decision == no)
            {
                Console.Write("Thanks for playing our game....");
                flag = false;
            }
        }

        }
    }
}
