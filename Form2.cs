using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace n64shark
{
	// Token: 0x02000002 RID: 2
	public partial class Form2 : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		private string loadObj { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		private int selectedVal { get; set; }

		// Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		public Form2(string obj, int selval)
		{
			this.selectedVal = selval;
			this.loadObj = obj;
			this.InitializeComponent();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
		private void Form2_Load(object sender, EventArgs e)
		{
			bool flag = this.selectedVal == 1024;
			if (flag)
			{
				MessageBox.Show("You must select a line to use the edit line feature!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				base.Close();
			}
			int num = this.selectedVal + 1;
			string[] array = File.ReadAllLines(this.loadObj);
			this.textBox1.Text = array[this.selectedVal];
			this.textBox2.Text = num.ToString();
			this.textBox3.Text = this.loadObj;
			char[] array2 = array[this.selectedVal].ToCharArray();
			bool flag2 = array2[0] == '8';
			if (flag2)
			{
				this.richTextBox1.Text = "ram(0x80" + new string(array2, 2, 6) + ") = 0x" + new string(array2, 9, 4);
			}
			else
			{
				this.richTextBox1.Text = string.Concat(new string[]
				{
					"if(ram(0x80",
					new string(array2, 2, 6),
					") == 0x",
					new string(array2, 9, 4),
					"){\n    "
				});
				char[] value = array[num].ToCharArray();
				this.richTextBox1.Text = string.Concat(new string[]
				{
					this.richTextBox1.Text,
					"ram(0x80",
					new string(value, 2, 6),
					") = 0x",
					new string(value, 9, 4),
					" \n}"
				});
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000221C File Offset: 0x0000041C
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = this.textBox1.Text.Length != 13;
			if (flag)
			{
				MessageBox.Show("Parsing error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				string[] array = File.ReadAllLines(this.loadObj);
				array[this.selectedVal] = this.textBox1.Text;
				File.WriteAllLines(this.loadObj, array);
				int num = this.selectedVal + 1;
				char[] array2 = array[this.selectedVal].ToCharArray();
				bool @checked = this.checkBox1.Checked;
				if (@checked)
				{
					bool flag2 = array2[0] == '8';
					if (flag2)
					{
						int num2 = int.Parse(new string(array2, 9, 4), NumberStyles.HexNumber);
						this.richTextBox1.Text = "ram(0x80" + new string(array2, 2, 6) + ") = " + num2.ToString();
					}
					else
					{
						int num3 = int.Parse(new string(array2, 9, 4), NumberStyles.HexNumber);
						this.richTextBox1.Text = string.Concat(new string[]
						{
							"if(ram(0x80",
							new string(array2, 2, 6),
							") == ",
							num3.ToString(),
							"){\n    "
						});
						char[] value = array[num].ToCharArray();
						int num4 = int.Parse(new string(value, 9, 4), NumberStyles.HexNumber);
						this.richTextBox1.Text = string.Concat(new string[]
						{
							this.richTextBox1.Text,
							"ram(0x80",
							new string(value, 2, 6),
							") = ",
							num4.ToString(),
							" \n}"
						});
					}
				}
				else
				{
					bool flag3 = array2[0] == '8';
					if (flag3)
					{
						this.richTextBox1.Text = "ram(0x80" + new string(array2, 2, 6) + ") = 0x" + new string(array2, 9, 4);
					}
					else
					{
						this.richTextBox1.Text = string.Concat(new string[]
						{
							"if(ram(0x80",
							new string(array2, 2, 6),
							") == 0x",
							new string(array2, 9, 4),
							"){\n    "
						});
						char[] value2 = array[num].ToCharArray();
						this.richTextBox1.Text = string.Concat(new string[]
						{
							this.richTextBox1.Text,
							"ram(0x80",
							new string(value2, 2, 6),
							") = 0x",
							new string(value2, 9, 4),
							" \n}"
						});
					}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024C7 File Offset: 0x000006C7
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000024C7 File Offset: 0x000006C7
		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000024C7 File Offset: 0x000006C7
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000024C7 File Offset: 0x000006C7
		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
