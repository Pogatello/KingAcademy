namespace KingICT.Academy.Infrastructure.Messaging
{
    public abstract class RequestBase
    {
        public string Id { get; set; }
        public string UserToken { get; set; }
    }
}
