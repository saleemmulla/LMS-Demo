using LMS.WEB.Portal.Models;
namespace LMS.WEB.Portal.Repository
{
    public interface ILoginRepository
    {
        LoginViewModel GetLoggedInUser(string UserName, string Password);
    }
}
