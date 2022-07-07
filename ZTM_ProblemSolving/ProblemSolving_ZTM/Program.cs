using ProblemSolving_ZTM;

//string testString = "abcdef";
//string outputString = ReverseString.Reverse(testString);
//Console.WriteLine(outputString);

//Solution solution = new Solution();
//solution.IsValid("()[]{}");

//LinkedList linkedList = new LinkedList();
////linkedList.StackOverFlow();
//linkedList.Append("hi");
//linkedList.Append("hello");
//linkedList.Append("shiv");
//linkedList.Append("shan");
//linkedList.ShowAll();

// Implement stack using single queue
MyStack myStack = new MyStack();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
Console.WriteLine($"{myStack.Pop()}"); 
Console.WriteLine($"{myStack.Top()}"); 
Console.WriteLine($"{myStack.Empty()}"); 