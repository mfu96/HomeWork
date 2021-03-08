using System;
using GameProject.Abstract;

namespace GameProject.Entities
{
    public class Customer:IEntity,IGames
    {
        public string Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
        public void Buy(Games game)
        {
            throw new NotImplementedException();
        }
    }
}