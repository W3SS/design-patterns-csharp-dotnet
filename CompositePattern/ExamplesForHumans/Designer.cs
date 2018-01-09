namespace CompositePattern.ExamplesForHumans
{
    public class Designer : IEmployee
    {
        protected float salary;
        protected string name;
        protected string[] roles;

        public Designer(string name, float salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetSalary(float salary)
        {
            this.salary = salary;
        }

        public float GetSalary()
        {
            return this.salary;
        }

        public string[] GetRoles()
        {
            return this.roles;
        }
    }
}
