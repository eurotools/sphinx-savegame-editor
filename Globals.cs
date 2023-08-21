namespace SavegameEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal static class Globals
    {
        internal const uint MaximumObjectives = 1700;
        internal const uint MaximumInventoryItems = 200;
        internal const uint MaximumAbilityItems = 50;
        internal const uint MaximumSavedTriggers = 100;
        internal const uint MaximumInventoryNotes = 10;
        internal const string GameLabel = "SPHINX";
        internal static string HashCodesFilePath = @"X:\Sphinx\Albert\Hashcodes.h";

        //-------------------------------------------------------------------------------------------------------------------------------
        internal static uint GetMaxValueArray(uint[] arr)
        {
            // Initialize maximum element
            uint max = 0;

            // Traverse array elements from second and
            // compare every element with current max
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
