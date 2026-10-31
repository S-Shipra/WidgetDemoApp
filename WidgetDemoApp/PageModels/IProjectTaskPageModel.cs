using CommunityToolkit.Mvvm.Input;
using WidgetDemoApp.Models;

namespace WidgetDemoApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}