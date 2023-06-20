namespace MinotaurLabyrinth
{
    /// <summary>
    /// A utility class for generating random numbers.
    /// </summary>
    public static class RandomNumberGenerator
    {
        private static Random _random;

        static RandomNumberGenerator()
        {
            _random = new Random();
        }

        /// <summary>
        /// Sets the seed for the random number generator.
        /// </summary>
        /// <param name="seed">The seed value.</param>
        public static void SetSeed(int seed)
        {
            _random = new Random(seed);
        }

        /// <summary>
        /// Generates a random integer value between the specified minimum (inclusive) and maximum (exclusive) values.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. maxValue must be greater than or equal to minValue.</param>
        /// <returns>A random integer value between minValue and maxValue.</returns>
        public static int Next(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }

        /// <summary>
        /// Generates a random integer value between 0 (inclusive) and the specified maximum (exclusive) value.
        /// </summary>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. maxValue must be greater than or equal to 0.</param>
        /// <returns>A random integer value between 0 and maxValue.</returns>
        public static int Next(int maxValue)
        {
            return _random.Next(maxValue);
        }

        /// <summary>
        /// Generates a random double value between 0.0 (inclusive) and 1.0 (exclusive).
        /// </summary>
        /// <returns>A random double value between 0.0 and 1.0.</returns>
        public static double NextDouble()
        {
            return _random.NextDouble();
        }
    }

    /// <summary>
    /// Represents the display details of a room, including the text to be displayed and its color.
    /// </summary>
    public record DisplayDetails(string Text, System.ConsoleColor Color);

    /// <summary>
    /// Represents a location in the 2D game world, based on its row and column.
    /// </summary>
    public record Location(int Row, int Column);

    /// <summary>
    /// Represents one of the four directions of movement.
    /// </summary>
    public enum Direction { North, South, West, East }

    /// <summary>
    /// Represents the size of the game map.
    /// </summary>
    public enum Size { Small, Medium, Large };

    /// <summary>
    /// Represents the types of rooms in the labyrinth.
    /// </summary>
    public enum RoomType { Room, Entrance, Sword, Wall, Pit, MyRoom }
}
