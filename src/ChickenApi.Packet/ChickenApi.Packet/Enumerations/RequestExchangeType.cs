namespace ChickenApi.Packet.Enumerations
{
    public enum RequestExchangeType : byte
    {
        Requested = 1,
        List = 2,
        Confirmed = 3,
        Cancelled = 4,
        Declined = 5
    }
}
