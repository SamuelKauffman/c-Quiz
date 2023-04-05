using System;

class Quiz { 

    static public void Main(String[] args) 

    { 

         double score = 0;
        Console.WriteLine("Welcome to your quiz! Dumbass…"); 
        Console.WriteLine("Type start to start."); 
        string start = Console.ReadLine();

          Console.WriteLine("Nice you can type, first question: "); 
            Console.WriteLine("Declare a number called num1 and make it equal 0. Hint: No decimal."); 
            String intDeclaration = Console.ReadLine();
             if(intDeclaration == "int num1 = 0;"){
             Console.WriteLine("Correct!"); 
              ++score;
}
else{
         Console.WriteLine("Wrong :("); 
          Console.WriteLine("Answer: int num1 =0;");
}
        Console.WriteLine("2nd Question: How would you type \"Hello World\" to the console?");
        String helloWorld = Console.ReadLine();
if(helloWorld == "System.Console.WriteLine(\"Hello World\");"){
 Console.WriteLine("Correct!");
++score;
}
else{
Console.WriteLine("Wrong");
Console.WriteLine("Answer: System.Console.WriteLine(\"Hello World\");");
}

      Console.WriteLine("3rd question: Declare a character with the name firstLetter and make it equal to s.");
       string firstName = Console.ReadLine();

if(firstName == "char firstLetter = \'s\';"){
       Console.WriteLine("Correct!");
        ++score;
    } 
else{
      Console.WriteLine("Wrong!!");
       Console.WriteLine("Answer: char firstLetter = \'s\';");
}

      Console.WriteLine("Last question: What would you put at the top of your code if you wanted to use the method System.Console.WriteLine by typing Console.WriteLine?"); 
         String system = Console.ReadLine();
if(system == "using System;"){
       Console.WriteLine("Correct!");
        ++score;
    } 
else{
      Console.WriteLine("Wrong…");
       Console.WriteLine("Answer: using System;");
}

Console.WriteLine("Nice you finished you quiz!");
double result = score/4 * 100;

Console.WriteLine("Your final score is: " + result + "%");

if(score > 75){
Console.WriteLine("You passed!");
}
else{
Console.WriteLine("You failed… Retake it now fucker.");
}
} 
}

