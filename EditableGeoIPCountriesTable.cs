using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Properties;
using rdpguard.lib;

internal sealed class EditableGeoIPCountriesTable : UserControl
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GClass5, string> _003C_003E9__30_1;

		public static Func<GClass5, string> _003C_003E9__30_3;

		internal string InitializeHandlers(GClass5 gclass5_0)
		{
			return gclass5_0.string_1;
		}

		internal string AddItems(GClass5 gclass5_0)
		{
			return gclass5_0.Name;
		}
	}

	private sealed class Class4
	{
		public EditableGeoIPCountriesTable control0_0;

		public object object_0;

		public EventArgs0 eventArgs0_0;

		internal void InitializeHandlers()
		{
			control0_0.InitializeComponent(object_0, eventArgs0_0);
		}
	}

	private sealed class Class5
	{
		public string[] string_0;

		internal bool InitializeHandlers(GClass5 gclass5_0)
		{
			return string_0.Contains(gclass5_0.string_1);
		}
	}

	private EventHandler eventHandler_0;

	public GClass7 gclass7_0 = new GClass7();

	public GClass7 gclass7_1 = new GClass7();

	public GClass7 gclass7_2 = new GClass7();

	public bool bool_0 = true;

	public bool bool_1 = true;

	public bool bool_2;

	public bool bool_3;

	public GeoIPDBVersion geoIPDBVersion_0;

	private IContainer icontainer_0;

	private Class67 class67_0;

	private GControl1 gcontrol1_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripDropDownButton toolStripDropDownButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private ToolStripButton toolStripButton_3;

	private ToolStripButton toolStripButton_4;

	private GeoIPCountriesTable control1_0;

	public GClass5[] GClass5_0
	{
		get
		{
			return control1_0.GClass5_1;
		}
		set
		{
			control1_0.GClass5_1 = value;
		}
	}

	public IPListEntry[] IPListEntry_0
	{
		get
		{
			return control1_0.IPListEntry_0;
		}
		set
		{
			control1_0.IPListEntry_0 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			return gcontrol1_0.Boolean_0;
		}
		set
		{
			gcontrol1_0.Boolean_0 = value;
		}
	}

	public GeoIPMode GeoIPMode_0
	{
		set
		{
			bool flag = GeoIPMode.Allow == value;
			gcontrol1_0.Visible = flag;
			toolStripButton_1.Visible = !flag;
			toolStripDropDownButton_0.Visible = flag;
			toolStripButton_2.Visible = flag;
		}
	}

	public event EventHandler Event_0
	{
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public EditableGeoIPCountriesTable()
	{
		InitializeComponent();
		InitializeHandlers();
		AddItems();
	}

	private void InitializeHandlers()
	{
		toolStripDropDownButton_0.DropDown = new Class57
		{
			ToolStripItem_0 = new ToolStripItem[3]
			{
				new Class56
				{
					Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.location_pin_16_dark : Resources.location_pin_16),
					Text = "Allowed country",
					eventHandler_0 = GetEntryCount
				},
				new ToolStripSeparator(),
				new Class56
				{
					Image = Resources.list_16,
					Text = "Allowed address or range",
					eventHandler_0 = GetAddressCount
				}
			},
			ImageScalingSize = new Size(16, 16)
		};
		toolStripButton_0.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	private void AddItems()
	{
		control1_0.Event_0 += method_12;
		control1_0.Event_1 += method_13;
		control1_0.Event_2 += method_14;
		control1_0.Event_3 += method_15;
		toolStripButton_1.Click += toolStripButton_1_Click;
		toolStripButton_2.Click += toolStripButton_2_Click;
		toolStripButton_3.Click += toolStripButton_3_Click;
		toolStripButton_4.Click += toolStripButton_4_Click;
	}

	private void AddItem()
	{
		using GeoIPCountryAddDialog form = new GeoIPCountryAddDialog(GClass5_0, geoIPDBVersion_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			control1_0.AddItems(form.GClass5_0);
		}
	}

	private void UpdateCustomList()
	{
		IPListEntryAddEditDialog form = new IPListEntryAddEditDialog(null)
		{
			Image_0 = Resources.whitelist_add_48,
			string_0 = Class148.Class156.string_0,
			string_1 = Class148.Class156.string_0
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				control1_0.UpdateCustomList(form.IPListEntry_0);
			}
		}
	}

	private void RemoveSelected()
	{
		if (!control1_0.Boolean_2)
		{
			return;
		}
		IPListDialog form = new IPListDialog(IPListEntry_0)
		{
			string_0 = Class148.Class156.string_0,
			Image_0 = Resources.whitelist_48,
			Image_1 = Resources.whitelist_add_48,
			Image_2 = Resources.whitelist_edit_48,
			String_0 = "Custom Allow List",
			String_1 = "Custom Allow List",
			String_2 = "A list of addresses that will always have access to the server"
		};
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				IPListEntry_0 = form.IPListEntry_0;
			}
		}
	}

	private void RemoveItem()
	{
		AdvancedGeoIPSettingsDialog form = new AdvancedGeoIPSettingsDialog
		{
			GClass7_0 = gclass7_0,
			GClass7_1 = gclass7_1,
			GClass7_2 = gclass7_2,
			Boolean_0 = bool_0,
			Boolean_1 = bool_1,
			Boolean_2 = bool_2,
			Boolean_3 = bool_3,
			GeoIPDBVersion_0 = geoIPDBVersion_0
		};
		GeoIPDBVersion geoIPDBVersion = geoIPDBVersion_0;
		using (form)
		{
			if (DialogResult.OK == form.ShowDialog())
			{
				gclass7_0 = form.GClass7_0;
				gclass7_1 = form.GClass7_1;
				gclass7_2 = form.GClass7_2;
				bool_0 = form.Boolean_0;
				bool_1 = form.Boolean_1;
				bool_2 = form.Boolean_2;
				bool_3 = form.Boolean_3;
				geoIPDBVersion_0 = form.GeoIPDBVersion_0;
			}
		}
		if (geoIPDBVersion != geoIPDBVersion_0)
		{
			UpdateTotals();
		}
	}

	private void UpdateTotals()
	{
		RemoveListItem(bool_4: true);
		Class89.eventHandler_28 = (EventHandler<EventArgs0>)Delegate.Combine(Class89.eventHandler_28, new EventHandler<EventArgs0>(InitializeComponent));
		Class89.smethod_39(geoIPDBVersion_0);
	}

	private void InitializeComponent(object sender, EventArgs0 e)
	{
		Class4 @class = new Class4();
		@class.control0_0 = this;
		@class.object_0 = sender;
		@class.eventArgs0_0 = e;
		Class89.eventHandler_28 = (EventHandler<EventArgs0>)Delegate.Remove(Class89.eventHandler_28, new EventHandler<EventArgs0>(InitializeComponent));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.InitializeHandlers));
			return;
		}
		RemoveListItem(bool_4: false);
		if (@class.eventArgs0_0.gclass29_0.Boolean_0)
		{
			Class5 class2 = new Class5();
			GClass5[] gClass5_ = control1_0.GClass5_1;
			Func<GClass5, string> selector = _003C_003Ec._003C_003E9.InitializeHandlers;
			class2.string_0 = gClass5_.Select(selector).ToArray();
			IPListEntry[] iPListEntry_ = control1_0.IPListEntry_0;
			GeoIPCountriesTable control = control1_0;
			IEnumerable<GClass5> source = @class.eventArgs0_0.gclass29_0.gclass5_0.Where(class2.InitializeHandlers);
			Func<GClass5, string> keySelector = _003C_003Ec._003C_003E9.AddItems;
			control.GClass5_1 = source.OrderBy(keySelector).ToArray();
			control1_0.IPListEntry_0 = iPListEntry_;
		}
		else
		{
			DialogResult dialogResult = MessageBox.Show("Unable to get countries, server response: " + @class.eventArgs0_0.gclass29_0.string_2, Class138.String_1, MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
			if (DialogResult.Retry == dialogResult)
			{
				UpdateTotals();
			}
		}
	}

	private void RemoveListItem(bool bool_4)
	{
		toolStripButton_0.Visible = bool_4;
		control1_0.Enabled = !bool_4;
		class67_0.Enabled = !bool_4;
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
		this.class67_0 = new Class67();
		this.toolStripButton_4 = new System.Windows.Forms.ToolStripButton();
		this.toolStripButton_3 = new System.Windows.Forms.ToolStripButton();
		this.toolStripButton_2 = new System.Windows.Forms.ToolStripButton();
		this.toolStripButton_1 = new System.Windows.Forms.ToolStripButton();
		this.toolStripDropDownButton_0 = new System.Windows.Forms.ToolStripDropDownButton();
		this.toolStripButton_0 = new System.Windows.Forms.ToolStripButton();
		this.gcontrol1_0 = new GControl1();
		this.control1_0 = new GeoIPCountriesTable();
		this.class67_0.SuspendLayout();
		base.SuspendLayout();
		this.class67_0.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.class67_0.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.class67_0.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.class67_0.ImageScalingSize = new System.Drawing.Size(10, 10);
		this.class67_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.toolStripButton_4, this.toolStripButton_3, this.toolStripButton_2, this.toolStripButton_1, this.toolStripDropDownButton_0, this.toolStripButton_0, this.gcontrol1_0 });
		this.class67_0.Location = new System.Drawing.Point(0, 258);
		this.class67_0.Name = "toolStrip1";
		this.class67_0.Size = new System.Drawing.Size(562, 27);
		this.class67_0.TabIndex = 0;
		this.class67_0.Text = "toolStrip1";
		this.toolStripButton_4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripButton_4.Image = Properties.Resources.config_10_v2;
		this.toolStripButton_4.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton_4.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.toolStripButton_4.Name = "m_btnAdvancedSettings";
		this.toolStripButton_4.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.toolStripButton_4.Size = new System.Drawing.Size(23, 25);
		this.toolStripButton_4.Text = "Settings";
		this.toolStripButton_4.ToolTipText = "Click to open advanced settings";
		this.toolStripButton_3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripButton_3.Enabled = false;
		this.toolStripButton_3.Image = Properties.Resources.del_10;
		this.toolStripButton_3.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton_3.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.toolStripButton_3.Name = "m_btnDelete";
		this.toolStripButton_3.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.toolStripButton_3.Size = new System.Drawing.Size(60, 25);
		this.toolStripButton_3.Text = "Delete";
		this.toolStripButton_3.ToolTipText = "Click to delete selected countries";
		this.toolStripButton_2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripButton_2.Enabled = false;
		this.toolStripButton_2.Image = Properties.Resources.edit_10;
		this.toolStripButton_2.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton_2.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.toolStripButton_2.Name = "m_btnEdit";
		this.toolStripButton_2.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.toolStripButton_2.Size = new System.Drawing.Size(47, 25);
		this.toolStripButton_2.Text = "Edit";
		this.toolStripButton_2.ToolTipText = "Click to edit custom allow list";
		this.toolStripButton_1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripButton_1.Image = Properties.Resources.plus_10;
		this.toolStripButton_1.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton_1.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.toolStripButton_1.Name = "m_btnAdd";
		this.toolStripButton_1.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.toolStripButton_1.Size = new System.Drawing.Size(49, 25);
		this.toolStripButton_1.Text = "Add";
		this.toolStripButton_1.ToolTipText = "Click to add new country";
		this.toolStripDropDownButton_0.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripDropDownButton_0.Image = Properties.Resources.plus_10;
		this.toolStripDropDownButton_0.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripDropDownButton_0.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.toolStripDropDownButton_0.Name = "m_btnAddDropDown";
		this.toolStripDropDownButton_0.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.toolStripDropDownButton_0.Size = new System.Drawing.Size(58, 25);
		this.toolStripDropDownButton_0.Text = "Add";
		this.toolStripDropDownButton_0.ToolTipText = "Click to add new country or custom allow list";
		this.toolStripButton_0.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.toolStripButton_0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.toolStripButton_0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
		this.toolStripButton_0.Name = "m_btnLoading";
		this.toolStripButton_0.Padding = new System.Windows.Forms.Padding(3);
		this.toolStripButton_0.Size = new System.Drawing.Size(23, 25);
		this.toolStripButton_0.Visible = false;
		this.gcontrol1_0.Boolean_0 = false;
		this.gcontrol1_0.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
		this.gcontrol1_0.Name = "m_chbTemporaryDenyRule";
		this.gcontrol1_0.Padding = new System.Windows.Forms.Padding(3);
		this.gcontrol1_0.Size = new System.Drawing.Size(268, 27);
		this.gcontrol1_0.Text = "Test mode (all countries allowed again after reboot)";
		this.gcontrol1_0.ToolTipText = "Use this mode to test blocking settings. After a restart, all countries will be allowed again to ensure access in case of configuration errors.";
		this.control1_0.GClass5_1 = new GClass5[0];
		this.control1_0.IPListEntry_0 = new rdpguard.lib.IPListEntry[0];
		this.control1_0.Dock = System.Windows.Forms.DockStyle.Fill;
		this.control1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.control1_0.Location = new System.Drawing.Point(0, 0);
		this.control1_0.Margin = new System.Windows.Forms.Padding(4);
		this.control1_0.Name = "m_lstCountries";
		this.control1_0.Size = new System.Drawing.Size(562, 258);
		this.control1_0.TabIndex = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.control1_0);
		base.Controls.Add(this.class67_0);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "EditableGeoIPCountriesTable";
		base.Size = new System.Drawing.Size(562, 285);
		this.class67_0.ResumeLayout(false);
		this.class67_0.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void GetEntryCount(object sender, EventArgs e)
	{
		AddItem();
	}

	private void GetAddressCount(object sender, EventArgs e)
	{
		UpdateCustomList();
	}

	private void method_12(object sender, EventArgs e)
	{
		toolStripButton_2.Enabled = control1_0.Boolean_2;
		toolStripButton_3.Enabled = (control1_0.GClass5_0.Any() ? true : false) || control1_0.Boolean_2;
	}

	private void method_13(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_14(object sender, KeyEventArgs e)
	{
		if (Keys.Delete == e.KeyCode)
		{
			toolStripButton_3.PerformClick();
		}
		if (Keys.Insert == e.KeyCode)
		{
			toolStripButton_1.PerformClick();
		}
	}

	private void method_15(object sender, MouseEventArgs e)
	{
		RemoveSelected();
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		AddItem();
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		RemoveSelected();
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		control1_0.RemoveSelected();
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		RemoveItem();
	}
}
