using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class WinPcapDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Class127, bool> _003C_003E9__10_0;

		public static Func<Class127, bool> _003C_003E9__10_1;

		internal bool method_0(Class127 class127_0)
		{
			return class127_0.Boolean_2;
		}

		internal bool method_1(Class127 class127_0)
		{
			return class127_0.Boolean_1;
		}
	}

	private sealed class Class17
	{
		public WinPcapDialog form18_0;

		public object object_0;

		public EventArgs6 eventArgs6_0;

		internal void method_0()
		{
			form18_0.method_12(object_0, eventArgs6_0);
		}
	}

	private Class127[] class127_0 = new Class127[0];

	private bi<Class127> bi_0;

	private Class127 class127_1 = Class127.class127_0;

	private IContainer icontainer_0;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private Class62 class62_0;

	private PictureBox pictureBox_0;

	private Class62 class62_1;

	private GClass3 gclass3_0;

	private ImageList imageList_0;

	private GClass3 gclass3_1;

	private Class62 class62_2;

	private Class61 class61_0;

	public Class127 Class127_0
	{
		get
		{
			return bi_0.Prop_0.FirstOrDefault();
		}
		private set
		{
			class127_1 = value;
		}
	}

	protected override Button Button_0 => class66_0;

	public WinPcapDialog(Class127 class127_2)
		: base(new Size(550, 400))
	{
		Class127_0 = class127_2;
		method_18();
		vmethod_1();
		method_15();
		method_17();
		base.Shown += Form18_Shown;
	}

	public void method_11()
	{
		Class89.eventHandler_22 = (EventHandler<EventArgs6>)Delegate.Combine(Class89.eventHandler_22, new EventHandler<EventArgs6>(method_12));
		Class89.smethod_31();
	}

	private void method_12(object sender, EventArgs6 e)
	{
		Class17 @class = new Class17();
		@class.form18_0 = this;
		@class.object_0 = sender;
		@class.eventArgs6_0 = e;
		Class89.eventHandler_22 = (EventHandler<EventArgs6>)Delegate.Remove(Class89.eventHandler_22, new EventHandler<EventArgs6>(method_12));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else if (!@class.eventArgs6_0.bool_0)
		{
			class61_0.Visible = false;
			class62_2.Visible = true;
			gclass3_1.Visible = true;
		}
		else
		{
			class127_0 = @class.eventArgs6_0.class127_0;
			method_13();
		}
	}

	private void method_13()
	{
		bi_0.SuspendLayout();
		bi_0.Items.Clear();
		bi_0.Items.AddRange(method_14().Select(method_19).ToArray());
		bi_0.ResumeLayout();
		bi_0.Focus();
	}

	private Class127[] method_14()
	{
		if (!class61_0.Checked)
		{
			Class127[] source = class127_0;
			Func<Class127, bool> predicate = _003C_003Ec._003C_003E9.method_1;
			return source.Where(predicate).ToArray();
		}
		Class127[] source2 = class127_0;
		Func<Class127, bool> predicate2 = _003C_003Ec._003C_003E9.method_0;
		return source2.Where(predicate2).ToArray();
	}

	private void method_15()
	{
		base.Controls.Add(bi_0 = method_16());
	}

	private bi<Class127> method_16()
	{
		bi<Class127> bi2 = new bi<Class127>();
		bi2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		bi2.FullRowSelect = true;
		bi2.MultiSelect = false;
		bi2.GridLines = true;
		bi2.HideSelection = false;
		bi2.HeaderStyle = ColumnHeaderStyle.None;
		bi2.Location = new Point(16, 97);
		bi2.Width = base.ClientRectangle.Width - 30;
		bi2.Height = class66_1.Top - 97 - 15;
		bi2.SmallImageList = imageList_0;
		bi2.UseCompatibleStateImageBehavior = false;
		bi2.View = View.Details;
		bi2.ColumnHeader_0 = new ColumnHeader[1]
		{
			new ColumnHeader()
		};
		return bi2;
	}

	private void method_17()
	{
		gclass3_0.Click += gclass3_0_Click;
		bi_0.SelectedIndexChanged += bi_0_SelectedIndexChanged;
		class61_0.CheckedChanged += class61_0_CheckedChanged;
		gclass3_1.Click += gclass3_1_Click;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	protected override void vmethod_0()
	{
		Button_0.Enabled = bi_0.Boolean_2;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void method_18()
	{
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WinPcapDialog));
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		class62_0 = new Class62();
		pictureBox_0 = new PictureBox();
		class62_1 = new Class62();
		gclass3_0 = new GClass3();
		imageList_0 = new ImageList(icontainer_0);
		gclass3_1 = new GClass3();
		class62_2 = new Class62();
		class61_0 = new Class61();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.opts_16;
		class66_0.Location = new Point(315, 349);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnSave";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 7;
		class66_0.Text = "Save";
		class66_0.TextAlign = ContentAlignment.MiddleRight;
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_1.Image = Resources.cancl_16;
		class66_1.Location = new Point(423, 349);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnCancel";
		class66_1.Size = new Size(100, 36);
		class66_1.TabIndex = 8;
		class66_1.Text = "Cancel";
		class66_1.TextAlign = ContentAlignment.MiddleRight;
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 73);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(507, 10);
		gcontrol0_0.TabIndex = 50;
		gcontrol0_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_0.Location = new Point(79, 15);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblCaption";
		class62_0.Size = new Size(181, 16);
		class62_0.TabIndex = 49;
		class62_0.Text = "WinPcap/Npcap Settings";
		pictureBox_0.Image = Resources.traffic_monitoring_48;
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
		class62_1.Name = "m_lblSubCaption";
		class62_1.Size = new Size(397, 16);
		class62_1.TabIndex = 48;
		class62_1.Text = "Please select network adapter for traffic monitoring and click Save";
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(451, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 9;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("m_smallImageList.ImageStream");
		imageList_0.TransparentColor = Color.Transparent;
		imageList_0.Images.SetKeyName(0, "PCI-card_24.png");
		gclass3_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(13, 369);
		gclass3_1.Name = "m_lnkWinPcap";
		gclass3_1.Size = new Size(244, 16);
		gclass3_1.TabIndex = 137;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "click here to download WinPcap/Npcap";
		gclass3_1.Visible = false;
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class62_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class62_2.AutoSize = true;
		class62_2.ForeColor = Color.Red;
		class62_2.Location = new Point(13, 349);
		class62_2.Margin = new Padding(4, 0, 4, 0);
		class62_2.Name = "m_lblWinPcapWarning";
		class62_2.Size = new Size(235, 16);
		class62_2.TabIndex = 138;
		class62_2.Text = "WinPcap/Npcap driver is not installed,";
		class62_2.Boolean_0 = true;
		class62_2.Visible = false;
		class61_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class61_0.AutoSize = true;
		class61_0.Checked = true;
		class61_0.CheckState = CheckState.Checked;
		class61_0.Location = new Point(16, 365);
		class61_0.Name = "m_chbHideIrrelevantAdapters";
		class61_0.Size = new Size(171, 20);
		class61_0.TabIndex = 140;
		class61_0.Text = "Hide irrelevant adapters";
		class61_0.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(536, 398);
		base.Controls.Add(class61_0);
		base.Controls.Add(class62_2);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class62_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(pictureBox_0);
		base.Controls.Add(class66_0);
		base.Controls.Add(class66_1);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "WinPcapDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "WinPcap/Npcap Settings";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void Form18_Shown(object sender, EventArgs e)
	{
		method_11();
	}

	private ListViewItem method_19(Class127 class127_2)
	{
		return new ListViewItem(class127_2.Name)
		{
			Tag = class127_2,
			Selected = (class127_2.string_0 == class127_1.string_0),
			ImageIndex = 0
		};
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class155.String_1);
	}

	private void bi_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		vmethod_0();
	}

	private void class61_0_CheckedChanged(object sender, EventArgs e)
	{
		method_13();
	}

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		method_9(Class148.String_6);
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.OK);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}
}
