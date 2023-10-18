using BeerManager.App.Model;
using System;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {

        /**
         * https://fr.wikipedia.org/wiki/Réflexion_(informatique)
         * 
         */
        Menu();

    }

    /// <summary>
    /// Menu du programme
    /// </summary>
    public static void Menu()
    {
        BeerType beerType = new BeerType();

        // Récupération du type d'objet, 2 manières, depuis l'instance ou depuis la classe.
        Type typeV1 = beerType.GetType();
        Type typeV2 = typeof(BeerType);

        bool keepGoing = true;
        do
        {
            Console.Clear();
            Console.WriteLine("1 - Informations générales");
            Console.WriteLine("2 - Attributs");
            Console.WriteLine("3 - Propriétés");
            Console.WriteLine("4 - Constructeurs");
            Console.WriteLine("5 - Méthodes");
            Console.WriteLine("6 - Sortie");

            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    GetGeneralInfos(typeV1);
                    break;
                case "2":
                    GetAttributesInformations(typeV1);
                    break;
                case "3":
                    GetPropertiesInformations(typeV1);
                    break;
                case "4":
                    GetConstructorsInformations(typeV1);
                    break;
                case "5":
                    GetMethodInformations(typeV1);
                    break; 
                case "6":
                    keepGoing = false;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Appuyer sur une touche pour continuer");
            Console.ReadKey();

        } while (keepGoing);
    }

    /// <summary>
    /// Obtient les informations générales
    /// </summary>
    public static void GetGeneralInfos(Type typeV1)
    {
        Console.WriteLine("Nom de la classe : " + typeV1.Name);
        Console.WriteLine("Nom de la classe (v2) : " + nameof(BeerType));
        Console.WriteLine("Nom complet de la classe : " + typeV1.FullName);
        Console.WriteLine("Espace de nom de la classe : " + typeV1.Namespace);

    }

    /// <summary>
    /// Récupère les informations sur les attribut de la classe.
    /// </summary>
    /// <param name="type">type correspondant</param>
    public static void GetAttributesInformations(Type type)
    {
        TypeInfo typeInfo = type.GetTypeInfo();

        foreach (FieldInfo fieldInfo in typeInfo.DeclaredFields)
        {
            Console.WriteLine( "Nom de l'attribut : " + fieldInfo.Name );
            Console.WriteLine( "  > Type : " + fieldInfo.FieldType);
            Console.WriteLine( "  > Public : " + fieldInfo.IsPublic);
        }
    }

    /// <summary>
    /// Récupère les informations sur les propriétés de la classe.
    /// </summary>
    /// <param name="type">type correspondant</param>
    public static void GetPropertiesInformations(Type type)
    {
        TypeInfo typeInfo = type.GetTypeInfo();


        foreach (PropertyInfo propretyInfo in typeInfo.DeclaredProperties)
        {
            Console.WriteLine("Nom de la propriété : " + propretyInfo.Name);
            Console.WriteLine("  > Type : " + propretyInfo.PropertyType);
            Console.WriteLine("  > Getter public : " + propretyInfo.CanRead);
            Console.WriteLine("  > Setter public : " + propretyInfo.CanWrite);
        }
    }

    /// <summary>
    /// Récupère les informations sur les constructeurs de la classe.
    /// </summary>
    /// <param name="type">type correspondant</param>
    public static void GetConstructorsInformations(Type type)
    {
        TypeInfo typeInfo = type.GetTypeInfo();


        foreach (ConstructorInfo constructorInfo in typeInfo.DeclaredConstructors)
        {
            Console.WriteLine("Nom du constructeur : " + constructorInfo.Name);
            Console.WriteLine("  > Publique : " + constructorInfo.IsPublic);
            Console.WriteLine("  > Paramètres : " );
            foreach (ParameterInfo parameterInfo in constructorInfo.GetParameters())
            {
                Console.WriteLine("     > " + parameterInfo.ParameterType);
            }
            
        }
    }

    /// <summary>
    /// Récupère les informations sur les méthodes de la classe.
    /// </summary>
    /// <param name="type">type correspondant</param>
    public static void GetMethodInformations(Type type)
    {
        TypeInfo typeInfo = type.GetTypeInfo();

        foreach (MethodInfo methodInfo in typeInfo.DeclaredMethods)
        {
            Console.WriteLine("Nom de la méthode : " + methodInfo.Name);
            Console.WriteLine("  > Publique : " + methodInfo.IsPublic);
            Console.WriteLine("  > type de retour : " + methodInfo.ReturnType);

            Console.WriteLine("  > Paramètres : ");
            foreach (ParameterInfo parameterInfo in methodInfo.GetParameters())
            {
                Console.WriteLine("     > " + parameterInfo.ParameterType);
            }

        }
    }
}