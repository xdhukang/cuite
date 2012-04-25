﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace CUITe.Controls.WinControls
{
    /// <summary>
    /// Wrapper class for WinListItem
    /// </summary>
    public class CUITe_WinListItem : CUITe_WinControl<WinListItem>
    {
        public CUITe_WinListItem() : base() { }
        public CUITe_WinListItem(string sSearchParameters) : base(sSearchParameters) { }

        public string DisplayText
        {
            get { return this.UnWrap().DisplayText; }
        }

        public bool Selected
        {
            get { return this.UnWrap().Selected; }
        }
    }
}