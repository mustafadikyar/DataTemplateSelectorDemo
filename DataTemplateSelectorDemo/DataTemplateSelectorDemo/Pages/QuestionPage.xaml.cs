﻿using DataTemplateSelectorDemo.ViewModels;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemplateSelectorDemo.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionPage : ContentPage
    {
        public QuestionPage()
        {
            InitializeComponent();
            this.BindingContext = CreateQuestions();
        }
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        ObservableCollection<BaseQuestionViewModel> CreateQuestions()
        {
            // dummy up some questions
            ObservableCollection<BaseQuestionViewModel> questions = new ObservableCollection<BaseQuestionViewModel>
            {
                new SingleQuestionViewModel(new Models.SingleQuestion()
                {
                    Question = "Question 1",
                }),
                new SingleQuestionTypeTwoViewModel(new Models.SingleQuestion()
                {
                    Question = "Question 2",
                }),
                new MultiChoiceQuestionViewModel(new Models.MultiChoiceQuestion()
                {
                    Question = "What language are you developing with?",
                    OptionOneText = "CSharp",
                    OptionTwoText = "GoLang",
                    OptionThreeText = "Other"
                }),
            };

            return questions;
        }
    }
}
