﻿namespace tourism_system.Domain.Abstraction
{
    public class ValueObjectId : ValueObject
    {
        public Guid value { get; private set; }

        protected ValueObjectId(Guid id)
        {
            value = id;
        }

        public static ValueObjectId Create(Guid id)
        {
            return new(id);
        }

        public static ValueObjectId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return value;
        }
    }
}