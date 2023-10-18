using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionaire
{
    public class Question
    {
        public string Text { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string RightAnswer { get; set; }
        public int Level { get; set; }
        public Question(string Text, string Answer1, string Answer2, string Answer3, string Answer4, string RightAnswer, int Level)
        {
            this.Text = Text;
            this.Answer1 = Answer1;
            this.Answer2 = Answer2;
            this.Answer3 = Answer3;
            this.Answer4 = Answer4;
            this.RightAnswer = RightAnswer;
            this.Level = Level;
        }
    }
}
