using NAudio.Lame;
using NAudio.Wave;


namespace conversor
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        public Form1()
        {
            InitializeComponent();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                panelaudio.Height -= 10;
                paineldevideos.Visible = true;
                if (panelaudio.Height == panelaudio.MinimumSize.Height)
                {

                    sidebarExpand = false;
                    timerMenu.Stop();
                    label4.Text = "APRESENTAÇÃO";
                }
                else
                {
                    paineldevideos.Height += 10;
                    if (paineldevideos.Height == paineldevideos.MaximumSize.Height)
                    {
                        sidebarExpand = true;


                    }
                }



            }
            else
            {
                panelaudio.Height += 10;
                if (panelaudio.Height == panelaudio.MaximumSize.Height)
                {

                    sidebarExpand = true;
                    timerMenu.Stop();
                    paineldevideos.Visible = false;
                    label4.Text = "CONVERSÃO DE AUDIO";

                }
                else
                {
                    paineldevideos.Height -= 10;
                    if (paineldevideos.Height == paineldevideos.MinimumSize.Height)
                    {
                        sidebarExpand = true;

                    }
                }

            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void txt_pastadest_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_pasta_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_past_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Selecione os arquivos de áudio";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] arquivos = openFileDialog1.FileNames;

                // Cria a pasta de destino para os arquivos MP3
                string destino = txt_pastadest.Text;
                Directory.CreateDirectory(destino);

                // Converte cada arquivo de áudio para MP3 e salva na pasta de destino
                foreach (string arquivo in arquivos)
                {

                    progressBar1.Value++;
                    progressBar1.Maximum = arquivos.Length;

                    // Abre o arquivo de áudio
                    using (var reader = new AudioFileReader(arquivo))
                    {

                        // Cria o arquivo MP3
                        string mp3Path = Path.Combine(destino, Path.GetFileNameWithoutExtension(arquivo) + ".mp3");
                        using (var writer = new LameMP3FileWriter(mp3Path, reader.WaveFormat, LAMEPreset.VBR_90))
                        {
                            string title = Path.GetFileNameWithoutExtension(arquivo);
                            listBox1.Items.Add("Concluido: " + title);
                            reader.CopyTo(writer);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_pastadest.Text = dialog.SelectedPath;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}