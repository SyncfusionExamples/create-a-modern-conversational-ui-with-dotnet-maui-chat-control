using AndroidX.Lifecycle;
using Syncfusion.Maui.Chat;

namespace ChatApp
{
    public partial class MainPage : ContentPage
    {

        ChatModel ViewModel;
        public MainPage()
        {
            InitializeComponent();
            ViewModel = this.BindingContext as ChatModel;
        }

       public void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.entry.Text))
            {
                ViewModel.Messages.Add(new TextMessage()
                {
                    Author = ViewModel.Sender,
                    Text = this.entry.Text,
                }
           );
                this.entry.ClearValue(Entry.TextProperty);
            }
        }
    }

}
