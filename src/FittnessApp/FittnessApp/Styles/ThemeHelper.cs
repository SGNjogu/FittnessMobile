using FittnessApp.AppSettings;

namespace FittnessApp.Styles
{
    public class ThemeHelper
    {
        /// <summary>
        /// Get's and applies the users preferred Theme
        /// </summary>
        public static void GetAppTheme()
        {
            string theme = Settings.GetSetting(Settings.Setting.AppTheme);

            if (!string.IsNullOrEmpty(theme))
            {
                var appTheme = EnumsConverter.ConvertToEnum<Settings.Theme>(theme);

                switch (appTheme)
                {
                    case Settings.Theme.LightTheme:
                        ChangeToLightTheme();
                        break;
                    case Settings.Theme.DarkTheme:
                        ChangeToDarkTheme();
                        break;
                    case Settings.Theme.SystemPreferred:
                        ChangeToSystemPreferredTheme();
                        break;
                    default:
                        ChangeToSystemPreferredTheme();
                        break;
                }
            }
            else
            {
                ChangeToSystemPreferredTheme();
            }
        }

        ///// <summary>
        ///// Changes theme to Light Theme
        ///// </summary>
        //public static void ChangeToLightTheme()
        //{
        //    Application.Current.Resources = new LightTheme();
        //    DependencyService.Get<IStatusBar>().ChangeStatusBarColorToWhite();
        //    Settings.AddSetting(Settings.Setting.AppTheme, EnumsConverter.ConvertToString(Settings.Theme.LightTheme));
        //}

        ///// <summary>
        ///// Changes to Dark Theme
        ///// </summary>
        //public static void ChangeToDarkTheme()
        //{
        //    Application.Current.Resources = new DarkTheme();
        //    DependencyService.Get<IStatusBar>().ChangeStatusBarColorToBlack();
        //    Settings.AddSetting(Settings.Setting.AppTheme, EnumsConverter.ConvertToString(Settings.Theme.DarkTheme));
        //}

        ///// <summary>
        ///// Changes to SystemPreferred Theme
        ///// </summary>
        //public static void ChangeToSystemPreferredTheme()
        //{
        //    AppTheme appTheme = AppInfo.RequestedTheme;

        //    if (appTheme == AppTheme.Dark)
        //    {
        //        ChangeToDarkTheme();
        //    }
        //    else if (appTheme == AppTheme.Light)
        //    {
        //        ChangeToLightTheme();
        //    }
        //    else
        //    {
        //        ChangeToLightTheme();
        //    }

        //    Settings.AddSetting(Settings.Setting.AppTheme, EnumsConverter.ConvertToString(Settings.Theme.SystemPreferred));
        //}

        /// <summary>
        /// Method to get imagePath depending on selected Theme
        /// </summary>
        /// <param name="image">Takes in the image name</param>
        /// <returns>Returns image path</returns>
        //public static string ImagePath(string image)
        //{
        //    //string theme = Settings.GetSetting(Settings.Setting.AppTheme);

        //    //if (!string.IsNullOrEmpty(theme))
        //    //{
        //    //    var appTheme = EnumsConverter.ConvertToEnum<Settings.Theme>(theme);

        //    //    switch (appTheme)
        //    //    {
        //    //        case Settings.Theme.LightTheme:
        //    //            return ImageUtility.ReturnImageSourceFromFile(image);
        //    //        case Settings.Theme.DarkTheme:
        //    //            return ImageUtility.ReturnImageSourceFromFile($"{image}_dark");
        //    //        default:
        //    //            AppTheme _theme = AppInfo.RequestedTheme;

        //    //            if (_theme == AppTheme.Dark)
        //    //            {
        //    //                return ImageUtility.ReturnImageSourceFromFile($"{image}_dark");
        //    //            }
        //    //            else
        //    //            {
        //    //                return ImageUtility.ReturnImageSourceFromFile(image);
        //    //            }
        //    //    }
        //    //}

        //    return ImageUtility.ReturnImageSourceFromFile(image);
        //}
    }
}