﻿using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfImage
    /// </summary>
    public class WpfImage : WpfControl<CUIT.WpfImage>
    {
        public WpfImage() : base() { }
        public WpfImage(string searchParameters) : base(searchParameters) { }

        public string Alt
        {
            get { return this.UnWrap().Alt; }
        }
    }
}