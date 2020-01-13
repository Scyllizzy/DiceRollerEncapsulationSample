using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerEncapsulationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[5];

            InitDice(dice);
            PrintFaceValues(dice);

            //Hold first 3 dice
            dice[0].IsHeld = true;
            dice[1].IsHeld = true;
            dice[2].IsHeld = true;

            Console.WriteLine();

            RollDice(dice);
            PrintFaceValues(dice);

            Console.ReadKey();
        }

        /// <summary>
        /// Rolls all the die in given array.
        /// </summary>
        /// <param name="dice">Array of die</param>
        private static void RollDice(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
            }
        }

        /// <summary>
        /// Prints the face values of the die in given array
        /// </summary>
        /// <param name="dice">Array of die</param>
        private static void PrintFaceValues(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].FaceValue);
            }
        }

        /// <summary>
        /// Initializes all die in given array.
        /// Assumes array has been given a length.
        /// </summary>
        /// <param name="dice">Array of die</param>
        private static void InitDice(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }
    }
}
