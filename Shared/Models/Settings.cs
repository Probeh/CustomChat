using Shared.Enums;
using System;
using System.Drawing;

namespace Shared.Models
{
    [Serializable]
    public class Settings : Model
    {
        #region Properties
        public Color Color { get; set; }
        public string Text { get; set; }
        #endregion

        // Constructor
        public Settings()
        {
            this.Initializer();
        }

        internal override void Initializer()
        {
            base.Initializer();
            this.Text = "Display Text";
            this.Type = DataType.Settings;
        }
    }
}
