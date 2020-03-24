using System.Collections.Generic;

namespace DataBase
{
    public class TestData
    {
        public static string ExpectedTitle => "Hong Kong protests trample rule of law - China";
        public static List<string> HeadersFromTestData => new List<string>()
            {
                "Aid effort 'overwhelmed' amid Idlib offensive",
                "Jeff Bezos pledges $10bn to fight climate change",
                "Cruise ship US passengers home to new quarantine",
                "Storm Dennis: See the damage from above",
                "Brexit negotiator: UK must be able to set own laws"
            };

        public static readonly Dictionary<string, string> dataToFillInAllFields = new Dictionary<string, string>
        {
            {"question", "All 300 had been working on the same floor, the 43rd, " +
           "and were sent home on Wednesday. All 300 had been working on the same floor, the 43rd, " +
           "and were sent home on Wednesday." },
            {"Name", "John Doe"},
            {"Email", "blablabla@gmail.com"},
            {"Age", "20"},
            {"Postcode","07931"}
        };
        public static readonly Dictionary<string, string> dataToFillInAllFieldsWithoutMessage = new Dictionary<string, string>
        {
            {"question", "" },
            {"Name", "John Doe"},
            {"Email", "blablabla@gmail.com"},
            {"Age", "20"},
            {"Postcode","07931"}
        };

        public static readonly Dictionary<string, string> dataToFillInAllFieldsWithoutName = new Dictionary<string, string>
        {
            {"question", "All 300 had been working on the same floor, the 43rd, " +
           "and were sent home on Wednesday. All 300 had been working on the same floor, the 43rd, " +
           "and were sent home on Wednesday." },
            {"Name", ""},
            {"Email", "blablabla@gmail.com"},
            {"Age", "20"},
            {"Postcode","07931"}
        };

        public static readonly Dictionary<string, string> dataToFillInAllFieldsWithoutEmail = new Dictionary<string, string>
        {
            {"question", "All 300 had been working on the same floor, the 43rd, " +
           "and were sent home on Wednesday. All 300 had been working on the same floor, the 43rd, " +
           "and were sent home on Wednesday." },
            {"Name", "John Doe"},
            {"Email", ""},
            {"Age", "20"},
            {"Postcode","07931"}
        };

        public static string ExpectedUrl => "https://www.bbc.com/news/uk-47933096";

        public static string ExpectedTextareaErrorMessage => "can't be blank";
        public static string ExpectedNameErrorMessage => "Name can't be blank";
        public static string ExpectedEmailErrorMessage => "Email address can't be blank";

    }
}
