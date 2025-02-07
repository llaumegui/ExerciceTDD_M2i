using ExoTDD.Classes;
using NUnit.Framework;

namespace TestExoTDD.Classes;

[TestFixture]
public class TestRechercheVille
{
    private List<String> _villes;
    private RechercheVille _rechercheVille;

    [SetUp]
    public void TestInitialize()
    {
        // simulate a db pull
        _villes = new List<String>()
        {
            "Paris",
            "Budapest",
            "Skopje",
            "Rotterdam",
            "Valence",
            "Vancouver",
            "Amsterdam",
            "Vienne",
            "Sydney",
            "New York",
            "Londres",
            "Bangkok",
            "Hong Kong",
            "Dubaï",
            "Rome",
            "Istanbul"
        };
        
        _rechercheVille = new RechercheVille(_villes);
    }
}