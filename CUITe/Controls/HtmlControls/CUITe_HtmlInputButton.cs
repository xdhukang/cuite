﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CUITe.Controls.HtmlControls
{
    public class CUITe_HtmlInputButton : CUITe_ControlBase<HtmlInputButton>
    {
        public CUITe_HtmlInputButton() : base() { }
        public CUITe_HtmlInputButton(string sSearchParameters) : base(sSearchParameters) { }

        public string InnerText
        {
            get
            {
                return this._control.InnerText;
            }
        }

        public string DisplayText
        {
            get
            {
                return this._control.DisplayText;
            }
        }
    }
}
