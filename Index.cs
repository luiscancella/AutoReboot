using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using System.Drawing.Text;
using System.Net.NetworkInformation;

namespace MonitorOMPH
{
    public partial class Index : Form
    {
        public List<string> selecteds { get; set; } = new List<string>();
        public List<string> selectedsNames { get; set; } = new List<string>();
        private Options winconf = new Options();

        public Index()
        {
            InitializeComponent();
            CenterToScreen();
            winconf.page = this;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            try
            {
                string config = "./../../config_example.json"; // Caminho do arquivo de configuração
                using (StreamReader read = new StreamReader(config))
                {
                    //Da parse no Json
                    string jsonpath = read.ReadToEnd();
                    dynamic result = serializer.DeserializeObject(jsonpath);
                    //Adicionar botões pelos resultados obtidos
                    int cont = 1;
                    foreach (KeyValuePair<string, object> item in result)
                    {
                        //Pega key, value do array
                        var name = item.Key;
                        var ip = item.Value as string;
                        //Cria o botão
                        Button btn = new Button()
                        {
                            Text = name,
                            Name = name,
                            Size = new Size(122, 70),
                            TabIndex = cont,
                            UseVisualStyleBackColor = false,
                            Enabled = false
                        };
                        if (pingable(ip)) btn.Enabled = true;
                        btn.Click += (Button, MouseEventArgs) => chooseBtn(btn, ip);
                        dflex.Controls.Add(btn);
                        //Adiciona 1 no contador
                        cont++;
                    }
                }
            } catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo de configuração não encontrado! Verifique a conexão");
            }
            
        }

        //Pinga o ip fornecido
        public bool pingable(string ip)
        {
            Ping device = new Ping();
            PingReply response = device.Send(ip);
            return response.Status.ToString().Equals("Success");
        }
        private bool chooseBtn(Button btn, string ip)
        {
            foreach (string item in selecteds)
            {
                if (item == ip)
                {
                    //Tira o botão da lista
                    btn.UseVisualStyleBackColor = false;
                    selecteds.Remove(item);
                    selectedsNames.Remove(btn.Name);
                    return false;
                }
            }
            //Adiciona o botão na lista
            selecteds.Add(ip);
            selectedsNames.Add(btn.Name);
            btn.UseVisualStyleBackColor = true;
            return true;
        }

        private void Index_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void options_Click(object sender, EventArgs e)
        {
            winconf.ShowDialog();
        }
    }
}
