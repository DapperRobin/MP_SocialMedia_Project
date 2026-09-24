using SMP_MP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMP_MP.Models
{
    public class FriendRequest
    {
        #region Properties

        public Guid Id { get; set; }
        public User SenderId { get; set; }
        public User RecipientId { get; set; }

        public FriendStatusEnums Status { get; set; }
        public DateTime SentAt { get; set; }

        #endregion

        #region Constructor(s)
        public FriendRequest(Guid id, User senderId, User recipientId, FriendStatusEnums status, DateTime sentAt)
        {
            Id = id;
            SenderId = senderId;
            RecipientId = recipientId;
            Status = status;
            SentAt = sentAt;
        }

        #endregion
    }
}