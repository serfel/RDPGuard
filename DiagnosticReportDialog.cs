using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Properties;

internal sealed class DiagnosticReportDialog : Form0
{
	private sealed class Class39
	{
		public DiagnosticReportDialog form34_0;

		public object object_0;

		public EventArgs8 eventArgs8_0;

		internal void method_0()
		{
			form34_0.OnButtonOk(object_0, eventArgs8_0);
		}
	}

	private sealed class Class40
	{
		public DiagnosticReportDialog form34_0;

		public object object_0;

		public EventArgs9 eventArgs9_0;

		internal void method_0()
		{
			form34_0.OnLoad(object_0, eventArgs9_0);
		}
	}

	private sealed class Class41
	{
		public DiagnosticReportDialog form34_0;

		public object object_0;

		public EventArgs10 eventArgs10_0;

		internal void method_0()
		{
			form34_0.ValidateInput(object_0, eventArgs10_0);
		}
	}

	private IContainer icontainer_0;

	private TextBox mtxtDiagnosticReport;

	private Class66 mbtnSend;

	private Class66 mbtnCancel;

	private PictureBox picWait;

	private GControl0 separatorLine1;

	private Class62 label2;

	private PictureBox imgBigIcon;

	private Class62 lblCaption;

	private Class62 mlblName;

	private TextBox medName;

	private TextBox medEmail;

	private Class62 mlblEmail;

	private TextBox medDescription;

	private Class62 mlblDescription;

	private bool Boolean_0
	{
		get
		{
			if (!string.IsNullOrEmpty(medName.Text) && !string.IsNullOrEmpty(medEmail.Text))
			{
				return !string.IsNullOrEmpty(medDescription.Text);
			}
			return false;
		}
	}

	public DiagnosticReportDialog()
		: base(new Size(700, 620))
	{
		OnCheckedChanged();
		InitializeFormPosition();
		SaveSettings();
		LoadSettings();
		base.Shown += Form34_Shown;
	}

	private void InitializeComponent()
	{
		Class89.eventHandler_3 = (EventHandler<EventArgs8>)Delegate.Combine(Class89.eventHandler_3, new EventHandler<EventArgs8>(OnButtonOk));
		Class89.smethod_21();
		OnTextChanged(bool_0: true);
	}

	private void OnButtonOk(object sender, EventArgs8 e)
	{
		Class39 @class = new Class39();
		@class.form34_0 = this;
		@class.object_0 = sender;
		@class.eventArgs8_0 = e;
		Class89.eventHandler_3 = (EventHandler<EventArgs8>)Delegate.Remove(Class89.eventHandler_3, new EventHandler<EventArgs8>(OnButtonOk));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		OnTextChanged(bool_0: false);
		mtxtDiagnosticReport.Text = @class.eventArgs8_0.class141_0.string_2;
	}

	private void OnButtonCancel(string string_0, string string_1, string string_2)
	{
		Class89.eventHandler_4 = (EventHandler<EventArgs9>)Delegate.Combine(Class89.eventHandler_4, new EventHandler<EventArgs9>(OnLoad));
		Class89.eventHandler_5 = (EventHandler<EventArgs10>)Delegate.Combine(Class89.eventHandler_5, new EventHandler<EventArgs10>(ValidateInput));
		Class89.smethod_22(new Class141
		{
			Name = string_0,
			string_0 = string_1,
			string_1 = string_2,
			string_2 = mtxtDiagnosticReport.Text
		});
		mtxtDiagnosticReport.Clear();
		OnTextChanged(bool_0: true);
	}

