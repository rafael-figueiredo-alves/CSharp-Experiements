using System.Runtime.CompilerServices;

namespace EditorTextos
{
	public partial class frmMain : Form
	{
		private int Docs = 1;
		public frmMain()
		{
			InitializeComponent();
		}

		private RichTextBox? DocWindow()
		{
			if (ActiveMdiChild is FrmDoc Docs)
			{
				return Docs.DocContent;
			}
			else
			{
				return null;
			}
		}

		private void CxPesquisa_Enter(object sender, EventArgs e)
		{
			if (cxPesquisa.Text == "Pesquisar...")
			{
				cxPesquisa.Clear();
			}
		}

		private void CxPesquisa_Leave(object sender, EventArgs e)
		{
			if (cxPesquisa.Text == string.Empty || cxPesquisa.Text == null)
			{
				cxPesquisa.Text = "Pesquisar...";
			}
		}

		private void MenuSobre_Click(object sender, EventArgs e)
		{
			FrmAbout formAbout = new();
			_ = formAbout.ShowDialog();
		}

		private void EncerrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmDoc Documento = new()
			{
				MdiParent = this,
				Text = "Sem Título " + Docs.ToString()
			};
			Documento.Show();
			Docs++;
		}

		private void TimerControles_Tick(object sender, EventArgs e)
		{
			if (DocWindow() != null)
			{
				BtnSalvar.Enabled = DocWindow()!.Modified;
				BtnImprimir.Enabled = true;
				BtnCopiar.Enabled = true;
				BtnCortar.Enabled = true;
				BtnColar.Enabled = true;
				BtnDesfazer.Enabled = DocWindow()!.CanUndo;
				BtnRefazer.Enabled = DocWindow()!.CanRedo;
			}
			else
			{
				BtnSalvar.Enabled = false;
				BtnImprimir.Enabled = false;
				BtnCopiar.Enabled = false;
				BtnCortar.Enabled = false;
				BtnColar.Enabled = false;
				BtnDesfazer.Enabled = false;
				BtnRefazer.Enabled = false;
			}
		}
	}
}