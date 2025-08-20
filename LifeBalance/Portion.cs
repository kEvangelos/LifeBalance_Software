using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeBalance
{
    /// <summary>
    /// Repräsentiert eine typische Portion eines Lebensmittels.
    /// </summary>
    public class Portion
    {
        /// <summary>
        /// Primärschlüssel in der Datenbank.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Fremdschlüssel: verweist auf das zugehörige Lebensmittel (Food).
        /// </summary>
        public int FoodId { get; set; }

        /// <summary>
        /// Navigation Property zum zugehörigen Lebensmittel.
        /// </summary>
        public Food Food { get; set; } = null!;

        /// <summary>
        /// Beschreibung der Portion, z. B. "Banane mittel", "1 Stück", "1 EL".
        /// </summary>
        public string Bezeichnung { get; set; } = "";

        /// <summary>
        /// Durchschnittsgewicht der Portion in Gramm.
        /// </summary>
        public double Gramm { get; set; }
    } // class
} // namespace
