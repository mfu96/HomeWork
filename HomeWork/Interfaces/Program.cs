using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeManager();
            employeeManager.Add();
            Console.WriteLine("--------");

            ProjectManager projectManager = new ProjectManager();
            projectManager.AddCustomer(new CustomerManager());
            projectManager.AddEmployee(new EmployeManager());
            Console.WriteLine("------");

            ProjectManager2 projectManager2 = new ProjectManager2();
            projectManager2.Add(customerManager);   //Yukarıda new'lediğim için burada gerek yok
            projectManager2.Updated(new InternManager());


        }
    }

    //Aslen İnterface'de yapılmak istenen aynı imzada olan kodları tekrar etmemek ve
    //imza sayısını en aza inirdimek diye adlandırabliriz
    //Örneğe bakacak olursak Her Person/Kişi için Add operasyonu var ama işçi için farklı
    //müşteir için farklı vs vs
    //biz burda Add operasyonunu ayarlayıp her birim kendi kodunu yazması için bir
    //olanak sağlamış oluyoruz
    
    
    //İnterface'ler new'lenemez!!!
    interface IPersonManager

    {
    //unnimplemented operation
    void Add();
    void Update();
    }
    

    class CustomerManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeManager:IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager:IPersonManager      //Mesela satjyer hiç hesapta yoktu ama eklemek
                                            //zorunda kaldık yanlız tek yaptığımız class'ı
                                            //ekleyip interface'ini göstermek gerisi
                                            //zaten bildiğimiz şeyler
                                            
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager    //Burada yaptığım gibi ayrı ayrı yazmak yerine 2 de olduuğu 
                            //gibi yapmak daha mantıklı
    {
        public void AddCustomer(CustomerManager customerManager)
        {
            customerManager.Add();
        }
        public void AddEmployee(EmployeManager employeManager)
        {
            employeManager.Add();
        }
    }

    class ProjectManager2
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        public void Updated(IPersonManager personManager)
        {
            personManager.Update();
        }
        
    }
    }
