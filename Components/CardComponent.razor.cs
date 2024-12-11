using Microsoft.AspNetCore.Components;

namespace ZCodBlazorCourse.Components
{
    public partial class CardComponent
    {
        [Parameter , EditorRequired]
        public string Image { get; set; }
        [Parameter, EditorRequired]
        public string Title { get; set; }
        [Parameter]
        public string? Description { get; set; }
    }
}