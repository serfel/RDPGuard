using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class EventLogDialog : Form0
{
	private readonly Class12 class12_0;

	private IContainer icontainer_0;

	private GClass0 gclass0_0;

	private ColumnHeader columnHeader_0;

	public EventLogDialog()
		: base(new Size(320, 240))
	{
		method_11();
		vmethod_1();
		class12_0 = new Class12(gclass0_0);
	}

	protected override void OnClosed(EventArgs eventArgs_0)
	{
		base.OnClosed(eventArgs_0);
		class12_0.method_0();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_11()
	{
		gclass0_0 = new GClass0();
		columnHeader_0 = new ColumnHeader();
		SuspendLayout();
		gclass0_0.Columns.AddRange(new ColumnHeader[1] { columnHeader_0 });
		gclass0_0.Dock = DockStyle.Fill;
		gclass0_0.HeaderStyle = ColumnHeaderStyle.None;
		gclass0_0.HideSelection = false;
		gclass0_0.Location = new Point(0, 0);
		gclass0_0.Name = "lstEventLog";
		gclass0_0.ShowItemToolTips = true;
		gclass0_0.Size = new Size(495, 259);
		gclass0_0.TabIndex = 0;
		gclass0_0.UseCompatibleStateImageBehavior = false;
		gclass0_0.View = View.Details;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(495, 259);
		base.Controls.Add(gclass0_0);
		base.Name = "EventLogDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Event Log";
		ResumeLayout(performLayout: false);
	}
}
