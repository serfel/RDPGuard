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
    private IContainer components;
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox_0 = new System.Windows.Forms.PictureBox();
            this.class62_0 = new Class62();
            this.class62_1 = new Class62();
            this.class66_0 = new Class66();
            this.class66_1 = new Class66();
            this.gcontrol0_0 = new GControl0();
            this.gclass3_0 = new GClass3();
            this.class0_0 = new Class0();
            this.class62_2 = new Class62();
            this.class63_0 = new Class63();
            this.panel_0 = new System.Windows.Forms.Panel();
            this.class62_3 = new Class62();
            this.class63_1 = new Class63();
            this.class0_1 = new Class0();
            this.class61_0 = new Class61();
            this.gclass3_1 = new GClass3();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_0
            // 
            this.pictureBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pictureBox_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pictureBox_0.Location = new System.Drawing.Point(16, 15);
            this.pictureBox_0.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_0.Name = "pictureBox_0";
            this.pictureBox_0.Size = new System.Drawing.Size(48, 48);
            this.pictureBox_0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_0.TabIndex = 0;
            this.pictureBox_0.TabStop = false;
            // 
            // class62_0
            // 
            this.class62_0.AutoSize = true;
            this.class62_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_0.Boolean_0 = false;
            this.class62_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_0.Location = new System.Drawing.Point(79, 47);
            this.class62_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_0.Name = "class62_0";
            this.class62_0.Size = new System.Drawing.Size(162, 16);
            this.class62_0.TabIndex = 4;
            this.class62_0.Text = "<description placeholder>";
            // 
            // class62_1
            // 
            this.class62_1.AutoSize = true;
            this.class62_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_1.Boolean_0 = false;
            this.class62_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.class62_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_1.Location = new System.Drawing.Point(79, 15);
            this.class62_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_1.Name = "class62_1";
            this.class62_1.Size = new System.Drawing.Size(186, 16);
            this.class62_1.TabIndex = 14;
            this.class62_1.Text = "<subcaption placeholder>";
            // 
            // class66_0
            // 
            this.class66_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_0.Image = global::Properties.Resources.cancl_16;
            this.class66_0.Location = new System.Drawing.Point(560, 713);
            this.class66_0.Margin = new System.Windows.Forms.Padding(4);
            this.class66_0.Name = "class66_0";
            this.class66_0.Size = new System.Drawing.Size(100, 36);
            this.class66_0.TabIndex = 5;
            this.class66_0.Text = "Cancel";
            this.class66_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_0.UseVisualStyleBackColor = false;
            // 
            // class66_1
            // 
            this.class66_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class66_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class66_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class66_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class66_1.Image = global::Properties.Resources.opts_16;
            this.class66_1.Location = new System.Drawing.Point(275, 713);
            this.class66_1.Margin = new System.Windows.Forms.Padding(4);
            this.class66_1.Name = "class66_1";
            this.class66_1.Size = new System.Drawing.Size(277, 36);
            this.class66_1.TabIndex = 4;
            this.class66_1.Text = "<ok_button>";
            this.class66_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.class66_1.UseVisualStyleBackColor = false;
            // 
            // gcontrol0_0
            // 
            this.gcontrol0_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcontrol0_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gcontrol0_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gcontrol0_0.Location = new System.Drawing.Point(16, 73);
            this.gcontrol0_0.Name = "gcontrol0_0";
            this.gcontrol0_0.Size = new System.Drawing.Size(638, 10);
            this.gcontrol0_0.TabIndex = 35;
            this.gcontrol0_0.TabStop = false;
            // 
            // gclass3_0
            // 
            this.gclass3_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gclass3_0.AutoSize = true;
            this.gclass3_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_0.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_0.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_0.Location = new System.Drawing.Point(584, 9);
            this.gclass3_0.Name = "gclass3_0";
            this.gclass3_0.Size = new System.Drawing.Size(72, 16);
            this.gclass3_0.TabIndex = 6;
            this.gclass3_0.TabStop = true;
            this.gclass3_0.Text = "online help";
            this.gclass3_0.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // class0_0
            // 
            this.class0_0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class0_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class0_0.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.class0_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class0_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class0_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class0_0.FormattingEnabled = true;
            this.class0_0.Location = new System.Drawing.Point(200, 167);
            this.class0_0.Name = "class0_0";
            this.class0_0.Size = new System.Drawing.Size(454, 23);
            this.class0_0.TabIndex = 1;
            // 
            // class62_2
            // 
            this.class62_2.AutoSize = true;
            this.class62_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_2.Boolean_0 = false;
            this.class62_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_2.Location = new System.Drawing.Point(13, 167);
            this.class62_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_2.Name = "class62_2";
            this.class62_2.Size = new System.Drawing.Size(47, 16);
            this.class62_2.TabIndex = 67;
            this.class62_2.Text = "Action:";
            // 
            // class63_0
            // 
            this.class63_0.AutoSize = true;
            this.class63_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_0.Boolean_0 = false;
            this.class63_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_0.Location = new System.Drawing.Point(197, 197);
            this.class63_0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class63_0.Name = "class63_0";
            this.class63_0.Size = new System.Drawing.Size(247, 16);
            this.class63_0.TabIndex = 66;
            this.class63_0.Text = "Specify the action that will occur when {0}";
            // 
            // panel_0
            // 
            this.panel_0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.panel_0.Location = new System.Drawing.Point(9, 213);
            this.panel_0.Margin = new System.Windows.Forms.Padding(0);
            this.panel_0.Name = "panel_0";
            this.panel_0.Size = new System.Drawing.Size(651, 493);
            this.panel_0.TabIndex = 2;
            // 
            // class62_3
            // 
            this.class62_3.AutoSize = true;
            this.class62_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class62_3.Boolean_0 = false;
            this.class62_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class62_3.Location = new System.Drawing.Point(13, 97);
            this.class62_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class62_3.Name = "class62_3";
            this.class62_3.Size = new System.Drawing.Size(44, 16);
            this.class62_3.TabIndex = 71;
            this.class62_3.Text = "Event:";
            // 
            // class63_1
            // 
            this.class63_1.AutoSize = true;
            this.class63_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class63_1.Boolean_0 = false;
            this.class63_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class63_1.Location = new System.Drawing.Point(197, 127);
            this.class63_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.class63_1.Name = "class63_1";
            this.class63_1.Size = new System.Drawing.Size(179, 16);
            this.class63_1.TabIndex = 70;
            this.class63_1.Text = "Select event type from the list";
            // 
            // class0_1
            // 
            this.class0_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.class0_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class0_1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.class0_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.class0_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.class0_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class0_1.FormattingEnabled = true;
            this.class0_1.Location = new System.Drawing.Point(200, 97);
            this.class0_1.Name = "class0_1";
            this.class0_1.Size = new System.Drawing.Size(454, 23);
            this.class0_1.TabIndex = 0;
            // 
            // class61_0
            // 
            this.class61_0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.class61_0.AutoSize = true;
            this.class61_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.class61_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.class61_0.Location = new System.Drawing.Point(16, 722);
            this.class61_0.Name = "class61_0";
            this.class61_0.Size = new System.Drawing.Size(77, 20);
            this.class61_0.TabIndex = 3;
            this.class61_0.Text = "Enabled";
            this.class61_0.UseVisualStyleBackColor = false;
            // 
            // gclass3_1
            // 
            this.gclass3_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gclass3_1.AutoSize = true;
            this.gclass3_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gclass3_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gclass3_1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gclass3_1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            this.gclass3_1.Location = new System.Drawing.Point(585, 127);
            this.gclass3_1.Name = "gclass3_1";
            this.gclass3_1.Size = new System.Drawing.Size(68, 16);
            this.gclass3_1.TabIndex = 72;
            this.gclass3_1.TabStop = true;
            this.gclass3_1.Text = "configure..";
            this.gclass3_1.Visible = false;
            this.gclass3_1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(135)))), ((int)(((byte)(200)))));
            // 
            // CustomActionAddEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.gclass3_1);
            this.Controls.Add(this.class61_0);
            this.Controls.Add(this.class0_1);
            this.Controls.Add(this.class62_3);
            this.Controls.Add(this.class63_1);
            this.Controls.Add(this.panel_0);
            this.Controls.Add(this.class0_0);
            this.Controls.Add(this.class62_2);
            this.Controls.Add(this.class63_0);
            this.Controls.Add(this.gclass3_0);
            this.Controls.Add(this.gcontrol0_0);
            this.Controls.Add(this.class66_1);
            this.Controls.Add(this.class66_0);
            this.Controls.Add(this.class62_1);
            this.Controls.Add(this.class62_0);
            this.Controls.Add(this.pictureBox_0);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomActionAddEditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "<caption placeholder>";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
