using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal sealed class EventLogDialog : Form0
{
	private readonly Class12 class12_0;

	private IContainer icontainer_0;

	private ListViewWithScroll gclass0_0;

	private ColumnHeader columnHeader_0;

	public EventLogDialog()
		: base(new Size(320, 240))
	{
        InitializeComponent();
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

	private void InitializeComponent()
	{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventLogDialog));
            this.gclass0_0 = new ListViewWithScroll();
            this.columnHeader_0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // gclass0_0
            // 
            this.gclass0_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass0_0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gclass0_0.BackgroundImage")));
            this.gclass0_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            this.gclass0_0.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_0});
            this.gclass0_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclass0_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass0_0.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.gclass0_0.HideSelection = false;
            this.gclass0_0.Location = new System.Drawing.Point(0, 0);
            this.gclass0_0.Name = "gclass0_0";
            this.gclass0_0.ShowItemToolTips = true;
            this.gclass0_0.Size = new System.Drawing.Size(784, 561);
            this.gclass0_0.TabIndex = 0;
            this.gclass0_0.UseCompatibleStateImageBehavior = false;
            this.gclass0_0.View = System.Windows.Forms.View.Details;
            // 
            // EventLogDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gclass0_0);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "EventLogDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Event Log";
            this.ResumeLayout(false);

	}
}
