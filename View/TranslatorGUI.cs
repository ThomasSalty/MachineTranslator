using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; // Process
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MachineTranslator.Controller;
using MachineTranslator.View.Dialogs;
using MachineTranslator.Model;

namespace MachineTranslator.View
{
    /// A fõ ablak a menüsorral.
    /// 
    /// A "partial" kulcsó azt jelzi hogy más fájl(ok)ban is szerepelhet még ugyanennek az osztálynak
    /// kódja. A Visual Studio így választja ketté a generált kódtól a kézzel hozzáírtat.
    public partial class TranslatorGUI : Form
    {

        private bool isClickedForThe1stTime = true;
        private bool openFileDialogNotClicked = true;
        private TranslatorController control;
        private TMDialog tmDialog = new TMDialog();
        private Encoding encoding = System.Text.Encoding.Default;
        private int countTMunits = 0;

        /// <summary>
        /// Az "internal" kulcsszó hatására csak ez a program (assembly) látja
        /// ezt a property-t. Nincs definiálva setter, ezért csak olvasni lehet
        /// az értéket!
        /// </summary>
        internal TranslatorController Controller { get { return control; } }

        /*public TranslatorGUI()
        {
            InitializeComponent();
        }*/

        public TranslatorGUI(TranslatorController control)
        {
            this.control = control;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void translationMemoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmDialog.ShowDialog();
        }

        private void buttonTranslator_Click(object sender, EventArgs e)
        {
            string textHUN = textBoxEnglish.Text;
            string nl = Environment.NewLine;
            string parseTree;

            if (tmDialog.isUsingTMchecked())
            {
                textBoxHungarian.Text = translateStringUsingTM(textHUN);                
                parseTree = generateParsedTreeFrom(textHUN).Replace("\n", nl);
            }
            else
            {
                textBoxHungarian.Text = textHUN;
                parseTree = generateParsedTreeFrom(textHUN).Replace("\n", nl);
            }
            
            if (tmDialog.isDisplayingStatistics()) DisplayStatisticsTM();
        }

        private string generateParsedTreeFrom(string text)
        {
            /*File.WriteAllText(@"StanfordParser\input.txt", textHUN, encoding);
            string cmdText;
            cmdText = "/C cd StanfordParser && lexparser.bat input.txt > output.txt"; // A "/C" jelentése, hogy a parancs végrehajtása után nem vár user inputra, hanem terminál
            Process.Start("CMD.exe", cmdText);*/

            File.WriteAllText(@"StanfordParser\input.txt", text, encoding);
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C cd StanfordParser && lexparser.bat input.txt > output.txt"; // A "/C" jelentése, hogy a parancs végrehajtása után nem vár user inputra, hanem terminál
            process.StartInfo = startInfo;
            process.Start();

            return File.ReadAllText(@"StanfordParser\output.txt", encoding);
        }

        private void DisplayStatisticsTM()
        {
            string message = "A fordító memória által fordított kifejezések száma: "
                + countTMunits;
            string header = "Fordító memória"; 
            MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Information);
            countTMunits = 0;
        }

        private string translateStringUsingTM(string textHUN)
        {
            List<string> segments = getSegments();

            int numberOfSentences = textHUN.Split('.', '?', '!').Length - 1;
            string[] sentences = Regex.Split(textHUN, @"(?<=[\.!\?]+)\s+"); // \s+ white space 1x vagy többször
            
            bool segmentFound;
           // for (int j = 0; j < numberOfSentences; j++)
           // {
                for (int i = 0; i < segments.Count; i++)
                {
                    segmentFound = textHUN.IndexOf(segments[i], StringComparison.OrdinalIgnoreCase) >= 0;
                    if (segmentFound)
                    {
                        String sub = textHUN.Substring(textHUN.IndexOf(segments[i], StringComparison.OrdinalIgnoreCase), segments[i].Length);
                        if (sub.ToLower().Equals(segments[i]))
                        {
                            if (sub.Equals(capitalise(segments[i])) )
                                textHUN = textHUN.Replace(sub, capitalise(segments[i + 1]));
                            else
                                textHUN = textHUN.Replace(sub, segments[i + 1]);
                            countTMunits++;                            
                        }
                        i++;
                    }
                }
           // }

            return textHUN;
        }

        private List<string> getSegments()
        {
            IEnumerable<TranslationUnit> translationUnits = control.GetTranslationUnits();
            List<TranslationUnit> units = translationUnits.ToList();

            List<String> segments = new List<string>();
            for (int i = 0, j = 0; j < control.GetUnitsLength(units); i++, j++)
            {
                segments.Insert(i, units[j].Angol);
                segments.Insert(i + 1, units[j].Magyar);
                i++;
            }
            return segments;
        }

        /// <summary>
        /// Általános utility eszköz ami a megadott sztring első betűjét nagyra cseréli.
        /// </summary>
        /// <param name="s">Egy sztring aminek az első betűjét nagyra cseréljük.</param>
        /// <returns>A nagybetűvel kezdődő sztring.</returns>
        private string capitalise(string s)
        {
            if (s == null || s.Length == 0) return s;

            string s1 = s.Substring(0, 1).ToUpper() + s.Substring(1);
            return s1;
        }

        private void textBoxEnglish_MouseClick(object sender, MouseEventArgs e)
        {
            if (isClickedForThe1stTime && openFileDialogNotClicked)
            {
                textBoxEnglish.Clear();
                isClickedForThe1stTime = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogNotClicked = false;
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            string MyComputerGUID = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}"; //Globally Unique Identifier
            openFileDialog.InitialDirectory = MyComputerGUID;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                int size = 0;
                string text;
                string filename = openFileDialog.SafeFileName; // fájlnév + kiterjesztés
                string path = openFileDialog.FileName; // fájl elérési útvonala                
                try
                {
                    text = File.ReadAllText(path, encoding);
                    textBoxEnglish.Text = text;
                    size = text.Length;
                    if (size != 0) this.Text = "Angol-Magyar Fordítás | " + filename + ": "
                        + (size > 1024 ? size / 1024 + "," + size % 1024 + " kB" : size + " bytes");
                }
                catch (IOException ioe)
                {
                    MessageBox.Show("Hiba: A fájl nem nyitható meg!", ioe.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.ShowDialog();
            string path = "";
            path = saveFileDialog.FileName;
            if (path != "" && textBoxHungarian.Text != "")
            {
                File.WriteAllText(path, textBoxHungarian.Text, encoding);
            }
            else if (textBoxHungarian.Text == "")
            {
                MessageBox.Show("Csak a lefordított szöveget lehet menteni!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (path == "")
            {
                MessageBox.Show("Nincs megadva útvonal!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
