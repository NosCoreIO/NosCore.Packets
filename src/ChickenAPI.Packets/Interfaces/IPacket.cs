namespace ChickenAPI.Packets.Interfaces
{
    public interface IPacket
    {
        string Header { get; set; }
        ushort? KeepAliveId { get; set; }
    }
}