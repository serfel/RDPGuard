using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class ReportToAbuseIPDBAddEditControl : Control4
{
	private IContainer icontainer_0;

	private Class65 class65_0;

	private TextBox textBox_0;

	private Class62 class62_0;

	private Class63 class63_0;

	private PictureBox pictureBox_0;

	private GClass3 gclass3_1;

	public override Size Size_0 => new Size(570, 120);

	public override GClass3 GClass3_0 => gclass3_1;

	public override GClass10 GClass10_0
	{
		get
		{
			return new Class172
			{
				string_2 = textBox_0.Text
			};
		}
		set
		{
			textBox_0.Text = ((Class172)value).string_2;
		}
	}

	public override void vmethod_3(GEnum2 genum2_0)
	{
	}

	public override bool vmethod_4()
	{
		return true;
	}

	protected override void vmethod_0()
	{
		method_1();
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	protected override void vmethod_1()
	{
	}

	public override void vmethod_5(bool bool_1)
	{
		pictureBox_0.Visible = !bool_1;
		class62_0.Enabled = bool_1;
		class63_0.Enabled = bool_1;
		textBox_0.Enabled = bool_1;
		gclass3_1.Enabled = bool_1;
	}

	protected override void vmethod_2()
	{
		base.Boolean_0 = !string.IsNullOrEmpty(textBox_0.Text);
		gclass3_1.Enabled = base.Boolean_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_1()
	{
		new ComponentResourceManager(typeof(ReportToAbuseIPDBAddEditControl));
		class65_0 = new Class65();
		pictureBox_0 = new PictureBox();
		gclass3_1 = new GClass3();
		textBox_0 = new TextBox();
		class62_0 = new Class62();
		class63_0 = new Class63();
		class65_0.SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class65_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class65_0.Controls.Add(pictureBox_0);
		class65_0.Controls.Add(gclass3_1);
		class65_0.Controls.Add(textBox_0);
		class65_0.Controls.Add(class62_0);
		class65_0.Controls.Add(class63_0);
		class65_0.Location = new Point(4, 4);
		class65_0.Margin = new Padding(4);
		class65_0.Name = "m_grbSettings";
		class65_0.Padding = new Padding(4);
		class65_0.Size = new Size(608, 315);
		class65_0.TabIndex = 38;
		class65_0.TabStop = false;
		class65_0.Text = "Settings";
		pictureBox_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		pictureBox_0.Location = new Point(523, 295);
		pictureBox_0.Name = "m_picLoading";
		pictureBox_0.Size = new Size(16, 16);
		pictureBox_0.TabIndex = 87;
		pictureBox_0.TabStop = false;
		pictureBox_0.Visible = false;
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(545, 295);
		gclass3_1.Name = "m_lnkTestRun";
		gclass3_1.RightToLeft = RightToLeft.No;
		gclass3_1.Size = new Size(56, 16);
		gclass3_1.TabIndex = 86;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "test run";
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		textBox_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		textBox_0.Location = new Point(187, 32);
		textBox_0.Name = "m_edApiKey";
		textBox_0.Size = new Size(411, 22);
		textBox_0.TabIndex = 80;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(16, 32);
		class62_0.Name = "m_lblApiKey";
		class62_0.Size = new Size(99, 16);
		class62_0.TabIndex = 82;
		class62_0.Text = "API key:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(184, 60);
		class63_0.Name = "m_lblApiKeyHint";
		class63_0.Size = new Size(332, 16);
		class63_0.TabIndex = 81;
		class63_0.Text = "Please enter your AbuseIPDB API key";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.Controls.Add(class65_0);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(4);
		base.Name = "ReportToAbuseIPDBAddEditControl";
		base.Size = new Size(619, 322);
		class65_0.ResumeLayout(performLayout: false);
		class65_0.PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
	}
}
