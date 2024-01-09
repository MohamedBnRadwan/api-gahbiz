namespace GahbizWepApi.Interfaces
{
    public interface ILoginForm
    {
       string UserName { get; }
       string Password { get; }
       bool RememberMe { get; }
    }
}
