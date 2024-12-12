using ZCodBlazorCourse.Components;

namespace ZCodBlazorCourse.Pages
{
    public partial class Home
    {
        private List<BlogDto> blogs = new();
        //private List<CardComponentDto> cardComponentData = new();
        protected override void OnInitialized()
        {
            blogs.Add(new BlogDto
            {
                Id = 1,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut",
                Image = "/images/1.webp",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut"
            });
            blogs.Add(new BlogDto
            {
                Id = 2,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut",
                Image = "/images/2.webp",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut"
            });
            blogs.Add(new BlogDto
            {
                Id = 3,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut",
                Image = "/images/3.webp",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut"
            });
            blogs.Add(new BlogDto
            {
                Id = 4,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut",
                Image = "/images/4.webp",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut"
            });
            blogs.Add(new BlogDto
            {
                Id = 5,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut",
                Image = "/images/5.webp",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut"
            });
            blogs.Add(new BlogDto
            {
                Id = 6,
                Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut",
                Image = "/images/6.webp",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut"
            });

            //blogs.ForEach(p =>
            //{
            //    var card = new CardComponentDto
            //    {
            //        Id = p.Id,
            //        Title = p.Title , 
            //        Description = p.Description , 
            //        Image = p.Image , 
            //        Icon = "far fa-check"
            //    };

            //    cardComponentData.Add(card);
            //});
            base.OnInitialized();
        }
    }
    public class BlogDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Image { get; set; }
    }
}