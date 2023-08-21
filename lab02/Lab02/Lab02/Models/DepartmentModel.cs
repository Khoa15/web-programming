namespace Lab02.Models
{
    public class DepartmentModel
    {
        public String name { get; set; }
        public DepartmentModel() {
            name = String.Empty;
        }
        public DepartmentModel(String name)
        {
            this.name = name;
        }
    }
}
