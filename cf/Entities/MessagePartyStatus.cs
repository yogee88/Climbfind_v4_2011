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
    public partial class MessagePartyStatus
    {
        #region Primitive Properties
    
        public virtual System.Guid ID
        {
            get;
            set;
        }
    
        public virtual System.Guid PartyID
        {
            get;
            set;
        }
    
        public virtual Nullable<System.Guid> MessageID
        {
            get { return _messageID; }
            set
            {
                try
                {
                    _settingFK = true;
                    if (_messageID != value)
                    {
                        if (Message != null && Message.ID != value)
                        {
                            Message = null;
                        }
                        _messageID = value;
                    }
                }
                finally
                {
                    _settingFK = false;
                }
            }
        }
        private Nullable<System.Guid> _messageID;
    
        public virtual byte Status
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual Message Message
        {
            get { return _message; }
            set
            {
                if (!ReferenceEquals(_message, value))
                {
                    var previousValue = _message;
                    _message = value;
                    FixupMessage(previousValue);
                }
            }
        }
        private Message _message;

        #endregion
        #region Association Fixup
    
        private bool _settingFK = false;
    
        private void FixupMessage(Message previousValue)
        {
            if (previousValue != null && previousValue.MessagePartyStatus.Contains(this))
            {
                previousValue.MessagePartyStatus.Remove(this);
            }
    
            if (Message != null)
            {
                if (!Message.MessagePartyStatus.Contains(this))
                {
                    Message.MessagePartyStatus.Add(this);
                }
                if (MessageID != Message.ID)
                {
                    MessageID = Message.ID;
                }
            }
            else if (!_settingFK)
            {
                MessageID = null;
            }
        }

        #endregion
    }
}
