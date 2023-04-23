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

		private void menuSobre_Click(object sender, EventArgs e)
		{
			FrmAbout formAbout = new();
			_ = formAbout.ShowDialog();
		}

		private void EncerrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void novoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDoc Documento = new()
			{
				MdiParent = this,
				Text = "Sem Título " + Docs.ToString()
			};
			Documento.Show();
			Docs++;
		}

		private void timerControles_Tick(object sender, EventArgs e)
		{
			if (this?.ActiveMdiChild != null)
			{
				frmDoc? Docs = this.ActiveMdiChild as frmDoc;

				if (Docs != null)
				{
					BtnSalvar.Enabled = Docs.Modificado;
				}
				else
				{
					BtnSalvar.Enabled = false;
				}
			}
			else
			{
				BtnSalvar.Enabled = false;
			}

		}
	}
}