using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Xamarin.Forms.Platform.iOS
{
	public static class VisualElementExtensions
	{
		// TODO hartez duplicate this for the other platforms 

		public static bool UseLegacyColorManagement<T>(this T element) where T : VisualElement, IElementConfiguration<T>
		{
			// Determine whether we're letting the VSM handle the colors or doing it the old way
			// or disabling the legacy color management and doing it the old-old (pre 2.0) way
			return VisualStateManager.GetVisualStateGroups(element) == null
					&& element.OnThisPlatform().GetIsLegacyColorModeEnabled();
		}
	}
}