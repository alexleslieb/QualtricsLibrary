namespace QualtricsWebAPI.QualtricsClassLibrary.Routes
{
    public static class ApiRoutes
    {
        public const string UrlExtension = "/API/v3";

        public static class DirectoryContacts
        {
            public const string CreateDirectoryContact = UrlExtension + "/directories/{directoryId}/contacts";
            public const string GetDirectoryContacts = UrlExtension + "/directories/{directoryId}/contacts";
            public const string GetDirectoryContact = UrlExtension + "/directories/{directoryId}/contacts/{contactId}";
            public const string UpdateDirectoryContact = UrlExtension + "/directories/{directoryId}/contacts/{contactId}";
            public const string SearchDirectoryContacts = UrlExtension + "/directories/{directoryId}/contacts/search";
            public const string DeleteDirectoryContact = UrlExtension + "/directories/{directoryId}/contacts/{contactId}";
        }

        public static class ContactFrequency
        {
            public const string ContactFrequencyRules = UrlExtension + "/directories/{directoryId}/frequencyrules";
        }

        public static class ContactTransactions
        {
            public const string GetContactTransactions = UrlExtension + "/directories/{directoryId}/contacts/{contactId}";
        }

        public static class Directories
        {
            public const string GetDirectories = UrlExtension + "/directories";
        }

        public static class Surveys
        {
            public const string GetSurvey = UrlExtension + "/surveys/{surveyId}";
            public const string ListSurveys = UrlExtension + "/surveys/";
            public const string InsertEmbeddedDataFields = UrlExtension + "/surveys/{surveyId}/embeddeddatafields";
            public const string SendSurvey = UrlExtension + "/surveys/send/{surveyId}/";
        }

        public static class Distributions
        {
            public const string GetDistributions = UrlExtension + "/distributions";
            public const string CreateDistribution = UrlExtension + "/distributions";
            public const string CreateSMSDistribution = UrlExtension + "/distributions/sms";
            public const string ListSMSDistributions = UrlExtension + "/distributions/sms";
            public const string GetDistribution = UrlExtension + "/distributions/{distributionId}";
        }

        public static class MailingLists
        {
            public const string GetMailingList = UrlExtension + "/directories/{directoryId}/mailinglists/{mailingListId}";
            public const string GetMailingLists = UrlExtension + "/directories/{directoryId}/mailinglists";
            public const string ListContactsInMailingList = UrlExtension + "/directories/{directoryId}/mailinglists/{mailingListId}/contacts";
        }

        public static class MailingListContacts
        {
            public const string CreateContactInMailingList = UrlExtension + "/directories/{directoryId}/mailinglists/{mailingListId}/contacts";
            public const string GetContactInMailingList = UrlExtension + "/directories/{directoryId}/mailinglists/{mailingListId}/contacts/{contactId}";
        }

        public static class Libraries
        {
            public const string ListLibraries = UrlExtension + "/libraries";
        }
    }
}
