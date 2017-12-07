using System;
using System.Threading.Tasks;
using Android.App;
using Xamarin.Facebook;
using Xamarin.Facebook.Login;

namespace Pattern.Auth.Facebook
{
    public class FacebookAuth : IFacebookAuth
    {
        private Activity activity;

        public FacebookAuth(Activity activity)
        {
            this.activity = activity;
        }

        public Task<string> Login(string[] permissions)
        {
            LoginManager manager = LoginManager.Instance;

            manager.LogInWithReadPermissions(this.activity, permissions);

            return Task.FromResult(AccessToken.CurrentAccessToken.Token);
        }
    }
}
