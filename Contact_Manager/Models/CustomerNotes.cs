using Contact_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Models
{
    [Serializable]
   public class CustomerNotes : IIdentifier
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }

        public string Notes { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}
