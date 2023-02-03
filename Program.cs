static string[] GetLessThan4(string[] input)
{
    var counter = 0;
    var newArray = new string[input.Length];
    foreach(var element in input)
    {
        if (element.Length <= 3) 
        {
            newArray[counter] = element;
            counter++;
        }
        
    }
    Array.Resize<string>(ref newArray, counter);

    return newArray;
}

var array = new string[]{"hello", "2", "world", ":-)"};

var output = GetLessThan4(array);

foreach(var e in output){
    Console.Write(e + " ");
}