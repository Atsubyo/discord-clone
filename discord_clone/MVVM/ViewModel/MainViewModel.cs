using discord_clone.MVVM.Model;
using System;
using System.Collections.ObjectModel;

namespace discord_clone.MVVM.ViewModel {
    class MainViewModel {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public ObservableCollection<ServerModel> Servers { get; set; }
        public MainViewModel() {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();
            Servers = new ObservableCollection<ServerModel>();

            Messages.Add(new MessageModel {
                Username = "Samuel",
                UsernameColor = "#409aff",
                ProfilePic = "https://i.imgur.com/Fu4GB1n.png",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 3; i++) {
                Messages.Add(new MessageModel {
                    Username = "Samuel",
                    UsernameColor = "#409aff",
                    ProfilePic = "https://i.imgur.com/Fu4GB1n.png",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }

            for (int i = 0; i < 4; i++) {
                Messages.Add(new MessageModel {
                    Username = "Ditto",
                    UsernameColor = "#409aff",
                    ProfilePic = "https://i.imgur.com/4WYEH8I.jpeg",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                });
            }

            Messages.Add(new MessageModel {
                Username = "Ditto",
                UsernameColor = "#409aff",
                ProfilePic = "/Themes/ditto_pikachu.jpeg",
                Message = "Last",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            for (int i = 0; i < 20; i++) {
                Contacts.Add(new ContactModel {
                    Username = $"Samuel {i}",
                    CustomStatus = "Alive",
                    ProfilePic = "/Icons/andrew_profile.png",
                    Messages = Messages
                });
            }

            for (int i = 0; i < 10; i++) {
                Servers.Add(new ServerModel {
                    ServerName = $"Five Guys {i}",
                    ServerIcon = "/Icons/snom_with_knife.jpg"
                });
            }
        }
    }
}
