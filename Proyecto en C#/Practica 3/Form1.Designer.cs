namespace Practica_3
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
            this.components = new System.ComponentModel.Container();
            this.pnlGroup = new System.Windows.Forms.Panel();
            this.btnCargarIntermitentes = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVerdePrp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCambioTiempo = new System.Windows.Forms.Button();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.txtAmarilo = new System.Windows.Forms.TextBox();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblAmarillo = new System.Windows.Forms.Label();
            this.lblVerde9 = new System.Windows.Forms.Label();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.lblControl = new System.Windows.Forms.Label();
            this.pcbVLeft = new System.Windows.Forms.PictureBox();
            this.pcbVRight = new System.Windows.Forms.PictureBox();
            this.pcbHLeft = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            this.pcbHRight = new System.Windows.Forms.PictureBox();
            this.tmrIntermitentes = new System.Windows.Forms.Timer(this.components);
            this.pcbVerde1 = new System.Windows.Forms.PictureBox();
            this.pcbVerde = new System.Windows.Forms.PictureBox();
            this.lblVerde10 = new System.Windows.Forms.Label();
            this.pcbAmarillo = new System.Windows.Forms.PictureBox();
            this.pcbRojo = new System.Windows.Forms.PictureBox();
            this.pnlGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRojo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGroup
            // 
            this.pnlGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnlGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGroup.Controls.Add(this.btnCargarIntermitentes);
            this.pnlGroup.Controls.Add(this.panel1);
            this.pnlGroup.Controls.Add(this.btnDetener);
            this.pnlGroup.Controls.Add(this.btnIniciar);
            this.pnlGroup.Controls.Add(this.label3);
            this.pnlGroup.Controls.Add(this.label2);
            this.pnlGroup.Controls.Add(this.label1);
            this.pnlGroup.Controls.Add(this.pnlControl);
            this.pnlGroup.Location = new System.Drawing.Point(455, 237);
            this.pnlGroup.Name = "pnlGroup";
            this.pnlGroup.Size = new System.Drawing.Size(369, 252);
            this.pnlGroup.TabIndex = 4;
            // 
            // btnCargarIntermitentes
            // 
            this.btnCargarIntermitentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCargarIntermitentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarIntermitentes.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarIntermitentes.Location = new System.Drawing.Point(88, 172);
            this.btnCargarIntermitentes.Name = "btnCargarIntermitentes";
            this.btnCargarIntermitentes.Size = new System.Drawing.Size(192, 33);
            this.btnCargarIntermitentes.TabIndex = 39;
            this.btnCargarIntermitentes.Text = "Cargar intermitentes";
            this.btnCargarIntermitentes.UseVisualStyleBackColor = false;
            this.btnCargarIntermitentes.Click += new System.EventHandler(this.btnCargarIntermitentes_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(290, 704);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Seg";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(290, 676);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Seg";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(104, 702);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Seg";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(103, 676);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Seg";
            this.label8.Visible = false;
            // 
            // txtVerdePrp
            // 
            this.txtVerdePrp.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtVerdePrp.Enabled = false;
            this.txtVerdePrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerdePrp.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtVerdePrp.Location = new System.Drawing.Point(245, 699);
            this.txtVerdePrp.Name = "txtVerdePrp";
            this.txtVerdePrp.Size = new System.Drawing.Size(45, 20);
            this.txtVerdePrp.TabIndex = 29;
            this.txtVerdePrp.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(138, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Verde parpadeando";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(202, 675);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Verde";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 700);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Amarillo";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(11, 675);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Rojo";
            this.label4.Visible = false;
            // 
            // btnCambioTiempo
            // 
            this.btnCambioTiempo.BackColor = System.Drawing.Color.LightYellow;
            this.btnCambioTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioTiempo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambioTiempo.Location = new System.Drawing.Point(3, 673);
            this.btnCambioTiempo.Name = "btnCambioTiempo";
            this.btnCambioTiempo.Size = new System.Drawing.Size(183, 30);
            this.btnCambioTiempo.TabIndex = 29;
            this.btnCambioTiempo.UseVisualStyleBackColor = false;
            this.btnCambioTiempo.Visible = false;
            this.btnCambioTiempo.Click += new System.EventHandler(this.btnCambioTiempo_Click);
            // 
            // txtVerde
            // 
            this.txtVerde.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtVerde.Enabled = false;
            this.txtVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerde.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtVerde.Location = new System.Drawing.Point(245, 671);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(45, 20);
            this.txtVerde.TabIndex = 28;
            this.txtVerde.Visible = false;
            // 
            // txtAmarilo
            // 
            this.txtAmarilo.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtAmarilo.Enabled = false;
            this.txtAmarilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmarilo.ForeColor = System.Drawing.Color.Gold;
            this.txtAmarilo.Location = new System.Drawing.Point(57, 697);
            this.txtAmarilo.Name = "txtAmarilo";
            this.txtAmarilo.Size = new System.Drawing.Size(45, 20);
            this.txtAmarilo.TabIndex = 27;
            this.txtAmarilo.Visible = false;
            // 
            // txtRojo
            // 
            this.txtRojo.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtRojo.Enabled = false;
            this.txtRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRojo.ForeColor = System.Drawing.Color.Tomato;
            this.txtRojo.Location = new System.Drawing.Point(57, 673);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(45, 20);
            this.txtRojo.TabIndex = 25;
            this.txtRojo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblRojo);
            this.panel1.Controls.Add(this.lblAmarillo);
            this.panel1.Controls.Add(this.lblVerde9);
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 113);
            this.panel1.TabIndex = 26;
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Font = new System.Drawing.Font("SF Digital Readout", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRojo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRojo.Location = new System.Drawing.Point(14, 0);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(73, 90);
            this.lblRojo.TabIndex = 28;
            this.lblRojo.Text = "0";
            // 
            // lblAmarillo
            // 
            this.lblAmarillo.AutoSize = true;
            this.lblAmarillo.Font = new System.Drawing.Font("SF Digital Readout", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmarillo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAmarillo.Location = new System.Drawing.Point(131, 0);
            this.lblAmarillo.Name = "lblAmarillo";
            this.lblAmarillo.Size = new System.Drawing.Size(73, 90);
            this.lblAmarillo.TabIndex = 27;
            this.lblAmarillo.Text = "0";
            // 
            // lblVerde9
            // 
            this.lblVerde9.AutoSize = true;
            this.lblVerde9.Font = new System.Drawing.Font("SF Digital Readout", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde9.ForeColor = System.Drawing.Color.DimGray;
            this.lblVerde9.Location = new System.Drawing.Point(253, 0);
            this.lblVerde9.Name = "lblVerde9";
            this.lblVerde9.Size = new System.Drawing.Size(73, 90);
            this.lblVerde9.TabIndex = 26;
            this.lblVerde9.Text = "0";
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.LightCoral;
            this.btnDetener.Enabled = false;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(286, 172);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(78, 33);
            this.btnDetener.TabIndex = 12;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightGreen;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(3, 172);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(78, 33);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(5)))), ((int)(((byte)(6)))));
            this.label3.Location = new System.Drawing.Point(28, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(236)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(145, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amarillo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(282, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Verde";
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.Black;
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.lblControl);
            this.pnlControl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlControl.Location = new System.Drawing.Point(1, 1);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(368, 28);
            this.pnlControl.TabIndex = 3;
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblControl.Location = new System.Drawing.Point(81, -1);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(229, 29);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "Menú de control";
            this.lblControl.Click += new System.EventHandler(this.lblControl_Click);
            // 
            // pcbVLeft
            // 
            this.pcbVLeft.BackColor = System.Drawing.Color.Transparent;
            this.pcbVLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbVLeft.Image = global::Practica_3.Properties.Resources.SMVLeftOf;
            this.pcbVLeft.Location = new System.Drawing.Point(822, 70);
            this.pcbVLeft.Name = "pcbVLeft";
            this.pcbVLeft.Size = new System.Drawing.Size(57, 104);
            this.pcbVLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVLeft.TabIndex = 20;
            this.pcbVLeft.TabStop = false;
            // 
            // pcbVRight
            // 
            this.pcbVRight.BackColor = System.Drawing.Color.Transparent;
            this.pcbVRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbVRight.Image = global::Practica_3.Properties.Resources.SMVRighOft;
            this.pcbVRight.Location = new System.Drawing.Point(402, 534);
            this.pcbVRight.Name = "pcbVRight";
            this.pcbVRight.Size = new System.Drawing.Size(57, 104);
            this.pcbVRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVRight.TabIndex = 21;
            this.pcbVRight.TabStop = false;
            // 
            // pcbHLeft
            // 
            this.pcbHLeft.BackColor = System.Drawing.Color.Transparent;
            this.pcbHLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbHLeft.Image = global::Practica_3.Properties.Resources.SMHLeftOf1;
            this.pcbHLeft.Location = new System.Drawing.Point(869, 489);
            this.pcbHLeft.Name = "pcbHLeft";
            this.pcbHLeft.Size = new System.Drawing.Size(104, 57);
            this.pcbHLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHLeft.TabIndex = 22;
            this.pcbHLeft.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrDisplay
            // 
            this.tmrDisplay.Interval = 1000;
            this.tmrDisplay.Tick += new System.EventHandler(this.tmrDisplay_Tick);
            // 
            // pcbHRight
            // 
            this.pcbHRight.BackColor = System.Drawing.Color.Transparent;
            this.pcbHRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbHRight.Image = global::Practica_3.Properties.Resources.SMHRightOf1;
            this.pcbHRight.Location = new System.Drawing.Point(307, 169);
            this.pcbHRight.Name = "pcbHRight";
            this.pcbHRight.Size = new System.Drawing.Size(104, 57);
            this.pcbHRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbHRight.TabIndex = 24;
            this.pcbHRight.TabStop = false;
            // 
            // tmrIntermitentes
            // 
            this.tmrIntermitentes.Interval = 800;
            this.tmrIntermitentes.Tick += new System.EventHandler(this.tmrIntermitentes_Tick);
            // 
            // pcbVerde1
            // 
            this.pcbVerde1.BackColor = System.Drawing.Color.White;
            this.pcbVerde1.Image = global::Practica_3.Properties.Resources.off;
            this.pcbVerde1.Location = new System.Drawing.Point(3, 633);
            this.pcbVerde1.Name = "pcbVerde1";
            this.pcbVerde1.Size = new System.Drawing.Size(67, 80);
            this.pcbVerde1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVerde1.TabIndex = 13;
            this.pcbVerde1.TabStop = false;
            this.pcbVerde1.Visible = false;
            // 
            // pcbVerde
            // 
            this.pcbVerde.BackColor = System.Drawing.Color.White;
            this.pcbVerde.Image = global::Practica_3.Properties.Resources.off;
            this.pcbVerde.Location = new System.Drawing.Point(76, 633);
            this.pcbVerde.Name = "pcbVerde";
            this.pcbVerde.Size = new System.Drawing.Size(67, 80);
            this.pcbVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVerde.TabIndex = 1;
            this.pcbVerde.TabStop = false;
            this.pcbVerde.Visible = false;
            // 
            // lblVerde10
            // 
            this.lblVerde10.AutoSize = true;
            this.lblVerde10.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde10.ForeColor = System.Drawing.Color.DimGray;
            this.lblVerde10.Location = new System.Drawing.Point(297, 609);
            this.lblVerde10.Name = "lblVerde10";
            this.lblVerde10.Size = new System.Drawing.Size(99, 108);
            this.lblVerde10.TabIndex = 25;
            this.lblVerde10.Text = "0";
            this.lblVerde10.Visible = false;
            // 
            // pcbAmarillo
            // 
            this.pcbAmarillo.BackColor = System.Drawing.Color.White;
            this.pcbAmarillo.Image = global::Practica_3.Properties.Resources.off;
            this.pcbAmarillo.Location = new System.Drawing.Point(149, 633);
            this.pcbAmarillo.Name = "pcbAmarillo";
            this.pcbAmarillo.Size = new System.Drawing.Size(67, 80);
            this.pcbAmarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAmarillo.TabIndex = 7;
            this.pcbAmarillo.TabStop = false;
            this.pcbAmarillo.Visible = false;
            // 
            // pcbRojo
            // 
            this.pcbRojo.BackColor = System.Drawing.Color.White;
            this.pcbRojo.Image = global::Practica_3.Properties.Resources.off;
            this.pcbRojo.Location = new System.Drawing.Point(223, 633);
            this.pcbRojo.Name = "pcbRojo";
            this.pcbRojo.Size = new System.Drawing.Size(67, 80);
            this.pcbRojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRojo.TabIndex = 8;
            this.pcbRojo.TabStop = false;
            this.pcbRojo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica_3.Properties.Resources.Vía;
            this.ClientSize = new System.Drawing.Size(1280, 715);
            this.Controls.Add(this.pcbVerde);
            this.Controls.Add(this.pcbAmarillo);
            this.Controls.Add(this.pcbRojo);
            this.Controls.Add(this.pcbVerde1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pcbHRight);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pcbHLeft);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblVerde10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pcbVRight);
            this.Controls.Add(this.txtVerdePrp);
            this.Controls.Add(this.pcbVLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.btnCambioTiempo);
            this.Controls.Add(this.txtAmarilo);
            this.Controls.Add(this.txtRojo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1296, 754);
            this.MinimumSize = new System.Drawing.Size(1296, 754);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlGroup.ResumeLayout(false);
            this.pnlGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRojo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGroup;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.PictureBox pcbVLeft;
        private System.Windows.Forms.PictureBox pcbVRight;
        private System.Windows.Forms.PictureBox pcbHLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmrDisplay;
        private System.Windows.Forms.PictureBox pcbHRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblAmarillo;
        private System.Windows.Forms.Label lblVerde9;
        private System.Windows.Forms.Button btnCambioTiempo;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.TextBox txtAmarilo;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVerdePrp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargarIntermitentes;
        private System.Windows.Forms.Timer tmrIntermitentes;
        private System.Windows.Forms.PictureBox pcbVerde1;
        private System.Windows.Forms.PictureBox pcbVerde;
        private System.Windows.Forms.Label lblVerde10;
        private System.Windows.Forms.PictureBox pcbAmarillo;
        private System.Windows.Forms.PictureBox pcbRojo;
    }
}

