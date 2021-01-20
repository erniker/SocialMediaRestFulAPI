namespace SocialMedia.Infrastructure.Interface
{
    public interface IPasswordService
    {
        string Hash(string password);
        bool Check(string hash, string password);
    }
}
