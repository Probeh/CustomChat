using Shared.Enums;
using System;

namespace Shared.Models
{
    [Serializable]
    public abstract class Model
    {
        #region Properties
        public Guid ProfileID { get; set; }
        public DataType Type { get; set; }
        #endregion

        internal virtual void Initializer()
        {
            this.ProfileID = Guid.NewGuid();
        }
    }
}
