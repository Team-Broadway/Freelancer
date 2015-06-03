using Freelancer.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Freelancer.Data.UnitOfWork
{
    public interface IFreelancerData
    {
        UsersRepository Users { get; }
       
        ExamsRepository Exams { get; }
      
        NotificationsRepository Notifications { get; }

        MessagesRepository Messages { get; }
       
        ProjectsRepository Projects { get; }
       
        ProjectEmployeesRepository ProjectEmployees { get; }

        BiddingProjectEmployeesRepository BiddingProjectEmployees { get; }
       
        QuestionsRepository Questions { get; }
      
        SkillsRepository Skills { get; }

        ReviewsRepository Reviews { get; }
       
        int SaveChanges();
    }
}
