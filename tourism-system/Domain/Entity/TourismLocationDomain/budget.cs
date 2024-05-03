using tourism_system.Domain.Abstraction;

namespace tourism_system.Domain.Entity.TourismLocationDomain
{
    public class budget : ValueObject
    {
        public int from {  get; set; }
        public int to { get; set; }
        public budget(int from ,int to)
        {
            this.from = from;
            this.to = to;
        }

        public static budget Create(int from,int to)
        {
            return new(from,to);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return from;
            yield return to;
        }
    }
}
