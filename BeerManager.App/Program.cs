// See https://aka.ms/new-console-template for more information
using BeerManager.App.Model;
using System.Runtime.CompilerServices;
using System.Text;

Console.WriteLine("Hello, World!");

// On défini un booléen pour savoir si on continue le programme ou non
bool keepGoing = true;

BeerMana beerManager = new BeerMana();


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
            Beer beer = new Beer(); 
            Console.WriteLine("C'est parti pour l'ajout ! Liste actuelle : " + Environment.NewLine);
            beerManager.Beers.ForEach(beerTemp => Console.WriteLine(beerTemp.Name + Environment.NewLine));
            Console.WriteLine("Indiquez le nom de la bière : ");
            beer.Name = Console.ReadLine();
            Console.WriteLine("Indiquez son degré d'alcool");
            float degree;

            string? userDegreeInput = Console.ReadLine();
            while (float.TryParse(userDegreeInput, out degree))
            {
                Console.WriteLine("Saisie du degrée incorrecte, ressaisissez");
                userDegreeInput = Console.ReadLine();
            }
            beer.Degree = degree;

            Console.WriteLine("Maintenant, le type, indiquez le nom correspondant parmi la liste suivante : ");
            beerManager.BeerTypes.ForEach(bt => Console.WriteLine(bt.Name));

            bool isTypeNeed = true;
            string? inputBeerTypeUser = Console.ReadLine();
            while (isTypeNeed)
            {
                if (beerManager.BeerTypes.Any(bt => (bt.Name ?? "").ToLower() == (inputBeerTypeUser ?? "").ToLower()))
                {
                    beer.Type = beerManager.BeerTypes.First(bt => (bt.Name ?? "").ToLower() == (inputBeerTypeUser ?? "").ToLower());
                    isTypeNeed = false;
                }
                else
                {
                    Console.WriteLine("Veuillez ressaisir le type");
                    inputBeerTypeUser = Console.ReadLine();
                }
            }

            Console.WriteLine("Maintenant, le brasseur, indiquez le nom correspondant parmi la liste suivante : ");
            beerManager.Brewers.ForEach(bw => Console.WriteLine(bw.Name + Environment.NewLine));
            string? brewerInput = Console.ReadLine();
            bool isBrewerNeeded = true;
            while (isBrewerNeeded)
            {

                if (beerManager.Brewers.Any(bt => (bt.Name ?? "").ToLower() == brewerInput.ToLower()))
                {
                    beer.Brewer = beerManager.Brewers.First(bt => (bt.Name ?? "").ToLower() == brewerInput.ToLower());
                    isBrewerNeeded = false;
                }
                else
                {
                    Console.WriteLine("Veuillez ressaisir le type");
                    brewerInput = Console.ReadLine();

                }
            }

            beerManager.Beers.Add(beer);


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
