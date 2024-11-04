namespace DataAccess.DataObject
{
    public class Animal
    {
        private string Name{ get; set; }

        public Animal()
        {
        }
            
        public Animal(string name)
        {
            Name = name;
        }

        public string getName()
        {
            return Name;
        }
       public void show(){} 
    }
    
}