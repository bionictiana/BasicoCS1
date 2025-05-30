public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
        this.IsMdiContainer = true;
        this.WindowState = FormWindowState.Maximized;
        
        // Menu principal
        MenuStrip menuPrincipal = new MenuStrip();
        ToolStripMenuItem menuArquivo = new ToolStripMenuItem("Arquivo");
        ToolStripMenuItem menuNovo = new ToolStripMenuItem("Novo Documento");
        ToolStripMenuItem menuAbrir = new ToolStripMenuItem("Abrir");
        ToolStripMenuItem menuSair = new ToolStripMenuItem("Sair");
        
        menuArquivo.DropDownItems.AddRange(new ToolStripItem[] { menuNovo, menuAbrir, menuSair });
        menuPrincipal.Items.Add(menuArquivo);
        
        // Eventos
        menuNovo.Click += MenuNovo_Click;
        menuSair.Click += MenuSair_Click;
        
        this.MainMenuStrip = menuPrincipal;
        this.Controls.Add(menuPrincipal);
    }

    private void MenuNovo_Click(object sender, EventArgs e)
    {
        FormDocumento novoDocumento = new FormDocumento();
        novoDocumento.MdiParent = this;
        novoDocumento.Show();
    }

    private void MenuSair_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}