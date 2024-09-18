using System.ComponentModel;
using System.Diagnostics;

namespace Hangman
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        #region Fields 
        List<string> words = new List<string>()
        {
            "python",
            "java",
            "javascript",
            "csharp",
            "ruby",
            "swift",
            "kotlin",
            "php",
            "html",
            "css",
            "sql",
            "objectivec",
            "perl",
            "r",
            "matlab",
            "assembly",
            "typescript",
        };
        string answer = "";
        #endregion



        public MainPage()
        {
            InitializeComponent();
            Pickword();
        }

        #region Game Engine
        private void Pickword()
        {
            answer = words[new Random().Next(0, words.Count)];
            Debug.WriteLine(answer);
        }
        #endregion


    }

}
