using System.Threading.Tasks;

namespace BlazorMovies.Client.Auth
{
    interface ILoginService
    {
        Task Login(string token);
        Task Logout();
    }
}
