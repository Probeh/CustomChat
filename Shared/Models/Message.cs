using Shared.Enums;
using System;

namespace Shared.Models
{
    [Serializable]
    public class Message : Profile
    {
        #region Properties
        public Guid ComposerID { get; set; }
        public Guid RecipientID { get; set; }
        #endregion

        // Constructor
        public Message()
        {
            this.Initializer();
        }

        internal override void Initializer()
        {
            base.Initializer();
            this.RecipientID = Guid.Empty;
            this.Type = DataType.Message;
        }
    }
}
