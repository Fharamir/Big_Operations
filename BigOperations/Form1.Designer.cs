namespace BigOperations
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Primo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Counter1 = new System.Windows.Forms.Label();
            this.Counter2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Secondo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Totale = new System.Windows.Forms.TextBox();
            this.Counter3 = new System.Windows.Forms.Label();
            this.SuperDivision = new System.Windows.Forms.CheckBox();
            this.SDInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Copyto1 = new System.Windows.Forms.Button();
            this.Copyto2 = new System.Windows.Forms.Button();
            this.CopytoC = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Primo
            // 
            this.Primo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Primo.Location = new System.Drawing.Point(12, 47);
            this.Primo.Multiline = true;
            this.Primo.Name = "Primo";
            this.Primo.Size = new System.Drawing.Size(405, 130);
            this.Primo.TabIndex = 0;
            this.Primo.TextChanged += new System.EventHandler(this.Totalchar);
            this.Primo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keepchars);
            this.Primo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AllowPaste);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Number";
            // 
            // Counter1
            // 
            this.Counter1.AutoSize = true;
            this.Counter1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter1.Location = new System.Drawing.Point(402, 26);
            this.Counter1.Name = "Counter1";
            this.Counter1.Size = new System.Drawing.Size(15, 18);
            this.Counter1.TabIndex = 2;
            this.Counter1.Text = "0";
            // 
            // Counter2
            // 
            this.Counter2.AutoSize = true;
            this.Counter2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter2.Location = new System.Drawing.Point(402, 185);
            this.Counter2.Name = "Counter2";
            this.Counter2.Size = new System.Drawing.Size(15, 18);
            this.Counter2.TabIndex = 5;
            this.Counter2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Second Number";
            // 
            // Secondo
            // 
            this.Secondo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Secondo.Location = new System.Drawing.Point(12, 206);
            this.Secondo.Multiline = true;
            this.Secondo.Name = "Secondo";
            this.Secondo.Size = new System.Drawing.Size(405, 130);
            this.Secondo.TabIndex = 3;
            this.Secondo.TextChanged += new System.EventHandler(this.Totalchar);
            this.Secondo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keepchars);
            this.Secondo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AllowPaste);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Operation";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Add.Location = new System.Drawing.Point(15, 369);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(92, 36);
            this.Add.TabIndex = 7;
            this.Add.Text = "Addition";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Sub.Location = new System.Drawing.Point(118, 369);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(92, 36);
            this.Sub.TabIndex = 8;
            this.Sub.Text = "Subtraction";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Mult.Location = new System.Drawing.Point(222, 369);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(92, 36);
            this.Mult.TabIndex = 9;
            this.Mult.Text = "Multiplication";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Div.Location = new System.Drawing.Point(325, 369);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(92, 36);
            this.Div.TabIndex = 10;
            this.Div.Text = "Division";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Div_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Result";
            // 
            // Totale
            // 
            this.Totale.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totale.Location = new System.Drawing.Point(12, 445);
            this.Totale.Multiline = true;
            this.Totale.Name = "Totale";
            this.Totale.Size = new System.Drawing.Size(405, 130);
            this.Totale.TabIndex = 11;
            this.Totale.TextChanged += new System.EventHandler(this.Totalchar);
            // 
            // Counter3
            // 
            this.Counter3.AutoSize = true;
            this.Counter3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter3.Location = new System.Drawing.Point(402, 424);
            this.Counter3.Name = "Counter3";
            this.Counter3.Size = new System.Drawing.Size(15, 18);
            this.Counter3.TabIndex = 13;
            this.Counter3.Text = "0";
            // 
            // SuperDivision
            // 
            this.SuperDivision.AutoSize = true;
            this.SuperDivision.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.SuperDivision.Location = new System.Drawing.Point(288, 348);
            this.SuperDivision.Name = "SuperDivision";
            this.SuperDivision.Size = new System.Drawing.Size(108, 21);
            this.SuperDivision.TabIndex = 14;
            this.SuperDivision.Text = "Super Division";
            this.SuperDivision.UseVisualStyleBackColor = true;
            // 
            // SDInfo
            // 
            this.SDInfo.AutoSize = true;
            this.SDInfo.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDInfo.ForeColor = System.Drawing.Color.MediumBlue;
            this.SDInfo.Location = new System.Drawing.Point(402, 349);
            this.SDInfo.Name = "SDInfo";
            this.SDInfo.Size = new System.Drawing.Size(14, 17);
            this.SDInfo.TabIndex = 15;
            this.SDInfo.Text = "?";
            this.SDInfo.Click += new System.EventHandler(this.SDInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Calculation time:";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(245, 426);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(31, 16);
            this.Time.TabIndex = 17;
            this.Time.Text = "0 ms";
            // 
            // Copyto1
            // 
            this.Copyto1.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Copyto1.Location = new System.Drawing.Point(12, 581);
            this.Copyto1.Name = "Copyto1";
            this.Copyto1.Size = new System.Drawing.Size(104, 36);
            this.Copyto1.TabIndex = 18;
            this.Copyto1.Text = "Copy to First";
            this.Copyto1.UseVisualStyleBackColor = true;
            this.Copyto1.Click += new System.EventHandler(this.Copyto1_Click);
            // 
            // Copyto2
            // 
            this.Copyto2.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Copyto2.Location = new System.Drawing.Point(122, 581);
            this.Copyto2.Name = "Copyto2";
            this.Copyto2.Size = new System.Drawing.Size(104, 36);
            this.Copyto2.TabIndex = 19;
            this.Copyto2.Text = "Copy to Second";
            this.Copyto2.UseVisualStyleBackColor = true;
            this.Copyto2.Click += new System.EventHandler(this.Copyto2_Click);
            // 
            // CopytoC
            // 
            this.CopytoC.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.CopytoC.Location = new System.Drawing.Point(232, 581);
            this.CopytoC.Name = "CopytoC";
            this.CopytoC.Size = new System.Drawing.Size(122, 36);
            this.CopytoC.TabIndex = 20;
            this.CopytoC.Text = "Copy to Clipboard";
            this.CopytoC.UseVisualStyleBackColor = true;
            this.CopytoC.Click += new System.EventHandler(this.CopytoC_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.Exit.Location = new System.Drawing.Point(360, 581);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(56, 36);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 627);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CopytoC);
            this.Controls.Add(this.Copyto2);
            this.Controls.Add(this.Copyto1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SDInfo);
            this.Controls.Add(this.SuperDivision);
            this.Controls.Add(this.Counter3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Totale);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Counter2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Secondo);
            this.Controls.Add(this.Counter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Primo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(445, 665);
            this.MinimumSize = new System.Drawing.Size(445, 665);
            this.Name = "Main";
            this.Text = "BigOperations 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Primo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Counter1;
        private System.Windows.Forms.Label Counter2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Secondo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Sub;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Totale;
        private System.Windows.Forms.Label Counter3;
        private System.Windows.Forms.CheckBox SuperDivision;
        private System.Windows.Forms.Label SDInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button Copyto1;
        private System.Windows.Forms.Button Copyto2;
        private System.Windows.Forms.Button CopytoC;
        private System.Windows.Forms.Button Exit;
    }
}

