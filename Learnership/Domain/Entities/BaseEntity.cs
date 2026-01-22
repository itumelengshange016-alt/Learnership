using System;

namespace Learnership.Domain.Entities
{
    public abstract class BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; }
        public int RecordStatusId { get; set; } // Assuming 1 = Active
    }
}
