using discord_clone.Core;
using discord_clone.MVVM.Model;
using System;
using System.Collections.ObjectModel;

namespace discord_clone.MVVM.ViewModel {
    class MainViewModel : ObservableObject {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public ObservableCollection<ServerModel> Servers { get; set; }
        public ObservableCollection<ChatSearchModel> ChatSearchMessage { get; set; }

        // Commands
        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact {
            get { return _selectedContact; }
            set {
                _selectedContact = value;
                OnPropertyChanged();
            }
        }


        private string _message;
        public string Message {
            get { return _message; }
            set {
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel() {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();
            Servers = new ObservableCollection<ServerModel>();

            SendCommand = new RelayCommand(o => {
                Messages.Add(new MessageModel {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";

            });

            for (int i = 0; i < 20; i++) {
                Contacts.Add(new ContactModel {
                    Username = $"Samuel {i}",
                    CustomStatus = "Alive",
                    ProfilePic = "/Icons/andrew_profile.png",
                    Messages = Messages
                });
            }

            for (int i = 0; i < 20; ++i) {
                Contacts[i].Messages.Add(new MessageModel {
                    Username = Contacts[i].Username,
                    UsernameColor = "#409aff",
                    ProfilePic = Contacts[i].ProfilePic,
                    Message = $"Tester {i}",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = true
                });
                for (int j = 1; j < 10; ++j) {
                    Contacts[i].Messages.Add(new MessageModel {
                        Username = Contacts[i].Username,
                        UsernameColor = "#409aff",
                        ProfilePic = Contacts[i].ProfilePic,
                        Message = $"Test {j}",
                        Time = DateTime.Now,
                        IsNativeOrigin = false,
                        FirstMessage = false
                    });
                }
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
