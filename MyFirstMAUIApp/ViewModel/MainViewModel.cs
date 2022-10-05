using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIApp.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;
        [ObservableProperty]
        ObservableCollection<string> items;

        public MainViewModel()
        {
            items = new ObservableCollection<string>();
        }

        [RelayCommand] //command but had been replaced
        void Add()
        {
            //add our item
            if (string.IsNullOrEmpty(Text))
                return;
            items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }
    }
    
}
