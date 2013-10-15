namespace MachineTranslator.View.Dialogs
{
    partial class TMDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewUNITS = new System.Windows.Forms.DataGridView();
            this.addSegmentsGroupBox = new System.Windows.Forms.GroupBox();
            this.buttonUndoAddSegments = new System.Windows.Forms.Button();
            this.buttonAddSegments = new System.Windows.Forms.Button();
            this.textBoxHungarianSegment = new System.Windows.Forms.TextBox();
            this.textBoxEnglishSegment = new System.Windows.Forms.TextBox();
            this.labelHungarian = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.groupBoxDeleteSegment = new System.Windows.Forms.GroupBox();
            this.comboBoxDeleteSegment = new System.Windows.Forms.ComboBox();
            this.buttonDeleteSegments = new System.Windows.Forms.Button();
            this.labelDeleteSegment = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxTM = new System.Windows.Forms.CheckBox();
            this.checkBoxSTAT = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUNITS)).BeginInit();
            this.addSegmentsGroupBox.SuspendLayout();
            this.groupBoxDeleteSegment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUNITS
            // 
            this.dataGridViewUNITS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUNITS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUNITS.Location = new System.Drawing.Point(0, -1);
            this.dataGridViewUNITS.Name = "dataGridViewUNITS";
            this.dataGridViewUNITS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewUNITS.Size = new System.Drawing.Size(319, 350);
            this.dataGridViewUNITS.TabIndex = 0;
            // 
            // addSegmentsGroupBox
            // 
            this.addSegmentsGroupBox.Controls.Add(this.buttonUndoAddSegments);
            this.addSegmentsGroupBox.Controls.Add(this.buttonAddSegments);
            this.addSegmentsGroupBox.Controls.Add(this.textBoxHungarianSegment);
            this.addSegmentsGroupBox.Controls.Add(this.textBoxEnglishSegment);
            this.addSegmentsGroupBox.Controls.Add(this.labelHungarian);
            this.addSegmentsGroupBox.Controls.Add(this.labelEnglish);
            this.addSegmentsGroupBox.Location = new System.Drawing.Point(325, 12);
            this.addSegmentsGroupBox.Name = "addSegmentsGroupBox";
            this.addSegmentsGroupBox.Size = new System.Drawing.Size(338, 150);
            this.addSegmentsGroupBox.TabIndex = 1;
            this.addSegmentsGroupBox.TabStop = false;
            this.addSegmentsGroupBox.Text = "Szegmensek hozzáadása vagy módosítása";
            // 
            // buttonUndoAddSegments
            // 
            this.buttonUndoAddSegments.Enabled = false;
            this.buttonUndoAddSegments.Location = new System.Drawing.Point(180, 109);
            this.buttonUndoAddSegments.Name = "buttonUndoAddSegments";
            this.buttonUndoAddSegments.Size = new System.Drawing.Size(134, 23);
            this.buttonUndoAddSegments.TabIndex = 5;
            this.buttonUndoAddSegments.Text = "Visszavonás";
            this.buttonUndoAddSegments.UseVisualStyleBackColor = true;
            this.buttonUndoAddSegments.Click += new System.EventHandler(this.buttonUndoAddSegments_Click);
            // 
            // buttonAddSegments
            // 
            this.buttonAddSegments.Location = new System.Drawing.Point(25, 109);
            this.buttonAddSegments.Name = "buttonAddSegments";
            this.buttonAddSegments.Size = new System.Drawing.Size(130, 23);
            this.buttonAddSegments.TabIndex = 4;
            this.buttonAddSegments.Text = "Hozzáadás/Módosítás";
            this.buttonAddSegments.UseVisualStyleBackColor = true;
            this.buttonAddSegments.Click += new System.EventHandler(this.buttonAddSegments_Click);
            // 
            // textBoxHungarianSegment
            // 
            this.textBoxHungarianSegment.Location = new System.Drawing.Point(96, 69);
            this.textBoxHungarianSegment.Name = "textBoxHungarianSegment";
            this.textBoxHungarianSegment.Size = new System.Drawing.Size(228, 20);
            this.textBoxHungarianSegment.TabIndex = 3;
            // 
            // textBoxEnglishSegment
            // 
            this.textBoxEnglishSegment.Location = new System.Drawing.Point(96, 32);
            this.textBoxEnglishSegment.Name = "textBoxEnglishSegment";
            this.textBoxEnglishSegment.Size = new System.Drawing.Size(228, 20);
            this.textBoxEnglishSegment.TabIndex = 2;
            // 
            // labelHungarian
            // 
            this.labelHungarian.AutoSize = true;
            this.labelHungarian.Location = new System.Drawing.Point(6, 72);
            this.labelHungarian.Name = "labelHungarian";
            this.labelHungarian.Size = new System.Drawing.Size(92, 13);
            this.labelHungarian.TabIndex = 1;
            this.labelHungarian.Text = "Magyar szegmens";
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Location = new System.Drawing.Point(6, 32);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(87, 13);
            this.labelEnglish.TabIndex = 0;
            this.labelEnglish.Text = "Angol szegmens:";
            // 
            // groupBoxDeleteSegment
            // 
            this.groupBoxDeleteSegment.Controls.Add(this.comboBoxDeleteSegment);
            this.groupBoxDeleteSegment.Controls.Add(this.buttonDeleteSegments);
            this.groupBoxDeleteSegment.Controls.Add(this.labelDeleteSegment);
            this.groupBoxDeleteSegment.Location = new System.Drawing.Point(325, 168);
            this.groupBoxDeleteSegment.Name = "groupBoxDeleteSegment";
            this.groupBoxDeleteSegment.Size = new System.Drawing.Size(338, 90);
            this.groupBoxDeleteSegment.TabIndex = 2;
            this.groupBoxDeleteSegment.TabStop = false;
            this.groupBoxDeleteSegment.Text = "Szegmensek törlése";
            // 
            // comboBoxDeleteSegment
            // 
            this.comboBoxDeleteSegment.FormattingEnabled = true;
            this.comboBoxDeleteSegment.Location = new System.Drawing.Point(12, 49);
            this.comboBoxDeleteSegment.Name = "comboBoxDeleteSegment";
            this.comboBoxDeleteSegment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteSegment.TabIndex = 6;
            // 
            // buttonDeleteSegments
            // 
            this.buttonDeleteSegments.Location = new System.Drawing.Point(190, 49);
            this.buttonDeleteSegments.Name = "buttonDeleteSegments";
            this.buttonDeleteSegments.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteSegments.TabIndex = 5;
            this.buttonDeleteSegments.Text = "Törlés";
            this.buttonDeleteSegments.UseVisualStyleBackColor = true;
            this.buttonDeleteSegments.Click += new System.EventHandler(this.buttonDeleteSegments_Click);
            // 
            // labelDeleteSegment
            // 
            this.labelDeleteSegment.AutoSize = true;
            this.labelDeleteSegment.Location = new System.Drawing.Point(6, 33);
            this.labelDeleteSegment.Name = "labelDeleteSegment";
            this.labelDeleteSegment.Size = new System.Drawing.Size(139, 13);
            this.labelDeleteSegment.TabIndex = 0;
            this.labelDeleteSegment.Text = "Törlendő szegmensek ID-je:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(588, 312);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Bezárás";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxTM
            // 
            this.checkBoxTM.AutoSize = true;
            this.checkBoxTM.Checked = true;
            this.checkBoxTM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTM.Location = new System.Drawing.Point(334, 274);
            this.checkBoxTM.Name = "checkBoxTM";
            this.checkBoxTM.Size = new System.Drawing.Size(156, 17);
            this.checkBoxTM.TabIndex = 8;
            this.checkBoxTM.Text = "Fordító memória használata";
            this.checkBoxTM.UseVisualStyleBackColor = true;
            this.checkBoxTM.CheckedChanged += new System.EventHandler(this.checkBoxTM_CheckedChanged);
            // 
            // checkBoxSTAT
            // 
            this.checkBoxSTAT.AutoSize = true;
            this.checkBoxSTAT.Checked = true;
            this.checkBoxSTAT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSTAT.Location = new System.Drawing.Point(333, 296);
            this.checkBoxSTAT.Name = "checkBoxSTAT";
            this.checkBoxSTAT.Size = new System.Drawing.Size(74, 17);
            this.checkBoxSTAT.TabIndex = 9;
            this.checkBoxSTAT.Text = "Statisztika";
            this.checkBoxSTAT.UseVisualStyleBackColor = true;
            this.checkBoxSTAT.CheckedChanged += new System.EventHandler(this.checkBoxSTAT_CheckedChanged);
            // 
            // TMDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 342);
            this.Controls.Add(this.checkBoxSTAT);
            this.Controls.Add(this.checkBoxTM);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.groupBoxDeleteSegment);
            this.Controls.Add(this.addSegmentsGroupBox);
            this.Controls.Add(this.dataGridViewUNITS);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TMDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fordító memória";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUNITS)).EndInit();
            this.addSegmentsGroupBox.ResumeLayout(false);
            this.addSegmentsGroupBox.PerformLayout();
            this.groupBoxDeleteSegment.ResumeLayout(false);
            this.groupBoxDeleteSegment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUNITS;
        private System.Windows.Forms.GroupBox addSegmentsGroupBox;
        private System.Windows.Forms.Label labelHungarian;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.TextBox textBoxHungarianSegment;
        private System.Windows.Forms.TextBox textBoxEnglishSegment;
        private System.Windows.Forms.Button buttonAddSegments;
        private System.Windows.Forms.Button buttonUndoAddSegments;
        private System.Windows.Forms.GroupBox groupBoxDeleteSegment;
        private System.Windows.Forms.Label labelDeleteSegment;
        private System.Windows.Forms.Button buttonDeleteSegments;
        private System.Windows.Forms.ComboBox comboBoxDeleteSegment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxTM;
        private System.Windows.Forms.CheckBox checkBoxSTAT;
    }
}