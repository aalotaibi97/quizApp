using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizApp.Modal;
namespace QuizApp.ViewModal
{
    class HomeScreenViewModal
    {
        public List<QuizData> ListQuiz;
  
        public HomeScreenViewModal() {

            ListQuiz = new QuizData().GetQuizData();
        }
    }
}
