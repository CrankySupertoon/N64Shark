using System;
using System.Windows.Forms;

namespace GSStudio
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003A38 File Offset: 0x00001C38
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
