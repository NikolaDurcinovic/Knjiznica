
namespace Knjiznica
{
    partial class Glavna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Knjige = new System.Windows.Forms.ListBox();
            this.buttonPosudi = new System.Windows.Forms.Button();
            this.buttonIzmjeni = new System.Windows.Forms.Button();
            this.buttonVrati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posudjene knjige:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Knjige
            // 
            this.Knjige.FormattingEnabled = true;
            this.Knjige.ItemHeight = 15;
            this.Knjige.Location = new System.Drawing.Point(64, 125);
            this.Knjige.Name = "Knjige";
            this.Knjige.Size = new System.Drawing.Size(326, 154);
            this.Knjige.TabIndex = 1;
            // 
            // buttonPosudi
            // 
            this.buttonPosudi.Location = new System.Drawing.Point(438, 125);
            this.buttonPosudi.Name = "buttonPosudi";
            this.buttonPosudi.Size = new System.Drawing.Size(75, 23);
            this.buttonPosudi.TabIndex = 2;
            this.buttonPosudi.Text = "Posudi";
            this.buttonPosudi.UseVisualStyleBackColor = true;
            this.buttonPosudi.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonIzmjeni
            // 
            this.buttonIzmjeni.Location = new System.Drawing.Point(438, 191);
            this.buttonIzmjeni.Name = "buttonIzmjeni";
            this.buttonIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmjeni.TabIndex = 3;
            this.buttonIzmjeni.Text = "Izmjeni";
            this.buttonIzmjeni.UseVisualStyleBackColor = true;
            this.buttonIzmjeni.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonVrati
            // 
            this.buttonVrati.Location = new System.Drawing.Point(438, 256);
            this.buttonVrati.Name = "buttonVrati";
            this.buttonVrati.Size = new System.Drawing.Size(75, 23);
            this.buttonVrati.TabIndex = 4;
            this.buttonVrati.Text = "Vrati";
            this.buttonVrati.UseVisualStyleBackColor = true;
            this.buttonVrati.Click += new System.EventHandler(this.button3_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVrati);
            this.Controls.Add(this.buttonIzmjeni);
            this.Controls.Add(this.buttonPosudi);
            this.Controls.Add(this.Knjige);
            this.Controls.Add(this.label1);
            this.Name = "Glavna";
            this.Text = "Knjiznica";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Knjige;
        private System.Windows.Forms.Button buttonPosudi;
        private System.Windows.Forms.Button buttonIzmjeni;
        private System.Windows.Forms.Button buttonVrati;
    }
}

