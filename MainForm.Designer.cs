/*
 * Created by SharpDevelop.
 * User: 0181286
 * Date: 19/10/2020
 * Time: 13:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Teste_Servidor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.movimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.controleToolStripMenuItem,
									this.arquivosToolStripMenuItem,
									this.movimentosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// controleToolStripMenuItem
			// 
			this.controleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.empresasToolStripMenuItem,
									this.parametrosToolStripMenuItem});
			this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
			this.controleToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.controleToolStripMenuItem.Text = "Controle";
			// 
			// arquivosToolStripMenuItem
			// 
			this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.clientesToolStripMenuItem,
									this.fornecedoresToolStripMenuItem});
			this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
			this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.arquivosToolStripMenuItem.Text = "Arquivos";
			// 
			// movimentosToolStripMenuItem
			// 
			this.movimentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.saídasToolStripMenuItem});
			this.movimentosToolStripMenuItem.Name = "movimentosToolStripMenuItem";
			this.movimentosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
			this.movimentosToolStripMenuItem.Text = "Movimentos";
			// 
			// empresasToolStripMenuItem
			// 
			this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
			this.empresasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.empresasToolStripMenuItem.Text = "empresas";
			// 
			// parametrosToolStripMenuItem
			// 
			this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
			this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.parametrosToolStripMenuItem.Text = "Parametros";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			// 
			// fornecedoresToolStripMenuItem
			// 
			this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
			this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
			// 
			// saídasToolStripMenuItem
			// 
			this.saídasToolStripMenuItem.Name = "saídasToolStripMenuItem";
			this.saídasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.saídasToolStripMenuItem.Text = "Saídas";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Teste Servidor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem movimentosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
