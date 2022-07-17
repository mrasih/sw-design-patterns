namespace FactoryMethod
{
    public abstract class Workplace
    {
        // a workplace has one or more workers
        private readonly List<IWorker> _workers;

        public Workplace()
        {
            _workers = new();
            HireWorkers();
        }

        public List<IWorker> GetWorkers()
        {
            return _workers;
        }

        public abstract void HireWorkers();
    }

    public class SoftwareCompany : Workplace
    {
        public override void HireWorkers()
        {
            List<IWorker> workers = this.GetWorkers();
            workers.Add(new CEO());
            workers.Add(new CTO());
            workers.Add(new SoftwareProjectManager());
            workers.Add(new TeamLeader());
            workers.Add(new BackendDeveloper());
            workers.Add(new FrontendDeveloper());
            workers.Add(new DevOpsEngineer());
            workers.Add(new SoftwareTestEngineer());
        }
    }

    public class Factory : Workplace
    {
        public override void HireWorkers()
        {
            List<IWorker> workers = this.GetWorkers();
            workers.Add(new CEO());
            workers.Add(new OperationsManager());
            workers.Add(new ProductionEngineer());
            workers.Add(new QualityEngineer());
            workers.Add(new Technician());
        }
    }
}

