using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCFx
{
	public partial class MyDemo : Form
	{
		public MyDemo()
		{
			InitializeComponent();

			webBrowser.LoadUrl("http://192.168.1.124:1001/");
		}
	}
}
