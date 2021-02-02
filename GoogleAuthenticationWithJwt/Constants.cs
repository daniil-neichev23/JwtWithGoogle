namespace GoogleAuthenticationWithJwt
{
    public static class Constants
    {
        public const string Issuer = Audiance;
        public const string Audiance = "https://localhost:44339/";
        public const string Secret = "not_too_short_otherwise_it_might_error"; 
    }
}
