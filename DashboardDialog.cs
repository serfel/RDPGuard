using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class DashboardDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static EventHandler<EventArgs> _003C_003E9__12_0;

		public static EventHandler _003C_003E9__14_12;

		public static Func<ToolStripItem, bool> _003C_003E9__37_0;

		public static EventHandler _003C_003E9__77_2;

		internal void method_0(object sender, EventArgs e)
		{
			Class89.smethod_17();
			Class89.smethod_9();
			Class89.smethod_8();
			Class89.smethod_16();
			Class89.smethod_38();
		}

		internal void method_1(object sender, EventArgs e)
		{
			Class10.smethod_7();
		}

		internal bool method_2(ToolStripItem toolStripItem_0)
		{
			return "Advanced.." == toolStripItem_0.Text;
		}

		internal void method_3(object sender, EventArgs e)
		{
			Class89.smethod_30(Class10.GEnum16_0);
		}
	}

	private sealed class Class26
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs7 eventArgs7_0;

		internal void method_0()
		{
			form32_0.SaveSettings(object_0, eventArgs7_0);
		}
	}

	private sealed class Class27
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs7 eventArgs7_0;

		internal void method_0()
		{
			form32_0.OnTextChanged(object_0, eventArgs7_0);
		}
	}

	private sealed class Class28
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs12 eventArgs12_0;

		internal void method_0()
		{
			form32_0.method_25(object_0, eventArgs12_0);
		}
	}

	private sealed class Class29
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs11 eventArgs11_0;

		internal void method_0()
		{
			form32_0.method_26(object_0, eventArgs11_0);
		}
	}

	private sealed class Class30
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs14 eventArgs14_0;

		internal void method_0()
		{
			form32_0.method_27(object_0, eventArgs14_0);
		}
	}

	private sealed class Class31
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs1 eventArgs1_0;

		internal void method_0()
		{
			form32_0.method_28(object_0, eventArgs1_0);
		}
	}

	private sealed class Class32
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs1 eventArgs1_0;

		internal void method_0()
		{
			form32_0.method_29(object_0, eventArgs1_0);
		}
	}

	private sealed class Class33
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs1 eventArgs1_0;

		internal void method_0()
		{
			form32_0.method_30(object_0, eventArgs1_0);
		}
	}

	private sealed class Class34
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs13 eventArgs13_0;

		internal void method_0()
		{
			form32_0.method_32(object_0, eventArgs13_0);
		}
	}

	private sealed class Class35
	{
		public DashboardDialog form32_0;

		public object object_0;

		public EventArgs eventArgs_0;

		internal void method_0()
		{
			form32_0.method_33(object_0, eventArgs_0);
		}
	}

	private sealed class Class36
	{
		public Class169 class169_0;

		public DashboardDialog form32_0;

		internal void method_0()
		{
			if (class169_0 != form32_0.class164_0.Class169_0)
			{
				Class89.smethod_41();
				Class89.eventHandler_17 = (EventHandler)Delegate.Combine(Class89.eventHandler_17, new EventHandler(form32_0.method_39));
				Class89.smethod_30(GEnum16.const_3);
			}
			else
			{
				form32_0.class85_0.method_3();
			}
		}
	}

	private sealed class Class37
	{
		public Action action_0;

		internal void method_0(object sender, EventArgs13 e)
		{
			Class89.eventHandler_13 = null;
			action_0();
		}
	}

	private sealed class Class38
	{
		public Class90 class90_0;

		public GClass24 gclass24_0;

		public DashboardDialog form32_0;

		internal void method_0(object sender, EventArgs e)
		{
			Class89.smethod_29(new Class90[1] { class90_0 });
		}

		internal void method_1(object sender, EventArgs e)
		{
			Class89.smethod_29(new Class90[1] { class90_0 });
			Class89.smethod_25(gclass24_0);
		}

		internal void method_2(object sender, EventArgs e)
		{
			Class89.smethod_29(new Class90[1] { class90_0 });
			Class89.smethod_28(gclass24_0);
		}

		internal void method_3(object sender, EventArgs e)
		{
			Class77.smethod_0(gclass24_0.method_6());
		}

		internal void method_4(object sender, EventArgs e)
		{
			form32_0.ShowOnlineHelp(Class148.smethod_0(gclass24_0.method_6()));
		}
	}

	private Class79 class79_0;

	private NotifyIcon notifyIcon_0;

	private readonly Class85 class85_0 = new Class85();

	private readonly Class86 class86_0 = new Class86();

	private EventLogDialog form31_0;

	private bool bool_0;

	private Class164 class164_0;

	private Class78 class78_0;

	private IContainer icontainer_0;

	private StatusStrip statusBar;

	private ToolStripStatusLabel toolStripCurrentStatus;

	private MenuStrip mainMenu;

	private ToolStripMenuItem mainMenuFile;

	private ToolStripSeparator toolStripSeparator4;

	private ToolStripMenuItem mainMenuFileExit;

	private ToolStripMenuItem mainMenuView;

	private ToolStripMenuItem mainMenuViewShowStatusbar;

	private ToolStripMenuItem mainMenuViewShowEventLog;

	private ToolStripMenuItem mainMenuTools;

	private ToolStripMenuItem mainMenuToolsRdpGuardService;

	private ToolStripMenuItem mainMenuToolsRdpGuardServiceStart;

	private ToolStripMenuItem mainMenuToolsRdpGuardServiceStop;

	private ToolStripMenuItem mainMenuToolsRdpGuardServiceRestart;

	private ToolStripSeparator toolStripSeparator3;

	private ToolStripMenuItem mainMenuToolsDiagnostic;

	private ToolStripMenuItem mainMenuToolsOptions;

	private ToolStripMenuItem mainMenuHelp;

	private ToolStripMenuItem mainMenuHelpOnlineHelp;

	private ToolStripMenuItem mainMenuHelpContactUs;

	private ToolStripMenuItem mainMenuHelpCheckNewVersion;

	private ToolStripSeparator mainMenuHelpSeparator1;

	private ToolStripMenuItem mainMenuHelpBuyPro;

	private ToolStripMenuItem mmainMenuHelpProductActivation;

	private ToolStripSeparator mainMenuHelpSeparator2;

	private ToolStripMenuItem mainMenuHelpAbout;

	private ToolStripMenuItem mmainMenuToolsWhitelist;

	private ToolStripMenuItem mainMenuToolsUnblockAllIPAddresses;

	private ToolStripMenuItem mainMenuToolsFindIPAddress;

	private ToolStripSeparator toolStripSeparator2;

	private ToolStripMenuItem mainMenuToolsCustomActions;

	private ToolStripMenuItem mmainMenuToolsBlacklist;

	private ToolStripSeparator toolStripSeparator5;

	private ToolStripSeparator toolStripSeparator6;

	private NotifyIcon NotifyIcon_0
	{
		get
		{
			if (notifyIcon_0 == null)
			{
				notifyIcon_0 = new NotifyIcon
				{
					Icon = base.Icon,
					Text = "RdpGuard",
					ContextMenuStrip = new Class57
					{
						ToolStripItem_0 = new ToolStripItem[2]
						{
							new Class56
							{
								Text = "Show/Hide",
								Image = Resources.hd_16,
								ShortcutKeys = (Keys.M | Keys.Control),
								eventHandler_0 = method_79
							},
							new Class56
							{
								Text = "Exit",
								Image = Resources.exit_16,
								ShortcutKeys = (Keys.Q | Keys.Control),
								eventHandler_0 = method_80
							}
						}
					}
				};
				notifyIcon_0.MouseClick += notifyIcon_0_MouseClick;
			}
			return notifyIcon_0;
		}
	}

	public DashboardDialog()
		: base(new Size(600, 700))
	{
		base.Controls.Add(method_44());
		InitializeComponent();
		InitializeFormPosition();
		OnButtonOk();
		OnButtonCancel();
	}

	protected override void WndProc(ref Message message_0)
	{
		if (message_0.Msg == Class76.int_0)
		{
			Show();
			Class181.SetForegroundWindow(base.Handle);
			base.WindowState = FormWindowState.Normal;
		}
		base.WndProc(ref message_0);
	}

	private void InitializeComponent()
	{
		EventHandler<EventArgs> eventHandler_ = Class89.eventHandler_0;
		EventHandler<EventArgs> b = _003C_003Ec._003C_003E9.method_0;
		Class89.eventHandler_0 = (EventHandler<EventArgs>)Delegate.Combine(eventHandler_, b);
		Class89.eventHandler_14 = (EventHandler<EventArgs1>)Delegate.Combine(Class89.eventHandler_14, new EventHandler<EventArgs1>(method_30));
		Class89.eventHandler_15 = (EventHandler<EventArgs1>)Delegate.Combine(Class89.eventHandler_15, new EventHandler<EventArgs1>(method_28));
		Class89.eventHandler_16 = (EventHandler<EventArgs1>)Delegate.Combine(Class89.eventHandler_16, new EventHandler<EventArgs1>(method_29));
		Class89.eventHandler_1 = (EventHandler<EventArgs12>)Delegate.Combine(Class89.eventHandler_1, new EventHandler<EventArgs12>(method_25));
		Class89.eventHandler_2 = (EventHandler<EventArgs14>)Delegate.Combine(Class89.eventHandler_2, new EventHandler<EventArgs14>(method_27));
		Class89.eventHandler_6 = (EventHandler<EventArgs11>)Delegate.Combine(Class89.eventHandler_6, new EventHandler<EventArgs11>(method_26));
		Class89.eventHandler_12 = (EventHandler<EventArgs13>)Delegate.Combine(Class89.eventHandler_12, new EventHandler<EventArgs13>(method_32));
		Class89.eventHandler_29 = (EventHandler<EventArgs>)Delegate.Combine(Class89.eventHandler_29, new EventHandler<EventArgs>(method_33));
		Class89.smethod_2();
	}

	private void OnButtonOk()
	{
		Text = Class138.String_1;
		form31_0 = new EventLogDialog();
		Class10.smethod_1(class79_0);
		class78_0 = new Class78
		{
			Interval = 1000,
			eventHandler_0 = method_81
		};
		class78_0.Start();
		method_41();
		method_77();
	}

	private void OnButtonCancel()
	{
		base.Shown += Form32_Shown;
		class79_0.DocumentCompleted += class79_0_DocumentCompleted;
		mainMenuTools.DropDownOpening += toolStripMenuItem_5_DropDownOpening;
		mainMenuToolsRdpGuardService.DropDownOpening += toolStripMenuItem_6_DropDownOpening;
		toolStripCurrentStatus.Click += toolStripCurrentStatus_Click;
		base.FormClosing += Form32_FormClosing;
		base.Resize += Form32_Resize;
		mainMenuFileExit.Click += mainMenuFileExit_Click;
		mainMenuViewShowStatusbar.Click += mainMenuViewShowStatusbar_Click;
		mainMenuViewShowEventLog.Click += mainMenuViewShowEventLog_Click;
		mmainMenuToolsWhitelist.Click += mmainMenuToolsWhitelist_Click;
		mmainMenuToolsBlacklist.Click += mmainMenuToolsBlacklist_Click;
		mainMenuToolsUnblockAllIPAddresses.Click += mainMenuToolsUnblockAllIPAddresses_Click;
		ToolStripMenuItem toolStripMenuItem = mainMenuToolsFindIPAddress;
		EventHandler value = _003C_003Ec._003C_003E9.method_1;
		toolStripMenuItem.Click += value;
		mainMenuToolsCustomActions.Click += mainMenuToolsCustomActions_Click;
		mainMenuToolsDiagnostic.Click += mainMenuToolsDiagnostic_Click;
		mainMenuToolsOptions.Click += mainMenuToolsOptions_Click;
		mainMenuToolsRdpGuardServiceStart.Click += mainMenuToolsRdpGuardServiceStart_Click;
		mainMenuToolsRdpGuardServiceStop.Click += mainMenuToolsRdpGuardServiceStop_Click;
		mainMenuToolsRdpGuardServiceRestart.Click += mainMenuToolsRdpGuardServiceRestart_Click;
		mainMenuHelpOnlineHelp.Click += mainMenuHelpOnlineHelp_Click;
		mainMenuHelpContactUs.Click += mainMenuHelpContactUs_Click;
		mainMenuHelpCheckNewVersion.Click += mainMenuHelpCheckNewVersion_Click;
		mainMenuHelpBuyPro.Click += mainMenuHelpBuyPro_Click;
		mmainMenuHelpProductActivation.Click += mmainMenuHelpProductActivation_Click;
		mainMenuHelpAbout.Click += mainMenuHelpAbout_Click;
	}

	private void OnLoad()
	{
		if (!method_21())
		{
			return;
		}
		LicenseActivatationDialog form = new LicenseActivatationDialog();
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				Class89.smethod_8();
			}
		}
	}

	private void ValidateInput()
	{
		if (method_21() ? true : false)
		{
			Class89.eventHandler_18 = (EventHandler<EventArgs7>)Delegate.Combine(Class89.eventHandler_18, new EventHandler<EventArgs7>(SaveSettings));
			Class89.smethod_23();
		}
	}

	private void SaveSettings(object sender, EventArgs7 e)
	{
		Class26 @class = new Class26();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs7_0 = e;
		Class89.eventHandler_18 = (EventHandler<EventArgs7>)Delegate.Remove(Class89.eventHandler_18, new EventHandler<EventArgs7>(SaveSettings));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		IPListDialog form = new IPListDialog(@class.eventArgs7_0.iplistEntry_0)
		{
			Image_0 = Resources.whitelist_48,
			Image_1 = Resources.whitelist_add_48,
			Image_2 = Resources.whitelist_edit_48,
			String_0 = "RdpGuard Whitelist",
			String_1 = "Whitelist",
			String_2 = "A list of known safe IP addresses. RdpGuard will never block these addresses."
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				Class89.smethod_24(form.IPListEntry_0);
			}
		}
	}

	private void LoadSettings()
	{
		if (method_21() ? true : false)
		{
			Class89.eventHandler_20 = (EventHandler<EventArgs7>)Delegate.Combine(Class89.eventHandler_20, new EventHandler<EventArgs7>(OnTextChanged));
			Class89.smethod_26();
		}
	}

	private void OnTextChanged(object sender, EventArgs7 e)
	{
		Class27 @class = new Class27();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs7_0 = e;
		Class89.eventHandler_20 = (EventHandler<EventArgs7>)Delegate.Remove(Class89.eventHandler_20, new EventHandler<EventArgs7>(OnTextChanged));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		IPListDialog form = new IPListDialog(@class.eventArgs7_0.iplistEntry_0)
		{
			Image_0 = Resources.blacklist_48,
			Image_1 = Resources.blacklist_add_48,
			Image_2 = Resources.blacklist_edit_48,
			String_0 = "RdpGuard Blacklist",
			String_1 = "Blacklist",
			String_2 = "A list of permanently blocked IP addresses. RdpGuard will never unblock these addresses."
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				Class89.smethod_27(form.IPListEntry_0);
			}
		}
	}

	private void OnCheckedChanged()
	{
		if (method_21() && DialogResult.Yes == MessageBox.Show("Are you sure you want to unblock all IP addresses?", Class138.String_1, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
		{
			Class89.eventHandler_17 = (EventHandler)Delegate.Combine(Class89.eventHandler_17, new EventHandler(OnSelectedIndexChanged));
			Class89.smethod_30(GEnum16.const_3);
		}
	}

	private void OnSelectedIndexChanged(object sender, EventArgs e)
	{
		Class89.eventHandler_17 = (EventHandler)Delegate.Remove(Class89.eventHandler_17, new EventHandler(OnSelectedIndexChanged));
		Class89.smethod_9();
	}

	private bool method_21()
	{
		if (class85_0.Boolean_2)
		{
			class85_0.method_1();
		}
		class85_0.method_0();
		if (!class85_0.Boolean_1)
		{
			MessageBox.Show("Unable to start RdpGuard Service.", Class138.String_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		return class85_0.Boolean_1;
	}

	private void method_22()
	{
		method_23();
		method_24();
	}

	private void method_23()
	{
		if (class85_0.Boolean_1)
		{
			class79_0.method_4("service_status_pic", "green_ball");
		}
		else if (class85_0.Boolean_2)
		{
			class79_0.method_4("service_status_pic", "red_ball");
		}
		else
		{
			class79_0.method_4("service_status_pic", "yellow_ball");
		}
		class79_0.method_0("service_status", (class85_0.Boolean_0 ? true : false) ? class85_0.ServiceControllerStatus_0.ToString() : "Not Installed");
		class79_0.method_2("install_service_link", !class85_0.Boolean_0);
		if (class85_0.Boolean_1)
		{
			class79_0.method_2("protection_status_enabled", bool_0: true);
			class79_0.method_2("protection_status_disabled", bool_0: false);
		}
		else if (class85_0.Boolean_2)
		{
			class79_0.method_2("protection_status_enabled", bool_0: false);
			class79_0.method_2("protection_status_disabled", bool_0: true);
			class79_0.method_2("start_service_link", class85_0.Boolean_0);
		}
		else
		{
			class79_0.method_2("protection_status_enabled", bool_0: false);
			class79_0.method_2("protection_status_disabled", bool_0: false);
		}
		class79_0.method_2("wfp_status_container", class85_0.Boolean_1);
		class79_0.method_2("monitoring_container", class85_0.Boolean_1);
		class79_0.method_2("ip_source_bar", class85_0.Boolean_1);
		class79_0.method_2("blocked_ips_container", class85_0.Boolean_1);
	}

	private void method_24()
	{
		class79_0.method_2("eventlog_service", class86_0.Boolean_2);
	}

	private void method_25(object sender, EventArgs12 e)
	{
		Class28 @class = new Class28();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs12_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			toolStripCurrentStatus.Text = ((@class.eventArgs12_0.class157_0.Any() ? true : false) ? @class.eventArgs12_0.class157_0.Last().ToString().Replace("\r\n", "") : string.Empty);
		}
	}

	private void method_26(object sender, EventArgs11 e)
	{
		Class29 @class = new Class29();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs11_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else if (@class.eventArgs11_0.class146_0.Boolean_0)
		{
			class79_0.method_2("trial_info", bool_0: false);
			class79_0.method_2("maintenance_expiration_box", bool_0: false);
			method_40("Registered Version");
		}
	}

	private void method_27(object sender, EventArgs14 e)
	{
		Class30 @class = new Class30();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs14_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		class79_0.method_0("new_version_number", @class.eventArgs14_0.version_0.ToString(3));
		class79_0.method_2("new_version_box", bool_0: true);
	}

	private void method_28(object sender, EventArgs1 e)
	{
		Class31 @class = new Class31();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs1_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			Class10.smethod_3(@class.eventArgs1_0.class90_0);
		}
	}

	private void method_29(object sender, EventArgs1 e)
	{
		Class32 @class = new Class32();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs1_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			Class10.smethod_4(@class.eventArgs1_0.class90_0);
		}
	}

	private void method_30(object sender, EventArgs1 e)
	{
		Class33 @class = new Class33();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs1_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			Class10.smethod_2(@class.eventArgs1_0.class90_0);
		}
	}

	private void method_31(Class164 class164_1)
	{
		class79_0.method_2("monitoring_container", bool_0: true);
		int[] prop_ = Class189.Class189_0.Prop_0;
		int[] array = prop_;
		foreach (int int_ in array)
		{
			Class113 @class = class164_1.method_6(int_);
			string text = Regex.Replace(@class.String_0, "[^a-zA-Z0-9]", string.Empty).ToLowerInvariant();
			class79_0.method_4("proto_status_pic_" + text, (@class.bool_0 ? true : false) ? "green_ball" : "gray_ball");
			class79_0.method_0("lnk_" + text + "_status", (@class.bool_0 ? true : false) ? "Enabled" : "Disabled");
		}
	}

	private void method_32(object sender, EventArgs13 e)
	{
		Class34 @class = new Class34();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs13_0 = e;
		class164_0 = @class.eventArgs13_0.class164_0;
		Class10.class164_0 = @class.eventArgs13_0.class164_0;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			method_31(class164_0);
		}
	}

	private void method_33(object sender, EventArgs e)
	{
		Class35 @class = new Class35();
		@class.form32_0 = this;
		@class.object_0 = sender;
		@class.eventArgs_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		Class163.Class163_0.method_6();
		method_41();
	}

	private void method_34(bool bool_1)
	{
		mainMenuViewShowEventLog.Checked = bool_1;
		if (bool_1)
		{
			if (form31_0 == null)
			{
				form31_0 = new EventLogDialog();
			}
			form31_0.method_1();
			form31_0.Visible = true;
			form31_0.FormClosing += form31_0_FormClosing;
		}
		else if (form31_0 != null)
		{
			form31_0.Visible = false;
		}
	}

	private void method_35(bool bool_1)
	{
		statusBar.Visible = bool_1;
		mainMenuViewShowStatusbar.Checked = bool_1;
	}

	private void method_36()
	{
		IEnumerable<ToolStripItem> source = mainMenuTools.DropDownItems.Cast<ToolStripItem>();
		Func<ToolStripItem, bool> predicate = _003C_003Ec._003C_003E9.method_2;
		ToolStripItem toolStripItem = source.FirstOrDefault(predicate);
		if (Keys.Control != (Control.ModifierKeys & Keys.Control))
		{
			if (toolStripItem != null)
			{
				mainMenuTools.DropDownItems.Remove(toolStripItem);
				mainMenuTools.DropDownItems.RemoveByKey("f046f3008a71");
			}
		}
		else if (toolStripItem == null)
		{
			mainMenuTools.DropDownItems.Add(new ToolStripSeparator
			{
				Name = "f046f3008a71"
			});
			ToolStripItemCollection dropDownItems = mainMenuTools.DropDownItems;
			Class56 @class = new Class56
			{
				Text = "Advanced..",
				Image = Resources.confg_16
			};
			ToolStripItem[] array = new Class56[3]
			{
				new Class56
				{
					Text = "Set recommended Audit Settings",
					Image = Resources.whitelist_16,
					eventHandler_0 = method_82
				},
				new Class56
				{
					Text = "Reset BFE Entries",
					Image = Resources.regedit_16,
					eventHandler_0 = method_83
				},
				new Class56
				{
					Text = "Reset Registration",
					Image = Resources.key_16,
					eventHandler_0 = method_84
				}
			};
			ToolStripItem[] toolStripItem_ = array;
			@class.ToolStripItem_0 = toolStripItem_;
			dropDownItems.Add(@class);
		}
	}

	private void method_37()
	{
		mainMenuToolsRdpGuardServiceStart.Enabled = class85_0.Boolean_2;
		mainMenuToolsRdpGuardServiceStop.Enabled = class85_0.Boolean_1;
	}

	private void OnButtonOk()
	{
		Class36 @class = new Class36();
		@class.form32_0 = this;
		if (method_21() ? true : false)
		{
			while (class164_0 == null)
			{
				Thread.Sleep(100);
			}
			@class.class169_0 = class164_0.Class169_0;
			OptionsDialog form = new OptionsDialog(class164_0);
			if (DialogResult.OK == form.ShowDialog())
			{
				method_56(@class.method_0);
				NotifyIcon_0.Visible = Class163.Class163_0.class166_2.Boolean_0;
			}
		}
	}

	private void method_39(object sender, EventArgs e)
	{
		Class89.eventHandler_17 = (EventHandler)Delegate.Remove(Class89.eventHandler_17, new EventHandler(method_39));
		class85_0.method_3();
	}

	private void method_40(string string_0)
	{
		Text = Class138.String_1 + " " + string_0;
		method_0();
	}

	private void method_41()
	{
		method_35(Class163.Class163_0.class166_1.Boolean_0);
		method_34(Class163.Class163_0.class166_0.Boolean_0);
		NotifyIcon_0.Visible = Class163.Class163_0.class166_2.Boolean_0;
	}

	private void method_42()
	{
		bool_0 = true;
		Close();
	}

	private void method_43()
	{
		if (base.WindowState == FormWindowState.Normal)
		{
			if (Class163.Class163_0.class166_3.Boolean_0)
			{
				Hide();
			}
			base.WindowState = FormWindowState.Minimized;
			method_34(bool_1: false);
			return;
		}
		Show();
		Class181.SetForegroundWindow(base.Handle);
		base.WindowState = FormWindowState.Normal;
		if (NotifyIcon_0.Visible && !Class163.Class163_0.class166_2.Boolean_0)
		{
			NotifyIcon_0.Visible = false;
		}
		if (Class163.Class163_0.class166_0.Boolean_0)
		{
			method_34(bool_1: true);
		}
	}

	private Class79 method_44()
	{
		string newValue = Resources.Common_Style + ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.Common_Style_Dark : Resources.Common_Style_Light) + Resources.DashboardDialog_Style + ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.DashboardDialog_Style_Dark : Resources.DashboardDialog_Style_Light);
		string string_ = Resources.DashboardDialog.Replace("/*CSS*/", newValue);
		class79_0 = new Class79(string_)
		{
			AllowNavigation = false
		};
		return class79_0;
	}

	private void class79_0_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
		class79_0.Document.MouseUp -= ValidateInput;
		class79_0.Document.MouseUp += ValidateInput;
		class79_0.PreviewKeyDown -= class79_0_PreviewKeyDown;
		class79_0.PreviewKeyDown += class79_0_PreviewKeyDown;
		class79_0.method_6(new Dictionary<string, HtmlElementEventHandler>
		{
			{ "get_trial_link", method_45 },
			{ "enter_license_link", method_46 },
			{ "start_service_link", method_47 },
			{ "install_service_link", method_48 },
			{ "select_blocking_method", method_54 },
			{ "new_version_link", method_49 },
			{ "license_expired_link", method_51 },
			{ "edit_filter_link", method_52 },
			{ "reset_filter_link", method_53 },
			{ "edit_filter_link2", method_52 },
			{ "lnk_rdp_status", OnButtonOk },
			{ "lnk_ftp_status", OnButtonOk },
			{ "lnk_http_status", OnButtonOk },
			{ "lnk_smtp_status", OnButtonOk },
			{ "lnk_imap_status", OnButtonOk },
			{ "lnk_pop3_status", OnButtonOk },
			{ "lnk_mysql_status", OnButtonOk },
			{ "lnk_mssql_status", OnButtonOk },
			{ "lnk_sip_status", OnButtonOk },
			{ "lnk_openssh_status", method_66 },
			{ "lnk_aspnetwebforms_status", OnButtonOk },
			{ "lnk_rdweb_status", OnButtonOk },
			{ "lnk_msvpn_status", method_69 },
			{ "local_ips_switcher", method_70 },
			{ "cloud_ips_switcher", method_71 },
			{ "geoip_ips_switcher", method_72 },
			{ "all_ips_switcher", method_73 }
		});
		class79_0.CloseDialog(new Dictionary<string, HtmlElementEventHandler> { { "new_version_box", method_50 } });
	}

	private void method_45(object sender, HtmlElementEventArgs e)
	{
		ShowOnlineHelp(Class148.Class150.smethod_0("main"));
	}

	private void method_46(object sender, HtmlElementEventArgs e)
	{
		OnLoad();
	}

	private void method_47(object sender, HtmlElementEventArgs e)
	{
		class85_0.method_1();
	}

	private void method_48(object sender, HtmlElementEventArgs e)
	{
		class85_0.method_4();
	}

	private void method_49(object sender, HtmlElementEventArgs e)
	{
		ShowOnlineHelp(Class148.Class149.String_0);
	}

	private void method_50(object sender, HtmlElementEventArgs e)
	{
		if (MouseButtons.Right == e.MouseButtonsPressed)
		{
			Class57 @class = new Class57();
			@class.ToolStripItem_0 = new ToolStripItem[1]
			{
				new Class56
				{
					Text = "Dismiss..",
					Image = Resources.unblock_16,
					eventHandler_0 = method_85
				}
			};
			@class.Show(class79_0, e.MousePosition);
		}
	}

	private void method_51(object sender, HtmlElementEventArgs e)
	{
		ShowOnlineHelp(Class148.Class150.String_1);
	}

	private void method_52(object sender, HtmlElementEventArgs e)
	{
		Class10.smethod_7();
	}

	private void method_53(object sender, HtmlElementEventArgs e)
	{
		Class10.smethod_8();
	}

	private void method_54(object sender, HtmlElementEventArgs e)
	{
		OnButtonOk();
	}

	private void method_55()
	{
		method_56(method_86);
	}

	private void method_56(Action action_0)
	{
		Class89.eventHandler_13 = new Class37
		{
			action_0 = action_0
		}.method_0;
		Class89.smethod_18(class164_0);
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		RdpSettingsDialog form = new RdpSettingsDialog
		{
			Class122_0 = class164_0.Class122_0
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				class164_0.Class122_0 = form.Class122_0;
				method_55();
			}
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		FtpSettingsDialog form = new FtpSettingsDialog(class164_0.Class114_0);
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				class164_0.Class114_0 = form.Class114_0;
				method_55();
			}
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		HttpSettingsDialog form = new HttpSettingsDialog(class164_0.Class115_0);
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				class164_0.Class115_0 = form.Class115_0;
				method_55();
			}
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		SmtpSettingsDialog form = new SmtpSettingsDialog(class164_0.Class125_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			class164_0.Class125_0 = form.Class125_0;
			method_55();
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		ImapSettingsDialog form = new ImapSettingsDialog(class164_0.Class116_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			class164_0.Class116_0 = form.Class116_0;
			method_55();
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		Pop3SettingsDialog form = new Pop3SettingsDialog(class164_0.Class121_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			class164_0.Class121_0 = form.Class121_0;
			method_55();
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		MySqlSettingsDialog form = new MySqlSettingsDialog(class164_0.Class119_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			class164_0.Class119_0 = form.Class119_0;
			method_55();
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		MsSqlSettingsDialog form = new MsSqlSettingsDialog(class164_0.Class117_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			class164_0.Class117_0 = form.Class117_0;
			method_55();
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		SipSettingsDialog form = new SipSettingsDialog(class164_0.Class124_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			class164_0.Class124_0 = form.Class124_0;
			method_55();
		}
	}

	private void method_66(object sender, HtmlElementEventArgs e)
	{
		class164_0.Class120_0 = new Class120
		{
			bool_0 = !class164_0.Class120_0.bool_0
		};
		method_55();
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		using WebFormsSettingsDialog form = new WebFormsSettingsDialog(class164_0.Class126_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			class164_0.Class126_0 = form.Class126_0;
			method_55();
		}
	}

	private void OnButtonOk(object sender, HtmlElementEventArgs e)
	{
		RDWebSettingsDialog form = new RDWebSettingsDialog(class164_0.Class123_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			class164_0.Class123_0 = form.Class123_0;
			method_55();
		}
	}

	private void method_69(object sender, HtmlElementEventArgs e)
	{
		class164_0.Class118_0 = new Class118
		{
			bool_0 = !class164_0.Class118_0.bool_0
		};
		method_55();
	}

	private void method_70(object sender, HtmlElementEventArgs e)
	{
		Class10.smethod_6(GEnum16.const_0);
		method_74();
	}

	private void method_71(object sender, HtmlElementEventArgs e)
	{
		Class10.smethod_6(GEnum16.const_1);
		method_74();
	}

	private void method_72(object sender, HtmlElementEventArgs e)
	{
		Class10.smethod_6(GEnum16.const_2);
		method_74();
	}

	private void method_73(object sender, HtmlElementEventArgs e)
	{
		Class10.smethod_6(GEnum16.const_3);
		method_74();
	}

	private void method_74()
	{
		using Dictionary<string, GEnum16>.Enumerator enumerator = new Dictionary<string, GEnum16>
		{
			{
				"local_ips_switcher",
				GEnum16.const_0
			},
			{
				"cloud_ips_switcher",
				GEnum16.const_1
			},
			{
				"geoip_ips_switcher",
				GEnum16.const_2
			},
			{
				"all_ips_switcher",
				GEnum16.const_3
			}
		}.GetEnumerator();
		while (enumerator.MoveNext() ? true : false)
		{
			KeyValuePair<string, GEnum16> current = enumerator.Current;
			string text = "switcher";
			if (Class10.GEnum16_0 == current.Value)
			{
				text += " active_switcher";
			}
			class79_0.method_4(current.Key, text);
		}
	}

	private void ValidateInput(object sender, HtmlElementEventArgs e)
	{
		Class38 @class = new Class38();
		@class.form32_0 = this;
		HtmlElement elementFromPoint = class79_0.Document.GetElementFromPoint(e.MousePosition);
		if (null == elementFromPoint)
		{
			return;
		}
		if (e.MouseButtonsPressed == MouseButtons.Left)
		{
			method_76(elementFromPoint);
		}
		else
		{
			if (string.IsNullOrEmpty(elementFromPoint.Name))
			{
				return;
			}
			@class.class90_0 = Class90.smethod_1(elementFromPoint.Name);
			@class.gclass24_0 = @class.class90_0.gclass11_0.gclass24_0;
			bool flag = class164_0 != null && GeoIPMode.Allow == class164_0.Class132_0.geoIPMode_0 && GEnum16.const_2 == @class.class90_0.gclass11_0.genum16_0;
			if (@class.gclass24_0.Boolean_2)
			{
				ToolStripItem[] array = new ToolStripItem[2]
				{
					new Class56
					{
						Text = @class.gclass24_0.method_6(),
						Image = Resources.informaion_16,
						Enabled = false
					},
					new ToolStripSeparator()
				};
				ToolStripItem[] first = array;
				object obj;
				if (!flag)
				{
					obj = new ToolStripItem[6]
					{
						new Class56
						{
							Text = "Unblock",
							Image = Resources.unblock_16,
							eventHandler_0 = @class.method_0
						},
						new Class56
						{
							Text = "Unblock and whitelist",
							Image = Resources.unblock_16,
							eventHandler_0 = @class.method_1
						},
						null,
						null,
						null,
						null
					};
					object obj2 = obj;
					Class56 class2 = new Class56
					{
						Text = "Unblock all in this category..",
						Image = Resources.unblock_16
					};
					EventHandler eventHandler_ = _003C_003Ec._003C_003E9.method_3;
					class2.eventHandler_0 = eventHandler_;
					((object[])obj2)[2] = class2;
					((object[])obj)[3] = new ToolStripSeparator();
					((object[])obj)[4] = new Class56
					{
						Text = "Add to blacklist",
						Image = Resources.blacklist_16,
						eventHandler_0 = @class.method_2
					};
					((object[])obj)[5] = new ToolStripSeparator();
				}
				else
				{
					obj = new ToolStripItem[0];
				}
				array = first.Concat((IEnumerable<ToolStripItem>)obj).Concat(new ToolStripItem[3]
				{
					new Class56
					{
						Text = "Copy to clipboard",
						Image = Resources.copy_16,
						eventHandler_0 = @class.method_3
					},
					new ToolStripSeparator(),
					new Class56
					{
						Text = "Get whois data.. ",
						Image = Resources.question_16,
						eventHandler_0 = @class.method_4
					}
				}).ToArray();
				Class57 class3 = new Class57();
				class3.ToolStripItem_0 = array;
				class3.Show(class79_0, e.MousePosition);
			}
		}
	}

	private void method_76(HtmlElement htmlElement_0)
	{
		if (htmlElement_0.Id != null && htmlElement_0.Id.StartsWith("ip_"))
		{
			if (!string.IsNullOrEmpty(htmlElement_0.Name))
			{
				Class90 @class = Class90.smethod_1(htmlElement_0.Name);
				if (@class.gclass11_0.gclass24_0.Boolean_2)
				{
					ShowOnlineHelp(Class148.smethod_0(@class.gclass11_0.gclass24_0.method_6()));
					Class80.smethod_1(@class.gclass11_0.gclass24_0);
				}
				htmlElement_0.SetAttribute("className", "ip_lnk_visited");
				Class10.smethod_14();
			}
			return;
		}
		switch (htmlElement_0.Id)
		{
		case "lnk_ip_sorting_by_protocol":
			if (GEnum14.const_6 == Class163.Class163_0.GEnum14_0)
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_7;
			}
			else if (GEnum14.const_7 == Class163.Class163_0.GEnum14_0)
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_6;
			}
			else
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_6;
			}
			Class163.Class163_0.method_3();
			break;
		case "lnk_ip_sorting_by_unblock_date":
			if (GEnum14.const_4 == Class163.Class163_0.GEnum14_0)
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_5;
			}
			else if (GEnum14.const_5 == Class163.Class163_0.GEnum14_0)
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_4;
			}
			else
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_4;
			}
			Class163.Class163_0.method_3();
			break;
		case "lnk_ip_sorting_by_block_date":
			if (GEnum14.const_2 == Class163.Class163_0.GEnum14_0)
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_3;
			}
			else if (GEnum14.const_3 == Class163.Class163_0.GEnum14_0)
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_2;
			}
			else
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_2;
			}
			Class163.Class163_0.method_3();
			break;
		case "lnk_ip_sorting_by_ip":
			if (Class163.Class163_0.GEnum14_0 == GEnum14.const_0)
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_1;
			}
			else if (GEnum14.const_1 == Class163.Class163_0.GEnum14_0)
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_0;
			}
			else
			{
				Class163.Class163_0.GEnum14_0 = GEnum14.const_0;
			}
			Class163.Class163_0.method_3();
			break;
		}
		if (htmlElement_0.Id != null && htmlElement_0.Id.StartsWith("lnk_ip_sorting"))
		{
			Class10.smethod_5();
		}
		if (htmlElement_0.Id != null && htmlElement_0.Id.StartsWith("page"))
		{
			if ("pagePrev" == htmlElement_0.Id)
			{
				Class10.smethod_9();
			}
			else if ("pageNext" == htmlElement_0.Id)
			{
				Class10.smethod_10();
			}
			else
			{
				Class10.smethod_11(int.Parse(htmlElement_0.Id.Replace("page", "")));
			}
		}
	}

	private void class79_0_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
	{
		if (e.Alt && Keys.F4 == e.KeyCode)
		{
			Close();
		}
	}

	private void method_77()
	{
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
		this.statusBar = new System.Windows.Forms.StatusStrip();
		this.toolStripCurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
		this.mainMenu = new System.Windows.Forms.MenuStrip();
		this.mainMenuFile = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
		this.mainMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuView = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuViewShowStatusbar = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuViewShowEventLog = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuTools = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuToolsRdpGuardService = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuToolsRdpGuardServiceStart = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuToolsRdpGuardServiceStop = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuToolsRdpGuardServiceRestart = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
		this.mmainMenuToolsWhitelist = new System.Windows.Forms.ToolStripMenuItem();
		this.mmainMenuToolsBlacklist = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
		this.mainMenuToolsUnblockAllIPAddresses = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuToolsFindIPAddress = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.mainMenuToolsCustomActions = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
		this.mainMenuToolsDiagnostic = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuToolsOptions = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuHelpOnlineHelp = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuHelpContactUs = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuHelpCheckNewVersion = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuHelpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.mainMenuHelpBuyPro = new System.Windows.Forms.ToolStripMenuItem();
		this.mmainMenuHelpProductActivation = new System.Windows.Forms.ToolStripMenuItem();
		this.mainMenuHelpSeparator2 = new System.Windows.Forms.ToolStripSeparator();
		this.mainMenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
		this.statusBar.SuspendLayout();
		this.mainMenu.SuspendLayout();
		base.SuspendLayout();
		this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.toolStripCurrentStatus });
		this.statusBar.Location = new System.Drawing.Point(0, 639);
		this.statusBar.Name = "statusBar";
		this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
		this.statusBar.Size = new System.Drawing.Size(483, 22);
		this.statusBar.TabIndex = 4;
		this.statusBar.Text = "statusStrip1";
		this.toolStripCurrentStatus.Name = "toolStripCurrentStatus";
		this.toolStripCurrentStatus.Size = new System.Drawing.Size(468, 17);
		this.toolStripCurrentStatus.Spring = true;
		this.toolStripCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.mainMenu.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.mainMenuFile, this.mainMenuView, this.mainMenuTools, this.mainMenuHelp });
		this.mainMenu.Location = new System.Drawing.Point(0, 0);
		this.mainMenu.Name = "mainMenu";
		this.mainMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
		this.mainMenu.Size = new System.Drawing.Size(483, 25);
		this.mainMenu.TabIndex = 5;
		this.mainMenu.Text = "menuStrip1";
		this.mainMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.toolStripSeparator4, this.mainMenuFileExit });
		this.mainMenuFile.Name = "mainMenuFile";
		this.mainMenuFile.Size = new System.Drawing.Size(36, 19);
		this.mainMenuFile.Text = "File";
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new System.Drawing.Size(91, 6);
		this.mainMenuFileExit.Image = Properties.Resources.exit_16;
		this.mainMenuFileExit.Name = "mainMenuFileExit";
		this.mainMenuFileExit.Size = new System.Drawing.Size(94, 22);
		this.mainMenuFileExit.Text = "Exit";
		this.mainMenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.mainMenuViewShowStatusbar, this.mainMenuViewShowEventLog });
		this.mainMenuView.Name = "mainMenuView";
		this.mainMenuView.Size = new System.Drawing.Size(46, 19);
		this.mainMenuView.Text = "View";
		this.mainMenuViewShowStatusbar.Name = "mainMenuViewShowStatusbar";
		this.mainMenuViewShowStatusbar.Size = new System.Drawing.Size(161, 22);
		this.mainMenuViewShowStatusbar.Text = "Show statusbar";
		this.mainMenuViewShowEventLog.Name = "mainMenuViewShowEventLog";
		this.mainMenuViewShowEventLog.Size = new System.Drawing.Size(161, 22);
		this.mainMenuViewShowEventLog.Text = "Show event log";
		this.mainMenuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[12]
		{
			this.mainMenuToolsRdpGuardService, this.toolStripSeparator3, this.mmainMenuToolsWhitelist, this.mmainMenuToolsBlacklist, this.toolStripSeparator5, this.mainMenuToolsUnblockAllIPAddresses, this.mainMenuToolsFindIPAddress, this.toolStripSeparator2, this.mainMenuToolsCustomActions, this.toolStripSeparator6,
			this.mainMenuToolsDiagnostic, this.mainMenuToolsOptions
		});
		this.mainMenuTools.Name = "mainMenuTools";
		this.mainMenuTools.Size = new System.Drawing.Size(48, 19);
		this.mainMenuTools.Text = "Tools";
		this.mainMenuToolsRdpGuardService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.mainMenuToolsRdpGuardServiceStart, this.mainMenuToolsRdpGuardServiceStop, this.mainMenuToolsRdpGuardServiceRestart });
		this.mainMenuToolsRdpGuardService.Image = Properties.Resources.fastf_16;
		this.mainMenuToolsRdpGuardService.Name = "mainMenuToolsRdpGuardService";
		this.mainMenuToolsRdpGuardService.Size = new System.Drawing.Size(238, 22);
		this.mainMenuToolsRdpGuardService.Text = "RdpGuard Service";
		this.mainMenuToolsRdpGuardServiceStart.Image = Properties.Resources.play_16;
		this.mainMenuToolsRdpGuardServiceStart.Name = "mainMenuToolsRdpGuardServiceStart";
		this.mainMenuToolsRdpGuardServiceStart.Size = new System.Drawing.Size(113, 22);
		this.mainMenuToolsRdpGuardServiceStart.Text = "Start";
		this.mainMenuToolsRdpGuardServiceStop.Image = Properties.Resources.splay_16;
		this.mainMenuToolsRdpGuardServiceStop.Name = "mainMenuToolsRdpGuardServiceStop";
		this.mainMenuToolsRdpGuardServiceStop.Size = new System.Drawing.Size(113, 22);
		this.mainMenuToolsRdpGuardServiceStop.Text = "Stop";
		this.mainMenuToolsRdpGuardServiceRestart.Image = Properties.Resources.redo_16;
		this.mainMenuToolsRdpGuardServiceRestart.Name = "mainMenuToolsRdpGuardServiceRestart";
		this.mainMenuToolsRdpGuardServiceRestart.Size = new System.Drawing.Size(113, 22);
		this.mainMenuToolsRdpGuardServiceRestart.Text = "Restart";
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new System.Drawing.Size(235, 6);
		this.mmainMenuToolsWhitelist.Image = Properties.Resources.whitelist_16;
		this.mmainMenuToolsWhitelist.Name = "m_mainMenuToolsWhitelist";
		this.mmainMenuToolsWhitelist.Size = new System.Drawing.Size(238, 22);
		this.mmainMenuToolsWhitelist.Text = "Whitelist...";
		this.mmainMenuToolsBlacklist.Image = Properties.Resources.blacklist_16;
		this.mmainMenuToolsBlacklist.Name = "m_mainMenuToolsBlacklist";
		this.mmainMenuToolsBlacklist.Size = new System.Drawing.Size(238, 22);
		this.mmainMenuToolsBlacklist.Text = "Blacklist...";
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new System.Drawing.Size(235, 6);
		this.mainMenuToolsUnblockAllIPAddresses.Image = Properties.Resources.unblock_16;
		this.mainMenuToolsUnblockAllIPAddresses.Name = "mainMenuToolsUnblockAllIPAddresses";
		this.mainMenuToolsUnblockAllIPAddresses.Size = new System.Drawing.Size(238, 22);
		this.mainMenuToolsUnblockAllIPAddresses.Text = "Unblock all IP addresses";
		this.mainMenuToolsFindIPAddress.Image = Properties.Resources.magnifier_16;
		this.mainMenuToolsFindIPAddress.Name = "mainMenuToolsFindIPAddress";
		this.mainMenuToolsFindIPAddress.Size = new System.Drawing.Size(238, 22);
		this.mainMenuToolsFindIPAddress.Text = "Find IP address..";
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
		this.mainMenuToolsCustomActions.Image = Properties.Resources.notifications_16;
		this.mainMenuToolsCustomActions.Name = "mainMenuToolsCustomActions";
		this.mainMenuToolsCustomActions.Size = new System.Drawing.Size(238, 22);
		this.mainMenuToolsCustomActions.Text = "Custom Actions / Notifications";
		this.toolStripSeparator6.Name = "toolStripSeparator6";
		this.toolStripSeparator6.Size = new System.Drawing.Size(235, 6);
		this.mainMenuToolsDiagnostic.Image = Properties.Resources.diagnostics_16;
		this.mainMenuToolsDiagnostic.Name = "mainMenuToolsDiagnostic";
		this.mainMenuToolsDiagnostic.Size = new System.Drawing.Size(238, 22);
		this.mainMenuToolsDiagnostic.Text = "Diagnostics...";
		this.mainMenuToolsOptions.Image = Properties.Resources.apps_16;
		this.mainMenuToolsOptions.Name = "mainMenuToolsOptions";
		this.mainMenuToolsOptions.Size = new System.Drawing.Size(238, 22);
		this.mainMenuToolsOptions.Text = "Options...";
		this.mainMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.mainMenuHelpOnlineHelp, this.mainMenuHelpContactUs, this.mainMenuHelpCheckNewVersion, this.mainMenuHelpSeparator1, this.mainMenuHelpBuyPro, this.mmainMenuHelpProductActivation, this.mainMenuHelpSeparator2, this.mainMenuHelpAbout });
		this.mainMenuHelp.Name = "mainMenuHelp";
		this.mainMenuHelp.Size = new System.Drawing.Size(43, 19);
		this.mainMenuHelp.Text = "Help";
		this.mainMenuHelpOnlineHelp.Image = Properties.Resources.online_help_24;
		this.mainMenuHelpOnlineHelp.Name = "mainMenuHelpOnlineHelp";
		this.mainMenuHelpOnlineHelp.Size = new System.Drawing.Size(180, 22);
		this.mainMenuHelpOnlineHelp.Text = "Online Help";
		this.mainMenuHelpContactUs.Image = Properties.Resources.contactus_16;
		this.mainMenuHelpContactUs.Name = "mainMenuHelpContactUs";
		this.mainMenuHelpContactUs.Size = new System.Drawing.Size(180, 22);
		this.mainMenuHelpContactUs.Text = "Contact Us";
		this.mainMenuHelpCheckNewVersion.Image = Properties.Resources.new_version_check_24;
		this.mainMenuHelpCheckNewVersion.Name = "mainMenuHelpCheckNewVersion";
		this.mainMenuHelpCheckNewVersion.Size = new System.Drawing.Size(180, 22);
		this.mainMenuHelpCheckNewVersion.Text = "New Version Check";
		this.mainMenuHelpSeparator1.Name = "mainMenuHelpSeparator1";
		this.mainMenuHelpSeparator1.Size = new System.Drawing.Size(177, 6);
		this.mainMenuHelpBuyPro.Image = Properties.Resources.key_16;
		this.mainMenuHelpBuyPro.Name = "mainMenuHelpBuyPro";
		this.mainMenuHelpBuyPro.Size = new System.Drawing.Size(180, 22);
		this.mainMenuHelpBuyPro.Text = "Purchase RdpGuard";
		this.mmainMenuHelpProductActivation.Image = Properties.Resources.activate_pro_16__2_;
		this.mmainMenuHelpProductActivation.Name = "m_mainMenuHelpProductActivation";
		this.mmainMenuHelpProductActivation.Size = new System.Drawing.Size(180, 22);
		this.mmainMenuHelpProductActivation.Text = "Product Activation";
		this.mainMenuHelpSeparator2.Name = "mainMenuHelpSeparator2";
		this.mainMenuHelpSeparator2.Size = new System.Drawing.Size(177, 6);
		this.mainMenuHelpAbout.Image = Properties.Resources.about_24;
		this.mainMenuHelpAbout.Name = "mainMenuHelpAbout";
		this.mainMenuHelpAbout.Size = new System.Drawing.Size(180, 22);
		this.mainMenuHelpAbout.Text = "About...";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(483, 661);
		base.Controls.Add(this.mainMenu);
		base.Controls.Add(this.statusBar);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "DashboardDialog";
		base.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
		this.Text = "formMain";
		this.statusBar.ResumeLayout(false);
		this.statusBar.PerformLayout();
		this.mainMenu.ResumeLayout(false);
		this.mainMenu.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void method_79(object sender, EventArgs e)
	{
		method_43();
	}

	private void method_80(object sender, EventArgs e)
	{
		method_42();
	}

	private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
	{
		if (MouseButtons.Left == e.Button)
		{
			method_43();
		}
	}

	private void method_81(object sender, EventArgs e)
	{
		method_22();
	}

	private void Form32_Shown(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private void toolStripMenuItem_5_DropDownOpening(object sender, EventArgs e)
	{
		method_36();
	}

	private void toolStripMenuItem_6_DropDownOpening(object sender, EventArgs e)
	{
		method_37();
	}

	private void toolStripCurrentStatus_Click(object sender, EventArgs e)
	{
		Class163.Class163_0.class166_0.Boolean_0 = true;
		Class163.Class163_0.method_3();
		method_34(bool_1: true);
	}

	private void Form32_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (Class163.Class163_0.class166_4.Boolean_0)
		{
			NotifyIcon_0.Visible = true;
			Hide();
			base.WindowState = FormWindowState.Minimized;
		}
		if (CloseReason.UserClosing == e.CloseReason)
		{
			e.Cancel = Class163.Class163_0.class166_4.Boolean_0 && !bool_0;
		}
		if (!e.Cancel)
		{
			class78_0?.Stop();
			NotifyIcon_0?.Dispose();
			form31_0?.method_6();
			Class163.Class163_0.method_3();
		}
	}

	private void Form32_Resize(object sender, EventArgs e)
	{
		if (FormWindowState.Minimized == base.WindowState)
		{
			method_34(bool_1: false);
			if (Class163.Class163_0.class166_3.Boolean_0)
			{
				NotifyIcon_0.Visible = true;
				Hide();
			}
		}
		if (base.WindowState == FormWindowState.Normal && Class163.Class163_0.class166_0.Boolean_0)
		{
			method_34(bool_1: true);
		}
	}

	private void mainMenuFileExit_Click(object sender, EventArgs e)
	{
		method_42();
	}

	private void mainMenuViewShowStatusbar_Click(object sender, EventArgs e)
	{
		bool flag = !Class163.Class163_0.class166_1.Boolean_0;
		method_35(flag);
		Class163.Class163_0.class166_1.Boolean_0 = flag;
		Class163.Class163_0.method_3();
	}

	private void mainMenuViewShowEventLog_Click(object sender, EventArgs e)
	{
		bool flag = !Class163.Class163_0.class166_0.Boolean_0;
		method_34(flag);
		Class163.Class163_0.class166_0.Boolean_0 = flag;
		Class163.Class163_0.method_3();
	}

	private void mmainMenuToolsWhitelist_Click(object sender, EventArgs e)
	{
		ValidateInput();
	}

	private void mmainMenuToolsBlacklist_Click(object sender, EventArgs e)
	{
		LoadSettings();
	}

	private void mainMenuToolsUnblockAllIPAddresses_Click(object sender, EventArgs e)
	{
		OnCheckedChanged();
	}

	private void mainMenuToolsCustomActions_Click(object sender, EventArgs e)
	{
		if (method_21())
		{
			new CustomActionsDialog().ShowDialog();
		}
	}

	private void mainMenuToolsDiagnostic_Click(object sender, EventArgs e)
	{
		if (method_21())
		{
			new DiagnosticReportDialog().method_1();
		}
	}

	private void mainMenuToolsOptions_Click(object sender, EventArgs e)
	{
		OnButtonOk();
	}

	private void mainMenuToolsRdpGuardServiceStart_Click(object sender, EventArgs e)
	{
		class85_0.method_1();
	}

	private void mainMenuToolsRdpGuardServiceStop_Click(object sender, EventArgs e)
	{
		class85_0.method_2();
	}

	private void mainMenuToolsRdpGuardServiceRestart_Click(object sender, EventArgs e)
	{
		class85_0.method_3();
	}

	private void mainMenuHelpOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.String_0);
	}

	private void mainMenuHelpContactUs_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.String_1);
	}

	private void mainMenuHelpCheckNewVersion_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class149.String_0);
	}

	private void mainMenuHelpBuyPro_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class150.smethod_0("menu"));
	}

	private void mmainMenuHelpProductActivation_Click(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void mainMenuHelpAbout_Click(object sender, EventArgs e)
	{
		new AboutDialog(Text).method_1();
	}

	private void form31_0_FormClosing(object sender, FormClosingEventArgs e)
	{
		Class163.Class163_0.class166_0.Boolean_0 = false;
		Class163.Class163_0.method_3();
		mainMenuViewShowEventLog.Checked = false;
		form31_0 = null;
	}

	private void method_82(object sender, EventArgs e)
	{
		method_21();
		Class89.smethod_37();
	}

	private void method_83(object sender, EventArgs e)
	{
		method_21();
		Class89.smethod_40();
	}

	private void method_84(object sender, EventArgs e)
	{
		method_21();
		Class89.smethod_15();
	}

	private void method_85(object sender, EventArgs e)
	{
		class79_0.method_2("new_version_box", bool_0: false);
	}

	private void method_86()
	{
		class85_0.method_3();
	}
}
