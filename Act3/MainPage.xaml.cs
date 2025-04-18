namespace Act3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Formasuma(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginasuma());
        }

        private void Formaresta(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginaresta());
        }
        private void Formamultiplicar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginamultiplicar());
        }
        private void Formadivision(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginadivision());
        }
    }

}
