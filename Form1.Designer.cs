namespace Rekenmachine
{
    partial class FormRekenmachine
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
            this.tbX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btOptellen = new System.Windows.Forms.Button();
            this.btRoot = new System.Windows.Forms.Button();
            this.btVierkantswortel = new System.Windows.Forms.Button();
            this.btMachtsverheffing = new System.Windows.Forms.Button();
            this.btKwadraat = new System.Windows.Forms.Button();
            this.btDelen = new System.Windows.Forms.Button();
            this.btVermenigvuldigen = new System.Windows.Forms.Button();
            this.btAftrekken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(74, 45);
            this.tbX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(158, 31);
            this.tbX.TabIndex = 0;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(74, 93);
            this.tbY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(158, 31);
            this.tbY.TabIndex = 2;
            this.tbY.TextChanged += new System.EventHandler(this.tbY_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Info;
            this.tbResult.Location = new System.Drawing.Point(74, 142);
            this.tbResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(158, 31);
            this.tbResult.TabIndex = 5;
            // 
            // btOptellen
            // 
            this.btOptellen.Location = new System.Drawing.Point(74, 227);
            this.btOptellen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOptellen.Name = "btOptellen";
            this.btOptellen.Size = new System.Drawing.Size(107, 38);
            this.btOptellen.TabIndex = 6;
            this.btOptellen.Text = "+";
            this.btOptellen.UseVisualStyleBackColor = true;
            this.btOptellen.Click += new System.EventHandler(this.btOptellen_Click);
            // 
            // btRoot
            // 
            this.btRoot.Location = new System.Drawing.Point(246, 372);
            this.btRoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoot.Name = "btRoot";
            this.btRoot.Size = new System.Drawing.Size(107, 38);
            this.btRoot.TabIndex = 7;
            this.btRoot.Text = "root";
            this.btRoot.UseVisualStyleBackColor = true;
            this.btRoot.Click += new System.EventHandler(this.btWorteltrekking_Click);
            // 
            // btVierkantswortel
            // 
            this.btVierkantswortel.Location = new System.Drawing.Point(246, 323);
            this.btVierkantswortel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btVierkantswortel.Name = "btVierkantswortel";
            this.btVierkantswortel.Size = new System.Drawing.Size(107, 38);
            this.btVierkantswortel.TabIndex = 8;
            this.btVierkantswortel.Text = "sqrt";
            this.btVierkantswortel.UseVisualStyleBackColor = true;
            this.btVierkantswortel.Click += new System.EventHandler(this.btVierkantswortel_Click);
            // 
            // btMachtsverheffing
            // 
            this.btMachtsverheffing.Location = new System.Drawing.Point(246, 275);
            this.btMachtsverheffing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMachtsverheffing.Name = "btMachtsverheffing";
            this.btMachtsverheffing.Size = new System.Drawing.Size(107, 38);
            this.btMachtsverheffing.TabIndex = 9;
            this.btMachtsverheffing.Text = "X^Y";
            this.btMachtsverheffing.UseVisualStyleBackColor = true;
            this.btMachtsverheffing.Click += new System.EventHandler(this.btMachtsverheffing_Click);
            // 
            // btKwadraat
            // 
            this.btKwadraat.Location = new System.Drawing.Point(246, 227);
            this.btKwadraat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btKwadraat.Name = "btKwadraat";
            this.btKwadraat.Size = new System.Drawing.Size(107, 38);
            this.btKwadraat.TabIndex = 10;
            this.btKwadraat.Text = "X²";
            this.btKwadraat.UseVisualStyleBackColor = true;
            this.btKwadraat.Click += new System.EventHandler(this.btKwadraat_Click);
            // 
            // btDelen
            // 
            this.btDelen.Location = new System.Drawing.Point(74, 372);
            this.btDelen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDelen.Name = "btDelen";
            this.btDelen.Size = new System.Drawing.Size(107, 38);
            this.btDelen.TabIndex = 11;
            this.btDelen.Text = "/";
            this.btDelen.UseVisualStyleBackColor = true;
            this.btDelen.Click += new System.EventHandler(this.btDelen_Click);
            // 
            // btVermenigvuldigen
            // 
            this.btVermenigvuldigen.Location = new System.Drawing.Point(74, 323);
            this.btVermenigvuldigen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btVermenigvuldigen.Name = "btVermenigvuldigen";
            this.btVermenigvuldigen.Size = new System.Drawing.Size(107, 38);
            this.btVermenigvuldigen.TabIndex = 12;
            this.btVermenigvuldigen.Text = "x";
            this.btVermenigvuldigen.UseVisualStyleBackColor = true;
            this.btVermenigvuldigen.Click += new System.EventHandler(this.btVermenigvuldiging_Click);
            // 
            // btAftrekken
            // 
            this.btAftrekken.Location = new System.Drawing.Point(74, 275);
            this.btAftrekken.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAftrekken.Name = "btAftrekken";
            this.btAftrekken.Size = new System.Drawing.Size(107, 38);
            this.btAftrekken.TabIndex = 13;
            this.btAftrekken.Text = "-";
            this.btAftrekken.UseVisualStyleBackColor = true;
            this.btAftrekken.Click += new System.EventHandler(this.btAftrekken_Click);
            // 
            // FormRekenmachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 448);
            this.Controls.Add(this.btAftrekken);
            this.Controls.Add(this.btVermenigvuldigen);
            this.Controls.Add(this.btDelen);
            this.Controls.Add(this.btKwadraat);
            this.Controls.Add(this.btMachtsverheffing);
            this.Controls.Add(this.btVierkantswortel);
            this.Controls.Add(this.btRoot);
            this.Controls.Add(this.btOptellen);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbX);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormRekenmachine";
            this.Text = "Rekenmachine";
            this.Load += new System.EventHandler(this.FormRekenmachine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btOptellen;
        private System.Windows.Forms.Button btRoot;
        private System.Windows.Forms.Button btVierkantswortel;
        private System.Windows.Forms.Button btMachtsverheffing;
        private System.Windows.Forms.Button btKwadraat;
        private System.Windows.Forms.Button btDelen;
        private System.Windows.Forms.Button btVermenigvuldigen;
        private System.Windows.Forms.Button btAftrekken;
    }
}

