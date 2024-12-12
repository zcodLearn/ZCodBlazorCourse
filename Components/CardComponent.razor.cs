using Microsoft.AspNetCore.Components;
using ZCodBlazorCourse.Pages;

namespace ZCodBlazorCourse.Components
{
    public partial class CardComponent<TValue>
    {
        //[Parameter , EditorRequired]
        //public string Image { get; set; }
        //[Parameter, EditorRequired]
        //public string Title { get; set; }
        //[Parameter]
        //public string? Description { get; set; }
        //[Parameter ,EditorRequired]
        //public BlogDto Blog { get; set; }
        //[Parameter , EditorRequired]
        //public CardComponentDto Data { get; set; }
        [Parameter , EditorRequired]
        public TValue Data { get; set; }
        [Parameter, EditorRequired]
        public string ImageName { get; set; }
        [Parameter, EditorRequired]
        public string TitleName { get; set; }
        [Parameter, EditorRequired]
        public string DescriptionName { get; set; }

        private string title;
        private string image;
        private string? description;
        protected override void OnInitialized()
        {
            var dataType = Data.GetType();
            if (dataType is not null)
            {
                var getTitleProp = dataType.GetProperty(TitleName)?.GetValue(Data, null);
                title = getTitleProp?.ToString();

                var getImageProp = dataType.GetProperty(ImageName)?.GetValue(Data, null);
                image = getImageProp?.ToString();

                var getDescription = dataType.GetProperty(DescriptionName)?.GetValue(Data, null);
                description = getDescription?.ToString();
            }
            base.OnInitialized();
        }
    }

    //public class CardComponentDto
    //{
    //    public int Id { get; set; }
    //    public string Title { get; set; }
    //    public string Image { get; set; }
    //    public string? Description { get; set; }
    //    public string? Icon { get; set; }
    //}
}