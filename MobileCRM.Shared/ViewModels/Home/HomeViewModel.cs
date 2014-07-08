﻿using MobileCRM.Shared.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileCRM.Shared.ViewModels
{
  public class HomeViewModel : BaseViewModel
  {
    public ObservableCollection<MenuItem> MenuItems { get; set; }
    public HomeViewModel()
    {
      Title = "Mobile CRM";
      MenuItems = new ObservableCollection<MenuItem>();
      MenuItems.Add(new MenuItem
      {
        Id = 0,
        Title = "Dashboard",
        MenuType = MenuType.Dashboard,
        Icon = "account.png"
      }); MenuItems.Add(new MenuItem
      {
        Id = 1,
        Title = "Accounts",
        MenuType = MenuType.Accounts,
        Icon = "account.png"
      });
      MenuItems.Add(new MenuItem
      {
        Id = 2,
        Title = "Leads",
        MenuType = MenuType.Leads,
        Icon = "lead.png"
      });
      MenuItems.Add(new MenuItem
      {
        Id = 3,
        Title = "Contacts",
        MenuType = MenuType.Contacts,
        Icon = "contact.png"
      });
    }

  }
}
