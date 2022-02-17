﻿namespace SES.Projects.Sanitarium.Chameleon
{
    using System.IO;
    using System.Linq;

    public static class StringExtensions
    {
        public static string SearchPatternFromFileName(this string fullName)
        {
            var shortName = Path.GetFileName(fullName);
            var fileNameItems = shortName.Split('.');
            var searchPattern = (fileNameItems.FirstOrDefault() ?? string.Empty) + "*";
            foreach (var fileNameItem in fileNameItems.Skip(1))
            {
                searchPattern += ("." + fileNameItem);
            }

            return searchPattern;
        }

        public static string AddUserNameToFileName(this string fullName, string userName)
        {
            var directoryName = Path.GetDirectoryName(fullName);
            var shortName = Path.GetFileName(fullName);
            var extension = Path.GetExtension(fullName);
            shortName = shortName.Substring(0, shortName.LastIndexOf('.')) + "_" + userName + extension;

            return Path.Combine(directoryName, shortName);
        }
    }
}
