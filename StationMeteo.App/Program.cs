using StationMeteo.Metier;
namespace StationMeteo.App;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            CapteurMeteo capteurValide = new CapteurMeteo("Capteur_Nord", 12.5, 45);
            Console.WriteLine("[Capteur 1] Le capteur est valide.");
            Console.WriteLine($"Nom: {capteurValide.Nom}, Température: {capteurValide.Temperature}, Humidité: {capteurValide.Humidite}%");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Capteur 1] Erreur : {ex.Message}");
        }

        try
        {
            CapteurMeteo capteurInvalideNom = new CapteurMeteo("Capteur123", 10, 50);
            Console.WriteLine("[Capteur 2] Le capteur est valide.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"[Capteur 2] Erreur de nom : {ex.Message}");
        }

        try
        {
            CapteurMeteo capteurInvalideHumidite = new CapteurMeteo("Capteur_Sud", 15, -10);
            Console.WriteLine("[Capteur 3] Le capteur est valide.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"[Capteur 3] Erreur d'humidité : {ex.Message}");
        }




    }
}
