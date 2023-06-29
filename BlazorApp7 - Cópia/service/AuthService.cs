namespace BlazorApp7.service;

public class AuthService
{
    public bool isAuthenticated = false;

    public bool IsAuthenticated => isAuthenticated;

    public void SetAuthenticated()
    {
        isAuthenticated = true;
    }

    public void SetUnauthenticated()
    {
        isAuthenticated = false;
    }
}
