namespace ChickenAPI.Packets.Interfaces
{
    public interface IPacket
    {
        string Header { get; set; }
        int? KeepAliveId { get; set; }
    }
}