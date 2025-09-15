namespace generic;

public class generic_class<T>
{
    private T data;
    public generic_class(T data)
    {
        this.data = data;
    }
    public T GetData()
    {
        return data;
    }

}
