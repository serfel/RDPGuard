using System;
using System.Drawing;
using System.Windows.Forms;

internal abstract class Class53 : TextBox
{
	public Image image_0 = new Bitmap(16, 16);

	public Image image_1 = new Bitmap(16, 16);

	public Image image_2;

	private PictureBox pictureBox_0;

	public EventHandler eventHandler_0;

	public string String_0
	{
		set
		{
			new ToolTip().SetToolTip(PictureBox_0, value);
		}
	}

	private PictureBox PictureBox_0
	{
		get
		{
			if (pictureBox_0 == null)
			{
				pictureBox_0 = new PictureBox
				{
					Cursor = Cursors.Hand,
					Image = image_1,
					Size = new Size(16, 16)
				};
				pictureBox_0.MouseEnter += pictureBox_0_MouseEnter;
				pictureBox_0.MouseLeave += pictureBox_0_MouseLeave;
				pictureBox_0.MouseDown += pictureBox_0_MouseDown;
				pictureBox_0.MouseUp += pictureBox_0_MouseUp;
				pictureBox_0.Click += pictureBox_0_Click;
				base.Controls.Add(pictureBox_0);
			}
			return pictureBox_0;
		}
	}

	protected abstract void OnFormClosing();

	private void method_0(bool bool_0)
	{
		PictureBox_0.Image = ((bool_0 ? true : false) ? image_0 : image_1);
	}

	protected override void OnEnabledChanged(EventArgs eventArgs_0)
	{
		base.OnEnabledChanged(eventArgs_0);
		PictureBox_0.Enabled = base.Enabled;
		PictureBox pictureBox = PictureBox_0;
		Image image;
		if (!base.Enabled)
		{
			image = image_2;
			if (image == null)
			{
				image = image_1;
			}
		}
		else
		{
			image = image_1;
		}
		pictureBox.Image = image;
	}

	protected override void OnSizeChanged(EventArgs eventArgs_0)
	{
		base.OnSizeChanged(eventArgs_0);
		PictureBox_0.Location = new Point(base.ClientSize.Width - PictureBox_0.Width - 2, (base.ClientSize.Height - PictureBox_0.Height) / 2);
	}

	protected override void OnMouseEnter(EventArgs eventArgs_0)
	{
		base.OnMouseEnter(eventArgs_0);
		method_0(bool_0: true);
	}

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		base.OnMouseLeave(eventArgs_0);
		method_0(bool_0: false);
	}

	protected override void OnEnter(EventArgs eventArgs_0)
	{
		base.OnEnter(eventArgs_0);
		method_0(bool_0: true);
	}

	protected override void OnLeave(EventArgs eventArgs_0)
	{
		base.OnLeave(eventArgs_0);
		method_0(bool_0: false);
	}

	protected override void OnClick(EventArgs eventArgs_0)
	{
		eventHandler_0?.Invoke(this, eventArgs_0);
		base.OnClick(eventArgs_0);
	}

	protected override void OnMouseDoubleClick(MouseEventArgs mouseEventArgs_0)
	{
		OnFormClosing();
		base.OnMouseDoubleClick(mouseEventArgs_0);
	}

	private void pictureBox_0_MouseEnter(object sender, EventArgs e)
	{
		method_0(bool_0: true);
	}

	private void pictureBox_0_MouseLeave(object sender, EventArgs e)
	{
		method_0(bool_0: false);
	}

	private void pictureBox_0_MouseDown(object sender, MouseEventArgs e)
	{
		pictureBox_0.Image = image_1;
	}

	private void pictureBox_0_MouseUp(object sender, MouseEventArgs e)
	{
		pictureBox_0.Image = image_0;
	}

	private void pictureBox_0_Click(object sender, EventArgs e)
	{
		OnFormClosing();
	}
}
