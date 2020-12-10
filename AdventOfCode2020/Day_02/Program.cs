using static System.Console;

WriteLine("Hello World!");

record DataA(int A, int B);
record DataB
{
    public int A { get; init; }
    public int B { get; init; }
}