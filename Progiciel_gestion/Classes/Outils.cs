using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Documents;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace Progiciel_gestion.Classes
{
    class Outils
    {

        public static DateTime convertirDate(string maDate)
        {
            DateTime myDate = DateTime.ParseExact(maDate, "dd-MMM-yyyy", CultureInfo.InvariantCulture);
            return myDate;

        }

        public static string lireRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                // TextPointer qui pointe vers le début du champ texte du RichTextBox.
                rtb.Document.ContentStart,
                // TextPointer qui pointe vers la fin du champ texte du RichTextBox.
                rtb.Document.ContentEnd
            );

            // La propriété Text d'un TextRange retourne une chaîne de caratctères
            // représentant le texte complet du TexRange.
            return textRange.Text;
        }

    }
}
