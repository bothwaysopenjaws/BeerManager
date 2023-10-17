using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerManager.App.Model
{
    /// <summary>
    /// Brasseur
    /// </summary>
    public class Brewer
    {
        #region Attributes

        /// <summary>
        /// Nom
        /// </summary>
        public string _Name;

        /// <summary>
        /// Pays
        /// </summary>
        private string _Country;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient le nom
        /// </summary>
        public string Name { get => _Name; set => _Name = value; }

        /// <summary>
        /// Obtient le pays
        /// </summary>
        public string Country { get => _Country; set => _Country = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Instancie un brasseur
        /// </summary>
        /// <param name="name">Nom du brasseur</param>
        /// <param name="country">Pays du brasseur</param>
        public Brewer(string name, string country)
        {
            this.Name = name;
            this._Country = country;
        }

        #endregion

        #region Methods

        #endregion
    }
}
