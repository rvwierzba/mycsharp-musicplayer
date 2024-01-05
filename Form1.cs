using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;

namespace MyCsharpMusicPlayer
{
    public partial class MyCsharpMusicPlayer : Form
    {
        public MyCsharpMusicPlayer()
        {
            InitializeComponent();
            linkLabel.LinkVisited = false;
        }

        // Criando variaveis array do tipo String globais para salvar os nomes e os caminhos das m�sicas
        String[] paths, files;

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.rvwtech.com.br/sobre-rafael");

            }
            catch (Exception)
            {
                MessageBox.Show("N�o foi poss�vel acessar o site do desenvolvedor!");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // C�digo para a sele��o de m�sicas
            OpenFileDialog ofd = new();

            // Permitir m�ltiplas sele��es para iser��o de v�rias m�sicas ao mesmo tempo
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames; // Salva os nomes das faixas no arr files.
                paths = ofd.FileNames; // Salva os caminhos das faixas no arr paths.

                //Percorre os titulos das m�sicas Adicionadas
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); // Mostras as m�sicas adicionadas no ListBox
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // C�digo para reproduzir m�sica selecionada no ListBox
            LibVLC libVLC = new LibVLC(enableDebugLogs: false);
            var selectedMusic = paths[listBoxSongs.SelectedIndex];
            Media media = new Media(libVLC, new Uri(selectedMusic));
            vlcPlayer.MediaPlayer = new MediaPlayer(media);
            if(vlcPlayer.MediaPlayer != null) 
            vlcPlayer.MediaPlayer.Play();
           
        }
               
    }
}
