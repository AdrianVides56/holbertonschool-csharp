enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog (string dname, float dage, string downer, Rating drating)
    {
        name = dname;
        age = dage;
        owner = downer;
        rating = drating;
    }
}
