namespace MachineTranslator.View
{
    partial class TranslatorGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorGUI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközökToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translationMemoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonTranslator = new System.Windows.Forms.Button();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxHungarian = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eszközökToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(792, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "&Fájl";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openToolStripMenuItem.Text = "Megnyitás";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveToolStripMenuItem.Text = "Mentés";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(131, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Kilépés";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // eszközökToolStripMenuItem
            // 
            this.eszközökToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translationMemoryToolStripMenuItem});
            this.eszközökToolStripMenuItem.Name = "eszközökToolStripMenuItem";
            this.eszközökToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eszközökToolStripMenuItem.Text = "&Eszközök";
            // 
            // translationMemoryToolStripMenuItem
            // 
            this.translationMemoryToolStripMenuItem.Name = "translationMemoryToolStripMenuItem";
            this.translationMemoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.translationMemoryToolStripMenuItem.Text = "Fordítómemória";
            this.translationMemoryToolStripMenuItem.Click += new System.EventHandler(this.translationMemoryToolStripMenuItem_Click);
            // 
            // buttonTranslator
            // 
            this.buttonTranslator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTranslator.Location = new System.Drawing.Point(64, 278);
            this.buttonTranslator.Name = "buttonTranslator";
            this.buttonTranslator.Size = new System.Drawing.Size(665, 41);
            this.buttonTranslator.TabIndex = 1;
            this.buttonTranslator.Text = "Fordítás";
            this.buttonTranslator.UseVisualStyleBackColor = true;
            this.buttonTranslator.Click += new System.EventHandler(this.buttonTranslator_Click);
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Location = new System.Drawing.Point(64, 55);
            this.textBoxEnglish.Multiline = true;
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEnglish.Size = new System.Drawing.Size(665, 217);
            this.textBoxEnglish.TabIndex = 2;
            this.textBoxEnglish.Text = "Ide írja az angol nyelvű szöveget...";
            this.textBoxEnglish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEnglish_MouseClick);
            // 
            // textBoxHungarian
            // 
            this.textBoxHungarian.Location = new System.Drawing.Point(64, 325);
            this.textBoxHungarian.Multiline = true;
            this.textBoxHungarian.Name = "textBoxHungarian";
            this.textBoxHungarian.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHungarian.Size = new System.Drawing.Size(665, 217);
            this.textBoxHungarian.TabIndex = 3;
            // 
            // TranslatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.textBoxHungarian);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.buttonTranslator);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TranslatorGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angol-Magyar Fordítás";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eszközökToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translationMemoryToolStripMenuItem;
        private System.Windows.Forms.Button buttonTranslator;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxHungarian;
    }
}