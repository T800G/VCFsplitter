/*
 * Created by SharpDevelop.
 * User: T800
 * Date: 23.2.2019.
 * Time: 11:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VCFsplitter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttonSource = new System.Windows.Forms.Button();
			this.buttonOutput = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSplit = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonSource
			// 
			this.buttonSource.Location = new System.Drawing.Point(399, 30);
			this.buttonSource.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonSource.Name = "buttonSource";
			this.buttonSource.Size = new System.Drawing.Size(72, 26);
			this.buttonSource.TabIndex = 1;
			this.buttonSource.Text = "Browse...";
			this.buttonSource.UseVisualStyleBackColor = true;
			this.buttonSource.Click += new System.EventHandler(this.Button1_Click);
			// 
			// buttonOutput
			// 
			this.buttonOutput.Location = new System.Drawing.Point(399, 91);
			this.buttonOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonOutput.Name = "buttonOutput";
			this.buttonOutput.Size = new System.Drawing.Size(72, 26);
			this.buttonOutput.TabIndex = 3;
			this.buttonOutput.Text = "Browse...";
			this.buttonOutput.UseVisualStyleBackColor = true;
			this.buttonOutput.Click += new System.EventHandler(this.Button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(18, 32);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(358, 22);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(18, 92);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(358, 22);
			this.textBox2.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(18, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(271, 19);
			this.label1.TabIndex = 7;
			this.label1.Text = "Input file";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(18, 70);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(271, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Output folder";
			// 
			// buttonSplit
			// 
			this.buttonSplit.Location = new System.Drawing.Point(399, 147);
			this.buttonSplit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonSplit.Name = "buttonSplit";
			this.buttonSplit.Size = new System.Drawing.Size(72, 26);
			this.buttonSplit.TabIndex = 4;
			this.buttonSplit.Text = "Split";
			this.buttonSplit.UseVisualStyleBackColor = true;
			this.buttonSplit.Click += new System.EventHandler(this.ButtonSplit_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(303, 147);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(72, 26);
			this.buttonExit.TabIndex = 5;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "vcf";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "vCard Files (*.vcf)|*.vcf";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
			// 
			// folderBrowserDialog1
			// 
			this.folderBrowserDialog1.ShowNewFolderButton = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 162);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 19);
			this.label3.TabIndex = 8;
			this.label3.Text = "©T800 Productions";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(303, 56);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 19);
			this.label4.TabIndex = 9;
			this.label4.Text = "(or drag and drop file)";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(492, 189);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSplit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonOutput);
			this.Controls.Add(this.buttonSource);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VCFsplitter";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonSplit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonOutput;
		private System.Windows.Forms.Button buttonSource;
	}
}
