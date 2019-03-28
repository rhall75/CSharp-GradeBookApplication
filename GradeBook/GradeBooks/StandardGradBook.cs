using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradBook: BaseGradeBook
    {
        public StandardGradBook(string name): base(name)
        {
            this.Type = GradeBookType.Standard;
        }
    }
}
