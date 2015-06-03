namespace Freelancer.Data.UnitOfWork
{

    using Freelancer.Data;
    using Freelancer.Data.Repositories;
    using Freelancer.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;


    public class FreelancerData : IFreelancerData
    {
        private ApplicationDbContext context;
        private IDictionary<Type, object> repositories;

        public FreelancerData(ApplicationDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public UsersRepository Users
        {
            get { return (UsersRepository)this.GetRepository<User>(); }
        }

        public ExamsRepository Exams
        {
            get { return (ExamsRepository)this.GetRepository<Exam>(); }
        }

        public NotificationsRepository Notifications
        {
            get { return (NotificationsRepository)this.GetRepository<Notification>(); }
        }

        public MessagesRepository Messages
        {
            get { return (MessagesRepository)this.GetRepository<Message>(); }
        }

        public ProjectsRepository Projects
        {
            get { return (ProjectsRepository)this.GetRepository<Project>(); }
        }

        public ProjectEmployeesRepository ProjectEmployees
        {
            get { return (ProjectEmployeesRepository)this.GetRepository<ProjectEmployee>(); }
        }


        public BiddingProjectEmployeesRepository BiddingProjectEmployees
        {
            get { return (BiddingProjectEmployeesRepository)this.GetRepository<BiddingProjectEmployee>(); }
        }

        public QuestionsRepository Questions
        {
            get { return (QuestionsRepository)this.GetRepository<Question>(); }
        }

        public SkillsRepository Skills
        {
            get { return (SkillsRepository)this.GetRepository<Skill>(); }
        }

        public ReviewsRepository Reviews
        {
            get { return (ReviewsRepository)this.GetRepository<Review>(); }
        }

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                var typeOfRepository = typeof(GenericRepository<T>);

                if (type.IsAssignableFrom(typeof(User)))
                {
                    typeOfRepository = typeof(UsersRepository);
                }

                if (type.IsAssignableFrom(typeof(Project)))
                {
                    typeOfRepository = typeof(ProjectsRepository);
                }

                if (type.IsAssignableFrom(typeof(Message)))
                {
                    typeOfRepository = typeof(MessagesRepository);
                }

                if (type.IsAssignableFrom(typeof(ProjectEmployee)))
                {
                    typeOfRepository = typeof(ProjectEmployeesRepository);
                }

                if (type.IsAssignableFrom(typeof(BiddingProjectEmployee)))
                {
                    typeOfRepository = typeof(BiddingProjectEmployeesRepository);
                }

                if (type.IsAssignableFrom(typeof(Notification)))
                {
                    typeOfRepository = typeof(NotificationsRepository);
                }

                if (type.IsAssignableFrom(typeof(Exam)))
                {
                    typeOfRepository = typeof(ExamsRepository);
                }

                if (type.IsAssignableFrom(typeof(Question)))
                {
                    typeOfRepository = typeof(QuestionsRepository);
                }

                if (type.IsAssignableFrom(typeof(Review)))
                {
                    typeOfRepository = typeof(ReviewsRepository);
                }

                if (type.IsAssignableFrom(typeof(Skill)))
                {
                    typeOfRepository = typeof(SkillsRepository);
                }

                var repository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(type, repository);
            }

            return (IRepository<T>)this.repositories[type];
        }
    }
}

