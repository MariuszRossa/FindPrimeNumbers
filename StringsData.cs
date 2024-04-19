namespace FindPrimeNumbers
{
    public static class StringsData
    {
        #region File 
        public const string FileName = "PrimeNumer "; 
        public const string FileType = ".xml ";
        #endregion

        #region Error messeges
        public const string ErrorSave = "Error with file creation steep, \r\nError: \r\n" ; 
        public const string ErrorAddSave = "Error with adding data to existing file, \r\nError: \r\n" ;

        public const string ErrorFindingPrimeNb = "This cycle failed to find a prime number, calculation stopped.";
        #endregion

        #region Cycle time configuration
        public const int CycleDurationSec = 5;// 120;
        public const int CycleWaitTimeSec = 0;// 60;
        #endregion
    }
}
