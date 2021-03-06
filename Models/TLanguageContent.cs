﻿using System;
using System.Collections.Generic;

namespace OMSDAdmin.Models
{
    public partial class TLanguageContent
    {
        public int TLanguageContentId { get; set; }
        public int Editstate { get; set; }
        public int Sublistingid { get; set; }
        public DateTime Datecreated { get; set; }
        public string Content { get; set; }
        public int? Language { get; set; }
        public int? V51Language { get; set; }

        public Language LanguageNavigation { get; set; }
        public Language Sublisting { get; set; }
        public V51Languages V51LanguageNavigation { get; set; }
    }
}
