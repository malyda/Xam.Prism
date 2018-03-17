using System;
using System.Collections.Generic;
using System.Text;
using Prism.Events;
using Xam.Prism.Enums;

namespace Xam.Prism.View.Events
{
    class MenuPageNavigationEvent : PubSubEvent<NavigationEnums.PagesForNavigation>
    {
    }
}
