using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.OffsetDateTime
{
    public struct OffsetDateTime : IEquatable<OffsetDateTime>
    {
        public DateTime Value { get; init; }
        public TimeSpan Offset {  get; init; }

        public OffsetDateTime(int year, int month, int day, int hour, int minute, int second, TimeSpan offset)
        {
            Value = new DateTime(year, month, day, hour, minute, second);
            Offset = offset;
        }

        public bool Equals(OffsetDateTime other)
        {
            return Value.Add(Offset).Equals(other.Value.Add(other.Offset));
        }
    }
}
