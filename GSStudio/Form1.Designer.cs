namespace GSStudio
{
	// Token: 0x02000005 RID: 5
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000033BC File Offset: 0x000015BC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000033F4 File Offset: 0x000015F4
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.listBox2 = new global::System.Windows.Forms.ListBox();
			this.listBox3 = new global::System.Windows.Forms.ListBox();
			this.listBox4 = new global::System.Windows.Forms.ListBox();
			this.button4 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(59, 42);
			this.button1.TabIndex = 0;
			this.button1.Text = "Load GS file";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Enabled = false;
			this.button2.Location = new global::System.Drawing.Point(12, 59);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(59, 42);
			this.button2.TabIndex = 1;
			this.button2.Text = "Patch to ROM";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.Enabled = false;
			this.button3.Location = new global::System.Drawing.Point(12, 106);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(59, 42);
			this.button3.TabIndex = 2;
			this.button3.Text = "Convert to ASM";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.listBox1.Enabled = false;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[]
			{
				"00"
			});
			this.listBox1.Location = new global::System.Drawing.Point(77, 13);
			this.listBox1.Name = "listBox1";
			this.listBox1.ScrollAlwaysVisible = true;
			this.listBox1.Size = new global::System.Drawing.Size(36, 108);
			this.listBox1.TabIndex = 3;
			this.listBox1.SelectedIndexChanged += new global::System.EventHandler(this.listBox1_SelectedIndexChanged);
			this.listBox2.Enabled = false;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Items.AddRange(new object[]
			{
				"0000"
			});
			this.listBox2.Location = new global::System.Drawing.Point(161, 13);
			this.listBox2.Name = "listBox2";
			this.listBox2.ScrollAlwaysVisible = true;
			this.listBox2.Size = new global::System.Drawing.Size(58, 108);
			this.listBox2.TabIndex = 4;
			this.listBox2.SelectedIndexChanged += new global::System.EventHandler(this.listBox2_SelectedIndexChanged);
			this.listBox3.Enabled = false;
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Items.AddRange(new object[]
			{
				"0000"
			});
			this.listBox3.Location = new global::System.Drawing.Point(225, 13);
			this.listBox3.Name = "listBox3";
			this.listBox3.ScrollAlwaysVisible = true;
			this.listBox3.Size = new global::System.Drawing.Size(57, 108);
			this.listBox3.TabIndex = 5;
			this.listBox3.SelectedIndexChanged += new global::System.EventHandler(this.listBox3_SelectedIndexChanged);
			this.listBox4.Enabled = false;
			this.listBox4.FormattingEnabled = true;
			this.listBox4.Items.AddRange(new object[]
			{
				"00"
			});
			this.listBox4.Location = new global::System.Drawing.Point(119, 13);
			this.listBox4.Name = "listBox4";
			this.listBox4.ScrollAlwaysVisible = true;
			this.listBox4.Size = new global::System.Drawing.Size(36, 108);
			this.listBox4.TabIndex = 6;
			this.listBox4.SelectedIndexChanged += new global::System.EventHandler(this.listBox4_SelectedIndexChanged);
			this.button4.Enabled = false;
			this.button4.Location = new global::System.Drawing.Point(77, 127);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(205, 21);
			this.button4.TabIndex = 7;
			this.button4.Text = "Edit line";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(294, 160);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.listBox4);
			base.Controls.Add(this.listBox3);
			base.Controls.Add(this.listBox2);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "Form1";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "n64shark GUI";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000013 RID: 19
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.ListBox listBox2;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.ListBox listBox3;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.ListBox listBox4;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Button button4;
	}
}
