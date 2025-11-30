namespace SelecaoCoresComboBox
{
    public partial class Frm_TelaInicial : Form
    {
        public Frm_TelaInicial()
        {
            InitializeComponent();
            CarregarCoresComboBox();
            Cmb_Cores.SelectedIndex = -1;
        }

        private List<Color> Cores() {
        
            List<Color> colors = new List<Color>();

            colors.Add(Color.Red);
            colors.Add(Color.Green);
            colors.Add(Color.Blue);
            colors.Add(Color.Magenta);
            colors.Add(Color.Yellow);
            colors.Add(Color.Lime);
            colors.Add(Color.LimeGreen);
            colors.Add(Color.Orange);

            return colors;

        }

        private void CarregarCoresComboBox()
        {
            List<Color> cores = Cores();

            foreach(Color cor in cores)
            {
                Cmb_Cores.Items.Add(cor.Name);
            }
        }

        private void Btn_Aplicar_Click(object sender, EventArgs e)
        {
            if(Cmb_Cores.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma cor antes de aplicar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeCor = Cmb_Cores.SelectedItem.ToString();
            Color corSelecionada = Color.FromName(nomeCor);

            Lbl_CorEscolhida.Text = nomeCor;
            Pnl_Cor.BackColor = corSelecionada;
        }

        private void Btn_Resetar_Click(object sender, EventArgs e)
        {
            Cmb_Cores.SelectedIndex = -1;
            Lbl_CorEscolhida.Text = "";
            Pnl_Cor.BackColor = SystemColors.Control;
        }
    }
}
