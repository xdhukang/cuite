﻿using CUIT = Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfHyperlink
    /// </summary>
    public class WpfHyperlink : WpfControl<CUIT.WpfHyperlink>
    {
        public WpfHyperlink() : base() { }
        public WpfHyperlink(string searchParameters) : base(searchParameters) { }

        public string Alt
        {
            get { return this.UnWrap().Alt; }
        }
    }
}