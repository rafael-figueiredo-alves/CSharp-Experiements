using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTextos
{
	public partial class frmDoc : Form
	{
		public bool Modificado { get; set; } = false;
		public frmDoc()
		{
			InitializeComponent();
		}

		private void timerControles_Tick(object sender, EventArgs e)
		{
			Modificado = true;
		}
	}
}
