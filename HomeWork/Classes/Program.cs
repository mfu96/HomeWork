namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Updated();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Updated();

            
        }
        
    }
}
