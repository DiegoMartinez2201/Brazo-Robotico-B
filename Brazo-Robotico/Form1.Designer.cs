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
            this.trackBarBase = new System.Windows.Forms.TrackBar();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.trackBarCodo = new System.Windows.Forms.TrackBar();
            this.trackBarBrazo = new System.Windows.Forms.TrackBar();
            this.trackBarMano = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMano)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarBase
            // 
            this.trackBarBase.Location = new System.Drawing.Point(222, 129);
            this.trackBarBase.Name = "trackBarBase";
            this.trackBarBase.Size = new System.Drawing.Size(328, 45);
            this.trackBarBase.TabIndex = 0;
            this.trackBarBase.Scroll += new System.EventHandler(this.trackBarBase_Scroll);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(149, 25);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 1;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // trackBarCodo
            // 
            this.trackBarCodo.Location = new System.Drawing.Point(222, 180);
            this.trackBarCodo.Name = "trackBarCodo";
            this.trackBarCodo.Size = new System.Drawing.Size(328, 45);
            this.trackBarCodo.TabIndex = 2;
            this.trackBarCodo.Scroll += new System.EventHandler(this.trackBarCodo_Scroll);
            // 
            // trackBarBrazo
            // 
            this.trackBarBrazo.Location = new System.Drawing.Point(222, 231);
            this.trackBarBrazo.Name = "trackBarBrazo";
            this.trackBarBrazo.Size = new System.Drawing.Size(328, 45);
            this.trackBarBrazo.TabIndex = 3;
            this.trackBarBrazo.Scroll += new System.EventHandler(this.trackBarBrazo_Scroll);
            // 
            // trackBarMano
            // 
            this.trackBarMano.Location = new System.Drawing.Point(222, 282);
            this.trackBarMano.Name = "trackBarMano";
            this.trackBarMano.Size = new System.Drawing.Size(328, 45);
            this.trackBarMano.TabIndex = 4;
            this.trackBarMano.Scroll += new System.EventHandler(this.trackBarMano_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarMano);
            this.Controls.Add(this.trackBarBrazo);
            this.Controls.Add(this.trackBarCodo);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.trackBarBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarBase;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.TrackBar trackBarCodo;
        private System.Windows.Forms.TrackBar trackBarBrazo;
        private System.Windows.Forms.TrackBar trackBarMano;
    }
}

