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
    public partial class Media
    {
        #region Primitive Properties
    
        public virtual System.Guid ID
        {
            get;
            set;
        }
    
        public virtual byte TypeID
        {
            get;
            set;
        }
    
        public virtual string ContentType
        {
            get;
            set;
        }
    
        public virtual string Content
        {
            get;
            set;
        }
    
        public virtual string NameUrlPart
        {
            get;
            set;
        }
    
        public virtual string Title
        {
            get;
            set;
        }
    
        public virtual string Author
        {
            get;
            set;
        }
    
        public virtual Nullable<System.DateTime> TakenDate
        {
            get;
            set;
        }
    
        public virtual System.DateTime AddedUtc
        {
            get;
            set;
        }
    
        public virtual System.Guid AddedByUserID
        {
            get { return _addedByUserID; }
            set
            {
                if (_addedByUserID != value)
                {
                    if (Profile != null && Profile.ID != value)
                    {
                        Profile = null;
                    }
                    _addedByUserID = value;
                }
            }
        }
        private System.Guid _addedByUserID;
    
        public virtual Nullable<double> Latitude
        {
            get;
            set;
        }
    
        public virtual Nullable<double> Longitude
        {
            get;
            set;
        }
    
        public virtual string Description
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
    
        public virtual bool FeedVisible
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<ObjectMedia> ObjectMedias
        {
            get
            {
                if (_objectMedias == null)
                {
                    var newCollection = new FixupCollection<ObjectMedia>();
                    newCollection.CollectionChanged += FixupObjectMedias;
                    _objectMedias = newCollection;
                }
                return _objectMedias;
            }
            set
            {
                if (!ReferenceEquals(_objectMedias, value))
                {
                    var previousValue = _objectMedias as FixupCollection<ObjectMedia>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupObjectMedias;
                    }
                    _objectMedias = value;
                    var newValue = value as FixupCollection<ObjectMedia>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupObjectMedias;
                    }
                }
            }
        }
        private ICollection<ObjectMedia> _objectMedias;
    
        public virtual ICollection<MediaOpinion> MediaOpinions
        {
            get
            {
                if (_mediaOpinions == null)
                {
                    var newCollection = new FixupCollection<MediaOpinion>();
                    newCollection.CollectionChanged += FixupMediaOpinions;
                    _mediaOpinions = newCollection;
                }
                return _mediaOpinions;
            }
            set
            {
                if (!ReferenceEquals(_mediaOpinions, value))
                {
                    var previousValue = _mediaOpinions as FixupCollection<MediaOpinion>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupMediaOpinions;
                    }
                    _mediaOpinions = value;
                    var newValue = value as FixupCollection<MediaOpinion>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupMediaOpinions;
                    }
                }
            }
        }
        private ICollection<MediaOpinion> _mediaOpinions;
    
        public virtual ICollection<UserPersonalityMedia> UserPersonalityMedias
        {
            get
            {
                if (_userPersonalityMedias == null)
                {
                    var newCollection = new FixupCollection<UserPersonalityMedia>();
                    newCollection.CollectionChanged += FixupUserPersonalityMedias;
                    _userPersonalityMedias = newCollection;
                }
                return _userPersonalityMedias;
            }
            set
            {
                if (!ReferenceEquals(_userPersonalityMedias, value))
                {
                    var previousValue = _userPersonalityMedias as FixupCollection<UserPersonalityMedia>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupUserPersonalityMedias;
                    }
                    _userPersonalityMedias = value;
                    var newValue = value as FixupCollection<UserPersonalityMedia>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupUserPersonalityMedias;
                    }
                }
            }
        }
        private ICollection<UserPersonalityMedia> _userPersonalityMedias;
    
        public virtual ICollection<CheckIn> CheckIns
        {
            get
            {
                if (_checkIns == null)
                {
                    var newCollection = new FixupCollection<CheckIn>();
                    newCollection.CollectionChanged += FixupCheckIns;
                    _checkIns = newCollection;
                }
                return _checkIns;
            }
            set
            {
                if (!ReferenceEquals(_checkIns, value))
                {
                    var previousValue = _checkIns as FixupCollection<CheckIn>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupCheckIns;
                    }
                    _checkIns = value;
                    var newValue = value as FixupCollection<CheckIn>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupCheckIns;
                    }
                }
            }
        }
        private ICollection<CheckIn> _checkIns;
    
        public virtual Profile Profile
        {
            get { return _profile; }
            set
            {
                if (!ReferenceEquals(_profile, value))
                {
                    var previousValue = _profile;
                    _profile = value;
                    FixupProfile(previousValue);
                }
            }
        }
        private Profile _profile;

        #endregion
        #region Association Fixup
    
        private void FixupProfile(Profile previousValue)
        {
            if (previousValue != null && previousValue.Media.Contains(this))
            {
                previousValue.Media.Remove(this);
            }
    
            if (Profile != null)
            {
                if (!Profile.Media.Contains(this))
                {
                    Profile.Media.Add(this);
                }
                if (AddedByUserID != Profile.ID)
                {
                    AddedByUserID = Profile.ID;
                }
            }
        }
    
        private void FixupObjectMedias(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (ObjectMedia item in e.NewItems)
                {
                    item.Media = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (ObjectMedia item in e.OldItems)
                {
                    if (ReferenceEquals(item.Media, this))
                    {
                        item.Media = null;
                    }
                }
            }
        }
    
        private void FixupMediaOpinions(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (MediaOpinion item in e.NewItems)
                {
                    item.Medium = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (MediaOpinion item in e.OldItems)
                {
                    if (ReferenceEquals(item.Medium, this))
                    {
                        item.Medium = null;
                    }
                }
            }
        }
    
        private void FixupUserPersonalityMedias(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (UserPersonalityMedia item in e.NewItems)
                {
                    item.Media = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (UserPersonalityMedia item in e.OldItems)
                {
                    if (ReferenceEquals(item.Media, this))
                    {
                        item.Media = null;
                    }
                }
            }
        }
    
        private void FixupCheckIns(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (CheckIn item in e.NewItems)
                {
                    if (!item.Media.Contains(this))
                    {
                        item.Media.Add(this);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (CheckIn item in e.OldItems)
                {
                    if (item.Media.Contains(this))
                    {
                        item.Media.Remove(this);
                    }
                }
            }
        }

        #endregion
    }
}
