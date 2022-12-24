using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using CommunityToolkit.Mvvm.Messaging;
using esquire.ViewModels;

namespace esquire.Views;

public class WindowBase<T> : Window where T : ViewModelBase
{
    protected WindowBase()
    {
        DataContext = App.Current.Services.GetService(typeof(T));
        WeakReferenceMessenger.Default.Register<OpenDialogMessage>(this, OpenDialog);
    }
    
    private void OpenDialog(object? recipient, OpenDialogMessage message)
    {
        Show();
        
        Type? dialogView = LocateViewFromViewModel(message.ViewModelType);
        if (dialogView is null)
        {
            Console.WriteLine($"Dialog error: unable to find view {message.ViewModelType}");
            return;
        }
        
        var dialog = Activator.CreateInstance(dialogView)!;
        
        ((Window?)dialog)?.ShowDialog(this);
    }

    private static Type? LocateViewFromViewModel(Type viewModel)
    {
        string name = viewModel.FullName!.Replace("ViewModel", "View");
        Type? view = Type.GetType(name);
        return view;
    }
}