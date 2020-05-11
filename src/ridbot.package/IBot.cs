using System.Collections.Generic;

namespace ridbot
{
    public interface IBot
    {
        /// <summary>
        /// This method will be called at the beginning of the battle, if this is the first battle the previous configurations will be null
        /// </summary>
        /// <param name="yourPrevious">Configuration from the previous game</param>
        /// <param name="youWon">Did you win the previous game</param>
        /// <returns>Configruation for this round</returns>
        BotConfiguration GetBotConfiguration(PreviousResultEnum result, IBotConfiguration yourPrevious);

        /// <summary>
        /// This method will be called every turn
        /// </summary>
        /// <param name="turn">Current turn number</param>
        /// <param name="totalTurns">Total turns in the game</param>
        /// <param name="yourConfiguration">Your bot configuration</param>
        /// <param name="positions">Positions of all entities in play</param>
        /// <returns>Action to perform this round</returns>
        BotAction GetBotAction(int turn, int totalTurns, IBotConfiguration yourConfiguration, IGameEntity yourBot, IEnumerable<IGameEntity> gameAssets);

        /// <summary>
        /// Name of your bot
        /// </summary>
        string Name { get; }
    }
}