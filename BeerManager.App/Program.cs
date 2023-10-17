// See https://aka.ms/new-console-template for more information
using BeerManager.App.Model;

Console.WriteLine("Hello, World!");

// On défini un booléen pour savoir si on continue le programme ou non
bool keepGoing = true;


#region Ajout des types

// Instanciation d'un type de bière
BeerType blondType = new BeerType();
blondType.Name = "Blonde";

BeerType whiteType = new BeerType();
blondType.Name = "Blanche";
// Syntaxe alternative
BeerType blackType = new BeerType(){ Name = "Noire"};

// En passant par le constructeur
BeerType brownType = new BeerType("Brune");

// On instancie la liste des types
List<BeerType> beerTypes = new List<BeerType>();

beerTypes.Add(blondType);
beerTypes.Add(whiteType);
beerTypes.Add(blackType);
beerTypes.Add(brownType);

#endregion

#region Ajout des brasseurs

Brewer firstBrewer = new Brewer("Lancelot", "France");
Brewer secondBrewer = new Brewer("Heineken", "Pays-Bas");
Brewer thirdBrewer = new Brewer("Carlsberg", "Danemark");

List<Brewer> brewers = new List<Brewer>();
brewers.Add(firstBrewer);
brewers.Add(secondBrewer);
brewers.Add(thirdBrewer);

#endregion

#region Bières

List<Beer> beers = new List<Beer>();
beers.Add(new Beer() { Name = "Correff", Degree = 8, Brewer = firstBrewer, Type = blondType });

#endregion

// Boucle du menu
do
{


    // Nettoie la console.
    Console.Clear();

    Console.WriteLine("Mon bar à bière");
    Console.WriteLine("1 - Ajouter des bières");
    Console.WriteLine("2 - Supprimer des bières");
    Console.WriteLine("3 - Ajouter ou réduire du stock de bières");
    Console.WriteLine("4 - Sortir");

    // Récupération du choix de l'utilisateur
    // Le point d'interrogation indique que la variable est nullable.
    string? userChoice = Console.ReadLine();

    //
    switch (userChoice)
    {
        case "1":
            Console.WriteLine("C'est parti pour l'ajout !");
            beers.ForEach(beerTemp => Console.WriteLine(beerTemp.Name + Environment.NewLine));
            break;
        case "2":
            Console.WriteLine("Supprimer des bières");
            break;
        case "3":
            Console.WriteLine("Gestion du stock");
            break;
        case "4":
            keepGoing = false;
            break;
        default:
            break;
    }

    Console.WriteLine("Appuyer sur une touche pour continuer...");
    Console.ReadKey();

} while (keepGoing);
