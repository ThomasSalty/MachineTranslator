using System;
using System.Collections.Generic;
using System.ComponentModel;//
using System.Data;//
using System.Drawing;//
using System.Linq;//
using System.Text;
using System.IO;//
using System.Windows.Forms;
using MachineTranslator.Model;
using MachineTranslator.View;

namespace MachineTranslator.Controller
{
    public class TranslatorController
    {
        private TranslatorDAO dao = new TranslatorDAO();
        private bool isSegmentUpdated;
        private bool isSegmentInserted;

        public bool getIsSegmentUpdated()
        {
            return isSegmentUpdated = dao.isSegmentUpdated;
        }

        public bool getIsSegmentInserted()
        {
            return isSegmentInserted = dao.isSegmentInserted;
        }

        /// <summary>
        /// A fordítási egységek listájának lekérése 
        /// </summary>
        /// <returns>fordítási egységek listája</returns>
        public IEnumerable<TranslationUnit> GetTranslationUnits()
        {
            List<TranslationUnit> translationUnits = new List<TranslationUnit>();

            foreach (TranslationUnit unit in dao.GetTranslationUnits())
            {
                translationUnits.Add(unit);                
            }
            return translationUnits;
        } // GetTranslationUnits

        internal int GetUnitsLength(IEnumerable<TranslationUnit> units)
        {
            return dao.GetUnitsNumber(units);
        }

        internal bool DeleteTranslationUnit(string english)
        {
            return dao.DeleteTranslationUnit(english);
        }

        internal bool AddOrUpdateTranslationUnit(TranslationUnit unit)
        {
            return dao.AddOrUpdateTranslationUnit(unit);
        }

        internal string GetUnitEnglish(TranslationUnit unit)
        {
            return dao.GetEnglishUnit(unit);
        }

        internal List<string> GetEnglishUnits(IEnumerable<TranslationUnit> units)
        {
            return dao.GetEnglishUnits(units);
        }
    }
}