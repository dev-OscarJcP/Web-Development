namespace DevFreela.Models
{
    public class CreateCommentModel
    {
        public int IdComment { get; set; }
        public int IdProject { get; set; }
        public string ContentComment { get; set; }
        public int IdUserComment { get; set; }
        public DateTime DateCreatedComment { get; set; }
    }
}
