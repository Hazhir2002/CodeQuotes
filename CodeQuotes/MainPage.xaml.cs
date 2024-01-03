namespace CodeQuotes
{
    public partial class MainPage : ContentPage
    {
        List<string> quotes = new List<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadMauiAsset();
        }

        async Task LoadMauiAsset()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("quotes.txt");
            using var reader = new StreamReader(stream);

            while (reader.Peek() != -1)
            {
                quotes.Add(reader.ReadLine());
            }
        }

        private void btnGenerateQuote_Clicked(object sender, EventArgs e)
        {
            var random = new Random();

            var color1 = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));
            var color2 = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));
            var color3 = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));
            var color4 = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));
            var color5 = Color.FromRgb(
                random.Next(0, 256),
                random.Next(0, 256),
                random.Next(0, 256));

            gdStop1.Color = color1;
            gdStop2.Color = color2;
            gdStop3.Color = color3;
            gdStop4.Color = color4;
            gdStop5.Color = color5;

            int index = random.Next(quotes.Count);
            quote.Text = quotes[index];
        }
    }

}
