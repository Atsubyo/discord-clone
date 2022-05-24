using System;

namespace discord_clone.MVVM.Model {
    public class MessageModel {
        public string Username { get; set; }
        public string UsernameColor { get; set; }
        public string ProfilePic { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool? FirstMessage { get; set; }
    }
}
