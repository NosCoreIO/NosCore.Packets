namespace NosCore.Packets.Enumerations
{
    public enum WpPortalType
    {
        NormalTs = 0,
        // The character has reached the level minimum and has not finished it yet; below that level it is NormalTs.
        NormalTsReachable = 1,
        NormalTsDone = 4,
        HeroTs = 8,
        HeroTsDone = 12
    }
}
