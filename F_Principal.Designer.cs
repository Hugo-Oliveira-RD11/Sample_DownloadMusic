
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tp_NoQueue = new System.Windows.Forms.TabPage();
            this.cb_willDownloadMusic = new System.Windows.Forms.CheckBox();
            this.lb_Status = new System.Windows.Forms.Label();
            this.Ltb_WhatAMusic = new System.Windows.Forms.ListBox();
            this.btn_WhatALink = new System.Windows.Forms.Button();
            this.tb_WhatALink = new System.Windows.Forms.TextBox();
            this.btn_WhereSave = new System.Windows.Forms.Button();
            this.tb_WhereSave = new System.Windows.Forms.TextBox();
            this.bgWorker_Baixar = new System.ComponentModel.BackgroundWorker();
            this.bgWorker_Converter = new System.ComponentModel.BackgroundWorker();
            this.bgWorker_Converter_Video = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Tp_NoQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tp_NoQueue);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // Tp_NoQueue
            // 
            this.Tp_NoQueue.Controls.Add(this.cb_willDownloadMusic);
            this.Tp_NoQueue.Controls.Add(this.lb_Status);
            this.Tp_NoQueue.Controls.Add(this.Ltb_WhatAMusic);
            this.Tp_NoQueue.Controls.Add(this.btn_WhatALink);
            this.Tp_NoQueue.Controls.Add(this.tb_WhatALink);
            this.Tp_NoQueue.Controls.Add(this.btn_WhereSave);
            this.Tp_NoQueue.Controls.Add(this.tb_WhereSave);
            this.Tp_NoQueue.Location = new System.Drawing.Point(4, 22);
            this.Tp_NoQueue.Name = "Tp_NoQueue";
            this.Tp_NoQueue.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_NoQueue.Size = new System.Drawing.Size(790, 426);
            this.Tp_NoQueue.TabIndex = 0;
            this.Tp_NoQueue.Text = "simples baixador";
            this.Tp_NoQueue.UseVisualStyleBackColor = true;
            // 
            // cb_willDownloadMusic
            // 
            this.cb_willDownloadMusic.AutoSize = true;
            this.cb_willDownloadMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_willDownloadMusic.Location = new System.Drawing.Point(626, 403);
            this.cb_willDownloadMusic.Name = "cb_willDownloadMusic";
            this.cb_willDownloadMusic.Size = new System.Drawing.Size(122, 21);
            this.cb_willDownloadMusic.TabIndex = 6;
            this.cb_willDownloadMusic.Text = "Baixar musica?";
            this.cb_willDownloadMusic.UseVisualStyleBackColor = true;
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Status.Location = new System.Drawing.Point(17, 372);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(0, 20);
            this.lb_Status.TabIndex = 5;
            // 
            // Ltb_WhatAMusic
            // 
            this.Ltb_WhatAMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltb_WhatAMusic.FormattingEnabled = true;
            this.Ltb_WhatAMusic.ItemHeight = 16;
            this.Ltb_WhatAMusic.Location = new System.Drawing.Point(5, 145);
            this.Ltb_WhatAMusic.Name = "Ltb_WhatAMusic";
            this.Ltb_WhatAMusic.ScrollAlwaysVisible = true;
            this.Ltb_WhatAMusic.Size = new System.Drawing.Size(780, 196);
            this.Ltb_WhatAMusic.TabIndex = 4;
            // 
            // btn_WhatALink
            // 
            this.btn_WhatALink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WhatALink.Location = new System.Drawing.Point(599, 104);
            this.btn_WhatALink.Name = "btn_WhatALink";
            this.btn_WhatALink.Size = new System.Drawing.Size(77, 26);
            this.btn_WhatALink.TabIndex = 3;
            this.btn_WhatALink.Text = "Baixar";
            this.btn_WhatALink.UseVisualStyleBackColor = true;
            this.btn_WhatALink.Click += new System.EventHandler(this.btn_WhatALink_Click);
            // 
            // tb_WhatALink
            // 
            this.tb_WhatALink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WhatALink.Location = new System.Drawing.Point(6, 104);
            this.tb_WhatALink.Name = "tb_WhatALink";
            this.tb_WhatALink.Size = new System.Drawing.Size(570, 26);
            this.tb_WhatALink.TabIndex = 2;
            // 
            // btn_WhereSave
            // 
            this.btn_WhereSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WhereSave.Location = new System.Drawing.Point(599, 42);
            this.btn_WhereSave.Name = "btn_WhereSave";
            this.btn_WhereSave.Size = new System.Drawing.Size(149, 26);
            this.btn_WhereSave.TabIndex = 1;
            this.btn_WhereSave.Text = "Onde vai Salvar";
            this.btn_WhereSave.UseVisualStyleBackColor = true;
            this.btn_WhereSave.Click += new System.EventHandler(this.btn_WhereSave_Click);
            // 
            // tb_WhereSave
            // 
            this.tb_WhereSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_WhereSave.Location = new System.Drawing.Point(6, 42);
            this.tb_WhereSave.Name = "tb_WhereSave";
            this.tb_WhereSave.ReadOnly = true;
            this.tb_WhereSave.Size = new System.Drawing.Size(570, 26);
            this.tb_WhereSave.TabIndex = 0;
            // 
            // bgWorker_Baixar
            // 
            this.bgWorker_Baixar.WorkerReportsProgress = true;
            this.bgWorker_Baixar.WorkerSupportsCancellation = true;
            this.bgWorker_Baixar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_Baixar_DoWork);
            this.bgWorker_Baixar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_Baixar_RunWorkerCompleted);
            // 
            // bgWorker_Converter
            // 
            this.bgWorker_Converter.WorkerReportsProgress = true;
            this.bgWorker_Converter.WorkerSupportsCancellation = true;
            this.bgWorker_Converter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_Converter_DoWork);
            this.bgWorker_Converter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_Converter_RunWorkerCompleted);
            // 
            // bgWorker_Converter_Video
            // 
            this.bgWorker_Converter_Video.WorkerReportsProgress = true;
            this.bgWorker_Converter_Video.WorkerSupportsCancellation = true;
            this.bgWorker_Converter_Video.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_Converter_Video_DoWork);
            this.bgWorker_Converter_Video.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_Converter_Video_RunWorkerCompleted);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 456);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.Text = "Baixador de Musica";
            this.tabControl1.ResumeLayout(false);
            this.Tp_NoQueue.ResumeLayout(false);
            this.Tp_NoQueue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tp_NoQueue;
        private System.Windows.Forms.Button btn_WhereSave;
        private System.Windows.Forms.TextBox tb_WhereSave;
        private System.Windows.Forms.ListBox Ltb_WhatAMusic;
        private System.Windows.Forms.Button btn_WhatALink;
        private System.Windows.Forms.TextBox tb_WhatALink;
        private System.Windows.Forms.Label lb_Status;
        private System.ComponentModel.BackgroundWorker bgWorker_Baixar;
        private System.Windows.Forms.CheckBox cb_willDownloadMusic;
        private System.ComponentModel.BackgroundWorker bgWorker_Converter;
        private System.ComponentModel.BackgroundWorker bgWorker_Converter_Video;
    }
}