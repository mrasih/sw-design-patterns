namespace FactoryMethod
{
    public interface IWorker
    {
        public string Work();
    }

    public class CEO : IWorker {
        public string Work()
        {
            return "I manage the whole company.";
        }
    }

    public class CTO : IWorker {
        public string Work()
        {
            return "I manage the technology department.";
        }
    }

    public class SoftwareProjectManager : IWorker {
        public string Work()
        {
            return "I manage the software projects.";
        }
    }

    public class TeamLeader : IWorker {
        public string Work()
        {
            return "I manage the software development team.";
        }
    }

    public class BackendDeveloper : IWorker {
        public string Work()
        {
            return "I develop backend of a software.";
        }
    }

    public class FrontendDeveloper : IWorker {
        public string Work()
        {
            return "I develop frontend of a software.";
        }
    }

    public class DevOpsEngineer : IWorker {
        public string Work()
        {
            return "I shorten the software development life cycle and provide continuous software product delivery with high quality.";
        }
    }

    public class SoftwareTestEngineer : IWorker {
        public string Work()
        {
            return "I test the software developed so far by the softwre development team to ensure that it works perfectly.";
        }
    }

    public class OperationsManager : IWorker {
        public string Work()
        {
            return "I manager production in the factory.";
        }
    }

    public class ProductionEngineer : IWorker {
        public string Work()
        {
            return "I design how a product must be produced in fastest and cheapest way possible in the factory.";
        }
    }

    public class QualityEngineer : IWorker {
        public string Work()
        {
            return "I check the quality of the products that are produced in the factory.";
        }
    }

    public class Technician : IWorker {
        public string Work()
        {
            return "I follow the instructions to produce the product.";
        }
    }
}

