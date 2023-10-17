using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerManager.App.Model
{
    /// <summary>
    /// Type de bière
    /// </summary>
    public class BeerType
    {
        #region Attributes

        /// <summary>
        /// Nom du type
        /// </summary>
        private string _Name;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou définir le nom du type
        /// </summary>
        public string Name { get => _Name; set => _Name = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public BeerType()
        {
               
        }

        /// <summary>
        /// Constructeur de la classe du type de bière
        /// Permet l'instanciation de la classe
        /// </summary>
        public BeerType(string? name)
        {
            if (name == null)
            {
                this.Name = "Non défini";
            }
            else
            {
                this.Name = name;
            }
        }




        #endregion

        #region Methods

        #endregion
    }
}
