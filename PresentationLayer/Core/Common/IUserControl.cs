using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common.Layout;

namespace PresentationLayer.Core.Common
{
    public interface IUserControl
    {
        event EventHandler UserControlViewLoadingEventRaised;

        ILayout Layout { get; set; }

        void ShowUserControl();

        void InitializeUserControlLayout();

        void SetUserControlDockingToDockStyleFill();
    }
}
