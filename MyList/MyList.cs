using System;

public class MyList<T>
{
    private T[] _items;
    private int _count;
  
    public MyList()
    {
        _items = new T[4];//Capacity 4;
        _count = 0;
    }
    
    public int Count
    {
        get { return _count; }
    }
    
    public int Capacity
    {
        get { return _items.Length; }
    }
    public void Add(T item)
    {
        if(_count == _items.Length)
        {
            Resize();
            _items[_count] = item;
            _count++;
        }
        else
        {
            _items[_count] = item;
            _count ++;
        }
    }
    private void Resize()
    {
        int newCapacity = _items.Length * 2;
        T[] newItems = new T[newCapacity];
        for(int i = 0; i < _count; i++)
        {
            newItems[i] = _items[i];
        }
        _items = newItems;
    }
    public void RemoveAtIndex(int index)
    {
        if(index < 0 || index > _count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Invalid Index");
        }
        
        for(int i = index; i < _count - 1; i++)
        {
            _items[i] = _items[i + 1];
        }
        _count --;
        _items[_count] = default!;//Без ! компілятор свариться, думаю ми не знаємо за null;
    }
    public bool Remove(T item)
    {
        for(int i = 0; i < _count; i++)
        {
            if(object.Equals(_items[i], item))
            {
                RemoveAtIndex(i);
                return true;
            }
        }
        return false;
    }
    public void ShowAll()
    {
        for(int i = 0; i < _count; i++)
        {
            Console.WriteLine(_items[i]);
        }
    }
}