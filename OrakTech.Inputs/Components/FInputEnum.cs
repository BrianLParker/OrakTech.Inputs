namespace OrakTech.Inputs.Components
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Microsoft.AspNetCore.Components;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Rendering;

    public class FInputEnum<TValue> : InputBase<TValue>, IFocusInput
    {

        public ElementReference Element { get; set; }

        [Parameter]
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public RenderFragment<TValue>? ChildContent { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "select");
            builder.AddMultipleAttributes(1, AdditionalAttributes);
            builder.AddAttribute(2, "class", CssClass);
            builder.AddAttribute(3, "value", BindConverter.FormatValue(CurrentValueAsString));
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
            builder.AddAttribute(4, "onchange", EventCallback.Factory.CreateBinder<string?>(this, __value => CurrentValueAsString = __value, CurrentValueAsString));
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
            if (ChildContent is not null)
            {
                foreach (var enumValue in enumValues)
                {

                    builder.AddContent(1, ChildContent(enumValue));
                }
            }
            else
            {
                foreach (var enumValue in enumValues)
                {
                    builder.OpenElement(1, "option");
                    builder.AddAttribute(2, "value", enumValue);
                    builder.AddContent(3, enumValue);
                    builder.CloseElement();
                }
            }
            builder.AddElementReferenceCapture(5, (__ref) => { Element = __ref; });
            builder.CloseElement();
        }

        IReadOnlyList<TValue> enumValues => Enum.GetValues(typeof(TValue)).Cast<TValue>().ToArray();

        protected override bool TryParseValueFromString(
                string value,
                [MaybeNullWhen(false)] out TValue result,
                [NotNullWhen(false)] out string validationErrorMessage)
        {
            validationErrorMessage = "";
            var parseOk = Enum.TryParse(typeof(TValue), value, out var parseResult);
            if (parseOk)
            {
                result = (TValue)parseResult;
                return parseOk;
            }
            else
            {
                validationErrorMessage = $"Failed to pass value {value}";
                result = default;
                return false;
            }
        }
    }
}
