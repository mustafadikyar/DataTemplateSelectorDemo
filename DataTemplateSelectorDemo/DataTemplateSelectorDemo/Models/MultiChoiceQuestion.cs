namespace DataTemplateSelectorDemo.Models
{
    public class MultiChoiceQuestion : BaseQuestion
    {
        public string OptionOneText { get; set; }
        public bool OptionOneValue { get; set; }

        public string OptionTwoText { get; set; }
        public bool OptionTwoValue { get; set; }

        public string OptionThreeText { get; set; }
        public bool OptionThreeValue { get; set; }
    }
}
