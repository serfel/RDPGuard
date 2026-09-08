using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Properties;

internal sealed class formCrashReport : Form0
{
	private IContainer icontainer_0;

	private PictureBox pictureBox1;

	private Class62 mlblSubCaption1;

	private TextBox mtxtCrashReport;

	private Class66 mbtnSend;

	private Class66 mbtnCancel;

	private Class62 mlblSubCaption2;

	private Class62 mlblSubCaption3;

	private Class62 label1;

	private Class62 label2;

	private GClass3 mlnkVersionCheck;

	public formCrashReport(string string_0)
	{
		InitializeComponent();
		InitializeFormPosition();
		method_11(string_0);
		InitializeHandlers();
	}

	private void method_11(string string_0)
	{
		mtxtCrashReport.Text = string_0;
	}

	private void InitializeHandlers()
	{
		mlnkVersionCheck.LinkClicked += mlnkVersionCheck_LinkClicked;
		mbtnCancel.Click += mbtnCancel_Click;
		mbtnSend.Click += mbtnSend_Click;
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
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		this.mlblSubCaption1 = new Class62();
		this.mtxtCrashReport = new System.Windows.Forms.TextBox();
		this.mbtnSend = new Class66();
		this.mbtnCancel = new Class66();
		this.mlblSubCaption2 = new Class62();
		this.mlblSubCaption3 = new Class62();
		this.label1 = new Class62();
		this.label2 = new Class62();
		this.mlnkVersionCheck = new GClass3();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.pictureBox1.Image = Properties.Resources.debug_48;
		this.pictureBox1.Location = new System.Drawing.Point(16, 16);
		this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(48, 48);
		this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
		this.pictureBox1.TabIndex = 0;
		this.pictureBox1.TabStop = false;
		this.mlblSubCaption1.AutoSize = true;
		this.mlblSubCaption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
		this.mlblSubCaption1.Location = new System.Drawing.Point(79, 16);
		this.mlblSubCaption1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.mlblSubCaption1.Name = "m_lblSubCaption1";
		this.mlblSubCaption1.Size = new System.Drawing.Size(208, 16);
		this.mlblSubCaption1.TabIndex = 16;
		this.mlblSubCaption1.Text = "Sorry, something went wrong.";
		this.mtxtCrashReport.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		this.mtxtCrashReport.Font = new System.Drawing.Font("Courier New", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.mtxtCrashReport.Location = new System.Drawing.Point(16, 103);
		this.mtxtCrashReport.Margin = new System.Windows.Forms.Padding(4);
		this.mtxtCrashReport.Multiline = true;
		this.mtxtCrashReport.Name = "m_txtCrashReport";
		this.mtxtCrashReport.ReadOnly = true;
		this.mtxtCrashReport.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.mtxtCrashReport.Size = new System.Drawing.Size(670, 393);
		this.mtxtCrashReport.TabIndex = 17;
		this.mtxtCrashReport.WordWrap = false;
		this.mbtnSend.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.mbtnSend.Image = Properties.Resources.opts_16;
		this.mbtnSend.Location = new System.Drawing.Point(478, 513);
		this.mbtnSend.Margin = new System.Windows.Forms.Padding(4);
		this.mbtnSend.Name = "m_btnSend";
		this.mbtnSend.Size = new System.Drawing.Size(100, 36);
		this.mbtnSend.TabIndex = 18;
		this.mbtnSend.Text = "Send";
		this.mbtnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.mbtnSend.UseVisualStyleBackColor = true;
		this.mbtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.mbtnCancel.Image = Properties.Resources.cancl_16;
		this.mbtnCancel.Location = new System.Drawing.Point(586, 513);
		this.mbtnCancel.Margin = new System.Windows.Forms.Padding(4);
		this.mbtnCancel.Name = "m_btnCancel";
		this.mbtnCancel.Size = new System.Drawing.Size(100, 36);
		this.mbtnCancel.TabIndex = 19;
		this.mbtnCancel.Text = "Cancel";
		this.mbtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.mbtnCancel.UseVisualStyleBackColor = true;
		this.mlblSubCaption2.AutoSize = true;
		this.mlblSubCaption2.Location = new System.Drawing.Point(79, 48);
		this.mlblSubCaption2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.mlblSubCaption2.Name = "m_lblSubCaption2";
		this.mlblSubCaption2.Size = new System.Drawing.Size(449, 16);
		this.mlblSubCaption2.TabIndex = 15;
		this.mlblSubCaption2.Text = "A detailed error report has been created and pasted into the text box below";
		this.mlblSubCaption3.AutoSize = true;
		this.mlblSubCaption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		this.mlblSubCaption3.Location = new System.Drawing.Point(79, 74);
		this.mlblSubCaption3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.mlblSubCaption3.Name = "m_lblSubCaption3";
		this.mlblSubCaption3.Size = new System.Drawing.Size(611, 16);
		this.mlblSubCaption3.TabIndex = 23;
		this.mlblSubCaption3.Text = "You can send it to help us improve RdpGuard. We will treat this report as confidential and anonymous.";
		this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		this.label1.Location = new System.Drawing.Point(13, 510);
		this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(197, 16);
		this.label1.TabIndex = 24;
		this.label1.Text = "This bug might already be fixed.";
		this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		this.label2.Location = new System.Drawing.Point(79, 534);
		this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(319, 16);
		this.label2.TabIndex = 25;
		this.label2.Text = "to check if a newer version is available for download.";
		this.mlnkVersionCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.mlnkVersionCheck.AutoSize = true;
		this.mlnkVersionCheck.LinkColor = System.Drawing.Color.FromArgb(38, 135, 200);
		this.mlnkVersionCheck.Location = new System.Drawing.Point(13, 534);
		this.mlnkVersionCheck.Name = "m_lnkVersionCheck";
		this.mlnkVersionCheck.Size = new System.Drawing.Size(67, 16);
		this.mlnkVersionCheck.TabIndex = 26;
		this.mlnkVersionCheck.TabStop = true;
		this.mlnkVersionCheck.Text = "Click here";
		this.mlnkVersionCheck.VisitedLinkColor = System.Drawing.Color.FromArgb(38, 135, 200);
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(703, 562);
		base.Controls.Add(this.mlnkVersionCheck);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.mlblSubCaption3);
		base.Controls.Add(this.mbtnSend);
		base.Controls.Add(this.mbtnCancel);
		base.Controls.Add(this.mtxtCrashReport);
		base.Controls.Add(this.mlblSubCaption1);
		base.Controls.Add(this.mlblSubCaption2);
		base.Controls.Add(this.pictureBox1);
		this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
		base.Margin = new System.Windows.Forms.Padding(4);
		this.MinimumSize = new System.Drawing.Size(710, 400);
		base.Name = "formCrashReport";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Program Crashed";
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void mlnkVersionCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ShowOnlineHelp(Class148.Class149.String_0);
	}

	private void mbtnCancel_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.Cancel);
	}

	private void mbtnSend_Click(object sender, EventArgs e)
	{
		CloseDialog(DialogResult.OK);
	}
}
