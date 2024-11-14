namespace Brazo_Robotico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBarBase = new System.Windows.Forms.TrackBar();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.trackBarCodo = new System.Windows.Forms.TrackBar();
            this.trackBarBrazo = new System.Windows.Forms.TrackBar();
            this.trackBarMano = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMano)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarBase
            // 
            this.trackBarBase.Location = new System.Drawing.Point(222, 150);
            this.trackBarBase.Name = "trackBarBase";
            this.trackBarBase.Size = new System.Drawing.Size(328, 45);
            this.trackBarBase.TabIndex = 0;
            this.trackBarBase.Scroll += new System.EventHandler(this.trackBarBase_Scroll);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(397, 76);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 1;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // trackBarCodo
            // 
            this.trackBarCodo.Location = new System.Drawing.Point(222, 212);
            this.trackBarCodo.Name = "trackBarCodo";
            this.trackBarCodo.Size = new System.Drawing.Size(328, 45);
            this.trackBarCodo.TabIndex = 2;
            this.trackBarCodo.Scroll += new System.EventHandler(this.trackBarCodo_Scroll);
            // 
            // trackBarBrazo
            // 
            this.trackBarBrazo.Location = new System.Drawing.Point(222, 279);
            this.trackBarBrazo.Name = "trackBarBrazo";
            this.trackBarBrazo.Size = new System.Drawing.Size(328, 45);
            this.trackBarBrazo.TabIndex = 3;
            this.trackBarBrazo.Scroll += new System.EventHandler(this.trackBarBrazo_Scroll);
            // 
            // trackBarMano
            // 
            this.trackBarMano.Location = new System.Drawing.Point(222, 348);
            this.trackBarMano.Name = "trackBarMano";
            this.trackBarMano.Size = new System.Drawing.Size(328, 45);
            this.trackBarMano.TabIndex = 4;
            this.trackBarMano.Scroll += new System.EventHandler(this.trackBarMano_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar Puerto COM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "BRAZO ROBOTICO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 450);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 336);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "BASE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CODO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "BRAZO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "MANO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarMano);
            this.Controls.Add(this.trackBarBrazo);
            this.Controls.Add(this.trackBarCodo);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.trackBarBase);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMano)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarBase;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.TrackBar trackBarCodo;
        private System.Windows.Forms.TrackBar trackBarBrazo;
        private System.Windows.Forms.TrackBar trackBarMano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

