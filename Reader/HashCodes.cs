using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SavegameEditor.Reader
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal static class HashCodes
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal static Dictionary<uint, string> Read_Sound_h(string filePath, string sectionA = "", string sectionB = "", string sectionC = "")
        {
            Dictionary<uint, string> HashTable = new Dictionary<uint, string>();
            try
            {
                using (StreamReader streamReader = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read)))
                {
                    string input = streamReader.ReadToEnd();

                    string pattern = "#define([\\s])+([\\w]+)([\\s])+(0x[\\da-fA-F]{8,8})";
                    MatchCollection matchCollection = Regex.Matches(input, pattern);

                    if (matchCollection.Count > 0)
                    {
                        for (int i = 0; i < matchCollection.Count; i++)
                        {
                            input = matchCollection[i].ToString();
                            input = input.Replace("#define ", string.Empty);
                            Match match = Regex.Match(input, "([\\w]+)");
                            string label = match.ToString().Trim();
                            if ((sectionA.Length > 0 && label.StartsWith(sectionA, StringComparison.OrdinalIgnoreCase)) || (sectionB.Length > 0 && label.StartsWith(sectionB, StringComparison.OrdinalIgnoreCase)) || (sectionC.Length > 0 && label.StartsWith(sectionC, StringComparison.OrdinalIgnoreCase)))
                            {
                                GetAndAddObjectives(input, label, HashTable);
                            }
                            else if (sectionA.Length == 0 && sectionB.Length == 0)
                            {
                                GetAndAddObjectives(input, label, HashTable);
                            }
                            else if (sectionC.Length == 0)
                            {
                                GetAndAddObjectives(input, label, HashTable);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return HashTable;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private static void GetAndAddObjectives(string input, string label, Dictionary<uint, string> HashTable)
        {
            Match match2 = Regex.Match(input, "(0x[\\da-fA-F]{8,8})");
            uint hashCode = Convert.ToUInt32(match2.ToString().Trim(), 16);
            if (!HashTable.ContainsKey(hashCode))
            {
                //Add HashCode
                HashTable.Add(hashCode, label);
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
