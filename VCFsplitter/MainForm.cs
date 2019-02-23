using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

	
namespace VCFsplitter
{
	public partial class MainForm : Form
	{
		private const string APPREGKEY = @"SOFTWARE\T800 Productions\{29376202-D747-41cf-83AE-1D7534F5C787}";
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// Add constructor code after the InitializeComponent() call.
			//
			
			//enable drag & drop
			this.AllowDrop = true;
			this.DragEnter += new DragEventHandler(MainForm_DragEnter);
			this.DragDrop += new DragEventHandler(MainForm_DragDrop);
			
			//load settings
			try
			{
				RegistryKey regkey = Registry.CurrentUser.OpenSubKey(APPREGKEY);  
				if (regkey != null)
				{
					folderBrowserDialog1.SelectedPath = regkey.GetValue("outputFolder").ToString();
					textBox2.Text = folderBrowserDialog1.SelectedPath;
				}
			}
			catch (Exception ex)
	        {
	            //MessageBox.Show("Error: " + ex.Message);
	        }

		}
		
		private void MainForm_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)  
		{  
		   if (e.Data.GetDataPresent(DataFormats.FileDrop))
		      e.Effect = DragDropEffects.Copy; 		   
		   else  
		      e.Effect = DragDropEffects.None;  
		}  
		
		private void MainForm_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try
			{
			string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			if (String.Equals(FileList[0].Substring(FileList[0].Length - 4), ".vcf", StringComparison.OrdinalIgnoreCase))
			{
				textBox1.Text = FileList[0];
			}
			}
			catch (Exception ex)
	        {  
	            MessageBox.Show("Error: " + ex.Message);
	        }
		}
		
		void Button1_Click(object sender, EventArgs e) { openFileDialog1.ShowDialog(); }
		
		void Button2_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox2.Text = folderBrowserDialog1.SelectedPath;
				//write registry settings
				try
				{
					RegistryKey regkey = Registry.CurrentUser.CreateSubKey(APPREGKEY);
					regkey.SetValue("outputFolder", textBox2.Text.ToString());
				}
				catch (Exception ex)
		        {  
		            //MessageBox.Show("Error: " + ex.Message);
		        }
			}
				
		}
		
		void ButtonSplit_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Length>0 && textBox2.Text.Length>0)
			{
				buttonSplit.Enabled = false;
				CardSplitter csp = new CardSplitter();
				csp.Split(textBox1.Text, textBox2.Text);
				buttonSplit.Enabled = true;
			}
		}
		
		void ButtonExit_Click(object sender, EventArgs e) { this.Close(); }	
		
		void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
	        try
	        {
				textBox1.Text=openFileDialog1.FileNames[0];
	        }
			catch (Exception ex)
			{
	            MessageBox.Show("Error: " + ex.Message);  
	        }
		}
		
		
	}
}
