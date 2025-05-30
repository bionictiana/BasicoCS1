public partial class FormDocumento : Form
{
    public FormDocumento()
    {
        InitializeComponent();
        this.Text = "Novo Documento";
        this.WindowState = FormWindowState.Maximized;
        
        // Componentes do formulário
        RichTextBox rtbDocumento = new RichTextBox();
        rtbDocumento.Dock = DockStyle.Fill;
        this.Controls.Add(rtbDocumento);
    }
}