using System;
using System.Text.Json;
using System.Windows.Input;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Essentials;

using DeliveryApp.Models;
using DeliveryApp.Classes;

namespace DeliveryApp.ViewModels
{
    public class UserAccountViewModel : BaseViewModel
    {
        private AppSettings userSettings;

        public AppSettings UserSettings
        {
            get { return userSettings; }
            set { SetProperty(ref userSettings, value); }
        }

        private string selectedAppTheme;

        public string SelectedAppTheme
        {
            get { return selectedAppTheme; }
            set { SetProperty(ref selectedAppTheme, value); UpdateSettingsTheme(); }
        }

        private void UpdateSettingsTheme()
        {
            if (!string.IsNullOrWhiteSpace(SelectedAppTheme))
                UserSettings.AppTheme = (DeliveryAppTheme)Enum.Parse(typeof(DeliveryAppTheme), SelectedAppTheme);
            else
                UserSettings.AppTheme = DeliveryAppTheme.Default;
        }

        public ICommand SaveCommand { get; set; }

        private async Task Save()
        {
            var jsonUserSettings = JsonSerializer.Serialize(UserSettings);
            Preferences.Set(Constants.UserSettingsKey, jsonUserSettings);
            ApplyTheme();

            await App.Current.MainPage.DisplayAlert("Success", "Account Preferences Saved!", "OK");
        }

        public UserAccountViewModel()
        {
            SaveCommand = new Command(async() => await Save());
            GetUserSettings();
        }

        private void ApplyTheme()
        {
            switch (UserSettings.AppTheme)
            {
                case DeliveryAppTheme.Default:
                    Application.Current.UserAppTheme = OSAppTheme.Unspecified;
                    break;
                case DeliveryAppTheme.Dark:
                    Application.Current.UserAppTheme = OSAppTheme.Dark;
                    break;
                case DeliveryAppTheme.Light:
                    Application.Current.UserAppTheme = OSAppTheme.Light;
                    break;
            }
        }

        private void GetUserSettings()
        {
            var jsonUserSettings = Preferences.Get(Constants.UserSettingsKey, string.Empty);

            if (!string.IsNullOrWhiteSpace(jsonUserSettings))
            {
                UserSettings = JsonSerializer.Deserialize<AppSettings>(jsonUserSettings);
            }
            else
            {
                UserSettings = new AppSettings()
                {
                    AppTheme = DeliveryAppTheme.Default,
                    News = true,
                    Notifications = true
                };
            }

            SelectedAppTheme = UserSettings.AppTheme.ToString();
        }
    }
}
