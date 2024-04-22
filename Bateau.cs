abstract class Bateau
{
    public string Type;
    public int capaciteMax;
    public List<string> inventaire;

    public bool SetPassagers(int nombre)
    {
        return nombre <= capaciteMax;
    }

    public bool VerifierInventaire()
    {
        
        return true;
    }
}