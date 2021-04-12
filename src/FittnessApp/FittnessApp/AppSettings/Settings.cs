using FittnessApp.Utils;
using Xamarin.Essentials;

namespace FittnessApp.AppSettings
{
    public static class Settings
    {
        /// <summary>
        /// Settings enums for easier identity of saved items
        /// </summary>
        public enum Setting
        {
            AppTheme,
            IsLoggedIn,
            DefaultSourceLanguage,
            DefaultTargetLanguage,
            DataConsentStatus
        }

        /// <summary>
        /// Theme enums for easier identity of saved items
        /// </summary>
        public enum Theme
        {
            LightTheme,
            DarkTheme,
            SystemPreferred
        }

        /// <summary>
        /// Method to get setting
        /// </summary>
        /// <param name="preference">Takes in settings enum</param>
        /// <returns>Setting string</returns>
        public static string GetSetting(Setting preference)
        {
            bool hasKey = Preferences.ContainsKey(EnumsConverter.ConvertToString(preference));

            if (hasKey)
            {
                return Preferences.Get(EnumsConverter.ConvertToString(preference), null);
            }

            return null;
        }
    }
}
