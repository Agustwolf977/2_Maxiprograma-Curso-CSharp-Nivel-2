namespace TareaWinForms
{
    partial class miPrimerAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miPrimerAplicacion));
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(39, 45);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(131, 109);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Botón Para No Se Qué";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1.Location = new System.Drawing.Point(286, 129);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(233, 26);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Label Para No Se Qué";
            this.lbl1.MouseLeave += new System.EventHandler(this.lbl1_MouseLeave);
            this.lbl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl1_MouseMove);
            // 
            // txb1
            // 
            this.txb1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb1.Location = new System.Drawing.Point(350, 179);
            this.txb1.MaxLength = 32768;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(100, 20);
            this.txb1.TabIndex = 2;
            this.txb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb1_KeyPress);
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(350, 230);
            this.txb2.Multiline = true;
            this.txb2.Name = "txb2";
            this.txb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb2.Size = new System.Drawing.Size(100, 75);
            this.txb2.TabIndex = 3;
            this.txb2.Leave += new System.EventHandler(this.txb2_Leave);
            // 
            // miPrimerAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "miPrimerAplicacion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mi Primera Aplicación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.miPrimerAplicacion_FormClosed);
            this.Load += new System.EventHandler(this.miPrimerAplicacion_Load);
            this.Click += new System.EventHandler(this.miPrimerAplicacion_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox txb2;
    }
}