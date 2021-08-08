using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using Xabe.FFmpeg;
using System.Text.RegularExpressions;
using MediaToolkit;
using MediaToolkit.Model;

namespace Sample_DownloadMusic
{
    public partial class F_Principal : Form
    {
        private YouTube youtube = YouTube.Default;
        private FolderBrowserDialog folder = new FolderBrowserDialog();
        private string nome1 = "";
        private string nome = "";
        private string output = "";

        public F_Principal()
        {
            InitializeComponent();
        }


        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                folder.ShowNewFolderButton = true;
                folder.ShowDialog();
                tb_salvar.Text = folder.SelectedPath + "/";
                output = folder.SelectedPath + "/";
            }
            catch
            {
                output = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                tb_salvar.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }
        }

        private void btn_Baixar_Click(object sender, EventArgs e)
        {
            btn_Baixar.Enabled = false;
            btn_Salvar.Enabled = false;
            tb_Baixar.ReadOnly = true;
            if (!String.IsNullOrWhiteSpace(tb_Baixar.Text))
            {

                if (!bgWorker.IsBusy)
                {
                    lb_status.Text = "Baixando...";
                    bgWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Espere ate a mensagem dizer terminado!");
                }
            }
            else
                MessageBox.Show("Coloque um Link Valido!");
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var video = youtube.GetVideo(tb_Baixar.Text);
                File.WriteAllBytes(output + video.FullName, video.GetBytes());
                nome1 = video.FullName;

            }
            catch(Exception error)
            {
                MessageBox.Show("Não foi possivel Baixar esse video! | " + error.Message);
            }

        }
            

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lb_status.Text = "Baixado!";
            if (!bgWorkerConvert.IsBusy)
            {
                lb_status.Text = "Convertendo...";
                Regex re = new Regex(@"\..{3}");
                nome = Regex.Replace(nome1, re.ToString(), ".mp3");
                bgWorkerConvert.RunWorkerAsync();
            }
            else
            {
                bgWorkerConvert.CancelAsync();
                bgWorkerConvert.RunWorkerAsync();
            }
            
        }

        private void bgWorkerConvert_DoWork(object sender, DoWorkEventArgs e)
        {
            var inputFile = new MediaFile { Filename = output + nome1 };
            var outputFile = new MediaFile { Filename = output + nome };
            using (var engine = new Engine())
            {
                engine.Convert(inputFile, outputFile);
            }
        }

        private void bgWorkerConvert_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                File.Delete(output + nome1);
                btn_Baixar.Enabled = true;
                btn_Salvar.Enabled = true;
                tb_Baixar.ReadOnly = false;
                lb_status.Text = "Terminou";
                MessageBox.Show("Terminou de Baixar a sua musica!");


            }
            catch
            {
                btn_Baixar.Enabled = true;
                btn_Salvar.Enabled = true;
                tb_Baixar.ReadOnly = false;
                lb_status.Text = "Terminou";
                MessageBox.Show("Terminou de Baixar a sua musica!");
            }
        }

    }
}
