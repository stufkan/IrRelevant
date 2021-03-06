﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrRelevant;

namespace IrRelevant.Model
{
    public class Item
    {
        public const string defaultTitle = "New note";
        public const string defaultContent = "Write your note";
        public const IconEnum defaultIcon = IconEnum.unknown;
        public const bool defaultExpanded = true;

        public Item()
        {
            Title = defaultTitle;
            Icon = defaultIcon;
            Content = defaultContent;
            Expanded = defaultExpanded;
        }

        public string Title { get; set; }
        public IconEnum Icon { get; set; }
        public string Content { get; set; }

        public bool Expanded { get; set; }
    }
}
