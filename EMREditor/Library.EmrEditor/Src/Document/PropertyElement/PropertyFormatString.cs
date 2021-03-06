﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DrectSoft.Library.EmrEditor.Src.Document
{
    public class PropertyFormatString : PropertyBase
    {
        ZYFormatString _e;
        public PropertyFormatString(object e)
            : base(e)
        {
            _e = (ZYFormatString)e;
        }
        [Category("数据元代码"), DisplayName("数据元代码")]
        public string Code
        {
            get { return _e.Code; }
            set { _e.Code = value; }
        }
        [Category("属性设置"), DisplayName("名称")]
        public string Name
        {
            get { return _e.Name; }
            set { _e.Name = value; }
        }


        [Category("属性设置"), DisplayName("默认值")]
        public string Text
        {
            get { return _e.Text; }
            set { _e.Text = value; }
        }
        [Category("属性设置"), DisplayName("长度")]
        public uint Length
        {
            get { return _e.Length; }
            set { _e.Length = value; }
        }

        [Category("属性设置"), DisplayName("必点项"), Description("必须用鼠标双击，以表示关注过此项。")]
        [TypeConverter(typeof(BlankConverter))]
        [EditorAttribute(typeof(BoolEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public bool MustClick
        {
            get { return _e.MustClick; }
            set { _e.MustClick = value; }
        }
    }
}
