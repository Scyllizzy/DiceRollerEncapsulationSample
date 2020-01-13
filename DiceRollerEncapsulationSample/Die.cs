using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerEncapsulationSample
{
    /// <summary>
    /// Represents an individual 6-sided die
    /// </summary>
    class Die
    {
        // Static members get shared across all instances of this class. 
        //Meaning all die now have access to the same random object
        private static Random rand;

        /// <summary>
        /// The current value of the die (1-6)
        /// </summary>
        public byte FaceValue { get; private set; }

        /// <summary>
        /// Die that are held are not rolled
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Runs once before any die objects are created 
        /// and initializes Random object once
        /// </summary>
        static Die()
        {
            rand = new Random();
        }

        public Die()
        {
            Roll();
        }

        /// <summary>
        /// Generates a new random face value (1-6).
        /// Sets the face value to the randomly generated value.
        /// Returns the face value.
        /// </summary>
        /// <returns>Return face value (1-6)</returns>
        public byte Roll()
        {
            //If current die is held, return the current value. It wont roll
            if (IsHeld)
            {
                return FaceValue;
            }

            const byte MinValue = 1;
            const byte MaxValue = 6;
            //Offset is for the exclusive range of Random.Next()
            const byte Offset = 1;

            FaceValue = (byte)rand.Next(MinValue, MaxValue + Offset);
            return FaceValue;
        }
    }
}
