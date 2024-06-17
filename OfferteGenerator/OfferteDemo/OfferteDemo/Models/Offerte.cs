using System.ComponentModel;

namespace OfferteDemo.Models;

public class Offerte : INotifyPropertyChanged
{
    public Offerte()
    {
        MateriaalSoort = MateriaalSoorten[0];
    }

    public readonly List<MateriaalSoort> MateriaalSoorten = MateriaalSoort.Default();
    private MateriaalSoort? materiaalSoort;
    public MateriaalSoort? MateriaalSoort
    {
        get { return materiaalSoort; }
        set
        {
            if (value != materiaalSoort)
            {
                materiaalSoort = value;

                OnPropertyChanged(nameof(MateriaalSoort));

                OnPropertyChanged(nameof(PrijsPerM2));
                OnPropertyChanged(nameof(M2Prijs));

                OnPropertyChanged(nameof(RandafwerkingPrijsPerM));
                OnPropertyChanged(nameof(RandafwerkingPrijs));
                OnPropertyChanged(nameof(RandafwerkingVerstekMinimaalMM));
                OnPropertyChanged(nameof(RandafwerkingVerstekMaximaalMM));
                OnPropertyChanged(nameof(RandafwerkingVerstekRange));

                OnPropertyChanged(nameof(SpatrandPrijsPerM));
                OnPropertyChanged(nameof(SpatrandMinHoogte));
                OnPropertyChanged(nameof(SpatrandMaxHoogte));
                OnPropertyChanged(nameof(SpatrandPrijs));
                OnPropertyChanged(nameof(SpatrandHoogteRange));

                OnPropertyChanged(nameof(VensterbankPrijsPerM));
                OnPropertyChanged(nameof(VensterbankMinBreedte));
                OnPropertyChanged(nameof(VensterbankMaxBreedte));
                OnPropertyChanged(nameof(VensterbankPrijs));
                OnPropertyChanged(nameof(VensterbankBreedteRange));

                OnPropertyChanged(nameof(SpoelbakPrijs));

                OnPropertyChanged(nameof(KraangatPrijs));

                OnPropertyChanged(nameof(ZeepdispenserPrijs));

                OnPropertyChanged(nameof(BoorgatenPrijsPerStuk));
                OnPropertyChanged(nameof(BoorgatenPrijs));

                OnPropertyChanged(nameof(WCDPrijs));

                OnPropertyChanged(nameof(AchterwandPrijsPerM2));
                OnPropertyChanged(nameof(AchterwandPrijs));
                OnPropertyChanged(nameof(AchterwandAfwerkingPrijsPerM2));
                OnPropertyChanged(nameof(AchterwandAfwerkingPrijs));

                OnPropertyChanged(nameof(TotaalPrijs));
            }
        }
    }

    // Required
    private double aantalM2 = 0;
    public double AantalM2
    {
        get => aantalM2;
        set
        {
            if (value != aantalM2)
            {
                aantalM2 = value;
                OnPropertyChanged(nameof(AantalM2));
                OnPropertyChanged(nameof(M2Prijs));
                OnPropertyChanged(nameof(TotaalPrijs));
            }
        }
    }
    public double PrijsPerM2 => MateriaalSoort?.PrijsPerM2 ?? 0;
    public double M2Prijs => AantalM2 * PrijsPerM2;

    // Required, may be 0
    private double randafwerkingAantalM = 0;
    public double RandafwerkingAantalM
    {
        get => randafwerkingAantalM;
        set
        {
            if (value != randafwerkingAantalM)
            {
                randafwerkingAantalM = value;
                OnPropertyChanged(nameof(RandafwerkingAantalM));
                OnPropertyChanged(nameof(RandafwerkingPrijs));
                OnPropertyChanged(nameof(TotaalPrijs));
            }
        }
    }
    public double RandafwerkingPrijsPerM => MateriaalSoort?.RandafdwerkingPerM ?? 0;
    private double randafwerkingVerstekMM = 0;
    public double RandafwerkingVerstekMM
    {
        get => randafwerkingVerstekMM;
        set
        {
            value = value < RandafwerkingVerstekMinimaalMM
                ? RandafwerkingVerstekMinimaalMM
                : value > RandafwerkingVerstekMaximaalMM
                ? RandafwerkingVerstekMaximaalMM
                : value;

            if (value == randafwerkingVerstekMM)
                return;

            randafwerkingVerstekMM = value;
            OnPropertyChanged(nameof(RandafwerkingVerstekMM));
            OnPropertyChanged(nameof(TotaalPrijs));
            OnPropertyChanged(nameof(RandafwerkingVerstekRange));
        }
    }
    public double RandafwerkingVerstekMinimaalMM = 40;
    public double RandafwerkingVerstekMaximaalMM = 100;
    public double RandafwerkingPrijs => RandafwerkingAantalM * RandafwerkingPrijsPerM;
    public string RandafwerkingVerstekRange
        => "Verstek " + (RandafwerkingVerstekMaximaalMM > 0
        ? $"({RandafwerkingVerstekMinimaalMM}-{RandafwerkingVerstekMaximaalMM} mm)"
        : $">{RandafwerkingVerstekMinimaalMM}");

