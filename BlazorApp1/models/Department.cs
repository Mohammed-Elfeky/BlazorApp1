using System.Collections.Generic;

namespace BlazorApp1.models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }=new List<Employee>();
    }
}
