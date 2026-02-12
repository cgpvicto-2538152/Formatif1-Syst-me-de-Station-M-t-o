namespace StationMeteo.Metier;

/// <summary>
/// Classe CapteurMeteo qui représente un capteur de meteo
/// </summary>
public class CapteurMeteo
{

    private string? _nom;
    private double _temperature;
    private double _humidite;

    /// <summary>
    /// Nom
    /// </summary>
    public string Nom
    {
        get { return _nom!; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Le nom ne peut pas etre vide ou null");
            }
            if (ContientDesChiffres(value))
            {
                throw new ArgumentException("Le nom ne peut pas contenir de chiffre");
            }
            _nom = value;
        }
    }

    /// <summary>
    /// Temperature
    /// </summary>
    public double Temperature
    {
        get { return _temperature; }
        private set
        {
            if (value < -60 )
            {
                _temperature = -60;
            }
            else if (value > 60)
            {
                _temperature = 60;
            }
            else
            {
                _temperature = value;
            }
        }
    }

    /// <summary>
    /// Humidite
    /// </summary>
    public double Humidite
    {
        get { return _humidite; }
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Humidite doit etre entre 0 et 100");
            }
            _humidite = value;
        }
    }

    /// <summary>
    /// Verifie si le texte contient des chiffres
    /// </summary>
    /// <param name="texte">String a verifier</param>
    /// <returns> True si le texte contient des chiffres, False sinon</returns>
    /// <remarks>
    /// Static parce que c'est une methode de classe et non d'instance
    /// </remarks>
    private static bool ContientDesChiffres(string texte)
    {
        foreach (char c in texte)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Constructeur qui accepte uniquement le nom
    /// </summary>
    /// <param name="nom">Le nom</param>
    public CapteurMeteo(string nom)
    {
        Nom = nom;
    }

    /// <summary>
    /// Constructeur qui accepte les 3 paramètres
    /// </summary>
    /// <param name="nom">Le nom</param>
    /// <param name="temperature">La temperature</param>
    /// <param name="humidite">L'humidite</param>
    public CapteurMeteo(string nom, double temperature, double humidite)
    {
        Nom = nom;
        Temperature = temperature;
        Humidite = humidite;
    }


}
