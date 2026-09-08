using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

internal class Control2 : UserControl
{
	private EventHandler eventHandler_0;

	private EventHandler eventHandler_1;

	private bool bool_0;

	private readonly Size size_0;

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			eventHandler_1?.Invoke(this, EventArgs.Empty);
		}
	}

	public virtual Size Size_0 => size_0;

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

	public event EventHandler Event_1
	{
		add
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		remove
		{
			EventHandler eventHandler = eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_1, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	protected virtual void OnFormClosing()
	{
	}

	protected virtual void InitializeFormPosition()
	{
	}

	public Control2()
	{
		OnFormClosing();
		InitializeFormPosition();
		Form0.smethod_3(this, InitializeHandlers, AdjustFormSize);
		AdjustFormSize();
	}

	protected virtual void AdjustFormSize()
	{
	}

	private void InitializeHandlers()
	{
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}
}
