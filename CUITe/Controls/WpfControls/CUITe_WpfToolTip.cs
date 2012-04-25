﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;

namespace CUITe.Controls.WpfControls
{
    /// <summary>
    /// Wrapper class for WpfToolTip
    /// </summary>
    public class CUITe_WpfToolTip : CUITe_WpfControl<WpfToolTip>
    {
        public CUITe_WpfToolTip() : base() { }
        public CUITe_WpfToolTip(string sSearchParameters) : base(sSearchParameters) { }
    }
}