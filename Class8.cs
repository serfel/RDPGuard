using System.Drawing;
using System.Windows.Forms;

internal sealed class Class8 : ListViewItem
{
	public long Int64_0
	{
		set
		{
			base.SubItems[1].Text = value.ToString("N0");
		}
	}

	public GStruct1 GStruct1_0
	{
		set
		{
			base.SubItems[2].Text = value.method_0("N0");
		}
	}

	public long Int64_1
	{
		set
		{
			base.Text = $"Total ({value})";
		}
	}

	public Class8()
	{
		base.BackColor = SystemColors.Control;
		base.Text = "Total";
		base.SubItems.AddRange(new string[3]
		{
			string.Empty,
			string.Empty,
			string.Empty
		});
	}
}
