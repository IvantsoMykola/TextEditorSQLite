using System;
using System.Collections.Generic;
using System.Text;
using TextEditorSQLite.Helpers;

namespace TextEditorSQLite.Models
{
    class TextFile : Observable
    {
        private string text;
        private string title;
        private string format;
        private float size;
        public string Text
        {
            get { return text; }
            set { Set(ref text, value); }
        }
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }
        public string Format
        {
            get { return format; }
            set { Set(ref format, value); }
        }
        public float Size
        {
            get { return size; }
            set { Set(ref size, value); }
        }

        public string FullTitle => string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Format)? Title + Format : Title + "." + Format;
    }
}
