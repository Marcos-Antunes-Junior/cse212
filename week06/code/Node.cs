using NuGet.Frameworks;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }


    public void Insert(int value)
    {


        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
            {
                Left = new Node(value);
            }
            else
            {
                var currentValue = new Node(value);
                if (Left.Data != currentValue.Data)
                {
                    Left.Insert(value);
                }

            }



        }
        else
        {
            // Insert to the right
            if (Right is null)
            {
                Right = new Node(value);
            }
            else
            {
                var currentValue = new Node(value);
                if (Right.Data != currentValue.Data)
                {
                    Right.Insert(value);
                }


            }

        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }

        if (value < Data)
        {
            if (Left != null)
            {
                return Left.Contains(value);
            }
            else
            {
                return false;
            }

        }


        if (Right != null)
        {
            return Right.Contains(value);
        }
        else
        {
            return false;
        }


    }

    public int GetHeight()
    {
        int getLeftHeight = Left?.GetHeight() ?? 0;
        int getRightHeight = Right?.GetHeight() ?? 0;

        if (getLeftHeight > getRightHeight)
        {
            return getLeftHeight + 1;

        }
        else
        {
            return getRightHeight + 1;
        }
    }
}