	private void OnLoad(object sender, EventArgs9 e)
	{
		Class40 @class = new Class40();
		@class.form34_0 = this;
		@class.object_0 = sender;
		@class.eventArgs9_0 = e;
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
		}
		else
		{
			mtxtDiagnosticReport.AppendText(@class.eventArgs9_0.string_0);
		}
	}

	private void ValidateInput(object sender, EventArgs10 e)
	{
		Class41 @class = new Class41();
		@class.form34_0 = this;
		@class.object_0 = sender;
		@class.eventArgs10_0 = e;
		Class89.eventHandler_4 = (EventHandler<EventArgs9>)Delegate.Remove(Class89.eventHandler_4, new EventHandler<EventArgs9>(OnLoad));
		Class89.eventHandler_5 = (EventHandler<EventArgs10>)Delegate.Remove(Class89.eventHandler_5, new EventHandler<EventArgs10>(ValidateInput));
		if (base.InvokeRequired)
		{
			BeginInvoke(new Action(@class.method_0));
			return;
		}
		OnTextChanged(bool_0: false);
		if (@class.eventArgs10_0.bool_0)
		{
			Thread.Sleep(2000);
			CloseDialog(DialogResult.OK);
		}
	}

	private void SaveSettings()
	{
		lblCaption.Text = string.Format(lblCaption.Text, "RdpGuard");
		mtxtDiagnosticReport.Text = "Loading data...";
		mbtnSend.Enabled = Boolean_0;
		picWait.Image = ((Class163.Class163_0.Boolean_0 ? true : false) ? Resources.wait_25_dark : Resources.wait_25);
	}

	private void LoadSettings()
	{
		medName.TextChanged += medName_TextChanged;
		medEmail.TextChanged += medEmail_TextChanged;
		medDescription.TextChanged += medDescription_TextChanged;
		mbtnSend.Click += mbtnSend_Click;
		mbtnCancel.Click += mbtnCancel_Click;
	}

	private void OnTextChanged(bool bool_0)
	{
		picWait.Visible = bool_0;
		mbtnSend.Enabled = !bool_0 && Boolean_0;
		mlblName.Enabled = !bool_0;
		medName.Enabled = !bool_0;
		mlblEmail.Enabled = !bool_0;
		medEmail.Enabled = !bool_0;
		mlblDescription.Enabled = !bool_0;
		medDescription.Enabled = !bool_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	private void OnCheckedChanged()
	{
		new ComponentResourceManager(typeof(DiagnosticReportDialog));
		mtxtDiagnosticReport = new TextBox();
		mbtnSend = new Class66();
		mbtnCancel = new Class66();
		picWait = new PictureBox();
		separatorLine1 = new GControl0();
		label2 = new Class62();
		imgBigIcon = new PictureBox();
		lblCaption = new Class62();
		mlblName = new Class62();
		medName = new TextBox();
		medEmail = new TextBox();
		mlblEmail = new Class62();
		medDescription = new TextBox();
		mlblDescription = new Class62();
		((ISupportInitialize)picWait).BeginInit();
		((ISupportInitialize)imgBigIcon).BeginInit();
		SuspendLayout();
		mtxtDiagnosticReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		mtxtDiagnosticReport.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		mtxtDiagnosticReport.Location = new Point(16, 98);
		mtxtDiagnosticReport.Margin = new Padding(5, 4, 5, 4);
		mtxtDiagnosticReport.Multiline = true;
		mtxtDiagnosticReport.Name = "m_txtDiagnosticReport";
		mtxtDiagnosticReport.ReadOnly = true;
		mtxtDiagnosticReport.ScrollBars = ScrollBars.Both;
		mtxtDiagnosticReport.Size = new Size(665, 308);
		mtxtDiagnosticReport.TabIndex = 0;
		mtxtDiagnosticReport.WordWrap = false;
		mbtnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnSend.Enabled = false;
		mbtnSend.Image = Resources.opts_16;
		mbtnSend.Location = new Point(471, 542);
		mbtnSend.Margin = new Padding(4);
		mbtnSend.Name = "m_btnSend";
		mbtnSend.Size = new Size(100, 36);
		mbtnSend.TabIndex = 20;
		mbtnSend.Text = "Send";
		mbtnSend.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnSend.UseVisualStyleBackColor = true;
		mbtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		mbtnCancel.Image = Resources.cancl_16;
		mbtnCancel.Location = new Point(579, 542);
		mbtnCancel.Margin = new Padding(4);
		mbtnCancel.Name = "m_btnCancel";
		mbtnCancel.Size = new Size(100, 36);
		mbtnCancel.TabIndex = 21;
		mbtnCancel.Text = "Cancel";
		mbtnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
		mbtnCancel.UseVisualStyleBackColor = true;
		picWait.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
		picWait.Location = new Point(440, 549);
		picWait.Name = "picWait";
		picWait.Size = new Size(25, 25);
		picWait.TabIndex = 46;
		picWait.TabStop = false;
		picWait.Visible = false;
		separatorLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		separatorLine1.Location = new Point(16, 81);
		separatorLine1.Name = "separatorLine1";
		separatorLine1.Size = new Size(664, 2);
		separatorLine1.TabIndex = 50;
		separatorLine1.TabStop = false;
		label2.AutoSize = true;
		label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 204);
		label2.Location = new Point(79, 15);
		label2.Margin = new Padding(4, 0, 4, 0);
		label2.Name = "label2";
		label2.Size = new Size(133, 16);
		label2.TabIndex = 49;
		label2.Text = "Diagnostic Report";
		imgBigIcon.Image = Resources.diagnostics_48;
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
		lblCaption.Size = new Size(404, 16);
		lblCaption.TabIndex = 48;
		lblCaption.Text = "Please send us diagnostic report if you have any problems with {0}.";
		mlblName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblName.AutoSize = true;
		mlblName.Location = new Point(13, 421);
		mlblName.Name = "m_lblName";
		mlblName.Size = new Size(76, 16);
		mlblName.TabIndex = 51;
		mlblName.Text = "Your name:";
		medName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		medName.Location = new Point(25, 440);
		medName.Name = "m_edName";
		medName.Size = new Size(247, 22);
		medName.TabIndex = 52;
		medEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		medEmail.Location = new Point(25, 498);
		medEmail.Name = "m_edEmail";
		medEmail.Size = new Size(247, 22);
		medEmail.TabIndex = 54;
		mlblEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblEmail.AutoSize = true;
		mlblEmail.Location = new Point(13, 479);
		mlblEmail.Name = "m_lblEmail";
		mlblEmail.Size = new Size(75, 16);
		mlblEmail.TabIndex = 53;
		mlblEmail.Text = "Your email:";
		medDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
		medDescription.Font = new Font("Courier New", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
		medDescription.Location = new Point(291, 440);
		medDescription.Margin = new Padding(5, 4, 5, 4);
		medDescription.MaxLength = 2048;
		medDescription.Multiline = true;
		medDescription.Name = "m_edDescription";
		medDescription.ScrollBars = ScrollBars.Both;
		medDescription.Size = new Size(389, 80);
		medDescription.TabIndex = 55;
		mlblDescription.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
		mlblDescription.AutoSize = true;
		mlblDescription.Location = new Point(279, 421);
		mlblDescription.Name = "m_lblDescription";
		mlblDescription.Size = new Size(131, 16);
		mlblDescription.TabIndex = 56;
		mlblDescription.Text = "Problem description:";
		base.AutoScaleDimensions = new SizeF(8f, 16f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(692, 591);
		base.Controls.Add(mlblDescription);
		base.Controls.Add(medDescription);
		base.Controls.Add(medEmail);
		base.Controls.Add(mlblEmail);
		base.Controls.Add(medName);
		base.Controls.Add(mlblName);
		base.Controls.Add(separatorLine1);
		base.Controls.Add(label2);
		base.Controls.Add(lblCaption);
		base.Controls.Add(imgBigIcon);
		base.Controls.Add(picWait);
		base.Controls.Add(mbtnSend);
		base.Controls.Add(mbtnCancel);
		base.Controls.Add(mtxtDiagnosticReport);
		Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
		base.Margin = new Padding(5, 4, 5, 4);
		base.Name = "DiagnosticReportDialog";
		base.StartPosition = FormStartPosition.Manual;
		Text = "Diagnostic Report";
		((ISupportInitialize)picWait).EndInit();
		((ISupportInitialize)imgBigIcon).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	private void Form34_Shown(object sender, EventArgs e)
	{
		InitializeComponent();
	}

	private void medName_TextChanged(object sender, EventArgs e)
	{
		mbtnSend.Enabled = Boolean_0;
	}

	private void medEmail_TextChanged(object sender, EventArgs e)
	{
		mbtnSend.Enabled = Boolean_0;
	}

	private void medDescription_TextChanged(object sender, EventArgs e)
	{
		mbtnSend.Enabled = Boolean_0;
	}

	private void mbtnSend_Click(object sender, EventArgs e)
	{
		OnButtonCancel(medName.Text, medEmail.Text, medDescription.Text);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}
}
