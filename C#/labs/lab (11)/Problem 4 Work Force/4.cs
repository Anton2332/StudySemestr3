using Problem_4_Work_Force;
JobList jobs = new JobList();
List<IEmployee> employees = new List<IEmployee>();

while (true)
{
    string str = Console.ReadLine();
    if(str.ToLower() == "end")
    {
        break;
    }
    string [] arrStr = str.Split(" ");
    switch (arrStr[0])
    {
        case "Job":
            Job job = new Job(employees.FirstOrDefault(e => e.Name == arrStr[3]), arrStr[1], int.Parse(arrStr[2]));
            jobs.Add(job);
            job.JobFinished += jobs.OnJobFinished;
            break;
        case "StandardEmployee":
            StandardEmployee standardEmployee = new StandardEmployee(arrStr[1]);
            employees.Add(standardEmployee);
            break ;
        case "PartTimeEmployee":
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee(arrStr[1]);
            employees.Add(partTimeEmployee);
            break;
        case "Pass":
            foreach(var i in jobs.ToList())
            {
                i.Update();
            }
            break;
        case "Status":
            foreach(var i in jobs)
            {
                Console.WriteLine(i.ToString());
            }
            break;
    }
}





