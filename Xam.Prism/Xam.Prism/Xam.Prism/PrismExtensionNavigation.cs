using System;
using static Xam.Prism.Enums.NavigationEnums;

namespace Xam.Prism
{
    static class PrismExtensionNavigation
    {
        public static string GetBaseNavigationPage()
        {
            return RootPagesForNavigation.NavigationPage.ToString();
        }
        public static Uri GetMasterDetailPageUri()
        {
            return new Uri(RootPagesForNavigation.CustomMasterDetailPage.ToString(), UriKind.Relative);
        }
    }
}