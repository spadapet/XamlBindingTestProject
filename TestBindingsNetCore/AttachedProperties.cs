using System.Windows;

namespace TestBindings
{
    internal static class AttachedProperties
    {
        public static readonly DependencyProperty IsBubbleSourceProperty = DependencyProperty.RegisterAttached(
          "IsBubbleSource",
          typeof(bool),
          typeof(AttachedProperties),
          new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));

        internal static void SetIsBubbleSource(UIElement element, bool value)
        {
            element.SetValue(IsBubbleSourceProperty, value);
        }

        internal static bool GetIsBubbleSource(UIElement element)
        {
            return (bool)element.GetValue(IsBubbleSourceProperty);
        }
    }
}
