using Syncfusion.Maui.Chat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class ChatModel
    {
        public ObservableCollection<object> Messages { get; set; }
        public Author Sender { get; set; }
        public Author Reciver { get; set; }
        public ChatModel() {
            Messages = new ObservableCollection<object>();
            Sender = new Author() { Name="Daniel", Avatar="img.png"};
            Reciver = new Author() { Name = "Jack" };
            GenerateMessages();
        }

        public void GenerateMessages()
        {
            Messages.Add(new TextMessage()
            {
                Author = Sender,
                Text = "Hi, Jack"
            });

            Messages.Add(new TextMessage()
            {
                Author = Reciver,
                Text = "Hi, Daniel"
            });

            Messages.Add(new DatePickerMessage()
            {
                Author = Sender,
                Text = "Select a date for project discussion"
            });
        }
    }
}
