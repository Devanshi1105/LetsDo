using Acr.UserDialogs;
using LetsCookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCookApp.ViewModels
{
    public class LoginViewModel :BaseViewModel
    {

        public LoginViewModel()
        {
            
           
           
        }

        public void GetAllCategory()
        {
            CommonRequest obj = new CommonRequest();

            userManager.getAllCategory(obj, () =>
            {
                var userProfileResponse = userManager.CategoryResponse;
            },
             (requestFailedReason) =>
             {
                 Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
                 {
                    //  UserDialogs.Instance.Alert(requestFailedReason.Message, null, "OK");
                    // UserDialogs.Instance.HideLoading();
                });
             });
        }
           

        private string emailId;

        public string EmailId
        {
            get { return emailId; }
            set { emailId = value;
                RaisePropertyChanged(() => EmailId);
            }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; RaisePropertyChanged(() => UserName); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; RaisePropertyChanged(() => Password); }
        }


    }
}
