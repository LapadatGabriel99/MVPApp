using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Core.Common;
using System.Windows.Forms;
using PresentationLayer.Core.Views.UserControls;
using PresentationLayer.Persistence.Views.UserControls;

namespace PresentationLayer.Core.Views
{
    public interface IMainView 
    {
        event EventHandler MainViewLoadingEventRaised;
        event EventHandler MainViewLoadedEventRaised;
        event EventHandler NewsButtonClickEventRaised;
        event EventHandler PlantListButtonClickEventRaised;
        event EventHandler DepartmentListButtonClickEventRaised;
        event EventHandler HelpAboutMenuClickEventRaised;

        IUnderlineLabelConditions UnderlineLabelConditions { get; set; }

        Button NewsButton { get; }
        Button PlantsButton { get; }
        Button DepartmentsButton { get; }       

        void ShowMainView();
        void ChangeMainViewStartPosition();

        void SetUnderlineLabelStartingLocation();
        void ChangeUnderlineLabelLocation(Button button);

        void InitializeUserControlList();

        void AddUserControlsToUserControlViewPanel(List<IUserControl> userControlList);
        void DisplayUserControlOnUserControlViewPanel(IUserControl userControl);
    }
}
