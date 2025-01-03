﻿using System.DirectoryServices;
using System.Runtime.Versioning;

namespace Admin_SiapKuliah_backend.Helper
{
    public class LDAPAuthentication(IConfiguration configuration)
    {
        readonly string adPath = configuration["Key:linkLDAP"]!;

        [SupportedOSPlatform("windows")]
        public bool IsAuthenticated(string username, string password)
        {
            return true;
        }

        [SupportedOSPlatform("windows")]
        public string GetMail(string username)
        {
            return username;
        }

        [SupportedOSPlatform("windows")]
        public string GetDisplayName(string username)
        {
            return username;
        }
    }
}
