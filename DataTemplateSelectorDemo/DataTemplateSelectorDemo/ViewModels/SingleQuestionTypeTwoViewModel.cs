using DataTemplateSelectorDemo.Models;

namespace DataTemplateSelectorDemo.ViewModels
{
    public  class SingleQuestionTypeTwoViewModel : BaseQuestionViewModel
    {
		private SingleQuestion _singleQuestion;

		public SingleQuestionTypeTwoViewModel(SingleQuestion singleQuestion)
		{
			_singleQuestion = singleQuestion;
		}

		public string Question
		{
			get
			{
				return _singleQuestion.Question;
			}
			set
			{
				if (value != _singleQuestion.Question)
				{
					_singleQuestion.Question = value;
					RaisePropertyChanged();
				}
			}
		}

		public string Answer
		{
			get
			{
				return _singleQuestion.Answer;
			}
			set
			{
				if (value != _singleQuestion.Answer)
				{
					_singleQuestion.Answer = value;
					RaisePropertyChanged();
				}
			}
		}
	}
}
