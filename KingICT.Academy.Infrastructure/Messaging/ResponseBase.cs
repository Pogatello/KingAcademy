namespace KingICT.Academy.Infrastructure.Messaging
{
    public abstract class ResponseBase
    {
        public int StatusCode
        {
            get
            {
                return (int)Status;
            }
        }

        public Status Status { get; set; }

        public string Message { get; set; }
    }
}
