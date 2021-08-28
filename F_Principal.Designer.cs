
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
            this.Tp_withQueue = new System.Windows.Forms.TabPage();
            this.lb_StatusMusic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddLink = new System.Windows.Forms.Button();
            this.btn_WhereASave2 = new System.Windows.Forms.Button();
            this.tb_WhatALink2 = new System.Windows.Forms.TextBox();
            this.tb_WhereASave2 = new System.Windows.Forms.TextBox();
            this.Ltb_WhatASave = new System.Windows.Forms.ListBox();
            this.Ltb_WhatWillASave = new System.Windows.Forms.ListBox();
            this.bgWorker_Baixar = new System.ComponentModel.BackgroundWorker();
            this.bgWorker_Converter = new System.ComponentModel.BackgroundWorker();
            this.btn_Baixar = new System.Windows.Forms.Button();
            this.bgWorker_baixarLista = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.Tp_NoQueue.SuspendLayout();
            this.Tp_withQueue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tp_NoQueue);
            this.tabControl1.Controls.Add(this.Tp_withQueue);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 448);
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
            this.Tp_NoQueue.Size = new System.Drawing.Size(788, 422);
            this.Tp_NoQueue.TabIndex = 0;
            this.Tp_NoQueue.Text = "simples baixador";
            this.Tp_NoQueue.UseVisualStyleBackColor = true;
            // 
            // cb_willDownloadMusic
            // 
            this.cb_willDownloadMusic.AutoSize = true;
            this.cb_willDownloadMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_willDownloadMusic.Location = new System.Drawing.Point(615, 384);
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
            this.lb_Status.Location = new System.Drawing.Point(7, 380);
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
            this.Ltb_WhatAMusic.Size = new System.Drawing.Size(776, 228);
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
            // Tp_withQueue
            // 
            this.Tp_withQueue.Controls.Add(this.btn_Baixar);
            this.Tp_withQueue.Controls.Add(this.lb_StatusMusic);
            this.Tp_withQueue.Controls.Add(this.label1);
            this.Tp_withQueue.Controls.Add(this.btn_AddLink);
            this.Tp_withQueue.Controls.Add(this.btn_WhereASave2);
            this.Tp_withQueue.Controls.Add(this.tb_WhatALink2);
            this.Tp_withQueue.Controls.Add(this.tb_WhereASave2);
            this.Tp_withQueue.Controls.Add(this.Ltb_WhatASave);
            this.Tp_withQueue.Controls.Add(this.Ltb_WhatWillASave);
            this.Tp_withQueue.Location = new System.Drawing.Point(4, 22);
            this.Tp_withQueue.Name = "Tp_withQueue";
            this.Tp_withQueue.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_withQueue.Size = new System.Drawing.Size(788, 422);
            this.Tp_withQueue.TabIndex = 1;
            this.Tp_withQueue.Text = "baixador com fila";
            this.Tp_withQueue.UseVisualStyleBackColor = true;
            // 
            // lb_StatusMusic
            // 
            this.lb_StatusMusic.AutoSize = true;
            this.lb_StatusMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StatusMusic.Location = new System.Drawing.Point(252, 370);
            this.lb_StatusMusic.Name = "lb_StatusMusic";
            this.lb_StatusMusic.Size = new System.Drawing.Size(236, 20);
            this.lb_StatusMusic.TabIndex = 7;
            this.lb_StatusMusic.Text = "Aqui vai em qual passo estamos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aqui vai o nome da musica";
            // 
            // btn_AddLink
            // 
            this.btn_AddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddLink.Location = new System.Drawing.Point(306, 214);
            this.btn_AddLink.Name = "btn_AddLink";
            this.btn_AddLink.Size = new System.Drawing.Size(167, 31);
            this.btn_AddLink.TabIndex = 5;
            this.btn_AddLink.Text = "Adicionar a Lista";
            this.btn_AddLink.UseVisualStyleBackColor = true;
            this.btn_AddLink.Click += new System.EventHandler(this.btn_AddToList_Click);
            // 
            // btn_WhereASave2
            // 
            this.btn_WhereASave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WhereASave2.Location = new System.Drawing.Point(306, 47);
            this.btn_WhereASave2.Name = "btn_WhereASave2";
            this.btn_WhereASave2.Size = new System.Drawing.Size(167, 30);
            this.btn_WhereASave2.TabIndex = 4;
            this.btn_WhereASave2.Text = "Onde vai Baixar";
            this.btn_WhereASave2.UseVisualStyleBackColor = true;
            this.btn_WhereASave2.Click += new System.EventHandler(this.btn_WhereASave2_Click);
            // 
            // tb_WhatALink2
            // 
            this.tb_WhatALink2.Location = new System.Drawing.Point(256, 188);
            this.tb_WhatALink2.Name = "tb_WhatALink2";
            this.tb_WhatALink2.Size = new System.Drawing.Size(274, 20);
            this.tb_WhatALink2.TabIndex = 3;
            // 
            // tb_WhereASave2
            // 
            this.tb_WhereASave2.Location = new System.Drawing.Point(256, 7);
            this.tb_WhereASave2.Name = "tb_WhereASave2";
            this.tb_WhereASave2.ReadOnly = true;
            this.tb_WhereASave2.Size = new System.Drawing.Size(274, 20);
            this.tb_WhereASave2.TabIndex = 2;
            // 
            // Ltb_WhatASave
            // 
            this.Ltb_WhatASave.FormattingEnabled = true;
            this.Ltb_WhatASave.Location = new System.Drawing.Point(548, 7);
            this.Ltb_WhatASave.Name = "Ltb_WhatASave";
            this.Ltb_WhatASave.Size = new System.Drawing.Size(234, 407);
            this.Ltb_WhatASave.TabIndex = 1;
            // 
            // Ltb_WhatWillASave
            // 
            this.Ltb_WhatWillASave.FormattingEnabled = true;
            this.Ltb_WhatWillASave.Location = new System.Drawing.Point(4, 7);
            this.Ltb_WhatWillASave.Name = "Ltb_WhatWillASave";
            this.Ltb_WhatWillASave.Size = new System.Drawing.Size(234, 407);
            this.Ltb_WhatWillASave.TabIndex = 0;
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
            // btn_Baixar
            // 
            this.btn_Baixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baixar.Location = new System.Drawing.Point(338, 266);
            this.btn_Baixar.Name = "btn_Baixar";
            this.btn_Baixar.Size = new System.Drawing.Size(88, 28);
            this.btn_Baixar.TabIndex = 8;
            this.btn_Baixar.Text = "Baixar";
            this.btn_Baixar.UseVisualStyleBackColor = true;
            this.btn_Baixar.Click += new System.EventHandler(this.btn_Baixar_Click);
            // 
            // bgWorker_baixarLista
            // 
            this.bgWorker_baixarLista.WorkerReportsProgress = true;
            this.bgWorker_baixarLista.WorkerSupportsCancellation = true;
            this.bgWorker_baixarLista.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_baixarLista_DoWork);
            this.bgWorker_baixarLista.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_baixarLista_RunWorkerCompleted);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.Text = "Baixador de Musica";
            this.tabControl1.ResumeLayout(false);
            this.Tp_NoQueue.ResumeLayout(false);
            this.Tp_NoQueue.PerformLayout();
            this.Tp_withQueue.ResumeLayout(false);
            this.Tp_withQueue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tp_NoQueue;
        private System.Windows.Forms.TabPage Tp_withQueue;
        private System.Windows.Forms.Button btn_WhereSave;
        private System.Windows.Forms.TextBox tb_WhereSave;
        private System.Windows.Forms.ListBox Ltb_WhatAMusic;
        private System.Windows.Forms.Button btn_WhatALink;
        private System.Windows.Forms.TextBox tb_WhatALink;
        private System.Windows.Forms.Button btn_AddLink;
        private System.Windows.Forms.Button btn_WhereASave2;
        private System.Windows.Forms.TextBox tb_WhatALink2;
        private System.Windows.Forms.TextBox tb_WhereASave2;
        private System.Windows.Forms.ListBox Ltb_WhatASave;
        private System.Windows.Forms.ListBox Ltb_WhatWillASave;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.Label lb_StatusMusic;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bgWorker_Baixar;
        private System.Windows.Forms.CheckBox cb_willDownloadMusic;
        private System.ComponentModel.BackgroundWorker bgWorker_Converter;
        private System.Windows.Forms.Button btn_Baixar;
        private System.ComponentModel.BackgroundWorker bgWorker_baixarLista;
    }
}