using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace MonitorOMPH
{
    public partial class Options : Form
    {
        public Index page { get; set; }
        public Options()
        {
            InitializeComponent();
        }

        public void LoadList()
        {
            lista.Items.Clear();
            lista.Items.Add("Monitores selecionados:");
            foreach (string monitor in page.selectedsNames) lista.Items.Add(monitor);
        }

        void reiniciar(string ip)
        {
            // Configuração de conexão
            int port = 22;
            string user = "root";
            string password = "password_example";

            // Faz a conexão SSH
            using (var client = new SshClient(ip, port, user, password))
            {
                //Conectar e reinciar o dispositivo
                try
                {
                    client.Connect();
                    client.RunCommand("reboot");
                }
                catch (SshConnectionException)
                {
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: "+ex.ToString());
                }
            }
        }

        private void request_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            LoadList();
        }

        private void reboot_Click(object sender, EventArgs e)
        {
            foreach (string ip in page.selecteds)
            {
                reiniciar(ip);
            }
            MessageBox.Show("Reiniciado com sucesso!");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
