using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragViewSample
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion




        public static string GeneralSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(SettingsKey, value);
            }
        }






        public static string color
        {
            get
            {
                return AppSettings.GetValueOrDefault(nameof(color), SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(nameof(color), value);
            }
        }

        public static string opacity
        {
            get
            {
                return AppSettings.GetValueOrDefault(nameof(opacity), SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(nameof(opacity), value);
            }
        }

        public static string rotation
        {
            get
            {
                return AppSettings.GetValueOrDefault(nameof(rotation), SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(nameof(rotation), value);
            }
        }

        public static string sliderval
        {
            get
            {
                return AppSettings.GetValueOrDefault(nameof(sliderval), SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(nameof(sliderval), value);
            }
        }
        public static string sliderval2
        {
            get
            {
                return AppSettings.GetValueOrDefault(nameof(sliderval2), SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(nameof(sliderval2), value);
            }
        }






    }
}
