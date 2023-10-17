using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerManager.App.Model
{
    /// <summary>
    /// Bière, qui hérite de la classe beverage.
    /// </summary>
    public class Beer : Beverage
    {
        #region Attributes

        /**
         * Nom
         * Degré
         * Brasseur
         * Type
         * Quantité
         */

        private float _Degree;
        private Brewer _Brewer;
        private BeerType _Type;


        #endregion

        #region Properties

        public float Degree { get => _Degree; set => _Degree = value; }
        public Brewer Brewer { get => _Brewer; set => _Brewer = value; }
        public BeerType Type { get => _Type; set => _Type = value; }
        #endregion

        #region Constructors

        /// <summary>
        /// Appelle le constructeur d'une bière. la base permet d'appeler le constructeur du parent.
        /// </summary>
        public Beer() : base(true)
        {

        }




        #endregion

        #region Methods

        #endregion
    }
}
