using System;
using static Xam.Prism.Enums.NavigationEnums;

namespace Xam.Prism
{
    static class PrismExtensionNavigation
    {
        public static string GetBaseNavigationStack()
        {
            return RootPagesForNavigation.NavigationPage.ToString();
        }

        public static string GetBaseMasterDetailPageStack()
        {
            return
                $"{RootPagesForNavigation.CustomMasterDetailPage}/{RootPagesForNavigation.NavigationPage}/{PagesForNavigation.FirstPage}";
        }

        public static Uri GetBaseMasterDetailPageUri(bool absolute = false)
        {
            if (absolute) return new Uri(GetBaseMasterDetailPageStack(), UriKind.Absolute);
            else return new Uri(GetBaseMasterDetailPageStack(), UriKind.Relative);
        }
    }
}