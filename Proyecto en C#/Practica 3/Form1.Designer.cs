namespace Practica_3
{
    partial class frmSimulacion
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
            this.components = new System.ComponentModel.Container();
            this.pnlGroup = new System.Windows.Forms.Panel();
            this.pnlMenuControl = new System.Windows.Forms.Panel();
            this.lblDisplayRojo = new System.Windows.Forms.Label();
            this.lblDisplayAmarillo = new System.Windows.Forms.Label();
            this.lblDisplayVerde = new System.Windows.Forms.Label();
            this.btnPreventivas = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblEtiquetaRoja = new System.Windows.Forms.Label();
            this.lblEtiquetaAmarilla = new System.Windows.Forms.Label();
            this.lblEtiquetaVerde = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblControl = new System.Windows.Forms.Label();
            this.pcbDerechaV = new System.Windows.Forms.PictureBox();
            this.pcbIzquierdaV = new System.Windows.Forms.PictureBox();
            this.pcbDerechaH = new System.Windows.Forms.PictureBox();
            this.tmrCambioSemaforos = new System.Windows.Forms.Timer(this.components);
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            this.pcbIzquierdaH = new System.Windows.Forms.PictureBox();
            this.tmrPreventivas = new System.Windows.Forms.Timer(this.components);
            this.lblVerdeAuxiliar = new System.Windows.Forms.Label();
            this.tmrCambioDisplays = new System.Windows.Forms.Timer(this.components);
            this.pnlGroup.SuspendLayout();
            this.pnlMenuControl.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDerechaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIzquierdaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDerechaH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIzquierdaH)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGroup
            // 
            this.pnlGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnlGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGroup.Controls.Add(this.pnlMenuControl);
            this.pnlGroup.Controls.Add(this.btnPreventivas);
            this.pnlGroup.Controls.Add(this.btnDetener);
            this.pnlGroup.Controls.Add(this.btnIniciar);
            this.pnlGroup.Controls.Add(this.lblEtiquetaRoja);
            this.pnlGroup.Controls.Add(this.lblEtiquetaAmarilla);
            this.pnlGroup.Controls.Add(this.lblEtiquetaVerde);
            this.pnlGroup.Controls.Add(this.pnlControl);
            this.pnlGroup.Location = new System.Drawing.Point(607, 319);
            this.pnlGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGroup.Name = "pnlGroup";
            this.pnlGroup.Size = new System.Drawing.Size(491, 246);
            this.pnlGroup.TabIndex = 4;
            // 
            // pnlMenuControl
            // 
            this.pnlMenuControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenuControl.Controls.Add(this.lblDisplayRojo);
            this.pnlMenuControl.Controls.Add(this.lblDisplayAmarillo);
            this.pnlMenuControl.Controls.Add(this.lblDisplayVerde);
            this.pnlMenuControl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenuControl.Location = new System.Drawing.Point(4, 68);
            this.pnlMenuControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMenuControl.Name = "pnlMenuControl";
            this.pnlMenuControl.Size = new System.Drawing.Size(481, 118);
            this.pnlMenuControl.TabIndex = 26;
            // 
            // lblDisplayRojo
            // 
            this.lblDisplayRojo.AutoSize = true;
            this.lblDisplayRojo.Font = new System.Drawing.Font("SF Digital Readout", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayRojo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDisplayRojo.Location = new System.Drawing.Point(19, 0);
            this.lblDisplayRojo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayRojo.Name = "lblDisplayRojo";
            this.lblDisplayRojo.Size = new System.Drawing.Size(92, 113);
            this.lblDisplayRojo.TabIndex = 28;
            this.lblDisplayRojo.Text = "0";
            // 
            // lblDisplayAmarillo
            // 
            this.lblDisplayAmarillo.AutoSize = true;
            this.lblDisplayAmarillo.Font = new System.Drawing.Font("SF Digital Readout", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAmarillo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDisplayAmarillo.Location = new System.Drawing.Point(175, 0);
            this.lblDisplayAmarillo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayAmarillo.Name = "lblDisplayAmarillo";
            this.lblDisplayAmarillo.Size = new System.Drawing.Size(92, 113);
            this.lblDisplayAmarillo.TabIndex = 27;
            this.lblDisplayAmarillo.Text = "0";
            // 
            // lblDisplayVerde
            // 
            this.lblDisplayVerde.AutoSize = true;
            this.lblDisplayVerde.Font = new System.Drawing.Font("SF Digital Readout", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayVerde.ForeColor = System.Drawing.Color.DimGray;
            this.lblDisplayVerde.Location = new System.Drawing.Point(337, 0);
            this.lblDisplayVerde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayVerde.Name = "lblDisplayVerde";
            this.lblDisplayVerde.Size = new System.Drawing.Size(92, 113);
            this.lblDisplayVerde.TabIndex = 26;
            this.lblDisplayVerde.Text = "0";
            // 
            // btnPreventivas
            // 
            this.btnPreventivas.BackColor = System.Drawing.Color.Khaki;
            this.btnPreventivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreventivas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreventivas.Location = new System.Drawing.Point(173, 191);
            this.btnPreventivas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPreventivas.Name = "btnPreventivas";
            this.btnPreventivas.Size = new System.Drawing.Size(144, 41);
            this.btnPreventivas.TabIndex = 39;
            this.btnPreventivas.Text = "Preventivas";
            this.btnPreventivas.UseVisualStyleBackColor = false;
            this.btnPreventivas.Click += new System.EventHandler(this.btnPreventivas_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.LightCoral;
            this.btnDetener.Enabled = false;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(361, 191);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(124, 41);
            this.btnDetener.TabIndex = 12;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightGreen;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(4, 191);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(104, 41);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblEtiquetaRoja
            // 
            this.lblEtiquetaRoja.AutoSize = true;
            this.lblEtiquetaRoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaRoja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(5)))), ((int)(((byte)(6)))));
            this.lblEtiquetaRoja.Location = new System.Drawing.Point(37, 39);
            this.lblEtiquetaRoja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiquetaRoja.Name = "lblEtiquetaRoja";
            this.lblEtiquetaRoja.Size = new System.Drawing.Size(55, 25);
            this.lblEtiquetaRoja.TabIndex = 10;
            this.lblEtiquetaRoja.Text = "Rojo";
            // 
            // lblEtiquetaAmarilla
            // 
            this.lblEtiquetaAmarilla.AutoSize = true;
            this.lblEtiquetaAmarilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaAmarilla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(37)))));
            this.lblEtiquetaAmarilla.Location = new System.Drawing.Point(193, 39);
            this.lblEtiquetaAmarilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiquetaAmarilla.Name = "lblEtiquetaAmarilla";
            this.lblEtiquetaAmarilla.Size = new System.Drawing.Size(90, 25);
            this.lblEtiquetaAmarilla.TabIndex = 9;
            this.lblEtiquetaAmarilla.Text = "Amarillo";
            // 
            // lblEtiquetaVerde
            // 
            this.lblEtiquetaVerde.AutoSize = true;
            this.lblEtiquetaVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaVerde.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblEtiquetaVerde.Location = new System.Drawing.Point(376, 37);
            this.lblEtiquetaVerde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEtiquetaVerde.Name = "lblEtiquetaVerde";
            this.lblEtiquetaVerde.Size = new System.Drawing.Size(70, 25);
            this.lblEtiquetaVerde.TabIndex = 4;
            this.lblEtiquetaVerde.Text = "Verde";
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Black;
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.lblControl);
            this.pnlControl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlControl.Location = new System.Drawing.Point(1, 1);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(490, 34);
            this.pnlControl.TabIndex = 3;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblControl.Location = new System.Drawing.Point(108, -1);
            this.lblControl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(286, 36);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "Menú de control";
            // 
            // pcbDerechaV
            // 
            this.pcbDerechaV.BackColor = System.Drawing.Color.Transparent;
            this.pcbDerechaV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbDerechaV.Image = global::Practica_3.Properties.Resources.SMVLeftOf;
            this.pcbDerechaV.Location = new System.Drawing.Point(1096, 86);
            this.pcbDerechaV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbDerechaV.Name = "pcbDerechaV";
            this.pcbDerechaV.Size = new System.Drawing.Size(76, 128);
            this.pcbDerechaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDerechaV.TabIndex = 20;
            this.pcbDerechaV.TabStop = false;
            // 
            // pcbIzquierdaV
            // 
            this.pcbIzquierdaV.BackColor = System.Drawing.Color.Transparent;
            this.pcbIzquierdaV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIzquierdaV.Image = global::Practica_3.Properties.Resources.SMVRighOft;
            this.pcbIzquierdaV.Location = new System.Drawing.Point(536, 657);
            this.pcbIzquierdaV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbIzquierdaV.Name = "pcbIzquierdaV";
            this.pcbIzquierdaV.Size = new System.Drawing.Size(76, 128);
            this.pcbIzquierdaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIzquierdaV.TabIndex = 21;
            this.pcbIzquierdaV.TabStop = false;
            // 
            // pcbDerechaH
            // 
            this.pcbDerechaH.BackColor = System.Drawing.Color.Transparent;
            this.pcbDerechaH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbDerechaH.Image = global::Practica_3.Properties.Resources.SMHLeftOf1;
            this.pcbDerechaH.Location = new System.Drawing.Point(1159, 602);
            this.pcbDerechaH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbDerechaH.Name = "pcbDerechaH";
            this.pcbDerechaH.Size = new System.Drawing.Size(139, 70);
            this.pcbDerechaH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDerechaH.TabIndex = 22;
            this.pcbDerechaH.TabStop = false;
            // 
            // tmrCambioSemaforos
            // 
            this.tmrCambioSemaforos.Interval = 1;
            this.tmrCambioSemaforos.Tick += new System.EventHandler(this.tmrCambioSemaforos_Tick_1);
            // 
            // tmrDisplay
            // 
            this.tmrDisplay.Interval = 1000;
            this.tmrDisplay.Tick += new System.EventHandler(this.tmrDisplay_Tick);
            // 
            // pcbIzquierdaH
            // 
            this.pcbIzquierdaH.BackColor = System.Drawing.Color.Transparent;
            this.pcbIzquierdaH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIzquierdaH.Image = global::Practica_3.Properties.Resources.SMHRightOf1;
            this.pcbIzquierdaH.Location = new System.Drawing.Point(409, 208);
            this.pcbIzquierdaH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbIzquierdaH.Name = "pcbIzquierdaH";
            this.pcbIzquierdaH.Size = new System.Drawing.Size(139, 70);
            this.pcbIzquierdaH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIzquierdaH.TabIndex = 24;
            this.pcbIzquierdaH.TabStop = false;
            // 
            // tmrPreventivas
            // 
            this.tmrPreventivas.Interval = 500;
            this.tmrPreventivas.Tick += new System.EventHandler(this.tmrPreventias_Tick);
            // 
            // lblVerdeAuxiliar
            // 
            this.lblVerdeAuxiliar.AutoSize = true;
            this.lblVerdeAuxiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerdeAuxiliar.ForeColor = System.Drawing.Color.DimGray;
            this.lblVerdeAuxiliar.Location = new System.Drawing.Point(16, 838);
            this.lblVerdeAuxiliar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerdeAuxiliar.Name = "lblVerdeAuxiliar";
            this.lblVerdeAuxiliar.Size = new System.Drawing.Size(30, 31);
            this.lblVerdeAuxiliar.TabIndex = 25;
            this.lblVerdeAuxiliar.Text = "0";
            this.lblVerdeAuxiliar.Visible = false;
            // 
            // tmrCambioDisplays
            // 
            this.tmrCambioDisplays.Interval = 500;
            this.tmrCambioDisplays.Tick += new System.EventHandler(this.tmrCambioDisplays_Tick);
            // 
            // frmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica_3.Properties.Resources.Vía;
            this.ClientSize = new System.Drawing.Size(1704, 870);
            this.Controls.Add(this.pcbIzquierdaH);
            this.Controls.Add(this.pcbDerechaH);
            this.Controls.Add(this.lblVerdeAuxiliar);
            this.Controls.Add(this.pcbIzquierdaV);
            this.Controls.Add(this.pcbDerechaV);
            this.Controls.Add(this.pnlGroup);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1722, 917);
            this.MinimumSize = new System.Drawing.Size(1722, 917);
            this.Name = "frmSimulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlGroup.ResumeLayout(false);
            this.pnlGroup.PerformLayout();
            this.pnlMenuControl.ResumeLayout(false);
            this.pnlMenuControl.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDerechaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIzquierdaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDerechaH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIzquierdaH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGroup;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblEtiquetaRoja;
        private System.Windows.Forms.Label lblEtiquetaAmarilla;
        private System.Windows.Forms.Label lblEtiquetaVerde;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.PictureBox pcbDerechaV;
        private System.Windows.Forms.PictureBox pcbIzquierdaV;
        private System.Windows.Forms.PictureBox pcbDerechaH;
        private System.Windows.Forms.Timer tmrCambioSemaforos;
        private System.Windows.Forms.Timer tmrDisplay;
        private System.Windows.Forms.PictureBox pcbIzquierdaH;
        private System.Windows.Forms.Panel pnlMenuControl;
        private System.Windows.Forms.Label lblDisplayRojo;
        private System.Windows.Forms.Label lblDisplayAmarillo;
        private System.Windows.Forms.Label lblDisplayVerde;
        private System.Windows.Forms.Button btnPreventivas;
        private System.Windows.Forms.Timer tmrPreventivas;
        private System.Windows.Forms.Label lblVerdeAuxiliar;
        private System.Windows.Forms.Timer tmrCambioDisplays;
    }
}

