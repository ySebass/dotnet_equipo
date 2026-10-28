/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 27/10/2026
 * Time: 08:28 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyectoPrueba
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
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.registrarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 105);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(218, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "BIENVENIDO!!!!";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.registrarteToolStripMenuItem,
									this.iniciarSesionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(284, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// registrarteToolStripMenuItem
			// 
			this.registrarteToolStripMenuItem.Name = "registrarteToolStripMenuItem";
			this.registrarteToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.registrarteToolStripMenuItem.Text = "Registrarte";
			this.registrarteToolStripMenuItem.Click += new System.EventHandler(this.RegistrarteToolStripMenuItemClick);
			// 
			// iniciarSesionToolStripMenuItem
			// 
			this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
			this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.iniciarSesionToolStripMenuItem.Text = "Iniciar sesion";
			this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.IniciarSesionToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Programa";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarteToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label1;
	}
}
