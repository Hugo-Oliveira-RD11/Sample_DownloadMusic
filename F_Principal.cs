using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace Sample_DownloadMusic
{
    public partial class F_Principal : Form
    {
        private YouTube youTube = YouTube.Default;
        private string output ="";
        private string name1 = "";
        private string name2 = "";
        private List<string> WillDownLoad = new List<string>();
        private List<string> Download = new List<string>();
        public F_Principal()
        {
            InitializeComponent();
            cb_willDownloadMusic.Checked = true;
        }

        private void btn_WhereSave_Click(object sender, EventArgs e)
        {
            WhereSave();
        }

        private void btn_WhereASave2_Click(object sender, EventArgs e)
        {
            WhereSave();
        }
        private void btn_WhatALink_Click(object sender, EventArgs e)
        {
            btn_WhatALink.Enabled = false;
            btn_WhereSave.Enabled = false;
            btn_WhereASave2.Enabled = false;
            tb_WhatALink.ReadOnly = true;
            tabControl1.Enabled = false;

            if (!String.IsNullOrWhiteSpace(tb_WhatALink.Text))
            {
                if (!bgWorker_Baixar.IsBusy)
                {
                    lb_Status.Text = "Baixando....";
                    bgWorker_Baixar.RunWorkerAsync();
                }
                else
                {
                    bgWorker_Baixar.CancelAsync();
                    bgWorker_Baixar.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Coloque um Link veridico!!!");
            }
        }
        private void WhereSave()
        {
            FolderBrowserDialog folder = new FolderBrowserDialog()
            {
                ShowNewFolderButton = true,
                Description = "Voce tem que Escolher onde vai salvar as musicas!"
            };
            try
            {
                folder.ShowDialog();
                tb_WhereSave.Text = folder.SelectedPath;
                tb_WhereASave2.Text = folder.SelectedPath;
                output = folder.SelectedPath;
            }
            catch
            {
                output = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                tb_WhereSave.Text = output;
                tb_WhereASave2.Text = output;

            }
        }

        private void btn_AddToList_Click(object sender, EventArgs e)
        {
            WillDownLoad.Add(tb_WhatALink2.Text);
            UpdataListBox(Ltb_WhatWillASave, WillDownLoad);
        }

        private void UpdataListBox(ListBox listbox, List<string> List)
        {
            listbox.DataSource = null;
            listbox.DataSource = List;
        }

        private void bgWorker_Baixar_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var video = youTube.GetVideo(tb_WhatALink.Text);
                File.WriteAllBytes(output, video.GetBytes());
                name1 = video.FullName;
            }
            catch(Exception error)
            {
                MessageBox.Show("não conseguimos baixar esse video" +
                    error);

            }
        }

        private void bgWorker_Baixar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (cb_willDownloadMusic.Checked)
            {
                lb_Status.Text = "Convertendo...";
                Regex re = new Regex(@"\..{1,9}");
                name2 = Regex.Replace(name1, re.ToString(), ".mp3");
                bgWorker_Converter.RunWorkerAsync();
            }
            else if(!cb_willDownloadMusic.Checked)
            {
                lb_Status.Text = "Ja terminou!!";
                MessageBox.Show("Terminou de baixar o seu video !!");
            }

        }

        private void bgWorker_Converter_DoWork(object sender, DoWorkEventArgs e)
        {
            var inputFile = new MediaFile { Filename = output + name1 };
            var outputFile = new MediaFile { Filename = output + name2 };
            using (var engine = new Engine())
            {
                engine.Convert(inputFile, outputFile);
            }

        }

        private void bgWorker_Converter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                File.Delete(output + name1);
                btn_WhatALink.Enabled = true;
                btn_WhereSave.Enabled = true;
                btn_WhereASave2.Enabled = true;
                tb_WhatALink.ReadOnly = false;
                tabControl1.Enabled = true;
                Ltb_WhatAMusic.Items.Add(name1 + " - " + DateTime.Now.ToString("HH:mm ddd/MM"));
                lb_Status.Text = "Terminou!";
                MessageBox.Show("terminou de baixar e converter a sua musica!!");
            }catch
            {
                btn_WhatALink.Enabled = true;
                btn_WhereSave.Enabled = true;
                btn_WhereASave2.Enabled = true;
                tb_WhatALink.ReadOnly = false;
                tabControl1.Enabled = true;
                MessageBox.Show("A musica foi baixada, mas não conseguimos deletar o video, então eu pesso ao senhor para deletar a o video que o nome dele é " + name1);
                lb_Status.Text = "Baixou, mas não conseguimos deletar, peço que delete esse video que foi baixado!!";
                 
            }
        }

        private void bgWorker_baixarLista_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgWorker_baixarLista_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btn_Baixar_Click(object sender, EventArgs e)
        {

        }
    }
}
