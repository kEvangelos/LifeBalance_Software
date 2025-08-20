using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeBalance
{
    /// <summary>
    /// Repräsentiert ein einzelnes Lebensmittel mit Nährwertangaben pro 100 g essbaren Anteil.
    /// </summary>
    public class Food
    {
        /// <summary>
        /// Primärschlüssel in der Datenbank (fortlaufende ID).
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Offizieller Name des Lebensmittels (z. B. "Banane, roh").
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Haupt- oder Unterkategorie, z. B. "Früchte frisch".
        /// </summary>
        public string? Kategorie { get; set; }

        /// <summary>
        /// Energiegehalt in Kilokalorien pro 100 g.
        /// </summary>
        public double EnergieKcal { get; set; }

        /// <summary>
        /// Proteingehalt in Gramm pro 100 g.
        /// </summary>
        public double Protein_g { get; set; }

        /// <summary>
        /// Gesamtfett in Gramm pro 100 g.
        /// </summary>
        public double Fett_g { get; set; }

        /// <summary>
        /// Gesättigte Fettsäuren in Gramm pro 100 g.
        /// </summary>
        public double FettGesättigt_g { get; set; }

        /// <summary>
        /// Gesamte Kohlenhydrate in Gramm pro 100 g.
        /// </summary>
        public double Kohlenhydrate_g { get; set; }

        /// <summary>
        /// Zuckeranteil in Gramm pro 100 g.
        /// </summary>
        public double Zucker_g { get; set; }

        /// <summary>
        /// Ballaststoffe in Gramm pro 100 g.
        /// </summary>
        public double Ballaststoffe_g { get; set; }

        /// <summary>
        /// Salzgehalt in Gramm pro 100 g (entspricht Natrium × 2,5).
        /// </summary>
        public double Salz_g { get; set; }

        /// <summary>
        /// Wasseranteil in Gramm pro 100 g.
        /// </summary>
        public double Wasser_g { get; set; }

        /// <summary>
        /// Cholesterin in Milligramm pro 100 g.
        /// </summary>
        public double Cholesterin_mg { get; set; }

        /// <summary>
        /// Dichte (g/ml), falls bekannt. Nützlich für die Umrechnung in Milliliter.
        /// </summary>
        public double? Dichte_g_ml { get; set; }
    } // class
} // namespace
