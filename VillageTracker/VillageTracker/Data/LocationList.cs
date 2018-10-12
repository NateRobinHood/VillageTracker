using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillageTracker.Data
{
    public class LocationList : List<LocationData>
    {
        //Public Events
        public event EventHandler<OnLocationAddedRemovedArgs> OnLocationAdded;
        public event EventHandler<OnLocationAddedRemovedArgs> OnLocationRemoved;

        public LocationList()
        {

        }

        //Public Overrides
        //
        // Summary:
        //     Adds an object to the end of the System.Collections.Generic.List`1.
        //
        // Parameters:
        //   item:
        //     The object to be added to the end of the System.Collections.Generic.List`1. The
        //     value can be null for reference types.
        public new void Add(LocationData item)
        {
            base.Add(item);
            OnLocationAdded?.Invoke(this, new OnLocationAddedRemovedArgs(item));
        }
        //
        // Summary:
        //     Adds the elements of the specified collection to the end of the System.Collections.Generic.List`1.
        //
        // Parameters:
        //   collection:
        //     The collection whose elements should be added to the end of the System.Collections.Generic.List`1.
        //     The collection itself cannot be null, but it can contain elements that are null,
        //     if type T is a reference type.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     collection is null.
        public new void AddRange(IEnumerable<LocationData> collection)
        {
            foreach (LocationData newNpc in collection)
            {
                this.Add(newNpc);
            }
        }

        //
        // Summary:
        //     Removes the first occurrence of a specific object from the System.Collections.Generic.List`1.
        //
        // Parameters:
        //   item:
        //     The object to remove from the System.Collections.Generic.List`1. The value can
        //     be null for reference types.
        //
        // Returns:
        //     true if item is successfully removed; otherwise, false. This method also returns
        //     false if item was not found in the System.Collections.Generic.List`1.
        public new bool Remove(LocationData item)
        {
            bool ret = base.Remove(item);
            if (ret)
                OnLocationRemoved?.Invoke(this, new OnLocationAddedRemovedArgs(item));

            return ret;
        }
    }
}
