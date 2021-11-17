using DataTemplateSelectorDemo.ViewModels;
using System;
using Xamarin.Forms;

namespace DataTemplateSelectorDemo.Selectors
{
    public class QuestionSelector : Xamarin.Forms.DataTemplateSelector
    {
        public DataTemplate SingleQuestionTemplate { get; set; }
        public DataTemplate SingleQuestionTypeTwoTemplate { get; set; }
        public DataTemplate MultiChoiceTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is SingleQuestionViewModel)
                return SingleQuestionTemplate;

            if (item is MultiChoiceQuestionViewModel)
                return MultiChoiceTemplate;

            if (item is SingleQuestionTypeTwoViewModel)
                return SingleQuestionTypeTwoTemplate;

            throw new InvalidOperationException($"No template specified for type {item.GetType().ToString()}");
        }
    }
}
