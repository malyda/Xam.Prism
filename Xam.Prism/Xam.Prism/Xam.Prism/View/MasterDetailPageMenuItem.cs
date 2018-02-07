using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xam.Prism.View
{
    public class MasterDetailPageMenuItem
    {
        public MasterDetailPageMenuItem()
        {
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Page { get; set; }

        public NavigationParameters PageParameters { get; set; }
    }
}