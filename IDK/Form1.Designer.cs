namespace IDK
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.radioButtonDefinite = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonIndefinite = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonIndefinite = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLimpiarIndef = new System.Windows.Forms.Button();
            this.labelGraph = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLimpiarDef = new System.Windows.Forms.Button();
            this.textBoxAprox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxInf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDefResul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDefinite = new System.Windows.Forms.Button();
            this.textBoxDefinite = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(294, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(789, 76);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Calculadora de Integrales";
            // 
            // radioButtonDefinite
            // 
            this.radioButtonDefinite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonDefinite.AutoSize = true;
            this.radioButtonDefinite.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDefinite.Location = new System.Drawing.Point(588, 7);
            this.radioButtonDefinite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonDefinite.Name = "radioButtonDefinite";
            this.radioButtonDefinite.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.radioButtonDefinite.Size = new System.Drawing.Size(380, 33);
            this.radioButtonDefinite.TabIndex = 9;
            this.radioButtonDefinite.TabStop = true;
            this.radioButtonDefinite.Text = "Integrales Definidas";
            this.radioButtonDefinite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(29, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese un integral:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 31);
            this.textBox1.TabIndex = 0;
            // 
            // buttonIndefinite
            // 
            this.buttonIndefinite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonIndefinite.Location = new System.Drawing.Point(28, 103);
            this.buttonIndefinite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIndefinite.Name = "buttonIndefinite";
            this.buttonIndefinite.Size = new System.Drawing.Size(93, 40);
            this.buttonIndefinite.TabIndex = 2;
            this.buttonIndefinite.Text = "Integrar";
            this.buttonIndefinite.UseVisualStyleBackColor = false;
            this.buttonIndefinite.Click += new System.EventHandler(this.buttonIndefinite_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(203, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonIndefinite
            // 
            this.radioButtonIndefinite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonIndefinite.AutoSize = true;
            this.radioButtonIndefinite.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonIndefinite.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIndefinite.ForeColor = System.Drawing.Color.White;
            this.radioButtonIndefinite.Location = new System.Drawing.Point(111, 7);
            this.radioButtonIndefinite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonIndefinite.Name = "radioButtonIndefinite";
            this.radioButtonIndefinite.Size = new System.Drawing.Size(245, 33);
            this.radioButtonIndefinite.TabIndex = 8;
            this.radioButtonIndefinite.TabStop = true;
            this.radioButtonIndefinite.Text = "Integrales Indefinidas";
            this.radioButtonIndefinite.UseVisualStyleBackColor = false;
            this.radioButtonIndefinite.CheckedChanged += new System.EventHandler(this.radioButtonIndefinite_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonLimpiarIndef);
            this.panel1.Controls.Add(this.labelGraph);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonIndefinite);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-2, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 579);
            this.panel1.TabIndex = 12;
            // 
            // buttonLimpiarIndef
            // 
            this.buttonLimpiarIndef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLimpiarIndef.Location = new System.Drawing.Point(28, 167);
            this.buttonLimpiarIndef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLimpiarIndef.Name = "buttonLimpiarIndef";
            this.buttonLimpiarIndef.Size = new System.Drawing.Size(93, 40);
            this.buttonLimpiarIndef.TabIndex = 8;
            this.buttonLimpiarIndef.Text = "Limpiar";
            this.buttonLimpiarIndef.UseVisualStyleBackColor = false;
            // 
            // labelGraph
            // 
            this.labelGraph.AutoSize = true;
            this.labelGraph.Location = new System.Drawing.Point(206, 130);
            this.labelGraph.Name = "labelGraph";
            this.labelGraph.Size = new System.Drawing.Size(41, 13);
            this.labelGraph.TabIndex = 7;
            this.labelGraph.Text = "Grafica";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(290, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 31);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultado:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonLimpiarDef);
            this.panel2.Controls.Add(this.textBoxAprox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxInf);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxSup);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxDefResul);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonDefinite);
            this.panel2.Controls.Add(this.textBoxDefinite);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(652, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 579);
            this.panel2.TabIndex = 13;
            // 
            // buttonLimpiarDef
            // 
            this.buttonLimpiarDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonLimpiarDef.Location = new System.Drawing.Point(28, 438);
            this.buttonLimpiarDef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLimpiarDef.Name = "buttonLimpiarDef";
            this.buttonLimpiarDef.Size = new System.Drawing.Size(93, 40);
            this.buttonLimpiarDef.TabIndex = 14;
            this.buttonLimpiarDef.Text = "Limpiar";
            this.buttonLimpiarDef.UseVisualStyleBackColor = false;
            this.buttonLimpiarDef.Click += new System.EventHandler(this.buttonLimpiarDef_Click);
            // 
            // textBoxAprox
            // 
            this.textBoxAprox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxAprox.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxAprox.Location = new System.Drawing.Point(290, 91);
            this.textBoxAprox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAprox.Multiline = true;
            this.textBoxAprox.Name = "textBoxAprox";
            this.textBoxAprox.Size = new System.Drawing.Size(350, 31);
            this.textBoxAprox.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Aproximacion:";
            // 
            // textBoxInf
            // 
            this.textBoxInf.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxInf.Location = new System.Drawing.Point(28, 289);
            this.textBoxInf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInf.Multiline = true;
            this.textBoxInf.Name = "textBoxInf";
            this.textBoxInf.Size = new System.Drawing.Size(80, 31);
            this.textBoxInf.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(29, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Limite Inferior:";
            // 
            // textBoxSup
            // 
            this.textBoxSup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxSup.Location = new System.Drawing.Point(28, 167);
            this.textBoxSup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSup.Multiline = true;
            this.textBoxSup.Name = "textBoxSup";
            this.textBoxSup.Size = new System.Drawing.Size(80, 31);
            this.textBoxSup.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(29, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Limite Superior:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grafica";
            // 
            // textBoxDefResul
            // 
            this.textBoxDefResul.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxDefResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxDefResul.Location = new System.Drawing.Point(290, 30);
            this.textBoxDefResul.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDefResul.Multiline = true;
            this.textBoxDefResul.Name = "textBoxDefResul";
            this.textBoxDefResul.Size = new System.Drawing.Size(350, 31);
            this.textBoxDefResul.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resultado:";
            // 
            // buttonDefinite
            // 
            this.buttonDefinite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDefinite.Location = new System.Drawing.Point(28, 373);
            this.buttonDefinite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDefinite.Name = "buttonDefinite";
            this.buttonDefinite.Size = new System.Drawing.Size(93, 40);
            this.buttonDefinite.TabIndex = 2;
            this.buttonDefinite.Text = "Integrar";
            this.buttonDefinite.UseVisualStyleBackColor = false;
            this.buttonDefinite.Click += new System.EventHandler(this.buttonDefinite_Click);
            // 
            // textBoxDefinite
            // 
            this.textBoxDefinite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxDefinite.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.textBoxDefinite.Location = new System.Drawing.Point(28, 52);
            this.textBoxDefinite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDefinite.Multiline = true;
            this.textBoxDefinite.Name = "textBoxDefinite";
            this.textBoxDefinite.Size = new System.Drawing.Size(199, 31);
            this.textBoxDefinite.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(264, 157);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(376, 407);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(29, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese un integral:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Definida",
            "Valor Promedio"});
            this.comboBox1.Location = new System.Drawing.Point(1069, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.radioButtonIndefinite);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.radioButtonDefinite);
            this.panel3.Location = new System.Drawing.Point(-2, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1308, 45);
            this.panel3.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IDK.Properties.Resources.download1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 721);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.RadioButton radioButtonDefinite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIndefinite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label labelGraph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDefResul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDefinite;
        private System.Windows.Forms.TextBox textBoxDefinite;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAprox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonIndefinite;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonLimpiarIndef;
        private System.Windows.Forms.Button buttonLimpiarDef;
    }
}

