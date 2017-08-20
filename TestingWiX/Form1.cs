using System.Windows.Forms;

namespace TestingWiX
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Text = Application.ProductName;
			labelInfo.Text = $"v{Application.ProductVersion}";
		}
	}
}
