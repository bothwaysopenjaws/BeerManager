using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BeerManager.App.Model
{
    /// <summary>
    /// brevage, classe abstraite qui doit donc être instanciée par le biais de ses enfants.
    /// </summary>
    public abstract class Beverage
    {
        #region Attributes
        /// <summary>
        /// A des bulles
        /// </summary>
        private bool _HasBubbles;

        /// <summary>
        /// Nom
        /// </summary>
        private string _Name;

        /// <summary>
        /// Quantité
        /// </summary>
        private int _Quantity;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini les bulles
        /// </summary>
        public bool HasBubbles { get => _HasBubbles; set => _HasBubbles = value; }

        /// <summary>
        /// Obtient ou défini le nom
        /// </summary>
        public string Name { get => _Name; set => _Name = value; }

        /// <summary>
        /// Obtient ou défini la quantité
        /// </summary>
        public int Quantity { get => _Quantity; private set => _Quantity = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur pour un breuvage
        /// </summary>
        /// <param name="hasBubbles">Indique si on a des bulles ou non.</param>
        public Beverage(bool hasBubbles)
        {
            this.HasBubbles = hasBubbles;
            this.Quantity = 0;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Inverse si on a des bulles ou non.
        /// </summary>
        public void InverseBubbles() => this.HasBubbles = !this.HasBubbles;

        /// <summary>
        /// Ajout d'une quantité positive ou négative. Indique si l'opération a bien été effectuée.
        /// </summary>
        /// <param name="quantity">quantité à ajouter ou retirer</param>
        public virtual bool ModifyQuantity(int quantity)
        {
            bool result = false;
            if (this.Quantity + quantity >= 0)
            {
                this.Quantity += quantity;
                result = true;
            }

            return result;
        }

        #endregion
    }
}
