using System.Collections.Generic;

namespace Problem_4_Work_Force
{
    internal class JobList : List<Job>
    {
        public void OnJobFinished(object sender, JobEventArgs args)
        {
            args.Job.JobFinished -= OnJobFinished;
            Remove(args.Job);
        }
    }
}
