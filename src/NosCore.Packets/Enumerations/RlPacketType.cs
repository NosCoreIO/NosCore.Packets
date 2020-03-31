namespace NosCore.Packets.Enumerations
{
    public enum RlPacketType
    {
        Normal,
        WantToRegister = 1,
        WantToUnregister = 2,
        MemberAndAlreadyInList = 3
    }
}