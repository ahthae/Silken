using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using esquire.Data.Fusion;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace esquire.ViewModels.AnalysisMode;

public class UserDialogCloseMessage : DialogCloseMessage {}
public class ConfirmDatabaseUserMessage { }

public partial class UserDialogViewModel : ViewModelBase
{
    public class UserDialogUser
    {
        public string? Username { get; set; }
        public string? UserGuid { get; set; }
        public decimal? UserId { get; set; }
    }
    
    [ObservableProperty] private ObservableCollection<UserDialogUser>? _users;
    [ObservableProperty] private UserDialogUser? _selectedUser;

    public UserDialogViewModel() 
    {

        SelectedUser = new UserDialogUser()
        {
            Username = "",
            UserGuid = "Loading users please wait",
            UserId = 0
        };

        PopulateUsers = PopulateUsersAsync;
    }
    
    [RelayCommand]
    public void OnConfirm() => WeakReferenceMessenger.Default.Send(new ConfirmDatabaseUserMessage());
    [RelayCommand]
    public void OnCancel() => WeakReferenceMessenger.Default.Send(new UserDialogCloseMessage());
    public Func<string?,CancellationToken,Task<IEnumerable<object>>> PopulateUsers { get; }

    private async Task<IEnumerable<object>> PopulateUsersAsync(string? text, CancellationToken token)
    {
        return from user in Enumerable.Where<UserDialogUser>(Users, user => user.Username?.Contains(text ?? "", StringComparison.OrdinalIgnoreCase) ?? false )
            select user;
    }

    public async Task UpdateDatabaseUsersAsync()
    {
        try
        {
            Users = await QueryDatabaseUsersAsync();
            SelectedUser = null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error querying database for users {ex.Message}\n{ex.StackTrace}"); //TODO show is UI
        }
    }

    private static async Task<ObservableCollection<UserDialogUser>> QueryDatabaseUsersAsync()
    {
            FusionContext? db = App.Current!.Services.GetService<FusionContext>();
            var users = db!.PerUsers
                                       .Where(user => user.ActiveFlag == "Y")
                                       .Select(u => new UserDialogUser{ Username = u.Username, UserGuid = u.UserGuid, UserId = u.UserId })
                                       .ToListAsync();
            return new ObservableCollection<UserDialogUser>(await users);
    }
}