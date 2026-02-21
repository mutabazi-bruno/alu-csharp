using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie with a private health field.
    /// </summary>
    public class Zombie
    {
        /// <summary>Health of the zombie.</summary>
        private int health;

        /// <summary>Initializes a new Zombie with 0 health.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new Zombie with specified health.
        /// </summary>
        /// <param name="value">The health value.</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Gets the health of the Zombie.
        /// </summary>
        /// <returns>The health value.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
