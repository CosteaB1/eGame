namespace eGame.Domain.ValueObjects.User
{
    public record NickName
    {
        public const int MaxLength = 20;
        public const int MinLength = 5;

        private NickName(string value)
        {
            Value = value;
        }
        public string Value { get; }

        public static NickName Create(string nickName)
        {
            return new NickName(nickName);
        }
    }
}
