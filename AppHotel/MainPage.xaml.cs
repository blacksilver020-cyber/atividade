namespace AppHotel;

public partial class MainPage : ContentPage
{
    private readonly HotelViewModel _viewModel = new();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = _viewModel;
        _viewModel.Status = "Preencha os dados para solicitar sua reserva.";
    }

    private async void OnReserveClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_viewModel.GuestName))
        {
            await DisplayAlert("Atenção", "Informe o nome do hóspede.", "OK");
            return;
        }

        _viewModel.Status = $"Solicitação preparada para {_viewModel.GuestName}.";
        await DisplayAlert("Solicitação registrada",
            $"Hóspede: {_viewModel.GuestName}\nAcomodação: {_viewModel.RoomType}\n" +
            $"Entrada: {_viewModel.CheckIn:dd/MM/yyyy}\nHóspedes: {_viewModel.Guests:0}",
            "OK");
    }
}
