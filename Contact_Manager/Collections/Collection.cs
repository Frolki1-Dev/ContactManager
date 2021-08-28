using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using Contact_Manager.Interfaces;

namespace Contact_Manager.Collections
{
    /**
     * Extend the CollectionBase function with our important functions
     */
    [Serializable]
    public abstract class Collection : CollectionBase
    {
        /**
         * Get the next ID of the resource
         */
        protected int GetNextId()
        {
            if (List.Count < 1)
            {
                // The start index
                return 1;
            }

            // Convert the IList to a normal list
            List<IIdentifier> list = List.Cast<IIdentifier>().ToList();
            // Get the max id from the list
            int max = list.Max(u => u.Id);
            // Add one to the max id
            return max + 1;
        }

        /**
         * Get the list index from the given id
         */
        protected int GetIndexFromId(int id)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (this[i].Id == id)
                {
                    return i;
                }
            }

            return 0;
        }

        /**
         * Get a resource by ID
         */
        public dynamic GetById(int id)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (this[i].Id == id)
                {
                    return this[i];
                }
            }

            return null;
        }

        /**
         * Save the list into the binary data
         */
        protected void Save()
        {
            DataContainer.SaveList(GetDataContainerListName());
        }

        /**
         * Adds a new object to the list
         */
        public void Add(dynamic obj)
        {
            // Set the id
            obj.Id = GetNextId();

            // Add the user
            List.Add(obj);

            // Save the object
            Save();
        }

        /**
         * Edits an object in the list
         */
        public void Edit(dynamic obj)
        {
            // Find the index
            int index = GetIndexFromId(obj.Id);

            if (index < 0)
            {
                // We have a problem!
                throw new InvalidDataException("The id " + obj.Id + " was not founded in the list " + TypeDescriptor.GetClassName(this) + "!");
            }

            // Remove the index and add the user new to the list
            List.RemoveAt(index);
            List.Add(obj);
            Save();
        }

        /**
         * Deletes an object from the list
         */
        public void Delete(int id)
        {
            foreach (IIdentifier obj in List)
            {
                // Check if the id are the same
                if (obj.Id == id)
                {
                    obj.Deleted = true;
                    break; // Stop the foreach loop
                }
            }

            Save();
        }

        public IIdentifier this[int i]
        {
            get => (IIdentifier)List[i];

            set => List.Add(value);
        }

        protected abstract string GetDataContainerListName();
    }
}
