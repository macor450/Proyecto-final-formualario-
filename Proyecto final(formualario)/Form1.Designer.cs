namespace Proyecto_final_formualario_
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblComenzar = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.lblfin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(1, 431);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(568, 18);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(1, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(568, 18);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(118, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(372, 77);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "ping pong";
            // 
            // lblComenzar
            // 
            this.lblComenzar.AutoSize = true;
            this.lblComenzar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComenzar.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComenzar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblComenzar.Location = new System.Drawing.Point(123, 187);
            this.lblComenzar.Name = "lblComenzar";
            this.lblComenzar.Size = new System.Drawing.Size(225, 46);
            this.lblComenzar.TabIndex = 4;
            this.lblComenzar.Text = "Comenzar";
            this.lblComenzar.Click += new System.EventHandler(this.lblComenzar_Click);
            this.lblComenzar.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.lblComenzar.MouseEnter += new System.EventHandler(this.lblComenzar_MouseEnter);
            this.lblComenzar.MouseLeave += new System.EventHandler(this.lblComenzar_MouseLeave);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalir.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalir.Location = new System.Drawing.Point(118, 303);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(119, 46);
            this.lblSalir.TabIndex = 5;
            this.lblSalir.Text = "Salir";
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            this.lblSalir.MouseEnter += new System.EventHandler(this.lblSalir_MouseEnter);
            this.lblSalir.MouseLeave += new System.EventHandler(this.lblSalir_MouseLeave);
            // 
            // Tiempo
            // 
            this.Tiempo.Interval = 1;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfin.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfin.Location = new System.Drawing.Point(245, 141);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(0, 46);
            this.lblfin.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.lblfin);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblComenzar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblComenzar;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Label lblfin;
    }
}

