using ExoTDD.Classes;
using NUnit.Framework;

namespace TestExoTDD.Classes;

[TestFixture]
public class TestRechercheVille
{
    private List<String> _villes;
    private RechercheVille _rechercheVille;

    [OneTimeSetUp]
    public void TestSetup()
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

    [TestCase("I")]
    public void TestRechercher_ExceptionWhenLessThan2Characters(string word)
    {
        Assert.Throws<NotFoundException>(() => _rechercheVille.Rechercher(word));
    }

    [OneTimeTearDown]
    public void TestTeardown()
    {
        _rechercheVille = null!;
        _villes = null!;
    }
}