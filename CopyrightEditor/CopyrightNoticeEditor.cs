using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CopyrightEditor
{
    public class CopyrightNoticeEditor
    {
        public string SourceFolderPath { get; set; }
        public string ExistingCopyrightNotice { get; set; }
        public string NewCopyrightNotice {  get; set; }
        public bool bFindExisitingCopyrightNotice { get; set; }
        public bool bAddCopyrightNoticeIfNotFound { get; set; }
        public string SupportedFilesExtensions { get; set; }
        public bool bAddEmptyLineAfterCopyrightNotice { get; set; }
        public List<string> Errors { get; set; }
        public int UpdatedFilesNumber { get; set; }

        public CopyrightNoticeEditor()
        {
            Errors = new List<string>(); 
        }

        public bool HasValidConfig()
        {
            if (bFindExisitingCopyrightNotice)
            {
                return !string.IsNullOrEmpty(SourceFolderPath) && !string.IsNullOrEmpty(NewCopyrightNotice);
            }

            return !string.IsNullOrEmpty(SourceFolderPath) && !string.IsNullOrEmpty(ExistingCopyrightNotice) &&
                   !string.IsNullOrEmpty(NewCopyrightNotice);
        }

        public void TraverseDirectories(string currentDirectory)
        {
            try
            {
                // Process files in the current directory
                ProcessFiles(currentDirectory);

                // Recursively traverse subdirectories
                string[] subDirectories = Directory.GetDirectories(currentDirectory);

                foreach (string subDirectory in subDirectories)
                {
                    TraverseDirectories(subDirectory);
                }
            }
            catch (Exception ex)
            {
                string error = $"[ERROR] ({currentDirectory}) : {ex.Message}";
                Errors.Add(error);
            }
        }

        void ProcessFiles(string directory)
        {
            try
            {
                string[] files = Directory.GetFiles(directory);
                foreach (string file in files)
                {
                    string fileExtension = Path.GetExtension(file);

                    string[] ValidExtensions = SupportedFilesExtensions.Split(',');

                    foreach (string extension in ValidExtensions)
                    {
                        if (fileExtension.Equals(extension, StringComparison.OrdinalIgnoreCase))
                        {
                            // Process each file     
                            WriteNewCopyrightNotice(file);

                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string error = $"[ERROR] ({directory}) : {ex.Message}";
                Errors.Add(error);
            }
        }

        public void WriteNewCopyrightNotice(string filePath)
        {
            string fileContent = File.ReadAllText(filePath);

            if (bFindExisitingCopyrightNotice)
            {
                string pattern = @"^(//.*?$|/\*.*?\*/)";
                Match firstCommentMatch = Regex.Match(fileContent, pattern, RegexOptions.Multiline | RegexOptions.Singleline);

                if (firstCommentMatch.Success)
                {
                    // Remove the matched comment
                    string updatedContent = fileContent.Remove(firstCommentMatch.Index, firstCommentMatch.Length);

                    // Add new copyright notice
                    if (bAddEmptyLineAfterCopyrightNotice)
                    {
                        updatedContent = NewCopyrightNotice + Environment.NewLine + updatedContent;
                    }
                    else
                    {
                        updatedContent = NewCopyrightNotice + updatedContent;
                    }

                    // Write the updated content back to the file
                    File.WriteAllText(filePath, updatedContent);
                    UpdatedFilesNumber += 1;
                }
                else if (bAddCopyrightNoticeIfNotFound)
                {
                    // Add new copyright notice if no existing notice is found
                    string updatedContent;

                    if (bAddEmptyLineAfterCopyrightNotice)
                    {
                        updatedContent = NewCopyrightNotice + Environment.NewLine + fileContent;
                    }
                    else
                    {
                        updatedContent = NewCopyrightNotice + fileContent;
                    }

                    // Write the updated content back to the file
                    File.WriteAllText(filePath, updatedContent);
                    UpdatedFilesNumber += 1;
                }
            }
            else
            {
                string pattern = Regex.Escape(ExistingCopyrightNotice);
                Match commentMatch = Regex.Match(fileContent, pattern, RegexOptions.Multiline);

                if (commentMatch.Success)
                {
                    // Replace the existing copyright notice with the new one
                    string updatedContent = fileContent.Replace(commentMatch.Value, NewCopyrightNotice);

                    // Write the updated content back to the file
                    File.WriteAllText(filePath, updatedContent);
                    UpdatedFilesNumber += 1;
                }
                else if (bAddCopyrightNoticeIfNotFound)
                {
                    // Add new copyright notice if no existing notice is found
                    string updatedContent;

                    if (bAddEmptyLineAfterCopyrightNotice)
                    {
                        updatedContent = NewCopyrightNotice + Environment.NewLine + fileContent;
                    }
                    else
                    {
                        updatedContent = NewCopyrightNotice + fileContent;
                    }

                    // Write the updated content back to the file
                    File.WriteAllText(filePath, updatedContent);
                    UpdatedFilesNumber += 1;
                }
            }
        }

        private void ClearErrors()
        {
            Errors.Clear();
        }

        public void ChangeCopyrightNotice()
        {
            if (HasValidConfig())
            {
                UpdatedFilesNumber = 0;
                ClearErrors();

                TraverseDirectories(SourceFolderPath);
            }  
        }
    }
}

