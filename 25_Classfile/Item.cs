class Item
{
    string mName = "none";
    int mGold;

    public Item(string _Name, int _Gold)
    {
        mName = _Name;
        mGold = _Gold;
    }

    public string Name
    {
        get
        {
            return mName;
        }

        set
        {
            mName = value;
        }
    }

    public int Gold
    {
        get
        {
            return mGold;
        }

        set
        {
            mGold = value;
        }
    }

}