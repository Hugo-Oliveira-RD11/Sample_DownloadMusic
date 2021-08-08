
namespace Sample_DownloadMusic
{
    partial class F_Principal
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
            this.lb_baixar = new System.Windows.Forms.Label();
            this.btn_Baixar = new System.Windows.Forms.Button();
            this.tb_Baixar = new System.Windows.Forms.TextBox();
            this.lb_salvar = new System.Windows.Forms.Label();
            this.tb_salvar = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.bgWorkerConvert = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lb_baixar
            // 
            this.lb_baixar.AutoSize = true;
            this.lb_baixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_baixar.Location = new System.Drawing.Point(12, 108);
            this.lb_baixar.Name = "lb_baixar";
            this.lb_baixar.Size = new System.Drawing.Size(130, 16);
            this.lb_baixar.TabIndex = 0;
            this.lb_baixar.Text = "Coloquer o link Aqui!";
            // 
            // btn_Baixar
            // 
            this.btn_Baixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baixar.Location = new System.Drawing.Point(616, 105);
            this.btn_Baixar.Name = "btn_Baixar";
            this.btn_Baixar.Size = new System.Drawing.Size(115, 25);
            this.btn_Baixar.TabIndex = 1;
            this.btn_Baixar.Text = "Baixar";
            this.btn_Baixar.UseVisualStyleBackColor = true;
            this.btn_Baixar.Click += new System.EventHandler(this.btn_Baixar_Click);
            // 
            // tb_Baixar
            // 
            this.tb_Baixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Baixar.Location = new System.Drawing.Point(158, 105);
            this.tb_Baixar.Name = "tb_Baixar";
            this.tb_Baixar.Size = new System.Drawing.Size(439, 22);
            this.tb_Baixar.TabIndex = 2;
            // 
            // lb_salvar
            // 
            this.lb_salvar.AutoSize = true;
            this.lb_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salvar.Location = new System.Drawing.Point(15, 13);
            this.lb_salvar.Name = "lb_salvar";
            this.lb_salvar.Size = new System.Drawing.Size(159, 16);
            this.lb_salvar.TabIndex = 3;
            this.lb_salvar.Text = "Onde vai salvar a musica";
            // 
            // tb_salvar
            // 
            this.tb_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salvar.Location = new System.Drawing.Point(194, 8);
            this.tb_salvar.Name = "tb_salvar";
            this.tb_salvar.ReadOnly = true;
            this.tb_salvar.Size = new System.Drawing.Size(347, 22);
            this.tb_salvar.TabIndex = 4;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(616, 12);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(115, 27);
            this.btn_Salvar.TabIndex = 5;
            this.btn_Salvar.Text = "salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(12, 179);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(0, 16);
            this.lb_status.TabIndex = 8;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // bgWorkerConvert
            // 
            this.bgWorkerConvert.WorkerReportsProgress = true;
            this.bgWorkerConvert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerConvert_DoWork);
            this.bgWorkerConvert.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerConvert_RunWorkerCompleted);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 298);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.tb_salvar);
            this.Controls.Add(this.lb_salvar);
            this.Controls.Add(this.tb_Baixar);
            this.Controls.Add(this.btn_Baixar);
            this.Controls.Add(this.lb_baixar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Principal";
            this.Text = "Baixador de Musicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_baixar;
        private System.Windows.Forms.Button btn_Baixar;
        private System.Windows.Forms.TextBox tb_Baixar;
        private System.Windows.Forms.Label lb_salvar;
        private System.Windows.Forms.TextBox tb_salvar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Label lb_status;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.ComponentModel.BackgroundWorker bgWorkerConvert;
    }
}

