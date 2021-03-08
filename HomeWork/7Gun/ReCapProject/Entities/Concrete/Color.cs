using Entities.Abstract;

namespace Entities.Concrete
{
    public class Color:IEntity
    {
        public string ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
