using Pages;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class FormSteps
    {
        public static void SearchFor (string value)
        {
            BasePage basePage = new BasePage();
            basePage.ClearSearchField();
            basePage.SendValueToSearchField(value);
            basePage.ClickSearchButton();
        }

        public static void FillInForm(Dictionary<string, string> fieldsAndValues)
        {
            new ComplexForm().FillForm(fieldsAndValues);
        }

        public static void FillInAndSubmitForm(Dictionary<string, string> fieldsAndValues)
        {
            FillInForm(fieldsAndValues);
            new ComplexForm().SubmitInfo();
        }
    }
}