    // Only with specific Types
    private double spatrandAantalM = 0;
    public double SpatrandAantalM
    {
        get => spatrandAantalM;
        set
        {
            if (value == spatrandAantalM)
                return;

            spatrandAantalM = value;
            OnPropertyChanged(nameof(SpatrandAantalM));
            OnPropertyChanged(nameof(SpatrandPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    public double SpatrandPrijsPerM => MateriaalSoort?.SpatrandPerM ?? 0;
    public double SpatrandMinHoogte => MateriaalSoort?.SpatrandMinHoogte ?? 0;
    public double SpatrandMaxHoogte => MateriaalSoort?.SpatrandMaxHoogte ?? 0;
    public double SpatrandPrijs => SpatrandAantalM * SpatrandPrijsPerM;
    private double spatrandHoogte = 0;
    public double SpatrandHoogte
    {
        get => spatrandHoogte; set
        {
            if (value == spatrandHoogte)
                return;

            spatrandHoogte = value;
            OnPropertyChanged(nameof(SpatrandHoogte));
            OnPropertyChanged(nameof(SpatrandHoogteRange));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    public string SpatrandHoogteRange => "Hoogte (" + (SpatrandMaxHoogte > 0
        ? $"{SpatrandMinHoogte}-{SpatrandMaxHoogte}"
        : $"> {SpatrandMinHoogte}") + "mm)";

    private double vensterbankAantalM = 0;
    public double VensterbankAantalM
    {
        get => vensterbankAantalM; set
        {
            if (value == vensterbankAantalM)
                return;

            vensterbankAantalM = value;
            OnPropertyChanged(nameof(VensterbankAantalM));
            OnPropertyChanged(nameof(VensterbankPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    public double VensterbankPrijsPerM => MateriaalSoort?.VensterbankPerM ?? 0;
    public double VensterbankPrijs => VensterbankAantalM * VensterbankPrijsPerM;
    public double VensterbankMinBreedte => MateriaalSoort?.VensterbankMinBreedte ?? 0;
    public double VensterbankMaxBreedte => MateriaalSoort?.VensterbankMaxBreedte ?? 0;
    private double vensterbankBreedte = 0;
    public double VensterbankBreedte
    {
        get => vensterbankBreedte; set
        {
            value = value < VensterbankMinBreedte
                ? VensterbankMinBreedte
                : value > VensterbankMaxBreedte
                ? VensterbankMaxBreedte
                : value;

            if (value == vensterbankBreedte)
                return;

            vensterbankBreedte = value;
            OnPropertyChanged(nameof(VensterbankBreedte));
            OnPropertyChanged(nameof(VensterbankBreedteRange));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    public string VensterbankBreedteRange => (VensterbankMaxBreedte > 0
        ? $"{VensterbankMinBreedte}-{VensterbankMaxBreedte}"
        : $"> {VensterbankMinBreedte}") + " mm breed";

    public int SpoelbakType
    {
        get => spoelbakType; set
        {
            if (value == spoelbakType)
                return;

            spoelbakType = value;
            OnPropertyChanged(nameof(SpoelbakType));
            OnPropertyChanged(nameof(SpoelbakPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    private int spoelbakType = 0;
    public double SpoelbakPrijs => SpoelbakType switch
    {
        1 => MateriaalSoort?.UitsparingOnderbouw ?? 0,
        2 => MateriaalSoort?.UitsparingInleg ?? 0,
        3 => MateriaalSoort?.UitsparingRuw ?? 0,
        _ => 0
    };
    public double OnderbouwPrijs => MateriaalSoort?.UitsparingOnderbouw ?? 0;
    public double InlegPrijs => MateriaalSoort?.UitsparingInleg ?? 0;
    public double RuwPrijs => MateriaalSoort?.UitsparingRuw ?? 0;



    public bool Kraangat
    {
        get => kraangat; set
        {
            if (value == kraangat)
                return;

            kraangat = value;
            OnPropertyChanged(nameof(Kraangat));
            OnPropertyChanged(nameof(KraangatPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    private bool kraangat = false;
    public double KraangatØ = 36;
    public double KraangatPrijsPer => MateriaalSoort?.Kraangat ?? 0;
    public double KraangatPrijs => Kraangat ? MateriaalSoort?.Kraangat ?? 0 : 0;

    private bool zeepdispenser = false;
    public bool Zeepdispenser
    {
        get => zeepdispenser; set
        {
            if (value == zeepdispenser)
                return;

            zeepdispenser = value;
            OnPropertyChanged(nameof(Zeepdispenser));
            OnPropertyChanged(nameof(ZeepdispenserPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    public double ZeepdispenserØ = 26;
    public double ZeepdispenserPrijs => Zeepdispenser ? MateriaalSoort?.Zeepdispenser ?? 0 : 0;
    public double ZeepdispenserPrijsPer => MateriaalSoort?.Zeepdispenser ?? 0;
    public int BoorgatenAantal
    {
        get => boorgatenAantal; set
        {
            if (value == boorgatenAantal)
                return;

            boorgatenAantal = value;
            OnPropertyChanged(nameof(BoorgatenAantal));
            OnPropertyChanged(nameof(BoorgatenPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    private int boorgatenAantal = 0;
    public int BoorgatenMinMM = 0;
    public int BoorgatenMaxMM = 10;
    public int BoorgatenMM
    {
        get => boorgatenMM; set
        {
            if(value == boorgatenMM)
                return;

            boorgatenMM = value;
            OnPropertyChanged(nameof(BoorgatenMM));
        }
    }
    public string BoorgatenRange => $"{BoorgatenMinMM}-{BoorgatenMaxMM} mm";
    public double BoorgatenPrijsPerStuk => MateriaalSoort?.BoorgatenPerStuk ?? 0;
    public double BoorgatenPrijs => BoorgatenAantal * BoorgatenPrijsPerStuk;

    private bool wcd = false;
    public bool WCD
    {
        get => wcd; set
        {
            if (value == wcd)
                return;

            wcd = value;
            OnPropertyChanged(nameof(WCD));
            OnPropertyChanged(nameof(WCDPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    public double WCDPrijsPer => MateriaalSoort?.WCDPrijs ?? 0;
    public double WCDPrijs => WCD ? MateriaalSoort?.WCDPrijs ?? 0 : 0;
    public double WCDØMinMM = 60;
    public double WCDØMaxMM = 106;
    public double WCDØ = 60;

    private double achterwandAantalM2 = 0;
    public double AchterwandAantalM2
    {
        get => achterwandAantalM2; set
        {
            if (value == achterwandAantalM2)
                return;

            achterwandAantalM2 = value;
            OnPropertyChanged(nameof(AchterwandAantalM2));
            OnPropertyChanged(nameof(AchterwandPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    public double AchterwandPrijsPerM2 => MateriaalSoort?.AchterwandPerM ?? 0;
    public double AchterwandPrijs => AchterwandAantalM2 * AchterwandPrijsPerM2;

    private double achterwandAfwerkingAantalM2 = 0;
    private int boorgatenMM;

    public double AchterwandAfwerkingAantalM2
    {
        get => achterwandAfwerkingAantalM2; set
        {
            if (value == achterwandAfwerkingAantalM2)
                return;

            achterwandAfwerkingAantalM2 = value;
            OnPropertyChanged(nameof(AchterwandAfwerkingAantalM2));
            OnPropertyChanged(nameof(AchterwandAfwerkingPrijs));
            OnPropertyChanged(nameof(TotaalPrijs));
        }
    }
    public double AchterwandAfwerkingPrijsPerM2 => MateriaalSoort?.PrijsPerM2 ?? 0;
    public double AchterwandAfwerkingPrijs => AchterwandAfwerkingAantalM2 * AchterwandAfwerkingPrijsPerM2;

    public double TotaalPrijs => M2Prijs
        + RandafwerkingPrijs
        + SpatrandPrijs
        + VensterbankPrijs
        + SpoelbakPrijs
        + KraangatPrijs
        + ZeepdispenserPrijs
        + BoorgatenPrijs
        + WCDPrijs
        + AchterwandPrijs
        + AchterwandAfwerkingPrijs;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
