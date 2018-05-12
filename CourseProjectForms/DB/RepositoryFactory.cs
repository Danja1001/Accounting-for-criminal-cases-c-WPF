using CourseProjectForms.DB.Interfaces;


namespace CourseProjectForms.DB
{
    public class RepositoryFactory
    {
        public static IRepository Create()
        {
            var databaseContext = new DatabaseContext("lawyerAgencyDatabase");
            return new RepositoryComposition(databaseContext);
        }
    }
}