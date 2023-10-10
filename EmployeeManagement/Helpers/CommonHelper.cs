using EmployeeManagement.Helpers.EmployeeHelper;
using EmployeeManagement.Models.Employee;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeManagement.Helpers
{
    /// <summary>
    /// Class conftains common functions which can be used across this 
    /// and new project
    /// </summary>
    public static class CommonHelper
    {
        /// <summary>
        /// Checks if the given string is Valud Int or not
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsValidInt(string input)
        {
            return Int32.TryParse(input, out int result);
        }

        /// <summary>
        /// Checks if given field is empty or not.
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns></returns>
        public static bool IsNotEmptyText(string inputText)
        {
            return !string.IsNullOrEmpty(inputText);
        }

        /// <summary>
        /// Checks if given email is valid or not
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, pattern);
        }

        /// <summary>
        /// Tells if any value is selected from Drop down or not
        /// </summary>
        /// <param name="comboBox"></param>
        /// <returns></returns>
        public static bool IsValueSelected(ComboBox comboBox)
        {
            return comboBox.SelectedIndex >= 0;
        }

        /// <summary>
        /// Extension method if given string matches with any of the string.
        /// </summary>
        /// <param name="inputText"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool IsOneOf(this string inputText, params string[] values)
        {
            foreach (string value in values)
            {
                if (inputText.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }

        public static string DecodeFromBase64(this string input)
        {
            // Convert the bytes back to a string using UTF-8 encoding
            return Encoding.UTF8.GetString(Convert.FromBase64String(input));

        }

    }

    public static class ExportToCSV<T>
    {
        static StringBuilder strBuilder;
        public static List<T> objList;
        public static string ExportData()
        {
            string filename = EmployeeConstants.FileSavepath + "export_" + System.DateTime.Now.ToString("ddmmyyyyhhss") + ".csv";
            strBuilder = new StringBuilder();
            try
            {
                foreach (PropertyInfo propInfo in objList[0].GetType().GetProperties())
                {
                    strBuilder.Append(propInfo.Name.ToString() + ",");
                }
                foreach (T obj in objList)
                {
                    strBuilder.AppendLine();
                    foreach (PropertyInfo propInfo in objList[0].GetType().GetProperties())
                    {
                        strBuilder.Append(propInfo.GetValue(obj).ToString() + ",");
                    }
                }
                CheckAndCreateDirectory();
                File.WriteAllText(filename, strBuilder.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{EmployeeConstants.ErrorExportingData}{filename}. Reason - {ex.Message}");
            }

            return filename;
        }

        private static void CheckAndCreateDirectory()
        {
            string path = EmployeeConstants.FileSavepath;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

        }
    }
}
