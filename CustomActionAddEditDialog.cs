using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class CustomActionAddEditDialog : Form0
{
	private delegate Class102 Delegate0(Class102 class102_0);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GEnum3, string> _003C_003E9__18_0;

		internal string method_0(GEnum3 genum3_0)
		{
			return Class186.Class186_0[genum3_0];
		}
	}

	private sealed class Class13
	{
		public Control4 control4_0;

		public CustomActionAddEditDialog form9_0;

		internal void method_0(object sender, EventArgs e)
		{
			form9_0.class66_1.Enabled = control4_0.Boolean_0;
		}
	}

	private sealed class Class14
	{
		public CustomActionAddEditDialog form9_0;

		public object object_0;

		public EventArgs3 eventArgs3_0;

		internal void method_0()
		{
			form9_0.method_17(object_0, eventArgs3_0);
		}
	}

	private readonly Control4[] control4_0 = new Control4[5]
	{
		new MailSendTaskAddEditControl(),
		new HttpPostTaskAddEditControl(),
		new ExecuteProgramAddEditControl(),
		new ReportToAbuseIPDBAddEditControl(),
		new TelegramSendTaskAddEditControl()
	};

	private static readonly GEnum3[] genum3_0 = Class186.Class186_0.Prop_0.Except(new GEnum3[1] { GEnum3.const_3 }).ToArray();

	private readonly Dictionary<GEnum2, GEnum3[]> dictionary_0 = new Dictionary<GEnum2, GEnum3[]>
	{
		{
			GEnum2.const_0,
			Class186.Class186_0.Prop_0
		},
		{
			GEnum2.const_1,
			genum3_0
		},
		{
			GEnum2.const_2,
			genum3_0
		},
		{
			GEnum2.const_3,
			genum3_0
		},
		{
			GEnum2.const_4,
			genum3_0
		},
		{
			GEnum2.const_5,
			genum3_0
		}
	};

	private readonly Dictionary<GEnum2, Class95> dictionary_1 = new Dictionary<GEnum2, Class95>
	{
		{
			GEnum2.const_0,
			new Class96()
		},
		{
			GEnum2.const_1,
			new Class97()
		},
		{
			GEnum2.const_2,
			new Class98()
		},
		{
			GEnum2.const_3,
			new Class99()
		},
		{
			GEnum2.const_4,
			new Class100()
		},
		{
			GEnum2.const_5,
			new Class101()
		}
	};

	private readonly Dictionary<GEnum2, Delegate0> dictionary_2 = new Dictionary<GEnum2, Delegate0>
	{
		{
			GEnum2.const_0,
			null
		},
		{
			GEnum2.const_1,
			null
		},
		{
			GEnum2.const_2,
			smethod_4
		},
		{
			GEnum2.const_3,
			null
		},
		{
			GEnum2.const_4,
			null
		},
		{
			GEnum2.const_5,
			null
		}
	};

	private Class94 class94_0;

	private IContainer icontainer_0;

	private PictureBox pictureBox_0;

	private Class62 class62_0;

	private Class62 class62_1;

	private Class66 class66_0;

	private Class66 class66_1;

	private GControl0 gcontrol0_0;

	private GClass3 gclass3_0;

	private Class0 class0_0;

	private Class62 class62_2;

	private Class63 class63_0;

	private Panel panel_0;

	private Class62 class62_3;

	private Class63 class63_1;

	private Class0 class0_1;

	private Class61 class61_0;

	private GClass3 gclass3_1;

	public Class94 Class94_0
	{
		get
		{
			class94_0.class95_0 = dictionary_1[GEnum2_0];
			class94_0.gclass10_0 = Control4_0.GClass10_0;
			class94_0.bool_0 = class61_0.Checked;
			return class94_0;
		}
		set
		{
			class94_0 = value;
			class0_1.Text = Class185.Class185_0[value.class95_0.GEnum2_0];
			class0_0.Text = Class186.Class186_0[value.gclass10_0.GEnum3_0];
			class61_0.Checked = value.bool_0;
			dictionary_1[value.class95_0.GEnum2_0] = value.class95_0;
			Control4_0.GClass10_0 = value.gclass10_0;
		}
	}

	private GEnum3 GEnum3_0
	{
		get
		{
			if (!string.IsNullOrEmpty(class0_0.Text))
			{
				return Class186.Class186_0[class0_0.Text];
			}
			return GEnum3.const_0;
		}
	}

	private Control4 Control4_0 => control4_0.Where(method_19).FirstOrDefault();

	private GEnum2 GEnum2_0 => Class185.Class185_0[class0_1.Text];

	public CustomActionAddEditDialog(Class94 class94_1)
		: base(new Size(685, 800))
	{
		InitializeComponent();
		vmethod_1();
		method_13();
		method_14();
		method_11();
		if (class94_1 == null)
		{
			Class94_0 = new Class94
			{
				class95_0 = new Class96(),
				gclass10_0 = new Class175()
			};
			Text = "Add New Custom Action";
			class62_1.Text = "New Custom Action";
			class62_0.Text = "Specify Custom Action properties and click Add new custom action";
			class66_1.Text = "Add new custom action";
			pictureBox_0.Image = Resources.notifications_add_48;
			gclass3_0.Click += gclass3_0_Click;
			Control4_0.vmethod_3(GEnum2_0);
		}
		else
		{
			Class94_0 = class94_1;
			Text = "Edit Custom Action";
			class62_1.Text = "Edit Custom Action";
			class62_0.Text = "Edit Custom Action properties and click Save changes";
			class66_1.Text = "Save changes";
			pictureBox_0.Image = Resources.notifications_edit_48;
			gclass3_0.Click += gclass3_0_Click_1;
		}
	}

	private void method_11()
	{
		class0_1.Items.Clear();
		ComboBox.ObjectCollection items = class0_1.Items;
		object[] prop_ = Class185.Class185_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
		class0_1.SelectedIndex = 0;
	}

	private void method_12()
	{
		class0_0.Items.Clear();
		ComboBox.ObjectCollection items = class0_0.Items;
		GEnum3[] source = dictionary_0[GEnum2_0];
		Func<GEnum3, string> selector = _003C_003Ec._003C_003E9.method_0;
		object[] array = source.Select(selector).ToArray();
		object[] items2 = array;
		items.AddRange(items2);
		class0_0.SelectedIndex = 0;
	}

	private void method_13()
	{
		Control4[] array = control4_0;
		for (int i = 0; i < array.Length; i++)
		{
			Class13 @class = new Class13();
			@class.form9_0 = this;
			@class.control4_0 = array[i];
			@class.control4_0.GClass3_0.Click += method_20;
			@class.control4_0.Event_1 += @class.method_0;
			@class.control4_0.Event_0 += method_21;
			@class.control4_0.Dock = DockStyle.Fill;
			@class.control4_0.Visible = false;
			panel_0.Controls.Add(@class.control4_0);
		}
	}

	private void method_14()
	{
		class0_1.SelectedIndexChanged += class0_1_SelectedIndexChanged;
		gclass3_1.Click += gclass3_1_Click;
		class0_0.SelectedIndexChanged += class0_0_SelectedIndexChanged;
		class66_0.Click += class66_0_Click;
		class66_1.Click += class66_1_Click;
	}

	private void method_15(bool bool_0)
	{
		class0_1.Enabled = bool_0;
		class0_0.Enabled = bool_0;
		class66_1.Enabled = bool_0;
	}

	private void method_16()
	{
		Class89.eventHandler_27 = (EventHandler<EventArgs3>)Delegate.Combine(Class89.eventHandler_27, new EventHandler<EventArgs3>(method_17));
		Class89.smethod_36(Class94_0);
		Control4_0.vmethod_5(bool_1: false);
		method_15(bool_0: false);
	}

	private void method_17(object sender, EventArgs3 e)
	{
		Class14 @class = new Class14();
		@class.form9_0 = this;
		@class.object_0 = sender;
		@class.eventArgs3_0 = e;
		Class89.eventHandler_27 = (EventHandler<EventArgs3>)Delegate.Remove(Class89.eventHandler_27, new EventHandler<EventArgs3>(method_17));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		if (@class.eventArgs3_0.gclass10_0.Boolean_0)
		{
			MessageBox.Show("Test task was successfully completed.", Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}
		else
		{
			MessageBox.Show("Unable to start test task.\r\n\r\nError Code: " + @class.eventArgs3_0.gclass10_0.string_0 + "\r\n\r\nError Message: " + @class.eventArgs3_0.gclass10_0.string_1, Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		Control4_0.vmethod_5(bool_1: true);
		method_15(bool_0: true);
	}

	private static Class102 smethod_4(Class102 class102_0)
	{
		ProtocolRulesDialog form = new ProtocolRulesDialog
		{
			String_0 = "Exclusion Rules for Successful Logins",
			String_1 = "Exclusion Rules for Successful Logins",
			String_2 = "Specify rules to exclude certain successful login events from triggering actions.",
			string_0 = Class148.Class153.String_3,
			String_3 = "Exclusion Rules:",
			String_4 = ((Class105)class102_0).string_0,
			String_5 = "Define exclusion rules for successful login events. Refer to the online help for syntax."
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				return new Class105
				{
					string_0 = form.String_4
				};
			}
			return class102_0;
		}
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
		pictureBox_0 = new PictureBox();
		class62_0 = new Class62();
		class62_1 = new Class62();
		class66_0 = new Class66();
		class66_1 = new Class66();
		gcontrol0_0 = new GControl0();
		gclass3_0 = new GClass3();
		class0_0 = new Class0();
		class62_2 = new Class62();
		class63_0 = new Class63();
		panel_0 = new Panel();
		class62_3 = new Class62();
		class63_1 = new Class63();
		class0_1 = new Class0();
		class61_0 = new Class61();
		gclass3_1 = new GClass3();
		((ISupportInitialize)pictureBox_0).BeginInit();
		SuspendLayout();
		pictureBox_0.Location = new Point(16, 15);
		pictureBox_0.Margin = new Padding(4);
		pictureBox_0.Name = "m_imgBigIcon";
		pictureBox_0.Size = new Size(48, 48);
		pictureBox_0.SizeMode = PictureBoxSizeMode.AutoSize;
		pictureBox_0.TabIndex = 0;
		pictureBox_0.TabStop = false;
		class62_0.AutoSize = true;
		class62_0.Location = new Point(79, 47);
		class62_0.Margin = new Padding(4, 0, 4, 0);
		class62_0.Name = "m_lblSubCaption";
		class62_0.Size = new Size(163, 16);
		class62_0.TabIndex = 4;
		class62_0.Text = "<description placeholder>";
		class62_1.AutoSize = true;
		class62_1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		class62_1.Location = new Point(79, 15);
		class62_1.Margin = new Padding(4, 0, 4, 0);
		class62_1.Name = "m_lblCaption";
		class62_1.Size = new Size(187, 16);
		class62_1.TabIndex = 14;
		class62_1.Text = "<subcaption placeholder>";
		class66_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		class66_0.Image = Resources.cancl_16;
		class66_0.Location = new Point(560, 713);
		class66_0.Margin = new Padding(4);
		class66_0.Name = "m_btnCancel";
		class66_0.Size = new Size(100, 36);
		class66_0.TabIndex = 5;
		class66_0.Text = "Cancel";
		class66_0.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_0.UseVisualStyleBackColor = true;
		class66_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		class66_1.Image = Resources.opts_16;
		class66_1.Location = new Point(275, 713);
		class66_1.Margin = new Padding(4);
		class66_1.Name = "m_btnOK";
		class66_1.Size = new Size(277, 36);
		class66_1.TabIndex = 4;
		class66_1.Text = "<ok_button>";
		class66_1.TextImageRelation = TextImageRelation.ImageBeforeText;
		class66_1.UseVisualStyleBackColor = true;
		gcontrol0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		gcontrol0_0.Location = new Point(16, 73);
		gcontrol0_0.Name = "separatorLine1";
		gcontrol0_0.Size = new Size(638, 10);
		gcontrol0_0.TabIndex = 35;
		gcontrol0_0.TabStop = false;
		gclass3_0.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_0.AutoSize = true;
		gclass3_0.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_0.Location = new Point(584, 9);
		gclass3_0.Name = "m_lnkOnlineHelp";
		gclass3_0.Size = new Size(73, 16);
		gclass3_0.TabIndex = 6;
		gclass3_0.TabStop = true;
		gclass3_0.Text = "online help";
		gclass3_0.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		class0_0.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_0.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_0.FormattingEnabled = true;
		class0_0.Location = new Point(200, 167);
		class0_0.Name = "m_cbAction";
		class0_0.Size = new Size(454, 24);
		class0_0.TabIndex = 1;
		class62_2.AutoSize = true;
		class62_2.Location = new Point(13, 167);
		class62_2.Margin = new Padding(4, 0, 4, 0);
		class62_2.Name = "m_lblAction";
		class62_2.Size = new Size(48, 16);
		class62_2.TabIndex = 67;
		class62_2.Text = "Action:";
		class63_0.AutoSize = true;
		class63_0.ForeColor = SystemColors.ControlDarkDark;
		class63_0.Location = new Point(197, 197);
		class63_0.Margin = new Padding(4, 0, 4, 0);
		class63_0.Name = "m_lblActionHint";
		class63_0.Size = new Size(248, 16);
		class63_0.TabIndex = 66;
		class63_0.Text = "Specify the action that will occur when {0}";
		panel_0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		panel_0.Location = new Point(9, 213);
		panel_0.Margin = new Padding(0);
		panel_0.Name = "m_panel";
		panel_0.Size = new Size(651, 493);
		panel_0.TabIndex = 2;
		class62_3.AutoSize = true;
		class62_3.Location = new Point(13, 97);
		class62_3.Margin = new Padding(4, 0, 4, 0);
		class62_3.Name = "m_lblEvent";
		class62_3.Size = new Size(45, 16);
		class62_3.TabIndex = 71;
		class62_3.Text = "Event:";
		class63_1.AutoSize = true;
		class63_1.ForeColor = SystemColors.ControlDarkDark;
		class63_1.Location = new Point(197, 127);
		class63_1.Margin = new Padding(4, 0, 4, 0);
		class63_1.Name = "m_lblEventHint";
		class63_1.Size = new Size(180, 16);
		class63_1.TabIndex = 70;
		class63_1.Text = "Select event type from the list";
		class0_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		class0_1.DropDownStyle = ComboBoxStyle.DropDownList;
		class0_1.FormattingEnabled = true;
		class0_1.Location = new Point(200, 97);
		class0_1.Name = "m_cbEvent";
		class0_1.Size = new Size(454, 24);
		class0_1.TabIndex = 0;
		class61_0.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		class61_0.AutoSize = true;
		class61_0.Location = new Point(16, 722);
		class61_0.Name = "m_chbEnabled";
		class61_0.Size = new Size(78, 20);
		class61_0.TabIndex = 3;
		class61_0.Text = "Enabled";
		class61_0.UseVisualStyleBackColor = true;
		gclass3_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		gclass3_1.AutoSize = true;
		gclass3_1.LinkColor = Color.FromArgb(38, 135, 200);
		gclass3_1.Location = new Point(585, 127);
		gclass3_1.Name = "m_lnkConfigureEvent";
		gclass3_1.Size = new Size(69, 16);
		gclass3_1.TabIndex = 72;
		gclass3_1.TabStop = true;
		gclass3_1.Text = "configure..";
		gclass3_1.Visible = false;
		gclass3_1.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(669, 762);
		base.Controls.Add(gclass3_1);
		base.Controls.Add(class61_0);
		base.Controls.Add(class0_1);
		base.Controls.Add(class62_3);
		base.Controls.Add(class63_1);
		base.Controls.Add(panel_0);
		base.Controls.Add(class0_0);
		base.Controls.Add(class62_2);
		base.Controls.Add(class63_0);
		base.Controls.Add(gclass3_0);
		base.Controls.Add(gcontrol0_0);
		base.Controls.Add(class66_1);
		base.Controls.Add(class66_0);
		base.Controls.Add(class62_1);
		base.Controls.Add(class62_0);
		base.Controls.Add(pictureBox_0);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "CustomActionAddEditDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "<caption placeholder>";
		((ISupportInitialize)pictureBox_0).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private bool method_19(Control4 control4_1)
	{
		return control4_1.GClass10_0.GEnum3_0 == GEnum3_0;
	}

	private void gclass3_0_Click(object sender, EventArgs e)
	{
		method_9(Class148.Class153.String_1);
	}

	private void gclass3_0_Click_1(object sender, EventArgs e)
	{
		method_9(Class148.Class153.String_2);
	}

	private void method_20(object sender, EventArgs e)
	{
		method_16();
	}

	private void method_21(object sender, EventArgs e)
	{
		class66_1.PerformClick();
	}

	private void class0_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		method_12();
		class63_0.Text = "Specify the action that will occur when " + class0_1.Text;
		Control4_0.vmethod_3(GEnum2_0);
		gclass3_1.Visible = dictionary_1[GEnum2_0].class102_0.Boolean_0;
	}

	private void gclass3_1_Click(object sender, EventArgs e)
	{
		dictionary_1[GEnum2_0].class102_0 = dictionary_2[GEnum2_0](dictionary_1[GEnum2_0].class102_0);
	}

	private void class0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		Control4 control = Control4_0;
		Control4[] array = control4_0;
		Control4[] array2 = array;
		foreach (Control4 control2 in array2)
		{
			control2.Visible = control.GClass10_0.GEnum3_0 == control2.GClass10_0.GEnum3_0;
		}
		int num = base.Width - panel_0.Width + control.Size_0.Width;
		int num2 = base.Height - panel_0.Height + control.Size_0.Height;
		MinimumSize = new Size(num, num2);
		base.Height = num2;
		class66_1.Enabled = control.Boolean_0;
		control.vmethod_3(GEnum2_0);
	}

	private void class66_0_Click(object sender, EventArgs e)
	{
		method_8(DialogResult.Cancel);
	}

	private void class66_1_Click(object sender, EventArgs e)
	{
		if (Control4_0.vmethod_4())
		{
			method_8(DialogResult.OK);
		}
	}
}
