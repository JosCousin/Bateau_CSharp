class BateauVoilier : Bateau
{
    
    public BateauVoilier()
    {
        Type = "bateau à voile";
        capaciteMax = 4;
        inventaire = new List<string> { "voiles", "cordages", "gilets de sauvetage" };
    }
}