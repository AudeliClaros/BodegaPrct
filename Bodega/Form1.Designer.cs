
namespace Bodega
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
            this.lstBodegaInfo = new System.Windows.Forms.ListBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbodegaId = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtubicacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBodegaInfo
            // 
            this.lstBodegaInfo.FormattingEnabled = true;
            this.lstBodegaInfo.Location = new System.Drawing.Point(27, 280);
            this.lstBodegaInfo.Name = "lstBodegaInfo";
            this.lstBodegaInfo.Size = new System.Drawing.Size(738, 238);
            this.lstBodegaInfo.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(788, 376);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(172, 44);
            this.btn.TabIndex = 1;
            this.btn.Text = "Agregar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de la bodega";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ubicación";
            // 
            // txtbodegaId
            // 
            this.txtbodegaId.Location = new System.Drawing.Point(126, 42);
            this.txtbodegaId.Name = "txtbodegaId";
            this.txtbodegaId.Size = new System.Drawing.Size(100, 20);
            this.txtbodegaId.TabIndex = 5;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(126, 109);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(207, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtubicacion
            // 
            this.txtubicacion.Location = new System.Drawing.Point(126, 189);
            this.txtubicacion.Name = "txtubicacion";
            this.txtubicacion.Size = new System.Drawing.Size(294, 20);
            this.txtubicacion.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 530);
            this.Controls.Add(this.txtubicacion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtbodegaId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lstBodegaInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBodegaInfo;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbodegaId;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtubicacion;
    }
}

