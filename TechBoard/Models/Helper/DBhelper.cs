using TechBoard.Models;
using TechBoard.Models.ViewModels;

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

        public Subject LoadSubject(int subjectId)
        {
            return _context.Subject.FirstOrDefault(x => x.Id == subjectId);
        }

        public List<SubjectThreadViewModel> LoadThreads(int subjectId)
        {
            var threadsAndSubjects = _context.Thread
                                    .Join(
                                        _context.Subject,
                                        thread => thread.SubjectRefId,
                                        subject => subjectId,
                                        (thread, subject) => new SubjectThreadViewModel
                                        {
                                            // Select the properties you need from both tables
                                            ThreadId = thread.Id,
                                            SubjectTitle = subject.Title,
                                            ThreadHeading = thread.Heading,
                                        }
                                    )
                                    .ToList(); // Materialize the query to a list

            return threadsAndSubjects;
        }

        public List<ThreadPostViewModel> LoadPosts(int threadId)
        {
            var postAndThread = _context.Post
                                    .Join(
                                        _context.Thread,
                                        post => post.ThreadRefId,
                                        thread => threadId,
                                        (post, thread) => new ThreadPostViewModel
                                        {
                                            // Select the properties you need from both tables
                                            PostId = thread.Id,
                                            PostTitle = post.Title,
                                            ThreadHeading = thread.Heading,
                                            TextBody = post.TextBody
                                        }
                                    )
                                    .ToList(); // Materialize the query to a list

            return postAndThread;
        }
    }
}
