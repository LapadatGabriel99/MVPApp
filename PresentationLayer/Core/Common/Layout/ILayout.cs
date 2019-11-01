using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common.Layout.Docking;

namespace PresentationLayer.Core.Common.Layout
{
    public interface ILayout
    {
        IControlDocking ControlDocking { get; set; }
    }
}
