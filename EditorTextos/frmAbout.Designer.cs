namespace EditorTextos
{
	partial class FrmAbout
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			imageLogo = new PictureBox();
			lblTitulo = new Label();
			lblVersion = new Label();
			lblCopyright = new Label();
			btnFechar = new Button();
			((System.ComponentModel.ISupportInitialize)imageLogo).BeginInit();
			SuspendLayout();
			// 
			// imageLogo
			// 
			imageLogo.Image = Properties.Resources.icons8_typewriter_with_tablet_100;
			imageLogo.Location = new Point(12, 12);
			imageLogo.Name = "imageLogo";
			imageLogo.Size = new Size(100, 100);
			imageLogo.TabIndex = 0;
			imageLogo.TabStop = false;
			// 
			// lblTitulo
			// 
			lblTitulo.AutoSize = true;
			lblTitulo.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
			lblTitulo.Location = new Point(118, 12);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(354, 37);
			lblTitulo.TabIndex = 1;
			lblTitulo.Text = "Editor de Texto em C#";
			// 
			// lblVersion
			// 
			lblVersion.AutoSize = true;
			lblVersion.Location = new Point(125, 43);
			lblVersion.Name = "lblVersion";
			lblVersion.Size = new Size(59, 15);
			lblVersion.TabIndex = 2;
			lblVersion.Text = "versão 1.0";
			// 
			// lblCopyright
			// 
			lblCopyright.AutoSize = true;
			lblCopyright.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
			lblCopyright.Location = new Point(123, 66);
			lblCopyright.Name = "lblCopyright";
			lblCopyright.Size = new Size(214, 16);
			lblCopyright.TabIndex = 3;
			lblCopyright.Text = "©2023 - Produzido por DevPegasus";
			// 
			// btnFechar
			// 
			btnFechar.Location = new Point(387, 89);
			btnFechar.Name = "btnFechar";
			btnFechar.Size = new Size(75, 23);
			btnFechar.TabIndex = 4;
			btnFechar.Text = "&Fechar";
			btnFechar.UseVisualStyleBackColor = true;
			btnFechar.Click += btnFechar_Click;
			// 
			// FrmAbout
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(474, 118);
			ControlBox = false;
			Controls.Add(btnFechar);
			Controls.Add(lblCopyright);
			Controls.Add(lblVersion);
			Controls.Add(lblTitulo);
			Controls.Add(imageLogo);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Name = "FrmAbout";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Sobre o EditorTexto";
			((System.ComponentModel.ISupportInitialize)imageLogo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox imageLogo;
		private Label lblTitulo;
		private Label lblVersion;
		private Label lblCopyright;
		private Button btnFechar;
	}
}