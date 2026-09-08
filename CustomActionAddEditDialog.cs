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
			form9_0.mbtnOK.Enabled = control4_0.Boolean_0;
		}
	}

	private sealed class Class14
	{
		public CustomActionAddEditDialog form9_0;

		public object object_0;

		public EventArgs3 eventArgs3_0;

		internal void method_0()
		{
			form9_0.LoadSettings(object_0, eventArgs3_0);
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
			OnButtonOk
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

	private PictureBox mimgBigIcon;

	private Class62 mlblSubCaption;

	private Class62 mlblCaption;

	private Class66 mbtnCancel;

	private Class66 mbtnOK;

	private GControl0 separatorLine1;

	private GClass3 mlnkOnlineHelp;

	private Class0 mcbAction;

	private Class62 mlblAction;

	private Class63 mlblActionHint;

	private Panel mpanel;

	private Class62 mlblEvent;

	private Class63 mlblEventHint;

	private Class0 mcbEvent;

	private Class61 mchbEnabled;

	private GClass3 mlnkConfigureEvent;

	public Class94 Class94_0
	{
		get
		{
			class94_0.class95_0 = dictionary_1[GEnum2_0];
			class94_0.gclass10_0 = Control4_0.GClass10_0;
			class94_0.bool_0 = mchbEnabled.Checked;
			return class94_0;
		}
		set
		{
			class94_0 = value;
			mcbEvent.Text = Class185.Class185_0[value.class95_0.GEnum2_0];
			mcbAction.Text = Class186.Class186_0[value.gclass10_0.GEnum3_0];
			mchbEnabled.Checked = value.bool_0;
			dictionary_1[value.class95_0.GEnum2_0] = value.class95_0;
			Control4_0.GClass10_0 = value.gclass10_0;
		}
	}

	private GEnum3 GEnum3_0
	{
		get
		{
			if (!string.IsNullOrEmpty(mcbAction.Text))
			{
				return Class186.Class186_0[mcbAction.Text];
			}
			return GEnum3.const_0;
		}
	}

	private Control4 Control4_0 => control4_0.Where(OnCheckedChanged).FirstOrDefault();

	private GEnum2 GEnum2_0 => Class185.Class185_0[mcbEvent.Text];

	public CustomActionAddEditDialog(Class94 class94_1)
		: base(new Size(685, 800))
	{
		OnTextChanged();
		InitializeFormPosition();
		OnButtonCancel();
		OnLoad();
		InitializeComponent();
		if (class94_1 == null)
		{
			Class94_0 = new Class94
			{
				class95_0 = new Class96(),
				gclass10_0 = new Class175()
			};
			Text = "Add New Custom Action";
			mlblCaption.Text = "New Custom Action";
			mlblSubCaption.Text = "Specify Custom Action properties and click Add new custom action";
			mbtnOK.Text = "Add new custom action";
			mimgBigIcon.Image = Resources.notifications_add_48;
			mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
			Control4_0.UpdateTaskType(GEnum2_0);
		}
		else
		{
			Class94_0 = class94_1;
			Text = "Edit Custom Action";
			mlblCaption.Text = "Edit Custom Action";
			mlblSubCaption.Text = "Edit Custom Action properties and click Save changes";
			mbtnOK.Text = "Save changes";
			mimgBigIcon.Image = Resources.notifications_edit_48;
			mlnkOnlineHelp.Click += gclass3_0_Click_1;
		}
	}

	private void InitializeComponent()
	{
		mcbEvent.Items.Clear();
		ComboBox.ObjectCollection items = mcbEvent.Items;
		object[] prop_ = Class185.Class185_0.Prop_1;
		object[] items2 = prop_;
		items.AddRange(items2);
		mcbEvent.SelectedIndex = 0;
	}

	private void OnButtonOk()
	{
		mcbAction.Items.Clear();
		ComboBox.ObjectCollection items = mcbAction.Items;
		GEnum3[] source = dictionary_0[GEnum2_0];
		Func<GEnum3, string> selector = _003C_003Ec._003C_003E9.method_0;
		object[] array = source.Select(selector).ToArray();
		object[] items2 = array;
		items.AddRange(items2);
		mcbAction.SelectedIndex = 0;
	}

	private void OnButtonCancel()
	{
		Control4[] array = control4_0;
		for (int i = 0; i < array.Length; i++)
		{
			Class13 @class = new Class13();
			@class.form9_0 = this;
			@class.control4_0 = array[i];
			@class.control4_0.GClass3_0.Click += OnSelectedIndexChanged;
			@class.control4_0.Event_1 += @class.method_0;
			@class.control4_0.Event_0 += method_21;
			@class.control4_0.Dock = DockStyle.Fill;
			@class.control4_0.Visible = false;
			mpanel.Controls.Add(@class.control4_0);
		}
	}

	private void OnLoad()
	{
		mcbEvent.SelectedIndexChanged += class0_1_SelectedIndexChanged;
		mlnkConfigureEvent.Click += mlnkConfigureEvent_Click;
		mcbAction.SelectedIndexChanged += class0_0_SelectedIndexChanged;
		mbtnCancel.Click += mbtnCancel_Click;
		mbtnOK.Click += mbtnOK_Click;
	}

	private void ValidateInput(bool bool_0)
	{
		mcbEvent.Enabled = bool_0;
		mcbAction.Enabled = bool_0;
		mbtnOK.Enabled = bool_0;
	}

	private void SaveSettings()
	{
		Class89.eventHandler_27 = (EventHandler<EventArgs3>)Delegate.Combine(Class89.eventHandler_27, new EventHandler<EventArgs3>(LoadSettings));
		Class89.smethod_36(Class94_0);
		Control4_0.SetEditMode(bool_1: false);
		ValidateInput(bool_0: false);
	}

	private void LoadSettings(object sender, EventArgs3 e)
	{
		Class14 @class = new Class14();
		@class.form9_0 = this;
		@class.object_0 = sender;
		@class.eventArgs3_0 = e;
		Class89.eventHandler_27 = (EventHandler<EventArgs3>)Delegate.Remove(Class89.eventHandler_27, new EventHandler<EventArgs3>(LoadSettings));
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
		Control4_0.SetEditMode(bool_1: true);
		ValidateInput(bool_0: true);
	}

	private static Class102 OnButtonOk(Class102 class102_0)
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

	private void OnTextChanged()
	{
		mimgBigIcon = new PictureBox();
		mlblSubCaption = new Class62();
		mlblCaption = new Class62();
		mbtnCancel = new Class66();
		mbtnOK = new Class66();
		separatorLine1 = new GControl0();
		mlnkOnlineHelp = new GClass3();
		mcbAction = new Class0();
		mlblAction = new Class62();
		mlblActionHint = new Class63();
		mpanel = new Panel();
		mlblEvent = new Class62();
		mlblEventHint = new Class63();
		mcbEvent = new Class0();
		mchbEnabled = new Class61();
		mlnkConfigureEvent = new GClass3();
		((ISupportInitialize)mimgBigIcon).BeginInit();
		SuspendLayout();
		mimgBigIcon.Location = new Point(16, 15);
		mimgBigIcon.Margin = new Padding(4);
		mimgBigIcon.Name = "m_imgBigIcon";
		mimgBigIcon.Size = new Size(48, 48);
		mimgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		mimgBigIcon.TabIndex = 0;
		mimgBigIcon.TabStop = false;
		mlblSubCaption.AutoSize = true;
		mlblSubCaption.Location = new Point(79, 47);
		mlblSubCaption.Margin = new Padding(4, 0, 4, 0);
		mlblSubCaption.Name = "m_lblSubCaption";
		mlblSubCaption.Size = new Size(163, 16);
		mlblSubCaption.TabIndex = 4;
		mlblSubCaption.Text = "<description placeholder>";
		mlblCaption.AutoSize = true;
		mlblCaption.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		mlblCaption.Location = new Point(79, 15);
		mlblCaption.Margin = new Padding(4, 0, 4, 0);
		mlblCaption.Name = "m_lblCaption";
		mlblCaption.Size = new Size(187, 16);
		mlblCaption.TabIndex = 14;
		mlblCaption.Text = "<subcaption placeholder>";
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(560, 713);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 5;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		mbtnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mbtnOK.Image = Resources.opts_16;
		mbtnOK.Location = new Point(275, 713);
		mbtnOK.Margin = new Padding(4);
		mbtnOK.Name = "m_btnOK";
		mbtnOK.Size = new Size(277, 36);
		mbtnOK.TabIndex = 4;
		mbtnOK.Text = "<ok_button>";
		mbtnOK.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnOK.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 73);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(638, 10);
		separatorLine1.TabIndex = 35;
		separatorLine1.TabStop = false;
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(584, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 6;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		mcbAction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbAction.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbAction.FormattingEnabled = true;
		mcbAction.Location = new Point(200, 167);
		mcbAction.Name = "m_cbAction";
		mcbAction.Size = new Size(454, 24);
		mcbAction.TabIndex = 1;
		mlblAction.AutoSize = true;
		mlblAction.Location = new Point(13, 167);
		mlblAction.Margin = new Padding(4, 0, 4, 0);
		mlblAction.Name = "m_lblAction";
		mlblAction.Size = new Size(48, 16);
		mlblAction.TabIndex = 67;
		mlblAction.Text = "Action:";
		mlblActionHint.AutoSize = true;
		mlblActionHint.ForeColor = SystemColors.ControlDarkDark;
		mlblActionHint.Location = new Point(197, 197);
		mlblActionHint.Margin = new Padding(4, 0, 4, 0);
		mlblActionHint.Name = "m_lblActionHint";
		mlblActionHint.Size = new Size(248, 16);
		mlblActionHint.TabIndex = 66;
		mlblActionHint.Text = "Specify the action that will occur when {0}";
		mpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mpanel.Location = new Point(9, 213);
		mpanel.Margin = new Padding(0);
		mpanel.Name = "m_panel";
		mpanel.Size = new Size(651, 493);
		mpanel.TabIndex = 2;
		mlblEvent.AutoSize = true;
		mlblEvent.Location = new Point(13, 97);
		mlblEvent.Margin = new Padding(4, 0, 4, 0);
		mlblEvent.Name = "m_lblEvent";
		mlblEvent.Size = new Size(45, 16);
		mlblEvent.TabIndex = 71;
		mlblEvent.Text = "Event:";
		mlblEventHint.AutoSize = true;
		mlblEventHint.ForeColor = SystemColors.ControlDarkDark;
		mlblEventHint.Location = new Point(197, 127);
		mlblEventHint.Margin = new Padding(4, 0, 4, 0);
		mlblEventHint.Name = "m_lblEventHint";
		mlblEventHint.Size = new Size(180, 16);
		mlblEventHint.TabIndex = 70;
		mlblEventHint.Text = "Select event type from the list";
		mcbEvent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		mcbEvent.DropDownStyle = ComboBoxStyle.DropDownList;
		mcbEvent.FormattingEnabled = true;
		mcbEvent.Location = new Point(200, 97);
		mcbEvent.Name = "m_cbEvent";
		mcbEvent.Size = new Size(454, 24);
		mcbEvent.TabIndex = 0;
		mchbEnabled.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mchbEnabled.AutoSize = true;
		mchbEnabled.Location = new Point(16, 722);
		mchbEnabled.Name = "m_chbEnabled";
		mchbEnabled.Size = new Size(78, 20);
		mchbEnabled.TabIndex = 3;
		mchbEnabled.Text = "Enabled";
		mchbEnabled.UseVisualStyleBackColor = true;
		mlnkConfigureEvent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkConfigureEvent.AutoSize = true;
		mlnkConfigureEvent.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkConfigureEvent.Location = new Point(585, 127);
		mlnkConfigureEvent.Name = "m_lnkConfigureEvent";
		mlnkConfigureEvent.Size = new Size(69, 16);
		mlnkConfigureEvent.TabIndex = 72;
		mlnkConfigureEvent.TabStop = true;
		mlnkConfigureEvent.Text = "configure..";
		mlnkConfigureEvent.Visible = false;
		mlnkConfigureEvent.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(669, 762);
		base.Controls.Add(mlnkConfigureEvent);
		base.Controls.Add(mchbEnabled);
		base.Controls.Add(mcbEvent);
		base.Controls.Add(mlblEvent);
		base.Controls.Add(mlblEventHint);
		base.Controls.Add(mpanel);
		base.Controls.Add(mcbAction);
		base.Controls.Add(mlblAction);
		base.Controls.Add(mlblActionHint);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(mbtnOK);
		base.Controls.Add(mbtnCancel);
		base.Controls.Add(mlblCaption);
		base.Controls.Add(mlblSubCaption);
		base.Controls.Add(mimgBigIcon);
		Font = new Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new Padding(4);
		base.Name = "CustomActionAddEditDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "<caption placeholder>";
		((ISupportInitialize)mimgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private bool OnCheckedChanged(Control4 control4_1)
	{
		return control4_1.GClass10_0.GEnum3_0 == GEnum3_0;
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class153.String_1);
	}

	private void gclass3_0_Click_1(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class153.String_2);
	}

	private void OnSelectedIndexChanged(object sender, EventArgs e)
	{
		SaveSettings();
	}

	private void method_21(object sender, EventArgs e)
	{
		mbtnOK.PerformClick();
	}

	private void class0_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		OnButtonOk();
		mlblActionHint.Text = "Specify the action that will occur when " + mcbEvent.Text;
		Control4_0.UpdateTaskType(GEnum2_0);
		mlnkConfigureEvent.Visible = dictionary_1[GEnum2_0].class102_0.Boolean_0;
	}

	private void mlnkConfigureEvent_Click(object sender, EventArgs e)
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
		int num = base.Width - mpanel.Width + control.Size_0.Width;
		int num2 = base.Height - mpanel.Height + control.Size_0.Height;
		MinimumSize = new Size(num, num2);
		base.Height = num2;
		mbtnOK.Enabled = control.Boolean_0;
		control.UpdateTaskType(GEnum2_0);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}

	private void mbtnOK_Click(object sender, EventArgs e)
	{
		if (Control4_0.ValidateInput())
		{
			CloseDialog(DialogResult.OK);
		}
	}
}
