# create-a-modern-conversational-ui-with-dotnet-maui-chat-control
Learn how to create modern chat layouts and bind messages with various formats, including text, images, and more. Additionally, discover how to dynamically send messages using external textboxes and buttons.

## Sample

```xaml  

     <Grid RowDefinitions="50, *" ColumnDefinitions="0.7*,0.3*">
        <Entry x:Name="entry"></Entry>
        <Button Grid.Row="0" Grid.Column="1"
                Text="Send"
                WidthRequest="100"
                Margin="2"
                Clicked="Button_Clicked"></Button>
        <sf:SfChat Grid.Row="1" Grid.ColumnSpan="2"
            Messages="{Binding Messages}"
            CurrentUser="{Binding Reciver}"
            ShowTimeBreak="True"></sf:SfChat>
    </Grid>

Code Behind :

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
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.