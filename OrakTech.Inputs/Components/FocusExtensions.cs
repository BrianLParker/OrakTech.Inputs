namespace OrakTech.Inputs.Components
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public static class FocusExtensions
    {
        public static ValueTask FocusAsync(this IFocusInput focusInput)
            => focusInput.Element.FocusAsync();
    }
}
