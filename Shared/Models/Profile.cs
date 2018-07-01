using Shared.Enums;
using System;

namespace Shared.Models
{
    [Serializable]
    public class Profile : Model
    {
        #region Properties
        public Settings Settings { get; set; }
        public DateTime Created { get; set; }
        #endregion

        // Constructor
        public Profile()
        {
            this.Initializer();
        }

        internal override void Initializer()
        {
            base.Initializer();
            this.Created = DateTime.Now;
            this.Type = DataType.Connection;
        }
    }
}
