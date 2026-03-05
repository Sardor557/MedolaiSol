namespace Medolai.Shared
{
    public class Vars
    {
        public int CacheTimeOut { get; set; }
        public string ServerUrl { get; set; }
    }

    public class JwtVars
    {
        public string ValidAudience { get; set; }
        public string ValidIssuer { get; set; }
        public string Secret { get; set; }
        public int TokenValidityInHours { get; set; }
        public int RefreshTokenValidityInHours { get; set; }
    }
}
