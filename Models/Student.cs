namespace StudentGradeSystem;

abstract class Student
{
    #region Protected fields
    protected string _name;
    protected string _username;
    protected string _password;
    protected string _institudeType;
    #endregion

    #region Public Properties
    public string Name
    {
        get { return _name; }
        protected set { _name = value; }
    }
    public string Institude_Type
    {
        get { return _institudeType; }
        protected set { _institudeType = value; }
    }
    public string UserName
    {
        get { return _username; }
        protected set { _username = value; }
    }
    public string Password
    {
        get { return _password; }
        protected set { _password = value; }
    }
    #endregion

    #region Abstract Methods
    public abstract void DisplayInfo();
    #endregion
}
