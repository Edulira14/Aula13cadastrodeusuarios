namespace Aula13cadastrodeusuarios
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
        }
        
        public void atualizaInterface()
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                listView1.Items.Add(pessoas[i].nome);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            int idade = int.Parse (txtidade.Text);
            string rua = txtrua.Text;
            string cidade = txtcidade.Text;

            Pessoa pessoa = new Pessoa(nome, idade, rua, cidade);
            pessoas.Add(pessoa);
            atualizaInterface();
        }
    }
}