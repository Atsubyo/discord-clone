using System.Collections.ObjectModel;
using System.Linq;

namespace discord_clone.MVVM.Model {
    public class ContactModel {
        public string Username { get; set; }
        public string CustomStatus { get; set; }
        public string ProfilePic { get; set; }
        public ObservableCollection<MessageModel> Messages { get; set; }
    }
}
