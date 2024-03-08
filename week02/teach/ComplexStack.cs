public static class ComplexStack {

    public static void Main(){
        bool resp = DoSomethingComplicated("(a == 3 or (b == 5 and c == 6))");


    }
    public static bool DoSomethingComplicated(string line) {
        var stack = new Stack<char>();
        foreach (var item in line) {
            if (item is '(' or '[' or '{') {
                stack.Push(item);
            }
            else if (item is ')') {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }
            else if (item is ']') {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }
            else if (item is '}') {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        return stack.Count == 0;
    }

    public static void Answer(bool resp){
                if(resp){
            Console.WriteLine("Your openings and ending are perfect.");
        }
        else {
            Console.WriteLine("There is something missing.");
        }
    }
}