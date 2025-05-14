namespace InstantiatorPackage
{
    public class InstantiatorSettings
    {
        /// <summary>
        /// You can modify this variable directly in the script so that any team member using the 
        /// 'Instantiator.GetInstance' method (not it's overloads) will follow your naming conventions 
        /// for singleton instance variables. </summary>
        public const string DEFAULT_SINGLETON_VARIABLE_NAME = "Instance";
    }
}