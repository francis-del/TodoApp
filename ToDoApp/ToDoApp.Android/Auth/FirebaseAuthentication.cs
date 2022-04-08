using Android.Gms.Extensions;
using Firebase.Auth;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using ToDoApp.FireAuth;
using ToDoApp.Models;

namespace ToDoApp.Droid.Auth
{
    public class FirebaseAuthentication : IFirebaseAuthentication
    {
        public async Task<UserModel> LoginWithEmailAndPassword(string email, string password)
        {
            try
            {
                var firebaseuser = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                var token = await firebaseuser.User.GetIdToken(false).AsAsync<GetTokenResult>();
                var users = new UserModel()
                {
                    DisplayName = firebaseuser.User.DisplayName,
                    Email = firebaseuser.User.Email,
                    Token = token.Token
                };
                return users;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public async Task<bool> RegisterWithEmailAndPassword(string username, string email, string password)
        {
            try
            {
                var result = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
                var usersProfileBuilder = new UserProfileChangeRequest.Builder();
                usersProfileBuilder.SetDisplayName(username);
                await result.User.UpdateProfileAsync(usersProfileBuilder.Build());
                return result.User != null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public async Task ForgetPassword(string email)
        {
            try
            {
                await FirebaseAuth.Instance.SendPasswordResetEmailAsync(email);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public string GetUsername()
        {
            var users = FirebaseAuth.Instance.CurrentUser;
            return users?.DisplayName;
        }

        public string GetUserId()
        {
            var users = FirebaseAuth.Instance.CurrentUser;
            return users?.Uid;
        }


        public bool IsLoggedIn()
        {
            var users = FirebaseAuth.Instance.CurrentUser;
            return users != null;
        }

        public bool LogOut()
        {
            try
            {
                FirebaseAuth.Instance.SignOut();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
    }
}