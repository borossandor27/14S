namespace WindowsFormsTagdij
{
    partial class Form_ClubTags
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
            this.listBox_KlubTagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Azonosito = new System.Windows.Forms.TextBox();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.numericUpDown_SzuletesiEv = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_IranyitoSzam = new System.Windows.Forms.NumericUpDown();
            this.textBox_Orszag = new System.Windows.Forms.TextBox();
            this.button_Insert = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IranyitoSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_KlubTagok
            // 
            this.listBox_KlubTagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_KlubTagok.FormattingEnabled = true;
            this.listBox_KlubTagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_KlubTagok.Name = "listBox_KlubTagok";
            this.listBox_KlubTagok.Size = new System.Drawing.Size(207, 426);
            this.listBox_KlubTagok.TabIndex = 0;
            this.listBox_KlubTagok.SelectedIndexChanged += new System.EventHandler(this.listBox_KlubTagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Delete);
            this.groupBox1.Controls.Add(this.button_Update);
            this.groupBox1.Controls.Add(this.button_Insert);
            this.groupBox1.Controls.Add(this.textBox_Orszag);
            this.groupBox1.Controls.Add(this.numericUpDown_IranyitoSzam);
            this.groupBox1.Controls.Add(this.numericUpDown_SzuletesiEv);
            this.groupBox1.Controls.Add(this.textBox_Nev);
            this.groupBox1.Controls.Add(this.textBox_Azonosito);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(207, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott tag adatai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Születési év";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Irányítószám";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ország";
            // 
            // textBox_Azonosito
            // 
            this.textBox_Azonosito.Location = new System.Drawing.Point(137, 26);
            this.textBox_Azonosito.Name = "textBox_Azonosito";
            this.textBox_Azonosito.Size = new System.Drawing.Size(120, 20);
            this.textBox_Azonosito.TabIndex = 5;
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(137, 63);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(120, 20);
            this.textBox_Nev.TabIndex = 6;
            // 
            // numericUpDown_SzuletesiEv
            // 
            this.numericUpDown_SzuletesiEv.Location = new System.Drawing.Point(137, 100);
            this.numericUpDown_SzuletesiEv.Maximum = new decimal(new int[] {
            2090,
            0,
            0,
            0});
            this.numericUpDown_SzuletesiEv.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown_SzuletesiEv.Name = "numericUpDown_SzuletesiEv";
            this.numericUpDown_SzuletesiEv.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_SzuletesiEv.TabIndex = 7;
            this.numericUpDown_SzuletesiEv.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericUpDown_IranyitoSzam
            // 
            this.numericUpDown_IranyitoSzam.Location = new System.Drawing.Point(137, 137);
            this.numericUpDown_IranyitoSzam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_IranyitoSzam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_IranyitoSzam.Name = "numericUpDown_IranyitoSzam";
            this.numericUpDown_IranyitoSzam.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_IranyitoSzam.TabIndex = 8;
            this.numericUpDown_IranyitoSzam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBox_Orszag
            // 
            this.textBox_Orszag.Location = new System.Drawing.Point(137, 174);
            this.textBox_Orszag.Name = "textBox_Orszag";
            this.textBox_Orszag.Size = new System.Drawing.Size(120, 20);
            this.textBox_Orszag.TabIndex = 9;
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(48, 234);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(209, 30);
            this.button_Insert.TabIndex = 10;
            this.button_Insert.Text = "Új tag";
            this.button_Insert.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(48, 289);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(209, 28);
            this.button_Update.TabIndex = 11;
            this.button_Update.Text = "Módosít";
            this.button_Update.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(48, 342);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(209, 30);
            this.button_Delete.TabIndex = 12;
            this.button_Delete.Text = "Törlés";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // Form_ClubTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_KlubTagok);
            this.Name = "Form_ClubTags";
            this.Text = "Beregszaszi Club";
            this.Load += new System.EventHandler(this.Form_ClubTags_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SzuletesiEv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IranyitoSzam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_KlubTagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Orszag;
        private System.Windows.Forms.NumericUpDown numericUpDown_IranyitoSzam;
        private System.Windows.Forms.NumericUpDown numericUpDown_SzuletesiEv;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.TextBox textBox_Azonosito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Insert;
    }
}

