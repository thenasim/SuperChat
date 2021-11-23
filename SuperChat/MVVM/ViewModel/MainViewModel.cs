using SuperChat.Core;
using SuperChat.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChat.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */
        public RelayCommand SendCommand { get; set; }
        private ContactModel _selectedContactModel;

        public ContactModel SelectedContact
        {
            get { return _selectedContactModel; }
            set 
            { 
                _selectedContactModel = value;
                OnPropertyChanged();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message; }
            set
            { 
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new();
            Contacts = new();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel { Message = Message, FirstMessage = false });
                Message = "";
            });

            Messages.Add(new()
            {
                Username = "Nasim",
                UsernameColor = "#409aff",
                ImageSource = "https://i.imgur.com/i2szTsp.png",
                Message = "Hello",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            foreach (int _ in Enumerable.Range(1, 3))
            {
                Messages.Add(new()
                {
                    Username = "Nasim",
                    UsernameColor = "#409aff",
                    ImageSource = "https://images.unsplash.com/photo-1586083702768-190ae093d34d?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzNzY1NzUwMg&ixlib=rb-1.2.1&q=80&utm_campaign=api-credit&utm_medium=referral&utm_source=unsplash_source&w=1080",
                    Message = "Hello",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            foreach (int _ in Enumerable.Range(1, 3))
            {
                Messages.Add(new()
                {
                    Username = "Mehedi",
                    UsernameColor = "#409aff",
                    ImageSource = "https://images.unsplash.com/photo-1586083702768-190ae093d34d?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzNzY1NzUwMg&ixlib=rb-1.2.1&q=80&utm_campaign=api-credit&utm_medium=referral&utm_source=unsplash_source&w=1080",
                    Message = "Test 1",
                    Time = DateTime.Now,
                    IsNativeOrigin = true,
                });
            }

            Messages.Add(new()
            {
                Username = "Mehedi",
                UsernameColor = "#409aff",
                ImageSource = "https://images.unsplash.com/photo-1586083702768-190ae093d34d?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzNzY1NzUwMg&ixlib=rb-1.2.1&q=80&utm_campaign=api-credit&utm_medium=referral&utm_source=unsplash_source&w=1080",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            foreach (int count in Enumerable.Range(1, 5))
            {
                Contacts.Add(new()
                {
                    Username = $"Mehedi {count}",
                    ImageSource = "https://images.unsplash.com/photo-1586083702768-190ae093d34d?crop=entropy&cs=tinysrgb&fit=max&fm=jpg&ixid=MnwxfDB8MXxyYW5kb218MHx8fHx8fHx8MTYzNzY1NzUwMg&ixlib=rb-1.2.1&q=80&utm_campaign=api-credit&utm_medium=referral&utm_source=unsplash_source&w=1080",
                    Messages = Messages
                });
            }
        }
    }
}
