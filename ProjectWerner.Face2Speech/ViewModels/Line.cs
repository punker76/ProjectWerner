﻿using System.Collections.Generic;
using PropertyChanged;

namespace ProjectWerner.Face2Speech.ViewModels
{
    [ImplementPropertyChanged]
    public class Line
    {
        public int SelectedWordIndex { get; set; }

        public List<KeyboardChars> Words { get; set; }
        public bool IsSelected { get; set; }

        public Line()
        {
            Words = new List<KeyboardChars>();
            SelectedWordIndex = -1;
        }
    }
}