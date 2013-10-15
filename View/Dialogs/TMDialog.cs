using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MachineTranslator.Model;
using MachineTranslator.Controller;

namespace MachineTranslator.View.Dialogs
{
    public partial class TMDialog : Form
    {
        private TranslatorController control = new TranslatorController();
        private TranslationUnit unit = new TranslationUnit();
        private List<string> EnglishUnitsFromDatabase;
        private string english;
        private bool isSegmentAdded = false;
        private bool usingTranslationMemory = true;
        private bool displayingStatistics = true;

        public TMDialog()
        {
            InitializeComponent();
            UpdateDataGridView();
            UpdateComboBox();
            this.CancelButton = buttonCancel;
        }

        private void UpdateDataGridView()
        {
            dataGridViewUNITS.DataSource = control.GetTranslationUnits();
        }

        private void UpdateComboBox()
        {
            EnglishUnitsFromDatabase = 
                control.GetEnglishUnits(control.GetTranslationUnits());
            EnglishUnitsFromDatabase.Sort();

            comboBoxDeleteSegment.Items.Clear();
            comboBoxDeleteSegment.Items.AddRange(EnglishUnitsFromDatabase.ToArray<string>());
            //comboBoxDeleteSegment.Items.AddRange(EnglishUnitsFromDatabase.Cast<object>().ToArray());            
            comboBoxDeleteSegment.SelectedItem = EnglishUnitsFromDatabase.Min();
        }

        private void DeleteSegments()
        {
            if (control.DeleteTranslationUnit(english)) UpdateDataGridView();
            else
            {
                MessageBox.Show("Hiba történt a rekord törlésekor!", "Hiba!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddSegments_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxEnglishSegment.Text) || String.IsNullOrEmpty(textBoxHungarianSegment.Text))
            {
                MessageBox.Show("Mindkét szegmenst meg kell adni!", "Hiba!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {                
                unit.Angol = textBoxEnglishSegment.Text;
                unit.Magyar = textBoxHungarianSegment.Text;
                if (control.AddOrUpdateTranslationUnit(unit))
                {
                    if (control.getIsSegmentUpdated())
                    {
                        buttonUndoAddSegments.Enabled = false;
                        UpdateDataGridView();
                    }
                    else
                    {
                        isSegmentAdded = true;
                        english = control.GetUnitEnglish(unit);
                        buttonUndoAddSegments.Enabled = true;
                        UpdateDataGridView();
                        UpdateComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("Hiba történt az adatbázis írásakor!", "Hiba!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUndoAddSegments_Click(object sender, EventArgs e)
        {
            if (isSegmentAdded && control.getIsSegmentInserted())
                DeleteSegments();
            buttonUndoAddSegments.Enabled = false;
            UpdateComboBox();
        }

        private void buttonDeleteSegments_Click(object sender, EventArgs e)
        {
            english = comboBoxDeleteSegment.SelectedItem.ToString();
            DeleteSegments();
        }

        private void checkBoxTM_CheckedChanged(object sender, EventArgs e)
        {
            usingTranslationMemory = !usingTranslationMemory;
            if (!checkBoxTM.Checked) checkBoxSTAT.CheckState = CheckState.Unchecked;
        }

        public bool isUsingTMchecked()
        {
            return usingTranslationMemory;
        }


        private void checkBoxSTAT_CheckedChanged(object sender, EventArgs e)
        {
            displayingStatistics = !displayingStatistics;
            if (checkBoxSTAT.Checked) checkBoxTM.CheckState = CheckState.Checked;

        }

        public bool isDisplayingStatistics()
        {
            return displayingStatistics;
        }
    }
}
