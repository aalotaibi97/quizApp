using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
        }
        // On Focus Listener for Usename editor to Display "User Name" as Hint when
        // Editor is Blank

        // UserName is object Refrence for username editor in xaml
        private void UserName_Focused(object sender, FocusEventArgs e)
        {
            if (UserName.Text.Equals("User Name")) 
            {
                UserName.Text = "";
               
            }
        }

        // On Unfocus Listener for Usename editor to hide "User Name" as Hint and make user to type from 0 string
        // UserName is object Refrence for username editor in xaml
        private void UserName_Unfocused(object sender, FocusEventArgs e)
        {
            if (UserName.Text.Equals(""))
            {
                UserName.Text = "User Name";
             
            }
        }

        // On Focus Listener for Password editor to Display "Password" as Hint when
        // Editor is Blank
        // Password is object Refrence for password editor in xaml
        private void Password_Focused(object sender, FocusEventArgs e)
        {
            if (Password.Text.Equals("Password"))
            {
                Password.Text = "";

            }

        }
        // On Unfocus Listener for Usename editor to hide "Password" as Hint and make user to type from 0 string
        // Password is object Refrence for Password editor in xaml
        private void Password_Unfocused(object sender, FocusEventArgs e)
        {
            if (Password.Text.Equals(""))
            {
                Password.Text = "Password";

            }
        }


        //Click Listener of Sign In Button To verify Login Details
        // and navigate to Quiz page
        // UserName is object Refrence for username editor in xaml
        // Password is object Refrence for Password editor in xaml

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (!(UserName.Text.Equals("") || Password.Text.Equals("")))
            {
                Navigation.PushAsync(new QuizPage());
                
            }
           
        }


        //Click Listener of Register Label Button To Navigate to Signup Page
     
        private void TapGestureRecognizer_Register(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}