namespace ridbot
{
    public sealed class BotAction
    {
        /// <summary>
        /// Move, attack or wait. Default is wait.
        /// </summary>
        public ActionTypeEnum Action { get; set; }

        /// <summary>
        /// Angle for which to move or attack, see the readme on the project site for description
        /// </summary>
        public int Angle { get; set; }

        /// <summary>
        /// Maximum distance to move or fire, this is capped by the configuration.
        /// But maybe you don't want to move or fire your maximum distance.
        /// To pick up a powerup you must move to it and stop on it, not move over it.
        /// </summary>
        public int Distance { get; set; }
    }
}