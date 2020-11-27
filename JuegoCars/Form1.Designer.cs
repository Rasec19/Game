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
            this.timerCar2 = new System.Windows.Forms.Timer(this.components);
            this.timerAnimationCar2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timerGenObjCar2 = new System.Windows.Forms.Timer(this.components);
            this.puntosCar2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.puntos.Location = new System.Drawing.Point(89, 9);
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
            // timerCar2
            // 
            this.timerCar2.Interval = 10;
            this.timerCar2.Tick += new System.EventHandler(this.timerCar2_Tick);
            // 
            // timerAnimationCar2
            // 
            this.timerAnimationCar2.Interval = 1;
            this.timerAnimationCar2.Tick += new System.EventHandler(this.timerAnimationCar2_Tick);
            // 
            // timerGenObjCar2
            // 
            this.timerGenObjCar2.Interval = 315;
            this.timerGenObjCar2.Tick += new System.EventHandler(this.timerGenObjCar2_Tick);
            // 
            // puntosCar2
            // 
            this.puntosCar2.AutoSize = true;
            this.puntosCar2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.puntosCar2.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntosCar2.Location = new System.Drawing.Point(322, 9);
            this.puntosCar2.Name = "puntosCar2";
            this.puntosCar2.Size = new System.Drawing.Size(25, 23);
            this.puntosCar2.TabIndex = 2;
            this.puntosCar2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Castellar", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player 2:";
            // 
            // Pista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puntosCar2);
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
        private System.Windows.Forms.Timer timerCar2;
        private System.Windows.Forms.Timer timerAnimationCar2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timerGenObjCar2;
        private System.Windows.Forms.Label puntosCar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

