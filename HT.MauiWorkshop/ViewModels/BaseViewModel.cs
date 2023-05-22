using CommunityToolkit.Mvvm.ComponentModel;

namespace HT.MauiWorkshop.ViewModels;

[ObservableObject]
public partial class BaseViewModel
{
    public virtual Task OnAppearing() => Task.CompletedTask;
}