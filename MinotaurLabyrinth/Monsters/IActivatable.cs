namespace MinotaurLabyrinth
{
    /// <summary>
    /// This interface defines a structure for enabling the activation of game elements.
    /// </summary>
    public partial interface IActivatable
    {
        /// <summary>
        /// game elements activate.
        /// </summary>
        /// <param name="hero">The hero interacting with the game element.</param>
        /// <param name="map">The current game map.</param>
        void Activate(Hero hero, GameMap map);
    }

    public class GameMap
    {
    }
}
