
namespace reproductor
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
            this.pbxPlay = new System.Windows.Forms.PictureBox();
            this.pbxPause = new System.Windows.Forms.PictureBox();
            this.pbxNext = new System.Windows.Forms.PictureBox();
            this.pbxPrevious = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPlay
            // 
            this.pbxPlay.Image = ((System.Drawing.Image)(resources.GetObject("pbxPlay.Image")));
            this.pbxPlay.Location = new System.Drawing.Point(332, 478);
            this.pbxPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxPlay.Name = "pbxPlay";
            this.pbxPlay.Size = new System.Drawing.Size(133, 62);
            this.pbxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlay.TabIndex = 0;
            this.pbxPlay.TabStop = false;
            this.pbxPlay.Click += new System.EventHandler(this.pbxPlay_Click);
            // 
            // pbxPause
            // 
            this.pbxPause.Image = ((System.Drawing.Image)(resources.GetObject("pbxPause.Image")));
            this.pbxPause.Location = new System.Drawing.Point(473, 478);
            this.pbxPause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxPause.Name = "pbxPause";
            this.pbxPause.Size = new System.Drawing.Size(133, 62);
            this.pbxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPause.TabIndex = 1;
            this.pbxPause.TabStop = false;
            this.pbxPause.Click += new System.EventHandler(this.pbxPause_Click);
            // 
            // pbxNext
            // 
            this.pbxNext.Image = ((System.Drawing.Image)(resources.GetObject("pbxNext.Image")));
            this.pbxNext.Location = new System.Drawing.Point(615, 478);
            this.pbxNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxNext.Name = "pbxNext";
            this.pbxNext.Size = new System.Drawing.Size(133, 62);
            this.pbxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNext.TabIndex = 2;
            this.pbxNext.TabStop = false;
            this.pbxNext.Click += new System.EventHandler(this.pbxNext_Click);
            // 
            // pbxPrevious
            // 
            this.pbxPrevious.Image = ((System.Drawing.Image)(resources.GetObject("pbxPrevious.Image")));
            this.pbxPrevious.Location = new System.Drawing.Point(191, 478);
            this.pbxPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxPrevious.Name = "pbxPrevious";
            this.pbxPrevious.Size = new System.Drawing.Size(133, 62);
            this.pbxPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPrevious.TabIndex = 3;
            this.pbxPrevious.TabStop = false;
            this.pbxPrevious.Click += new System.EventHandler(this.pbxPrevious_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Todos|*.*";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(16, 478);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 16);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "label1";
            this.lbl1.Visible = false;
            // 
            // pbx4
            // 
            this.pbx4.Image = ((System.Drawing.Image)(resources.GetObject("pbx4.Image")));
            this.pbx4.Location = new System.Drawing.Point(83, 477);
            this.pbx4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(100, 53);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx4.TabIndex = 6;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.pbx4_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(108, 534);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 16);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Cargar";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(843, 64);
            this.lstLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(159, 116);
            this.lstLista.TabIndex = 8;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(822, 21);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(198, 20);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Lista de Reproduccion";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(867, 212);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(100, 28);
            this.btnAñadir.TabIndex = 10;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(769, 436);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pbxPrevious);
            this.Controls.Add(this.pbxNext);
            this.Controls.Add(this.pbxPause);
            this.Controls.Add(this.pbxPlay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPlay;
        private System.Windows.Forms.PictureBox pbxPause;
        private System.Windows.Forms.PictureBox pbxNext;
        private System.Windows.Forms.PictureBox pbxPrevious;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnAñadir;
    }
}

