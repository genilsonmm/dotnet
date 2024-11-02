using Quiz.API.Data.Entity;

namespace Quiz.API.Dto
{
    public class AskDTO
    {
        public string Title { get; set; }

        public AnswerDTO Answer { get; set; }

    }
}
