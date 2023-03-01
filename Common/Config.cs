namespace Common
{
    public static class Config
    {
        public static string DatabasePath { get; } = "D:/work/pbsw/large-systems/database.db";
        public static string DataSourcePath { get; } = "D:/work/pbsw/large-systems/source/maildir";
        public static int NumberOfFoldersToIndex { get; } = 10; // Use 0 or less for indexing all folders
    }
}