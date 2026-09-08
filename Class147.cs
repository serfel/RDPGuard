internal static class Class147
{
	public static readonly string string_0 = "Please wait, connecting activation server..";

	public static readonly string string_1 = "Your license has been successfully activated. Thank you!";

	public static readonly string string_2 = "Your license has been successfully deactivated.";

	public static string smethod_0(GEnum19 genum19_0)
	{
		if (1 == 0)
		{
		}
		string result = genum19_0 switch
		{
			GEnum19.const_8 => "Unknown error ocurred on activation server. Please contact us.", 
			GEnum19.Registered => "The key was disabled and can not be used.", 
			GEnum19.const_2 => "Chargeback received for this key. The key can not be used.", 
			GEnum19.const_3 => "Refund issued for this key. The key can not be used.", 
			GEnum19.const_4 => "Activation limit exceeded for this License key.\r\n\r\nWould you like to obtain an additional key with discount?", 
			GEnum19.const_6 => "Connection Error: please make sure RdpGuard service process (rdpguard-svc.exe) is allowed to connect activation server at rdpguard.com", 
			GEnum19.const_7 => string.Format("This license key can not be used to activate {0} {1}", "RdpGuard", Class138.version_0) + ".\r\n\r\nEach license includes one year of free upgrades and support.\r\n\r\nWould you like to obtain an additional year with 40% discount?", 
			_ => "Invalid License Key. Please check the License key you entered.", 
		};
		if (1 == 0)
		{
		}
		return result;
	}
}
