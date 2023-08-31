using TechBoard.Models;

namespace TechBoard.Helper
{
    public class DBhelper
    {
        private readonly DataContext _context;

        public DBhelper(DataContext context)
        {
            _context = context;
        }

        public List<Subject> LoadSubjects()
        {
            return _context.Subject.ToList();
        }

        public List<Models.Thread> LoadThreads(int subjectId)
        {
            return _context.Thread.Where(x => x.SubjectRefId == subjectId).ToList();
        }

        public List<Post> LoadPosts(int threadId)
        {
            return _context.Post.Where(x => x.ThreadRefId == threadId).ToList();
        }
    }
}
