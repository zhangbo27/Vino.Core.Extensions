﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vino.Core.Extensions.Layui
{
    public class LayuiOption
    {
        public bool ActionsInFormItem { set; get; } = false;

        public ActionButton Submit { set; get; } = new ActionButton { Css = "layui-btn-small", Text = "保 存" };

        public CloseButton Close { set; get; } = new CloseButton { Css = "layui-btn-small layui-btn-warm", Text = "关 闭", Icon = "&#x1006;", Action = "javascript:closeWindow()" };

        public ResetButton Reset { set; get; } = new ResetButton { Css = "layui-btn-small layui-btn-primary", Text = "重 置", Icon = "" };
    }
}
