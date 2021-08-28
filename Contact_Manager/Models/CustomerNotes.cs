using Contact_Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_Manager.Models
{
    /**
     * Customer notes object
     */
    [Serializable]
    public class CustomerNotes
    {
        public string Notes { get; set; }

        public DateTime CreatedAt { get; set; }

        public string CreatedFrom { get; set; }

        public CustomerNotes(string note, string createdFrom, DateTime createdAt)
        {
            Notes = note;
            CreatedAt = createdAt;
            CreatedFrom = createdFrom;
        }

        public CustomerNotes(string note)
        {
            Notes = note;
            CreatedAt = DateTime.Now;
            CreatedFrom = Authentication.Authentication.GetUser().Username;
        }
    }
}