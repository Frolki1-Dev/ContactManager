using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact_Manager.Models;

namespace Contact_Manager.Collections
{
    /**
     * Stores all trainees
     */
    [Serializable]
    class Trainees : Collection
    {
        public new Trainee this[int i]
        {
            get => (Trainee)List[i];

            set => List.Add(value);
        }

        protected override string GetDataContainerListName()
        {
            return DataContainer.Trainees;
        }
    }
}
