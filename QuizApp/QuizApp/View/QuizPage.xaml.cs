using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QuizApp.ViewModal;
using QuizApp.Modal;
namespace QuizApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizPage : ContentPage
    {
        HomeScreenViewModal homescreen;
        List<QuizData> Questions;
        string choosenAnswer = "";
        String submitAnswer = "";
        public int i = 0;

        public QuizPage()
        {
            InitializeComponent();
            homescreen = new HomeScreenViewModal();
            Questions = homescreen.ListQuiz;
            showQuestion();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (EditorLayout.IsVisible)
            {
                submitAnswer = Editor.Text;
                i += 1;
            }

            DisplayAlert("Your Anser", submitAnswer, "Ok");
        }

        private void Picker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var picker = ((Picker)sender);
            int choosenAnswer = picker.SelectedIndex;
        }


        public void showQuestion()
        {
            QuizData data = Questions[i];
            question.Text = data.text;
            if (data.type == "textbox")
            {
                EditorLayout.IsVisible = true;
                PickerLayout.IsVisible = false;
            }
            else
                if (data.type == "choice")
            {
                PickerLayout.IsVisible = true;
                EditorLayout.IsVisible = false;
                QuizData quiz = Questions[i];
                foreach (string option in quiz.options)
                {
                    picker.Items.Add(option);
                }
            }


        }
    }

}