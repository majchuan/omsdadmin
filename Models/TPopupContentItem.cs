﻿using System;
using System.Collections.Generic;

namespace OMSDAdmin.Models
{
    public partial class TPopupContentItem
    {
        public int TPopupContentItemId { get; set; }
        public int Editstate { get; set; }
        public int Sublistingid { get; set; }
        public DateTime Datecreated { get; set; }
        public string Content { get; set; }
        public int? Language { get; set; }
        public string Title { get; set; }

        public V51Languages LanguageNavigation { get; set; }
        public PopupContent Sublisting { get; set; }
    }
}
