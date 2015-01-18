namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDownFont = new System.Windows.Forms.NumericUpDown();
            this.LblTailleFont = new System.Windows.Forms.Label();
            this.LbTailleCote = new System.Windows.Forms.Label();
            this.numericUpDownCote = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCote)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(170, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(851, 281);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // numericUpDownFont
            // 
            this.numericUpDownFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFont.Location = new System.Drawing.Point(15, 146);
            this.numericUpDownFont.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDownFont.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownFont.Name = "numericUpDownFont";
            this.numericUpDownFont.Size = new System.Drawing.Size(75, 26);
            this.numericUpDownFont.TabIndex = 2;
            this.numericUpDownFont.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownFont.ValueChanged += new System.EventHandler(this.numericUpDownFont_ValueChanged);
            // 
            // LblTailleFont
            // 
            this.LblTailleFont.AutoSize = true;
            this.LblTailleFont.Location = new System.Drawing.Point(12, 130);
            this.LblTailleFont.Name = "LblTailleFont";
            this.LblTailleFont.Size = new System.Drawing.Size(89, 13);
            this.LblTailleFont.TabIndex = 3;
            this.LblTailleFont.Text = "Taille de la police";
            // 
            // LbTailleCote
            // 
            this.LbTailleCote.AutoSize = true;
            this.LbTailleCote.Location = new System.Drawing.Point(12, 188);
            this.LbTailleCote.Name = "LbTailleCote";
            this.LbTailleCote.Size = new System.Drawing.Size(101, 13);
            this.LbTailleCote.TabIndex = 4;
            this.LbTailleCote.Text = "Longueur des cotes";
            // 
            // numericUpDownCote
            // 
            this.numericUpDownCote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCote.Location = new System.Drawing.Point(15, 204);
            this.numericUpDownCote.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDownCote.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCote.Name = "numericUpDownCote";
            this.numericUpDownCote.Size = new System.Drawing.Size(75, 26);
            this.numericUpDownCote.TabIndex = 5;
            this.numericUpDownCote.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownCote.ValueChanged += new System.EventHandler(this.numericUpDownCote_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 355);
            this.Controls.Add(this.numericUpDownCote);
            this.Controls.Add(this.LbTailleCote);
            this.Controls.Add(this.LblTailleFont);
            this.Controls.Add(this.numericUpDownFont);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownFont;
        private System.Windows.Forms.Label LblTailleFont;
        private System.Windows.Forms.Label LbTailleCote;
        private System.Windows.Forms.NumericUpDown numericUpDownCote;
    }
}

