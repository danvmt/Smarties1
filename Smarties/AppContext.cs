using System;
namespace Smarties
{
    public static class AppContext
    {
        private static GeneralSettingsPage generalSettings;
        public static GeneralSettingsPage GeneralSettings
        {
            get { return generalSettings = generalSettings ?? new GeneralSettingsPage(); }
        }
    }
}
