using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPraktos4
{
    internal class Human
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public CorrectOption CorrectOption { get; set; }
    }
    public enum CorrectOption
    {
        FirstAnswerCorrect,
        SecondAnswerCorrect,
        ThirdAnswerCorrect
    }
}
