namespace MinotaurLabyrinth
{
    /// <summary>
    /// Represents a wall room, which acts as a barrier and cannot be activated or interacted with.
    /// </summary>
    public class Wall : Room
    {
        static Wall()
        {
            RoomFactory.Instance.Register(RoomType.Wall, () => new Wall());
        }

        /// <inheritdoc/>
        public override RoomType Type { get; } = RoomType.Wall;

        // No need to override the Activate method here

        /// <inheritdoc/>
        public override DisplayDetails Display()
        {
            return new DisplayDetails("[ ]", ConsoleColor.Black);
        }
    }
}
