using Xam.Prism.Enums;

namespace Xam.Prism.View.Pages.MasterDetailPageRoot
{
    public class CustomMasterDetailPageMenuItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public NavigationEnums.PagesForNavigation NavigationTo { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Page: {NavigationTo.ToString()}";
        }
    }
}