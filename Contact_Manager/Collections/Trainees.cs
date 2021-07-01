using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    [Serializable]
    class Trainees : CollectionBase
    {
        public void Add(Trainee user)
        {
            List.Add(user);
        }

        public Trainee this[int i]
        {
            get => (Trainee)List[i];

            set => List.Add(value);
        }
    }
}
