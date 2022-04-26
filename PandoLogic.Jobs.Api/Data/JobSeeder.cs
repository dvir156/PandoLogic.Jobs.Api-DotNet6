using PandoLogic.Jobs.Api.Models;

namespace PandoLogic.Jobs.Api.Data
{
    public class JobSeeder
    {
        private readonly JobContext _jobDbContext;

        public JobSeeder(JobContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }

        public void Seed()
        {
            if (!_jobDbContext.Jobs.Any())
            {
                var jobs = new List<JobData>();
                var rnd = new Random();

                for (int i = 1; i < 100; i++)
                {
                    var newJob = new JobData
                    {
                        Active = i * rnd.Next(6),
                        Views = i * rnd.Next(4),
                        Predicted = i * rnd.Next(5),
                        Date = DateTime.Now.AddDays(i)
                    };
                    jobs.Add(newJob);   
                }

                _jobDbContext.Jobs.AddRange(jobs);
                _jobDbContext.SaveChanges();
            }
        }
    }
}
