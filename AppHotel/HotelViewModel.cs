using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppHotel;

public class HotelViewModel : INotifyPropertyChanged
{
    private double _guests = 2;
    private DateTime _checkIn = DateTime.Today.AddDays(1);
    private string _guestName = "";
    private string _roomType = "Suíte Standard";
    private string _status = "Preencha os dados para solicitar sua reserva.";

    public event PropertyChangedEventHandler? PropertyChanged;

    public string[] RoomTypes { get; } = { "Suíte Standard", "Suíte Luxo", "Quarto Família" };
    public DateTime MinimumDate => DateTime.Today;

    public double Guests
    {
        get => _guests;
        set { if (_guests != value) { _guests = value; OnPropertyChanged(); } }
    }

    public DateTime CheckIn
    {
        get => _checkIn;
        set { if (_checkIn != value) { _checkIn = value; OnPropertyChanged(); } }
    }

    public string GuestName
    {
        get => _guestName;
        set { if (_guestName != value) { _guestName = value; OnPropertyChanged(); } }
    }

    public string RoomType
    {
        get => _roomType;
        set { if (_roomType != value) { _roomType = value; OnPropertyChanged(); } }
    }

    public string Status
    {
        get => _status;
        set { if (_status != value) { _status = value; OnPropertyChanged(); } }
    }

    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
