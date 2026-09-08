using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Properties;

internal sealed class SmtpServersDialog : Form0
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ListViewItem, Class109> _003C_003E9__4_0;

		public static Action<ListViewItem> _003C_003E9__8_0;

		internal Class109 method_0(ListViewItem listViewItem_0)
		{
			return listViewItem_0.Tag as Class109;
		}

		internal void method_1(ListViewItem listViewItem_0)
		{
			listViewItem_0.Remove();
		}
	}

	private sealed class Class19
	{
		public SmtpServersDialog form25_0;

		public object object_0;

		public EventArgs4 eventArgs4_0;

		internal void method_0()
		{
			form25_0.OnButtonOk(object_0, eventArgs4_0);
		}

		internal void method_1(Class109 class109_0)
		{
			form25_0.OnCheckedChanged(class109_0);
		}
	}

	private IContainer icontainer_0;

	private Class66 mbtnSave;

	private Class66 btnCancel;

	private GControl0 separatorLine1;

	private Class62 label2;

	private PictureBox imgBigIcon;

	private Class62 lblCaption;

	private GClass0 mlstSmtpServers;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private Class66 mbtnDelete;

	private Class66 mbtnEdit;

	private Class66 mbtnAdd;

	private GClass3 mlnkOnlineHelp;

	private ColumnHeader columnHeader_2;

	private ColumnHeader columnHeader_3;

	private ColumnHeader columnHeader_4;

	private Class109[] Class109_0
	{
		get
		{
			IEnumerable<ListViewItem> source = mlstSmtpServers.Items.Cast<ListViewItem>();
			Func<ListViewItem, Class109> selector = _003C_003Ec._003C_003E9.method_0;
			return source.Select(selector).ToArray();
		}
	}

	public SmtpServersDialog()
		: base(new Size(700, 525))
	{
		ValidateInput();
		InitializeFormPosition();
		LoadSettings();
		base.Shown += Form25_Shown;
	}

	private void InitializeComponent()
	{
		Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Combine(Class89.eventHandler_23, new EventHandler<EventArgs4>(OnButtonOk));
		Class89.smethod_32();
	}

	private void OnButtonOk(object sender, EventArgs4 e)
	{
		Class19 @class = new Class19();
		@class.form25_0 = this;
		@class.object_0 = sender;
		@class.eventArgs4_0 = e;
		Class89.eventHandler_23 = (EventHandler<EventArgs4>)Delegate.Remove(Class89.eventHandler_23, new EventHandler<EventArgs4>(OnButtonOk));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		@class.eventArgs4_0.class109_0.smethod_0(@class.method_1);
		OnSelectedIndexChanged();
	}

	private void OnButtonCancel()
	{
		Class89.smethod_33(Class109_0);
	}

	private void OnLoad()
	{
		using SmtpServerAddEditDialog form = new SmtpServerAddEditDialog(null);
		if (DialogResult.OK == form.ShowDialog())
		{
			OnCheckedChanged(form.Class109_0);
			OnSelectedIndexChanged();
		}
	}

	private void ValidateInput()
	{
		using SmtpServerAddEditDialog form = new SmtpServerAddEditDialog(mlstSmtpServers.SelectedItems[0].Tag as Class109);
		if (DialogResult.OK == form.ShowDialog())
		{
			mlstSmtpServers.SelectedItems[0].Tag = form.Class109_0;
			OnSelectedIndexChanged();
		}
	}

	private void SaveSettings()
	{
		IEnumerable<ListViewItem> ienumerable_ = mlstSmtpServers.SelectedItems.Cast<ListViewItem>();
		Action<ListViewItem> action_ = _003C_003Ec._003C_003E9.method_1;
		ienumerable_.smethod_0(action_);
	}

	private void LoadSettings()
	{
		mlstSmtpServers.SelectedIndexChanged += gclass0_0_SelectedIndexChanged;
		mlstSmtpServers.MouseDoubleClick += mlstSmtpServers_MouseDoubleClick;
		mlstSmtpServers.KeyUp += mlstSmtpServers_KeyUp;
		mbtnAdd.Click += mbtnAdd_Click;
		mbtnEdit.Click += mbtnEdit_Click;
		mbtnDelete.Click += mbtnDelete_Click;
		mbtnSave.Click += mbtnSave_Click;
		btnCancel.Click += btnCancel_Click;
		mlnkOnlineHelp.Click += mlnkOnlineHelp_Click;
	}

	private void OnTextChanged()
	{
		mbtnEdit.Enabled = mlstSmtpServers.Boolean_2;
		mbtnDelete.Enabled = mlstSmtpServers.Boolean_1;
	}

	private void OnCheckedChanged(Class109 class109_0)
	{
		mlstSmtpServers.Items.Add(new ListViewItem
		{
			Tag = class109_0
		});
	}

	private void OnSelectedIndexChanged()
	{
		IEnumerator enumerator = mlstSmtpServers.Items.GetEnumerator();
		try
		{
			while (enumerator.MoveNext() ? true : false)
			{
				ListViewItem listViewItem = (ListViewItem)enumerator.Current;
				Class109 @class = listViewItem.Tag as Class109;
				listViewItem.SubItems.Clear();
				listViewItem.Text = @class.string_1;
				listViewItem.SubItems.Add(@class.ushort_0.ToString());
				listViewItem.SubItems.Add((@class.bool_0 ? true : false) ? "Yes" : "No");
				listViewItem.SubItems.Add(@class.string_2);
				listViewItem.SubItems.Add((string.IsNullOrEmpty(@class.string_3) ? true : false) ? string.Empty : "**************");
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
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

	private void ValidateInput()
	{
		mbtnSave = new Class66();
		btnCancel = new Class66();
		separatorLine1 = new GControl0();
		label2 = new Class62();
		imgBigIcon = new PictureBox();
		lblCaption = new Class62();
		mlstSmtpServers = new GClass0();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		columnHeader_3 = new ColumnHeader();
		columnHeader_4 = new ColumnHeader();
		mbtnDelete = new Class66();
		mbtnEdit = new Class66();
		mbtnAdd = new Class66();
		mlnkOnlineHelp = new GClass3();
		((ISupportInitialize)imgBigIcon).BeginInit();
		SuspendLayout();
		mbtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSave.Image = Resources.opts_16;
		mbtnSave.Location = new Point(463, 438);
		mbtnSave.Margin = new Padding(4);
		mbtnSave.Name = "m_btnSave";
		mbtnSave.Size = new Size(100, 36);
		mbtnSave.TabIndex = 3;
		mbtnSave.Text = "Save";
		mbtnSave.TextAlign = ContentAlignment.MiddleRight;
		mbtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSave.UseVisualStyleBackColor = true;
		btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		btnCancel.Image = Resources.cancl_16;
		btnCancel.Location = new Point(571, 438);
		btnCancel.Margin = new Padding(4);
		btnCancel.Name = "btnCancel";
		btnCancel.Size = new Size(100, 36);
		btnCancel.TabIndex = 4;
		btnCancel.Text = "Cancel";
		btnCancel.TextAlign = ContentAlignment.MiddleRight;
		btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		btnCancel.UseVisualStyleBackColor = true;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(656, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		label2.Location = new Point(79, 15);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(108, 16);
		label2.TabIndex = 49;
		label2.Text = "SMTP Servers";
		imgBigIcon.Image = Resources.mail_server_48;
		imgBigIcon.Location = new Point(16, 15);
		imgBigIcon.Margin = new Padding(4);
		imgBigIcon.Name = "imgBigIcon";
		imgBigIcon.Size = new Size(48, 48);
		imgBigIcon.SizeMode = PictureBoxSizeMode.AutoSize;
		imgBigIcon.TabIndex = 47;
		imgBigIcon.TabStop = false;
		lblCaption.AutoSize = true;
		lblCaption.Location = new Point(79, 47);
		lblCaption.Margin = new Padding(4, 0, 4, 0);
		lblCaption.Name = "lblCaption";
		lblCaption.Size = new Size(251, 16);
		lblCaption.TabIndex = 48;
		lblCaption.Text = "SMTP servers  to use for sending emails.";
		mlstSmtpServers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mlstSmtpServers.Columns.AddRange(new ColumnHeader[5] { columnHeader_0, columnHeader_1, columnHeader_2, columnHeader_3, columnHeader_4 });
		mlstSmtpServers.FullRowSelect = true;
		mlstSmtpServers.GridLines = true;
		mlstSmtpServers.HideSelection = false;
		mlstSmtpServers.Location = new Point(15, 98);
		mlstSmtpServers.Name = "m_lstSmtpServers";
		mlstSmtpServers.Size = new Size(657, 325);
		mlstSmtpServers.TabIndex = 6;
		mlstSmtpServers.UseCompatibleStateImageBehavior = false;
		mlstSmtpServers.View = View.Details;
		columnHeader_0.Text = "Host";
		columnHeader_0.Width = 100;
		columnHeader_1.Text = "Port";
		columnHeader_1.Width = 100;
		columnHeader_2.Text = "SSL/TLS";
		columnHeader_2.Width = 100;
		columnHeader_3.Text = "User name";
		columnHeader_3.Width = 100;
		columnHeader_4.Text = "Password";
		columnHeader_4.Width = 100;
		mbtnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mbtnDelete.Enabled = false;
		mbtnDelete.Image = Resources.del_16;
		mbtnDelete.ImageAlign = ContentAlignment.MiddleRight;
		mbtnDelete.Location = new Point(232, 438);
		mbtnDelete.Margin = new Padding(4);
		mbtnDelete.Name = "m_btnDelete";
		mbtnDelete.Size = new Size(100, 36);
		mbtnDelete.TabIndex = 2;
		mbtnDelete.Text = "Delete";
		mbtnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnDelete.UseVisualStyleBackColor = true;
		mbtnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mbtnEdit.Enabled = false;
		mbtnEdit.Image = Resources.edit_16;
		mbtnEdit.ImageAlign = ContentAlignment.MiddleRight;
		mbtnEdit.Location = new Point(124, 438);
		mbtnEdit.Margin = new Padding(4);
		mbtnEdit.Name = "m_btnEdit";
		mbtnEdit.Size = new Size(100, 36);
		mbtnEdit.TabIndex = 1;
		mbtnEdit.Text = "Edit";
		mbtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnEdit.UseVisualStyleBackColor = true;
		mbtnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mbtnAdd.Image = Resources.add_16;
		mbtnAdd.ImageAlign = ContentAlignment.MiddleRight;
		mbtnAdd.Location = new Point(16, 438);
		mbtnAdd.Margin = new Padding(4);
		mbtnAdd.Name = "m_btnAdd";
		mbtnAdd.Size = new Size(100, 36);
		mbtnAdd.TabIndex = 0;
		mbtnAdd.Text = "Add";
		mbtnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnAdd.UseVisualStyleBackColor = true;
		mlnkOnlineHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
		mlnkOnlineHelp.AutoSize = true;
		mlnkOnlineHelp.LinkColor = Color.FromArgb(38, 135, 200);
		mlnkOnlineHelp.Location = new Point(599, 9);
		mlnkOnlineHelp.Name = "m_lnkOnlineHelp";
		mlnkOnlineHelp.Size = new Size(73, 16);
		mlnkOnlineHelp.TabIndex = 5;
		mlnkOnlineHelp.TabStop = true;
		mlnkOnlineHelp.Text = "online help";
		mlnkOnlineHelp.VisitedLinkColor = Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(684, 487);
		base.Controls.Add(mlnkOnlineHelp);
		base.Controls.Add(mbtnDelete);
		base.Controls.Add(mbtnEdit);
		base.Controls.Add(mbtnAdd);
		base.Controls.Add(mlstSmtpServers);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(label2);
		base.Controls.Add(lblCaption);
		base.Controls.Add(imgBigIcon);
		base.Controls.Add(mbtnSave);
		base.Controls.Add(btnCancel);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "SmtpServersDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "SMTP Servers";
		((ISupportInitialize)imgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void Form25_Shown(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private void gclass0_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		OnTextChanged();
	}

	private void mlstSmtpServers_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		ValidateInput();
	}

	private void mlstSmtpServers_KeyUp(object sender, KeyEventArgs e)
	{
		if (Keys.Delete == e.KeyCode)
		{
			mbtnDelete.PerformClick();
		}
		if (Keys.Insert == e.KeyCode)
		{
			mbtnAdd.PerformClick();
		}
		if (Keys.F2 == e.KeyCode)
		{
			mbtnEdit.PerformClick();
		}
	}

	private void mbtnAdd_Click(object sender, EventArgs e)
	{
		OnLoad();
	}

	private void mbtnEdit_Click(object sender, EventArgs e)
	{
		ValidateInput();
	}

	private void mbtnDelete_Click(object sender, EventArgs e)
	{
		SaveSettings();
	}

	private void mbtnSave_Click(object sender, EventArgs e)
	{
		OnButtonCancel();
		CloseDialog(DialogResult.OK);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}

	private void mlnkOnlineHelp_Click(object sender, EventArgs e)
	{
		ShowOnlineHelp(Class148.Class154.String_0);
	}
}
