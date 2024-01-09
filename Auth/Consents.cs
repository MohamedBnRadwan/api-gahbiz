using System.Reflection;

namespace GahbizWepApi.Auth
{
    public enum Modules
    {
        Branches,
        Leads,
        Services,
        Files,
        ServiceFiles,
        Clients,
        ClientFiles,
        WebIntro,
        WebAbout,
        WebService,
        WebServiceOffers,
        WebContact,
    }

    public enum UserType
    {
        Admin,
        User,
        Client
    }

    public static class UserPermission
    {
        public const string View = "View";
        public const string Create = "Create";
        public const string Update = "Update";
        public const string Delete = "Delete";

        public static List<string> GenerateAllPermissions()
        {
            var allPermissions = new List<string>();

            var modules = Enum.GetNames(typeof(Modules));

            foreach (var module in modules)
                allPermissions.AddRange(PermissionsList(module));

            return allPermissions;
        }

        public static List<string> PermissionsList(string module)
        {
            return new List<string>()
            {
                $"{module}.{View}",
                $"{module}.{Create}",
                $"{module}.{Update}",
                $"{module}.{Delete}|"
            };
        }
    }
}
