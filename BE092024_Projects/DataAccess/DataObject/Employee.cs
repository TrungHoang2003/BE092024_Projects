using DataAccess.Interface;

namespace DataAccess.DataObject.Employee
{
    public class Employe: IEmployee
    {
        private string id { get; set; }
        private string name { get; set; }
        private string gender { get; set; }
        private double basicSalary { get; set; }
        private double coefficient { get; set; }
        private double allowance { get; set; }
        private double totalSalary { get; set; }
        
        public Employe(string name, string id, string gender, double basicSalary, double coefficient, double allowance, double totalSalary)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.basicSalary = basicSalary;
            this.coefficient = coefficient;
            this.allowance = allowance;
            this.totalSalary = totalSalary;
        }

        public void addEmployee()
        {
        }

        public void searchEmployee()
        {
        }
    }
}