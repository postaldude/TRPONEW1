using System.Runtime.InteropServices;

namespace TRPONEW.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Posts
        {
            public static readonly string GetAll = $"{Base}/posts";

        }
    }
}