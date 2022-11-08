public class Matrix
{
    public Matrix(int row, int col)
    {
        this.Row = row;
        this.Col = col;

        int[][] matrix = new int[this.Row][];
        for (int i = 0; i < this.Row; i++)   
            matrix[i] = new int[this.Col];

        this.items = matrix;
    }

    public int Row { get; private set; }
    public int Col { get; private set; }
    public int[][] items { get; set; }

    private bool isSquare() => this.Row == this.Col;
    public static Matrix T(Matrix matrix)
    {
        Matrix newMatrix = new Matrix(matrix.Col, matrix.Row);
        for (int i = 0; i < matrix.Col; i++)
            for (int j = 0; j < matrix.Row; j++)
                newMatrix.items[i][j] = matrix.items[j][i];

        return newMatrix;
    }
    public static Matrix Opposite(Matrix matrix)
    {
        Matrix newMatrix = Matrix.Copy(matrix);
        for (int i = 0; i < matrix.Row; i++)
            for (int j = 0; j < matrix.Col; j++)
                newMatrix.items[i][j] = -matrix.items[i][j];
        
        return newMatrix;
    }
    public static Matrix Null(Matrix matrix)
    {
        Matrix newMatrix = Matrix.Copy(matrix);
        for (int i = 0; i < matrix.Row; i++)
            for (int j = 0; j < matrix.Col; j++)
                newMatrix.items[i][j] = 0;
        
        return newMatrix;
    }
    public bool IsIdentity()
    {
        if (!this.isSquare()) return false;

        bool isIdentity = true;
        for (int i = 0; i < this.Row; i++)
            for (int j = 0; j < this.Col; j++)
            {
                if (i == j && this.items[i][j] != 1)
                {
                    isIdentity = false;
                    break;
                }
                else if (i != j && this.items[i][j] != 0)
                {
                    isIdentity = false;
                    break;
                }
            }
        
        return isIdentity;
    }
    public bool IsDiagonal()
    {
        if (!this.isSquare()) return false;
        
        bool isDiagonal = true;
        for (int i = 0; i < this.Row; i++)
            for (int j = 0; j < this.Col; j++)
                if (i != j && this.items[i][j] != 0)
                {
                    isDiagonal = false;
                    break;
                }
        
        return isDiagonal;
    }
    public bool IsUnique()
    {
        if (!this.isSquare()) return false;
        
        bool isUnique = true;
        int number = int.MaxValue;
        for (int i = 0; i < this.Row; i++)
            for (int j = 0; j < this.Col; j++)
                if (i != j)
                {
                    if (number == int.MaxValue)
                        number = this.items[i][j];
                    
                    else if (number != this.items[i][j])
                        isUnique = false;
                }
        
        return isUnique;
    }
    public bool IsSymmetrical()
    {
        if (!this.isSquare()) return false;
        
        Matrix transpose = Matrix.T(this);

        return this == transpose;
    }
    public bool IsAntiSymmetric()
    {
        if (!this.isSquare()) return false;
        
        Matrix transpose = Matrix.T(this);
        Matrix opposite = Matrix.Opposite(this);
        return opposite == transpose;
    }
    public void git (int value)
    {
        for (int i = 0; i < this.Row; i++)
            for (int j = 0; j < this.Col; j++)
                this.items[i][j] = value;
    }
    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Row != b.Row || a.Col != b.Col)
            throw new Exception();

        Matrix newMatrix = Matrix.Copy(a);
        for (int i = 0; i < a.Row; i++)
            for (int j = 0; j < a.Col; j++)
                newMatrix.items[i][j] += b.items[i][j];
        
        return newMatrix;
    }
    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Row != b.Row || a.Col != b.Col)
            throw new Exception();

        Matrix newMatrix = Matrix.Copy(a);
        for (int i = 0; i < a.Row; i++)
            for (int j = 0; j < a.Col; j++)
                newMatrix.items[i][j] -= b.items[i][j];
        
        return newMatrix;
    }
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Row != b.Row || a.Col != b.Col)
            throw new Exception();

        Matrix newMatrix = Matrix.Copy(a);
        for (int i = 0; i < a.Row; i++)
            for (int j = 0; j < a.Col; j++)
                newMatrix.items[i][j] *= b.items[i][j];
        
        return newMatrix;
    }
    public static bool operator ==(Matrix a, Matrix b)
    {
        bool state = true;
        if (a.Row != b.Row || a.Col != b.Col)
            return false;

        for (int i = 0; i < a.Row; i++)
            for (int j = 0; j < a.Col; j++)
                if(a.items[i][j] != b.items[i][j])
                    state = false;
        
        return state;
    }
    public static bool operator !=(Matrix a, Matrix b)
    {
        bool state = true;
        if (a.Row != b.Row || a.Col != b.Col)
            return false;

        for (int i = 0; i < a.Row; i++)
            for (int j = 0; j < a.Col; j++)
                if(a.items[i][j] == b.items[i][j])
                    state = false;
        
        return state;
    }
    public static Matrix Copy(Matrix matrix)
    {
        Matrix newMatrix = new Matrix(matrix.Row, matrix.Col);

        for (int i = 0; i < matrix.Row; i++)
            for (int j = 0; j < matrix.Col; j++)
                newMatrix.items[i][j] = matrix.items[i][j];

        return newMatrix;
    }
    public override string ToString()
    {
        string matrixStr = "";

        for (int i = 0; i < this.Row; i++)
        {
            for (int j = 0; j < this.Col; j++)
                matrixStr += $"{this.items[i][j]} ";
            
            matrixStr += "\n";
        }
        
        return matrixStr;
    }
}