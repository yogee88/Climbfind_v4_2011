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
    public partial class Post
    {
        #region Primitive Properties
    
        public virtual System.Guid ID
        {
            get;
            set;
        }
    
        public virtual int TypeID
        {
            get;
            set;
        }
    
        public virtual System.Guid UserID
        {
            get { return _userID; }
            set
            {
                if (_userID != value)
                {
                    if (Profile != null && Profile.ID != value)
                    {
                        Profile = null;
                    }
                    _userID = value;
                }
            }
        }
        private System.Guid _userID;
    
        public virtual System.Guid PlaceID
        {
            get;
            set;
        }
    
        public virtual byte PlaceTypeID
        {
            get;
            set;
        }
    
        public virtual System.DateTime Utc
        {
            get;
            set;
        }
    
        public virtual string TemplateKey
        {
            get;
            set;
        }
    
        public virtual string TemplateData
        {
            get;
            set;
        }
    
        public virtual bool IsPublic
        {
            get;
            set;
        }
    
        public virtual string SlugUrlPart
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
    
        public virtual Nullable<System.DateTime> LastActivityUtc
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Alert> Alerts
        {
            get
            {
                if (_alerts == null)
                {
                    var newCollection = new FixupCollection<Alert>();
                    newCollection.CollectionChanged += FixupAlerts;
                    _alerts = newCollection;
                }
                return _alerts;
            }
            set
            {
                if (!ReferenceEquals(_alerts, value))
                {
                    var previousValue = _alerts as FixupCollection<Alert>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupAlerts;
                    }
                    _alerts = value;
                    var newValue = value as FixupCollection<Alert>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupAlerts;
                    }
                }
            }
        }
        private ICollection<Alert> _alerts;
    
        public virtual ICollection<PostComment> PostComments
        {
            get
            {
                if (_postComments == null)
                {
                    var newCollection = new FixupCollection<PostComment>();
                    newCollection.CollectionChanged += FixupPostComments;
                    _postComments = newCollection;
                }
                return _postComments;
            }
            set
            {
                if (!ReferenceEquals(_postComments, value))
                {
                    var previousValue = _postComments as FixupCollection<PostComment>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupPostComments;
                    }
                    _postComments = value;
                    var newValue = value as FixupCollection<PostComment>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupPostComments;
                    }
                }
            }
        }
        private ICollection<PostComment> _postComments;
    
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
            if (previousValue != null && previousValue.Posts.Contains(this))
            {
                previousValue.Posts.Remove(this);
            }
    
            if (Profile != null)
            {
                if (!Profile.Posts.Contains(this))
                {
                    Profile.Posts.Add(this);
                }
                if (UserID != Profile.ID)
                {
                    UserID = Profile.ID;
                }
            }
        }
    
        private void FixupAlerts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Alert item in e.NewItems)
                {
                    item.Post = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Alert item in e.OldItems)
                {
                    if (ReferenceEquals(item.Post, this))
                    {
                        item.Post = null;
                    }
                }
            }
        }
    
        private void FixupPostComments(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (PostComment item in e.NewItems)
                {
                    item.Post = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (PostComment item in e.OldItems)
                {
                    if (ReferenceEquals(item.Post, this))
                    {
                        item.Post = null;
                    }
                }
            }
        }

        #endregion
    }
}