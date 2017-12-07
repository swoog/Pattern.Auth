using System;
using System.Threading.Tasks;

namespace Pattern.Auth.Facebook
{
    public interface IFacebookAuth
    {
        Task<string> Login(string[] permissions);
    }
}
