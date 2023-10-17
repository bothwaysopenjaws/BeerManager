using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerManager.App.Model
{
    /// <summary>
    /// Gestionnaire de bières
    /// </summary>
    public class BeerMana
    {
        #region Attributes

        /// <summary>
        /// Bières
        /// </summary>
        private List<Beer> _Beers;

        /// <summary>
        /// Brasseurs
        /// </summary>
        private List<Brewer> _Brewers;

        /// <summary>
        /// 
        /// </summary>
        private List<BeerType> _BeerTypes;

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public List<Beer> Beers { get => _Beers; set => _Beers = value; }

        /// <summary>
        /// 
        /// </summary>
        public List<Brewer> Brewers { get => _Brewers; set => _Brewers = value; }

        /// <summary>
        /// 
        /// </summary>
        public List<BeerType> BeerTypes { get => _BeerTypes; set => _BeerTypes = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Manager
        /// </summary>
        public BeerMana()
        {
            this.Beers = new List<Beer>(); 
            this.Brewers = new List<Brewer>();
            this.BeerTypes = new List<BeerType>();

            this.GenerateDatas();
        }


        #endregion

        #region Methods

        /// <summary>
        /// Génère les données de base.
        /// </summary>
        private void GenerateDatas()
        {

            #region Ajout des types

            // Instanciation d'un type de bière
            BeerType blondType = new BeerType();
            blondType.Name = "Blonde";

            BeerType whiteType = new BeerType();
            blondType.Name = "Blanche";
            // Syntaxe alternative
            BeerType blackType = new BeerType() { Name = "Noire" };

            // En passant par le constructeur
            BeerType brownType = new BeerType("Brune");

            // On instancie la liste des types
            this.BeerTypes.Add(blondType);
            this.BeerTypes.Add(whiteType);
            this.BeerTypes.Add(blackType);
            this.BeerTypes.Add(brownType);

            #endregion

            #region Ajout des brasseurs

            Brewer firstBrewer = new Brewer("Lancelot", "France");
            Brewer secondBrewer = new Brewer("Heineken", "Pays-Bas");
            Brewer thirdBrewer = new Brewer("Carlsberg", "Danemark");

            this.Brewers.Add(firstBrewer);
            this.Brewers.Add(secondBrewer);
            this.Brewers.Add(thirdBrewer);

            #endregion

            #region Bières

            this.Beers.Add(new Beer() { Name = "Correff", Degree = 8, Brewer = firstBrewer, Type = blondType });

            #endregion

        }

        #endregion


    }
}
