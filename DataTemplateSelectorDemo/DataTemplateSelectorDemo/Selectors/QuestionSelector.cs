using DataTemplateSelectorDemo.ViewModels;
using System;
using Xamarin.Forms;

namespace DataTemplateSelectorDemo.Selectors
{
    public class QuestionSelector : Xamarin.Forms.DataTemplateSelector
    {
        public DataTemplate SingleQuestionTemplate { get; set; }
      

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is SingleQuestionViewModel)
                return SingleQuestionTemplate;

            throw new InvalidOperationException($"No template specified for type {item.GetType().ToString()}");
        }
    }
}
