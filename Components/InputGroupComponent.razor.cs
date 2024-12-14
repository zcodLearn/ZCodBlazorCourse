using Microsoft.AspNetCore.Components;

namespace ZCodBlazorCourse.Components
{
    public partial class InputGroupComponent
    {
        [Parameter]
        public string? DisplayName { get; set; }
        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        [Parameter]
        public RenderFragment? ButtonTemplate { get; set; }

        private async Task OnChangeValue(ChangeEventArgs args)
        {
            var value = args?.Value?.ToString();
            Value = value;
            if (ValueChanged.HasDelegate) 
            {
                await ValueChanged.InvokeAsync(value);
            }
        }
    }
}