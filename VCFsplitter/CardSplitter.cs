using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text;


namespace VCFsplitter
{
	public class CardSplitter
	{
		public CardSplitter() {}
	
		public void Split(String vcfFile, String outFolder)
		{
			try
			{
				string[] srcLines = File.ReadAllLines(vcfFile);
				//Debug.WriteLine("srcLines="+srcLines.Length);
	
				StringBuilder strb = new StringBuilder();
				string fname="";				
				
				//foreach (string srcLine in srcLines)
				for (int r=0; r<srcLines.Length; r++)
		        {
					string srcLine = srcLines[r];
					
					strb.AppendLine(srcLine);
					
					//if there is at least one non-ascii char present then all chars are encoded
					if ((srcLine.Length>43) && (srcLine.Substring(0, 43).Equals("FN;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:")))
					{
						fname=srcLine.Substring(43);
						
						//encoded content can be split across multiple lines:
						//  FN;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=4A=6F=62=5F=4D=69=72=6A=61=6E=61=20=4B=72=61=6C=6A=20=4B=6F=70=69=C4=
						//  =87
						int m=1;
						while (srcLines[r+m].Substring(0,1).Equals("=") && (m < 7))  //check next 6 lines, should be sufficient (at least it should break on END:VCARD
						{
							fname += srcLines[r+m].Substring(1); //previous line already ends with '='
							m++;
						}
	
						//decode
						byte[] bytes = new byte[fname.Length/3];
						for (int i=0; i<bytes.Length; i++)
						{
							int iHex = Convert.ToInt32(fname.Substring(i*3+1,2), 16);
							bytes[i] = Convert.ToByte(iHex);
						}
						fname = Encoding.UTF8.GetString(bytes);
					}
					else if ((srcLine.Length>3) && (srcLine.Substring(0, 3).Equals("FN:")))
					{
						fname=srcLine.Substring(3);
					}
					
					//split on closing tag
					if (srcLine.Equals("END:VCARD"))
					{
						//remove invalid filesystem path chars
						fname=fname.Replace("\\",null);
						fname=fname.Replace("/", null);
						fname=fname.Replace(":", null);
						fname=fname.Replace("*", null);
						fname=fname.Replace("?", null);
						fname=fname.Replace("\"",null);
						fname=fname.Replace("<", null);
						fname=fname.Replace(">", null);
						fname=fname.Replace("|", null);
						
						//never overwrite
						if (File.Exists(outFolder + "\\" + fname + ".vcf"))
						{
							Int32 filecounter = 1;
							while (File.Exists(outFolder + "\\" + fname + filecounter + ".vcf")) filecounter++;
							File.WriteAllText(outFolder + "\\" + fname + filecounter + ".vcf", strb.ToString());
						}
						else
						{
							File.WriteAllText(outFolder + "\\" + fname + ".vcf", strb.ToString());
						}
						
						//start new card
						strb.Clear();
						fname="";
					}
		        }
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);  
			}
		}
	}
}
