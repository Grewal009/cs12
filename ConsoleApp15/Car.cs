namespace ConsoleApp15;

public class Car
{
    //// En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell, registreringsnummer og kilometerstand. Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, eller han kan velge å finne en bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand. Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.

    private string _brand;
    private int _yearModel;
    private string _registrationNumber;
    private int _km;

    //properties
    public int YearModel => _yearModel;
    public int Km => _km;


    public Car(string Brand, int YearModel, string ResistrationNumber,int Km)
    {
        _brand = Brand;
        _yearModel = YearModel;
        _registrationNumber = ResistrationNumber;
        _km = Km;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {_brand}, Year Model: {_yearModel}, Resitration Number: {_registrationNumber}, KM: {_km}");
    }

    

}