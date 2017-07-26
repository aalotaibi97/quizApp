using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Modal
{

    // generic datatype for Quiz data
    //with set and get method
    //mutiple objects for diffrent-2 type question and answer
    //bind them in one class object
   public class QuizData
    {
        // simply question id
        public int id { private set; get; }
        //string object to hold question
        public String text { private set; get; }
        //type for submit answer 
        //for ex- answer in text mode or choice mode
        public String type { private set; get; }
        //vaildation on name 
        public String validate { private set; get; }

        public String help { private set; get; }
        //String array for answer
        public String[] answer { private set; get; }

        //String Array for options in multichoice or choice answer mode
        public String[] options { private set; get; }

        // weightage for question
        public int weighting { private set; get; }
        
        //Method GetQuizData() to get list of quesstion for quiz
        //Here we have sample test as defind in sample link for quiz
        //return type- List of Generic quiz datatype
        public List<QuizData> GetQuizData() {
            List<QuizData> QuizList = new List<QuizData> {
                new QuizData{id=1,text="Sid",type="textbox", validate="/[0-9]+/"},
                new QuizData{id=2,text="Name",type="textbox", validate="/[0-9]+/",help="Your full name"},
                new QuizData{id=3,text="What is the capital of Australia?",type="textbox", validate="/[0-9]+/",help="Your full name",answer=new string[]{"Canberra" },weighting=5},
                new QuizData{id=4,text="What is the largest state in Australia?",type="textbox", validate="/[0-9]+/",help="Your full name",answer=new string[]{"Western Australia" },weighting=5},
                new QuizData{id=4,text="What is the capital of Victoria?",type="choice", validate="/[0-9]+/",help="Your full name",answer=new string[]{"Melbourne" },weighting=5,options= new string[]{ "Sydney", "Brisbane", "Melbourne" } },
                new QuizData{id=4,text="Which are the territories of Australia?",type="multiplechoice", validate="/[0-9]+/",help="Your full name",answer=new string[]{ "ACT","NT"},weighting=5,options= new string[]{ "ACT","NSW","NT","QLD","SA","TAS","VIC","WA" } },
            };

            return QuizList;

        }
    }

 

}
