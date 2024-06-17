namespace OfferteDemo.Models;

public class MateriaalSoort
{
    public string Naam { get; set; }

    public double PrijsPerM2 { get; set; } = 0;

    /// <summary>
    /// Minimale hoogte van de spatrand in mm
    /// </summary>
    public double SpatrandMinHoogte { get; set; } = 0;
    /// <summary>
    /// Maximale hoogte van de spatrand in mm
    /// </summary>
    public double SpatrandMaxHoogte { get; set; } = 0;
    /// <summary>
    /// Prijs van de spatrand per meter
    /// </summary>
    public double SpatrandPerM { get; set; } = 0;

    /// <summary>
    /// Minimale hoogte van de vensterbank in mm
    /// </summary>
    public double VensterbankMinBreedte { get; set; } = 0;
    /// <summary>
    /// Maximale hoogte van de vensterbank in mm
    /// </summary>
    public double VensterbankMaxBreedte { get; set; } = 0;
    /// <summary>
    /// Prijs van de vensterbank per meter
    /// </summary>
    public double VensterbankPerM { get; set; } = 0;

    /// <summary>
    /// Mogelijkheid tot randafwerking
    /// </summary>
    public bool Randafwerking { get; set; }
    /// <summary>
    /// Prijs van de randafwerking per meter
    /// </summary>
    public double RandafdwerkingPerM { get; set; } = 0;

    /// <summary>
    /// Mogelijkheid tot boorgaten
    /// </summary>
    public bool Boorgaten { get; set; }
    public double BoorgatenPerStuk { get; set; } = 0;

    /// <summary>
    /// Mogelijkheid tot het plaatsen van een wand contact doos
    /// </summary>
    public bool WCD { get; set; }
    public double WCDPrijs { get; set; } = 0;

    public double UitsparingOnderbouw { get; set; } = 0;
    public double UitsparingInleg { get; set; } = 0;
    public double UitsparingRuw { get; set; } = 0;
    public double Kraangat { get; set; } = 0;
    public double Zeepdispenser { get; set; } = 0;

    public double AchterwandPerM { get; set; } = 0;
    public double AchterwandAfwerkingPerM { get; set; } = 0;

    public static List<MateriaalSoort> Default() =>
    [
        new()
        {
            Naam  = "Noble Desiree Grey Matt",
            SpatrandMinHoogte = 0,
            SpatrandMaxHoogte = 150,
            VensterbankMinBreedte = 150,
            VensterbankMaxBreedte = 0,
            Boorgaten = true,
            WCD = true,
            Randafwerking = false,
            PrijsPerM2 = 247.52,
            RandafdwerkingPerM = 87,
            SpatrandPerM = 35,
            VensterbankPerM = 309.40,
            UitsparingOnderbouw = 151.5,
            UitsparingInleg = 97.5,
            UitsparingRuw = 70,
            Kraangat = 10.7,
            Zeepdispenser = 10.7,
            BoorgatenPerStuk = 5,
            WCDPrijs = 13.50,
            AchterwandPerM = 309.4,
            AchterwandAfwerkingPerM = 28
        },
        new()
        {
            Naam  = "Noble Carrara Verzoet",
            SpatrandMinHoogte = 150,
            SpatrandMaxHoogte = 0,
            VensterbankMinBreedte = 0,
            VensterbankMaxBreedte = 150,
            Boorgaten = true,
            WCD = true,
            Randafwerking = true,
            PrijsPerM2 = 258.40,
            RandafdwerkingPerM = 87,
            SpatrandPerM = 309.40,
            VensterbankPerM = 35,

            AchterwandPerM = 315.6,

            UitsparingOnderbouw = 151.5,
            UitsparingInleg = 97.5,
            UitsparingRuw = 70,
            Kraangat = 10.7,
            Zeepdispenser = 10.7,
            BoorgatenPerStuk = 5,
            WCDPrijs = 13.50,
            AchterwandAfwerkingPerM = 28
        },
        new()
        {
            Naam  = "Taurus Terazzo White Verzoet",
            SpatrandMinHoogte = 0,
            SpatrandMaxHoogte = 150,
            VensterbankMinBreedte = 0,
            VensterbankMaxBreedte = 150,
            Boorgaten = false,
            WCD = false,
            Randafwerking = true,
            PrijsPerM2 = 239.4,
            RandafdwerkingPerM = 79,
            SpatrandPerM = 35,
            VensterbankPerM = 35,

            AchterwandPerM = 298.5,

            UitsparingOnderbouw = 151.5,
            UitsparingInleg = 97.5,
            UitsparingRuw = 70,
            Kraangat = 10.7,
            Zeepdispenser = 10.7,
            BoorgatenPerStuk = 5,
            WCDPrijs = 13.50,
            AchterwandAfwerkingPerM = 28
        },
        new()
        {
            Naam  = "Taurus Terazzo Black",
            SpatrandMinHoogte = 150,
            SpatrandMaxHoogte = 0,
            VensterbankMinBreedte = 150,
            VensterbankMaxBreedte = 0,
            Boorgaten = true,
            WCD = true,
            Randafwerking = true,
            PrijsPerM2 = 228.5,
            RandafdwerkingPerM = 79,
            SpatrandPerM = 309.4,
            VensterbankPerM = 309.4,

            AchterwandPerM = 289.5,

            UitsparingOnderbouw = 151.5,
            UitsparingInleg = 97.5,
            UitsparingRuw = 70,
            Kraangat = 10.7,
            Zeepdispenser = 10.7,
            BoorgatenPerStuk = 5,
            WCDPrijs = 13.50,
            AchterwandAfwerkingPerM = 28
        },
        new()
        {
            Naam  = "Glencoe Verzoet",
            SpatrandMinHoogte = 0,
            SpatrandMaxHoogte = 0,
            VensterbankMinBreedte = 150,
            VensterbankMaxBreedte = 0,
            Boorgaten = false,
            WCD = false,
            Randafwerking = true,
            PrijsPerM2 = 305.5,
            RandafdwerkingPerM = 95,
            SpatrandPerM = 350,
            VensterbankPerM = 340.5,

            AchterwandPerM = 315.6,

            UitsparingOnderbouw = 151.5,
            UitsparingInleg = 97.5,
            UitsparingRuw = 70,
            Kraangat = 10.7,
            Zeepdispenser = 10.7,
            BoorgatenPerStuk = 5,
            WCDPrijs = 13.50,
            AchterwandAfwerkingPerM = 28
        }
    ];
}
