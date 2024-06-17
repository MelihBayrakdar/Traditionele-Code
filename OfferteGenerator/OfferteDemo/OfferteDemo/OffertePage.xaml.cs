using OfferteDemo.Models;

namespace OfferteDemo;

public partial class OffertePage : ContentPage
{
    public Offerte Offerte { get; set; } = new Offerte();

    public OffertePage()
    {
        InitializeComponent();
        this.BindingContext = Offerte;
        MateriaalPicker.ItemsSource = Offerte.MateriaalSoorten;
        MateriaalPicker.SelectedIndexChanged += OnMateriaalSelectionChanged;
        MateriaalPicker.SelectedIndex = 0;
    }

    private void OnMateriaalSelectionChanged(object? sender, EventArgs e)
    {
        Offerte.MateriaalSoort = MateriaalPicker.SelectedItem as MateriaalSoort;
    }
}