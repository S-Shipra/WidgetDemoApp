namespace WidgetDemoApp.Pages;

public partial class MainPage : ContentPage
{
    int likeCount = 0;

    public List<string> Skills { get; } = new() { "C#", ".NET MAUI", "XAML", "Git" };

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    void OnLikeClicked(object sender, EventArgs e)
    {
        likeCount++;
        LikeButton.Text = $"Like ({likeCount})";
    }

    void OnResetClicked(object sender, EventArgs e)
    {
        likeCount = 0;
        LikeButton.Text = "Like (0)";
    }

    async void OnMessageClicked(object sender, EventArgs e)
    {
        Spinner.IsVisible = true;
        Spinner.IsRunning = true;
        await Task.Delay(1500);
        Spinner.IsRunning = false;
        Spinner.IsVisible = false;
        await DisplayAlertAsync("Message", "Message sent!", "OK");
    }

    async void OnPostClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(CommentEntry.Text))
        {
            await DisplayAlertAsync("Comment", "Type a comment first.", "OK");
            return;
        }
        CommentLabel.Text = $"Your comment: {CommentEntry.Text}";
        CommentEntry.Text = "";
    }

    void OnSwitchToggled(object sender, ToggledEventArgs e)
    {
        AvailLabel.Text = e.Value ? "Yes" : "No";
    }

    async void OnSkillSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0) return;
        string skill = e.CurrentSelection[0].ToString();
        ((CollectionView)sender).SelectedItem = null;
        await DisplayAlertAsync("Skill", skill, "OK");
    }
}