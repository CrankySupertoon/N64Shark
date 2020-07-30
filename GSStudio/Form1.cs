using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using n64shark;

namespace GSStudio
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002BAA File Offset: 0x00000DAA
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002BD0 File Offset: 0x00000DD0
		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Game Shark Code";
			openFileDialog.Filter = "GS files|*.gs; *.gsc; *.txt; ";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				bool flag2 = false;
				this.loadObj = openFileDialog.FileName.ToString();
				string[] array = File.ReadAllLines(openFileDialog.FileName.ToString());
				int num = 0;
				bool flag3 = false;
				foreach (string text in array)
				{
					bool flag4 = num > 0;
					if (flag4)
					{
						MessageBox.Show("The current version only fully supports 1 line.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						bool flag5 = !flag2;
						if (flag5)
						{
							flag2 = true;
						}
						num = -1024;
					}
					char[] array3 = text.ToCharArray();
					bool flag6 = array3[0] == 'D';
					if (flag6)
					{
						bool flag7 = flag3;
						if (flag7)
						{
							MessageBox.Show("D commands are not fully supported currently.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							bool flag8 = !flag2;
							if (flag8)
							{
								flag2 = true;
							}
							flag3 = true;
						}
					}
					else
					{
						bool flag9 = array3[0] != '8';
						if (flag9)
						{
							MessageBox.Show("Parsing error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return;
						}
					}
					bool flag10 = array3[1] == '1' || array3[1] == '0';
					if (!flag10)
					{
						MessageBox.Show("Parsing error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
					bool flag11 = !this.listBox1.Enabled;
					if (flag11)
					{
						MessageBox.Show("Code parsed succesfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						this.listBox1.Items.Clear();
						this.listBox4.Items.Clear();
						this.listBox2.Items.Clear();
						this.listBox3.Items.Clear();
						this.listBox1.Enabled = true;
						this.listBox4.Enabled = true;
						this.listBox2.Enabled = true;
						this.listBox3.Enabled = true;
					}
					this.listBox1.Items.Add(new string(array3, 0, 2));
					this.listBox4.Items.Add(new string(array3, 2, 2));
					this.listBox2.Items.Add(new string(array3, 4, 4));
					this.listBox3.Items.Add(new string(array3, 9, 4));
					num++;
				}
				this.button1.Enabled = false;
				bool flag12 = !flag2;
				if (flag12)
				{
					this.button2.Enabled = true;
					this.button3.Enabled = true;
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002E85 File Offset: 0x00001085
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002E8D File Offset: 0x0000108D
		private string loadObj { get; set; }

		// Token: 0x06000019 RID: 25 RVA: 0x00002E96 File Offset: 0x00001096
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Feature not supported yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002EAC File Offset: 0x000010AC
		private void button3_Click(object sender, EventArgs e)
		{
			int num = 0;
			string text = ".org 0x861C0\r\nADDIU SP, SP, 0XFFE8\r\nSW RA, 0X14(SP)\r\n\r\n";
			foreach (object obj in this.listBox4.Items)
			{
				string str = obj.ToString();
				int num2 = int.Parse(this.listBox2.Items[num].ToString(), NumberStyles.HexNumber);
				bool flag = num2 > 32767;
				if (flag)
				{
					str = (int.Parse(obj.ToString(), NumberStyles.HexNumber) + 1).ToString("X");
				}
				text = text + "LUI T0, 0x80" + str + "\r\n";
				bool flag2 = int.Parse(this.listBox1.Items[num].ToString()) == 80;
				if (flag2)
				{
					string text2 = this.listBox3.Items[num].ToString();
					text2 = text2.Substring(2, text2.Length - 2);
					text = text + "ORI T1, T1, 0x" + text2 + "\r\n";
					text = string.Concat(new object[]
					{
						text,
						"SB T1, 0x",
						this.listBox2.Items[num],
						"(T0)\r\n\r\n"
					});
				}
				else
				{
					text = string.Concat(new object[]
					{
						text,
						"ORI T1, T1, 0x",
						this.listBox3.Items[num],
						"\r\n"
					});
					text = string.Concat(new object[]
					{
						text,
						"SH T1, 0x",
						this.listBox2.Items[num],
						"(T0)\r\n\r\n"
					});
				}
				num++;
			}
			text += "\r\nLW RA, 0x14(SP)\r\nJR RA\r\nADDIU SP, SP, 0x18";
			File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "/output.asm", text);
			Process.Start("notepad.exe", Path.GetDirectoryName(Application.ExecutablePath) + "/output.asm");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000030E0 File Offset: 0x000012E0
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.listBox1.SelectedIndex == -1;
			if (!flag)
			{
				bool flag2 = this.listBox1.SelectedIndex != this.selectedval;
				if (flag2)
				{
					this.selectedval = this.listBox1.SelectedIndex;
					this.listBox2.SetSelected(this.listBox1.SelectedIndex, true);
					this.listBox3.SetSelected(this.listBox1.SelectedIndex, true);
					this.listBox4.SetSelected(this.listBox1.SelectedIndex, true);
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003178 File Offset: 0x00001378
		private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.button4.Enabled = true;
			bool flag = this.listBox4.SelectedIndex == -1;
			if (!flag)
			{
				bool flag2 = this.listBox4.SelectedIndex != this.selectedval;
				if (flag2)
				{
					this.selectedval = this.listBox4.SelectedIndex;
					this.listBox2.SetSelected(this.listBox4.SelectedIndex, true);
					this.listBox3.SetSelected(this.listBox4.SelectedIndex, true);
					this.listBox1.SetSelected(this.listBox4.SelectedIndex, true);
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003220 File Offset: 0x00001420
		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.listBox2.SelectedIndex == -1;
			if (!flag)
			{
				bool flag2 = this.listBox2.SelectedIndex != this.selectedval;
				if (flag2)
				{
					this.selectedval = this.listBox2.SelectedIndex;
					this.listBox1.SetSelected(this.listBox2.SelectedIndex, true);
					this.listBox3.SetSelected(this.listBox2.SelectedIndex, true);
					this.listBox4.SetSelected(this.listBox2.SelectedIndex, true);
				}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000032B8 File Offset: 0x000014B8
		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.listBox3.SelectedIndex == -1;
			if (!flag)
			{
				bool flag2 = this.listBox3.SelectedIndex != this.selectedval;
				if (flag2)
				{
					this.selectedval = this.listBox3.SelectedIndex;
					this.listBox2.SetSelected(this.listBox3.SelectedIndex, true);
					this.listBox1.SetSelected(this.listBox3.SelectedIndex, true);
					this.listBox4.SetSelected(this.listBox3.SelectedIndex, true);
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003350 File Offset: 0x00001550
		private void button4_Click(object sender, EventArgs e)
		{
			bool flag = this.listBox1.Items[0] == "00";
			if (flag)
			{
				MessageBox.Show("You must select a line to use the edit line feature!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Form2 form = new Form2(this.loadObj, this.selectedval);
				form.Show();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000033A9 File Offset: 0x000015A9
		private void Form1_Load(object sender, EventArgs e)
		{
			this.button4.Enabled = true;
		}

		// Token: 0x04000012 RID: 18
		private int selectedval = 1024;
	}
}
