using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonComponents.DependencyInjection;
using PresentationLayer.Core.Views;

namespace PresentationLayer.Core.Dependencies
{
    public interface IMainViewDependency : IDependency<IMainView>
    {
    }
}
