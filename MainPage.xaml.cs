using System.Text.RegularExpressions;

namespace MauiApp8;

public partial class MainPage : ContentPage
{
    bool sur = false;
    bool nam = false;
    bool fut = false;
    bool num = false;
    bool mai = false;
    public MainPage()
    {
        InitializeComponent();
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (SurName.Text != null)
        {
            sur = TextP(SurName.Text);
        }
        if (Name.Text != null)
        {
            nam = TextP(Name.Text);
        }
        if (Name.Text != null)
        {
            fut = TextP(FuthersName.Text);
        }
        if(Number.Text != null)
        {
            Regex r = new Regex(@"^'+'(\d*)");
            num = r.IsMatch(Number.Text); 
        }
        if(Mail.Text!= null)
        {
            Regex w = new Regex(@"(\S*)'@'(\S*)");
            mai = w.IsMatch(Mail.Text);
        }
        
        string s = "QWQ";
        await DisplayAlert("QWQW", "asd", "ad", "sd");
    }
    public bool TextP(string q)
    {
        if (q.Length > 0 && q.Length < 11)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

