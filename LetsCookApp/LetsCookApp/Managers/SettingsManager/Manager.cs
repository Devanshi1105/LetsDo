using Acr.UserDialogs;
using LetsCookApp.Managers.ApiProvider;
using LetsCookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCookApp.Managers.SettingsManager
{
    public class Manager : IManager
    {
        private readonly IApiProvider _apiProvider;
        private readonly ISettingsManager _settingsManager;

        public CategoryResponse CategoryResponse { get { return categoryResponse; } }

        public Manager(IApiProvider apiProvider, ISettingsManager settingsManager)
        {
            _apiProvider = apiProvider;
            _settingsManager = settingsManager;
        }
        #region Header
        public Dictionary<string, string> GetHeaders()
        {
            Dictionary<string, string> header = new Dictionary<string, string>();
           // header.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("LetsCookApp" + ":" + "LetsCookApp")));
            return header;
        }

        #endregion
        string error = "Please Check Internet Connection.";
        private CategoryResponse categoryResponse { get; set; }
        public async void  getAllCategory(CommonRequest commonRequest, Action success, Action<CategoryResponse> failed)
        {
            bool IsNetwork = true;//await DependencyService.Get<IMediaService>().CheckNewworkConnectivity();
            if (IsNetwork)
            {

                var url = string.Format("{0}getAllCategories.php", _settingsManager.ApiHost);

                await Task.Run(async () =>
                {
                    Dictionary<string, string> head = GetHeaders();
                    var result =  _apiProvider.Get<CategoryResponse>(url,  null);
                    if (result.IsSuccessful)
                    {
                        if (success != null)
                        {
                            categoryResponse = result.Result;
                            success.Invoke();
                        }
                    }
                    else
                    {
                        failed.Invoke(result.Result);
                    }
                });
            }
            else
            {
                UserDialogs.Instance.HideLoading(); UserDialogs.Instance.Alert(error, null, "OK");
            }
        }
    }
}
