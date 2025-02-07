namespace ExoTDD.Classes;

public class RechercheVille {
    private List<String> _villes;

    public RechercheVille(List<String> villes)
    {
        _villes = villes;
    }
   
    public List<String> Rechercher(String mot)
    {
        if (mot.Length < 2)
            throw new NotFoundException();

        throw new NotImplementedException();
    }
}