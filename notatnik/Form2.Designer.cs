
namespace notatnik
{
    partial class Opinia
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
            this.okno_opinia = new System.Windows.Forms.RichTextBox();
            this.Dodaj_opinie = new System.Windows.Forms.Button();
            this.Zamknij = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // okno_opinia
            // 
            this.okno_opinia.Location = new System.Drawing.Point(22, 12);
            this.okno_opinia.Name = "okno_opinia";
            this.okno_opinia.Size = new System.Drawing.Size(269, 65);
            this.okno_opinia.TabIndex = 0;
            this.okno_opinia.Text = "";
            // 
            // Dodaj_opinie
            // 
            this.Dodaj_opinie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj_opinie.Location = new System.Drawing.Point(312, 4);
            this.Dodaj_opinie.Name = "Dodaj_opinie";
            this.Dodaj_opinie.Size = new System.Drawing.Size(93, 34);
            this.Dodaj_opinie.TabIndex = 1;
            this.Dodaj_opinie.Text = "Dodaj opinię";
            this.Dodaj_opinie.UseVisualStyleBackColor = true;
            this.Dodaj_opinie.Click += new System.EventHandler(this.Dodaj_opinie_Click);
            // 
            // Zamknij
            // 
            this.Zamknij.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zamknij.Location = new System.Drawing.Point(312, 44);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(93, 34);
            this.Zamknij.TabIndex = 2;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // Opinia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 110);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.Dodaj_opinie);
            this.Controls.Add(this.okno_opinia);
            this.Name = "Opinia";
            this.Text = "Opinia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox okno_opinia;
        private System.Windows.Forms.Button Dodaj_opinie;
        private System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}