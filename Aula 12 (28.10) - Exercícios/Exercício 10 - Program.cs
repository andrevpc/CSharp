Matriz matrix = new Matriz(3,3);
matrix = Matriz.Aleatoria(matrix);
Console.WriteLine(matrix);
// Console.WriteLine(Matriz.Transposta(matrix));

// Console.WriteLine(Matriz.Oposta(matrix));

// Console.WriteLine(Matriz.Nula(matrix));

// Console.WriteLine(Matriz.Identidade(matrix));
// Console.WriteLine(matrix.IsSquare());

// Console.WriteLine(matrix.IsIdentidade());
// matrix = Matriz.Identidade(matrix);
// Console.WriteLine(matrix);
// Console.WriteLine(matrix.IsIdentidade());

// Console.WriteLine(matrix.IsDiagonal());
// matrix = Matriz.Diagonal(matrix);
// Console.WriteLine(matrix);
// Console.WriteLine(matrix.IsDiagonal());

// Console.WriteLine(matrix + Matriz.Identidade(matrix));

// Console.WriteLine(matrix - Matriz.Identidade(matrix));

Matriz matrix1 = Matriz.Aleatoria(matrix);
Console.WriteLine(matrix1);
Console.WriteLine(matrix * matrix1);