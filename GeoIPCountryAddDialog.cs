using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class GeoIPCountryAddDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GClass5, string> _003C_003E9__4_0;

		public static Func<GClass5, string> _003C_003E9__6_2;

		internal string method_0(GClass5 gclass5_0)
		{
			return gclass5_0.string_1;
		}

		internal string method_1(GClass5 gclass5_0)
		{
			return gclass5_0.Name;
		}
	}

	private sealed class Class9
	{
		public GeoIPCountryAddDialog form7_0;

		public object object_0;

		public EventArgs0 eventArgs0_0;

		internal void method_0()
		{
			form7_0.method_12(object_0, eventArgs0_0);
		}

		internal bool method_1(GClass5 gclass5_0)
		{
			return !form7_0.string_0.Contains(gclass5_0.string_1);
		}
	}

	private string[] string_0;

	private GeoIPDBVersion geoIPDBVersion_0;

	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private GeoIPCountriesTable control1_0;

	private PictureBox pictureBox_1;

	private Class63 class63_0;

	public GClass5[] GClass5_0 => control1_0.GClass5_0;

	protected override Button Button_0 => class66_0;

	public GeoIPCountryAddDialog(GClass5[] gclass5_0, GeoIPDBVersion geoIPDBVersion_1)
		: base(new Size(600, 525))
	{
		Func<GClass5, string> selector = _003C_003Ec._003C_003E9.method_0;
		string_0 = gclass5_0.Select(selector).ToArray();
		geoIPDBVersion_0 = geoIPDBVersion_1;
		InitializeComponent();
		vmethod_1();
		method_13();
		method_14();
		base.Shown += Form7_Shown;
	}

	private void method_11()
	{
		method_15(bool_0: true);
		Class89.eventHandler_28 = (EventHandler<EventArgs0>)Delegate.Combine(Class89.eventHandler_28, new EventHandler<EventArgs0>(method_12));
		Class89.smethod_39(geoIPDBVersion_0);
	}

	private void method_12(object sender, EventArgs0 e)
	{
		Class9 @class = new Class9();
		@class.form7_0 = this;
		@class.object_0 = sender;
		@class.eventArgs0_0 = e;
		Class89.eventHandler_28 = (EventHandler<EventArgs0>)Delegate.Remove(Class89.eventHandler_28, new EventHandler<EventArgs0>(method_12));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		method_15(bool_0: false);
		GeoIPCountriesTable control = control1_0;
		IEnumerable<GClass5> source = @class.eventArgs0_0.gclass29_0.gclass5_0.Where(@class.method_1);
		Func<GClass5, string> keySelector = _003C_003Ec._003C_003E9.method_1;
		control.GClass5_1 = source.OrderBy(keySelector).ToArray();
	}

	private void method_13()
	{
		pictureBox_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.location_pin_48_dark : Resources.location_pin_48);
		pictureBox_1.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	private void method_14()
	{
		control1_0.Event_0 += method_17;
		control1_0.Event_3 += method_18;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
		gclass3_0.Click += gclass3_0_Click;
	}

	private void method_15(bool bool_0)
	{
		pictureBox_1.Visible = bool_0;
		class63_0.Visible = bool_0;
		control1_0.Enabled = !bool_0;
		class66_0.Enabled = !bool_0;
		class66_1.Enabled = !bool_0;
		vmethod_0();
		control1_0.Focus();
	}

	protected override void vmethod_0()
	{
		class66_0.Enabled = control1_0.Boolean_0;
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
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		control1_0 = new GeoIPCountriesTable();
		pictureBox_1 = new PictureBox();
		class63_0 = new Class63();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((ISupportInitialize)pictureBox_1).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(464, 438);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnAdd";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 20;
		class66_0.Text = "Добавить";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(572, 438);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 21;
		class66_1.Text = "Отмена";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 81);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(656, 2);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "label2";
		class62_0.Size = new Size(91, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "Добавить Country";
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 47;
		pictureBox_0.TabStop = false;
		class62_1.AutoSize = true;
		class62_1.Location = new Point(79, 47);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "lblCaption";
		class62_1.Size = new Size(384, 16);
		class62_1.TabIndex = 48;
		class62_1"Select one or multiple countries from the list below and click Add";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkBehavior = LinkBehavior.NeverUnderline;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(599, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(72, 16);
		gclass3_0.TabIndex = 55;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "справка онлайн";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		control1_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		control1_0.GClass5_1 = new GClass5[0];
		control1_0.IPListEntry_0 = new IPListEntry[0];
		control1_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		control1_0.Location = new Point(16, 98);
		control1_0.Margin = new Padding(4);
		control1_0.Name = "m_lstCountries";
		control1_0.Size = new Size(656, 327);
		control1_0.TabIndex = 56;
		pictureBox_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		pictureBox_1.Location = new Point(16, 458);
		pictureBox_1.Name = "m_picLoading";
		pictureBox_1.Size = new Size(16, 16);
		pictureBox_1.TabIndex = 76;
		pictureBox_1.TabStop = false;
		pictureBox_1.Visible = false;
		class63_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(39, 458);
		class63_0.Margin = new Padding(4, 0, 4, 0);
		class63_0.Name = "m_lblLoadingHint";
		class63_0.Size = new Size(58, 16);
		class63_0.TabIndex = 77;
		class63_0"loading..";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(684, 487);
		base.Controls.Add(class63_0);
		base.Controls.Add(pictureBox_1);
		base.Controls.Add(control1_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "GeoIPCountryAddDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Add Country";
		((ISupportInitialize)pictureBox_0).EndInit();
		((ISupportInitialize)pictureBox_1).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void Form7_Shown(object sender, EventArgs e)
	{
		method_11();
	}

	private void method_17(object sender, EventArgs e)
	{
		vmethod_0();
	}

	private void method_18(object sender, MouseEventArgs e)
	{
		class66_0.PerformClick();
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class156.String_0);
	}
}
