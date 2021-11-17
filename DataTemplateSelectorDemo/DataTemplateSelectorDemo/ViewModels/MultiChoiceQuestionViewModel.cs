using DataTemplateSelectorDemo.Models;

namespace DataTemplateSelectorDemo.ViewModels
{
    public class MultiChoiceQuestionViewModel : BaseQuestionViewModel
    {
        MultiChoiceQuestion question;
        public MultiChoiceQuestionViewModel(MultiChoiceQuestion question)
        {
            this.question = question;
        }

        public string Question
        {
            get
            {
                return question.Question;
            }
            set
            {
                if (value != question.Question)
                {
                    question.Question = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string OptionOneText
        {
            get
            {
                return question.OptionOneText;
            }
            set
            {
                if (value != question.OptionOneText)
                {
                    question.OptionOneText = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool OptionOneValue
        {
            get
            {
                return question.OptionOneValue;
            }
            set
            {
                if (value != question.OptionOneValue)
                {
                    question.OptionOneValue = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string OptionTwoText
        {
            get
            {
                return question.OptionTwoText;
            }
            set
            {
                if (value != question.OptionTwoText)
                {
                    question.OptionTwoText = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool OptionTwoValue
        {
            get
            {
                return question.OptionTwoValue;
            }
            set
            {
                if (value != question.OptionTwoValue)
                {
                    question.OptionTwoValue = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string OptionThreeText
        {
            get
            {
                return question.OptionThreeText;
            }
            set
            {
                if (value != question.OptionThreeText)
                {
                    question.OptionThreeText = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool OptionThreeValue
        {
            get
            {
                return question.OptionThreeValue;
            }
            set
            {
                if (value != question.OptionThreeValue)
                {
                    question.OptionThreeValue = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
