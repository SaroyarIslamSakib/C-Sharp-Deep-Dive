#region Array
//One Dimensional array
int[] IntArray = new int[5];
int[] IntArray2 = { 10, 20, 30, 40, 50 };

//2-Dimensional array
int[,] Array3 = new int[2, 3];

//Jugged Array
int[][] Array4 = new int[3][];
Array4[0] = new[] { 10, 20, 30 };
Array4[1] = new[] { 10, 20, 30 };
Array4[2] = new[] { 10, 20, 30 };
#endregion
#region Lists
List<int> numbers = new() { 10, 20, 30, 40, 50, 60 };
List<int> temp = new() { 70, 80 };
numbers.AddRange(temp);

numbers.ForEach(x => Console.WriteLine(x));
#endregion