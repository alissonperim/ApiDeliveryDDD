using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDeliveryDDD.Domain.Entities
{
    public class BaseClass
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? AlterationDate { get; set; }
        public bool IsActive { get; set; }

        public BaseClass()
        {
        }

        public BaseClass(int id, DateTime creationDate, DateTime alterationDate, bool isActive)
        {
            Id = id;
            CreationDate = creationDate;
            AlterationDate = alterationDate;
            IsActive = isActive;
        }
    }
}
