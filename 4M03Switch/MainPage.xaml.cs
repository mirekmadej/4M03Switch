namespace _4M03Switch
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void onSwitchToggled(object sender, EventArgs e)
        {
            if (swBold.IsToggled)
                lblText.FontAttributes = FontAttributes.Bold;
            else
                lblText.FontAttributes = FontAttributes.None;
        }

    }

}
