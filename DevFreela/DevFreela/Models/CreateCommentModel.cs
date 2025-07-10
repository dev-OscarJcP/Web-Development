namespace DevFreela.Models
{
    public class CreateCommentModel
    {
        public int IdComment { get; set; }
        public string ContentComment { get; set; }
        public string UserComment { get; set; }
        public DateTime DateCreatedComment { get; set; }
    }
}
