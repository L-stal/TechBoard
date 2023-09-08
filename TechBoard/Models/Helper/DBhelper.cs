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

        public List<SubjectViewModel> LoadSubjects()
        {
            var subjects = _context.Subject
                .Select(subject => new SubjectViewModel
                {
                    Id = subject.Id,
                    Title = subject.Title,
                }
            )
            .ToList();

            return subjects;
        }

        public List<SubjectThreadViewModel> LoadThreads(int subjectId)
        {
            var threadsAndSubjects = _context.Thread
                                    .Where(thread => thread.SubjectRefId == subjectId)
                                    .Join(
                                        _context.Subject,
                                        thread => thread.SubjectRefId,
                                        subject => subject.Id,
                                        (thread, subject) => new SubjectThreadViewModel
                                        {
                                            // Select the properties you need from both tables
                                            ThreadId = thread.Id,
                                            ThreadHeading = thread.Heading,
                                            SubjectRefId = subject.Id,
                                        }
                                    )
                                    .ToList(); // Materialize the query to a list

            return threadsAndSubjects;
        }

        public List<ThreadPostViewModel> LoadPosts(int threadId)
        {
            var postAndThread = _context.Post
                                    .Where(post => post.ThreadRefId == threadId)
                                    .Join(
                                        _context.Thread,
                                        post => post.ThreadRefId,
                                        thread => thread.Id,
                                        (post, thread) => new ThreadPostViewModel
                                        {
                                            // Select the properties you need from both tables
                                            PostId = thread.Id,
                                            PostTitle = post.Title,
                                            TextBody = post.TextBody,
                                            ThreadRefId = thread.Id,
                                        }
                                    )
                                    .ToList(); // Materialize the query to a list

            return postAndThread;
        }

        //Edit data in post
        public void EditPost(int postId, string textBody, string? title)
        {
            Post post = (from x in _context.Post
                         where x.Id == postId
                         select x).First();
            post.TextBody = textBody;
            if (title != null)
                post.Title = title;
            _context.SaveChanges();
        }

        public void EditThread(int threadId, string heading)
        {
            Models.Thread thread = (from x in _context.Thread
                                    where x.Id == threadId
                                    select x).First();
            thread.Heading = heading;
            _context.SaveChanges();
        }

        public void EditSubject(int subjectId, string title)
        {
            Subject subject = (from x in _context.Subject
                               where x.Id == subjectId
                               select x).First();
            subject.Title = title;
            _context.SaveChanges();
        }
        public void AddPost(Post newpost)
        {
            _context.Post.Add(newpost);
            _context.SaveChanges();
        }
        public void AddThread(Models.Thread newThread)
        {
            _context.Thread.Add(newThread);
            _context.SaveChanges();
        }
        public void AddThreadPost(Models.Thread newThread, Post newThreadPost)
        {
            // Set the relationship between Thread and Post
            newThread.Posts = new List<Post> { newThreadPost };
            newThreadPost.Thread = newThread;

            _context.Post.Add(newThreadPost);
            _context.Thread.Add(newThread);
            _context.SaveChanges();
        }
    }
}
