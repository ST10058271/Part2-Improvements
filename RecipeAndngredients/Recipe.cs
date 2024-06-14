
internal class Recipe
{
    private string? name;

    public Recipe(string? name)
    {
        this.name = name;
    }

    public string? Name { get; internal set; }

    internal void AddIngredient(Ingredient ingredient)
    {
        throw new NotImplementedException();
    }

    internal void AddStep(string? step)
    {
        throw new NotImplementedException();
    }

    internal void Clear()
    {
        throw new NotImplementedException();
    }

    internal void Display()
    {
        throw new NotImplementedException();
    }

    internal void DisplayTotalCalories()
    {
        throw new NotImplementedException();
    }

    internal void Reset()
    {
        throw new NotImplementedException();
    }

    internal void Scale(double factor)
    {
        throw new NotImplementedException();
    }
}