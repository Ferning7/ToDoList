using ListaDeTarefas.UserControls;

namespace ListaDeTarefas
{
    public partial class Conteudo : Form
    {
        public Conteudo()
        {
            InitializeComponent();
        }

        bool mouseDown;
        Point lastLocation;

        private void adicionarUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {
            UC_Login telaLogin = new UC_Login();
            adicionarUserControl(telaLogin);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void navBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y
                );

            }
        }

        private void navBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void navBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Conteudo_Load(object sender, EventArgs e)
        {
            UC_Login log = new UC_Login();
            UC_Home home = new UC_Home();
            adicionarUserControl(log);
        }
    }
}
