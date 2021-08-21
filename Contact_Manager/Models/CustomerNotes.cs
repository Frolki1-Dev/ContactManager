using Contact_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Models
{
    [Serializable]
   public class CustomerNotes
    {
        public string Notes { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedFrom { get; set; }

        public CustomerNotes(string note, string created_from, DateTime created_at)
        {
            this.Notes = note;
            this.CreatedAt = created_at;
            this.CreatedFrom = created_from;
        }
        public CustomerNotes(string note)
        {
            this.Notes = note;
            this.CreatedAt = DateTime.Now;
            this.CreatedFrom = Authentication.Authentication.GetUser().Username;
        }
    }
}
