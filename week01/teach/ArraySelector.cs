public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        // var intResult = select;
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        List<int> selectedList = new List<int>();

        //manage element array index to be stored
        int count = 0;

        foreach(int selector in select){
            if(selector == 1){
               if (count < list1.Length) selectedList.Add(list1[count]);
            }
            else if(selector == 2){
               if (count < list2.Length) selectedList.Add(list2[count]);
            }
            count += 1;
        }

        int[] selectedArray = selectedList.ToArray();
        return selectedArray;
    }
}