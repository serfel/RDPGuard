using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class EventLogDialog : Form0
{
	private readonly Class12 class12_0;

	private IContainer icontainer_0;

	private GClass0 lstEventLog;

	private ColumnHeader columnHeader_0;

	public EventLogDialog()
		: base(new Size(320, 240))
	{
		InitializeComponent();
		InitializeFormPosition();
		class12_0 = new Class12(lstEventLog);
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

	private void InitializeComponent()
	{
		lstEventLog = new GClass0();
		columnHeader_0 = new ColumnHeader();
		SuspendLayout();
		lstEventLog.Columns.AddRange(new ColumnHeader[1] { columnHeader_0 });
		lstEventLog.Dock = DockStyle.Fill;
		lstEventLog.HeaderStyle = ColumnHeaderStyle.None;
		lstEventLog.HideSelection = false;
		lstEventLog.Location = new Point(0, 0);
		lstEventLog.Name = "lstEventLog";
		lstEventLog.ShowItemToolTips = true;
		lstEventLog.Size = new Size(495, 259);
		lstEventLog.TabIndex = 0;
		lstEventLog.UseCompatibleStateImageBehavior = false;
		lstEventLog.View = View.Details;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(495, 259);
		base.Controls.Add(lstEventLog);
		base.Name = "EventLogDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Event Log";
		ResumeLayout(performLayout: false);
	}
}
