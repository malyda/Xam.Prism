using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xam.Prism.View
{

    public class CustomMasterDetailPageMenuItem
    {
        public CustomMasterDetailPageMenuItem()
        {
            TargetType = typeof(CustomMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}