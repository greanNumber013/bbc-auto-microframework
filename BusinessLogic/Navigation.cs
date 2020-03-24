using Pages;

namespace BusinessLogic
{
    public class Navigation
    {
        public static void GoToNewsPageBbc()
        {
            MainPageBbc mainPageBbc = new MainPageBbc();
            mainPageBbc.ClickOnMenu();
            mainPageBbc.ClickOnNews();
        }
        public static void GoToHaveYourSayPageBbc()
        {
            GoToNewsPageBbc();
            NewsPageBbc newsPageBbc = new NewsPageBbc();
            newsPageBbc.ClickOnMore();
            newsPageBbc.ClickOnHaveYourSay();
        }
        public static void GoToQuestionPageBbc()
        {
            GoToHaveYourSayPageBbc();
            HaveYourSayPageBbc haveYourSayPageBbc = new HaveYourSayPageBbc();
            haveYourSayPageBbc.ClickOnQuestionLink();
        }
    }
}
