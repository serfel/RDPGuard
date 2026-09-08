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

	private Class67 toolStrip1;

	private GControl1 mchbTemporaryDenyRule;

	private ToolStripButton mbtnLoading;

	private ToolStripDropDownButton mbtnAddDropDown;

	private ToolStripButton mbtnAdd;

	private ToolStripButton mbtnEdit;

	private ToolStripButton mbtnDelete;

	private ToolStripButton mbtnAdvancedSettings;

	private GeoIPCountriesTable mlstCountries;

	public GClass5[] GClass5_0
	{
		get
		{
			return mlstCountries.GClass5_1;
		}
		set
		{
			mlstCountries.GClass5_1 = value;
		}
	}

	public IPListEntry[] IPListEntry_0
	{
		get
		{
			return mlstCountries.IPListEntry_0;
		}
		set
		{
			mlstCountries.IPListEntry_0 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			return mchbTemporaryDenyRule.Boolean_0;
		}
		set
		{
			mchbTemporaryDenyRule.Boolean_0 = value;
		}
	}

	public GeoIPMode GeoIPMode_0
	{
		set
		{
			bool flag = GeoIPMode.Allow == value;
			mchbTemporaryDenyRule.Visible = flag;
			mbtnAdd.Visible = !flag;
			mbtnAddDropDown.Visible = flag;
			mbtnEdit.Visible = flag;
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
		mbtnAddDropDown.DropDown = new Class57
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
		mbtnLoading.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_16_dark : Resources.wait_16);
	}

	private void AddItems()
	{
		mlstCountries.Event_0 += method_12;
		mlstCountries.Event_1 += method_13;
		mlstCountries.Event_2 += method_14;
		mlstCountries.Event_3 += method_15;
		mbtnAdd.Click += mbtnAdd_Click;
		mbtnEdit.Click += mbtnEdit_Click;
		mbtnDelete.Click += mbtnDelete_Click;
		mbtnAdvancedSettings.Click += mbtnAdvancedSettings_Click;
	}

	private void AddItem()
	{
		using GeoIPCountryAddDialog form = new GeoIPCountryAddDialog(GClass5_0, geoIPDBVersion_0);
		if (DialogResult.OK == form.ShowDialog())
		{
			mlstCountries.AddItems(form.GClass5_0);
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
				mlstCountries.UpdateCustomList(form.IPListEntry_0);
			}
		}
	}

	private void RemoveSelected()
	{
		if (!mlstCountries.Boolean_2)
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
			GClass5[] gClass5_ = mlstCountries.GClass5_1;
			Func<GClass5, string> selector = _003C_003Ec._003C_003E9.InitializeHandlers;
			class2.string_0 = gClass5_.Select(selector).ToArray();
			IPListEntry[] iPListEntry_ = mlstCountries.IPListEntry_0;
			GeoIPCountriesTable control = mlstCountries;
			IEnumerable<GClass5> source = @class.eventArgs0_0.gclass29_0.gclass5_0.Where(class2.InitializeHandlers);
			Func<GClass5, string> keySelector = _003C_003Ec._003C_003E9.AddItems;
			control.GClass5_1 = source.OrderBy(keySelector).ToArray();
			mlstCountries.IPListEntry_0 = iPListEntry_;
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
		mbtnLoading.Visible = bool_4;
		mlstCountries.Enabled = !bool_4;
		toolStrip1.Enabled = !bool_4;
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
		this.toolStrip1 = new Class67();
		this.mbtnAdvancedSettings = new System.Windows.Forms.ToolStripButton();
		this.mbtnDelete = new System.Windows.Forms.ToolStripButton();
		this.mbtnEdit = new System.Windows.Forms.ToolStripButton();
		this.mbtnAdd = new System.Windows.Forms.ToolStripButton();
		this.mbtnAddDropDown = new System.Windows.Forms.ToolStripDropDownButton();
		this.mbtnLoading = new System.Windows.Forms.ToolStripButton();
		this.mchbTemporaryDenyRule = new GControl1();
		this.mlstCountries = new GeoIPCountriesTable();
		this.toolStrip1.SuspendLayout();
		base.SuspendLayout();
		this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
		this.toolStrip1.ImageScalingSize = new System.Drawing.Size(10, 10);
		this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[7] { this.mbtnAdvancedSettings, this.mbtnDelete, this.mbtnEdit, this.mbtnAdd, this.mbtnAddDropDown, this.mbtnLoading, this.mchbTemporaryDenyRule });
		this.toolStrip1.Location = new System.Drawing.Point(0, 258);
		this.toolStrip1.Name = "toolStrip1";
		this.toolStrip1.Size = new System.Drawing.Size(562, 27);
		this.toolStrip1.TabIndex = 0;
		this.toolStrip1.Text = "toolStrip1";
		this.mbtnAdvancedSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnAdvancedSettings.Image = Properties.Resources.config_10_v2;
		this.mbtnAdvancedSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnAdvancedSettings.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.mbtnAdvancedSettings.Name = "m_btnAdvancedSettings";
		this.mbtnAdvancedSettings.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.mbtnAdvancedSettings.Size = new System.Drawing.Size(23, 25);
		this.mbtnAdvancedSettings.Text = "Settings";
		this.mbtnAdvancedSettings.ToolTipText = "Click to open advanced settings";
		this.mbtnDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnDelete.Enabled = false;
		this.mbtnDelete.Image = Properties.Resources.del_10;
		this.mbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnDelete.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.mbtnDelete.Name = "m_btnDelete";
		this.mbtnDelete.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.mbtnDelete.Size = new System.Drawing.Size(60, 25);
		this.mbtnDelete.Text = "Delete";
		this.mbtnDelete.ToolTipText = "Click to delete selected countries";
		this.mbtnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnEdit.Enabled = false;
		this.mbtnEdit.Image = Properties.Resources.edit_10;
		this.mbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnEdit.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.mbtnEdit.Name = "m_btnEdit";
		this.mbtnEdit.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.mbtnEdit.Size = new System.Drawing.Size(47, 25);
		this.mbtnEdit.Text = "Edit";
		this.mbtnEdit.ToolTipText = "Click to edit custom allow list";
		this.mbtnAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnAdd.Image = Properties.Resources.plus_10;
		this.mbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnAdd.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.mbtnAdd.Name = "m_btnAdd";
		this.mbtnAdd.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.mbtnAdd.Size = new System.Drawing.Size(49, 25);
		this.mbtnAdd.Text = "Add";
		this.mbtnAdd.ToolTipText = "Click to add new country";
		this.mbtnAddDropDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnAddDropDown.Image = Properties.Resources.plus_10;
		this.mbtnAddDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnAddDropDown.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
		this.mbtnAddDropDown.Name = "m_btnAddDropDown";
		this.mbtnAddDropDown.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
		this.mbtnAddDropDown.Size = new System.Drawing.Size(58, 25);
		this.mbtnAddDropDown.Text = "Add";
		this.mbtnAddDropDown.ToolTipText = "Click to add new country or custom allow list";
		this.mbtnLoading.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
		this.mbtnLoading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
		this.mbtnLoading.ImageTransparentColor = System.Drawing.Color.Magenta;
		this.mbtnLoading.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
		this.mbtnLoading.Name = "m_btnLoading";
		this.mbtnLoading.Padding = new System.Windows.Forms.Padding(3);
		this.mbtnLoading.Size = new System.Drawing.Size(23, 25);
		this.mbtnLoading.Visible = false;
		this.mchbTemporaryDenyRule.Boolean_0 = false;
		this.mchbTemporaryDenyRule.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
		this.mchbTemporaryDenyRule.Name = "m_chbTemporaryDenyRule";
		this.mchbTemporaryDenyRule.Padding = new System.Windows.Forms.Padding(3);
		this.mchbTemporaryDenyRule.Size = new System.Drawing.Size(268, 27);
		this.mchbTemporaryDenyRule.Text = "Test mode (all countries allowed again after reboot)";
		this.mchbTemporaryDenyRule.ToolTipText = "Use this mode to test blocking settings. After a restart, all countries will be allowed again to ensure access in case of configuration errors.";
		this.mlstCountries.GClass5_1 = new GClass5[0];
		this.mlstCountries.IPListEntry_0 = new rdpguard.lib.IPListEntry[0];
		this.mlstCountries.Dock = System.Windows.Forms.DockStyle.Fill;
		this.mlstCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		this.mlstCountries.Location = new System.Drawing.Point(0, 0);
		this.mlstCountries.Margin = new System.Windows.Forms.Padding(4);
		this.mlstCountries.Name = "m_lstCountries";
		this.mlstCountries.Size = new System.Drawing.Size(562, 258);
		this.mlstCountries.TabIndex = 1;
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.mlstCountries);
		base.Controls.Add(this.toolStrip1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
		base.Margin = new System.Windows.Forms.Padding(4);
		base.Name = "EditableGeoIPCountriesTable";
		base.Size = new System.Drawing.Size(562, 285);
		this.toolStrip1.ResumeLayout(false);
		this.toolStrip1.PerformLayout();
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
		mbtnEdit.Enabled = mlstCountries.Boolean_2;
		mbtnDelete.Enabled = (mlstCountries.GClass5_0.Any() ? true : false) || mlstCountries.Boolean_2;
	}

	private void method_13(object sender, EventArgs e)
	{
		eventHandler_0?.Invoke(sender, e);
	}

	private void method_14(object sender, KeyEventArgs e)
	{
		if (Keys.Delete == e.KeyCode)
		{
			mbtnDelete.PerformClick();
		}
		if (Keys.Insert == e.KeyCode)
		{
			mbtnAdd.PerformClick();
		}
	}

	private void method_15(object sender, MouseEventArgs e)
	{
		RemoveSelected();
	}

	private void mbtnAdd_Click(object sender, EventArgs e)
	{
		AddItem();
	}

	private void mbtnEdit_Click(object sender, EventArgs e)
	{
		RemoveSelected();
	}

	private void mbtnDelete_Click(object sender, EventArgs e)
	{
		mlstCountries.RemoveSelected();
	}

	private void mbtnAdvancedSettings_Click(object sender, EventArgs e)
	{
		RemoveItem();
	}
}
