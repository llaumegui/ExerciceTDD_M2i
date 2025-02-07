namespace ExoTDD.Classes;

public class RechercheVille {
    
    private List<string> _villes;

    public RechercheVille(List<string> villes)
    {
        _villes = villes;
    }
   
    public List<string> Rechercher(string mot)
    {
        if (mot.Length < 2)
            throw new NotFoundException();
        
        return _villes.Where(v => v.StartsWith(mot)).ToList();
    }
}