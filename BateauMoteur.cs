class BateauMoteur : Bateau
{
    
    public BateauMoteur()
    {
        Type = "bateau à moteur";
        capaciteMax = 8;
        inventaire = new List<string> { "gilets de sauvetage", "bouées", "extincteur" };
    }
}