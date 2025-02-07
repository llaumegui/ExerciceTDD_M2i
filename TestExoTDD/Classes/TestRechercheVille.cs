using ExoTDD.Classes;
using NUnit.Framework;
using NUnit.Framework.Legacy;

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

    [TestCase("Va")]
    public void TestRechercher_StartWithLetters(string letters)
    {
        List<string> result = _rechercheVille.Rechercher(letters);
        List<string> expected = _villes.Where(v => v.StartsWith(letters)).ToList();
        
        CollectionAssert.AreEqual(expected, result);
    }

    [OneTimeTearDown]
    public void TestTeardown()
    {
        _rechercheVille = null!;
        _villes = null!;
    }
}