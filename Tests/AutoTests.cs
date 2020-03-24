using BusinessLogic;
using NUnit.Framework;
using Pages;
using DataBase;

namespace Tests
{
    [TestFixture]
    public class AutoTests : Setup
    {
        [Test]

        public void CheckMainHeaderText()
        { 
            Navigation.GoToNewsPageBbc();
            Assert.AreEqual(TestData.ExpectedTitle, new NewsPageBbc().ExtractMainHeaderText()); 
        }

        [Test]
        public void CheckSecondaryTitlesText()
        {
            Navigation.GoToNewsPageBbc();
            Assert.IsTrue(new NewsPageBbc().SecondaryTitlesAreEqualTo(TestData.HeadersFromTestData),
                "Headers from the page do not match headers from Test Data");
        }

        [Test]
        public void CheckSearchResultMatchesHeadlineCategoryText()
        {
            Navigation.GoToNewsPageBbc();
            string categoryName = new NewsPageBbc().ExtractHeadlineArticleCategoryText();
            FormSteps.SearchFor(categoryName);
            Assert.IsTrue(new SearchResultsPageBbc().ExtractFirstSearchResultText().Contains(categoryName), 
                "First search result doesn't contain any required words");
        }

        [Test]
        public void CheckPageAfterSubmittingQuestion()
        {
            Navigation.GoToQuestionPageBbc();
            FormSteps.FillInForm(TestData.dataToFillInAllFields);
            //Here was a Submit button
            Assert.AreEqual(TestData.ExpectedUrl, new QuestionPageBbc().GetPageUrl());
        }

        [Test]
        public void CheckEmptyTextAreaErrorMessage()
        {
            Navigation.GoToQuestionPageBbc();
            FormSteps.FillInAndSubmitForm(TestData.dataToFillInAllFieldsWithoutMessage);
            Assert.AreEqual(TestData.ExpectedTextareaErrorMessage,
                new QuestionPageBbc().ExtractTextareaErrorText());
        }

        [Test]
        public void CheckEmptyNameErrorMessage()
        {
            Navigation.GoToQuestionPageBbc();
            FormSteps.FillInAndSubmitForm(TestData.dataToFillInAllFieldsWithoutName);
            Assert.AreEqual(TestData.ExpectedNameErrorMessage,
                new QuestionPageBbc().ExtractNameErrorText());
        }

        [Test]
        public void CheckEmptyEmailErrorMessage()
        {
            Navigation.GoToQuestionPageBbc();
            FormSteps.FillInAndSubmitForm(TestData.dataToFillInAllFieldsWithoutEmail);
            Assert.AreEqual(TestData.ExpectedEmailErrorMessage,
                new QuestionPageBbc().ExtractEmailErrorText());
        }
    }
}
