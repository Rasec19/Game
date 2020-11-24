namespace JuegoCars
{
    partial class Pista
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
            this.components = new System.ComponentModel.Container();
            this.Carretera = new System.Windows.Forms.PictureBox();
            this.puntos = new System.Windows.Forms.Label();
            this.timerCar1 = new System.Windows.Forms.Timer(this.components);
            this.timerAnimationCar1 = new System.Windows.Forms.Timer(this.components);
            this.timerGenObjCar1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).BeginInit();
            this.SuspendLayout();
            // 
            // Carretera
            // 
            this.Carretera.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Carretera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Carretera.Location = new System.Drawing.Point(0, 0);
            this.Carretera.Name = "Carretera";
            this.Carretera.Size = new System.Drawing.Size(384, 461);
            this.Carretera.TabIndex = 0;
            this.Carretera.TabStop = false;
            this.Carretera.Paint += new System.Windows.Forms.PaintEventHandler(this.Carretera_Paint);
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.puntos.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.Location = new System.Drawing.Point(324, 9);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(25, 23);
            this.puntos.TabIndex = 1;
            this.puntos.Text = "0";
            // 
            // timerCar1
            // 
            this.timerCar1.Interval = 10;
            this.timerCar1.Tick += new System.EventHandler(this.timerCar1_Tick);
            // 
            // timerAnimationCar1
            // 
            this.timerAnimationCar1.Interval = 1;
            this.timerAnimationCar1.Tick += new System.EventHandler(this.timerAnimationCar1_Tick);
            // 
            // timerGenObjCar1
            // 
            this.timerGenObjCar1.Interval = 315;
            this.timerGenObjCar1.Tick += new System.EventHandler(this.timerGenObjCar1_Tick);
            // 
            // Pista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.Carretera);
            this.Name = "Pista";
            this.Text = "Juego Cars";
            this.Load += new System.EventHandler(this.Pista_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pista_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Carretera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Carretera;
        private System.Windows.Forms.Label puntos;
        private System.Windows.Forms.Timer timerCar1;
        private System.Windows.Forms.Timer timerAnimationCar1;
        private System.Windows.Forms.Timer timerGenObjCar1;
    }
}

