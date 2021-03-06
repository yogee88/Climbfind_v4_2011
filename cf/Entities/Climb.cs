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
    public partial class Climb
    {
        #region Primitive Properties
    
        public virtual System.Guid ID
        {
            get;
            set;
        }
    
        public virtual byte CountryID
        {
            get;
            set;
        }
    
        public virtual System.Guid LocationID
        {
            get { return _locationID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_locationID != value)
                    {
                        if (Location != null && Location.ID != value)
                        {
                            Location = null;
                        }
                        _locationID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private System.Guid _locationID;
    
        public virtual Nullable<System.Guid> SetterID
        {
            get { return _setterID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_setterID != value)
                    {
                        if (Setter != null && Setter.ID != value)
                        {
                            Setter = null;
                        }
                        _setterID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<System.Guid> _setterID;
    
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
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual string GradeLocal
        {
            get;
            set;
        }
    
        public virtual byte GradeCfNormalize
        {
            get;
            set;
        }
    
        public virtual string Avatar
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> Denorm_AddedUtc
        {
            get;
            set;
        }
    
        public virtual Nullable<double> Rating
        {
            get;
            set;
        }
    
        public virtual int RatingCount
        {
            get;
            set;
        }
    
        public virtual Nullable<int> HeightInMeters
        {
            get;
            set;
        }
    
        public virtual string NameShort
        {
            get;
            set;
        }
    
        public virtual byte TypeID
        {
            get;
            set;
        }
    
        public virtual Nullable<System.Guid> SectionID
        {
            get { return _sectionID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_sectionID != value)
                    {
                        if (LocationSection != null && LocationSection.ID != value)
                        {
                            LocationSection = null;
                        }
                        _sectionID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<System.Guid> _sectionID;
    
        public virtual Nullable<System.DateTime> Compat_SetDateTime
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> Compat_PulledDownDateTime
        {
            get;
            set;
        }
    
        public virtual string Compat_DescriptionWhere
        {
            get;
            set;
        }
    
        public virtual int Compat_NumberOfPitches
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
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
    
        public virtual ICollection<ClimbTag> ClimbTags
        {
            get
            {
                if (_climbTags == null)
                {
                    var newCollection = new FixupCollection<ClimbTag>();
                    newCollection.CollectionChanged += FixupClimbTags;
                    _climbTags = newCollection;
                }
                return _climbTags;
            }
            set
            {
                if (!ReferenceEquals(_climbTags, value))
                {
                    var previousValue = _climbTags as FixupCollection<ClimbTag>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupClimbTags;
                    }
                    _climbTags = value;
                    var newValue = value as FixupCollection<ClimbTag>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupClimbTags;
                    }
                }
            }
        }
        private ICollection<ClimbTag> _climbTags;
    
        public virtual LocationSection LocationSection
        {
            get { return _locationSection; }
            set
            {
                if (!ReferenceEquals(_locationSection, value))
                {
                    var previousValue = _locationSection;
                    _locationSection = value;
                    FixupLocationSection(previousValue);
                }
            }
        }
        private LocationSection _locationSection;
    
        public virtual Setter Setter
        {
            get { return _setter; }
            set
            {
                if (!ReferenceEquals(_setter, value))
                {
                    var previousValue = _setter;
                    _setter = value;
                    FixupSetter(previousValue);
                }
            }
        }
        private Setter _setter;
    
        public virtual ICollection<LoggedClimb> LoggedClimbs
        {
            get
            {
                if (_loggedClimbs == null)
                {
                    var newCollection = new FixupCollection<LoggedClimb>();
                    newCollection.CollectionChanged += FixupLoggedClimbs;
                    _loggedClimbs = newCollection;
                }
                return _loggedClimbs;
            }
            set
            {
                if (!ReferenceEquals(_loggedClimbs, value))
                {
                    var previousValue = _loggedClimbs as FixupCollection<LoggedClimb>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupLoggedClimbs;
                    }
                    _loggedClimbs = value;
                    var newValue = value as FixupCollection<LoggedClimb>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupLoggedClimbs;
                    }
                }
            }
        }
        private ICollection<LoggedClimb> _loggedClimbs;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupLocation(LocationEF previousValue)
        {
            if (previousValue != null && previousValue.Climbs.Contains(this))
            {
                previousValue.Climbs.Remove(this);
            }
    
            if (Location != null)
            {
                if (!Location.Climbs.Contains(this))
                {
                    Location.Climbs.Add(this);
                }
                if (LocationID != Location.ID)
                {
                    LocationID = Location.ID;
                }
            }
        }
    
        private void FixupLocationSection(LocationSection previousValue)
        {
            if (previousValue != null && previousValue.Climbs.Contains(this))
            {
                previousValue.Climbs.Remove(this);
            }
    
            if (LocationSection != null)
            {
                if (!LocationSection.Climbs.Contains(this))
                {
                    LocationSection.Climbs.Add(this);
                }
                if (SectionID != LocationSection.ID)
                {
                    SectionID = LocationSection.ID;
                }
            }
            else if (!_settingFK)
            {
                SectionID = null;
            }
        }
    
        private void FixupSetter(Setter previousValue)
        {
            if (previousValue != null && previousValue.Climbs.Contains(this))
            {
                previousValue.Climbs.Remove(this);
            }
    
            if (Setter != null)
            {
                if (!Setter.Climbs.Contains(this))
                {
                    Setter.Climbs.Add(this);
                }
                if (SetterID != Setter.ID)
                {
                    SetterID = Setter.ID;
                }
            }
            else if (!_settingFK)
            {
                SetterID = null;
            }
        }
    
        private void FixupClimbTags(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ClimbTag item in e.NewItems)
                {
                    item.Climb = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ClimbTag item in e.OldItems)
                {
                    if (ReferenceEquals(item.Climb, this))
                    {
                        item.Climb = null;
                    }
                }
            }
        }
    
        private void FixupLoggedClimbs(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (LoggedClimb item in e.NewItems)
                {
                    item.Climb = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (LoggedClimb item in e.OldItems)
                {
                    if (ReferenceEquals(item.Climb, this))
                    {
                        item.Climb = null;
                    }
                }
            }
        }

        #endregion
    }
}
