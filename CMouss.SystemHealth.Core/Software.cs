namespace CMouss.SystemHealth.Core
{
    public class Software
    {

        #region Name
        string name;
        public string Name { get => name; set => name = value; }
        #endregion

        #region Version
        string version;
        public string Version { get => version; set => version = value; }
        #endregion

        #region RunMode
        string runMode;
        public string RunMode { get => runMode; set => runMode = value; }
        #endregion

        #region Status
        string status;
        public string Status { get => status; set => status = value; }
        #endregion






        #region Attributes
        List<Attribute> attributes;
        public List<Attribute> Attributes { get => attributes; set => attributes = value; }
        #endregion


    }
}
