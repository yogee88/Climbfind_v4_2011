//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace cf.Entities
{
    public partial class LocationSection
    {
        #region Primitive Properties
    
        public virtual System.Guid ID
        {
            get;
            set;
        }
    
        public virtual System.Guid LocationID
        {
            get { return _locationID; }
            set
            {
                if (_locationID != value)
                {
                    if (Location != null && Location.ID != value)
                    {
                        Location = null;
                    }
                    _locationID = value;
                }
            }
        }
        private System.Guid _locationID;
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string NameUrlPart
        {
            get;
            set;
        }
    
        public virtual string Avatar
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual byte DefaultClimbTypeID
        {
            get;
            set;
        }
    
        public virtual byte DefaultGradeTypeID
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Climb> Climbs
        {
            get
            {
                if (_climbs == null)
                {
                    var newCollection = new FixupCollection<Climb>();
                    newCollection.CollectionChanged += FixupClimbs;
                    _climbs = newCollection;
                }
                return _climbs;
            }
            set
            {
                if (!ReferenceEquals(_climbs, value))
                {
                    var previousValue = _climbs as FixupCollection<Climb>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupClimbs;
                    }
                    _climbs = value;
                    var newValue = value as FixupCollection<Climb>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupClimbs;
                    }
                }
            }
        }
        private ICollection<Climb> _climbs;
    
        public virtual LocationEF Location
        {
            get { return _location; }
            set
            {
                if (!ReferenceEquals(_location, value))
                {
                    var previousValue = _location;
                    _location = value;
                    FixupLocation(previousValue);
                }
            }
        }
        private LocationEF _location;

        #endregion
        #region Association Fixup
    
        private void FixupLocation(LocationEF previousValue)
        {
            if (previousValue != null && previousValue.LocationsSections.Contains(this))
            {
                previousValue.LocationsSections.Remove(this);
            }
    
            if (Location != null)
            {
                if (!Location.LocationsSections.Contains(this))
                {
                    Location.LocationsSections.Add(this);
                }
                if (LocationID != Location.ID)
                {
                    LocationID = Location.ID;
                }
            }
        }
    
        private void FixupClimbs(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Climb item in e.NewItems)
                {
                    item.LocationSection = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Climb item in e.OldItems)
                {
                    if (ReferenceEquals(item.LocationSection, this))
                    {
                        item.LocationSection = null;
                    }
                }
            }
        }

        #endregion
    }
}
